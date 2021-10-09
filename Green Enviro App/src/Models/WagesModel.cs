using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Green_Enviro_App
{

	class WagesModel
	{
		Database database;
		CSVHandles csvHandles;
		FileHandles fileHandles;

		/// <summary>
		/// Initializes a new instance of the <see cref="WagesModel"/> class.
		/// </summary>
		/// <param name="db">The database calss object.</param>
		/// <param name="csvH">The CSV Handler class object.</param>
		/// <param name="fH">The file handler class object.</param>
		public WagesModel(Database db, CSVHandles csvH, FileHandles fH) 
		{
			database = db;
			csvHandles = csvH;
			fileHandles = fH;
			createLogFiles();
		}

		//Create purchase and wages logs for each month if they don't already exist
		private void createLogFiles()
		{
			const string wagesFileHeaders = "Date,Name,Amount";
			fileHandles.createCSVFile(FileHandles.LogType.Wages, wagesFileHeaders);
		}

		/// <summary>
		/// Gets the months for which wages logs exist.
		/// </summary>
		/// <returns>A List of strings representing the months.</returns>
		public List<string> getMonths() 
		{
			return fileHandles.getLogNames(FileHandles.LogType.Wages);
		}
	}
}
