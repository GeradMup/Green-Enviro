
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using PdfSharp.Pdf;
using PdfSharp.Drawing;
using System.IO;

namespace Green_Enviro_App
{
	class DeliveryNote
	{

		static string path = Path.GetDirectoryName(Path.GetDirectoryName(Directory.GetCurrentDirectory()));
		string basePath = path + @"\resources\Logs\Delivery Notes\";
		string letterHeadPath = path + @"\resources\Green Enviro Destruction Certificate Logo Better.png";
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

		/// <summary>Describes the products to be Delivered.</summary>
		public struct Products
		{
			/// <summary>Gets or sets the total quantity of all the products to be Delivered.</summary>
			/// <value>The total quantity.</value>
			public double totalQuantity { get; set; }
			/// <summary>Gets or sets the names and weights of all the products to be delivered.</summary>
			/// <value>The products.</value>
			public List<KeyValuePair<String, double>> products { get; set; }
		}

		private enum LineColours
		{
			black,
			yellow
		};

		public DeliveryNote() 
		{
			System.Text.Encoding.RegisterProvider(System.Text.CodePagesEncodingProvider.Instance);

			// New document
			PdfDocument document = new PdfDocument();
			PdfPage page = document.AddPage();
			graphic = XGraphics.FromPdfPage(page);

			insertHeader();
			insertCompanyInfo(new List<string>{"Green Envrio SA Recycling", "Nicholas Mupfumisi", "recycle@greenevirosa.co.za", "011 899 1126", "5 Shaft Road, Knights, Germiston,1401"});
			insertTableAndHeaders();

			Products productsInfo = new Products();
			List<KeyValuePair<String, Double>> prodsAndQuantities = new List<KeyValuePair<string, double>>();

			KeyValuePair<String, Double> product1 = new KeyValuePair<string, double>("Cu Mix", 4.4);
			KeyValuePair<String, Double> product2 = new KeyValuePair<string, double>("Cu Brazery", 12);
			KeyValuePair<String, Double> product3 = new KeyValuePair<string, double>("Cu Tin", 15);
			KeyValuePair<String, Double> product4 = new KeyValuePair<string, double>("A Grade", 50);
			KeyValuePair<String, Double> product5 = new KeyValuePair<string, double>("Something Long Here Okay", 23);
			KeyValuePair<String, Double> product6 = new KeyValuePair<string, double>("One more thing", 17);
			
			double totalQuantity = 100.0;

			prodsAndQuantities.Add(product1);
			prodsAndQuantities.Add(product2);
			prodsAndQuantities.Add(product3);
			prodsAndQuantities.Add(product4);
			prodsAndQuantities.Add(product5);
			prodsAndQuantities.Add(product6);
			prodsAndQuantities.Add(product1);
			prodsAndQuantities.Add(product2);
			prodsAndQuantities.Add(product3);
			prodsAndQuantities.Add(product4);
			prodsAndQuantities.Add(product5);
			prodsAndQuantities.Add(product6);
			prodsAndQuantities.Add(product1);
			prodsAndQuantities.Add(product2);
			prodsAndQuantities.Add(product3);

			productsInfo.totalQuantity = totalQuantity;
			productsInfo.products = prodsAndQuantities;

			insertProducts(productsInfo);
			insertDisclaimer();
			insertColletorInfo(new CollectorInformation());
			insertSignatureFields();

			document.Save(basePath + @"Test.pdf");
		}

		private void insertHeader() 
		{
			XImage letterHeadImage = XImage.FromFile(letterHeadPath);

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

		private void insertCompanyInfo(List<string> companyInfo) 
		{
			double y_coordinate = 230;
			
			double x_offset = 30;
			string date = DateTime.Now.ToString("dd MMMM yyyy");
			insertKeyValueLine("Date :", date, ref y_coordinate, x_offset);

			x_offset = 53.5;
			insertKeyValueLine("Company :", companyInfo[0], ref y_coordinate, x_offset);

			x_offset = 80;
			insertKeyValueLine("Contact Person :", companyInfo[1], ref y_coordinate, x_offset);

			x_offset = 36;
			insertKeyValueLine("Email :", companyInfo[2], ref y_coordinate, x_offset);

			x_offset = 91;
			insertKeyValueLine("Contact Numbers :", companyInfo[3], ref y_coordinate, x_offset);

			x_offset = 46;
			insertKeyValueLine("Address :", companyInfo[4], ref y_coordinate, x_offset);

			drawHorizontalLine(LineColours.black);

		}
		
		private void insertKeyValueLine(string key, string value, ref double y_coordinate, double xValue_offset) 
		{
			
			graphic.DrawString(key, regularFontBold, XBrushes.Black, new XPoint(startOfTextXPosition, y_coordinate));
			graphic.DrawString(value, regularFont, XBrushes.Black, new XPoint(startOfTextXPosition + xValue_offset, y_coordinate));
			
			y_coordinate += nextSentenceOffset;
			currentLine = y_coordinate;
		}

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

		private void insertProducts(Products prod) 
		{
			foreach (KeyValuePair<String, double> product in prod.products) 
			{
				currentLine += nextSentenceOffset;
				graphic.DrawString(product.Key, regularFont, XBrushes.Black, new XPoint(tableDescriptionOfProductsPosition, currentLine));
				graphic.DrawString(product.Value.ToString(), regularFont, XBrushes.Black, new XPoint(tableQuantityPosition, currentLine));
			}

			drawHorizontalLine(LineColours.yellow);

			currentLine += nextSentenceOffset;

			graphic.DrawString("Total", regularFontBold, XBrushes.Black, new XPoint(tableDescriptionOfProductsPosition, currentLine));
			graphic.DrawString(prod.totalQuantity.ToString(), regularFontBold, XBrushes.Black, new XPoint(tableQuantityPosition, currentLine));
			drawHorizontalLine(LineColours.yellow);
			currentLine += nextSentenceOffset;
			drawHorizontalLine(LineColours.black);
		}

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

		public class CollectorInformation 
		{

			public CollectorInformation(string _name = "Unknown", string _cellNumber = "0000000000", string _vehicleReg = "WAS902GP",
										string _vehicleType = "Bin Truck") 
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
	}
}
