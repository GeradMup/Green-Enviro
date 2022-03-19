using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Green_Enviro_App
{

	using GridViewData = DGVOps.GridViewData;
	/// <summary>
	/// Class to handle all the business logic related to the Sales Police Register
	/// </summary>
	class SalesPrModel
	{

		FileHandles fileHandles;
		CSVHandles csvHandles;

		/// <summary>
		/// Initializes a new instance of the <see cref="SalesPrModel"/> class.
		/// </summary>
		/// <param name="fh">The fh.</param>
		/// <param name="csvh">The CSVH.</param>
		public SalesPrModel(FileHandles fh, CSVHandles csvh) 
		{
			fileHandles = fh;
			csvHandles = csvh;
			createLogFiles();
		}

		/// <summary>
		/// Gets all the months for which sales police registers have been recorded.
		/// </summary>
		/// <returns>A List of strings with all the months.</returns>
		/// <exception cref="Exception">ex.Message</exception>
		public List<string> getMonths()
		{
			try
			{
				return fileHandles.getLogNames(FileHandles.LogType.SalesPoliceRegisters);
			}
			catch (Exception ex) 
			{
				throw new Exception(ex.Message);
			}
		}

		/// <summary>
		/// Gets the grid data to be displayed on the sales police register.
		/// </summary>
		/// <param name="month">The month.</param>
		/// <returns>An object of type grid data.</returns>
		public GridViewData getGridData(string month) 
		{
			GridViewData data = new GridViewData();
			string pathToSalesLog = fileHandles.pathToLogs(FileHandles.LogType.SalesPoliceRegisters, month);

			try
			{
				data.data = csvHandles.getCSVContents(pathToSalesLog);
				data.dates = csvHandles.getDatesInFile(pathToSalesLog);
				return data;
			}
			catch (Exception ex) 
			{
				throw new Exception(ex.Message);
			}
		}

		/// <summary>
		/// Creates the log files for the Sales Police Register.
		/// </summary>
		private void createLogFiles()
		{
			//For the police register, we will use the same headers as the purchases files
			string salesPRLogHeaders = GenericModels.enumFieldsToString<PurchasesModel.PurchaseLogHeaders>();
			fileHandles.createCSVFile(FileHandles.LogType.SalesPoliceRegisters, salesPRLogHeaders);
		}

		/// <summary>
		/// Adds entries to the sales police register.
		/// </summary>
		public void addToSalesRegister(string entry) 
		{
			string path = fileHandles.pathToLogs(FileHandles.LogType.SalesPoliceRegisters);
			bool entryAlreadyAdded = csvHandles.entryExistsInCSV(path,entry);

			try
			{
				//Check if the entry has not already been added to the police register.
				if (entryAlreadyAdded) throw new EntryAlreadyAddedException();
				csvHandles.addToCSV(path, new List<string>(){ entry });
			}
			catch (Exception ex) 
			{
				throw new Exception(ex.Message);
			}
		}

		/// <summary>
		/// Deteles an entry from the Sales Police Register log file.
		/// </summary>
		/// <param name="rowToDelete">The row to delete.</param>
		/// <param name="month">The month.</param>
		/// <exception cref="System.Exception"></exception>
		public void deleteEntry(string rowToDelete, string month) 
		{
			string pathToLog = fileHandles.pathToLogs(FileHandles.LogType.SalesPoliceRegisters, month);
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
}
