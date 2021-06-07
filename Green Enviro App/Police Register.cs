using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Green_Enviro_App
{
	class Police_Register
	{
		static string month = DateTime.Now.ToString("MMMM yyyy");
		static string pathToProjectDirectory = Path.GetDirectoryName(Path.GetDirectoryName(Directory.GetCurrentDirectory()));
		string pathToSalesPoliceRegister = pathToProjectDirectory + @"\resources\Logs\Police Registers\Sales\" + month + ".csv";
		string pathToPurchasePoliceRegister = pathToProjectDirectory + @"\resources\Logs\Police Registers\Purchases\" + month + ".csv";

		public Police_Register() 
		{
			
		}

		private void setupPoliceRegisters() 
		{
			
		}

		private void createFiles(string path) 
		{
			string headers = "Date";
			StringBuilder _csv_content = new StringBuilder();
			_csv_content.AppendLine(headers);
				
			File.AppendAllText(headers, _csv_content.ToString());
		}

	}
}
