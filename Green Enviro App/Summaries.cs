using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Green_Enviro_App
{
	class Summaries
	{
		string _ferrous = "Ferrous";
		string _non_ferrous = "Non-Ferrous";
		Main_Form _main_form;

		float _total_ferrous_purchases = 0;
		float _total_non_ferrous_purchases = 0;
		float _total_ferrous_sales = 0;
		float _total_non_ferrous_sales = 0;
		float _total_purchases = 0;
		float _total_sales = 0;
		float _total_wages = 0;
		float _total_expenses = 0;
		float _profit = 0;
		float _total_float = 0;

		public Summaries(Main_Form main) 
		{
			_main_form = main;
			Setup();
		}

		private void Setup() 
		{
			foreach (var item in _main_form.PurchaseLogMonth.Items) 
			{
				_main_form.SummariesMonthSelector.Items.Add(item.ToString());
			}
		}

		public void MonthSelected() 
		{
			if (_main_form.SummariesMonthSelector.SelectedItem == null) 
			{
				//Do nothing if no month is selected
				return;
			}

			string _month = _main_form.SummariesMonthSelector.SelectedItem.ToString();
			string _path_to_purchases_file = @"..//..//resources//Logs//Purchases//" + _month + ".csv";
			string _path_to_sales_file = @"..//..//resources//Logs//Sales//" + _month + ".csv";
			string _path_to_expenses_file = @"..//..//resources//Logs//Expenses//" + _month + ".csv";
			string _path_to_wages_file = @"..//..//resources//Logs//Wages//" + _month + ".csv";
			string _path_to_total_float = @"..//..//resources//Float//" + _month + "_total_float.csv";

			//Read all the lines		

			//Starting with the purchases
			Purchases(_path_to_purchases_file);
			Sales(_path_to_sales_file);
			Wages(_path_to_wages_file);
			Expenses(_path_to_expenses_file);
			Float(_path_to_total_float);
			Profit();
			Display();
		}

		private void Purchases(string _path_to_purchases_file) 
		{
			string[] _purchases_lines = System.IO.File.ReadAllLines(_path_to_purchases_file);
			_total_ferrous_purchases = 0;
			_total_non_ferrous_purchases = 0;
			int _type_column = 9;
			int _amount_column = 8;

			if (_purchases_lines.Length > 0)
			{
				for (int _row = 1; _row < _purchases_lines.Length; _row++)
				{
					//For each line, we want a list of the words on the line seperated by the comma
					string[] dataWords = _purchases_lines[_row].Split(',');

					if (dataWords[_type_column] == _ferrous)
					{
						_total_ferrous_purchases += float.Parse(dataWords[_amount_column], CultureInfo.InvariantCulture);
					}
					else if (dataWords[_type_column] == _non_ferrous)
					{
						_total_non_ferrous_purchases += float.Parse(dataWords[_amount_column], CultureInfo.InvariantCulture);
					}
				}
			}
			_total_purchases = _total_non_ferrous_purchases + _total_ferrous_purchases;
		}

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
		 	_total_float =  float.Parse(File.ReadAllText(_path_to_float_file), CultureInfo.InvariantCulture);
		}

		private void Profit() 
		{
			_profit = _total_ferrous_sales + _total_non_ferrous_sales - _total_ferrous_purchases - _total_non_ferrous_purchases - _total_wages - _total_expenses;
		}

		private void Display() 
		{
			ClearFields();

			_main_form.SummariesFPurchasesBox.AppendText("\n  R " + _total_ferrous_purchases.ToString());
			_main_form.SummariesNFPurchasesBox.AppendText("\n  R " + _total_non_ferrous_purchases.ToString());
			
			_main_form.SummariesFSalesBox.AppendText("\n  R " + _total_ferrous_sales.ToString());
			_main_form.SummariesNFSalesBox.AppendText("\n  R " + _total_non_ferrous_sales.ToString());

			_main_form.SummariesWagesBox.AppendText("\n  R " + _total_wages.ToString());

			_main_form.SummariesExpensesBox.AppendText("\n  R " + _total_expenses.ToString());

			_main_form.SummariesProfitBox.AppendText("\n  R " + _profit);
			
			_main_form.SummariesTotalPurchases.AppendText("\n  R " + _total_purchases);
			
			_main_form.SummariesTotalSales.AppendText("\n R " + _total_sales);
			
			_main_form.SummariesTotalFloat.AppendText("\n R " + _total_float);

			if (_profit < 0)
			{
				_main_form.SummariesProfitBox.BackColor = Color.Red;
			}
			else 
			{
				_main_form.SummariesProfitBox.BackColor = Color.LawnGreen;
			}

		}

		private void ClearFields() 
		{
			_main_form.SummariesFPurchasesBox.Clear();
			_main_form.SummariesNFPurchasesBox.Clear();

			_main_form.SummariesFSalesBox.Clear();
			_main_form.SummariesNFSalesBox.Clear();

			_main_form.SummariesWagesBox.Clear();

			_main_form.SummariesExpensesBox.Clear();

			_main_form.SummariesProfitBox.Clear();

			_main_form.SummariesTotalPurchases.Clear();

			_main_form.SummariesTotalSales.Clear();

			_main_form.SummariesTotalFloat.Clear();

			_main_form.SummariesProfitBox.BackColor = Color.White;
		}

		public void Reset() 
		{
			_main_form.SummariesMonthSelector.SelectedItem = null;
			ClearFields();
		}
	}
}
