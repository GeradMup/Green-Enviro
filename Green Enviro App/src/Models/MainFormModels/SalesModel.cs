using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Green_Enviro_App
{
	using GridViewData = DGVOps.GridViewData;

	/// <summary>
	/// Class to handle all business logic regarding sales.
	/// </summary>
	class SalesModel
	{
		Database database;
		FileHandles fileHandles;
		CSVHandles csvHandles;

		/// <summary>Initializes a new instance of the <see cref="SalesModel" /> class.</summary>
		/// <param name="db">The database object.</param>
		/// <param name="fh">The fileHandles object.</param>
		/// <param name="csvh">The CSVHandles object.</param>
		public SalesModel(Database db, FileHandles fh, CSVHandles csvh) 
		{
			database = db;
			fileHandles = fh;
			csvHandles = csvh;
			createLogFile();
		}

		/// <summary>
		/// Creates the log file for the month if it does not already exist.
		/// </summary>
		private void createLogFile() 
		{
			string salesLogHeaders = GenericModels.enumFieldsToString<SalesLogHeaders>();
			fileHandles.createCSVFile(FileHandles.LogType.Sales, salesLogHeaders);
		}

		/// <summary>
		/// Gets all the months for which sales were recorded.
		/// </summary>
		/// <returns>A list of strings representing the months.</returns>
		public List<string> getMonths() 
		{
			return fileHandles.getLogNames(FileHandles.LogType.Sales);
		}

		/// <summary>Gets the amount column.</summary>
		/// <returns>An integer respresenting the amount column.</returns>
		public int getAmountColumn() 
		{
			return (int)SalesLogHeaders.Amount;
		}

		/// <summary>Gets the quantity column.</summary>
		/// <returns>An integer representing the quanity column.</returns>
		public int getQuantityColumn() 
		{
			return (int)SalesLogHeaders.Quantity;
		}

		public GridViewData getGridData(string month) 
		{
			string pathToLog = fileHandles.pathToLogs(FileHandles.LogType.Sales, month);
			GridViewData gridData = new GridViewData();

			try
			{
				gridData.data = csvHandles.getCSVContents(pathToLog);
				gridData.dates = csvHandles.getDatesInFile(pathToLog);
			}
			catch (Exception ex) 
			{
				throw new Exception(ex.Message);
			}
			return gridData;
		}

		/// <summary>
		/// Enum class to describe the sales log headers.
		/// </summary>
		enum SalesLogHeaders 
		{
			/// <summary>The date</summary>
			Date,
			/// <summary>The company</summary>
			Company,
			/// <summary>The quantity</summary>
			Quantity,
			/// <summary>The amount</summary>
			Amount,
			/// <summary>The type</summary>
			Type
		}
	}
}
