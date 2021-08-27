
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
			//XFont font = new XFont("Arial", 20);

			//graphics.DrawString("First line of text", font, XBrushes.Black, new XRect(0, 0, page.Width, page.Height),
			//XStringFormats.Center);

			//graphics.DrawString("Third line", font, XBrushes.Red, new XPoint(100, 300));

			document.Save(basePath + @"Test.pdf");
		}

		private void insertHeader(XGraphics graphic) 
		{
			XImage letterHeadImage = XImage.FromFile(letterHeadPath);

			double top = 30;
			double left = 30;
			double height = 140;
			double width = 520;
			graphic.DrawImage(letterHeadImage, top, left, width, height);
		}
		
	}
}
