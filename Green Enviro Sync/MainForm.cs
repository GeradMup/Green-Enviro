using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.NetworkInformation;
using System.Runtime;
using System.Runtime.InteropServices;
using Firebase.Storage;
using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;
using System.Net;
using System.IO;
using System.Diagnostics;
using System.IO.Compression;

namespace Green_Enviro_Sync
{
	public partial class Sync : Form
	{
		//Importing the package that will allow us to check for an internet connection before attempting to perform any downloads
		[DllImport("wininet.dll")]
		private extern static bool InternetGetConnectedState(out int description, int resultValue);

		static IFirebaseClient _fb_client;

		static string _main_dir_path = Path.GetDirectoryName(Path.GetDirectoryName(Directory.GetCurrentDirectory()));
		string _resources_path = _main_dir_path + @"\resources";
		string _resources_zip_path = _main_dir_path + @"\resources.zip";
		string _database_version_file = _main_dir_path + @"\DatabaseVersion.txt";
		static string _path_to_db_file_main = _main_dir_path + @"\Green Enviro Data.mdf";
		static string _path_to_log_file = _main_dir_path + @"\Green Enviro Data_log.ldf";

		static string _firebase_node = "Database Url";
		string _db_file_name = "Green Enviro Data.mdf";
		string _log_file_name = "Green Enviro Data_log.ldf";
		string _resources_file_name = "resources.zip";

		static string _data_bucket_name = "green-enviro-app.appspot.com";

		static Stopwatch _stopwatch;
		ErrorMsgBox _errorBox;
		int _permission_level;
		
		public Sync(int permissionLevel)
		{
			InitializeComponent();
			_permission_level = permissionLevel;
		}

		private void UploadBtn_Click(object sender, EventArgs e)
		{
			if ((_permission_level == 4) || (_permission_level == 5))
			{
				CheckConnectivity();
				SetupFirebaseDatabase();

				//First Upload the .mdf file
				//The log file will be uploaded via a recursive function call
				string parentDirectory = "Database file" + GetDatabaseVersion().ToString();
				UploadDatabase(1, _path_to_db_file_main, _db_file_name, parentDirectory);

			}
			else 
			{
				MessageBox.Show("Permission Denied", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void DownloadBtn_Click(object sender, EventArgs e)
		{
			if ((_permission_level == 2) || (_permission_level == 5))
			{
				CheckConnectivity();
				SetupFirebaseDatabase();
				//First get the .mdf file
				//The .ldf will be downloaded via a recursive function call
				RetrieveFromFirebase(_path_to_db_file_main, 1);
			}
			else 
			{
				MessageBox.Show("Permission Denied", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private bool CheckConnectivity() 
		{
			int _description;
			bool _isConnected = InternetGetConnectedState(out _description, 0);


			if (_isConnected == false)
			{
				_errorBox = new ErrorMsgBox();
				_errorBox.Activate();
				_errorBox.Show();
			}

			return _isConnected;
		}

		private void SetupFirebaseDatabase()
		{
			//Create the destination folder if it does not already exist
			IFirebaseConfig config = new FirebaseConfig
			{
				AuthSecret = "SAn2zMDU2KlQ626lxLPOlO8JUlhdWJQvFqq0Yv3H",
				BasePath = "https://green-enviro-app-default-rtdb.firebaseio.com/"
			};

			_fb_client = new FireSharp.FirebaseClient(config);

			if (_fb_client == null)
			{
				_errorBox = new ErrorMsgBox();
				_errorBox.Activate();
				_errorBox.Show();
			}
		}


		internal class Data
		{
			public int index { get; set; }
			public string downloadUrl { get; set; }
		}

		private async void UploadDatabase(int _index, string pathToLocalFile, string nameOfFile, string parentDirectory)
		{
			//First close the Database before trying to upload

			//Now try to upload the database
			var uploadStream = File.Open(pathToLocalFile, FileMode.Open);

			var task = new FirebaseStorage(_data_bucket_name)
				.Child(parentDirectory)                 //Parent Directory
				.Child(nameOfFile)         //Actual File Name
				.PutAsync(uploadStream);

			task.Progress.ProgressChanged += (s, e) => ProgressBar();
			string download_address = await task;

			Data _data = new Data
			{
				index = _index,
				downloadUrl = download_address
			};
			
			InsertIntoFirebase(_data);

			if (_index == 1)
			{
				//Second upload the log file(.ldf)
				UploadDatabase(2, _path_to_log_file, _log_file_name, parentDirectory);
			}
			else if (_index == 2)
			{
				ZipLogFiles();
				UploadDatabase(3, _resources_zip_path, _resources_file_name, parentDirectory);
			}
			else 
			{
				InsertionCompleted();
			}
		}

		private async void InsertIntoFirebase(Data _data)
		{
			try
			{
				SetResponse _response = await _fb_client.SetTaskAsync(_firebase_node + _data.index, _data);
			}
			catch (Exception ex) 
			{
				MessageBox.Show("Upload Failed : " + ex.Message);
			}
		}

		private void InsertionCompleted() 
		{
			UpDownPgBar.Visible = false;
			MessageBox.Show("Upload Completed");
			LaunchMainApp();
			this.Close();
		}

		private async void RetrieveFromFirebase(string savePath, int nodeNum)
		{
			FirebaseResponse _response = await _fb_client.GetTaskAsync(_firebase_node + nodeNum);
			Data _data = _response.ResultAs<Data>();
			string _download_address = _data.downloadUrl;
			int _download_index = _data.index;

			await DownloadDatabase(_download_index, _download_address, savePath);
		}

		// ****************************************************************************************************************

		public async Task DownloadDatabase(int index, string _downloadUrl, string _savePath)
		{
			_stopwatch = Stopwatch.StartNew();
			//Downloading the Database file and saving it in the Debug folder of the main application

			WebClient _client = new WebClient();
			Uri _url_address = new Uri(_downloadUrl);
			_client.DownloadProgressChanged += new DownloadProgressChangedEventHandler(ProgressBar);
			_client.DownloadFileCompleted += (sender, e) => DownloadCompleted(index);
			//_client.DownloadFileAsync(_url_address, _path_to_db_file);
			await _client.DownloadFileTaskAsync(_url_address, _savePath);
		}

		//************************************************************************************************************************
		//Progress bar
		private void ProgressBar(object sender, DownloadProgressChangedEventArgs e) 
		{
				//some other processing to do possible
				if (_stopwatch.ElapsedMilliseconds >= 200)
				{
					ProgressBar();
					_stopwatch.Restart();
				}
		}
		private void ProgressBar ()
		{
			//Activates the progress bar
			UpDownPgBar.Visible = true;
			//MessageBox.Show("Progress Bar Made Visible");
			
			UpDownPgBar.Value += 5;
			if (UpDownPgBar.Value >= 100)
			{
				UpDownPgBar.Value = 0;
			}
		}

		private void DownloadCompleted(int _index) 
		{

			if (_index == 1)
			{
				//Do nothing because we sting need to download the second file
				RetrieveFromFirebase(_path_to_log_file, 2);
				return;
			}
			else if (_index == 2) 
			{
				RetrieveFromFirebase(_resources_zip_path, 3);
				return;
			}
			else if(_index == 3)
			{
				UnzipLogFiles();
				UpDownPgBar.Visible = false;
				MessageBox.Show("Download Completed");
				LaunchMainApp();
				this.Close();
			}
		}

		public void LaunchMainApp() 
		{
			string _main_exe_path = @"..//..//..//Green Enviro App//bin//Debug//Green Enviro App.exe";
			//Run the main application after data syncronization is completed
			string _absolute_path = Path.GetFullPath(_main_exe_path);
			Process.Start(_absolute_path, _permission_level.ToString());
			this.Close();
			Application.Exit();
		}

		private void CancelBtn_Click(object sender, EventArgs e)
		{
			LaunchMainApp();
			this.Close();
		}

		private void ZipLogFiles()
		{
			try
			{
				if (File.Exists(_resources_zip_path)) 
				{
					File.Delete(_resources_zip_path);
				}
				ZipFile.CreateFromDirectory(_resources_path, _resources_zip_path);
			}
			catch(Exception ex) 
			{
				MessageBox.Show("Error Zipping: " + ex.Message);
			}
		}

		private void UnzipLogFiles() 
		{
			try
			{
				if (Directory.Exists(_resources_path)) 
				{
					bool _delete_subfolders_and_files = true;
					Directory.Delete(_resources_path, _delete_subfolders_and_files);
				}
				ZipFile.ExtractToDirectory(_resources_zip_path, _resources_path);
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error Unzipping: " + ex.Message);
			}
		}

		private int GetDatabaseVersion() 
		{
			string line = "";
			int databaseVersion = 0;
			try
			{
				line = System.IO.File.ReadAllText(_database_version_file);
				databaseVersion = int.Parse(line);
				SetDatabaseVersion(databaseVersion);
			}
			catch (Exception ex) 
			{
				MessageBox.Show("Error", "Failed to read the database version file");
			}

;
			return databaseVersion;
		}

		private void SetDatabaseVersion(int currentVersion) 
		{
			if (currentVersion > 20)
			{
				currentVersion = 1;
			}
			else 
			{
				currentVersion++;
			}

			FileStream fWrite = new FileStream(_database_version_file,
			FileMode.OpenOrCreate, FileAccess.Write, FileShare.None);

			byte[] writeArr = Encoding.UTF8.GetBytes(currentVersion.ToString());
			fWrite.Write(writeArr, 0, currentVersion.ToString().Length);
			fWrite.Close();
		}

		private void Sync_FormClosing(object sender, FormClosingEventArgs e)
		{

			try
			{
				foreach (Process proc in Process.GetProcessesByName("sqlservr"))
				{
					proc.Kill();
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}
	}
}
