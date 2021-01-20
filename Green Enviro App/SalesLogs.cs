using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;
using System.IO;

namespace Green_Enviro_App
{
	class SalesLogs
	{
		static string _month_n_year = DateTime.Now.ToString("MMMM yyyy");
		string _path_to_sales = @"..//..//resources//Logs//Sales//" + _month_n_year + ".csv";

		Main_Form _main_form;

		DataTable _purchases_data_table = new DataTable();
		BindingSource _binding_source = new BindingSource();
		string _empty_string = " ";

		string _ferrous;
		string _non_ferrous;
		public SalesLogs(Main_Form _main)
		{
			_main_form = _main;
			CreateLogFiles();
			SetupSalesLogs();
		}

		private void SetupSalesLogs()
		{
			
		}

		private void CreateLogFiles() 
		{
			if (!File.Exists(_path_to_sales))
			{
				string _sales_file_headers = "Date,Company,Quantity,Amount,Type";
				StringBuilder _csv_content = new StringBuilder();
				_csv_content.AppendLine(_sales_file_headers);
				File.AppendAllText(_path_to_sales, _csv_content.ToString());
			}
		}

		public void setTypes(string F, string N)
		{
			_ferrous = F;
			_non_ferrous = N;

			//Also setup the Ferrous or Non-Ferrous Selector
			_main_form.PurchaseLogType.Items.Add(_ferrous);
			_main_form.PurchaseLogType.Items.Add(_non_ferrous);
		}

		public void AddSale() 
		{

		}
	}
}
