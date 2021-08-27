
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

		public DeliveryNote() 
		{
			System.Text.Encoding.RegisterProvider(System.Text.CodePagesEncodingProvider.Instance);

			// New document
			PdfDocument document = new PdfDocument();
			PdfPage page = document.AddPage();
			XGraphics graphics = XGraphics.FromPdfPage(page);

			insertHeader(graphics);
			insertCompanyInfo(graphics, new List<string>{""});
			//XFont font = new XFont("Arial", 20);

			//graphics.DrawString("First line of text", font, XBrushes.Black, new XRect(0, 0, page.Width, page.Height),
			//XStringFormats.Center);

			//graphics.DrawString("Third line", font, XBrushes.Red, new XPoint(100, 300));

			document.Save(basePath + @"Test.pdf");
		}

		private void insertHeader(XGraphics graphic) 
		{
			XImage letterHeadImage = XImage.FromFile(letterHeadPath);

			double y_coordinate = 30;
			double x_coordinate = 30;
			double height = 140;
			double width = 520;
			graphic.DrawImage(letterHeadImage, x_coordinate, y_coordinate, width, height);

			string heading = "DELIVERY NOTE";
			string fontName = "Times New Roman";
			XFont font = new XFont(fontName, 25, XFontStyle.Bold);

			y_coordinate = 195;
			x_coordinate = 187;
			graphic.DrawString(heading, font, XBrushes.Black, new XPoint(x_coordinate, y_coordinate));

			double start_x = 187;
			double start_y = 200;
			double end_x = 396;
			double end_y = 200;

			graphic.DrawLine(XPens.Black, new XPoint(start_x, start_y), new XPoint(end_x, end_y));
		}

		private void insertCompanyInfo(XGraphics graphic, List<string> companyInfo) 
		{
			double y_coordinate = 250;
			double x_coordinate = 40;
			
			double x_offset = 30;
			string date = DateTime.Now.ToString("dd MMMM yyyy");
			addLine(graphic,"Date :", date, ref y_coordinate, ref x_coordinate, x_offset);

			x_offset = 53.5;
			addLine(graphic,"Company :", "Date ", ref y_coordinate, ref x_coordinate, x_offset);

			x_offset = 80;
			addLine(graphic, "Contact Person :", "Date ", ref y_coordinate, ref x_coordinate, x_offset);

			x_offset = 36;
			addLine(graphic, "Email :", "Date ", ref y_coordinate, ref x_coordinate, x_offset);

			x_offset = 91;
			addLine(graphic, "Contact Numbers :", "Date ", ref y_coordinate, ref x_coordinate, x_offset);

			x_offset = 46;
			addLine(graphic, "Address :", "Date ", ref y_coordinate, ref x_coordinate, x_offset);

			double start_x = 40;
			double start_y = 340;
			double end_x = 550;
			double end_y = 340;

			graphic.DrawLine(XPens.Black, new XPoint(start_x, start_y), new XPoint(end_x, end_y));

		}

		private void addLine(XGraphics graphic, string key, string value, ref double y_coordinate, ref double x_coordinate, double x_offset) 
		{
			double nextSentenceOffset = 15;
			double fontSize = 11;
			string fontName = "Times New Roman";

			XFont font = new XFont(fontName, fontSize, XFontStyle.Bold);

			graphic.DrawString(key, font, XBrushes.Black, new XPoint(x_coordinate, y_coordinate));
			font = new XFont(fontName, fontSize);
			graphic.DrawString(value, font, XBrushes.Black, new XPoint(x_coordinate + x_offset, y_coordinate));
			
			y_coordinate += nextSentenceOffset;
		}
		
	}
}
