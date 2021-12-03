using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Green_Enviro_App
{
	using GridViewData = DGVOps.GridViewData;
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
			string wagesFileHeaders = GenericModels.enumFieldsToString<WagesLogHeaders>();
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

		/// <summary>
		/// Gets the data grid view data for a given month.
		/// </summary>
		/// <param name="month">The month.</param>
		/// <returns>A GridViewData object.</returns>
		public GridViewData gridViewData(string month) 
		{
			string pathToLog = fileHandles.pathToLogs(FileHandles.LogType.Wages, month);
			GridViewData gridData = new GridViewData();
			gridData.data = csvHandles.getCSVContents(pathToLog);
			gridData.dates = csvHandles.getDatesInFile(pathToLog);

			//After reading the data from the file, now we want to add the total to the amount column
			DataRow totalsRow = gridData.data.NewRow();
			string amountColumn = GenericModels.enumToString<WagesLogHeaders>(WagesLogHeaders.Amount);

			double totalAmount = 0.0;
			double total = gridData.data.AsEnumerable()
							.Where(r => double.TryParse(r.Field<string>(amountColumn), out totalAmount))
							.Sum(r => totalAmount);

			for (int x = 0; x < totalsRow.ItemArray.Length; x++) totalsRow[x] = string.Empty;
			totalsRow[amountColumn] = total;
			gridData.data.Rows.Add(totalsRow);
			return gridData;
		}

		/// <summary>Deletes a wedge entry from the log file given the wage information and the log month and returns the updated GridData</summary>
		/// <param name="wageInfo">The wage information.</param>
		/// <param name="wageLogMonth">The wage log month.</param>
		/// <returns>The updated GridData.</returns>
		public GridViewData deleteWage(string wageInfo, string wageLogMonth) 
		{
			string pathToLog = fileHandles.pathToLogs(FileHandles.LogType.Wages, wageLogMonth);
			
			//First update the substring that identifies the row to be deleted.
			csvHandles.setDeleteRowInfo(wageInfo);
			csvHandles.DeleteInCSV(pathToLog);

			return gridViewData(wageLogMonth);
		}

		/// <summary>Gets all the employees who are registered in the company.</summary>
		/// <returns>A list of strings containing all the employees names and surnames.</returns>
		public List<string> getEmployees()
		{
			DataTable employees = database.selectAll(Database.Tables.Employees);
			List<string> employeesString = new List<string>();
			int employeeNameColumn = 1;
			int employeeSurnameColumn = 2;
			string employeeNameAndSurname = "";
			foreach (DataRow row in employees.Rows)
			{
				employeeNameAndSurname = row[employeeNameColumn].ToString() + " " + row[employeeSurnameColumn].ToString();
				employeesString.Add(employeeNameAndSurname);
			}
			return employeesString;
		}

		/// <summary>Adds a new wage entry and returns the DataGridInfo with the updated wages.</summary>
		/// <param name="wageInfo">The wage information.</param>
		/// <returns>The updated grid data</returns>
		public GridViewData addWage(WageInfo wageInfo) 
		{
			string paymentMonth = wageInfo.paymentDate.ToString("MMMM yyyy");
			string currentTime = DateTime.Now.ToString("HH:mm:ss");
			string wageInfoString = wageInfo.paymentDate.ToString("dd MMMM yyyy ") + currentTime + "," + wageInfo.employeeName + "," + wageInfo.amount.ToString();
			string pathToWageLog = fileHandles.pathToLogs(FileHandles.LogType.Wages, paymentMonth);

			try
			{
				csvHandles.addToCSV(pathToWageLog, new List<string>(){ wageInfoString });
			}
			catch (Exception ex) 
			{
				throw new Exception(ex.Message);
			}
			
			return gridViewData(paymentMonth);
		}

		enum WagesLogHeaders 
		{
			Date,
			Name,
			Amount
		}


		/// <summary>Class object to hold the information required when recording a wage.</summary>
		internal class WageInfo 
		{
			/// <summary>Initializes a new instance of the <see cref="WageInfo" /> class.</summary>
			public WageInfo() 
			{
				employeeName = "";
				paymentDate = DateTime.Now;
				amount = Constants.DECIMAL_ZERO;
			}

			/// <summary>Gets or sets the name of the employee.</summary>
			/// <value>The name of the employee.</value>
			public string employeeName { set; get; }

			/// <summary>Gets or sets the payment date.</summary>
			/// <value>The payment date.</value>
			public DateTime paymentDate { set; get; }

			/// <summary>Gets or sets the payment amount.</summary>
			/// <value>The amount.</value>
			public decimal amount { set; get; }
		}
	}
}
