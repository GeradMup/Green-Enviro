
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using PdfSharp.Pdf;
using PdfSharp.Drawing;
using System.IO;
using System.Data;
using System.Windows.Forms;
using Green_Enviro_App.src.DataAccess;

namespace Green_Enviro_App
{
	class DeliveryNotesModel
	{
		double currentLine;
		const double nextSentenceOffset = 13;
		const double lineOffset = 4;
		const double tableDescriptionOfProductsPosition = 80;
		const double tableQuantityPosition = 420;
		const double regularFontSize = 10;
		const double startOfTextXPosition = 40;
		const string fontName = "Times New Roman";
		XFont regularFont = new XFont(fontName,regularFontSize);
		XFont regularFontBold = new XFont(fontName, regularFontSize, XFontStyle.Bold);
		XGraphics graphic;
		Products productsInfo;
		CSVHandles csvHandles;
		FileHandles fileHandles;

		const string GENERATING_DELIVERY_NOTE_EXCEPTION = "Unable to generate delivery note exception!";
		public DeliveryNotesModel(FileHandles fh) 
		{
			fileHandles = fh;
			System.Text.Encoding.RegisterProvider(System.Text.CodePagesEncodingProvider.Instance);
			productsInfo = new Products();
			
			csvHandles = new CSVHandles();
			setUpDeliveryNotes();
		}

		/// <summary>
		/// Creates the folder to save the delivery notes for the month if it does not already exist.
		/// </summary>
		private void setUpDeliveryNotes() 
		{
			string path = Constants.DELIVERY_NOTES_BASE_PATH + @"\" + Constants.CURRENT_MONTH_AND_YEAR + @"\";
			fileHandles.createFolder(path);
		}

		/// <summary>
		/// Inserts the copmany letter head on the delivery note.
		/// </summary>
		private void insertHeader() 
		{
			XImage letterHeadImage = XImage.FromFile(Constants.COMPANY_LETTERHEAD_PATH);

			double y_coordinate = 30;
			double x_coordinate = 30;
			double height = 140;
			double width = 520;
			graphic.DrawImage(letterHeadImage, x_coordinate, y_coordinate, width, height);

			string heading = "DELIVERY NOTE";
			string fontName = "Times New Roman";
			double fontSize = 25;
			XFont font = new XFont(fontName, fontSize, XFontStyle.Bold);

			y_coordinate = 195;
			x_coordinate = 187;
			graphic.DrawString(heading, font, XBrushes.Black, new XPoint(x_coordinate, y_coordinate));

			double start_x = 187;
			double y = 200;
			double end_x = 396;

			graphic.DrawLine(XPens.Black, new XPoint(start_x, y), new XPoint(end_x, y));
		}

		/// <summary>Inserts the information of the company to which the delivery is to be made.</summary>
		/// <param name="companyInfo">The company information.</param>
		private void insertCompanyInfo(Company companyInfo) 
		{
			double y_coordinate = 230;
			
			double x_offset = 30;
			string date = DateTime.Now.ToString("dd MMMM yyyy");
			insertKeyValueLine("Date :", date, ref y_coordinate, x_offset);

			x_offset = 53.5;
			insertKeyValueLine("Company :", companyInfo.Name, ref y_coordinate, x_offset);

			x_offset = 80;
			insertKeyValueLine("Contact Person :", companyInfo.ContactPerson, ref y_coordinate, x_offset);

			x_offset = 36;
			insertKeyValueLine("Email :", companyInfo.Email, ref y_coordinate, x_offset);

			x_offset = 91;
			insertKeyValueLine("Contact Numbers :", companyInfo.ContactNumbers, ref y_coordinate, x_offset);

			x_offset = 46;
			insertKeyValueLine("Address :", companyInfo.Address, ref y_coordinate, x_offset);

			drawHorizontalLine(LineColours.black);

		}

		/// <summary>Helper function for populating the delivery note strings.</summary>
		/// <param name="key">The key.</param>
		/// <param name="value">The value.</param>
		/// <param name="y_coordinate">The y coordinate.</param>
		/// <param name="xValue_offset">The x value offset.</param>
		private void insertKeyValueLine(string key, string value, ref double y_coordinate, double xValue_offset) 
		{
			
			graphic.DrawString(key, regularFontBold, XBrushes.Black, new XPoint(startOfTextXPosition, y_coordinate));
			graphic.DrawString(value, regularFont, XBrushes.Black, new XPoint(startOfTextXPosition + xValue_offset, y_coordinate));
			
			y_coordinate += nextSentenceOffset;
			currentLine = y_coordinate;
		}

		/// <summary>
		/// Inserts the table and its headers.
		/// </summary>
		private void insertTableAndHeaders() 
		{
			currentLine += (nextSentenceOffset * 1);

			drawHorizontalLine(LineColours.yellow);

			currentLine += nextSentenceOffset;
			drawHorizontalLine(LineColours.yellow);

			string tableHeader1 = "Description of Products";
			string tableHeader2 = "Net Quantity [Kg]";

			graphic.DrawString(tableHeader1, regularFontBold, XBrushes.Black, new XPoint(tableDescriptionOfProductsPosition, currentLine));
			graphic.DrawString(tableHeader2, regularFontBold, XBrushes.Black, new XPoint(tableQuantityPosition, currentLine));

		}

		/// <summary>
		/// Inserts the products to be delivered.
		/// </summary>
		private void insertProducts() 
		{
			foreach (Product product in productsInfo.products) 
			{
				currentLine += nextSentenceOffset;
				graphic.DrawString(product.name, regularFont, XBrushes.Black, new XPoint(tableDescriptionOfProductsPosition, currentLine));
				graphic.DrawString(product.quantity.ToString(), regularFont, XBrushes.Black, new XPoint(tableQuantityPosition, currentLine));
			}

			drawHorizontalLine(LineColours.yellow);

			currentLine += nextSentenceOffset;

			graphic.DrawString("Total", regularFontBold, XBrushes.Black, new XPoint(tableDescriptionOfProductsPosition, currentLine));
			graphic.DrawString(productsInfo.totalMass.ToString(), regularFontBold, XBrushes.Black, new XPoint(tableQuantityPosition, currentLine));
			drawHorizontalLine(LineColours.yellow);
			currentLine += nextSentenceOffset;
			drawHorizontalLine(LineColours.black);
		}

		/// <summary>Helper function for drawing the horizontal lines right across the page.</summary>
		/// <param name="lineColour">The line colour.</param>
		private void drawHorizontalLine(LineColours lineColour) 
		{
			double start_x = 40;
			double y = currentLine + lineOffset;
			double end_x = 550;

			switch (lineColour)
			{
				case LineColours.black:
					graphic.DrawLine(XPens.Black, new XPoint(start_x, y), new XPoint(end_x, y));
					break;
				case LineColours.yellow:
					graphic.DrawLine(XPens.Yellow, new XPoint(start_x, y), new XPoint(end_x, y));
					break;
				default:
					break;
			}
		}

		/// <summary>
		/// Inserts the disclaimer section of the delivery note.
		/// </summary>
		private void insertDisclaimer() 
		{
			string disclaimerLineOne = "Green Enviro SA Recycling hereby states that it is the lawful owner of the above listed goods and " +
										"has adhered to the second"; 
			string disclaimerLineTwo = "hand goods act by holding the goods for 7 days before dispatch. Green Enviro SA recycling will provide " +
										"proof of origin for any";
			string disclaimerLineThree = "burnt copper wire, which is classified as Braziery, along with a copy of our second hand goods license " +
										 "should it be required. ";

			currentLine += (nextSentenceOffset * 2);

			graphic.DrawString(disclaimerLineOne, regularFont, XBrushes.Black, new XPoint(startOfTextXPosition, currentLine));
			currentLine += nextSentenceOffset; 
			graphic.DrawString(disclaimerLineTwo, regularFont, XBrushes.Black, new XPoint(startOfTextXPosition, currentLine));
			currentLine += nextSentenceOffset; 
			graphic.DrawString(disclaimerLineThree, regularFont, XBrushes.Black, new XPoint(startOfTextXPosition, currentLine));
			currentLine += nextSentenceOffset;
			drawHorizontalLine(LineColours.black);
		}

		/// <summary>Inserts the information of the person delivering the goods.</summary>
		/// <param name="collectorInfo">The collector information.</param>
		private void insertColletorInfo(CollectorInformation collectorInfo) 
		{
			currentLine += (2* nextSentenceOffset);
			double xValue_offset = 63;
			insertKeyValueLine("Driver Name :", collectorInfo.name, ref currentLine, xValue_offset);
			xValue_offset = 63;
			insertKeyValueLine("Cell Number :", collectorInfo.cellNumber, ref currentLine, xValue_offset);
			xValue_offset = 91;
			insertKeyValueLine("Vehicle Regisration :", collectorInfo.vehicleRegistration, ref currentLine, xValue_offset);
			xValue_offset = 64;
			insertKeyValueLine("Vehicle Type :", collectorInfo.vehicleType, ref currentLine, xValue_offset);
			xValue_offset = 30;
			insertKeyValueLine("Time : ", DateTime.Now.ToString("HH : MM "), ref currentLine, xValue_offset);
		}

		/// <summary>
		/// Inserts the signature fields.
		/// </summary>
		private void insertSignatureFields()
		{
			currentLine += nextSentenceOffset * 2;
			double start_x = 40;
			double lengthOfSignatureLine = 160;
			double y = currentLine;
			double end_x = start_x + lengthOfSignatureLine;

			graphic.DrawLine(XPens.Black, new XPoint(start_x, y), new XPoint(end_x, y));

			start_x = 390;
			end_x = start_x + lengthOfSignatureLine;
			graphic.DrawLine(XPens.Black, new XPoint(start_x, y), new XPoint(end_x, y));
			
			currentLine += nextSentenceOffset;
			graphic.DrawString("Driver's Signature", regularFont, XBrushes.Black, new XPoint(startOfTextXPosition, currentLine));
			graphic.DrawString("Green Enviro Representative", regularFont, XBrushes.Black, new XPoint(start_x, currentLine));
		}

		/// <summary>This function fetches all the items from the Database and returns a List of strings with the names.</summary>
		/// <returns>A List of strings representing the item names.</returns>
		public List<string> getItemNames() 
		{
			string ITEMS = "ITEMS";
			DataTable items = csvHandles.getCSVContents(Constants.PATH_TO_DELIVERY_ITEMS);
			List<string> itemList = items.Rows.OfType<DataRow>().Select(dr => (string)dr[ITEMS]).ToList();
			return itemList;
		}

		/// <summary>Gets the company names.</summary>
		/// <returns>A List of strings representing the company names.</returns>
		public List<string> getCompanyNames() 
		{
			List<string> companyNames;
			using (DataEntities context = new DataEntities()) 
			{
				companyNames = context.Buyers.Select(column => column.Company).ToList();
			}
			return companyNames;
		}

		/// <summary>Adds the product to the list of products on the delivery note.</summary>
		/// <param name="productName">Name of the product.</param>
		/// <param name="mass">The mass of the product</param>
		/// <returns>A datable containig all the items that have been added.</returns>
		public DataTable addProduct(string productName, double mass) 
		{
			Product newProduct = new Product(productName, mass);
			productsInfo.products.Add(newProduct);
			productsInfo.totalMass = productsInfo.totalMass + mass;

			DataTable dataTable = new DataTable();
			string nameOfProduct = "Product Name";
			string quantity = "Quantity";
			dataTable.Columns.Add(nameOfProduct);
			dataTable.Columns.Add(quantity);
			DataRow newRow;
			foreach (Product product in productsInfo.products) 
			{
				newRow = dataTable.NewRow();
				newRow[nameOfProduct] = product.name;
				newRow[quantity] = product.quantity.ToString();
				dataTable.Rows.Add(newRow);
			}

			//Add an empty row between products and total quantities
			newRow = dataTable.NewRow();
			dataTable.Rows.Add(newRow);

			newRow = dataTable.NewRow();
			newRow[nameOfProduct] = "TOTALS";
			newRow[quantity] = productsInfo.totalMass;
			dataTable.Rows.Add(newRow);

			return dataTable;
		}

		/// <summary>Generates the delivery note after all the entries have been added.</summary>
		/// <param name="companyName">Name of the company name.</param>
		/// <param name="collectorInfo">The information about the person tansporting the delivery.</param>
		/// <returns>A string representing the path to the delivery note generated.</returns>
		/// <exception cref="System.Exception">If something goes wrong with the pdf generation or reading from the database.</exception>
		public string generateDeliveryNote(string companyName, CollectorInformation collectorInfo) 
		{
			string pathToDeliveryNote;
			try
			{
				// New document
				//DataTable companyData = database.select<Database.BuyersTableColumns>(Database.Tables.Buyers,
				//						Database.BuyersTableColumns.Company, companyName);

				//GenericModels.CompanyInfo companyInfo = dataTableToCompanyInfo(companyData);

				Company company;
				using (DataEntities context = new DataEntities()) 
				{
					company = context.Companies.Where(_company => _company.Name == companyName).FirstOrDefault<Company>();
				}

				PdfDocument document = new PdfDocument();
				PdfPage page = document.AddPage();
				graphic = XGraphics.FromPdfPage(page);

				insertHeader();
				insertCompanyInfo(company);
				insertTableAndHeaders();
				insertProducts();
				insertDisclaimer();
				insertColletorInfo(collectorInfo);
				insertSignatureFields();

				

				pathToDeliveryNote = generateSavePath(company.Name);
				document.Save(pathToDeliveryNote);
			}
			catch (Exception ex) 
			{
				throw new Exception(GENERATING_DELIVERY_NOTE_EXCEPTION, ex);
			}

			return pathToDeliveryNote;
		}

		/// <summary>Generates the path to save the new delivery note.</summary>
		/// <param name="companyName">Name of the company.</param>
		/// <returns>A string representing the path where the new delivery note should be saved.</returns>
		private string generateSavePath(string companyName) 
		{
			string basePath = Constants.DELIVERY_NOTES_BASE_PATH;
			string month = Constants.CURRENT_MONTH_AND_YEAR;
			string date = Constants.DATE;
			string fileName = companyName + " " + date;
			string fileExtension = Constants.PDF_EXTENSION;

			string filePath = GenericModels.generateSavePath(basePath,month,fileName,fileExtension);
			return filePath;
		}

		/// <summary>Gets the months for which delivery notes have been made.</summary>
		/// <returns>A string representing all the months for which delivery notes have been made.</returns>
		public List<string> getMonths() 
		{
			return fileHandles.getLogNames(FileHandles.LogType.DeliveryNotes);
		}

		/// <summary>Gets the names of all the delivery notes that were generated in the given month.</summary>
		/// <param name="monthAndYeah">The month and yeah.</param>
		/// <returns>A list of strings representing the names of all the delivery notes.</returns>
		public List<string> getDeliveryNotes(string monthAndYeah) 
		{
			string path = Constants.DELIVERY_NOTES_BASE_PATH + @"\" + monthAndYeah;
			return fileHandles.getfilesInFolder(path);
		}

		/// <summary>Gets the path to the currently selected delivery note.</summary>
		/// <param name="selectedDeliveryNote">The selected delivery note.</param>
		/// <param name="selectedMonthAndYear">The selected month and year.</param>
		/// <returns>A string representing the path to the currently selected delivery note.</returns>
		public string getPathToDeliveryNote(string selectedDeliveryNote, string selectedMonthAndYear) 
		{
			string basePath = Constants.DELIVERY_NOTES_BASE_PATH;
			string path = basePath + @"\" + selectedMonthAndYear + @"\" + selectedDeliveryNote;
			return path;
		}
		
		/// <summary>
		/// Describes the products to be Delivered.
		/// </summary>
		internal class Products
		{
			public Products() 
			{
				products = new List<Product>();
			}
			/// <summary>Gets or sets the total quantity of all the products to be Delivered.</summary>
			/// <value>The total mass of all products.</value>
			public double totalMass { get; set; }
			/// <summary>Gets or sets the names and weights of all the products to be delivered.</summary>
			/// <value>The products.</value>
			public List<Product> products { get; set; }
		}


		/// <summary>
		/// Describes a single product that goes on the Delivery note.
		/// </summary>
		internal class Product 
		{
			public Product(string _name, double _quantity) 
			{
				name = _name;
				quantity = _quantity;
			}
			public string name { get; set; }
			public double quantity { get; set; }
		}

		/// <summary>
		/// Describes the person delivering the goods.</summary>
		internal class CollectorInformation
		{
			public CollectorInformation(string _name = "Unknown", string _cellNumber = "0000000000", string _vehicleReg = "000000",
										string _vehicleType = "Unknown")
			{
				this.name = _name;
				this.cellNumber = _cellNumber;
				this.vehicleRegistration = _vehicleReg;
				this.vehicleType = _vehicleType;
			}
			public string name { set; get; }
			public string cellNumber { set; get; }
			public string vehicleRegistration { set; get; }
			public string vehicleType { set; get; }
		}

		/// <summary>
		/// Describes all the colours for the lines to be drawn on the Delivery Note.</summary>
		private enum LineColours
		{
			black,
			yellow
		};
	}
}
