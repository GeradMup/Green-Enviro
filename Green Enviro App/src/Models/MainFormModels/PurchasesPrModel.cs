using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Green_Enviro_App
{
	using GridViewData = DGVOps.GridViewData;

	/// <summary>
	/// Class to hanlde all the business logic relating to the police registers.
	/// </summary>
	class PurchasesPrModel
	{
		FileHandles fileHandles;
		CSVHandles csvHandles;

		/// <summary>
		/// Initializes a new instance of the <see cref="PurchasesPrModel"/> class.
		/// </summary>
		/// <param name="fh">The fh.</param>
		/// <param name="csv">The CSV.</param>
		public PurchasesPrModel(FileHandles fh, CSVHandles csv) 
		{
			fileHandles = fh;
			csvHandles = csv;
			createLogFiles();
		}

		/// <summary>
		/// Gets the months of all the police registers that have been recorded.
		/// </summary>
		/// <returns>A List of string containing the months.</returns>
		/// <exception cref="System.Exception"></exception>
		public List<string> getMonths() 
		{
			try
			{
				return fileHandles.getLogNames(FileHandles.LogType.PurchasesPoliceRegisters);
			}
			catch (Exception ex)
			{
				throw new Exception(ex.Message);
			}
		}

		/// <summary>
		/// Gets the data to be used on the purchases police register data grid view
		/// </summary>
		/// <param name="month">The month.</param>
		/// <returns>The GridViewData </returns>
		/// <exception cref="System.Exception"></exception>
		public GridViewData getGridData(string month) 
		{
			GridViewData gridData = new GridViewData();
			string pathToLogFile = fileHandles.pathToLogs(FileHandles.LogType.PurchasesPoliceRegisters, month);

			try
			{
				gridData.data = csvHandles.getCSVContents(pathToLogFile);
				gridData.dates = csvHandles.getDatesInFile(pathToLogFile);
			}
			catch (Exception ex) 
			{
				throw new Exception(ex.Message);
			}
			return gridData;
		}

		/// <summary>
		/// Creates the log files for purchases police registers if they don't already exist.
		/// </summary>
		private void createLogFiles() 
		{
			//For the log files, we will use the same header files that are used in the purchases log file.
			string purchasesPRLogHeaders = GenericModels.enumFieldsToString<PurchasesModel.PurchaseLogHeaders>();
			fileHandles.createCSVFile(FileHandles.LogType.PurchasesPoliceRegisters, purchasesPRLogHeaders);
		}

		/// <summary>
		/// Adds the given item to the purchases police register.
		/// </summary>
		public void addToPurchasesPoliceRegister(string entry)
		{
			string path = fileHandles.pathToLogs(FileHandles.LogType.PurchasesPoliceRegisters);
			bool entryAlreadyAdded = csvHandles.entryExistsInCSV(path, entry);

			try
			{
				if (entryAlreadyAdded) throw new EntryAlreadyAddedException();
				csvHandles.addToCSV(path, new List<string>() { entry });
			}
			catch (Exception ex) 
			{
				throw new Exception(ex.Message);
			}	
			
		}

		/// <summary>
		/// Deletes an entry from the purchases police register.
		/// </summary>
		/// <param name="rowToDelete">The line to delete.</param>
		/// <param name="month">The month.</param>
		public void deleteEntry(string rowToDelete, string month) 
		{
			string pathToLog = fileHandles.pathToLogs(FileHandles.LogType.PurchasesPoliceRegisters, month);
			try
			{
				csvHandles.setRowToDelete(rowToDelete);
				csvHandles.deleteInCSV(pathToLog);
			}
			catch (Exception ex) 
			{
				throw new Exception(ex.Message);
			}
		}
	}

	/// <summary>
	/// Exception to be thrown if you try to add an entry that already exists to the police register.
	/// </summary>
	/// <seealso cref="System.Exception" />
	class EntryAlreadyAddedException : Exception 
	{
		const string message = "This entry has already been added to the police register!";
		public EntryAlreadyAddedException() : base(message){ }
	}
}
