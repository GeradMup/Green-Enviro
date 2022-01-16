using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Green_Enviro_App
{
	class SummariesModel
	{
		FileHandles fileHandles;
		CSVHandles csvHandles;
		public SummariesModel(FileHandles fh, CSVHandles ch) 
		{
			fileHandles = fh;
			csvHandles = ch;
		}

		/// <summary>
		/// Gets all all the months for which summaries can be calculated.
		/// Summaries will base its months on the number of months for which purchases are available.
		/// </summary>
		/// <returns>A list of strings representing the months.</returns>
		public List<string> getMonths()
		{
			return fileHandles.getLogNames(FileHandles.LogType.Purchases);
		}

		public AllSummaries getSummaries(string selectedMonth)
		{
			Purchases purchasesSummary = purchases(selectedMonth);
			Sales salesSummary = sales(selectedMonth);
			double totalWages = wages(selectedMonth);
			double totalExpenses = expenses(selectedMonth);
			double profit = salesSummary.totalSales - purchasesSummary.totalPurchases - totalWages - totalExpenses;

			AllSummaries allSummarise = new AllSummaries();
			allSummarise.totalPurchases = Math.Round(purchasesSummary.totalPurchases, 0);
			allSummarise.totalFerrousPurchases = Math.Round(purchasesSummary.totalFerrousPurchases, 0);
			allSummarise.totalNonFerrousPurchases = Math.Round(purchasesSummary.totalNonFerrousPurchases, 0);
			allSummarise.totalSales = Math.Round(salesSummary.totalSales, 0);
			allSummarise.totalFerrousSales = Math.Round(salesSummary.totalFerrousSales, 0);
			allSummarise.totalNonFerrousSales = Math.Round(salesSummary.totalNonFerrousSales, 0);
			allSummarise.totalWages = Math.Round(totalWages, 0);
			allSummarise.totalExpenses = Math.Round(totalExpenses, 0);
			allSummarise.totalProfit = Math.Round(profit, 0);
			allSummarise.profitMade = profit > 0;

			return allSummarise;
		}

		private Purchases purchases(string month)
		{
			string filePath = fileHandles.pathToLogs(FileHandles.LogType.Purchases, month);
			DataTable purchaseEntries = csvHandles.getCSVContents(filePath);
			double totalFerrousPurchases = 0;
			double totalNonFerrousPurchases = 0;
			double totalPurchases = 0;
			int typeColumn = 9;
			int amountColumn = 8;

			if (purchaseEntries.Rows.Count > 0)
			{
				foreach (DataRow purchaseEntry in purchaseEntries.Rows)
				{
					if (purchaseEntry[typeColumn].ToString() == Constants.FERROUS)
					{
						totalFerrousPurchases += double.Parse(purchaseEntry[amountColumn].ToString(), CultureInfo.InvariantCulture);
					}
					else if (purchaseEntry[typeColumn].ToString() == Constants.NON_FERROUS)
					{
						totalNonFerrousPurchases += double.Parse(purchaseEntry[amountColumn].ToString(), CultureInfo.InvariantCulture);
					}
				}
			}
			totalPurchases = totalNonFerrousPurchases + totalFerrousPurchases;
			return new Purchases(totalPurchases, totalFerrousPurchases, totalNonFerrousPurchases);
		}

		private Sales sales(string month)
		{
			string filePath = fileHandles.pathToLogs(FileHandles.LogType.Sales, month);
			DataTable salesEntries = csvHandles.getCSVContents(filePath);

			double totalFerrousSales = 0;
			double totalNonFerrousSales = 0;
			double totalSales = 0;
			int typeColumn = 4;
			int amountColumn = 3;

			if (salesEntries.Rows.Count > 0)
			{
				foreach (DataRow saleEntry in salesEntries.Rows)
				{
					if (saleEntry[typeColumn].ToString() == Constants.FERROUS)
					{
						totalFerrousSales += double.Parse(saleEntry[amountColumn].ToString(), CultureInfo.InvariantCulture);
					}
					else if (saleEntry[typeColumn].ToString() == Constants.NON_FERROUS)
					{
						totalNonFerrousSales += double.Parse(saleEntry[amountColumn].ToString(), CultureInfo.InvariantCulture);
					}
				}
			}
			totalSales = totalNonFerrousSales + totalFerrousSales;
			return new Sales(totalSales, totalNonFerrousSales, totalFerrousSales);
		}

		private double wages(string month)
		{
			string filePath = fileHandles.pathToLogs(FileHandles.LogType.Wages, month);
			DataTable wagesEntries = csvHandles.getCSVContents(filePath);
			double totalWages = 0;

			int amountColumn = 2;

			if (wagesEntries.Rows.Count > 0)
			{
				foreach (DataRow wageEntry in wagesEntries.Rows)
				{
					totalWages += double.Parse(wageEntry[amountColumn].ToString(), CultureInfo.InvariantCulture);
				}
			}
			return totalWages;
		}

		private double expenses(string month)
		{
			string filePath = fileHandles.pathToLogs(FileHandles.LogType.Expenses, month);
			DataTable expensesEntries = csvHandles.getCSVContents(filePath);
			
			double totalExpenses = 0;
			int amountColumn = 2;

			if (expensesEntries.Rows.Count > 0)
			{
				foreach (DataRow expenseEntry in expensesEntries.Rows)				
					totalExpenses += double.Parse(expenseEntry[amountColumn].ToString(), CultureInfo.InvariantCulture);
			}
			return totalExpenses;
		}

		internal class AllSummaries 
		{
			/// <summary>
			/// Gets or sets the total wages.
			/// </summary>
			/// <value>
			/// The total wages.
			/// </value>
			public double totalWages { get; set; }
			
			/// <summary>
			/// Gets or sets the total expenses.
			/// </summary>
			/// <value>
			/// The total expenses.
			/// </value>
			public double totalExpenses { get; set; }
			
			/// <summary>
			/// Gets or sets the total ferrous purchases.
			/// </summary>
			/// <value>
			/// The total ferrous purchases.
			/// </value>
			public double totalFerrousPurchases { get; set; }
			
			/// <summary>
			/// Gets or sets the total non ferrous purchases.
			/// </summary>
			/// <value>
			/// The total non ferrous purchases.
			/// </value>
			public double totalNonFerrousPurchases { set; get; }
			
			/// <summary>
			/// Gets or sets the total purchases.
			/// </summary>
			/// <value>
			/// The total purchases.
			/// </value>
			public double totalPurchases { get; set; }
			
			/// <summary>
			/// Gets or sets the total ferrous sales.
			/// </summary>
			/// <value>
			/// The total ferrous sales.
			/// </value>
			public double totalFerrousSales { get; set; }
			
			/// <summary>
			/// Gets or sets the total non ferrous sales.
			/// </summary>
			/// <value>
			/// The total non ferrous sales.
			/// </value>
			public double totalNonFerrousSales { get; set; }
			
			/// <summary>
			/// Gets or sets the total sales.
			/// </summary>
			/// <value>
			/// The total sales.
			/// </value>
			public double totalSales { get; set; }
			
			/// <summary>
			/// Gets or sets the total profit.
			/// </summary>
			/// <value>
			/// The total profit.
			/// </value>
			public double totalProfit { set; get; }

			/// <summary>
			/// Gets or sets a value indicating whether there is profit or loss.
			/// </summary>
			/// <value>
			///   <c>true</c> if profit; otherwise, <c>false</c>.
			/// </value>
			public bool profitMade { set; get; }
		}

		internal class Purchases 
		{
			public Purchases(double _totalPurchases = 0, double _ferrousPurchases = 0, double _nonFerrousPurchases = 0) 
			{
				totalPurchases = _totalPurchases;
				totalFerrousPurchases = _ferrousPurchases;
				totalNonFerrousPurchases = _nonFerrousPurchases;
			}
			public double totalPurchases { get; set; }
			public double totalFerrousPurchases { get; set; }
			public double totalNonFerrousPurchases { get; set; }
		}

		internal class Sales
		{
			public Sales(double _totalSales = 0, double _ferrousSales = 0, double _nonFerrousSales = 0)
			{
				totalSales = _totalSales;
				totalFerrousSales = _ferrousSales;
				totalNonFerrousSales = _nonFerrousSales;
			}
			public double totalSales { get; set; }
			public double totalFerrousSales { get; set; }
			public double totalNonFerrousSales { get; set; }
		}
	}
}
