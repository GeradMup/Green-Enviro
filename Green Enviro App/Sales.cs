using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;
using System.IO;

namespace Green_Enviro_App
{
	class Sales
	{
		//First we need to know what month it is
		static string _month = DateTime.Now.ToString("MMMM yyyy");
		string _path_to_sales = @"..//..//resources//Logs//Sales//" + _month + ".csv";

		//Required objects
		Main_Form _main_form;
		Database _database;

		DataTable _sales_data_table = new DataTable();	//All the information about all the products the we have sold.
		DataTable _buyers;  //Companies that we sell and buy from
		List<string> _buyers_list = new List<string>();

		BindingSource _binding_source = new BindingSource();
		string _empty_string = " ";

		string _ferrous = "Ferrous";
		string _non_ferrous = "Non-Ferrous";
		bool _unknown_company = false;
		public Sales(Main_Form _main, Database data)
		{
			_main_form = _main;
			_database = data;
			CreateLogFiles();
			SetTypes();
			SetupSalesLogs();
			LoadBuyers();
		}

		public void SetTypes()
		{
			//Also setup the Ferrous or Non-Ferrous Selector
			_main_form.SaleTypeBx.Items.Add(_ferrous);
			_main_form.SaleTypeBx.Items.Add(_non_ferrous);

			_main_form.SalesLogType.Items.Add(_ferrous);
			_main_form.SalesLogType.Items.Add(_non_ferrous);
		}

		//Create purchase and sales logs for each month if they don't already exist
		private void CreateLogFiles()
		{
			//First Check if the files exist for each month
			//If the file does not exist, create it
			if (!File.Exists(_path_to_sales))
			{
				string _sales_file_headers = "Date,Company,Quantity,Amount,Type";
				StringBuilder _csv_content = new StringBuilder();
				_csv_content.AppendLine(_sales_file_headers);
				File.AppendAllText(_path_to_sales, _csv_content.ToString());
			}
		}

		public void SetupSalesLogs()
		{
			//This function will get the names of all the sales log files that exists in the Sales folder
			string _sales_logs_path = @"..//..//resources//Logs//Sales";
			DirectoryInfo _directory = new DirectoryInfo(_sales_logs_path);  //Assuming Test is your Folder
			FileInfo[] _files = _directory.GetFiles("*.csv");   //Getting Text files
			foreach (FileInfo _file in _files)
			{
				char[] _remove_chars = { 'c', 's', 'v', '.' };
				string _file_name = _file.Name.TrimEnd(_remove_chars);
				_main_form.SalesLogMonth.Items.Add(_file_name);
			}

			_main_form.SaleDate.Value = DateTime.Now;
		}

		private void LoadBuyers() 
		{
			//Gets all company details and stores them in a DataTable
			_buyers = _database.SelectAll("Buyers");

			//MessageBox.Show("All Customers: " + _customers.Rows.Count.ToString());

			_main_form.SaleCompanyNameList.Items.Clear();
			_buyers_list.Clear();

			int _company_name_index = 1;

			foreach (DataRow row in _buyers.Rows)
			{
				//Selects the customer numbers and adds to the drop down list on the receipt page
				_main_form.SaleCompanyNameList.Items.Add(row[_company_name_index]);
				_buyers_list.Add(row[_company_name_index].ToString());
			}
		}

		public void DisplaySalesLog()
		{

			if (_main_form.SalesLogMonth.SelectedItem == null)
			{
				//Do nothing is the user has not selected what month they want to view
				return;
			}
			//Clear the data table so that it can be ready for the next entries
			_sales_data_table.Clear();

			string _selected_month = _main_form.SalesLogMonth.SelectedItem.ToString();
			string _path_to_log_file = @"..//..//resources//Logs//Sales//" + _selected_month + ".csv";

			string[] lines = System.IO.File.ReadAllLines(_path_to_log_file);
			if (lines.Length > 0)
			{
				//first line to create the table headers
				string _first_line = lines[0];
				string[] _header_labels = _first_line.Split(',');
				if (!_sales_data_table.Columns.Contains(_header_labels[0]))
				{
					foreach (string _header_word in _header_labels)
					{
						_sales_data_table.Columns.Add(new DataColumn(_header_word));
					}
				}

				//Now we populate the table with the rest of the information that we want to view
				for (int _row = 1; _row < lines.Length; _row++)
				{
					//For each line, we want a list of the words on the line seperated by the comma
					string[] dataWords = lines[_row].Split(',');
					DataRow _data_row = _sales_data_table.NewRow();
					int columnIndex = 0;
					//Now populate the table one row at a time
					foreach (string headerWord in _header_labels)
					{
						_data_row[headerWord] = dataWords[columnIndex++];
					}
					//Add the completed row to the table
					_sales_data_table.Rows.Add(_data_row);
				}
			}

			if (_sales_data_table.Rows.Count > 0)
			{
				//Now we create the binding source for displaying the table information in the DataGridView
				_binding_source.DataSource = _sales_data_table;


				//Filter according to the date ranges if the dates have been selected correctly
				if (isDateFiltered() == true)
				{
					string _filter_start_date = _main_form.SalesLogStartDate.SelectedItem.ToString();
					string _filter_end_date = _main_form.SalesLogEndDate.SelectedItem.ToString();

					if (isTypeFiltered() == true)
					{
						string _item_type = _main_form.SalesLogType.SelectedItem.ToString();
						_binding_source.Filter = string.Format("Company = '{0}' OR Date >= '{1}' AND Date <= '{2}' AND Type = '{3}'", _empty_string, _filter_start_date, _filter_end_date, _item_type);
					}
					else
					{
						_binding_source.Filter = string.Format("Company = '{0}' OR Date >= '{1}' AND Date <= '{2}'", _empty_string, _filter_start_date, _filter_end_date);
					}
				}
				else
				{
					_binding_source.RemoveFilter();

					if (isTypeFiltered() == true)
					{
						string _item_type = _main_form.SalesLogType.SelectedItem.ToString();
						_binding_source.Filter = string.Format("Company = '{0}' OR Type = '{1}'", _empty_string, _item_type);
					}
				}

				_main_form.SalesLogGridView.DataSource = _binding_source;
				_main_form.SalesLogGridView.Columns[1].FillWeight = 190F;

				foreach (DataGridViewColumn _column in _main_form.SalesLogGridView.Columns)
				{
					_column.SortMode = DataGridViewColumnSortMode.NotSortable;
				}

				AddTotalsRow();
				_main_form.SalesLogGridView.Refresh();
			}

		}


		//This function will add up the KG's and Amount column on the Data Grid View and adds a row to show the totals
		private void AddTotalsRow()
		{
			float _total_kg = 0;
			float _total_amount = 0;
			int _kg_column = 2;
			int _amount_column = 3;


			for (int _row = 0; _row < _main_form.SalesLogGridView.Rows.Count - 1; _row++)
			{
				_total_amount += float.Parse(_main_form.SalesLogGridView.Rows[_row].Cells[_amount_column].Value.ToString());
				_total_kg += float.Parse(_main_form.SalesLogGridView.Rows[_row].Cells[_kg_column].Value.ToString());
			}

			//CustomMessageBox box = new CustomMessageBox("Total", "Kg's : " + _total_kg.ToString() + "\n" + "Amount : " + _total_amount.ToString());

			DataTable _totals_table = new DataTable();

			for (int _cols = 0; _cols < _main_form.SalesLogGridView.Columns.Count; _cols++)
			{
				DataColumn _new_column = new DataColumn();
				_totals_table.Columns.Add(_new_column);
			}

			DataRow _last_row = _sales_data_table.NewRow();
			DataRow _empty_row = _sales_data_table.NewRow();

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

			//Add the totals rows to the data table
			_sales_data_table.Rows.Add(_empty_row);
			_sales_data_table.Rows.Add(_last_row);

		}


		public void MonthSelected()
		{
			if (_main_form.SalesLogMonth.SelectedItem == null)
			{
				//Do nothing if no month is selected
				return;
			}

			string _selected_month = _main_form.SalesLogMonth.SelectedItem.ToString();
			string _path_to_log_file = @"..//..//resources//Logs//Sales//" + _selected_month + ".csv";

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
			_main_form.SalesLogStartDate.Items.Clear();
			_main_form.SalesLogEndDate.Items.Clear();

			//Now Populate the drop down list with available dates only.
			foreach (string _date in _dates)
			{
				_main_form.SalesLogStartDate.Items.Add(_date);
				_main_form.SalesLogEndDate.Items.Add(_date);
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
			if ((_main_form.SalesLogStartDate.SelectedItem == null) && (_main_form.SalesLogEndDate.SelectedItem == null))
			{
				//Do nothing if there are not filters selected
				return false;
			}

			if ((_main_form.SalesLogStartDate.SelectedItem != null) && (_main_form.SalesLogEndDate.SelectedItem == null))
			{
				//Do nothing if there are not filters selected
				CustomMessageBox msg = new CustomMessageBox("Error!", "INVALID DATE RANGE!");
				_main_form.SalesLogStartDate.SelectedItem = null;
				_main_form.SalesLogEndDate.SelectedItem = null;
				return false;
			}

			if ((_main_form.SalesLogStartDate.SelectedItem == null) && (_main_form.SalesLogEndDate.SelectedItem != null))
			{
				//Do nothing if there are not filters selected
				CustomMessageBox msg = new CustomMessageBox("Error!", "INVALID DATE RANGE!");
				_main_form.SalesLogStartDate.SelectedItem = null;
				_main_form.SalesLogEndDate.SelectedItem = null;
				return false;
			}

			DateTime _filter_start_date = Convert.ToDateTime(_main_form.SalesLogStartDate.SelectedItem.ToString());
			DateTime _filter_end_date = Convert.ToDateTime(_main_form.SalesLogEndDate.SelectedItem.ToString());

			if (_filter_start_date > _filter_end_date)
			{
				CustomMessageBox msg = new CustomMessageBox("Error!", "INVALID DATE RANGE!");
				_main_form.SalesLogStartDate.SelectedItem = null;
				_main_form.SalesLogEndDate.SelectedItem = null;
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
			if (_main_form.SalesLogType.SelectedItem == null)
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
			_main_form.SalesLogStartDate.SelectedItem = null;
			_main_form.SalesLogEndDate.SelectedItem = null;
			_main_form.SalesLogType.SelectedItem = null;

			DisplaySalesLog();
		}

		public void UnknownCompany() 
		{
			
			if (_main_form.NewCompanyCheckBox.CheckState == CheckState.Checked)
			{
				_main_form.SaleCompanyNameList.DropDownStyle = ComboBoxStyle.DropDown;
				_unknown_company = true;
				
			}
			else 
			{
				_main_form.SaleCompanyNameList.DropDownStyle = ComboBoxStyle.DropDownList;
				_unknown_company = true;
			}
		}


		public void AddSale()
		{
			if (ValidEntries() == false) 
			{
				return;
			}

			if (_main_form.NewCompanyCheckBox.CheckState == CheckState.Checked) 
			{
				if (_buyers_list.Contains(_main_form.SaleCompanyNameList.Text) == false) 
				{
					AddNewBuyer();
					LoadBuyers();
				}
			}

			StringBuilder _csv_content = new StringBuilder();
			string _date = _main_form.SaleDate.Value.ToString("dd MMMM yyyy");
			string _company = _main_form.SaleCompanyNameList.Text;
			string _quantity = _main_form.SaleQuantityBx.Value.ToString();
			string _amount = _main_form.SaleAmount.Value.ToString();
			string _type = _main_form.SaleTypeBx.Text;
			string _new_sale = _date + "," + _company + "," + _quantity + "," + _amount + "," + _type;
			_csv_content.AppendLine(_new_sale);

			try
			{
				File.AppendAllText(_path_to_sales, _csv_content.ToString());
				ClearFields();
				CustomMessageBox newBox = new CustomMessageBox("Success!", "Sale Recorded");
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error! \n" + ex.Message);
			}

			DisplaySalesLog();
		}

		//Validate that the user has entered all the information correctly
		private bool ValidEntries()
		{
			bool _all_good = false;
			string _title = "Error!";
			string _error_message = "";
			string _no_text = "";
			decimal _zero = (decimal)0.00;

			//First verify that all fields have been filled in correctly

			if (_main_form.SaleQuantityBx.Value == _zero)
			{
				_all_good = false;
				_error_message = "Please Insert the Quantity";
			}
			else if (_main_form.SaleTypeBx.Text == _no_text)
			{
				_all_good = false;
				_error_message = "Please Select the goods type";
			}
			else if (_main_form.SaleAmount.Value == _zero)
			{
				_all_good = false;
				_error_message = "Please Insert the Sale Amount";
			}
			else if (_main_form.SaleCompanyNameList.Text == _no_text)
			{
				_all_good = false;
				_error_message = "Please Select the a Company";
			}
			else 
			{
				_all_good = true;
			}

			if (_all_good == false) 
			{
				CustomMessageBox box = new CustomMessageBox(_title, _error_message);
			}
			
			return _all_good;
		}

		private void AddNewBuyer() 
		{
			string _table_name = "Buyers";
			string _parameter = "Company";
			string _company_name = "'" + _main_form.SaleCompanyNameList.Text + "'";

			Int32 _rows_affected = _database.InsertIntoDatabase(_table_name,_parameter,_company_name);

			if (_rows_affected == 1) 
			{
				CustomMessageBox mb = new CustomMessageBox("Success", "New Buyer Added");
			}
			
		}

		public void ClearFields() 
		{
			decimal _zero = (decimal)0.00;

			_main_form.SaleDate.Value = DateTime.Now;
			_main_form.SaleQuantityBx.Value = _zero;
			_main_form.NewCompanyCheckBox.CheckState = CheckState.Unchecked;
			_main_form.SaleCompanyNameList.DropDownStyle = ComboBoxStyle.DropDownList;
			_main_form.SaleTypeBx.SelectedItem = null;
			_main_form.SaleAmount.Value = _zero;
		}
	}
}

