using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Green_Enviro_App
{
	/// <summary>
	/// Class to hanlde all the business logic relating to the police registers.
	/// </summary>
	class PoliceRegistersModel
	{
		FileHandles fileHandles;
		CSVHandles csvHandles;

		/// <summary>
		/// Initializes a new instance of the <see cref="PoliceRegistersModel"/> class.
		/// </summary>
		/// <param name="fh">The fh.</param>
		/// <param name="csv">The CSV.</param>
		public PoliceRegistersModel(FileHandles fh, CSVHandles csv) 
		{
			fileHandles = fh;
			csvHandles = csv;
			createLogFiles();
		}

		private void createLogFiles() 
		{
			//For the log files, we will use the same header files that are used in the purchases log file.
			string purchasesLogHeaders = GenericModels.enumFieldsToString<PurchasesModel.PurchaseLogHeaders>();
			fileHandles.createCSVFile(FileHandles.LogType.PurchasesPoliceRegisters, purchasesLogHeaders);
		}

		/// <summary>
		/// Adds the given item to the purchases police register.
		/// </summary>
		public void addToPurchasesPoliceRegister(string entry) 
		{
			string path = fileHandles.pathToLogs(FileHandles.LogType.PurchasesPoliceRegisters);
			bool entryAlreadyAdded = csvHandles.entryExistsInCSV(path, entry);

			if (entryAlreadyAdded) throw new EntryAlreadyAddedException();

			csvHandles.addToCSV(path, new List<string>() { entry });
		}
	}

	class EntryAlreadyAddedException : Exception 
	{
		const string message = "This entry has already been added to the police register!";
		public EntryAlreadyAddedException() : base(message){ }
	}
}
