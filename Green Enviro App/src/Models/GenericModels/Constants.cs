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
		/// <summary>The path to the database sync program.</summary>
		public static readonly string DATABASE_SYNC_PROGRAM_PATH;
		/// <summary>The path to the main program's excecutable.</summary>
		public static readonly string MAIN_PROGRAM_PATH;
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
		/// <summary>The ferrous material label.</summary>
		public static readonly string FERROUS;
		/// <summary>The non ferrous material label.</summary>
		public static readonly string NON_FERROUS;
		/// <summary>The CSV extension</summary>
		public static readonly string CSV_EXTENSION;
		/// <summary>String representing an empty text.</summary>
		public static readonly string EMPTY_TEXT;
		/// <summary>The decimal zero</summary>
		public static readonly Decimal DECIMAL_ZERO;
		/// <summary>The PDF extension</summary>
		public static readonly string PDF_EXTENSION;
		/// <summary>Today's date.</summary>
		public static readonly string DATE;
		/// <summary>The company letterhead path.</summary>
		public static readonly string COMPANY_LETTERHEAD_PATH;
		/// <summary>The path to delivery items list.</summary>
		public static readonly string PATH_TO_DELIVERY_ITEMS;
		/// <summary>Path to the signature of the company's operations director.</summary>
		public static readonly string SINGNATURE_IMAGE_PATH;
		/// <summary>The format to use when naming log names from a date.</summary>
		public static readonly string LOG_NAME_DATE_FORMAT;
		/// <summary>The time format to use for logging transaction times.</summary>
		public static readonly string TIME_FORMAT;
		/// <summary>The date format to use for logging transaction dates.</summary>
		public static readonly string DATE_FORMAT;
		/// <summary>Special input characters to be ignored if users input them.</summary>
		public static readonly string SPECIAL_CHARACTERS;
		/// <summary>Permission denied error string.</summary>
		public static readonly string PERMISSION_DENIED;
		/// <summary>Admin permission level.</summary>
		public static readonly int ADMIN_PERMISSION_LEVEL;
		/// <summary>Elevated permission level.</summary>
		public static readonly int ELEVATED_PERMISSION_LEVEL;
		/// <summary>Initializes a new instance of the <see cref="Constants" /> class.</summary>
		static Constants()
		{
			PROJECT_PATH = Path.GetDirectoryName(Path.GetDirectoryName(Directory.GetCurrentDirectory()));
			DATABASE_SYNC_PROGRAM_PATH = PROJECT_PATH + @"\Green Enviro Sync\bin\Debug\Green Enviro Sync.exe";
			MAIN_PROGRAM_PATH = PROJECT_PATH + @"\bin\Debug\Green Enviro App.exe";
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
			PDF_EXTENSION = ".pdf";
			FERROUS = "Ferrous";
			NON_FERROUS = "Non-Ferrous";
			EMPTY_TEXT = "";
			DECIMAL_ZERO = 0.0M;
			DATE = DateTime.Now.ToString("dd MMMM yyyy");
			COMPANY_LETTERHEAD_PATH = PROJECT_PATH + @"\resources\Green Enviro Destruction Certificate Logo Better.png";
			PATH_TO_DELIVERY_ITEMS = PROJECT_PATH + @"\resources\Items\Items.txt";
			SINGNATURE_IMAGE_PATH = PROJECT_PATH + @"\resources\Green Enviro Signature.jpeg";
			LOG_NAME_DATE_FORMAT = "MMMM yyyy";
			SPECIAL_CHARACTERS = ",";
			TIME_FORMAT = "HH:mm:ss";
			DATE_FORMAT = "dd MMMM yyyy ";
			PERMISSION_DENIED = "Permission Denied!";
			ADMIN_PERMISSION_LEVEL = 5;
			ELEVATED_PERMISSION_LEVEL = 3;
		}
	}
}
