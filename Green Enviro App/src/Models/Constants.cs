using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Green_Enviro_App
{
	/// <summary>This Class contains all the common constants that will be used throughout the project</summary>
	public class Constants
	{
		/// <summary>The main project path where the solution is located</summary>
		public static readonly string PROJECT_PATH;
		/// <summary>The purchases base path</summary>
		public static readonly string PURCHASES_BASE_PATH;
		/// <summary>The delivery notes base path</summary>
		public static readonly string DELIVERY_NOTES_BASE_PATH;
		/// <summary>The destruction certificates base path</summary>
		public static readonly string DESTRUCTION_CERTIFICATES_BASE_PATH;
		/// <summary>The expenses base path</summary>
		public static readonly string EXPENSES_BASE_PATH;
		/// <summary>The inventory base path</summary>
		public static readonly string INVENTORY_BASE_PATH;
		/// <summary>The purchase police reg base path</summary>
		public static readonly string PURCHASE_POLICE_REG_BASE_PATH;
		/// <summary>The sales police reg base path</summary>
		public static readonly string SALES_POLICE_REG_BASE_PATH;
		/// <summary>The sales base path</summary>
		public static readonly string SALES_BASE_PATH;
		/// <summary>The wages base path</summary>
		public static readonly string WAGES_BASE_PATH;
		/// <summary>The current month and year</summary>
		public static readonly string CURRENT_MONTH_AND_YEAR;

		/// <summary>The CSV extension</summary>
		public static readonly string CSV_EXTENSION;

		/// <summary>Initializes a new instance of the <see cref="Constants" /> class.</summary>
		static Constants()
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
			CURRENT_MONTH_AND_YEAR = DateTime.Now.ToString("MMMM yyyy");
			CSV_EXTENSION = ".csv";
		}
	}
}
