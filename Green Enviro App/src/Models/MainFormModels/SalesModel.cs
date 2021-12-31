using System;
using System.Collections.Generic;
using System.Data;
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

		/// <summary>Gets the list of companies where sales can be made.</summary>
		/// <returns>A list of strings representing the company names.</returns>
		/// <exception cref="System.Exception">If there is a problem retrieving the company names from the database.</exception>
		public List<string> getCompanies() 
		{
			List<string> companiesList;
			try
			{
				DataTable buyers = database.selectAll(Database.Tables.Buyers);
				string companies = GenericModels.enumToString<Database.BuyersTableColumns>(Database.BuyersTableColumns.Company);
				companiesList = buyers.AsEnumerable().Select(r => r.Field<string>(companies)).ToList();
			}
			catch (Exception ex) 
			{
				throw new Exception(ex.Message);
			}
			return companiesList;
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

		/// <summary>Gets the log of the sales given the required month.</summary>
		/// <param name="month">The month.</param>
		/// <returns>GridViewData object containing the information in the log file.</returns>
		/// <exception cref="System.Exception"></exception>
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

		/// <summary>Deletes a sale entry given the sale information and log month.</summary>
		/// <param name="rowToDelete">The row to delete.</param>
		/// <param name="month">The month.</param>
		public void deleteSale(string rowToDelete, string month) 
		{
			string pathToLog = fileHandles.pathToLogs(FileHandles.LogType.Sales, month);
			csvHandles.setRowToDelete(rowToDelete);
			csvHandles.deleteInCSV(pathToLog);
		}

		/// <summary>Adds a sale entry given the sale info.</summary>
		/// <param name="saleInfo">Object with all the sale information.</param>
		public void addSale(SaleInfo saleInfo) 
		{
			string saleMonth = saleInfo.date.ToString(Constants.LOG_NAME_DATE_FORMAT);
			string currentTime = DateTime.Now.ToString(Constants.TIME_FORMAT);
			string saleDate = saleInfo.date.ToString(Constants.DATE_FORMAT) + currentTime;
			string saleInfoString = saleDate + "," + saleInfo.company + "," + saleInfo.quantity + "," + saleInfo.amount + "," + saleInfo.type;
			string pathToSaleLog = fileHandles.pathToLogs(FileHandles.LogType.Sales, saleMonth);

			try
			{
				csvHandles.addToCSV(pathToSaleLog, new List<string>() { saleInfoString });
			}
			catch (Exception ex) 
			{
				throw new Exception(ex.Message);
			}

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

		/// <summary>
		/// Object to describe the sale information.
		/// </summary>
		internal class SaleInfo 
		{
			public SaleInfo() 
			{
				company = "";
				quantity = Constants.DECIMAL_ZERO;
				type = "";
				amount = Constants.DECIMAL_ZERO;
			}

			/// <summary>Gets or sets the sale date.</summary>
			/// <value>The date.</value>
			public DateTime date { get; set; }
			/// <summary>Gets or sets the company name.</summary>
			/// <value>The company as a string.</value>
			public string company { get; set; }
			/// <summary>Gets or sets the quantity sold.</summary>
			/// <value>The quantity in decimal form.</value>
			public decimal quantity { get; set; }
			/// <summary>Gets or sets the type of scrap sold.</summary>
			/// <value>The type in string format.</value>
			public string type { get; set; }
			/// <summary>Gets or sets the amount received after the sale.</summary>
			/// <value>The amount in decimal format.</value>
			public decimal amount { set; get; }
		}
	}
}
