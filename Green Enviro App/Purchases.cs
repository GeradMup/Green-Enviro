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
	public class Purchases
	{
		Main_Form _main_form;
		CSVHandles csvHandles;
		FileHandles fileHandles;
		Purchases_PR _purchases_pr;
		DGVOps dgvOps;

		DataTable _purchases_data_table = new DataTable();
		BindingSource _binding_source = new BindingSource();
		List<String> logNames;
		List<DataTable> logs = new List<DataTable>();

		/// <summary>Initializes a new instance of the <see cref="Purchases" /> class.</summary>
		/// <param name="_main">The main user form control object</param>
		/// <param name="purchasesPR">The Purchases Police Register object.</param>
		/// <param name="fh">The FileHandles object.</param>
		public Purchases(Main_Form _main, Purchases_PR purchasesPR, FileHandles fh)
		{
			_main_form = _main;
			_purchases_pr = purchasesPR;
			fileHandles = fh;
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
			logNames = fileHandles.getLogNames(FileHandles.LogType.Purchases);
			dgvOps.populateLogMonths(logNames);
			dgvOps.setTypes();
		}

		//Create purchase and sales logs for each month if they don't already exist
		private void CreateLogFiles()
		{
			string _purchases_file_headers = "Date,Name,Surname,ID,No.,Item,Qnty,Price,Amnt,Type";
			fileHandles.createCSVFile(FileHandles.LogType.Purchases, _purchases_file_headers);
		}

		/// <summary>Used for adding purchases to the CSV File</summary>
		/// <param name="purchasedItems">A list of all the purchase items</param>
		public void AddPurchase(List<string> purchasedItems)
		{
			string successMessage = "Purchase Completed";
			//csvHandles.addToCSV(fileHandles.pathToLogs(FileHandles.LogType.Purchases), purchasedItems,_main_form, successMessage);
			DisplayPurchaseLog();
		}

		public void DisplayPurchaseLog()
		{
			//Do nothing is the user has not selected what month they want to view
			if (_main_form.PurchaseLogMonth.SelectedItem == null) return;
			
			selectLog();

			if (_purchases_data_table.Rows.Count > 0)
			{
				int kgColumn = 6;
				int amountCol = 8;

				dgvOps.changeBindingSource(_purchases_data_table);
				dgvOps.populateAndFilterGrid(dgvOps.defaultColWidths(), kgColumn, amountCol);
			}
		}

		private void selectLog() 
		{
			_purchases_data_table.Clear();

			string selectedMonth = _main_form.PurchaseLogMonth.SelectedItem.ToString();
			string pathToLogFile = fileHandles.pathToLogs(FileHandles.LogType.Purchases, selectedMonth);

			_purchases_data_table = csvHandles.getCSVContents(pathToLogFile);
		}

		public void MonthSelected() 
		{
			//Do nothing if no month is selected
			if (_main_form.PurchaseLogMonth.SelectedItem == null) return;
			
			string selectedMonth = _main_form.PurchaseLogMonth.SelectedItem.ToString();
			string pathToLogFile = fileHandles.pathToLogs(FileHandles.LogType.Purchases, selectedMonth);

			HashSet<string> dates = csvHandles.getDatesInFile(pathToLogFile);
			dgvOps.populateDates(dates);
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

		public void filterGrid() 
		{
			//To apply filters, we simply need to display the log again because everytime when the DataGrid
			//populate, a check is done to see if any filters have been applied or not
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
			//csvHandles.ConfirmDeletion(_main_form,this);
		}

		private string pathToDeleteFile()
		{
			string _path_to_purchase_file_to_be_deleted;
			string selectedMonthAndYear = _main_form.PurchaseLogMonth.SelectedItem.ToString();
			_path_to_purchase_file_to_be_deleted = @"..//..//resources//Logs//Purchases//" + selectedMonthAndYear + ".csv";
			
			return _path_to_purchase_file_to_be_deleted;
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
			//csvHandles.ConfirmPurchasePRAddition(_main_form, this);

		}

		public void PurchasePRWarning(bool actionConfirmed)
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
