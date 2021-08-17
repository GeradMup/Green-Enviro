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
		Purchases_PR _purchases_pr;
		DGVOps dgvOps;

		DataTable _purchases_data_table = new DataTable();
		BindingSource _binding_source = new BindingSource();
		List<String> logNames;
		List<KeyValuePair<String, DataTable>> logs = new List<KeyValuePair<String, DataTable>>();

		string _empty_string = " ";
		string _totals = "TOTALS";

		string _ferrous;
		string _non_ferrous;
		public Purchases(Main_Form _main, Purchases_PR purchasesPR)
		{
			_main_form = _main;
			_purchases_pr = purchasesPR;
			int uniquePurchaseColumns = 5;
			csvHandles = new CSVHandles(_main_form.PurchseLogGridView, uniquePurchaseColumns);
			dgvOps = new DGVOps(_main_form.PurchseLogGridView, _main_form.PurchaseLogMonth,
								_main_form.PurchaseLogStartDate, _main_form.PurchaseLogEndDate,
								_main_form.PurchaseLogType, _main_form);
			CreateLogFiles();
			SetupPurchaseLogs();
		}

		public void SetupPurchaseLogs()
		{
			//This function will get the names of all the purchase log files that exists in the purchases folder
			string _purchase_logs_path = path + @"\resources\Logs\Purchases";
			logNames = csvHandles.getFilesInFolder(_purchase_logs_path, _main_form.PurchaseLogMonth);
			string pathToLogFile;
			DataTable log = new DataTable();
			
			foreach (string logName in logNames) 
			{
				pathToLogFile = path + @"\resources\Logs\Purchases\" + logName + ".csv";
				log = csvHandles.getCSVContents(pathToLogFile);
				logs.Add(new KeyValuePair<string, DataTable>(logName,log));
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

		/// <summary>Used for adding purchases to the CSV File</summary>
		/// <param name="purchasedItems">A list of all the purchase items</param>
		public void AddPurchase(List<string> purchasedItems)
		{
			string successMessage = "Purchase Completed";
			csvHandles.addToCSV(_path_to_purchases, purchasedItems,_main_form, successMessage);
			DisplayPurchaseLog();
		}

		public void DisplayPurchaseLog()
		{
			//Do nothing is the user has not selected what month they want to view
			if (_main_form.PurchaseLogMonth.SelectedItem == null) return;
			
			selectLog();

			if (_purchases_data_table.Rows.Count > 0)
			{
				_binding_source.DataSource = _purchases_data_table;
				dgvOps.FilterGridView(ref _binding_source);
				PopulateGridView();
			}
		}

		private void selectLog() 
		{
			_purchases_data_table.Clear();

			string selectedMonth = _main_form.PurchaseLogMonth.SelectedItem.ToString();

			foreach (KeyValuePair<String, DataTable> log in logs) 
			{
				if (selectedMonth == log.Key) 
				{
					_purchases_data_table = log.Value;
					break;
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
			int kgColumn = 6;
			int amountColumn = 8;

			dgvOps.addTotalsRow(_purchases_data_table, kgColumn, amountColumn);
			dgvOps.highlightTotalsRow();
		}

		public void MonthSelected() 
		{
			//Do nothing if no month is selected
			if (_main_form.PurchaseLogMonth.SelectedItem == null) return;
			
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

			//Remove any previous filters and also display the purchase logs
			RemoveFilters();
			DisplayPurchaseLog();
			
		}

		/// <summary>
		/// Removes all the filters in the purchase log and displays all the existing entries
		/// </summary>
		public void RemoveFilters() 
		{
			dgvOps.RemoveFilters();
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
				CustomMessageBox mb = new CustomMessageBox(_main_form, CustomMessageBox.error, "Please select the purchase to be deleted");
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
			csvHandles.ConfirmDeletion(_main_form,this);
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
		public override void DeleteEntriesWarning(bool actionConfirmed) 
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

		/// <summary>Adds to pr request.</summary>
		/// Handles the pre-checks before attempting to add any entry to the police register
		public void addToPRRequest() 
		{
			//Verify that something is selected before attempting to add it to the police register
			if (_main_form.PurchseLogGridView.SelectedCells.Count == 0)
			{
				CustomMessageBox mb = new CustomMessageBox(_main_form, CustomMessageBox.error, "Please select the purchase to be added");
				return;
			}

			int _current_row = _main_form.PurchseLogGridView.CurrentCell.RowIndex;

			csvHandles.highlightRow(_current_row);
			csvHandles.ConfirmPurchasePRAddition(_main_form, this);

		}

		public override void PurchasePRWarning(bool actionConfirmed)
		{
			if (actionConfirmed == true)
			{
				//Here we will handle the code for copying items over to the police register
				csvHandles.eraseHighlightMarks();
				int _current_row = _main_form.PurchseLogGridView.CurrentCell.RowIndex;

				string purchaseInfo = "";

				//Copy all the elements in the columns of the data gridview and append them to a string. 
				//The string will have a comma at the beginning and therefore must be removed
				for (int column = 0; column < _main_form.PurchseLogGridView.ColumnCount; column++) 
				{
					purchaseInfo = purchaseInfo + "," + _main_form.PurchseLogGridView.Rows[_current_row].Cells[column].Value.ToString();
				}

				//Remove the comma at the beginning of the string
				purchaseInfo = purchaseInfo.Remove(0,1);

				//Add the new entry to the police register corresponding to this month
				string month = DateTime.Now.ToString("MMMM yyyy");
				_purchases_pr.addEntryToPR(purchaseInfo, month);
			}
			else
			{
				//If user cancels the deletion, we need to remove the highlight marks
				csvHandles.eraseHighlightMarks();
			}
		}
	}
}
