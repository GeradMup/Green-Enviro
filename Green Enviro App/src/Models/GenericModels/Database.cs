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
		const string DATABASE_SELECTING_ALL_EXCEPTION = "Database selecting all Exception!";
		const string DATABASE_INSERTION_EXCEPTION = "Database insertion error! " +
													"\nClose the Green Enviro program and run the 'Close SQL Program.'";
		const string DATABASE_SELECTING_EXCEPTION = "Database selecting exception";
		const string DATABASE_UPDATING_EXCEPTION = "Databse updating error! \nTry the following : " +
													"\n1. Check that you are not using an ID number that is already taken!" +
													"\n2. Close the Green Enviro program and run the 'Close SQL Program.'";
		const string DATABASE_OPENING_EXCEPTION = "Database opening error!" +
													"\nClose the Green Enviro program and run the 'Close SQL Program.'";
		const string DATABASE_DELETING_EXCEPTION = "Database deleting error!" +
													"\nClose the Green Enviro program and run the 'Close SQL Program.'";

		/// <summary>Initializes a new instance of the <see cref="Database" /> class.</summary>
		public Database()
		{
			//Sets up the first Database which stores the URL of the actual database file
		}

		/// <summary>
		/// Opens a connection to the database
		/// </summary>
		private void openDatabase()
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
			catch (Exception)
			{
				throw new Exception(DATABASE_OPENING_EXCEPTION);
			}
		}

		/// <summary>
		/// Closes the connection to a the database
		/// </summary>
		private static void closeDatabase()
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

		/// <summary>Selects all values from the database given the table name.</summary>
		/// <param name="_tableName">Name of the table.</param>
		/// <returns>A DataTable containing all the data read from the table.</returns>
		public DataTable selectAll(Tables _tableName)
		{
			DataTable _table = new DataTable();
			string tableName = GenericModels.enumToString<Tables>(_tableName);
			try
			{
				openDatabase();
				_command.CommandText = "SELECT * FROM " + tableName;

				SqlDataAdapter sda = new SqlDataAdapter(_command.CommandText, _connection);
				sda.Fill(_table);
				closeDatabase();
			}
			catch (Exception ex)
			{
				throw new Exception(DATABASE_SELECTING_EXCEPTION,ex);
			}
			return _table;
		}

		/// <summary>Selects specific elements from the database based on the table name and filterValue.</summary>
		/// <typeparam name="TableColumn">Template type describing the column name.</typeparam>
		/// <param name="_tableName">The name of the table from which the element must be read.</param>
		/// <param name="_columnName">A template value describing the name of the column to use for filtering.</param>
		/// <param name="filterValue">The value to use for filtering the database.</param>
		/// <returns>A DataTable with the selected values.</returns>
		/// <exception cref="System.Exception">If an error occurs while trying read from the database.</exception>
		public DataTable select<TableColumn>(Tables _tableName, TableColumn _columnName, string filterValue)
		{
			string tableName = GenericModels.enumToString<Tables>(_tableName);
			string columnName = GenericModels.enumToString<TableColumn>(_columnName);

			string filterExpression = columnName + " = '" + filterValue + "'";
			DataTable _table = new DataTable();
			try
			{
				openDatabase();
				_command.CommandText = "SELECT * FROM " + tableName + " WHERE " + filterExpression;

				SqlDataAdapter sda = new SqlDataAdapter(_command.CommandText, _connection);
				sda.Fill(_table);

				closeDatabase();
			}
			catch (Exception ex)
			{
				throw new Exception(DATABASE_SELECTING_ALL_EXCEPTION, ex);
			}
			return _table;
		}
		// Insertion function adding new users to the database yet not updating the database

		/// <summary>Deletes an entry in the database.</summary>
		/// <typeparam name="TableColumn">The type of the table column.</typeparam>
		/// <param name="_tableName">Name of the table to delete from.</param>
		/// <param name="_identifierColumn">The identifier column.</param>
		/// <param name="identifierValue">The indentifier value.</param>
		/// <returns>Int32 value representing the numer of rows that were altered.</returns>
		/// <exception cref="System.Exception">If something goes wrong while trying to delete.</exception>
		public Int32 delete<TableColumn>(Tables _tableName, TableColumn _identifierColumn, string identifierValue)
		{
			string tableName = GenericModels.enumToString<Tables>(_tableName);
			string identifierColumn = GenericModels.enumToString<TableColumn>(_identifierColumn);
			string _deletion_cmd = "DELETE FROM " + tableName + " WHERE " + identifierColumn + " = '" + identifierValue + "'";
			Int32 rowsAffected = 0;
			try
			{
				openDatabase();
				_command.CommandText = _deletion_cmd;
				rowsAffected = _command.ExecuteNonQuery();
				closeDatabase();
			}
			catch (Exception ex)
			{
				throw new Exception(DATABASE_DELETING_EXCEPTION, ex);
			}
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
			string tableName = GenericModels.enumToString<Tables>(_tableName);
			string tableColumns = getTableColumns(_tableName);
			string values = formatValuesForInsertion(_values);
			string insertionCmd = "INSERT INTO " + tableName + " (" + tableColumns + ") VALUES (" + values + ")";
			//Making the SQL command

			
			Int32 rowsAffected;
			try
			{
				openDatabase();
				_command.CommandText = insertionCmd;
				rowsAffected = _command.ExecuteNonQuery();
				closeDatabase();
			}
			catch (Exception ex)
			{
				throw new Exception(DATABASE_INSERTION_EXCEPTION, ex);
			}

			
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
		public void update<TableColumn>(Tables _tableName, 
			TableColumn[] columns, TableColumn _identifierColumn, string identifier, string[] values)
		{
			string tableName = GenericModels.enumToString<Tables>(_tableName);
			string identifierColumn = GenericModels.enumToString<TableColumn>(_identifierColumn);
			string columnValuePairs = formatValuesForUpdating<TableColumn>(columns, values);

			string updateCommandText = "UPDATE " + tableName + " SET " + columnValuePairs +
				" WHERE " + identifierColumn + " = '" + identifier + "'";

			try
			{
				openDatabase();
				_command.CommandText = updateCommandText;
				_command.ExecuteNonQuery();
				closeDatabase();
			}
			catch (Exception ex)
			{
				throw new Exception(DATABASE_UPDATING_EXCEPTION, ex);
			}
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
					tableNames = GenericModels.enumFieldsToString<BuyersTableColumns>();
					break;
				case Tables.Companies:
					tableNames = GenericModels.enumFieldsToString<CompaniesTableColumns>();
					break;
				case Tables.Customers:
					tableNames = GenericModels.enumFieldsToString<CustomersTableColumns>();
					break;
				case Tables.Employees:
					tableNames = GenericModels.enumFieldsToString<EmployeesTableColumns>();
					break;
				case Tables.Items:
					tableNames = GenericModels.enumFieldsToString<ItemsTableColumns>();
					break;
				case Tables.Stock:
					tableNames = GenericModels.enumFieldsToString<StockTableColumns>();
					break;
				case Tables.Users:
					tableNames = GenericModels.enumFieldsToString<UsersTableColumns>();
					break;
				case Tables.FixedExpenses:
					tableNames = GenericModels.enumFieldsToString<FixedExpensesTableColumns>();
					break;
				default:
					break;
			}

			return tableNames;
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

		/// <summary>Fomarts the tables and values to be updated in the database so that they are in the query format.</summary>
		/// <typeparam name="TableColumn">The type of the table column.</typeparam>
		/// <param name="tableColumns">The table columns to be updated.</param>
		/// <param name="values">The values to be used for updating the table.</param>
		/// <returns>A string of table names and value pairs to be updated in the database table.</returns>
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

		/// <summary>
		/// Enum class giving the names of all the tables in the database.</summary>
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
			Users,
			/// <summary>The FixedExpenses table.</summary>
			FixedExpenses
		}

		/// <summary>
		/// An enum to give the column names of the Buyers table.
		/// </summary>
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

		/// <summary>
		/// An enum to give the column names of the columns in the Companies table.
		/// </summary>
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

		/// <summary>
		/// An enum to give the column names of the Customers table.
		/// </summary>
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

		/// <summary>
		/// An enum to give the column names of the Employees table.
		/// </summary>
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

		/// <summary>
		/// An enum to give the column names of the Items table.
		/// </summary>
		public enum ItemsTableColumns
		{
			/// <summary>The item identifier</summary>
			Id,
			/// <summary>The name of the item</summary>
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

		/// <summary>
		/// An enum to give the column names of the Stock table.
		/// </summary>
		public enum StockTableColumns { }
		
		/// <summary>
		/// An enum to give the column names of the Users table.
		/// </summary>
		public enum UsersTableColumns
		{
			/// <summary>The account identifier</summary>
			AccountId,
			/// <summary>The username</summary>
			UserName,
			/// <summary>The password. Note that passwords will be encrypted when storing them.</summary>
			Password,
			/// <summary>The user's email address.</summary>
			Email,
			/// <summary>The user's permission level.</summary>
			PermissionLevel
		}

		/// <summary> 
		/// Enum to give the column names of the FixedExpenses table.</summary>
		public enum FixedExpensesTableColumns 
		{
			/// <summary>The name of the fixed expense. </summary>
			Name,
			/// <summary> The amount or cost of the fixed expense. </summary>
			Amount
		}	
	}
}
