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
	class Logs
	{
		public Logs() 
		{
			CreateLogFiles();
		}


		//Create purchase and sales logs for each month if they don't already exist
		private void CreateLogFiles() 
		{
			//First we need to know what month it is
			string _month = DateTime.Now.ToString("MMMM");

			//First Check if the files exist for each month
			string _path_to_purchases = @"..//..//resources//Logs//Purchases//" + _month + ".csv";
			string _path_to_sales = @"..//..//resources//Logs//Sales//" + _month + ".csv";
			string _path_to_expenses = @"..//..//resources//Logs//Expenses//" + _month + ".csv";
			string _path_to_wages = @"..//..//resources//Logs//Wages//" + _month + ".csv";

			if (!File.Exists(_path_to_purchases)) 
			{
				string _purchases_file_headers = "Date,Name,Surname,ID,Number,Item,Quantity,Price,Amount,F/N";
				CreateFile(_path_to_purchases, _purchases_file_headers);
			}

			if (!File.Exists(_path_to_sales))
			{
				string _sales_file_headers = "Date,Company,Quantity,Amount,F/N";
				CreateFile(_path_to_sales, _sales_file_headers);
			}

			if (!File.Exists(_path_to_expenses))
			{
				string _expenses_file_headers = "Date,Description,Amount";
				CreateFile(_path_to_expenses, _expenses_file_headers);
			}

			if (!File.Exists(_path_to_wages))
			{
				string _wages_file_headers = "Date,Person,Amount";
				CreateFile(_path_to_wages, _wages_file_headers);
			}
		}

		private void CreateFile(string path, string headers) 
		{
			StringBuilder _csv_content = new StringBuilder();
			_csv_content.AppendLine(headers);
			File.AppendAllText(path, _csv_content.ToString());
		}
	}
}
