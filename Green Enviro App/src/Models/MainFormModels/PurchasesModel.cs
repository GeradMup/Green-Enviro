using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Green_Enviro_App
{
	using GridViewData = DGVOps.GridViewData;

	/// <summary>
	/// Class to handle all the business logic related to the Purchases interactions.
	/// </summary>
	class PurchasesModel
	{
		private CSVHandles csvHandles;
		private FileHandles fileHandles;

		/// <summary>Initializes a new instance of the <see cref="PurchasesModel" /> class.</summary>
		/// <param name="fh">The FileHandles object.</param>
		/// <param name="csvh">The CSVHandles object.</param>
		public PurchasesModel(FileHandles fh, CSVHandles csvh) 
		{
			csvHandles = csvh;
			fileHandles = fh;
			createLogFiles();
		}

		/// <summary>
		/// Creates the log files for each month.
		/// </summary>
		private void createLogFiles() 
		{
			string purchasesLogHeaders = GenericModels.enumFieldsToString<PurchaseLogHeaders>();
			fileHandles.createCSVFile(FileHandles.LogType.Purchases, purchasesLogHeaders);
		}

		/// <summary>Gets the column number for the amount in the log file.</summary>
		/// <returns>The column number as an integer.</returns>
		public int amountColumn() 
		{
			return (int)PurchaseLogHeaders.Amnt;
		}

		/// <summary>Gets the column number for the quantity in the log file.</summary>
		/// <returns>The column number as an integer.</returns>
		public int quantityColumn() 
		{
			return (int)PurchaseLogHeaders.Qnty;
		}

		/// <summary>Gets the months of all the log months recorded.</summary>
		/// <returns>List of string representing all the log months.</returns>
		public List<string> getMonths()
		{
			try
			{
				return fileHandles.getLogNames(FileHandles.LogType.Purchases);
			}
			catch (Exception ex) 
			{
				throw new Exception(ex.Message);
			}
		}

		/// <summary>Gets the grid data given the selected log month.</summary>
		/// <param name="month">The selected log month.</param>
		/// <returns>A GridViewData object containing the Grid information and the dates in the selected log.</returns>
		/// <exception cref="System.Exception">If anything goes wrong while loading the data from the file.</exception>
		public GridViewData getGridData(string month) 
		{
			string pathToLog = fileHandles.pathToLogs(FileHandles.LogType.Purchases, month);
			GridViewData gridData = new GridViewData();

			try
			{
				gridData.data = csvHandles.getCSVContents(pathToLog);
				gridData.dates = csvHandles.getDatesInFile(pathToLog);
			}
			catch (Exception ex) 
			{
				throw new Exception(ex.Message);
			}
			return gridData;
		}

		/// <summary>Deletes a purchase entry given the its information and the log month where it belongs.</summary>
		/// <param name="entryInfo">The entry information.</param>
		/// <param name="month">The month.</param>
		public void deleteEntry(string entryInfo, string month) 
		{
			string pathToLog = fileHandles.pathToLogs(FileHandles.LogType.Purchases, month);
			csvHandles.setRowToDelete(entryInfo);
			try
			{
				csvHandles.deleteInCSV(pathToLog);
			}
			catch (Exception ex) 
			{
				throw new Exception(ex.Message);
			}
		}

		/// <summary>
		/// An Enum class describing headers for the Purchases log file.
		/// </summary>
		enum PurchaseLogHeaders 
		{
			/// <summary>The date. </summary>
			Date,
			/// <summary>The customer name.</summary>
			Name,
			/// <summary>The customer surname.</summary>
			Surname,
			/// <summary>The customer ID number.</summary>
			ID,
			/// <summary>The customer number</summary>
			Num,
			/// <summary>The item name.</summary>
			Item,
			/// <summary>The purchased quantity.</summary>
			Qnty,
			/// <summary>The unit price of the item.</summary>
			Price,
			/// <summary>The amount paid for the item.</summary>
			Amnt,
			/// <summary>The type of the item. Type is either Ferrous or Non-Ferrous.</summary>
			Type
		}

		/// <summary>
		/// Object to describe the customer information for purchases.
		/// </summary>
		internal class CustomerInfo
		{
			/// <summary>
			/// Initializes a new instance of the <see cref="CustomerInfo" /> class.</summary>
			public CustomerInfo()
			{
				date = DateTime.Now;
				name = "";
				surname = "";
				id = "";
				number = 0;
				address = "";
				cell = "";
				idPicture = null;
			}
			/// <summary>Gets or sets the purchase date.</summary>
			/// <value>The date.</value>
			public DateTime date { set; get; }
			/// <summary>Gets or sets the customer name.</summary>
			/// <value>The name.</value>
			public string name { set; get; }
			/// <summary>Gets or sets the customer surname.</summary>
			/// <value>The surname.</value>
			public string surname { set; get; }
			/// <summary>Gets or sets the customer ID number.</summary>
			/// <value>The identifier.</value>
			public string id { set; get; }
			/// <summary>Gets or sets the customer number.</summary>
			/// <value>The number.</value>
			public int number { set; get; }
			/// <summary>Gets or sets the customer's address.</summary>
			/// <value>The address.</value>
			public string address { set; get; }
			/// <summary>Gets or sets the customer's cell number.</summary>
			/// <value>The cell.</value>
			public string cell { set; get; }
			/// <summary> Gets or sets the identifier picture. </summary>
			/// <value> The identifier picture. </value>
			public Image idPicture { set; get; }
		}

		/// <summary>
		/// Object to describe the item info during a purchase.
		/// </summary>
		internal class PurchasedItemInfo 
		{
			/// <summary>
			/// Initializes a new instance of the <see cref="PurchasedItemInfo" /> class.</summary>
			public PurchasedItemInfo() 
			{
				name = "";
				quantity = Constants.DECIMAL_ZERO;
				unitPrice = Constants.DECIMAL_ZERO;
				totalPrice = Constants.DECIMAL_ZERO;
				type = "";
			}

			/// <summary>Gets or sets the item name.</summary>
			/// <value>The name.</value>
			public string name { set; get; }
			
			/// <summary>Gets or sets the item quantity.</summary>
			/// <value>The quantity.</value>
			public decimal quantity { set; get; }
			
			/// <summary>Gets or sets the item's unit price.</summary>
			/// <value>The unit price.</value>
			public decimal unitPrice { set; get; }
			
			/// <summary>Gets or sets the item's total price.</summary>
			/// <value>The total price.</value>
			public decimal totalPrice { set; get; }
			
			/// <summary>Gets or sets the item type. Item type can be Ferrous or Non-Ferrous.</summary>
			/// <value>The type.</value>
			public string type { set; get; }
		}
	}
}
