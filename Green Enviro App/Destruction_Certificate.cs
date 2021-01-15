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

                //-----------------------------------------------------
                //Here we are writing the context of the pdf file
                
                //-----------------------------------------------------------------------------------------------------------
                //Coordinates for exact placement
                var y_coordinates = (pdfDocument.Top - 180f)-30;
                var x_coordinates = 55;
                
                //-----------------------------------------------------------------------------------------------------------
                //Content of the pdf in strings
                string _date_of_certificate = DateTime.Now.ToString("dd MMMM yyyy       ");
                string extraction_date = _main_form.dstrctCertExtrctDateField.Text;
                string _company_for_certificate = _main_form.dstrctCertCompanyField.Text;
                string _contact_person_of_certificate = _main_form.dstrctCertCntactPersonField.Text;
                string _contact_person_number_of_certificate = _main_form.dstrctCertCntactNumField.Text;
                string _contact_person_email_for_certificate = _main_form.dstrctCertEmailAddressField.Text;
                string _description_of_product_for_certificate = _main_form.dstrctCertDescripOfProdField.Text;
                string _product_quantity = _main_form.dstrctCertQuantityField.Text;

                //----------------------------------------------------------------------------------------------------------------
                //Constant paragraphs of the destruction certificate
                string introduction_text = "This is to certify that all products collected from your premises from the " + extraction_date + " \n";
                string continuation_of_introduction_text = "have been completely scrapped and recycled \n";

                string _first_sentence_certifying_privacy = "We certify that all the material has been recycled in accordance with our organization’s secure \n";
                string _second_sentence_certifying_privacy = "destruction policies and in an environmentally friendly manner. National Provincial and Local \n";
                string _thrid_sentence_certifying_privacy = "Legislation have been upheld. If you have any queries please do not hesitate to contact us. \n";

                //-----------------------------------------------------------------------------------------------------------------
                //Writing in the pdf the information provided by the textbox
                y_coordinates -= 35;

                cb.SetFontAndSize(bold_times, 12);
                cb.ShowTextAligned(PdfContentByte.ALIGN_LEFT, "Date: ", x_coordinates, y_coordinates, 0);
                cb.SetFontAndSize(bfTimes, 12);
                cb.ShowTextAligned(PdfContentByte.ALIGN_LEFT, _date_of_certificate, x_coordinates + 30, y_coordinates, 0);
                y_coordinates -= 15;
                cb.SetFontAndSize(bold_times, 12);
                cb.ShowTextAligned(PdfContentByte.ALIGN_LEFT, "Company: ", x_coordinates, y_coordinates, 0);
                cb.SetFontAndSize(bfTimes, 12);
                cb.ShowTextAligned(PdfContentByte.ALIGN_LEFT, _company_for_certificate, x_coordinates + 57, y_coordinates, 0);
                y_coordinates -= 15;
                cb.SetFontAndSize(bold_times, 12);
                cb.ShowTextAligned(PdfContentByte.ALIGN_LEFT, "Contact Person: ", x_coordinates, y_coordinates, 0);
                cb.SetFontAndSize(bfTimes, 12);
                cb.ShowTextAligned(PdfContentByte.ALIGN_LEFT, _contact_person_of_certificate, x_coordinates + 87, y_coordinates, 0);
                y_coordinates -= 15;
                cb.SetFontAndSize(bold_times, 12);
                cb.ShowTextAligned(PdfContentByte.ALIGN_LEFT, "Email Address: ", x_coordinates, y_coordinates, 0);
                cb.SetFontAndSize(bfTimes, 12);
                cb.ShowTextAligned(PdfContentByte.ALIGN_LEFT, _contact_person_email_for_certificate, x_coordinates + 82, y_coordinates, 0);
                y_coordinates -= 15;
                cb.SetFontAndSize(bold_times, 12);
                cb.ShowTextAligned(PdfContentByte.ALIGN_LEFT, "Contact Numbers: ", x_coordinates, y_coordinates, 0);
                cb.SetFontAndSize(bfTimes, 12);
                cb.ShowTextAligned(PdfContentByte.ALIGN_LEFT, _contact_person_number_of_certificate, x_coordinates + 97, y_coordinates, 0);
                
                y_coordinates -= 25;

                //----------------------------------------------------------------------------------------------------------------------
                // Paragraph certifying the date and the materials the company recycled or scrapped
                cb.SetFontAndSize(bfTimes, 12);
                cb.ShowTextAligned(PdfContentByte.ALIGN_LEFT, introduction_text, x_coordinates, y_coordinates, 0) ;
                y_coordinates -= 15;
                cb.ShowTextAligned(PdfContentByte.ALIGN_LEFT, continuation_of_introduction_text, x_coordinates, y_coordinates, 0) ;

                y_coordinates -= 35;

                //------------------------------------------------------------------------------------------------------------------------
                // Description of products and quantity
                cb.SetFontAndSize(bold_times, 12);
                cb.ShowTextAligned(PdfContentByte.ALIGN_LEFT, "Description of products: ", x_coordinates , y_coordinates, 0);
                cb.SetFontAndSize(bfTimes, 12);
                cb.ShowTextAligned(PdfContentByte.ALIGN_LEFT, _contact_person_email_for_certificate, x_coordinates + 82, y_coordinates, 0);
                y_coordinates -= 15;
                cb.SetFontAndSize(bold_times, 12);
                cb.ShowTextAligned(PdfContentByte.ALIGN_LEFT, "Quantity: ", x_coordinates , y_coordinates, 0);
                cb.SetFontAndSize(bfTimes, 12);
                cb.ShowTextAligned(PdfContentByte.ALIGN_LEFT, _contact_person_email_for_certificate, x_coordinates + 50, y_coordinates, 0);
                y_coordinates -= 45;

                //------------------------------------------------------------------------------------------------------------------------
                // Legals and Privacy terms and conditions

                cb.ShowTextAligned(PdfContentByte.ALIGN_LEFT, _first_sentence_certifying_privacy, x_coordinates, y_coordinates, 0);
                y_coordinates -= 15;
                cb.ShowTextAligned(PdfContentByte.ALIGN_LEFT, _second_sentence_certifying_privacy, x_coordinates, y_coordinates, 0);
                y_coordinates -= 15;
                cb.ShowTextAligned(PdfContentByte.ALIGN_LEFT, _thrid_sentence_certifying_privacy, x_coordinates, y_coordinates, 0);

                y_coordinates -= 135;
                //------------------------------------------------------------------------------------------------------------------------
                //Signature and Current Date

                cb.SetFontAndSize(bold_times, 12);
                cb.ShowTextAligned(PdfContentByte.ALIGN_LEFT, _date_of_certificate, x_coordinates + 335, y_coordinates, 0);
                cb.ShowTextAligned(PdfContentByte.ALIGN_LEFT, "Operations Director", x_coordinates , y_coordinates, 0);
                y_coordinates -= 15;
                cb.ShowTextAligned(PdfContentByte.ALIGN_LEFT, "Nicholas Mupfumisi", x_coordinates , y_coordinates, 0);

                //Insert picture of signature (can be improved)
                y_coordinates -= 60;
                string signauture_image_path = @"..//..//resources//Green Enviro Signature.png";
                iTextSharp.text.Image _signature_img = iTextSharp.text.Image.GetInstance(signauture_image_path);
                _signature_img.ScalePercent(75f);
                _signature_img.SetAbsolutePosition(x_coordinates-10, y_coordinates);
                cb.AddImage(_signature_img);


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
