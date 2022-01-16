using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Green_Enviro_App.src.DataAccess;

namespace Green_Enviro_App
{
	using GridViewData = DGVOps.GridViewData;
	class ExpensesModel
	{
		CSVHandles csvHandles;
		FileHandles fileHandles;

		/// <summary>Initializes a new instance of the <see cref="ExpensesModel" /> class.</summary>
		/// <param name="db">The database.</param>
		/// <param name="csvH">The CSV h.</param>
		/// <param name="fh">The fh.</param>
		public ExpensesModel(CSVHandles csvH, FileHandles fh) 
		{
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
			bool newFileCreated = fileHandles.createCSVFile(FileHandles.LogType.Expenses, expensesLogHeaders);
			if (newFileCreated) recordFixedExpenses();
		}

		/// <summary>
		/// Records fixed expenses at the begining of every month.
		/// </summary>
		private void recordFixedExpenses() 
		{
			//DataTable fixedExpenses = database.selectAll(Database.Tables.FixedExpenses);
			ExpenseInfo expenseInfo = new ExpenseInfo();

			List<FixedExpens> fixedExpenses;
			using (DataEntities context = new DataEntities())
			{
				fixedExpenses = context.FixedExpenses.ToList();
			}	 

			foreach (FixedExpens expense in fixedExpenses) 
			{
				expenseInfo.date = DateTime.Now;
				expenseInfo.description = expense.Name;
				expenseInfo.amount = expense.Amount;
				addExpense(expenseInfo);
			}
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
		public GridViewData gridViewData(string month) 
		{
			string pathToLog = fileHandles.pathToLogs(FileHandles.LogType.Expenses, month);
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

		/// <summary>Deletes an expense entry with the given information in the given expenses log.</summary>
		/// <param name="expenseInfo">The expense information.</param>
		/// <param name="month">The log month.</param>
		/// <returns>The updated grid view data after the deletion.</returns>
		public GridViewData deleteExpense(string expenseInfo, string month) 
		{
			string pathToLog = fileHandles.pathToLogs(FileHandles.LogType.Expenses, month);

			//First update the substring that identifies the row to be deleted.
			csvHandles.setRowToDelete(expenseInfo);
			csvHandles.deleteInCSV(pathToLog);

			return gridViewData(month);			
		}

		/// <summary>Adds a new expense to the records of expenses.</summary>
		/// <param name="expenseInfo">The expense information.</param>
		/// <returns>The updated grid view data after recording the expense.</returns>
		/// <exception cref="System.Exception">If somthing goes wrong with the insertion of the expense.</exception>
		public GridViewData addExpense(ExpenseInfo	expenseInfo) 
		{
			string paymentMonth = expenseInfo.date.ToString(Constants.LOG_NAME_DATE_FORMAT);
			string currentTime = DateTime.Now.ToString(Constants.TIME_FORMAT);
			string paymentDate = expenseInfo.date.ToString(Constants.DATE_FORMAT) + currentTime;
			string expensesInfoString = paymentDate + "," + expenseInfo.description + "," + expenseInfo.amount.ToString();
			string pathToExpensesLog = fileHandles.pathToLogs(FileHandles.LogType.Expenses, paymentMonth);

			try
			{
				csvHandles.addToCSV(pathToExpensesLog, new List<string>() { expensesInfoString });
			}
			catch (Exception ex)
			{
				throw new Exception(ex.Message);
			}

			return gridViewData(paymentMonth);
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

			/// <summary>
			/// Creates a new instance of the <see cref="ExpenseInfo" /> class.</summary>
			public ExpenseInfo() 
			{
				date = DateTime.Now;
				description = "";
				amount = Constants.DECIMAL_ZERO;
			}
			public DateTime date { get; set; }

			/// <summary>Gets or sets the description of the expense.</summary>
			/// <value>The description.</value>
			public string description { get; set; }

			/// <summary>Gets or sets the amount that the expense costed.</summary>
			/// <value>The amount.</value>
			public decimal amount { set; get; }
		}
	}
}
