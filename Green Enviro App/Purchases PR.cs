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
		DGVOps dgvOps;
		int uniqueColumns;

		DataTable _data_table;
		BindingSource _binding_source = new BindingSource();
		public Purchases_PR(Main_Form mainForm)
		{
			_main_form = mainForm;
			csvHandles = new CSVHandles(mainForm.PurchasesPRDataGridView, uniqueColumns);
			dgvOps = new DGVOps(_main_form.PurchasesPRDataGridView,_main_form.PurchasesPRMonth,
								_main_form.PurchasePRStartDate, _main_form.PurchasePREndDate,
								_main_form.PurchasePRType,_main_form);

			//createFiles(pathToSalesPoliceRegister);
			createFiles(pathToPurchasePoliceRegister);
			setupPoliceRegisters();
		}

		private void setupPoliceRegisters()
		{
			List<string> logNames = csvHandles.getFilesInFolder(PurchasesPRBasePath);
			dgvOps.populateLogMonths(logNames);
			dgvOps.setTypes();
		}

		private void createFiles(string path)
		{
			string headers = "Date,Name,Surname,ID,No.,Item,Qnty,Price,Amnt,Type";
			csvHandles.createCSVFile(path, headers);
		}

		public void monthSelected()
		{
			if (_main_form.PurchasesPRMonth.SelectedItem == null) return;

			string _selected_month = _main_form.PurchasesPRMonth.SelectedItem.ToString();
			string _path_to_log_file = PurchasesPRBasePath + @"\" + _selected_month + ".csv";

			_data_table = csvHandles.getCSVContents(_path_to_log_file);

			HashSet<string> _dates = csvHandles.getDatesInFile(_path_to_log_file);
			dgvOps.populateDates(_dates);

			_binding_source.DataSource = _data_table;

			if (_data_table.Rows.Count > 0)	dgvOps.populateGridView(_binding_source, dgvOps.defaultColWidths(),_data_table);
			
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
