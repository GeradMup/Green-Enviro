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
		static string _month = DateTime.Now.ToString("MMMM yyyy");
		string _path_to_purchases = @"..//..//resources//Logs//Purchases//" + _month + ".csv";
		string _path_to_sales = @"..//..//resources//Logs//Sales//" + _month + ".csv";
		string _path_to_expenses = @"..//..//resources//Logs//Expenses//" + _month + ".csv";
		string _path_to_wages = @"..//..//resources//Logs//Wages//" + _month + ".csv";
		Main_Form _main_form;

		DataTable _purchases_data_table = new DataTable();
		public Logs(Main_Form _main)
		{
			_main_form = _main;
			CreateLogFiles();
			SetupPurchaseLogs();
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

		public void DisplayLog() 
		{
			_purchases_data_table.Clear();
			string[] lines = System.IO.File.ReadAllLines(_path_to_purchases);
			if (lines.Length > 0)
			{
				//first line to create header
				string _first_line = lines[0];
				string[] _header_labels = _first_line.Split(',');
				if (!_purchases_data_table.Columns.Contains(_header_labels[0]))
				{
					foreach (string _header_word in _header_labels)
					{
						_purchases_data_table.Columns.Add(new DataColumn(_header_word));
					}
				}

				//For Data
				for (int i = 1; i < lines.Length; i++)
				{
					string[] dataWords = lines[i].Split(',');
					DataRow _data_row = _purchases_data_table.NewRow();
					int columnIndex = 0;
					foreach (string headerWord in _header_labels)
					{
						_data_row[headerWord] = dataWords[columnIndex++];
					}
					_purchases_data_table.Rows.Add(_data_row);
				}
			}

			if (_purchases_data_table.Rows.Count > 0)
			{
				_main_form.PurchseLogGridView.DataSource = _purchases_data_table;
				_main_form.PurchseLogGridView.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
				_main_form.PurchseLogGridView.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
			}

		}

		public void SetupPurchaseLogs() 
		{
			//This function will get the names of all the purchase log files that exists in the purchases folder
			string _purchase_logs_path = @"..//..//resources//Logs//Purchases";
			DirectoryInfo _directory = new DirectoryInfo(_purchase_logs_path);//Assuming Test is your Folder
			FileInfo[] _files = _directory.GetFiles("*.csv"); //Getting Text files
			foreach (FileInfo _file in _files)
			{
				char[] _remove_chars = {'c','s','v','.' };
				string _file_name = _file.Name.TrimEnd(_remove_chars);
				_main_form.PurchaseLogMonth.Items.Add(_file_name);
			}
		}
	}
}
