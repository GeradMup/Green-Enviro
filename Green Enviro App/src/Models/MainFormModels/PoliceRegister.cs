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

			insertBorder();
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

		/// <summary>
		/// Inserts the page borders.
		/// </summary>
		private void insertBorder() 
		{
			// Outside borders
			double start_x = 40;
			double start_y = 40;
			double end_x = 800;
			double end_y = 0;
			graphic.DrawLine(XPens.Black, new XPoint(start_x, start_y), new XPoint(end_x, start_y));

			start_x = 40;
			start_y = 40;
			end_x = 40;
			end_y = 560;
			graphic.DrawLine(XPens.Black, new XPoint(start_x, start_y), new XPoint(end_x, end_y));

			start_x = 40;
			start_y = 560;
			end_x = 800;
			end_y = 560;
			graphic.DrawLine(XPens.Black, new XPoint(start_x, start_y), new XPoint(end_x, end_y));

			start_x = 800;
			start_y = 40;
			end_x = 800;
			end_y = 560;
			graphic.DrawLine(XPens.Black, new XPoint(start_x, start_y), new XPoint(end_x, end_y));

			// Inside borders
			start_x = 42;
			start_y = 42;
			end_x = 798;
			end_y = 42;
			graphic.DrawLine(XPens.Black, new XPoint(start_x, start_y), new XPoint(end_x, end_y));

			start_x = 42;
			start_y = 42;
			end_x = 42;
			end_y = 558;
			graphic.DrawLine(XPens.Black, new XPoint(start_x, start_y), new XPoint(end_x, end_y));

			start_x = 42;
			start_y = 558;
			end_x = 798;
			end_y = 558;
			graphic.DrawLine(XPens.Black, new XPoint(start_x, start_y), new XPoint(end_x, end_y));

			start_x = 798;
			start_y = 42;
			end_x = 798;
			end_y = 558;
			graphic.DrawLine(XPens.Black, new XPoint(start_x, start_y), new XPoint(end_x, end_y));
		}

		/// <summary>
		/// Inserts the Police Register header label
		/// </summary>
		private void insertHeader()
		{
			string heading = "Purchases Police Register";
			string fontName = "Times New Roman";
			double fontSize = 25;
			XFont font = new XFont(fontName, fontSize, XFontStyle.Bold);

			int y_coordinate = 65;
			int x_coordinate = 290;
			graphic.DrawString(heading, font, XBrushes.Black, new XPoint(x_coordinate, y_coordinate));
		}

		/// <summary>
		/// Generates the path to be used for saving the Police Register pdf files.
		/// </summary>
		/// <returns>A string representing the path.</returns>
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



		/// <summary>
		/// Creates the police register.
		/// </summary>
		public void createPoliceRegister() 
		{
			
		}
	}
}
