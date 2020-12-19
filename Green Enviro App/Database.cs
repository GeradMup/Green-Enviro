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
	
	class Database
	{
		static string database_address;

		public Database() 
		{
			uploadDatabaseAsync();
			
		}

		private static async void uploadDatabaseAsync()
		{
			var uploadStream = File.Open(@"C:\Sample\Nothing.txt", FileMode.Open);

			var task = new FirebaseStorage("green-enviro-app.appspot.com")
				.Child("Database File")
				.Child("Nothing.txt")
				.PutAsync(uploadStream);

			task.Progress.ProgressChanged += (s, e) => MessageBox.Show("Updating");

			database_address = await task;

			Console.WriteLine(database_address);
			MessageBox.Show("Update Complete");
			downloadDatabase();

		}

		private static void downloadDatabase()
		{

			//Create the destination folder if it does not already exist
			string _path_string = @"C:\Green Enviro";
			System.IO.Directory.CreateDirectory(_path_string);


			WebClient _client = new WebClient();
			_client.DownloadFile(database_address, @"C:\Green Enviro\Nothing.txt");
			MessageBox.Show("Update Complete");
		}

	}
}
