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
	class Expenses	: WarningInterface
	{
		//Required objects
		Main_Form _main_form;
		Database _database;
		CSVHandles csvHandles;

		DataTable _expenses_data_table = new DataTable();  //All the information about all the products the we have sold.

		BindingSource _binding_source = new BindingSource();
		string _empty_string = " ";
		public Expenses(Main_Form _main, Database data)
		{
			_main_form = _main;
			_database = data;
			int uniqueExpensesColumns = 3;
			csvHandles = new CSVHandles(_main_form.ExpensesLogGridView, uniqueExpensesColumns);
			CreateLogFiles();
			SetupExpensesLogs();
		}

		//Create purchase and expenses logs for each month if they don't already exist
		private void CreateLogFiles()
		{
			string expensesFileHeaders = "Date,Description,Amount";
			csvHandles.createCSVFile(CSVHandles.LogType.Expenses, expensesFileHeaders);
		}

		public void SetupExpensesLogs()
		{
			List<string> logNames = csvHandles.getLogNames(CSVHandles.LogType.Expenses);
			foreach (string logName in logNames)
			{
				_main_form.ExpensesLogMonth.Items.Add(logName);
			}

			_main_form.ExpenseDate.Value = DateTime.Now;
		}

		public void DisplayExpensesLog()
		{

			if (_main_form.ExpensesLogMonth.SelectedItem == null)
			{
				//Do nothing is the user has not selected what month they want to view
				return;
			}
			//Clear the data table so that it can be ready for the next entries
			_expenses_data_table.Clear();

			string _selected_month = _main_form.ExpensesLogMonth.SelectedItem.ToString();
			string _path_to_log_file = @"..//..//resources//Logs//Expenses//" + _selected_month + ".csv";

			string[] lines = System.IO.File.ReadAllLines(_path_to_log_file);
			if (lines.Length > 0)
			{
				//first line to create the table headers
				string _first_line = lines[0];
				string[] _header_labels = _first_line.Split(',');
				if (!_expenses_data_table.Columns.Contains(_header_labels[0]))
				{
					foreach (string _header_word in _header_labels)
					{
						_expenses_data_table.Columns.Add(new DataColumn(_header_word));
					}
				}

				//Now we populate the table with the rest of the information that we want to view
				for (int _row = 1; _row < lines.Length; _row++)
				{
					//For each line, we want a list of the words on the line seperated by the comma
					string[] dataWords = lines[_row].Split(',');
					DataRow _data_row = _expenses_data_table.NewRow();
					int columnIndex = 0;
					//Now populate the table one row at a time
					foreach (string headerWord in _header_labels)
					{
						_data_row[headerWord] = dataWords[columnIndex++];
					}
					//Add the completed row to the table
					_expenses_data_table.Rows.Add(_data_row);
				}
			}

			if (_expenses_data_table.Rows.Count > 0)
			{
				//Now we create the binding source for displaying the table information in the DataGridView
				_binding_source.DataSource = _expenses_data_table;


				//Filter according to the date ranges if the dates have been selected correctly
				if (isDateFiltered() == true)
				{
					string _filter_start_date = _main_form.ExpensesLogStartDate.SelectedItem.ToString();
					string _filter_end_date = _main_form.ExpensesLogEndDate.SelectedItem.ToString();

					_binding_source.Filter = string.Format("Description = '{0}' OR Date >= '{1}' AND Date <= '{2}'", _empty_string, _filter_start_date, _filter_end_date);
				}
				else
				{
					_binding_source.RemoveFilter();
				}

				_main_form.ExpensesLogGridView.DataSource = _binding_source;
				_main_form.ExpensesLogGridView.Columns[1].FillWeight = 190F;

				foreach (DataGridViewColumn _column in _main_form.ExpensesLogGridView.Columns)
				{
					_column.SortMode = DataGridViewColumnSortMode.NotSortable;
				}

				AddTotalsRow();

				int _last_row_index = 0;
				_last_row_index = _main_form.ExpensesLogGridView.Rows.GetRowCount(DataGridViewElementStates.Visible) - 1;

				_main_form.ExpensesLogGridView.Rows[_last_row_index].DefaultCellStyle.BackColor = Color.Yellow;
				_main_form.ExpensesLogGridView.Columns[0].FillWeight = 230F;
				_main_form.ExpensesLogGridView.Refresh();
			}

		}


		//This function will add up the KG's and Amount column on the Data Grid View and adds a row to show the totals
		private void AddTotalsRow()
		{
			float _total_amount = 0;
			int _amount_column = 2;


			for (int _row = 0; _row < _main_form.ExpensesLogGridView.Rows.Count; _row++)
			{
				_total_amount += float.Parse(_main_form.ExpensesLogGridView.Rows[_row].Cells[_amount_column].Value.ToString(), CultureInfo.InvariantCulture);
			}

			DataTable _totals_table = new DataTable();

			for (int _cols = 0; _cols < _main_form.ExpensesLogGridView.Columns.Count; _cols++)
			{
				DataColumn _new_column = new DataColumn();
				_totals_table.Columns.Add(_new_column);
			}

			DataRow _last_row = _expenses_data_table.NewRow();

			_last_row[0] = "TOTALS";
			for (int _cell = 1; _cell < _last_row.ItemArray.Length; _cell++)
			{
				if (_cell == _amount_column)
				{
					_last_row[_cell] = _total_amount;
				}
				else
				{
					_last_row[_cell] = _empty_string;
				}
			}

			//Add the totals rows to the data table
			_expenses_data_table.Rows.Add(_last_row);

		}

		public void MonthSelected()
		{
			if (_main_form.ExpensesLogMonth.SelectedItem == null) return;
			
			string selectedMonthAndYear = _main_form.ExpensesLogMonth.SelectedItem.ToString();
			string pathToLogFile = csvHandles.pathToLogs(CSVHandles.LogType.Expenses, selectedMonthAndYear);
			HashSet<string> dates = csvHandles.getDatesInFile(pathToLogFile);

			//First Clear the start and end date fields to prepare them for the new entry
			_main_form.ExpensesLogStartDate.Items.Clear();
			_main_form.ExpensesLogEndDate.Items.Clear();

			//Now Populate the drop down list with available dates only.
			foreach (string date in dates)
			{
				_main_form.ExpensesLogStartDate.Items.Add(date);
				_main_form.ExpensesLogEndDate.Items.Add(date);
			}

			//Change the contents displayed in the log if the month selected changes
			RemoveFilters();

		}

		/// <summary>
		/// Determines whether a valid date range is select for filtering the Expenses Log.
		/// </summary>
		/// <returns>
		///   <c>true</c> if a valid date range is selected; otherwise, <c>false</c>.
		/// </returns>
		/// <remark>
		/// If an invalid date range is selected, the date fields are set back to null
		/// </remark>
		private bool isDateFiltered()
		{
			if ((_main_form.ExpensesLogStartDate.SelectedItem == null) && (_main_form.ExpensesLogEndDate.SelectedItem == null))
			{
				//Do nothing if there are not filters selected
				return false;
			}

			if ((_main_form.ExpensesLogStartDate.SelectedItem != null) && (_main_form.ExpensesLogEndDate.SelectedItem == null))
			{
				//Do nothing if there are not filters selected
				CustomMessageBox msg = new CustomMessageBox(_main_form, "Error!", "INVALID DATE RANGE!");
				_main_form.ExpensesLogStartDate.SelectedItem = null;
				_main_form.ExpensesLogEndDate.SelectedItem = null;
				return false;
			}

			if ((_main_form.ExpensesLogStartDate.SelectedItem == null) && (_main_form.ExpensesLogEndDate.SelectedItem != null))
			{
				//Do nothing if there are not filters selected
				CustomMessageBox msg = new CustomMessageBox(_main_form, "Error!", "INVALID DATE RANGE!");
				_main_form.ExpensesLogStartDate.SelectedItem = null;
				_main_form.ExpensesLogEndDate.SelectedItem = null;
				return false;
			}

			DateTime _filter_start_date = Convert.ToDateTime(_main_form.ExpensesLogStartDate.SelectedItem.ToString());
			DateTime _filter_end_date = Convert.ToDateTime(_main_form.ExpensesLogEndDate.SelectedItem.ToString());

			if (_filter_start_date > _filter_end_date)
			{
				CustomMessageBox msg = new CustomMessageBox(_main_form, "Error!", "INVALID DATE RANGE!");
				_main_form.ExpensesLogStartDate.SelectedItem = null;
				_main_form.ExpensesLogEndDate.SelectedItem = null;
				return false;
			}

			return true;
		}

		/// <summary>
		/// Removes all the filters in the purchase log and displays all the existing entries
		/// </summary>
		public void RemoveFilters()
		{
			_main_form.ExpensesLogStartDate.SelectedItem = null;
			_main_form.ExpensesLogEndDate.SelectedItem = null;

			DisplayExpensesLog();
		}

		public void AddExpense()
		{
			if (ValidEntries() == false)
			{
				return;
			}

			StringBuilder _csv_content = new StringBuilder();
			string timeWhenEntered = DateTime.Now.ToString(" HH:mm:ss");
			string _date = _main_form.ExpenseDate.Value.ToString("dd MMMM yyyy") + timeWhenEntered;
			string _description = _main_form.ExpenseDescriptionBox.Text;
			string _amount = _main_form.ExpenseAmount.Value.ToString();

			string _new_expense = _date + "," + _description + "," + _amount;
			_csv_content.AppendLine(_new_expense);


			string path_to_save_new_expense = newExpensePath();

			try
			{
				File.AppendAllText(path_to_save_new_expense, _csv_content.ToString());
				ClearFields();
				CustomMessageBox newBox = new CustomMessageBox(_main_form, "Success!", "Expense Recorded");
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error! \n" + ex.Message);
			}

			//Remove all filters and re-load the expenses log after a new expense is added
			RemoveFilters();
		}

		/// <summary>
		/// This function is used to check if the user is trying to add a new expense 
		/// to a month different from the currently selected month.
		/// If the month differs, the new month is obtained, the path to it and the date for logging the expense
		/// </summary>
		/// <returns></returns>
		private string newExpensePath()
		{
			string pathToSaveNewExpense;

			//Check if the user is trying to add the new sale to a different month
			//If no month is selected, the new sale will be added to the current month
			if (_main_form.ExpensesLogMonth.SelectedItem == null)
			{
				pathToSaveNewExpense = csvHandles.pathToLogs(CSVHandles.LogType.Expenses);
			}
			else
			{
				string selectedMonthAndYear = _main_form.ExpensesLogMonth.SelectedItem.ToString();
				pathToSaveNewExpense = csvHandles.pathToLogs(CSVHandles.LogType.Expenses, selectedMonthAndYear);
			}

			return pathToSaveNewExpense;
		}

		//Validate that the user has entered all the information correctly
		private bool ValidEntries()
		{
			bool _all_good = false;
			string _title = "Error!";
			string _error_message = "";
			string _no_entry_string = "";
			decimal _zero = (decimal)0.00;

			if (_main_form.ExpenseAmount.Value == _zero)
			{
				_all_good = false;
				_error_message = "Please Insert the Amount";
			}
			else if (_main_form.ExpenseDescriptionBox.Text == _no_entry_string)
			{
				_all_good = false;
				_error_message = "Please Insert the Description";
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

		public void ClearFields()
		{
			decimal _zero = (decimal)0.00;

			_main_form.ExpenseDate.Value = DateTime.Now;
			_main_form.ExpenseAmount.Value = _zero;
			_main_form.ExpenseDescriptionBox.Text = "";
		}

		public void Reset() 
		{
			ClearFields();
			_main_form.ExpensesLogMonth.SelectedItem = null;
			RemoveFilters();
			_main_form.ExpensesLogGridView.DataSource = null;
		}

		/// <summary>
		/// This function deletes an expense if it was entered by mistake
		/// </summary>
		public void DeleteExpense()
		{
			//Verify that something is selected before attempting to delete
			if (_main_form.ExpensesLogGridView.SelectedCells.Count == 0)
			{
				CustomMessageBox mb = new CustomMessageBox(_main_form, CustomMessageBox.error, "Please select the expense to be deleted");
				return;
			}

			//Confirm that the user is not trying to delete the totals row
			if (_main_form.ExpensesLogGridView.CurrentCell.RowIndex == _main_form.ExpensesLogGridView.Rows.Count - 1)
			{
				CustomMessageBox mb = new CustomMessageBox(_main_form, CustomMessageBox.error, "It's not possible to delete the TOTALS row");
				return;
			}

			int _selected_row = _main_form.ExpensesLogGridView.CurrentCell.RowIndex;
			//Highlight the rows that will be deleted if the user chooses to confirm
			//Returns a string the will be the starting substring for the row that will be deleted
			int uniqueExpenseColumns = 3;
			
			csvHandles.RowsToDelete(_selected_row);
			csvHandles.ConfirmDeletion(_main_form, this);
		}

		private string pathToDeleteFile()
		{
			string _path_to_purchase_file_to_be_deleted;
			string selectedMonthAndYear = _main_form.ExpensesLogMonth.SelectedItem.ToString();
			_path_to_purchase_file_to_be_deleted = @"..//..//resources//Logs//Expenses//" + selectedMonthAndYear + ".csv";

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
				DisplayExpensesLog();
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
}
