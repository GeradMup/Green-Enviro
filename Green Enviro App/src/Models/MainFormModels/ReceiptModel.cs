using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Printing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Green_Enviro_App.src.DataAccess;

namespace Green_Enviro_App
{

	/// <summary>
	/// Class to handle all the business logic relating to the receipt page.
	/// </summary>
	class ReceiptModel
	{
		FileHandles fileHandles;
		CSVHandles csvHandles;
		DataTable receiptTable;

		public const string RECEIPT_ITEM_NAME_COL = "Name";
		public const string RECEIPT_QUANTITY_COL = "kg";
		public const string RECEIPT_PRICE_COL = "Price";
		public const string RECEIPT_AMOUNT_COL = "Amount";
		public const string RECEIPT_ITEM_TYPE_COL = "Type";
		readonly string PURCHASES_FILE_PATH;
		readonly string SALES_FILE_PATH;
		string latestTransaction = "";      //Keeps track of the most recent transaction done. Either Purchase or casual sale.
		Customer latestCustomer;
		Image companyLogoImage;
		CompanyInfo company;
		string latestReceiptContent;
		int latestReceiptLines;

		public static readonly List<string> TRANSACTIONS = new List<string>() { "PURCHASE", "CASUAL SALE", "FORMAL SALE" };
		/// <summary>Initializes a new instance of the <see cref="ReceiptModel" /> class.</summary>
		/// <param name="fh">Object of the file handles class.</param>
		/// <param name="csvh">Object of the CSVHandles class.</param>
		public ReceiptModel(FileHandles fh, CSVHandles csvh)
		{
			fileHandles = fh;
			csvHandles = csvh;
			PURCHASES_FILE_PATH = fileHandles.pathToLogs(FileHandles.LogType.Purchases);
			SALES_FILE_PATH = fileHandles.pathToLogs(FileHandles.LogType.Sales);
			companyLogoImage = getCompanyLogo();
			company = getCompanyInfo();
		}

		#region COMPANY INFO		

		/// <summary>
		/// Gets the company information.
		/// </summary>
		/// <returns>An object with all the company info</returns>
		public CompanyInfo getCompanyInfo()
		{
			CompanyInfo companyInfo;

			using (DataEntities context = new DataEntities())
			{
				companyInfo = context.CompanyInfoes.First();
			}
			return companyInfo;
		}

		#endregion COMPANY INFO [ END ]

		#region ITEMS
		/// <summary>
		/// Gets all the items that the company buys.
		/// </summary>
		/// <returns>A list of strings representing the item names.</returns>
		public List<string> getItems()
		{
			List<string> items;
			using (DataEntities context = new DataEntities())
			{
				items = context.Items
					.OrderBy(_item => _item.Id)
					.Select(_item => _item.Name)
					.ToList();
			}
			return items;
		}

		/// <summary>
		/// Gets the item's price given its name.
		/// </summary>
		/// <returns>A decimal value represneting the price.</returns>
		public decimal getPrice(string name)
		{
			decimal price;
			using (DataEntities context = new DataEntities())
			{
				price = context.Items.FirstOrDefault(_item => _item.Name == name).Price;
			}
			return price;
		}

		/// <summary>
		/// Gets the dealer price give the dealer price.
		/// </summary>
		/// <param name="name">The name.</param>
		/// <returns>A decimal value representing the dealer price.</returns>
		public decimal getDealerPrice(string name)
		{
			decimal dealerPrice;
			using (DataEntities context = new DataEntities())
			{
				dealerPrice = context.Items.FirstOrDefault(_item => _item.Name == name).DealerPrice;
			}
			return dealerPrice;
		}

		#endregion ITEMS [END]

		#region FLOAT
		/// <summary>
		/// Gets the float.
		/// </summary>
		/// <returns>A decimal value representing the float.</returns>
		public decimal getFloat()
		{
			decimal floatVal;
			using (DataEntities context = new DataEntities())
			{
				floatVal = context.Floats.First().FloatValue;
			}
			return floatVal;
		}

		/// <summary>
		/// Adds the float.
		/// </summary>
		/// <param name="value">The value.</param>
		public void editFloat(decimal value)
		{
			using (DataEntities context = new DataEntities())
			{
				Float savedFloat = context.Floats.First();
				savedFloat.FloatValue += value;
				context.SaveChanges();
			}
		}


		/// <summary>
		/// Indicates the current state of the float level.
		/// </summary>
		/// <param name="floatValue">The float value.</param>
		/// <returns>An object indicating the current state of the float level.</returns>
		public FloatLevel floatLevel(decimal floatValue)
		{
			decimal goodLevel = 5000;
			decimal runningOutLevel = 3000;

			if (floatValue > goodLevel) { return FloatLevel.StillGood; }
			if ((floatValue < goodLevel) && (floatValue > runningOutLevel)) { return FloatLevel.RunningOut; }
			else { return FloatLevel.VeryLow; }
		}

		/// <summary>
		/// Enum Values to describe the state of the float level
		/// </summary>
		public enum FloatLevel
		{
			StillGood,
			RunningOut,
			VeryLow
		}
		#endregion FLOAT [END]

		#region CUSTOMERS	
		/// <summary>
		/// Gets the customer numbers.
		/// </summary>
		/// <returns></returns>
		public List<int> customerNumbers()
		{
			List<int> customerNames;
			using (DataEntities context = new DataEntities())
			{
				customerNames = context.Customers
								.OrderBy(_customer => _customer.CustomerNumber)
								.Select(_customer => _customer.CustomerNumber)
								.ToList();
			}
			return customerNames;
		}

		/// <summary>
		/// Gets the customer information given the customer number.
		/// </summary>
		/// <param name="customerNum">The customer number.</param>
		/// <returns></returns>
		public Customer getCustomer(int customerNum)
		{
			Customer customer;
			using (DataEntities context = new DataEntities())
			{
				customer = context.Customers.FirstOrDefault(_customer => _customer.CustomerNumber == customerNum);
			}
			return customer;
		}

		/// <summary>
		/// Gets the customer's ID picture.
		/// </summary>
		/// <param name="imageBytes">The image bytes.</param>
		/// <returns></returns>
		public Image getIdPicture(byte[] imageBytes)
		{
			int zeroSize = 0;
			if (imageBytes.Length == zeroSize) return null;

			return GenericModels.byteArrayToImage(imageBytes);

		}
		#endregion CUSTOMERS [END]

		#region RECEIPT GRID		

		/// <summary>
		/// Gets the receipt grid.
		/// </summary>
		/// <returns>A DataTable to be used for the receipt.</returns>
		public DataTable receiptGrid()
		{
			receiptTable = new DataTable();

			DataColumn itemNameCol = new DataColumn
			{
				ColumnName = RECEIPT_ITEM_NAME_COL,
				Caption = RECEIPT_ITEM_NAME_COL
			};

			DataColumn quantityCol = new DataColumn
			{
				ColumnName = RECEIPT_QUANTITY_COL,
				Caption = RECEIPT_QUANTITY_COL
			};

			DataColumn priceCol = new DataColumn
			{
				ColumnName = RECEIPT_PRICE_COL,
				Caption = RECEIPT_PRICE_COL
			};

			DataColumn amountCol = new DataColumn
			{
				ColumnName = RECEIPT_AMOUNT_COL,
				Caption = RECEIPT_AMOUNT_COL
			};

			DataColumn typeCol = new DataColumn
			{
				ColumnName = RECEIPT_ITEM_TYPE_COL,
				Caption = RECEIPT_ITEM_TYPE_COL
			};

			//receiptTable.Columns.Add(itemNumberCol);
			receiptTable.Columns.Add(itemNameCol);
			receiptTable.Columns.Add(quantityCol);
			receiptTable.Columns.Add(priceCol);
			receiptTable.Columns.Add(amountCol);
			receiptTable.Columns.Add(typeCol);

			return receiptTable;
		}

		/// <summary>
		/// Adds an item to the list items to be purchased
		/// </summary>
		/// <param name="item">The item.</param>
		/// <returns></returns>
		public void addItem(PurchaseItem item)
		{
			string itemType;

			using (DataEntities context = new DataEntities())
			{
				itemType = context.Items
							.FirstOrDefault(_item => _item.Name == item.Name)
							.Type;
			}
			string decimalFormat = "0.00";
			DataRow newRow = receiptTable.NewRow();
			newRow[0] = item.Name;
			newRow[1] = item.Quantity.ToString(decimalFormat);
			newRow[2] = item.Price.ToString(decimalFormat);
			newRow[3] = (item.Price * item.Quantity).ToString(decimalFormat);
			newRow[4] = itemType;

			receiptTable.Rows.Add(newRow);
		}

		/// <summary>
		/// Gets all items to be purchased.
		/// </summary>
		/// <returns></returns>
		public DataTable getAllItems()
		{
			//Return a copy of the receiptTable because the original one will get modified by DGVOps when adding the totals.
			return receiptTable.Copy();
		}

		/// <summary>
		/// Gets the total amount for the all the items on the receipt.
		/// </summary>
		/// <returns>A float representing the total amount.</returns>
		public float totalAmount()
		{
			return receiptTable.AsEnumerable().Sum(row => float.Parse(row.Field<string>(RECEIPT_AMOUNT_COL)));
		}

		/// <summary>
		/// Gets the total quantity for all the items on the receipt page.
		/// </summary>
		/// <returns>A Float value representing the total quantity.</returns>
		public float totalQuantity()
		{
			return receiptTable.AsEnumerable().Sum(row => float.Parse(row.Field<string>(RECEIPT_QUANTITY_COL)));
		}

		/// <summary>
		/// Deletes an item from the list of items to be purchased.
		/// </summary>
		/// <param name="itemName">Name of the item.</param>
		public void deleteItem(string itemName)
		{
			receiptTable.AcceptChanges();
			foreach (DataRow entry in receiptTable.Rows)
			{
				if (entry[RECEIPT_ITEM_NAME_COL].ToString() == itemName) { entry.Delete(); }
			}
			receiptTable.AcceptChanges();
		}

		/// <summary>
		/// Checks if there are any items availble for a purchase or a casual sale.
		/// </summary>
		/// <returns></returns>
		public bool itemsAvailable()
		{
			int zeroSize = 0;
			return (receiptTable.Rows.Count == zeroSize) ? false : true;
		}

		/// <summary>
		/// Completes the purchase.
		/// </summary>
		public void completePurchase(Customer customer, decimal remainingFloat)
		{
			latestCustomer = new Customer(customer);
			//First check if we have enough float for the purchase.
			decimal costOfPurchase = totalCostOfPurchase();
			if (remainingFloat < costOfPurchase) { throw new InsufficientCashFloatException(remainingFloat, costOfPurchase); }

			List<string> entries = new List<string>();
			string entryString;
			DateTime date = DateTime.Now;
			foreach (DataRow entry in receiptTable.Rows)
			{
				entryString = formatPurchaseRow(customer, entry, date);
				entries.Add(entryString);
			}

			try
			{
				csvHandles.addToCSV(PURCHASES_FILE_PATH, entries);
				//receiptTable.Clear();
				costOfPurchase *= -1;
				editFloat(costOfPurchase);
				latestTransaction = TRANSACTIONS[0];    //Purchase
				setupSlip();
				printReceipt(latestReceiptContent, latestReceiptLines);
				receiptTable.Clear();
			}
			catch (Exception ex)
			{
				throw new Exception(ex.Message);
			}
		}

		/// <summary>
		/// Records a casual sale.
		/// </summary>
		/// <exception cref="System.Exception"></exception>
		public void completeCasualSale()
		{
			string date = DateTime.Now.ToString(Constants.DATE_TIME_FORMAT);
			string company = "CASUAL SALE";
			List<string> saleItems = new List<string>();
			string saleRow;
			decimal totalSaleAmount = 0;
			foreach (DataRow entry in receiptTable.Rows)
			{
				saleRow = date + ","
						+ company + ","
						+ entry[RECEIPT_QUANTITY_COL].ToString() + ","
						+ entry[RECEIPT_AMOUNT_COL].ToString() + ","
						+ entry[RECEIPT_ITEM_TYPE_COL].ToString();

				saleItems.Add(saleRow);
				totalSaleAmount += decimal.Parse(entry[RECEIPT_AMOUNT_COL].ToString());
			}

			try
			{
				csvHandles.addToCSV(SALES_FILE_PATH, saleItems);
				editFloat(totalSaleAmount);
				//receiptTable.Clear();
				latestTransaction = TRANSACTIONS[1];    //Casual sale
				setupSlip();
				printReceipt(latestReceiptContent, latestReceiptLines);
				receiptTable.Clear();
			}
			catch (Exception ex)
			{
				throw new Exception(ex.Message);
			}
		}

		/// <summary>
		/// Calculates the total cost of purchase.
		/// </summary>
		/// <returns></returns>
		private decimal totalCostOfPurchase()
		{
			decimal totalCost = 0;
			foreach (DataRow entry in receiptTable.Rows)
			{
				totalCost += decimal.Parse(entry[RECEIPT_AMOUNT_COL].ToString());
			}
			return totalCost;
		}

		/// <summary>
		/// Formats an entry row for insertion into the purchases csv file.
		/// </summary>
		/// <param name="customer"></param>
		/// <param name="row">The row.</param>
		/// <param name="date"></param>
		/// <returns>A formated string ready for insertion.</returns>
		private string formatPurchaseRow(Customer customer, DataRow row, DateTime date)
		{
			string dateString = date.ToString(Constants.DATE_TIME_FORMAT);
			string customerName = customer.Name;
			string customerSurname = customer.Surname;
			string Id = customer.ID;
			string customerNumber = customer.CustomerNumber.ToString();
			string itemName = row[RECEIPT_ITEM_NAME_COL].ToString();
			string quantity = row[RECEIPT_QUANTITY_COL].ToString();
			string price = row[RECEIPT_PRICE_COL].ToString();
			string amount = row[RECEIPT_AMOUNT_COL].ToString();
			string itemType = row[RECEIPT_ITEM_TYPE_COL].ToString();

			string formattedRow = dateString + ","
								 + customerName + ","
								 + customerSurname + ","
								 + Id + ","
								 + customerNumber + ","
								 + itemName + ","
								 + quantity + ","
								 + price + ","
								 + amount + ","
								 + itemType;

			return formattedRow;
		}

		/// <summary>
		/// Class to describe the fields for purchasing
		/// </summary>
		internal class PurchaseItem
		{
			public PurchaseItem() { }
			/// <summary>
			/// Gets or sets the name.
			/// </summary>
			/// <value>
			/// The name.
			/// </value>
			public string Name { get; set; }

			/// <summary>
			/// Gets or sets the quantity.
			/// </summary>
			/// <value>
			/// The quantity.
			/// </value>
			public decimal Quantity { get; set; }

			/// <summary>
			/// Gets or sets the price.
			/// </summary>
			/// <value>
			/// The price.
			/// </value>
			public decimal Price { get; set; }

		}
		#endregion RECEIPT GRID [ END ]

		#region RECEIPT SLIP

		/// <summary>
		/// Gets the type of the transaction that was previously done.
		/// </summary>
		/// <returns>A string name of the latest transaction type.</returns>
		public string latestTransactionType()
		{
			return latestTransaction;
		}

		/// <summary>
		/// Gets the details of the most recent customer processed.
		/// </summary>
		/// <returns></returns>
		public Customer latestCustomerDetails()
		{
			return latestCustomer;
		}

		/// <summary>
		/// Resets the latest transaction type.
		/// </summary>
		public void resetLatestTransaction()
		{
			latestTransaction = "";
		}

		/// <summary>
		/// Gets the company logo.
		/// </summary>
		/// <returns>An Image of the company logo.</returns>
		private Image getCompanyLogo()
		{
			byte[] imageBytes;
			using (DataEntities context = new DataEntities()) 
			{
				imageBytes = context.CompanyInfoes.First().Logo;
			}
			return GenericModels.byteArrayToImage(imageBytes);
		}

		/// <summary>
		/// Setups the slip for printing.
		/// </summary>
		private void setupSlip()
		{
			string _receipt_content = "";
			foreach (DataRow item in receiptTable.Rows)
			{
				_receipt_content += string.Format("{0,-11}", " " + item[ReceiptModel.RECEIPT_ITEM_NAME_COL].ToString());
				_receipt_content += string.Format("{0,-5}", formatValue(item[ReceiptModel.RECEIPT_QUANTITY_COL].ToString()));
				_receipt_content += string.Format("{0,-7}", formatValue(item[ReceiptModel.RECEIPT_PRICE_COL].ToString()));
				_receipt_content += string.Format("{0,-6}", formatValue(item[ReceiptModel.RECEIPT_AMOUNT_COL].ToString()));
				_receipt_content += "\n";
			}

			float totalTransactionAmount = totalAmount();
			float totalTransactionQuantity = totalQuantity();
			string typeOfTransaction = latestTransactionType();

			string transaction_time = DateTime.Now.ToString("HH:mm:ss");
			string _date = " Date: " + DateTime.Now.ToString("dd MMMM yyyy       ") + "\n Time: " + transaction_time + "\n";
			string _customer_details = String.Format(" Customer: {0}, {1}\n ID: {2}\n Cell: {3}\n", latestCustomer.Name, latestCustomer.CustomerNumber, latestCustomer.ID, latestCustomer.Cell);

			latestReceiptContent = string.Empty;
			latestReceiptContent += " \n";
			latestReceiptContent += " ----------------------------\n";
			latestReceiptContent += String.Format(" {0}, {1},\n", company.StreetAddress, company.Town);
			latestReceiptContent += String.Format(" {0}, {1}\n", company.City, company.ZipCode);
			latestReceiptContent += String.Format(" Phone: {0}\n", company.PhoneNum);
			latestReceiptContent += String.Format(" Tax Number: {0}\n", company.TaxNum);
			latestReceiptContent += String.Format(" Reg Number: {0}\n", company.RegNum);
			latestReceiptContent += " ----------------------------\n";
			latestReceiptContent += _date;
			latestReceiptContent += _customer_details;
			latestReceiptContent += " ----------------------------\n ";
			latestReceiptContent += string.Format("{0,-9}", "ITEMS");
			latestReceiptContent += string.Format("{0,-6}", "KGs");
			latestReceiptContent += string.Format("{0,-8}", "P/Kg");
			latestReceiptContent += string.Format("{0,-5}", "R");
			latestReceiptContent += "\n";
			latestReceiptContent += " ----------------------------\n";
			latestReceiptContent += _receipt_content;
			latestReceiptContent += "\n";
			latestReceiptContent += " Total:    " + totalTransactionQuantity + " Kgs";
			latestReceiptContent += "\n";
			latestReceiptContent += " Total:    R " + totalTransactionAmount.ToString();
			latestReceiptContent += "\n";
			latestReceiptContent += " ----------------------------\n";
			latestReceiptContent += " * * * " + typeOfTransaction + " * * * ";
			latestReceiptContent += "\n";
			latestReceiptContent += " * * * THANK YOU! * * * ";

			//receiptDataGrid.Visible = false;
			latestReceiptLines = Regex.Matches(latestReceiptContent, "\n").Count;
		}

		/// <summary>
		/// Removes trailing zeros from values passed in
		/// </summary>
		/// <param name="value"></param>
		/// <returns>A string number without trailing zeroes</returns>
		private string formatValue(string value)
		{
			decimal decimalValue = decimal.Parse(value);
			decimalValue = decimalValue / 1.000000000000000000000000000000000m;
			return decimalValue.ToString();
		}

		/// <summary>
		/// Prints the receipt.
		/// </summary>
		public void printReceipt(string receiptData, int receiptTotalLines)
		{
			int _width_offset = 35;
			//int _content_height = receiptBox.Lines.Count() * 20;

			int _content_height = receiptTotalLines * 20;
			int _header_height = 120;
			int receiptWidth = 346;
			PrintDocument _receipt_content = new PrintDocument();
			PrintDocument _receipt_header = new PrintDocument();

			_receipt_header.DefaultPageSettings.PaperSize = new PaperSize("Custom", receiptWidth - _width_offset, _header_height);
			_receipt_header.PrintPage += (sender, args) => printReceiptHeader(args);

			_receipt_content.DefaultPageSettings.PaperSize = new PaperSize("Custom", receiptWidth - _width_offset, _content_height);
			//_receipt_content.PrintPage += new PrintPageEventHandler(this.PrintDocument_PrintPage);
			_receipt_content.PrintPage += (sender, args) => printReceiptContent(receiptData, args);

			_receipt_header.PrinterSettings.PrinterName = "Microsoft Print to PDF";
			_receipt_content.PrinterSettings.PrinterName = "Microsoft Print to PDF";

			_receipt_header.Print();
			_receipt_content.Print();

		}

		/// <summary>
		/// Reprints the latest receipt.
		/// </summary>
		public void reprintReceipt() 
		{
			printReceipt(latestReceiptContent, latestReceiptLines); 
		}

		/// <summary>
		/// Prints the content of the receipt.
		/// </summary>
		/// <param name="receiptData">The receipt data.</param>
		/// <param name="e">The <see cref="PrintPageEventArgs"/> instance containing the event data.</param>
		private void printReceiptContent(string receiptData, PrintPageEventArgs e)
		{
			float _font_size = 9.1F;
			e.Graphics.DrawString(receiptData, new Font("Consolas", _font_size), Brushes.Black, -10, -5);
		}

		/// <summary>
		/// Prints the receipt header.
		/// </summary>
		/// <param name="logo">The Company Logo.</param>
		/// <param name="e">The <see cref="PrintPageEventArgs"/> instance containing the event data.</param>
		private void printReceiptHeader(PrintPageEventArgs e)
		{
			float _font_size = 15F;
			e.Graphics.DrawImage(companyLogoImage, 0, 0, 190, 80);
		}

		/// <summary>
		/// Resizes the logo image for the purpose of prriting it on the receipt.
		/// </summary>
		/// <param name="image">The image.</param>
		/// <param name="new_height">The new height.</param>
		/// <param name="new_width">The new width.</param>
		/// <returns></returns>
		public static Image ResizeLogoImage(Image image, int new_height, int new_width)
		{
			Bitmap new_image = new Bitmap(new_width, new_height);
			Graphics g = Graphics.FromImage((Image)new_image);
			g.InterpolationMode = InterpolationMode.High;
			g.DrawImage(image, 0, 0, new_width, new_height);
			return new_image;
		}

		#endregion RECEIPT SLIP [ END ]
	}

	/// <summary>
	/// Exception thrown when the total cost of a purchase exceeds the total float available.
	/// </summary>
	/// <seealso cref="System.Exception" />
	class InsufficientCashFloatException : Exception 
	{
		const string REMAINING_FLOAT = "Remaining float: R";
		const string COST_OF_PURCHASE = " is less than total cost of purchase: R";
		public InsufficientCashFloatException(decimal remainingFloat, decimal costOfPurchase) : 
			base(REMAINING_FLOAT + remainingFloat.ToString() + COST_OF_PURCHASE + costOfPurchase.ToString()) { }
	}
}

/*
 * 
 * CUSTOMER CONSTRUCTERS FOR THE CUSTOMER CLASS
public Customer() { }

public Customer(Customer customer)
{
	this.CustomerNumber = customer.CustomerNumber;
	this.ID = customer.ID;
	this.Name = customer.Name;
	this.Surname = customer.Surname;
	this.Cell = customer.Cell;
	this.Address = customer.Address;
}

*/