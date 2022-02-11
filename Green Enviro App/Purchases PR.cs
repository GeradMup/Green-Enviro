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
	/*
	public class Purchases_PR
	{
		Main_Form _main_form;

		CSVHandles csvHandles;
		FileHandles fileHandles;
		DGVOps dgvOps;
		int uniqueColumns;

		DataTable dataTable;
		BindingSource _binding_source = new BindingSource();
		public Purchases_PR(Main_Form mainForm, FileHandles fh)
		{
			_main_form = mainForm;
			fileHandles = fh;
			csvHandles = new CSVHandles(mainForm.PurchasesPRDataGridView, uniqueColumns);
			dgvOps = new DGVOps(_main_form.PurchasesPRDataGridView,_main_form.PurchasesPRMonth,
								_main_form.PurchasePRStartDate, _main_form.PurchasePREndDate,
								_main_form.PurchasePRType,_main_form);

			//createCSVFiles(pathToSalesPoliceRegister);
			createCSVFiles();
			setupPoliceRegisters();
		}

		private void setupPoliceRegisters()
		{
			List<string> logNames = fileHandles.getLogNames(FileHandles.LogType.PurchasesPoliceRegisters);
			dgvOps.populateLogMonths(logNames);
			dgvOps.setTypes();
		}

		//We will generate files on a monthly basis. This code will automatically generate a new csv file for each month
		private void createCSVFiles()
		{
			string headers = "Date,Name,Surname,ID,No.,Item,Qnty,Price,Amnt,Type,Sold";
			fileHandles.createCSVFile(FileHandles.LogType.PurchasesPoliceRegisters, headers);
		}

		public void monthSelected()
		{
			if (_main_form.PurchasesPRMonth.SelectedItem == null) return;

			string selectedMonthAndYear = _main_form.PurchasesPRMonth.SelectedItem.ToString();
			string pathToLogFile = fileHandles.pathToLogs(FileHandles.LogType.PurchasesPoliceRegisters, selectedMonthAndYear);

			dataTable = csvHandles.getCSVContents(pathToLogFile);

			HashSet<string> _dates = csvHandles.getDatesInFile(pathToLogFile);
			dgvOps.populateDates(_dates);

			dgvOps.changeBindingSource(dataTable);
			//if (dataTable.Rows.Count > 0)	dgvOps.populateAndFilterGrid(dgvOps.defaultColWidths());
			
		}

		public void filterGrid() 
		{
			dgvOps.filterGridView();
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

			string pathToLogFile = fileHandles.pathToLogs(FileHandles.LogType.PurchasesPoliceRegisters, month);

			DataTable temp_data_table = csvHandles.getCSVContents(pathToLogFile);
			List<String> PREntries = dataTableToStringList(temp_data_table);

			if (PREntries.Contains(purchaseEntry))
			{
				string errorMessage = "THIS PURCHASE HAS ALREADY BEEN ADDED TO THE POLICE REGISTER!!!";
				CustomMessageBox mb = new CustomMessageBox(_main_form,CustomMessageBox.MessageType.error, errorMessage);
			}
			else
			{
				//Add entry to the police register and flag it as not sold
				//The zero at the end flags the entry as not sold
				purchaseEntry = purchaseEntry + ",0";
				List<String> lines = new List<String>();
				lines.Add(purchaseEntry);
				string successMessage = "Purchase added to Purchase Police Register";
				//csvHandles.addToCSV(fileHandles.pathToLogs(FileHandles.LogType.PurchasesPoliceRegisters), lines, _main_form, successMessage);
			}
		}
	}*/
}
