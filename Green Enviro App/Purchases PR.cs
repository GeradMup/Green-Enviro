using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Green_Enviro_App
{
	public class Purchases_PR
	{
		static string month = DateTime.Now.ToString("MMMM yyyy");
		static string pathToProjectDirectory = Path.GetDirectoryName(Path.GetDirectoryName(Directory.GetCurrentDirectory()));
		static string SalesPRBasePath = pathToProjectDirectory + @"\resources\Logs\Police Registers\Sales";
		static string PurchasesPRBasePath = pathToProjectDirectory + @"\resources\Logs\Police Registers\Purchases";
		//string pathToSalesPoliceRegister = SalesPRBasePath + @"\" + month + ".csv";
		string pathToPurchasePoliceRegister = PurchasesPRBasePath + @"\" + month + ".csv";

		Main_Form _main_form;

		CSVHandles csvHandles;
		int uniqueColumns;

		DataTable _data_table;
		BindingSource _binding_source = new BindingSource();
		public Purchases_PR(Main_Form mainForm)
		{
			_main_form = mainForm;
			csvHandles = new CSVHandles(mainForm.PurchasesPRDataGridView, uniqueColumns);
			//createFiles(pathToSalesPoliceRegister);
			createFiles(pathToPurchasePoliceRegister);
			setupPoliceRegisters();
		}

		private void setupPoliceRegisters()
		{
			//_sales_data_table = csvHandles.getCSVContents(pathToPurchasePoliceRegister);
			//_purchases_data_table = csvHandles.getCSVContents(pathToSalesPoliceRegister);
			List<string> fileNames = csvHandles.getFilesInFolder(PurchasesPRBasePath, _main_form.PurchasesPRMonth);
		}

		private void createFiles(string path)
		{
			string headers = "Date,Name,Surname,ID,No.,Item,Qnty,Price,Amnt,Type";
			csvHandles.createCSVFile(path, headers);
		}

		public void monthSelected()
		{
			if (_main_form.PurchasesPRMonth.SelectedItem == null)
			{
				//Do nothing if no month is selected
				return;
			}

			string _selected_month = _main_form.PurchasesPRMonth.SelectedItem.ToString();
			string _path_to_log_file = PurchasesPRBasePath + @"\" + _selected_month + ".csv";

			_data_table = csvHandles.getCSVContents(_path_to_log_file);
			
			if (_data_table.Rows.Count > 0)
			{
				_binding_source.DataSource = _data_table;
				populateGridView();
			}
		}

		private void populateGridView()
		{
			_main_form.PurchasesPRDataGridView.DataSource = _binding_source;

			_main_form.PurchasesPRDataGridView.Columns[0].FillWeight = 180F;
			_main_form.PurchasesPRDataGridView.Columns[1].FillWeight = 100F;
			_main_form.PurchasesPRDataGridView.Columns[2].FillWeight = 110F;
			_main_form.PurchasesPRDataGridView.Columns[3].FillWeight = 130F;
			_main_form.PurchasesPRDataGridView.Columns[4].FillWeight = 40F;
			_main_form.PurchasesPRDataGridView.Columns[5].FillWeight = 80F;
			_main_form.PurchasesPRDataGridView.Columns[6].FillWeight = 50F;
			_main_form.PurchasesPRDataGridView.Columns[7].FillWeight = 50F;
			_main_form.PurchasesPRDataGridView.Columns[8].FillWeight = 60F;

			//Disables the ability to sort columns using the headers
			foreach (DataGridViewColumn _column in _main_form.PurchasesPRDataGridView.Columns)
			{
				_column.SortMode = DataGridViewColumnSortMode.NotSortable;
			}
		}

		//This function converts entries from a data table into a list of strings
		//Each row in the table will be a single string which is comma delimeted
		private List<String> dataTableToStringList(DataTable table)
		{
			List<String> stringList = new List<String>();
			string line = "";
			foreach (DataRow row in table.Rows)
			{
				foreach (DataColumn column in table.Columns)
				{
					line = line + "," + row[column].ToString();
				}
				//Remove the comma at the beginning of the line
				line = line.Remove(0, 1);
				stringList.Add(line);
				line = "";
			}

			return stringList;
		}

		public void addEntryToPR(string purchaseEntry, string month)
		{

			string _path_to_log_file = PurchasesPRBasePath + @"\" + month + ".csv";

			DataTable temp_data_table = csvHandles.getCSVContents(_path_to_log_file);
			List<String> PREntries = dataTableToStringList(temp_data_table);

			if (PREntries.Contains(purchaseEntry))
			{
				string errorMessage = "THIS PURCHASE HAS ALREADY BEEN ADDED TO THE POLICE REGISTER!!!";
				CustomMessageBox mb = new CustomMessageBox(_main_form,CustomMessageBox.error, errorMessage);
			}
			else
			{
				List<String> lines = new List<String>();
				lines.Add(purchaseEntry);
				string successMessage = "Purchase added to Purchase Police Register";
				csvHandles.addToCSV(pathToPurchasePoliceRegister, lines, _main_form, successMessage);

			}
		}
	}
}
