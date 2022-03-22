using PdfSharp.Drawing;
using PdfSharp.Pdf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Green_Enviro_App
{
	/// <summary>
	/// Class to handle all the common functionalities regarding destruction certificates.
	/// </summary>
	class PoliceRegister
	{

		FileHandles fileHandles;
		XGraphics graphic;
		public PoliceRegister(FileHandles fh) 
		{
			fileHandles = fh;
			System.Text.Encoding.RegisterProvider(System.Text.CodePagesEncodingProvider.Instance);
			setupPoliceRegisters();
			generatePoliceRegister();
		}

		/// <summary>
		/// Setups folder to save police registers after printing them.
		/// </summary>
		private void setupPoliceRegisters() 
		{
			string path = Constants.POLICE_REGISTERS_PATH + @"\" + Constants.CURRENT_MONTH_AND_YEAR + @"\";
			fileHandles.createFolder(path);
		}

		public void generatePoliceRegister() 
		{
			PdfDocument document = new PdfDocument();
			PdfPage page = document.AddPage();
			page.Orientation = PdfSharp.PageOrientation.Landscape;
			graphic = XGraphics.FromPdfPage(page);

			insertHeader();

			try
			{
				string pathToPoliceRegister = savePath();
				document.Save(pathToPoliceRegister);
			}
			catch (Exception ex) 
			{
				throw new Exception(ex.Message);
			}
		}

		private string savePath() 
		{
			string basePath = Constants.POLICE_REGISTERS_PATH;
			string month = Constants.CURRENT_MONTH_AND_YEAR;
			string date = Constants.DATE;
			string fileName = "Police Register " + date;
			string fileExtension = Constants.PDF_EXTENSION;

			string filePath = GenericModels.generateSavePath(basePath, month, fileName, fileExtension);
			return filePath;
		}

		private void insertHeader() 
		{
			string heading = "DELIVERY NOTE";
			string fontName = "Times New Roman";
			double fontSize = 25;
			XFont font = new XFont(fontName, fontSize, XFontStyle.Bold);

			int y_coordinate = 195;
			int x_coordinate = 187;
			graphic.DrawString(heading, font, XBrushes.Black, new XPoint(x_coordinate, y_coordinate));
		}

		/// <summary>
		/// Creates the police register.
		/// </summary>
		public void createPoliceRegister() 
		{
			
		}
	}
}
