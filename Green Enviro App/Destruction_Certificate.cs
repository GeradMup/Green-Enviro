using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;

namespace Green_Enviro_App
{
    class Destruction_Certificate
    {
        Main_Form _main_form;
        public Destruction_Certificate(Main_Form _form)
        {
            _main_form = _form;
        }

        public void ExportToPdf()
        {
            try
            {
                // Pdf Document type and size
                var pdfDocument = new Document(PageSize.A4, 60f, 60f, 60f, 60f);
                // Document path where it will be saved
                string _pdf_save_path = @"..//..//resources//Logs//Destruction Certificates//Pdf Test.pdf";
                //-----------------------------------------------------------------
                System.IO.FileStream fs = new FileStream(_pdf_save_path, FileMode.OpenOrCreate);
                //***********************************************************************
                PdfWriter writer = PdfWriter.GetInstance(pdfDocument, fs);

                //Here when uncommenting you can add meta information 
                
                /*
                // Add meta information to the document  
                pdfDocument.AddAuthor("Micke Blomquist");  
                pdfDocument.AddCreator("Sample application using iTextSharp");  
                pdfDocument.AddKeywords("PDF tutorial education");  
                pdfDocument.AddSubject("Document subject - Describing the steps creating a PDF document");  
                pdfDocument.AddTitle("The document title - PDF creation using iTextSharp");  
                */


                // Lets open the pdf document
                pdfDocument.Open();

                // Here we need the path to the image or logo image
                var image_path = @"..//..//resources//Green Enviro Destruction Certificate Logo.png";

   
                
                var spacer = new Paragraph("")
                {
                    SpacingBefore = 10f,
                    SpacingAfter = 10f,
                };

                //Font fntHeading = FontFactory.GetFont(FontFactory.HELVETICA, 20, Font.BOLD, new Color(0x00, 0x00, 0x00));
                BaseFont f_cn = BaseFont.CreateFont("c:\\windows\\fonts\\calibri.ttf", BaseFont.CP1252, BaseFont.NOT_EMBEDDED);
                BaseFont bfTimes = BaseFont.CreateFont(BaseFont.TIMES_ROMAN, BaseFont.CP1252, false);
                BaseFont bold_times = BaseFont.CreateFont(BaseFont.TIMES_BOLD, BaseFont.CP1252, false);

                //Font times = new Font(bfTimes, 12, Font.ITALIC, Color.RED);
                String msg = "Destruction Certificate";

                //BaseFont bfTimes = BaseFont.CreateFont(BaseFont.TIMES_ROMAN, BaseFont.CP1252, false);

                PdfContentByte cb = writer.DirectContent;

                cb.BeginText();

                iTextSharp.text.Image img = iTextSharp.text.Image.GetInstance(image_path);
                img.ScalePercent(75f);
                img.SetAbsolutePosition((PageSize.A4.Width - img.ScaledWidth) / 2, pdfDocument.Top - 135f);
                cb.AddImage(img);

                cb.SetFontAndSize(bold_times, 20);
                cb.ShowTextAligned(PdfContentByte.ALIGN_CENTER, "Destruction Certificate", 295, pdfDocument.Top - 180f, 0);



                cb.EndText();
                pdfDocument.Close();
                writer.Close();
                fs.Close();
            }
            catch (Exception ex)
            {

            }


        }

    }
}
