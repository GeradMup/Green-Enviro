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
		static readonly string _connection_string = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Green Enviro Data.mdf;Integrated Security = True; Connect Timeout = 30";
		//static string _connection_string = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename="+ _absolute_path_to_db +";Integrated Security = True; Connect Timeout = 30";
		//static string _connection_string = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\gerry\OneDrive\Documents\Work\Green Enviro\App Development\Green Enviro App\Green Enviro Data.mdf;Integrated Security=True;Connect Timeout=30";

		static SqlConnection _connection;
		static SqlCommand _command;

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


		// Insertion function adding new users to the database yet not updating the database
		public void InsertNewUser(string username,string password, string email_address)
        {
			
			OpenDatabase();

			//Here is two ways to insert the new user into the database command, the commented line on line 140 is the other method
			_command.Parameters.AddWithValue("@Username", username);
			_command.Parameters.AddWithValue("@Password", password);
			_command.Parameters.AddWithValue("@Email", email_address);
			string _insertion_command = "Insert into Users (Username,Password,Email) values (@Username,@Password,@Email)";

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

		public void DeleteFromDatabase(string _table,string _condition)
        {
			OpenDatabase();
			//The Delete command goes as follow
			string _deletion_cmd = "delete from " + _table + " where " + _condition;
			//Making the SQL command
			_command.CommandText = _deletion_cmd;
			//View if the changes where succesfully done on the console
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
		//
	}
}
