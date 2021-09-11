using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Green_Enviro_App
{
	/// <summary>This class handles all the interactions the computer's file system.</summary>
	public class FileHandles
	{
		/// <summary>Creates a CSV file for the specified log type and with the given headers..</summary>
		/// <param name="logType">Type of the log.</param>
		/// <param name="headers">The headers.</param>
		public void createCSVFile(LogType logType, string headers)
		{
			//First Check if the files exist for each month
			//If the file does not exist, create it
			string path = pathToLogs(logType);
			if (File.Exists(path)) return;
			string copyPath = path;
			folderPath(ref copyPath);
			createFolder(copyPath);
			StringBuilder _csv_content = new StringBuilder();
			_csv_content.AppendLine(headers);
			//_csv_content.AppendLine("\n");
			File.AppendAllText(path, _csv_content.ToString());

		}

		private void folderPath(ref string path)
		{
			char lastChar = path[path.Length - 1];
			char forwardSlash = '\\';

			//recursively call this function so that we can get the folder name that contains this file
			if (lastChar != forwardSlash)
			{
				path = path.Remove(path.Length - 1, 1);
				folderPath(ref path);
			}
		}

		/// <summary>Creates a folder at a given path.</summary>
		/// <param name="path">The path.</param>
		public void createFolder(string path)
		{
			if (Directory.Exists(path)) return;
			System.IO.Directory.CreateDirectory(path);
		}

		/// <summary>Gets the sub folders in a given path</summary>
		/// <param name="logType">The type of log whose sub folders are required.</param>
		/// <returns>A list of all the file names in folder</returns>

		public List<string> getLogNames(LogType logType)
		{
			List<DateTime> dates = new List<DateTime>();

			bool basePathOnly = true;
			string monthAndYear = null;
			string pathToFolder = pathToLogs(logType, monthAndYear, basePathOnly);
			DirectoryInfo directoryInfo = new DirectoryInfo(pathToFolder);
			DirectoryInfo[] folders = directoryInfo.GetDirectories();

			foreach (DirectoryInfo folder in folders)
			{
				string folderName = folder.Name;
				dates.Add(DateTime.ParseExact(folderName, "MMMM yyyy", null));
			}
			//The files are named after the month in which they were created.
			//Here we try to order the dates

			dates.Sort((x, y) => DateTime.Compare(x, y));
			List<String> sortedDates = new List<String>();
			foreach (DateTime date in dates)
			{
				sortedDates.Add(date.ToString("MMMM yyyy"));
			}
			return sortedDates;
		}

		/// <summary>
		/// Generates a path to the sales logs based on the current month of the year or the month selected by the user. The function can also generate only the base path based on the usere choice.
		/// </summary>
		/// <param name="logType">The Type of Log whose path is needed.</param>
		/// <param name="monthAndYear">An optional parameter to specify the month for the log needed. If left as null, the current month will be selected.</param>
		/// <param name="basePathOnly">An Optional parameter that specifies whether the caller is looking for the base path only or the full path.</param>
		/// <returns>A string representing the path.</returns>
		public string pathToLogs(LogType logType, string monthAndYear = null, bool basePathOnly = false)
		{
			if (basePathOnly) return getBasePath(logType);

			string date = "";
			string path = "";
			if (monthAndYear == null) date = Constants.CURRENT_MONTH_AND_YEAR;
			else date = monthAndYear;

			path = getBasePath(logType) + date + "\\" + date + Constants.CSV_EXTENSION;
			return path;
		}

		/// <summary>
		///   <para>
		/// Gets the base path to log files of the given type. </para>
		///   <para>Returns base path only if specified.</para>
		/// </summary>
		/// <param name="logType">Type of the log.</param>
		/// <returns>The path to the log file.</returns>
		private string getBasePath(LogType logType)
		{
			string basePath = "";
			switch (logType)
			{
				case LogType.DeliveryNotes:
					basePath = Constants.DELIVERY_NOTES_BASE_PATH;
					break;
				case LogType.DestructionCertificates:
					basePath = Constants.DESTRUCTION_CERTIFICATES_BASE_PATH;
					break;
				case LogType.Expenses:
					basePath = Constants.EXPENSES_BASE_PATH;
					break;
				case LogType.Inventory:
					basePath = Constants.INVENTORY_BASE_PATH;
					break;
				case LogType.PurchasesPoliceRegisters:
					basePath = Constants.PURCHASE_POLICE_REG_BASE_PATH;
					break;
				case LogType.SalesPoliceRegisters:
					basePath = Constants.SALES_POLICE_REG_BASE_PATH;
					break;
				case LogType.Purchases:
					basePath = Constants.PURCHASES_BASE_PATH;
					break;
				case LogType.Sales:
					basePath = Constants.SALES_BASE_PATH;
					break;
				case LogType.Wages:
					basePath = Constants.WAGES_BASE_PATH;
					break;
				default:
					break;
			}
			return basePath;
		}

		/// <summary>Gets all file names in a directory given the folder path.</summary>
		/// <param name="basePath">The base bath.</param>
		/// <returns>A list of all the file names in the folder.</returns>
		public List<string> getfilesInFolder(string basePath) 
		{
			DirectoryInfo dirInfo = new DirectoryInfo(basePath);
			FileInfo[] files = dirInfo.GetFiles();
			List<string> allFiles = new List<string>();

			foreach (FileInfo file in files) 
			{
				allFiles.Add(file.Name);
			}
			return allFiles;
		}

		private string enumToString<T>(T enumValue) 
		{
			string enumName = enumValue.ToString();
			return enumName;
		}
		/// <summary>Enum class to describe the different types of logs that the program will store.</summary>
		public enum LogType
		{
			/// <summary>The delivery notes</summary>
			DeliveryNotes,
			/// <summary>The destruction certificates</summary>
			DestructionCertificates,
			/// <summary>The expenses log</summary>
			Expenses,
			/// <summary>The inventory log.</summary>
			Inventory,
			/// <summary>The sales police registers</summary>
			SalesPoliceRegisters,
			/// <summary>The purchases police registers</summary>
			PurchasesPoliceRegisters,
			/// <summary>The purchases log</summary>
			Purchases,
			/// <summary>The sales log</summary>
			Sales,
			/// <summary>The wages log</summary>
			Wages
		}

		enum FileTypes 
		{
			csv,
			pdf,
			txt
		}
		
	}
}
