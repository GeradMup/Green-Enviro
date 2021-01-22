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
	class PurchaseLogs
	{
		//First we need to know what month it is
		static string _month = DateTime.Now.ToString("MMMM yyyy");
		string _path_to_purchases = @"..//..//resources//Logs//Purchases//" + _month + ".csv";
		string _path_to_expenses = @"..//..//resources//Logs//Expenses//" + _month + ".csv";
		string _path_to_wages = @"..//..//resources//Logs//Wages//" + _month + ".csv";
		Main_Form _main_form;

		DataTable _purchases_data_table = new DataTable();
		BindingSource _binding_source = new BindingSource();
		string _empty_string = " ";

		string _ferrous;
		string _non_ferrous;
		public PurchaseLogs(Main_Form _main)
		{
			_main_form = _main;
			CreateLogFiles();
			SetupPurchaseLogs();
		}

		public void setTypes(string F, string N) 
		{
			_ferrous = F;
			_non_ferrous = N;

			//Also setup the Ferrous or Non-Ferrous Selector
			_main_form.PurchaseLogType.Items.Add(_ferrous);
			_main_form.PurchaseLogType.Items.Add(_non_ferrous);
		}

		//Create purchase and sales logs for each month if they don't already exist
		private void CreateLogFiles()
		{
			//First Check if the files exist for each month
			//If the file does not exist, create it
			if (!File.Exists(_path_to_purchases))
			{
				string _purchases_file_headers = "Date,Name,Surname,ID,Number,Item,Quantity,Price,Amount,Type";
				StringBuilder _csv_content = new StringBuilder();
				_csv_content.AppendLine(_purchases_file_headers);
				File.AppendAllText(_path_to_purchases, _csv_content.ToString());
			}
		}

		private void CreateFile(string path, string headers)
		{

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

		public void DisplayPurchaseLog()
		{

			if (_main_form.PurchaseLogMonth.SelectedItem == null)
			{
				//Do nothing is the user has not selected what month they want to view
				return;
			}
			_purchases_data_table.Clear();

			string _selected_month = _main_form.PurchaseLogMonth.SelectedItem.ToString();
			string _path_to_log_file = @"..//..//resources//Logs//Purchases//" + _selected_month + ".csv";

			string[] lines = System.IO.File.ReadAllLines(_path_to_log_file);
			if (lines.Length > 0)
			{
				//first line to create the table headers
				string _first_line = lines[0];
				string[] _header_labels = _first_line.Split(',');
				if (!_purchases_data_table.Columns.Contains(_header_labels[0]))
				{
					foreach (string _header_word in _header_labels)
					{
						_purchases_data_table.Columns.Add(new DataColumn(_header_word));
					}
				}

				//Now we populate the table with the rest of the information that we want to view
				for (int _row = 1; _row < lines.Length; _row++)
				{
					//For each line, we want a list of the words on the line seperated by the comma
					string[] dataWords = lines[_row].Split(',');
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
				_binding_source.DataSource = _purchases_data_table;

				


				//Filter according to the date ranges if the dates have been selected correctly
				if (isDateFiltered() == true)
				{
					string _filter_start_date = _main_form.PurchaseLogStartDate.SelectedItem.ToString();
					string _filter_end_date = _main_form.PurchaseLogEndDate.SelectedItem.ToString();

					if (isTypeFiltered() == true)
					{
						string _item_type = _main_form.PurchaseLogType.SelectedItem.ToString();
						_binding_source.Filter = string.Format("Name = '{0}' OR Date >= '{1}' AND Date <= '{2}' AND Type = '{3}'", _empty_string, _filter_start_date, _filter_end_date, _item_type);
					}
					else
					{
						_binding_source.Filter = string.Format("Name = '{0}' OR Date >= '{1}' AND Date <= '{2}'", _empty_string, _filter_start_date, _filter_end_date);
					}
				}
				else
				{
					_binding_source.RemoveFilter();

					if (isTypeFiltered() == true)
					{
						string _item_type = _main_form.PurchaseLogType.SelectedItem.ToString();
						_binding_source.Filter = string.Format("Name = '{0}' OR Type = '{1}'", _empty_string, _item_type);
					}
				}

				_main_form.PurchseLogGridView.DataSource = _binding_source;
				_main_form.PurchseLogGridView.Columns[0].FillWeight = 120F;
				_main_form.PurchseLogGridView.Columns[3].FillWeight = 150F;

				AddTotalsRow();
				_main_form.PurchseLogGridView.Refresh();
			}

		}


		//This function will add up the KG's and Amount column on the Data Grid View and adds a row to show the totals
		private void AddTotalsRow() 
		{
			float _total_kg = 0;
			float _total_amount = 0;
			int _kg_column = 6;
			int _amount_column = 8;


			for (int _row = 0; _row < _main_form.PurchseLogGridView.Rows.Count - 1; _row++)
			{
				_total_amount += float.Parse(_main_form.PurchseLogGridView.Rows[_row].Cells[_amount_column].Value.ToString());
				_total_kg += float.Parse(_main_form.PurchseLogGridView.Rows[_row].Cells[_kg_column].Value.ToString());
			}

			//CustomMessageBox box = new CustomMessageBox("Total", "Kg's : " + _total_kg.ToString() + "\n" + "Amount : " + _total_amount.ToString());

			DataTable _totals_table = new DataTable();

			for (int _cols = 0; _cols < _main_form.PurchseLogGridView.Columns.Count; _cols++) 
			{
				DataColumn _new_column = new DataColumn();
				_totals_table.Columns.Add(_new_column);
			}

			DataRow _last_row = _purchases_data_table.NewRow();
			DataRow _empty_row = _purchases_data_table.NewRow();

			_last_row[0] = "TOTALS";
			for (int _cell = 1; _cell < _last_row.ItemArray.Length; _cell++)
			{
				_empty_row[_cell] = _empty_string;
				if (_cell == _amount_column)
				{
					_last_row[_cell] = _total_amount;
				}
				else if (_cell == _kg_column)
				{
					_last_row[_cell] = _total_kg;
				}
				else
				{
					_last_row[_cell] = _empty_string;
				}
			}

			_purchases_data_table.Rows.Add(_empty_row);
			_purchases_data_table.Rows.Add(_last_row);

		}

		public void SetupPurchaseLogs()
		{
			//This function will get the names of all the purchase log files that exists in the purchases folder
			string _purchase_logs_path = @"..//..//resources//Logs//Purchases";
			DirectoryInfo _directory = new DirectoryInfo(_purchase_logs_path);	//Assuming Test is your Folder
			FileInfo[] _files = _directory.GetFiles("*.csv");	//Getting Text files
			foreach (FileInfo _file in _files)
			{
				char[] _remove_chars = { 'c', 's', 'v', '.' };
				string _file_name = _file.Name.TrimEnd(_remove_chars);
				_main_form.PurchaseLogMonth.Items.Add(_file_name);
			}
		}

		public void MonthSelected() 
		{
			if (_main_form.PurchaseLogMonth.SelectedItem == null) 
			{
				//Do nothing if no month is selected
				return;
			}

			string _selected_month = _main_form.PurchaseLogMonth.SelectedItem.ToString();
			string _path_to_log_file = @"..//..//resources//Logs//Purchases//" + _selected_month + ".csv";

			string[] lines = System.IO.File.ReadAllLines(_path_to_log_file);
			HashSet<string> _dates = new HashSet<string>();

			if (lines.Length > 0) 
			{
				for (int _row = 1; _row < lines.Length; _row++) 
				{
					//For each line, we want a list of the words on the line seperated by the comma
					string[] dataWords = lines[_row].Split(',');

					//Now we want to add only the first word to a list of days if it is unique
					//In order to make sure that we do not repeat strings, we use a HashSet string
					_dates.Add(dataWords[0]);
				}
			}


			//First Clear the start and end date fields to prepare them for the new entry
			_main_form.PurchaseLogStartDate.Items.Clear();
			_main_form.PurchaseLogEndDate.Items.Clear();

			//Now Populate the drop down list with available dates only.
			foreach (string _date in _dates) 
			{
				_main_form.PurchaseLogStartDate.Items.Add(_date);
				_main_form.PurchaseLogEndDate.Items.Add(_date);
			}

			//Change the contents displayed in the log if the month selected changes
			RemoveFilters();
			
		}

		/// <summary>
		/// Determines whether a valid date range is select for filtering the Purchase Log.
		/// </summary>
		/// <returns>
		///   <c>true</c> if a valid date range is selected; otherwise, <c>false</c>.
		/// </returns>
		/// <remark>
		/// If an invalid date range is selected, the date fields are set back to null
		/// </remark>
		private bool isDateFiltered() 
		{
			if ((_main_form.PurchaseLogStartDate.SelectedItem == null) && (_main_form.PurchaseLogEndDate.SelectedItem == null)) 
			{
				//Do nothing if there are not filters selected
				return false;
			}

			if ((_main_form.PurchaseLogStartDate.SelectedItem != null) && (_main_form.PurchaseLogEndDate.SelectedItem == null))
			{
				//Do nothing if there are not filters selected
				CustomMessageBox msg = new CustomMessageBox ("Error!","INVALID DATE RANGE!");
				_main_form.PurchaseLogStartDate.SelectedItem = null;
				_main_form.PurchaseLogEndDate.SelectedItem = null;
				return false;
			}

			if ((_main_form.PurchaseLogStartDate.SelectedItem == null) && (_main_form.PurchaseLogEndDate.SelectedItem != null))
			{
				//Do nothing if there are not filters selected
				CustomMessageBox msg = new CustomMessageBox("Error!","INVALID DATE RANGE!");
				_main_form.PurchaseLogStartDate.SelectedItem = null;
				_main_form.PurchaseLogEndDate.SelectedItem = null;
				return false;
			}

			DateTime _start_date = Convert.ToDateTime(_main_form.PurchaseLogStartDate.SelectedItem.ToString());
			DateTime _end_date = Convert.ToDateTime(_main_form.PurchaseLogEndDate.SelectedItem.ToString());

			if (_start_date > _end_date) 
			{
				CustomMessageBox msg = new CustomMessageBox("Error!","INVALID DATE RANGE!");
				_main_form.PurchaseLogStartDate.SelectedItem = null;
				_main_form.PurchaseLogEndDate.SelectedItem = null;
				return false;
			}

			return true;
		}

		/// <summary>
		/// Determines whether the purchase box is type filtered or not
		/// </summary>
		/// <returns>
		///   <c>true</c> if either Ferrous or Non-Ferrous is selected; otherwise, <c>false</c>.
		/// </returns>
		private bool isTypeFiltered() 
		{
			if (_main_form.PurchaseLogType.SelectedItem == null)
			{
				return false;
			}
			else 
			{
				return true;
			}
		}

		/// <summary>
		/// Removes all the filters in the purchase log and displays all the existing entries
		/// </summary>
		public void RemoveFilters() 
		{
			_main_form.PurchaseLogStartDate.SelectedItem = null;
			_main_form.PurchaseLogEndDate.SelectedItem = null;
			_main_form.PurchaseLogType.SelectedItem = null;

			DisplayPurchaseLog();
		}
	}
}
