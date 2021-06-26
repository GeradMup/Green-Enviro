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
	class Purchases_PR
	{
		static string month = DateTime.Now.ToString("MMMM yyyy");
		static string pathToProjectDirectory = Path.GetDirectoryName(Path.GetDirectoryName(Directory.GetCurrentDirectory()));
		static string SalesPRBasePath = pathToProjectDirectory + @"\resources\Logs\Police Registers\Sales";
		static string PurchasesPRBasePath = pathToProjectDirectory + @"\resources\Logs\Police Registers\Purchases";
		string pathToSalesPoliceRegister = SalesPRBasePath + @"\" + month + ".csv";
		string pathToPurchasePoliceRegister = PurchasesPRBasePath + @"\" + month + ".csv";

		Main_Form _main_form;
		
		CSVHandles csvHandles;
		DataGridView dataGridView;
		int uniqueColumns;

		DataTable _purchases_data_table;

		public Purchases_PR(Main_Form mainForm) 
		{
			_main_form = mainForm;
			csvHandles = new CSVHandles(mainForm.PurchasesPRDataGridView, uniqueColumns);
			createFiles(pathToSalesPoliceRegister);
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
			if (_main_form.PurchasePRMonth.SelectedItem == null)
			{
				//Do nothing if no month is selected
				return;
			}
		}
	}
}
