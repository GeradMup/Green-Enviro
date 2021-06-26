using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Green_Enviro_App
{
	class Police_Register
	{
		static string month = DateTime.Now.ToString("MMMM yyyy");
		static string pathToProjectDirectory = Path.GetDirectoryName(Path.GetDirectoryName(Directory.GetCurrentDirectory()));
		string pathToSalesPoliceRegister = pathToProjectDirectory + @"\resources\Logs\Police Registers\Sales\" + month + ".csv";
		string pathToPurchasePoliceRegister = pathToProjectDirectory + @"\resources\Logs\Police Registers\Purchases\" + month + ".csv";

		Main_Form _main_form;
		
		CSVHandles csvHandles;
		DataGridView dataGridView;
		int uniqueColumns;

		public Police_Register(Main_Form mainForm) 
		{
			csvHandles = new CSVHandles(dataGridView, uniqueColumns);
			createFiles(pathToSalesPoliceRegister);
			createFiles(pathToPurchasePoliceRegister);
			_main_form = mainForm;
		}

		private void setupPoliceRegisters() 
		{
			
		}

		private void createFiles(string path) 
		{
			string headers = "Date,Name,Surname,ID,No.,Item,Qnty,Price,Amnt,Type";
			csvHandles.createCSVFile(path, headers);	
		}
	}
}
