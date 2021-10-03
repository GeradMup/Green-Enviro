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

		public Summaries getSummaries(string selectedMonth)
		{
			//string _month = _main_form.SummariesMonthSelector.SelectedItem.ToString();
			//string _path_to_purchases_file = @"..//..//resources//Logs//Purchases//" + _month + ".csv";
			//string _path_to_sales_file = @"..//..//resources//Logs//Sales//" + _month + ".csv";
			//string _path_to_expenses_file = @"..//..//resources//Logs//Expenses//" + _month + ".csv";
			//string _path_to_wages_file = @"..//..//resources//Logs//Wages//" + _month + ".csv";
			//string _path_to_total_float = @"..//..//resources//Float//" + _month + "_total_float.csv";

			//Read all the lines		

			//Starting with the purchases
			Purchases purchaseSummary = purchases(selectedMonth);

			System.Windows.Forms.MessageBox.Show(purchaseSummary.totalPurchases.ToString());
			System.Windows.Forms.MessageBox.Show(purchaseSummary.totalFerrousPurchases.ToString());
			System.Windows.Forms.MessageBox.Show(purchaseSummary.totalNonFerrousPurchases.ToString());
			//Sales(selectedMonth);
			//Wages(selectedMonth);
			//Expenses(selectedMonth);
			//Float(selectedMonth);
			//Profit();
			//Display();

			return new Summaries();
		}

		private Purchases purchases(string month)
		{
			string filePath = fileHandles.pathToLogs(FileHandles.LogType.Purchases, month);
			DataTable purchases = csvHandles.getCSVContents(filePath);
			double totalFerrousPurchases = 0;
			double totalNonFerrousPurchases = 0;
			double totalPurchases = 0;
			int typeColumn = 9;
			int amountColumn = 8;

			if ( purchases.Rows.Count > 0)
			{
				foreach (DataRow purchaseEntry in purchases.Rows)
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
/*
		private void Sales(string _path_to_sales_file)
		{
			string[] _sales_lines = System.IO.File.ReadAllLines(_path_to_sales_file);

			_total_ferrous_sales = 0;
			_total_non_ferrous_sales = 0;
			int _type_column = 4;
			int _amount_column = 3;

			if (_sales_lines.Length > 0)
			{
				for (int _row = 1; _row < _sales_lines.Length; _row++)
				{
					//For each line, we want a list of the words on the line seperated by the comma
					string[] dataWords = _sales_lines[_row].Split(',');

					if (dataWords[_type_column] == _ferrous)
					{
						_total_ferrous_sales += float.Parse(dataWords[_amount_column], CultureInfo.InvariantCulture);
					}
					else if (dataWords[_type_column] == _non_ferrous)
					{
						_total_non_ferrous_sales += float.Parse(dataWords[_amount_column], CultureInfo.InvariantCulture);
					}
				}
			}
			_total_sales = _total_non_ferrous_sales + _total_ferrous_sales;
		}

		private void Wages(string _path_to_wages_file)
		{
			string[] _wages_lines = System.IO.File.ReadAllLines(_path_to_wages_file);
			_total_wages = 0;

			int _amount_column = 2;

			if (_wages_lines.Length > 0)
			{
				for (int _row = 1; _row < _wages_lines.Length; _row++)
				{
					//For each line, we want a list of the words on the line seperated by the comma
					string[] dataWords = _wages_lines[_row].Split(',');
					_total_wages += float.Parse(dataWords[_amount_column], CultureInfo.InvariantCulture);
				}
			}
		}

		private void Expenses(string _path_to_expenses_file)
		{
			string[] _expenses_lines = System.IO.File.ReadAllLines(_path_to_expenses_file);
			_total_expenses = 0;

			int _amount_column = 2;

			if (_expenses_lines.Length > 0)
			{
				for (int _row = 1; _row < _expenses_lines.Length; _row++)
				{
					//For each line, we want a list of the words on the line seperated by the comma
					string[] dataWords = _expenses_lines[_row].Split(',');
					_total_expenses += float.Parse(dataWords[_amount_column], CultureInfo.InvariantCulture);
				}
			}
		}

		private void Float(string _path_to_float_file)
		{
			_total_float = float.Parse(File.ReadAllText(_path_to_float_file), CultureInfo.InvariantCulture);
		}

		private void Profit()
		{
			_profit = _total_ferrous_sales + _total_non_ferrous_sales - totalFerrousPurchases - totalNonFerrousPurchases - _total_wages - _total_expenses;
		}*/

		internal class Summaries 
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
			/// Gets or sets the total float.
			/// </summary>
			/// <value>
			/// The total float.
			/// </value>
			public double totalFloat { set; get; }
			/// <summary>
			/// Gets or sets the total profit.
			/// </summary>
			/// <value>
			/// The total profit.
			/// </value>
			public double totalProfit { set; get; }
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
	}
}
