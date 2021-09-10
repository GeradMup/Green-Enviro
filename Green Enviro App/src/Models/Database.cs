using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Firebase.Storage;
using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;
using System.Net;
using System.Data.SqlClient;
using System.Dynamic;
using ICSharpCode.Decompiler.IL;

namespace Green_Enviro_App
{

	/// <summary>
	///  Class for handling all the Database related work
	///   <br />
	/// </summary>
	public class Database
	{
		static string path = Path.GetDirectoryName(Path.GetDirectoryName(Directory.GetCurrentDirectory()));
		static string _connection_string = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + path + @"\Green Enviro Data.mdf;Integrated Security=True;Connect Timeout=30";

		static SqlConnection _connection;
		static SqlCommand _command;
		const string DATABASE_EXCEPTION = "Database Exception!";
		const string DATABASE_INSERTION_EXCEPTION = "Database insertion exception";
		const string DATABASE_SELECTING_EXCEPTION = "Database selecting exception";
		/// <summary>Initializes a new instance of the <see cref="Database" /> class.</summary>
		public Database()
		{
			//Sets up the first Database which stores the URL of the actual database file
		}
		// ****************************************************************************************************************

		public void UploadData(Main_Form _main)
		{
			//_main_form = _main;    
			OpenDatabase();
			InsertIntoDB();
		}

		//Loads of Tutorials on w3schools.com

		private void OpenDatabase()
		{
			if (_connection != null)
			{
				if (_connection.State == ConnectionState.Open)
				{
					return;
				}
			}

			try
			{
				_connection = new SqlConnection(_connection_string);
				_connection.Open();
				_command = _connection.CreateCommand();
				_command.CommandType = CommandType.Text;
			}
			catch (Exception ex)
			{
				MessageBox.Show("Failed To open database file: " + ex.Message);
			}
		}

		//Checks if a Database connection was made and tries to close it before exiting the application.
		private static void CloseDatabase()
		{
			if (_connection == null)
			{
				return;
			}

			if (_connection.State == ConnectionState.Open)
			{
				_connection.Close();
				_connection = null;
			}
		}

		private void InsertIntoDB()
		{

			//Check that the DB is open before trying to make an insertion
			OpenDatabase();

			_command.CommandText = "insert into FirstTable (Id, Name) values (22, 'Gerry')";
			try
			{
				_command.ExecuteNonQuery();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Failed To Connect To DB: " + ex.Message);
			}
		}

		/// <summary>Selects all values from the database given the table name.</summary>
		/// <param name="_tableName">Name of the table.</param>
		/// <returns>A DataTable containing all the data read from the table.</returns>
		public DataTable selectAll(Tables _tableName)
		{
			DataTable _table = new DataTable();
			string tableName = enumToString<Tables>(_tableName);
			try
			{
				OpenDatabase();
				_command.CommandText = "Select * From " + tableName;

				SqlDataAdapter sda = new SqlDataAdapter(_command.CommandText, _connection);
				sda.Fill(_table);
				CloseDatabase();
			}
			catch (Exception ex)
			{
				throw new Exception(DATABASE_SELECTING_EXCEPTION,ex);
			}
			return _table;
		}

		/// <summary>Selects specific elements from the database based on the table name and filterValue.</summary>
		/// <typeparam name="T">Template type describing the column name.</typeparam>
		/// <param name="_tableName">The name of the table from which the element must be read.</param>
		/// <param name="_columnName">A template value describing the name of the column to use for filtering.</param>
		/// <param name="filterValue">The value to use for filtering the database.</param>
		/// <returns>A DataTable with the selected values.</returns>
		/// <exception cref="System.Exception">If an error occurs while trying read from the database.</exception>
		public DataTable select<T>(Tables _tableName, T _columnName, string filterValue)
		{
			string tableName = enumToString<Tables>(_tableName);
			string columnName = enumToString<T>(_columnName);

			string filterExpression = columnName + " = '" + filterValue + "'";
			DataTable _table = new DataTable();
			try
			{
				OpenDatabase();
				_command.CommandText = "Select * From " + tableName + " where " + filterExpression;

				SqlDataAdapter sda = new SqlDataAdapter(_command.CommandText, _connection);
				sda.Fill(_table);

				CloseDatabase();
			}
			catch (Exception ex)
			{
				throw new Exception(DATABASE_EXCEPTION, ex);
			}
			return _table;
		}
		// Insertion function adding new users to the database yet not updating the database
		public void InsertNewUser(string username, string password, string email_address, int permission_level)
		{

			OpenDatabase();

			//Here is two ways to insert the new user into the database command, the commented line on line 140 is the other method
			_command.Parameters.AddWithValue("@Username", username);
			_command.Parameters.AddWithValue("@Password", password);
			_command.Parameters.AddWithValue("@Email", email_address);
			_command.Parameters.AddWithValue("@PermissionLevel", permission_level);
			string _insertion_command = "Insert into Users (Username,Password,Email,PermissionLevel) values (@Username,@Password,@Email,@PermissionLevel)";

			//string _insertion_command = "Insert into Users (Username,Password,Email) values ('"+username+ "','" + password + "','" + email_address + "')";

			_command.CommandText = _insertion_command;
			//Determine if the command was succesfully executed or not 
			try
			{
				Int32 rowsAffected = _command.ExecuteNonQuery();
				Console.WriteLine("RowsAffected: {0}", rowsAffected);
			}
			catch (Exception ex)
			{
				MessageBox.Show("Failed to Insert into DB : " + ex.Message);
			}

			CloseDatabase();
		}

		public Int32 DeleteFromDatabase(string _table, string _condition)
		{
			OpenDatabase();
			//The Delete command goes as follow
			string _deletion_cmd = "delete from " + _table + " where " + _condition;
			Int32 rowsAffected = 0;
			//Making the SQL command
			_command.CommandText = _deletion_cmd;
			//View if the changes where succesfully done on the console
			try
			{
				rowsAffected = _command.ExecuteNonQuery();
				Console.WriteLine("RowsAffected: {0}", rowsAffected);
			}
			catch (Exception ex)
			{
				MessageBox.Show("Failed to Delete into DB : " + ex.Message);
			}

			CloseDatabase();
			return rowsAffected;
		}


		/// <summary>Adds a new entry into the database specified by the table name.</summary>
		/// <typeparam name="T"></typeparam>
		/// <param name="_tableName">The table.</param>
		/// <param name="_values">A array of strings with the values that need to be added to the database. The array must have the same order as the order in which the columns appear in the database.</param>
		/// <returns>
		///   <br />
		/// </returns>
		public Int32 insert(Tables _tableName, string[] _values)
		{
			OpenDatabase();

			string tableName = enumToString<Tables>(_tableName);
			string tableColumns = getTableColumns(_tableName);
			string values = formatValuesForInsertion(_values);
			string insertionCmd = "insert into " + tableName + " (" + tableColumns + ") values (" + values + ")";
			//Making the SQL command

			_command.CommandText = insertionCmd;
			Int32 rowsAffected;
			try
			{
				rowsAffected = _command.ExecuteNonQuery();
			}
			catch (Exception ex)
			{
				throw new Exception(DATABASE_INSERTION_EXCEPTION, ex);
			}

			CloseDatabase();
			return rowsAffected;
		}

		/// <summary>Updates values in a database table.</summary>
		/// <typeparam name="TableName">The type of the table name.</typeparam>
		/// <typeparam name="TableColumn">The type of the table column.</typeparam>
		/// <param name="_tableName">Name of the table.</param>
		/// <param name="columns">An arrary of the columns to be updated.</param>
		/// <param name="_identifierColumn">The table column to be used as the identifier.</param>
		/// <param name="identifier">The identifier value.</param>
		/// <param name="values">The values to be updated in the table.</param>
		/// <returns>Int32 value representing how many table rows were updated.</returns>
		public Int32 updateDatabase<TableColumn>(Tables _tableName, 
			TableColumn[] columns, TableColumn _identifierColumn, string identifier, string[] values)
		{
			string tableName = enumToString<Tables>(_tableName);
			string identifierColumn = enumToString<TableColumn>(_identifierColumn);
			string columnValuePairs = formatValuesForUpdating<TableColumn>(columns, values);

			string updateCommandText = "UPDATE " + tableName + " set " + columnValuePairs +
				" where " + identifierColumn + " = '" + identifier + "'";

			Int32 rowsAffected = 0;

			try
			{
				OpenDatabase();
				_command.CommandText = updateCommandText;
				rowsAffected = _command.ExecuteNonQuery();
				CloseDatabase();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Failed to Insert into DB : " + ex.Message);
			}

			
			return rowsAffected;
		}

		/// <summary>Enum class giving the names of all the tables in the database.</summary>
		public enum Tables
		{
			/// <summary>The buyers table</summary>
			Buyers,
			/// <summary>The companies table.</summary>
			Companies,
			/// <summary>The customers table.</summary>
			Customers,
			/// <summary>The employees table.</summary>
			Employees,
			/// <summary>The items table.</summary>
			Items,
			/// <summary>The stock
			/// table.</summary>
			Stock,
			/// <summary>The users table.</summary>
			Users
		}

		/// <summary>An enum to give the column names of the Buyers table.</summary>
		public enum BuyersTableColumns
		{
			/// <summary>The company name.</summary>
			Company,
			/// <summary>The company physical address.</summary>
			Address,
			/// <summary>The contact person.</summary>
			ContactPerson,
			/// <summary>The contact number.</summary>
			ContactNumber,
			/// <summary>The email address.</summary>
			Email
		}

		/// <summary>An enum to give the column names of the columns in the Companies table.</summary>
		public enum CompaniesTableColumns
		{
			/// <summary> The name of the company</summary>
			Name,
			/// <summary>The contact person from the company.</summary>
			ContactPerson,
			/// <summary>The email of the company.</summary>
			Email,
			/// <summary>The contact numbers of the company.</summary>
			ContactNumbers,
			/// <summary>The address of the company.</summary>
			Address
		}

		/// <summary>An enum to give the column names of the Customers table.</summary>
		public enum CustomersTableColumns
		{
			/// <summary>The customer number</summary>
			CustomerNumber,
			/// <summary>The customer's ID number, passport number or any other identity document number.</summary>
			ID,
			/// <summary>The name of the customer.</summary>
			Name,
			/// <summary>The surname of the customer</summary>
			Surname,
			/// <summary>The customer's cellphone number.</summary>
			Cell,
			/// <summary>The address of the customer.</summary>
			Address
		}

		/// <summary>An enum to give the column names of the Employees table.</summary>
		public enum EmployeesTableColumns
		{   /// <summary>The name of the employee</summary>
			Name,
			/// <summary>The surname of the employee</summary>
			Surname,
			/// <summary>The identification number of the employee</summary>
			Identification,
			/// <summary>The gender of the employee</summary>
			Gender,
			/// <summary>The address of the employee</summary>
			Address,
			/// <summary>The cellphone number of the employee</summary>
			Cell
		}

		/// <summary>An enum to give the column names of the Items table.</summary>
		public enum ItemsTableColumns
		{   /// <summary>The name of the item</summary>
			Name,
			/// <summary>The price of the item</summary>
			Price,
			/// <summary>The dealer's prcice of the item</summary>
			DealerPrice,
			/// <summary>The type of the item.
			/// <para> Items can be ferrous or non-ferrous</para>
			/// </summary>
			Type
		}

		/// <summary>An enum to give the column names of the Stock table.</summary>
		public enum StockTableColumns { }

		/// <summary>An enum to give the column names of the Users table.</summary>
		public enum UsersTableColumns
		{   /// <summary>The username</summary>
			UserName,
			/// <summary>The password. Note that passwords will be encrypted when storing them.</summary>
			Password,
			/// <summary>The user's email address.</summary>
			Email,
			/// <summary>The user's permission level.</summary>
			PermissionLevel
		}

		/// <summary>Converts the name of any enum field into a string.</summary>
		/// <typeparam name="T">The name of the enum class.</typeparam>
		/// <param name="enumField">The enum field to be converted.</param>
		/// <returns>A string representation of the enum field name.</returns>
		public string enumToString<T>(T enumField) 
		{
			string enumName = enumField.ToString();
			return enumName;
		}

		/// <summary>Creates a string representing columns of a database table.</summary>
		/// <param name="_tableName">An enum type representing the name of the database table.</param>
		/// <returns>A string with all the table column names separated by commas.</returns>
		private string getTableColumns(Tables _tableName) 
		{
			string tableNames = "";

			switch (_tableName) 
			{
				case Tables.Buyers:
					tableNames = enumFieldsToString<BuyersTableColumns>();
					break;
				case Tables.Companies:
					tableNames = enumFieldsToString<CompaniesTableColumns>();
					break;
				case Tables.Customers:
					tableNames = enumFieldsToString<CustomersTableColumns>();
					break;
				case Tables.Employees:
					tableNames = enumFieldsToString<EmployeesTableColumns>();
					break;
				case Tables.Items:
					tableNames = enumFieldsToString<ItemsTableColumns>();
					break;
				case Tables.Stock:
					tableNames = enumFieldsToString<StockTableColumns>();
					break;
				case Tables.Users:
					tableNames = enumFieldsToString<UsersTableColumns>();
					break;
				default:
					break;
			}

			return tableNames;
		}

		/// <summary>Function to generate a string containing all the fields of a given enum type.</summary>
		/// <typeparam name="EnumType">The enum type.</typeparam>
		/// <returns>A string representing all the fields of the enum seperated by commas.</returns>
		private string enumFieldsToString<EnumType>() 
		{
			string[] values = Enum.GetNames(typeof(EnumType));
			string stringValues = "";

			foreach (string value in values)
			{
				stringValues = stringValues + "," + value;
			}

			//remove the first comma
			stringValues = stringValues.Remove(0, 1);
			return stringValues;
		}

		/// <summary>A function to convert an array of strings into one string seperated by commas.</summary>
		/// <param name="values">The array of strings.</param>
		/// <returns>A single string combining the arrary of strings seperated by commas.</returns>
		private string formatValuesForInsertion(string[] values) 
		{
			string stringValues = "'";

			foreach (string value in values) 
			{
				stringValues = stringValues + value + "','";
			}
			//Remove the last quotation and comma from the string.
			stringValues = stringValues.Remove(stringValues.Length - 2,2);
			return stringValues;
		}

		private string formatValuesForUpdating<TableColumn>(TableColumn[] tableColumns, string[] values) 
		{
			string columnValuePairs = "";
			for (int index = 0; index < tableColumns.Length; index++) 
			{
				columnValuePairs = columnValuePairs + tableColumns[index] + " = '" + values[index] + "', ";
			}
			columnValuePairs = columnValuePairs.Remove(columnValuePairs.Length - 2, 2);

			return columnValuePairs;
		}
	}
}
