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
using System.Globalization;

namespace Green_Enviro_App
{
	public class Purchases : WarningInterface
	{
		//First we need to know what month it is
		static string _month = DateTime.Now.ToString("MMMM yyyy");
		static string path = Path.GetDirectoryName(Path.GetDirectoryName(Directory.GetCurrentDirectory()));
		string _path_to_purchases = path + @"\resources\Logs\Purchases\" + _month + ".csv";
		Main_Form _main_form;
		CSVHandles csvHandles;

		DataTable _purchases_data_table = new DataTable();
		BindingSource _binding_source = new BindingSource();
		string _empty_string = " ";
		string _totals = "TOTALS";

		string _ferrous;
		string _non_ferrous;
		public Purchases(Main_Form _main)
		{
			_main_form = _main;
			int uniquePurchaseColumns = 5;
			csvHandles = new CSVHandles(_main_form.PurchseLogGridView,uniquePurchaseColumns);
			CreateLogFiles();
			SetupPurchaseLogs();
		}

		public void SetupPurchaseLogs()
		{
			//This function will get the names of all the purchase log files that exists in the purchases folder
			string _purchase_logs_path = path + @"\resources\Logs\Purchases";
			DirectoryInfo _directory = new DirectoryInfo(_purchase_logs_path);  //Assuming Test is your Folder
			FileInfo[] _files = _directory.GetFiles("*.csv");   //Getting Text files
			foreach (FileInfo _file in _files)
			{
				char[] _remove_chars = { 'c', 's', 'v', '.' };
				string _file_name = _file.Name.TrimEnd(_remove_chars);
				_main_form.PurchaseLogMonth.Items.Add(_file_name);
			}
		}

		public void setTypes(string F, string N) 
		{
			_ferrous = F;
			_non_ferrous = N;

			//Also setup the Ferrous or Non-Ferrous Selector
			_main_form.PurchaseLogType.Items.Clear();
			_main_form.PurchaseLogType.Items.Add(_ferrous);
			_main_form.PurchaseLogType.Items.Add(_non_ferrous);
		}

		//Create purchase and sales logs for each month if they don't already exist
		private void CreateLogFiles()
		{
			string _purchases_file_headers = "Date,Name,Surname,ID,No.,Item,Qnty,Price,Amnt,Type";
			csvHandles.createCSVFile(_path_to_purchases, _purchases_file_headers);
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
				
				CustomMessageBox box = new CustomMessageBox(_main_form, "Success!", "Purchase Completed!");
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error! \n" + ex.Message);
			}

			DisplayPurchaseLog();
		}

		public void DisplayPurchaseLog()
		{

			if (_main_form.PurchaseLogMonth.SelectedItem == null)
			{
				//Do nothing is the user has not selected what month they want to view
				return;
			}

			LoadPurchaseLog();

			if (_purchases_data_table.Rows.Count > 0)
			{
				_binding_source.DataSource = _purchases_data_table;
				FilterGridView();
				PopulateGridView();
			}
		}

		private void LoadPurchaseLog() 
		{
			_purchases_data_table.Clear();

			string _selected_month = _main_form.PurchaseLogMonth.SelectedItem.ToString();
			string _path_to_log_file = path + @"\resources\Logs\Purchases\" + _selected_month + ".csv";

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
		}

		private void FilterGridView() 
		{
			
			string _filter_instruction;
			//Filter according to the date ranges if the dates have been selected correctly
			if (isDateFiltered() == true)
			{
				string _filter_start_date = _main_form.PurchaseLogStartDate.SelectedItem.ToString();
				string _filter_end_date = _main_form.PurchaseLogEndDate.SelectedItem.ToString();


				if (isTypeFiltered() == true)
				{
					string _item_type = _main_form.PurchaseLogType.SelectedItem.ToString();
					_filter_instruction = "Date = '{0}' OR Date = '{1}' OR Date >= '{2}' AND Date <= '{3}' AND Type = '{4}'";
					_binding_source.Filter = string.Format(_filter_instruction, _totals, _empty_string, _filter_start_date, _filter_end_date, _item_type);
				}
				else
				{
					_filter_instruction = "Date = '{0}' OR Date = '{1}' OR Date >= '{2}' AND Date <= '{3}'";
					_binding_source.Filter = string.Format(_filter_instruction, _totals, _empty_string, _filter_start_date, _filter_end_date);
				}
			}
			else
			{
				_binding_source.RemoveFilter();

				if (isTypeFiltered() == true)
				{
					string _item_type = _main_form.PurchaseLogType.SelectedItem.ToString();
					_filter_instruction = "Date = '{0}' OR Date = '{1}' OR Type = '{2}'";
					_binding_source.Filter = string.Format(_filter_instruction, _totals, _empty_string, _item_type);
				}
			}
		}

		private void PopulateGridView() 
		{
			_main_form.PurchseLogGridView.DataSource = _binding_source;
			_main_form.PurchseLogGridView.Columns[0].FillWeight = 180F;
			_main_form.PurchseLogGridView.Columns[1].FillWeight = 100F;
			_main_form.PurchseLogGridView.Columns[2].FillWeight = 110F;
			_main_form.PurchseLogGridView.Columns[3].FillWeight = 130F;
			_main_form.PurchseLogGridView.Columns[4].FillWeight = 40F;
			_main_form.PurchseLogGridView.Columns[5].FillWeight = 80F;
			_main_form.PurchseLogGridView.Columns[6].FillWeight = 50F;
			_main_form.PurchseLogGridView.Columns[7].FillWeight = 50F;
			_main_form.PurchseLogGridView.Columns[8].FillWeight = 60F;

			//Disables the ability to sort columns using the headers
			foreach (DataGridViewColumn _column in _main_form.PurchseLogGridView.Columns)
			{
				_column.SortMode = DataGridViewColumnSortMode.NotSortable;
			}

			AddTotalsRow();
			int _last_row_index = 0;
			_last_row_index = _main_form.PurchseLogGridView.Rows.GetRowCount(DataGridViewElementStates.Visible) - 1;

			_main_form.PurchseLogGridView.Rows[_last_row_index].DefaultCellStyle.BackColor = Color.Yellow;
			_main_form.PurchseLogGridView.Refresh();
		}

		//This function will add up the KG's and Amount column on the Data Grid View and adds a row to show the totals
		private void AddTotalsRow() 
		{
			float _total_kg = 0;
			float _total_amount = 0;
			int _kg_column = 6;
			int _amount_column = 8;

			for (int _row = 0; _row < _main_form.PurchseLogGridView.Rows.Count; _row++)
			{
				_total_amount += float.Parse(_main_form.PurchseLogGridView.Rows[_row].Cells[_amount_column].Value.ToString(), CultureInfo.InvariantCulture);
				_total_kg += float.Parse(_main_form.PurchseLogGridView.Rows[_row].Cells[_kg_column].Value.ToString(), CultureInfo.InvariantCulture);
			}

			//CustomMessageBox box = new CustomMessageBox("Total", "Kg's : " + _total_kg.ToString() + "\n" + "Amount : " + _total_amount.ToString());

			DataTable _totals_table = new DataTable();

			for (int _cols = 0; _cols < _main_form.PurchseLogGridView.Columns.Count; _cols++) 
			{
				DataColumn _new_column = new DataColumn();
				_totals_table.Columns.Add(_new_column);
			}

			DataRow _last_row = _purchases_data_table.NewRow();

			_last_row[0] = _totals;
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
			_purchases_data_table.Rows.Add(_last_row);
		}

		public void MonthSelected() 
		{
			if (_main_form.PurchaseLogMonth.SelectedItem == null) 
			{
				//Do nothing if no month is selected
				return;
			}

			string _selected_month = _main_form.PurchaseLogMonth.SelectedItem.ToString();
			string _path_to_log_file = path + @"\resources\Logs\Purchases\" + _selected_month + ".csv";

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
				CustomMessageBox msg = new CustomMessageBox (_main_form, "Error!", "INVALID DATE RANGE!");
				_main_form.PurchaseLogStartDate.SelectedItem = null;
				_main_form.PurchaseLogEndDate.SelectedItem = null;
				return false;
			}

			if ((_main_form.PurchaseLogStartDate.SelectedItem == null) && (_main_form.PurchaseLogEndDate.SelectedItem != null))
			{
				//Do nothing if there are not filters selected
				CustomMessageBox msg = new CustomMessageBox(_main_form, "Error!", "INVALID DATE RANGE!");
				_main_form.PurchaseLogStartDate.SelectedItem = null;
				_main_form.PurchaseLogEndDate.SelectedItem = null;
				return false;
			}

			DateTime _start_date = Convert.ToDateTime(_main_form.PurchaseLogStartDate.SelectedItem.ToString());
			DateTime _end_date = Convert.ToDateTime(_main_form.PurchaseLogEndDate.SelectedItem.ToString());

			if (_start_date > _end_date) 
			{
				CustomMessageBox msg = new CustomMessageBox(_main_form, "Error!", "INVALID DATE RANGE!");
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

		public void Reset() 
		{
			_main_form.PurchaseLogMonth.SelectedItem = null;
			RemoveFilters();
			_main_form.PurchseLogGridView.DataSource = null;
		}

		/// <summary>
		/// This function deletes a purchase if it was entered by mistake
		/// The function will look through the entire purhase that was made and delete all corresponding items
		/// </summary>
		public void DeletePurchase() 
		{
			//Verify that something is selected before attempting to delete
			if (_main_form.PurchseLogGridView.SelectedCells.Count == 0) 
			{
				CustomMessageBox mb = new CustomMessageBox(_main_form, CustomMessageBox.error, "Please select the customer to be deleted");
				return;
			}

			//Confirm that the use is not trying to delete the totals column
			if (_main_form.PurchseLogGridView.CurrentCell.RowIndex == _main_form.PurchseLogGridView.Rows.Count-1)
			{
				CustomMessageBox mb = new CustomMessageBox(_main_form, CustomMessageBox.error, "It's not possible to delete the TOTALS row");
				return;
			}

			int _current_row = _main_form.PurchseLogGridView.CurrentCell.RowIndex;
			//Highlight the rows that will be deleted if the user chooses to confirm
			//Returns a string the will be the starting substring for the row that will be deleted

			csvHandles.RowsToDelete(_current_row);
			csvHandles.RequestUserConfirmation(_main_form,this);
		}

		private string pathToDeleteFile()
		{
			string _path_to_purchase_file_to_be_deleted;
			string selectedMonthAndYear = _main_form.PurchaseLogMonth.SelectedItem.ToString();
			_path_to_purchase_file_to_be_deleted = @"..//..//resources//Logs//Purchases//" + selectedMonthAndYear + ".csv";
			
			return _path_to_purchase_file_to_be_deleted;
		}

		/// <summary>
		/// Function that will be excecuted when after the warning message gets displayed
		/// </summary>
		public override void WarningWaitingFunction(bool actionConfirmed) 
		{
			if (actionConfirmed == true)
			{
				string pathToFile = pathToDeleteFile();
				//Recreate
				csvHandles.DeleteInCSV(pathToFile);
				DisplayPurchaseLog();
			}
			else 
			{
				//If user cancels the deletion, we need to remove the highlight marks
				csvHandles.eraseHighlightMarks();
			}
		}
	}
}
