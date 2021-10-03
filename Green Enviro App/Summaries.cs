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
			//getMonths();
		}
/*
		private void getMonths() 
		{
			foreach (var item in _main_form.PurchaseLogMonth.Items) 
			{
				_main_form.SummariesMonthSelector.Items.Add(item.ToString());
			}
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
			
			_main_form.SummariesTotalPurchases.AppendText("\n R " + _total_purchases);
			
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
*/	}
}
