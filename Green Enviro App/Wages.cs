using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;
using System.IO;
using System.Drawing;

namespace Green_Enviro_App
{
	class Wages
	{
		//First we need to know what month it is
		static string _month = DateTime.Now.ToString("MMMM yyyy");
		string _path_to_wages = @"..//..//resources//Logs//Wages//" + _month + ".csv";

		//Required objects
		Main_Form _main_form;
		Database _database;

		DataTable _wages_data_table = new DataTable();  //All the information about all the products the we have sold.
		

		BindingSource _binding_source = new BindingSource();
		string _empty_string = " ";

		public Wages(Main_Form _main, Database data)
		{
			_main_form = _main;
			_database = data;
			CreateLogFiles();
			SetupWagesLogs();
		}

		//Create purchase and wages logs for each month if they don't already exist
		private void CreateLogFiles()
		{
			//First Check if the files exist for each month
			//If the file does not exist, create it
			if (!File.Exists(_path_to_wages))
			{
				string _wages_file_headers = "Date,Name,Amount";
				StringBuilder _csv_content = new StringBuilder();
				_csv_content.AppendLine(_wages_file_headers);
				File.AppendAllText(_path_to_wages, _csv_content.ToString());
			}
		}

		public void SetupWagesLogs()
		{
			//This function will get the names of all the wages log files that exists in the wages folder
			string _wages_logs_path = @"..//..//resources//Logs//Wages";
			DirectoryInfo _directory = new DirectoryInfo(_wages_logs_path);  //Assuming Test is your Folder
			FileInfo[] _files = _directory.GetFiles("*.csv");   //Getting Text files
			foreach (FileInfo _file in _files)
			{
				char[] _remove_chars = { 'c', 's', 'v', '.' };
				string _file_name = _file.Name.TrimEnd(_remove_chars);
				_main_form.WageLogMonth.Items.Add(_file_name);
			}

			_main_form.WageDate.Value = DateTime.Now;
		}

		public void DisplayWagesLog()
		{

			if (_main_form.WageLogMonth.SelectedItem == null)
			{
				//Do nothing is the user has not selected what month they want to view
				return;
			}
			//Clear the data table so that it can be ready for the next entries
			_wages_data_table.Clear();

			string _selected_month = _main_form.WageLogMonth.SelectedItem.ToString();
			string _path_to_log_file = @"..//..//resources//Logs//Wages//" + _selected_month + ".csv";

			string[] lines = System.IO.File.ReadAllLines(_path_to_log_file);
			if (lines.Length > 0)
			{
				//first line to create the table headers
				string _first_line = lines[0];
				string[] _header_labels = _first_line.Split(',');
				if (!_wages_data_table.Columns.Contains(_header_labels[0]))
				{
					foreach (string _header_word in _header_labels)
					{
						_wages_data_table.Columns.Add(new DataColumn(_header_word));
					}
				}

				//Now we populate the table with the rest of the information that we want to view
				for (int _row = 1; _row < lines.Length; _row++)
				{
					//For each line, we want a list of the words on the line seperated by the comma
					string[] dataWords = lines[_row].Split(',');
					DataRow _data_row = _wages_data_table.NewRow();
					int columnIndex = 0;
					//Now populate the table one row at a time
					foreach (string headerWord in _header_labels)
					{
						_data_row[headerWord] = dataWords[columnIndex++];
					}
					//Add the completed row to the table
					_wages_data_table.Rows.Add(_data_row);
				}
			}

			if (_wages_data_table.Rows.Count > 0)
			{
				//Now we create the binding source for displaying the table information in the DataGridView
				_binding_source.DataSource = _wages_data_table;


				//Filter according to the date ranges if the dates have been selected correctly
				if (isDateFiltered() == true)
				{
					string _filter_start_date = _main_form.WageLogStartDate.SelectedItem.ToString();
					string _filter_end_date = _main_form.WageLogEndDate.SelectedItem.ToString();

					_binding_source.Filter = string.Format("Name = '{0}' OR Date >= '{1}' AND Date <= '{2}'", _empty_string, _filter_start_date, _filter_end_date);
				}
				else
				{
					_binding_source.RemoveFilter();
				}

				_main_form.WageLogGridView.DataSource = _binding_source;
				_main_form.WageLogGridView.Columns[1].FillWeight = 190F;

				foreach (DataGridViewColumn _column in _main_form.WageLogGridView.Columns)
				{
					_column.SortMode = DataGridViewColumnSortMode.NotSortable;
				}

				AddTotalsRow();

				int _last_row_index = 0;
				_last_row_index = _main_form.WageLogGridView.Rows.GetRowCount(DataGridViewElementStates.Visible) - 2;

				_main_form.WageLogGridView.Rows[_last_row_index].DefaultCellStyle.BackColor = Color.Yellow;
				_main_form.WageLogGridView.Refresh();
			}

		}


		//This function will add up the KG's and Amount column on the Data Grid View and adds a row to show the totals
		private void AddTotalsRow()
		{
			float _total_amount = 0;
			int _amount_column = 2;


			for (int _row = 0; _row < _main_form.WageLogGridView.Rows.Count - 1; _row++)
			{
				_total_amount += float.Parse(_main_form.WageLogGridView.Rows[_row].Cells[_amount_column].Value.ToString());
			}

			DataTable _totals_table = new DataTable();

			for (int _cols = 0; _cols < _main_form.WageLogGridView.Columns.Count; _cols++)
			{
				DataColumn _new_column = new DataColumn();
				_totals_table.Columns.Add(_new_column);
			}

			DataRow _last_row = _wages_data_table.NewRow();

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
			_wages_data_table.Rows.Add(_last_row);

		}


		public void MonthSelected()
		{
			if (_main_form.WageLogMonth.SelectedItem == null)
			{
				//Do nothing if no month is selected
				return;
			}

			string _selected_month = _main_form.WageLogMonth.SelectedItem.ToString();
			string _path_to_log_file = @"..//..//resources//Logs//Wages//" + _selected_month + ".csv";

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
			_main_form.WageLogStartDate.Items.Clear();
			_main_form.WageLogEndDate.Items.Clear();

			//Now Populate the drop down list with available dates only.
			foreach (string _date in _dates)
			{
				_main_form.WageLogStartDate.Items.Add(_date);
				_main_form.WageLogEndDate.Items.Add(_date);
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
			if ((_main_form.WageLogStartDate.SelectedItem == null) && (_main_form.WageLogEndDate.SelectedItem == null))
			{
				//Do nothing if there are not filters selected
				return false;
			}

			if ((_main_form.WageLogStartDate.SelectedItem != null) && (_main_form.WageLogEndDate.SelectedItem == null))
			{
				//Do nothing if there are not filters selected
				CustomMessageBox msg = new CustomMessageBox(_main_form, "Error!", "INVALID DATE RANGE!");
				_main_form.WageLogStartDate.SelectedItem = null;
				_main_form.WageLogEndDate.SelectedItem = null;
				return false;
			}

			if ((_main_form.WageLogStartDate.SelectedItem == null) && (_main_form.WageLogEndDate.SelectedItem != null))
			{
				//Do nothing if there are not filters selected
				CustomMessageBox msg = new CustomMessageBox(_main_form, "Error!", "INVALID DATE RANGE!");
				_main_form.WageLogStartDate.SelectedItem = null;
				_main_form.WageLogEndDate.SelectedItem = null;
				return false;
			}

			DateTime _filter_start_date = Convert.ToDateTime(_main_form.WageLogStartDate.SelectedItem.ToString());
			DateTime _filter_end_date = Convert.ToDateTime(_main_form.WageLogEndDate.SelectedItem.ToString());

			if (_filter_start_date > _filter_end_date)
			{
				CustomMessageBox msg = new CustomMessageBox(_main_form, "Error!", "INVALID DATE RANGE!");
				_main_form.WageLogStartDate.SelectedItem = null;
				_main_form.WageLogEndDate.SelectedItem = null;
				return false;
			}

			return true;
		}

		/// <summary>
		/// Removes all the filters in the purchase log and displays all the existing entries
		/// </summary>
		public void RemoveFilters()
		{
			_main_form.WageLogStartDate.SelectedItem = null;
			_main_form.WageLogEndDate.SelectedItem = null;

			DisplayWagesLog();
		}

		public void AddWage()
		{
			if (ValidEntries() == false)
			{
				return;
			}

			StringBuilder _csv_content = new StringBuilder();
			string _date = _main_form.WageDate.Value.ToString("dd MMMM yyyy");
			string _amount = _main_form.WageAmount.Value.ToString();
			string _employee;

			//Check if new Employee is Selected. If new Employee is selected, read the text, if not, read the 
			//the selected index
			_employee = _main_form.WagesEmployeeName.Text;
			string _new_wage = _date + "," + _employee + "," + _amount;
			_csv_content.AppendLine(_new_wage);

			try
			{
				File.AppendAllText(_path_to_wages, _csv_content.ToString());
				ClearFields();
				CustomMessageBox newBox = new CustomMessageBox(_main_form, "Success!", "Wage Recorded");
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error! \n" + ex.Message);
			}
		}

		//Validate that the user has entered all the information correctly
		private bool ValidEntries()
		{
			bool _all_good = false;
			string _title = "Error!";
			string _error_message = "";
			decimal _zero = (decimal)0.00;
			string _no_text = "";

			if (_main_form.WageAmount.Value == _zero)
			{
				_all_good = false;
				_error_message = "Please Insert the Amount";
			}
			else if (_main_form.WagesEmployeeName.Text == _no_text)
			{
				_all_good = false;
				_error_message = "Please Insert the Employee Name";
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

			_main_form.WageDate.Value = DateTime.Now;
			_main_form.WageAmount.Value = _zero;
			_main_form.PartTimeEmployeeCheckBox.CheckState = CheckState.Unchecked;
			_main_form.WagesEmployeeName.DropDownStyle = ComboBoxStyle.DropDownList;
			_main_form.WagesEmployeeName.SelectedItem = null;
		}

		public void PartTimeEmployee() 
		{
			if (_main_form.PartTimeEmployeeCheckBox.CheckState == CheckState.Checked)
			{
				_main_form.WagesEmployeeName.DropDownStyle = ComboBoxStyle.DropDown;
			}
			else 
			{
				_main_form.WagesEmployeeName.DropDownStyle = ComboBoxStyle.DropDownList;
			}
		}

		public void Reset() 
		{
			ClearFields();
			_main_form.WageLogMonth.SelectedItem = null;
			RemoveFilters();
			_main_form.WageLogGridView.DataSource = null;
		}
	}
}
