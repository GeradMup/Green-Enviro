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

		/// <summary>Creates the expenses log files for each month.</summary>
		private void createLogFiles() 
		{
			string expensesLogHeaders = GenericModels.enumFieldsToString<ExpensesLogHeaders>();
			fileHandles.createCSVFile(FileHandles.LogType.Expenses, expensesLogHeaders);
		}

		/// <summary>Gets all the months for which expenses have been recorded.</summary>
		public List<string> getMonths() 
		{
			return fileHandles.getLogNames(FileHandles.LogType.Expenses);
		}

		/// <summary>Enum class to describe the Expenses Log headers.</summary>
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
