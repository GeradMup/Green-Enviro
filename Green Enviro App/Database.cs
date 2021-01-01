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

	public class Database
	{
		static string _path_to_directory = @"..\\..\\";
		static string _path_to_db_file = _path_to_directory + "\\Green Enviro Data.mdf";
		static Main_Form _main_form;
		//static CustomMsgBox _custom_msg_box;

		//static string _connection_string = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\gerry\OneDrive\Documents\Work\Green Enviro\App Development\Green Enviro App\resources\Data\Green Enviro Data.mdf;Integrated Security = True; Connect Timeout = 30";
		static string _connection_string = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Green Enviro Data.mdf;Integrated Security = True; Connect Timeout = 30";
		//static string _connection_string = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename="+ _absolute_path_to_db +";Integrated Security = True; Connect Timeout = 30";
		//static string _connection_string = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\gerry\OneDrive\Documents\Work\Green Enviro\App Development\Green Enviro App\Green Enviro Data.mdf;Integrated Security=True;Connect Timeout=30";

		static SqlConnection _connection;
		static SqlCommand _command;

		public Database() 
		{
			//Sets up the first Database which stores the URL of the actual database file
			
		}
		// ****************************************************************************************************************

		public void UploadData(Main_Form _main) 
		{
			_main_form = _main;    
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
				MessageBox.Show("Failed To Connect To DB: " + ex.Message);
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

		public void SelectAll() 
		{ 
			
		}
	}
}
