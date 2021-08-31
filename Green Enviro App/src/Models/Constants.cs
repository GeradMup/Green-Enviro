using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Green_Enviro_App.src.Models
{


	class Constants
	{
		public readonly string PROJECT_PATH;
		public readonly string PURCHASES_BASE_PATH;
		public readonly string DELIVERY_NOTES_BASE_PATH;
		public readonly string DESTRUCTION_CERTIFICATES_BASE_PATH;
		public readonly string EXPENSES_BASE_PATH;
		public readonly string INVENTORY_BASE_PATH;
		public readonly string PURCHASE_POLICE_REG_BASE_PATH;
		public readonly string SALES_POLICE_REG_BASE_PATH;
		public readonly string SALES_BASE_PATH;
		public readonly string WAGES_BASE_PATH;

		public Constants()
		{
			PROJECT_PATH = Path.GetDirectoryName(Path.GetDirectoryName(Directory.GetCurrentDirectory()));
			PURCHASES_BASE_PATH = PROJECT_PATH + @"\resources\Logs\Purchases\";
			DELIVERY_NOTES_BASE_PATH = PROJECT_PATH + @"\resources\Logs\Delivery Notes\";
			DESTRUCTION_CERTIFICATES_BASE_PATH = PROJECT_PATH + @"\resources\Logs\Destruction Certificates\";
			EXPENSES_BASE_PATH = PROJECT_PATH + @"\resources\Logs\Expenses\";
			INVENTORY_BASE_PATH = PROJECT_PATH + @"\resources\Logs\Inventory\";
			PURCHASE_POLICE_REG_BASE_PATH = PROJECT_PATH + @"\resources\Logs\Police Registers\Purchases\";
			SALES_POLICE_REG_BASE_PATH = PROJECT_PATH + @"\resources\Logs\Police Registers\Sales\";
			SALES_BASE_PATH = PROJECT_PATH + @"\resources\Logs\Sales\";
			WAGES_BASE_PATH = PROJECT_PATH + @"\resources\Logs\Wages\";
		}
	}
}
