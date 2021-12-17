using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Green_Enviro_App
{
	using GridViewData = DGVOps.GridViewData;
	class ExpensesModel
	{
		Database database;
		CSVHandles csvHandles;
		FileHandles fileHandles;

		/// <summary>Initializes a new instance of the <see cref="ExpensesModel" /> class.</summary>
		/// <param name="db">The database.</param>
		/// <param name="csvH">The CSV h.</param>
		/// <param name="fh">The fh.</param>
		public ExpensesModel(Database db, CSVHandles csvH, FileHandles fh) 
		{
			database = db;
			csvHandles = csvH;
			fileHandles = fh;
			createLogFiles();
		}

		/// <summary>
		/// Creates the expenses log files for each month.
		/// </summary>
		private void createLogFiles() 
		{
			string expensesLogHeaders = GenericModels.enumFieldsToString<ExpensesLogHeaders>();
			fileHandles.createCSVFile(FileHandles.LogType.Expenses, expensesLogHeaders);
		}

		/// <summary>
		/// Gets all the months for which expenses have been recorded.
		/// </summary>
		public List<string> getMonths() 
		{
			return fileHandles.getLogNames(FileHandles.LogType.Expenses);
		}

		/// <summary>Gets the log dates.</summary>
		/// <param name="month">The month.</param>
		/// <returns>HashSet of strings containing all the dates.</returns>
		public HashSet<string> getLogDates(string month) 
		{
			string pathToLogFile = fileHandles.pathToLogs(FileHandles.LogType.Expenses, month);
			return csvHandles.getDatesInFile(pathToLogFile);
		}


		/// <summary>Gets the amount column.</summary>
		/// <returns>An integer representing the amount column number.</returns>
		public int getAmountColumn()
		{
			return (int)ExpensesLogHeaders.Amount;
		}


		/// <summary>Gets the grid view data.</summary>
		/// <param name="month">The month.</param>
		/// <returns>An object of type GridViewData.</returns>
		public DGVOps.GridViewData gridViewData(string month) 
		{
			string pathToLog = fileHandles.pathToLogs(FileHandles.LogType.Expenses, month);
			GridViewData gridData = new GridViewData();
			gridData.data = csvHandles.getCSVContents(pathToLog);
			gridData.dates = csvHandles.getDatesInFile(pathToLog);
			return gridData;
		}

		/// <summary>
		/// Enum class to describe the Expenses Log headers.
		/// </summary>
		enum ExpensesLogHeaders 
		{
			Date,
			Description,
			Amount
		}

		internal class ExpenseInfo 
		{
			
		}
	}
}
