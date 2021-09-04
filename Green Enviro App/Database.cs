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

namespace Green_Enviro_App
{

	/// <summary>
	///  Class for handling all the Database related work
	///   <br />
	/// </summary>
	public class Database
	{
		//static readonly string _path_to_directory = @"..\\..\\";
		//static readonly string _path_to_db_file = _path_to_directory + "\\Green Enviro Data.mdf";
		//static Main_Form _main_form;
		//static CustomMsgBox _custom_msg_box;

		//static string _connection_string = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\gerry\OneDrive\Documents\Work\Green Enviro\App Development\Green Enviro App\resources\Data\Green Enviro Data.mdf;Integrated Security = True; Connect Timeout = 30";
		//static readonly string _connection_string = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Green Enviro Data.mdf;Integrated Security = True; Connect Timeout = 30";
		//static string _connection_string = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename="+ _absolute_path_to_db +";Integrated Security = True; Connect Timeout = 30";

		static string path = Path.GetDirectoryName(Path.GetDirectoryName(Directory.GetCurrentDirectory()));
		static string _connection_string = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + path + @"\Green Enviro Data.mdf;Integrated Security=True;Connect Timeout=30";

		static SqlConnection _connection;
		static SqlCommand _command;
		const string DATABASE_EXCEPTION = "Database Exception!";

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

		public DataTable SelectAll(string tableName) 
		{
			OpenDatabase();
			DataTable _table = new DataTable();
			
			_command.CommandText = "Select * From " + tableName ;

			try
			{
				SqlDataAdapter sda = new SqlDataAdapter(_command.CommandText, _connection);
				sda.Fill(_table);
			}
			catch (Exception ex)
			{
				MessageBox.Show("Failed to Select from DB : " + ex.Message);
			}

			CloseDatabase();
			return _table;
		}

		/// <summary>Selects specific elements from the database based on the table name and filterValue.</summary>
		/// <typeparam name="T">Template type describing the table name.</typeparam>
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
			catch(Exception ex) 
			{
				throw new Exception(DATABASE_EXCEPTION, ex);
			}
			return _table;
		}
		// Insertion function adding new users to the database yet not updating the database
		public void InsertNewUser(string username,string password, string email_address,int permission_level)
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

		public Int32 DeleteFromDatabase(string _table,string _condition)
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

		// Functions inserting any information per parameters from a database table selected
		public Int32 InsertIntoDatabase(string _table,string _parameters, string _values)
        {
			OpenDatabase();
			//The Delete command goes as follow
			string _insertion_cmd = "insert into " + _table + " (" + _parameters + ") values (" + _values + ")";
			//Making the SQL command
			_command.CommandText = _insertion_cmd;
			Int32 rowsAffected = 0;
			//View if the changes where succesfully done on the console
			try
			{
				rowsAffected = _command.ExecuteNonQuery();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Failed to Insert into DB : " + ex.Message);
			}

			CloseDatabase();
			return rowsAffected;
		}

		public Int32 UpdateDatabase(string tableName, string columValuePairs, string identifierColumn, string identifier) 
		{
			OpenDatabase();
			string _update_command_text = "UPDATE " + tableName + " set " + columValuePairs +
				"where " + identifierColumn + " = " + identifier;

			_command.CommandText = _update_command_text;
			Int32 rowsAffected = 0;
			
			try
			{
				rowsAffected = _command.ExecuteNonQuery();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Failed to Insert into DB : " + ex.Message);
			}

			CloseDatabase();
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

		/// <summary>Enum to give all the columns of the Buyers Table.</summary>
		public enum BuyersTableColumns 
		{
			/// <summary>The Database entry Id</summary>
			Id,
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

		/// <summary>Converts the name of any enum field into a string.</summary>
		/// <typeparam name="T">The name of the enum class.</typeparam>
		/// <param name="enumField">The enum field to be converted.</param>
		/// <returns>A string representation of the enum field name.</returns>
		public string enumToString<T>(T enumField) 
		{
			string enumName = enumField.ToString();
			return enumName;
		}
	}
}
