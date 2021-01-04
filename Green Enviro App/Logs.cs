using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Green_Enviro_App
{
	class Logs
	{
		//First we need to know what month it is
		static string _month = DateTime.Now.ToString("MMMM_yyyy");
		string _path_to_purchases = @"..//..//resources//Logs//Purchases//" + _month + ".csv";
		string _path_to_sales = @"..//..//resources//Logs//Sales//" + _month + ".csv";
		string _path_to_expenses = @"..//..//resources//Logs//Expenses//" + _month + ".csv";
		string _path_to_wages = @"..//..//resources//Logs//Wages//" + _month + ".csv";
		public Logs()
		{
			CreateLogFiles();
		}


		//Create purchase and sales logs for each month if they don't already exist
		private void CreateLogFiles()
		{
			//First Check if the files exist for each month
			if (!File.Exists(_path_to_purchases))
			{
				string _purchases_file_headers = "Date,Name,Surname,ID,Number,Item,Quantity,Price,Amount,F/N";
				CreateFile(_path_to_purchases, _purchases_file_headers);
			}

			if (!File.Exists(_path_to_sales))
			{
				string _sales_file_headers = "Date,Company,Quantity,Amount,F/N";
				CreateFile(_path_to_sales, _sales_file_headers);
			}

			if (!File.Exists(_path_to_expenses))
			{
				string _expenses_file_headers = "Date,Description,Amount";
				CreateFile(_path_to_expenses, _expenses_file_headers);
			}

			if (!File.Exists(_path_to_wages))
			{
				string _wages_file_headers = "Date,Person,Amount";
				CreateFile(_path_to_wages, _wages_file_headers);
			}
		}

		private void CreateFile(string path, string headers)
		{
			StringBuilder _csv_content = new StringBuilder();
			_csv_content.AppendLine(headers);
			File.AppendAllText(path, _csv_content.ToString());
		}

		public void AddPurchase(List<string> purchasedItems)
		{
			StringBuilder _csv_content = new StringBuilder();
			
			foreach (string _purchase_entry in purchasedItems)
			{
				_csv_content.AppendLine(_purchase_entry);
			}

			try
			{
				File.AppendAllText(_path_to_purchases, _csv_content.ToString());
				MessageBox.Show("Purchase Completed!");
			}
			catch (Exception ex) 
			{
				MessageBox.Show("Error! \n" + ex.Message);
			}
		}

		public void AddSale() 
		{ 
		
		}

		public void AddExpense() 
		{ 
		
		}

		public void AddWage() 
		{
			
		}

		private void ActionCompleted(string message) 
		{
			
		}
	}
}
