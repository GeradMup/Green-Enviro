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
	
	public class Inventory
	{
		static string _month = DateTime.Now.ToString("MMMM yyyy");
		string _path_to_inventory = @"..//..//resources//Logs//Inventory//" + _month + ".csv";
		Main_Form _main_form;

		DataTable _inventory_data_table = new DataTable();
		BindingSource _binding_source = new BindingSource();

		public Inventory(Main_Form main)
		{
			_main_form = main;

			CreateLogFiles();
			SetUpInvetory();
		}

		private void CreateLogFiles()
		{
			//First Check if the files exist for each month
			//If the file does not exist, create it
			if (!File.Exists(_path_to_inventory))
			{
				string _inventory_file_headers = "Date,Item,Type,Quantity";
				StringBuilder _csv_content = new StringBuilder();
				_csv_content.AppendLine(_inventory_file_headers);
				//_csv_content.AppendLine("\n");
				File.AppendAllText(_path_to_inventory, _csv_content.ToString());
			}
		}

		private void SetUpInvetory() 
		{
			//This function will get the names of all the purchase log files that exists in the purchases folder
			string _inventory_logs_path = @"..//..//resources//Logs//Inventory";
			DirectoryInfo _directory = new DirectoryInfo(_inventory_logs_path);  //Assuming Test is your Folder
			FileInfo[] _files = _directory.GetFiles("*.csv");   //Getting Text files
			foreach (FileInfo _file in _files)
			{
				char[] _remove_chars = { 'c', 's', 'v', '.' };
				string _file_name = _file.Name.TrimEnd(_remove_chars);
				_main_form.InventoryLogMonth.Items.Add(_file_name);
			}
		}

		public void AddItems(List<string> entries) 
		{
			StringBuilder _csv_content = new StringBuilder();
			foreach (string _single_entry in entries)
			{ 
				_csv_content.AppendLine(_single_entry);
			}

			try
			{
				File.AppendAllText(_path_to_inventory, _csv_content.ToString());
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error! \n" + ex.Message);
			}
		}

		public void MonthSelected() 
		{
			if (_main_form.InventoryLogMonth.SelectedItem == null)
			{
				//Do nothing if no month is selected
				return;
			}

			string _selected_month = _main_form.InventoryLogMonth.SelectedItem.ToString();
			string _path_to_inventory_file = @"..//..//resources//Logs//Inventory//" + _selected_month + ".csv";

			string[] lines = System.IO.File.ReadAllLines(_path_to_inventory_file);
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
			_main_form.InventoryLogStartDate.Items.Clear();
			_main_form.InventoryLogEndDate.Items.Clear();

			//Now Populate the drop down list with available dates only.
			foreach (string _date in _dates)
			{
				_main_form.InventoryLogStartDate.Items.Add(_date);
				_main_form.InventoryLogEndDate.Items.Add(_date);
			}

			//Change the contents displayed in the log if the month selected changes
			RemoveFilters();
			DisplayLog();
		}

		private void RemoveFilters() 
		{
			
		}

		private void DisplayLog() 
		{
			if (_main_form.InventoryLogMonth.SelectedItem == null)
			{
				//Do nothing is the user has not selected what month they want to view
				return;
			}

			LoadInventoryLog();

			if (_inventory_data_table.Rows.Count > 0)
			{
				_binding_source.DataSource = _inventory_data_table;
				FilterGridView();
				PopulateGridView();
			}
		}

		private void LoadInventoryLog() 
		{
			_inventory_data_table.Clear();

			string _selected_month = _main_form.InventoryLogMonth.SelectedItem.ToString();
			string _path_to_log_file = @"..//..//resources//Logs//Inventory//" + _selected_month + ".csv";

			string[] lines = System.IO.File.ReadAllLines(_path_to_log_file);
			if (lines.Length > 0)
			{
				//first line to create the table headers
				string _first_line = lines[0];
				string[] _header_labels = _first_line.Split(',');
				if (!_inventory_data_table.Columns.Contains(_header_labels[0]))
				{
					foreach (string _header_word in _header_labels)
					{
						_inventory_data_table.Columns.Add(new DataColumn(_header_word));
					}
				}

				//Now we populate the table with the rest of the information that we want to view
				for (int _row = 1; _row < lines.Length; _row++)
				{
					//For each line, we want a list of the words on the line seperated by the comma
					string[] dataWords = lines[_row].Split(',');
					DataRow _data_row = _inventory_data_table.NewRow();
					int columnIndex = 0;
					foreach (string headerWord in _header_labels)
					{
						_data_row[headerWord] = dataWords[columnIndex++];
					}

					bool _row_exists = false;
					int _current_row = 0;
					string _quantity = "Quantity";
					string _date_string = "Date";
					foreach (DataRow _new_row in _inventory_data_table.Rows) 
					{
						if (_new_row["Item"].ToString() == _data_row["Item"].ToString()) 
						{
							_row_exists = true;
							break;
						}
						_current_row++;
					}

					if (_row_exists)
					{
						float _current_total_qnty= float.Parse(_inventory_data_table.Rows[_current_row][_quantity].ToString());
						float _new_total_qnty = _current_total_qnty + float.Parse(_data_row[_quantity].ToString());
						_inventory_data_table.Rows[_current_row][_quantity] = _new_total_qnty.ToString();
						_inventory_data_table.Rows[_current_row][_date_string] = _data_row[_date_string];
					}
					else 
					{
						_inventory_data_table.Rows.Add(_data_row);
					}
				}
			}
		}

		private void FilterGridView() 
		{ 
			
		}

		private void PopulateGridView() 
		{
			_main_form.InventoryLogGridView.DataSource = _binding_source;
			//_main_form.PurchseLogGridView.Columns[0].FillWeight = 120F;
			//_main_form.PurchseLogGridView.Columns[3].FillWeight = 150F;

			//Disables the ability to sort columns using the headers
			foreach (DataGridViewColumn _column in _main_form.InventoryLogGridView.Columns)
			{
				_column.SortMode = DataGridViewColumnSortMode.NotSortable;
			}

			//AddTotalsRow();
			//int _last_row_index = 0;
			//_last_row_index = _main_form.PurchseLogGridView.Rows.GetRowCount(DataGridViewElementStates.Visible) - 2;

			//_main_form.PurchseLogGridView.Rows[_last_row_index].DefaultCellStyle.BackColor = Color.Yellow;
			_main_form.InventoryLogGridView.Refresh();
		}
	}
}
