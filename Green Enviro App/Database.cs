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

namespace Green_Enviro_App
{
	
	public class Database
	{
		static string database_address;
		static string _path_to_directory = @"..\\..\\";
		static string _path_to_file = _path_to_directory + "\\Green Enviro Data.mdf";
		static string _data_bucket_name = "green-enviro-app.appspot.com";
		static Main_Form _main_form;

		static CustomMessageBox _custom_msg_box;


		public Database() 
		{
			//CreateProgressBar();
			//uploadDatabaseAsync();
			_custom_msg_box = new CustomMessageBox();

		}

		private static async void uploadDatabaseAsync()
		{
			var uploadStream = File.Open(_path_to_file, FileMode.Open);

			var task = new FirebaseStorage(_data_bucket_name)
				.Child("Database File")					//Parent Directory
				.Child("Green Enviro Data.mdf")			//Actual File Name
				.PutAsync(uploadStream);

			task.Progress.ProgressChanged += (s, e) => UploadProgress();

			database_address = await task;

			Console.WriteLine(database_address);

			_main_form.UpDownProgressBar.Visible = false;
			UploadCompleted();
			downloadDatabase();
		}

		private static void UploadProgress() 
		{
			_main_form.UpDownProgressBar.Visible = true;
			//MessageBox.Show("Progress Bar Made Visible");

			if (_main_form.UpDownProgressBar.Value >= 95) 
			{
				_main_form.UpDownProgressBar.Value = 0;
			}
			_main_form.UpDownProgressBar.Value += 10;

		}

		private static void UploadCompleted() 
		{
			_custom_msg_box.Activate();
			_custom_msg_box.Show();
			_custom_msg_box.Refresh();
			System.Threading.Thread.Sleep(2000);
			_custom_msg_box.Close();

		}

		private static void downloadDatabase()
		{
			//Create the destination folder if it does not already exist
			
			System.IO.Directory.CreateDirectory(_path_to_directory);

			WebClient _client = new WebClient();
			_client.DownloadFile(database_address, _path_to_file);
			MessageBox.Show("Download Complete");
		}

		public void SynchroniseData(Main_Form _main) 
		{
			_main_form = _main;
			_main_form.UpDownProgressBar.Visible = true;
			uploadDatabaseAsync();
		}
	}
}
