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
		static string database_address;
		static string database_address2;
		static string _path_to_directory = @"..\\..\\";
		static string _path_to_db_file = _path_to_directory + "\\Green Enviro Data.mdf";
		static string _path_to_log_file = _path_to_directory + "\\Green Enviro Data_log.ldf";
		static string _data_bucket_name = "green-enviro-app.appspot.com";
		static Main_Form _main_form;
		static CustomMsgBox _custom_msg_box;

		//static CustomMessageBox _custom_msg_box;

		//Database info
		//static string _connection_string = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\gerry\OneDrive\Documents\Work\Green Enviro\App Development\Green Enviro App\resources\Data\Green Enviro Data.mdf;Integrated Security = True; Connect Timeout = 30";
		static string _connection_string = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Green Enviro Data.mdf;Integrated Security = True; Connect Timeout = 30";

		SqlConnection _connection;
		static SqlCommand _command;

		static IFirebaseClient _fb_client;
		static string _firebase_node = "Database Url";

		public Database() 
		{
			//Sets up the first Database which stores the URL of the actual database file
			SetupFirebaseDatabase();
		}
		
		// ************************************************************************************************************
		
		private void SetupFirebaseDatabase() 
		{
			//Create the destination folder if it does not already exist
			IFirebaseConfig config = new FirebaseConfig
			{
				AuthSecret = "SAn2zMDU2KlQ626lxLPOlO8JUlhdWJQvFqq0Yv3H",
				BasePath = "https://green-enviro-app-default-rtdb.firebaseio.com/"
			};

			_fb_client = new FireSharp.FirebaseClient(config);

			if (_fb_client != null)
			{
				MessageBox.Show("Connected to Firebase Database");
			}
		}

		internal class Data 
		{ 
			public int index { get; set; }
			public string downloadUrl { get; set; }
		}
		private static async void InsertIntoFirebase(Data _data) 
		{
			SetResponse _response = await _fb_client.SetTaskAsync(_firebase_node + _data.index, _data);

			Data _result = _response.ResultAs<Data>();

			_custom_msg_box = new CustomMsgBox(_main_form);
			_custom_msg_box.DisplayMsg("Saved Download URL: " + _result.index);

		}

		private static async void RetrieveFromFirebase(string _nodeName) 
		{
			FirebaseResponse _response = await _fb_client.GetTaskAsync(_firebase_node+1);
			Data _data = _response.ResultAs<Data>();
			database_address = _data.downloadUrl;

			_response = await _fb_client.GetTaskAsync(_firebase_node + 2);
			_data = _response.ResultAs<Data>();
			database_address2 = _data.downloadUrl;


			DownloadDatabase();

		}
		// ****************************************************************************************************************

		public static void DownloadDatabase()
		{
			System.IO.Directory.CreateDirectory(_path_to_directory);

			WebClient _client = new WebClient();
			Uri _url_address = new Uri(database_address);
			_client.DownloadFileAsync(_url_address, _path_to_db_file);

			//_url_address = new Uri(database_address2);
			//_client.DownloadFileAsync(_url_address, _path_to_log_file);

			Completed("Successfully Synchronized!");
		}

		private static async void UploadDatabaseAsync()
		{
			var uploadStream = File.Open(_path_to_db_file, FileMode.Open);

			var task = new FirebaseStorage(_data_bucket_name)
				.Child("Database File")					//Parent Directory
				.Child("Green Enviro Data.mdf")			//Actual File Name
				.PutAsync(uploadStream);

			task.Progress.ProgressChanged += (s, e) => UploadProgress();
			database_address = await task;

			Data _data = new Data
			{
				index = 1,
				downloadUrl = database_address
			};

			uploadStream = File.Open(_path_to_log_file, FileMode.Open);
			task = new FirebaseStorage(_data_bucket_name)
				.Child("Database File")                 //Parent Directory
				.Child("Green Enviro Data_log.ldf")         //Actual File Name
				.PutAsync(uploadStream);

			task.Progress.ProgressChanged += (s, e) => UploadProgress();
			string database_address_log = await task;
	
			Data _data2 = new Data
			{
				index = 2,
				downloadUrl = database_address_log
			};

			InsertIntoFirebase(_data);
			InsertIntoFirebase(_data2);
			//DownloadDatabase();
			//UpdateURL(database_address);
			Completed("Upload Successful");
		}

		public void SynchroniseData(Main_Form _main)
		{
			_main_form = _main;
			_main_form.UpDownProgressBar.Visible = true;
			//DownloadDatabase();
			RetrieveFromFirebase(_firebase_node);
			
			
		}


		private static void UploadProgress() 
		{
			UpDownProgress();
		}

		private static void DownloadProgress(object sender, DownloadProgressChangedEventArgs e) 
		{
			UpDownProgress();
		}

		private static void UpDownProgress() 
		{
			//Activates the progress bar
			_main_form.UpDownProgressBar.Visible = true;
			//MessageBox.Show("Progress Bar Made Visible");
			_main_form.UpDownProgressBar.Value += 10;
			if (_main_form.UpDownProgressBar.Value >= 95)
			{
				_main_form.UpDownProgressBar.Value = 0;
			}
		}

		private static void Completed(string _msg) 
		{
			//Deactivate the progress
			_main_form.UpDownProgressBar.Value = 0;
			_main_form.UpDownProgressBar.Visible = false;

			//Show results message
			_custom_msg_box = new CustomMsgBox(_main_form);
			_custom_msg_box.DisplayMsg(_msg);
		}



		public void UploadData(Main_Form _main) 
		{
			_main_form = _main;    
			UploadDatabaseAsync();		
		}


		// ***************************************************************************************************************************
		//SQL Database stuff

		private void SetupDatabase() 
		{
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
		private static void insertIntoDB() 
		{
			//string _table_name = "DatabaseURL";
			//string _column = "address";
			//string _values = "Value";
			//_command.CommandText = "insert into ['" + _table_name + "'] ('" + _columns + "') values ('" + _values + "')";
		}

		private static void UpdateURL(string newURL) 
		{
			string _table_name = "DatabaseURL";
			string _column = "address";
			string _value = newURL;
			int _id = 1;
			_command.CommandText = "UPDATE "+ _table_name + " set "+ _column +" = '"+ _value +"' where id = "+ _id +"";
			_command.ExecuteNonQuery();
		}
	}
}
