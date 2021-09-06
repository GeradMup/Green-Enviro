using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;
using System.IO;
using System.Drawing;
using System.Globalization;

namespace Green_Enviro_App
{
	public class Sales : WarningInterface
	{
		//First we need to know what month it is

		//Required objects
		Main_Form _main_form;
		Database _database;
		CSVHandles csvHandles;
		FileHandles fileHandles;

		DataTable _sales_data_table = new DataTable();	//All the information about all the products the we have sold.
		DataTable _buyers;  //Companies that we sell and buy from
		List<string> _buyers_list = new List<string>();

		BindingSource _binding_source = new BindingSource();
		string _empty_string = " ";

		bool _unknown_company = false;
		public Sales(Main_Form _main, Database data, FileHandles fh)
		{
			_main_form = _main;
			_database = data;
			fileHandles = fh;
			int uniqueSalesColumns = 5;
			csvHandles = new CSVHandles(_main_form.SalesLogGridView, uniqueSalesColumns);
			CreateLogFiles();
			SetTypes();
			SetupSalesLogs();
			LoadBuyers();
		}

		public void SetTypes()
		{
			//Also setup the Ferrous or Non-Ferrous Selector
			_main_form.SaleTypeBx.Items.Add(Constants.FERROUS);
			_main_form.SaleTypeBx.Items.Add(Constants.NON_FERROUS);

			_main_form.SalesLogType.Items.Add(Constants.FERROUS);
			_main_form.SalesLogType.Items.Add(Constants.NON_FERROUS);
		}

		//Create purchase and sales logs for each month if they don't already exist
		private void CreateLogFiles()
		{
			//First Check if the files exist for each month
			//If the file does not exist, create it
			
			string salesFileHeaders = "Date,Company,Quantity,Amount,Type";
			fileHandles.createCSVFile(FileHandles.LogType.Sales, salesFileHeaders);
		}

		public void SetupSalesLogs()
		{
			//This function will get the names of all the sales log files that exists in the Sales folder
			List<string> logNames = fileHandles.getLogNames(FileHandles.LogType.Sales);
			foreach (string name in logNames)
			{
				_main_form.SalesLogMonth.Items.Add(name);
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

				int _last_row_index = 0;
				_last_row_index = _main_form.SalesLogGridView.Rows.GetRowCount(DataGridViewElementStates.Visible) - 1;

				_main_form.SalesLogGridView.Rows[_last_row_index].DefaultCellStyle.BackColor = Color.Yellow;
				_main_form.SalesLogGridView.Columns[0].FillWeight = 230F;
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

			for (int _row = 0; _row < _main_form.SalesLogGridView.Rows.Count; _row++)
			{ 
				_total_amount += float.Parse(_main_form.SalesLogGridView.Rows[_row].Cells[_amount_column].Value.ToString(), CultureInfo.InvariantCulture);
				_total_kg += float.Parse(_main_form.SalesLogGridView.Rows[_row].Cells[_kg_column].Value.ToString(), CultureInfo.InvariantCulture);
			}

			//CustomMessageBox box = new CustomMessageBox("Total", "Kg's : " + _total_kg.ToString() + "\n" + "Amount : " + _total_amount.ToString());

			DataTable _totals_table = new DataTable();

			for (int _cols = 0; _cols < _main_form.SalesLogGridView.Columns.Count; _cols++)
			{
				DataColumn _new_column = new DataColumn();
				_totals_table.Columns.Add(_new_column);
			}

			DataRow _last_row = _sales_data_table.NewRow();

			_last_row[0] = "TOTALS";
			for (int _cell = 1; _cell < _last_row.ItemArray.Length; _cell++)
			{
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
			_sales_data_table.Rows.Add(_last_row);

		}

		public void MonthSelected()
		{
			if (_main_form.SalesLogMonth.SelectedItem == null)
			{
				//Do nothing if no month is selected
				return;
			}

			string selectedMonthAndYear = _main_form.SalesLogMonth.SelectedItem.ToString();
			string pathToLogFile = fileHandles.pathToLogs(FileHandles.LogType.Sales,selectedMonthAndYear);
			HashSet<string> dates = csvHandles.getDatesInFile(pathToLogFile);

			//First Clear the start and end date fields to prepare them for the new entry
			_main_form.SalesLogStartDate.Items.Clear();
			_main_form.SalesLogEndDate.Items.Clear();

			//Now Populate the drop down list with available dates only.
			foreach (string date in dates)
			{
				_main_form.SalesLogStartDate.Items.Add(date);
				_main_form.SalesLogEndDate.Items.Add(date);
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
				CustomMessageBox msg = new CustomMessageBox(_main_form, "Error!", "INVALID DATE RANGE!");
				_main_form.SalesLogStartDate.SelectedItem = null;
				_main_form.SalesLogEndDate.SelectedItem = null;
				return false;
			}

			if ((_main_form.SalesLogStartDate.SelectedItem == null) && (_main_form.SalesLogEndDate.SelectedItem != null))
			{
				//Do nothing if there are not filters selected
				CustomMessageBox msg = new CustomMessageBox(_main_form, "Error!", "INVALID DATE RANGE!");
				_main_form.SalesLogStartDate.SelectedItem = null;
				_main_form.SalesLogEndDate.SelectedItem = null;
				return false;
			}

			DateTime _filter_start_date = Convert.ToDateTime(_main_form.SalesLogStartDate.SelectedItem.ToString());
			DateTime _filter_end_date = Convert.ToDateTime(_main_form.SalesLogEndDate.SelectedItem.ToString());

			if (_filter_start_date > _filter_end_date)
			{
				CustomMessageBox msg = new CustomMessageBox(_main_form, "Error!", "INVALID DATE RANGE!");
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

			//Check if the user is trying to add a new company
			if (_main_form.NewCompanyCheckBox.CheckState == CheckState.Checked) 
			{
				//Check if the added company name does not already exist
				if (_buyers_list.Contains(_main_form.SaleCompanyNameList.Text) == false) 
				{
					//Add the new company
					AddNewBuyer();
					//Re-load the companies list to be displayed again
					LoadBuyers();
				}
			}

			string timeWhenEntered = DateTime.Now.ToString(" HH:mm:ss");
			string _sale_date = _main_form.SaleDate.Value.ToString("dd MMMM yyyy") + timeWhenEntered;
			string _company = _main_form.SaleCompanyNameList.Text;
			string _quantity = _main_form.SaleQuantityBx.Value.ToString();
			string _amount = _main_form.SaleAmount.Value.ToString();
			string _type = _main_form.SaleTypeBx.Text;

			
			string _new_sale = _sale_date + "," + _company + "," + _quantity + "," + _amount + "," + _type;

			RecordSale(_new_sale, newSalePath());

			//Remove all filters and display the log after a new sale is added
			RemoveFilters();
		}

		private void RecordSale(string newSale, string pathToSaveNewSale) 
		{
			StringBuilder csvContent = new StringBuilder();
			csvContent.AppendLine(newSale);

			try
			{
				File.AppendAllText(pathToSaveNewSale, csvContent.ToString());
				ClearFields();
				CustomMessageBox newBox = new CustomMessageBox(_main_form, "Success!", "Sale Recorded");
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error! \n" + ex.Message);
			}

		}

		public void AddCasualSale(List<CasualSale> casualSales) 
		{
			string timeWhenEntered = DateTime.Now.ToString(" HH:mm:ss");
			string _sale_date = DateTime.Now.ToString("dd MMMM yyyy") + timeWhenEntered;
			string _company = "Casual Sale";
			string _new_sale = "";

			foreach (CasualSale sale in casualSales) 
			{
				string _quantity = sale.quantity;
				string _amount = sale.price;
				string _type = sale.itemType;
				_company = "Casual Sale : " + sale.item;
				_new_sale = _sale_date + "," + _company + "," + _quantity + "," + _amount + "," + _type;
				RecordSale(_new_sale,newSalePath());
			}
		}

		/// <summary>
		/// This function is used to check if the user is trying to add a new sale 
		/// to a month different from the currently selected month.
		/// If the month differs, the new month is obtained, the path to it and the date for logging the sale
		/// </summary>
		/// <returns></returns>
		private string newSalePath() 
		{
			string pathToSaveNewSale;

			//Check if the user is trying to add the new sale to a different month
			//If no month is selected, the new sale will be added to the current month
			if (_main_form.SalesLogMonth.SelectedItem == null)
			{
				pathToSaveNewSale = fileHandles.pathToLogs(FileHandles.LogType.Sales);
			}
			else
			{
				string selectedMonthAndYear = _main_form.SalesLogMonth.SelectedItem.ToString();
				pathToSaveNewSale = fileHandles.pathToLogs(FileHandles.LogType.Sales, selectedMonthAndYear);
			}
			return pathToSaveNewSale;
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
				CustomMessageBox box = new CustomMessageBox(_main_form, _title, _error_message);
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
				CustomMessageBox mb = new CustomMessageBox(_main_form, "Success!", "New Buyer Added");
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

		public void Reset() 
		{
			ClearFields();
			_main_form.SalesLogMonth.SelectedItem = null;
			RemoveFilters();
			_main_form.SalesLogGridView.DataSource = null;
		}

		/// <summary>
		/// Deletes a sale if user made mistake.
		/// </summary>
		public void DeleteSale()
		{
			//Verify that something is selected before attempting to delete
			if (_main_form.SalesLogGridView.SelectedCells.Count == 0)
			{
				CustomMessageBox mb = new CustomMessageBox(_main_form, CustomMessageBox.error, "Please select the sale to be deleted");
				return;
			}

			//Confirm that the user is not trying to delete the totals row
			if (_main_form.SalesLogGridView.CurrentCell.RowIndex == _main_form.SalesLogGridView.Rows.Count - 1)
			{
				CustomMessageBox mb = new CustomMessageBox(_main_form, CustomMessageBox.error, "It's not possible to delete the TOTALS row");
				return;
			}

			int _selected_row = _main_form.SalesLogGridView.CurrentCell.RowIndex;
			//Highlight the rows that will be deleted if the user chooses to confirm
			//Returns a string the will be the starting substring for the row that will be deleted

			csvHandles.RowsToDelete(_selected_row);
			csvHandles.ConfirmDeletion(_main_form, this);
		}

		private string pathToDeleteFile()
		{
			string _path_to_purchase_file_to_be_deleted;
			string selectedMonthAndYear = _main_form.SalesLogMonth.SelectedItem.ToString();
			_path_to_purchase_file_to_be_deleted = @"..//..//resources//Logs//Sales//" + selectedMonthAndYear + ".csv";

			return _path_to_purchase_file_to_be_deleted;
		}

		/// <summary>
		/// Function that will be excecuted when after the warning message gets displayed
		/// </summary>
		public override void DeleteEntriesWarning(bool actionConfirmed)
		{
			if (actionConfirmed == true)
			{
				string pathToFile = pathToDeleteFile();
				//Recreate
				csvHandles.DeleteInCSV(pathToFile);
				DisplaySalesLog();
			}
			else
			{
				//Remove the red highlighting on the previously selected rows
				//if the user decides to cancel the deletion
				csvHandles.eraseHighlightMarks();
			}
		}

		public override void PurchasePRWarning(bool actionConfirmed)
		{
			//throw new NotImplementedException();
		}
	}

	public struct CasualSale
	{
		public string item { get; set; }

		public string itemType { get; set; }

		public string price { get; set; }

		public string quantity { get; set; }
	}


}

