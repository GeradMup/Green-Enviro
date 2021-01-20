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
using System.Globalization;
using System.Web.UI.WebControls;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Header;
//using Microsoft.SharePoint.Client;

namespace Green_Enviro_App
{
    class Destruction_Certificate
    {
        Main_Form _main_form;
        
        public Destruction_Certificate(Main_Form _form)
        {
            _main_form = _form;
            GenerateExtractionDateList();
            QuantityOfProducts();
            //CalculateQuantityOfProduct();
        }
        private void GenerateDestructionCertificate(string _pdf_save_path)
        {

            try
            {
                // Pdf Document type and size
                var pdfDocument = new Document(PageSize.A4, 60f, 60f, 60f, 60f);
                
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
                var y_coordinates = (pdfDocument.Top - 180f) - 30;
                var x_coordinates = 55;

                //----------------------------------------------------------------------------------------------------------
                //Using the Tuple for the Unit
                var _quantity_unit = GetQuantity();

                //-----------------------------------------------------------------------------------------------------------
                //Content of the pdf in strings
                string _date_of_certificate = DateTime.Now.ToString("dd MMMM yyyy       ");
                string extraction_date = _main_form.dstrctCertificateDayList.SelectedItem.ToString() + "th of " + _main_form.dstrctCertificateMonthList.SelectedItem.ToString() + " " + _main_form.dstrctCertificateYearList.SelectedItem.ToString();
                string _company_for_certificate = _main_form.dstrctCertCompanyField.Text;
                string _contact_person_of_certificate = _main_form.dstrctCertCntactPersonField.Text;
                string _contact_person_number_of_certificate = _main_form.dstrctCertCntactNumField.Text;
                string _contact_person_email_for_certificate = _main_form.dstrctCertEmailAddressField.Text;
                string _description_of_product_for_certificate = _main_form.dstrctCertDescripOfProdField.Text;
                string _product_quantity = _quantity_unit.Item1 + " kg ( " + _quantity_unit.Item2 + " PALLETS )"; //_main_form.dstrctCertQuantityNumBox.Text;

                //----------------------------------------------------------------------------------------------------------------
                //Constant paragraphs of the destruction certificate
                string introduction_text = "This is to certify that all products collected from your premises from the " + extraction_date + " \n";
                string continuation_of_introduction_text = "have been completely scrapped and recycled. \n";

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
                cb.ShowTextAligned(PdfContentByte.ALIGN_LEFT, introduction_text, x_coordinates, y_coordinates, 0);
                y_coordinates -= 15;
                cb.ShowTextAligned(PdfContentByte.ALIGN_LEFT, continuation_of_introduction_text, x_coordinates, y_coordinates, 0);

                y_coordinates -= 35;

                //------------------------------------------------------------------------------------------------------------------------
                // Description of products and quantity
                cb.SetFontAndSize(bold_times, 12);
                cb.ShowTextAligned(PdfContentByte.ALIGN_LEFT, "Description of products: ", x_coordinates, y_coordinates, 0);
                cb.SetFontAndSize(bfTimes, 12);
                cb.ShowTextAligned(PdfContentByte.ALIGN_LEFT, _description_of_product_for_certificate, x_coordinates + 128, y_coordinates, 0);
                y_coordinates -= 15;
                cb.SetFontAndSize(bold_times, 12);
                cb.ShowTextAligned(PdfContentByte.ALIGN_LEFT, "Quantity: ", x_coordinates, y_coordinates, 0);
                cb.SetFontAndSize(bfTimes, 12);
                cb.ShowTextAligned(PdfContentByte.ALIGN_LEFT, _product_quantity, x_coordinates + 53, y_coordinates, 0);
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
                cb.ShowTextAligned(PdfContentByte.ALIGN_LEFT, "Operations Director", x_coordinates, y_coordinates, 0);
                y_coordinates -= 15;
                cb.ShowTextAligned(PdfContentByte.ALIGN_LEFT, "Nicholas Mupfumisi", x_coordinates, y_coordinates, 0);

                //Insert picture of signature (can be improved)
                y_coordinates -= 60;
                string signauture_image_path = @"..//..//resources//Green Enviro Signature.png";
                iTextSharp.text.Image _signature_img = iTextSharp.text.Image.GetInstance(signauture_image_path);
                _signature_img.ScalePercent(75f);
                _signature_img.SetAbsolutePosition(x_coordinates - 10, y_coordinates);
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

        public void ExportToPdf()
        {

            var _generate_DC = verifyGenerateDestructionCertificate();
            MessageBoxButtons _buttons;
            MessageBoxIcon _icon;

            string _message = _generate_DC.Item3;
            string _title = _generate_DC.Item2;
            string _store_path_of_pdf = _generate_DC.Item4;
            _buttons = MessageBoxButtons.OK;

            if (_generate_DC.Item1)
            {
                _icon = MessageBoxIcon.None;
                CustomMessageBox msg = new CustomMessageBox(_title, _message);
                GenerateDestructionCertificate(_store_path_of_pdf);
                ClearDCFields();
            }
            else
            {
                _icon = MessageBoxIcon.Error;
                MessageBox.Show(_message, _title, _buttons, _icon);
            }

        }

        // Function verifying the validity of all information inputted
        private Tuple<bool, string, string,string> verifyGenerateDestructionCertificate()
        {
            string _error = "Error";
            string _success = "Success";
            string _empty_txtbox = "";
            string _message_type = "";
            string _message = "";
            string _save_pdf_path = @"..//..//resources//Logs//Destruction Certificates//" + _main_form.dstrctCertCompanyField.Text + ".pdf";
            bool _all_good = false;

            if (_main_form.dstrctCertificateDayList.SelectedIndex == 0)
            {
                _message_type = _error;
                _message = "Day for Extraction Date not selected";
                _all_good = false;
            }
            else if (_main_form.dstrctCertificateMonthList.SelectedIndex == 0)
            {
                _message_type = _error;
                _message = "Month of the Extraction Date not selected";
                _all_good = false;
            }
            else if (_main_form.dstrctCertificateYearList.SelectedIndex == 0)
            {
                _message_type = _error;
                _message = "Year of the Extraction Date not selected";
                _all_good = false;
            }
            else if (_main_form.dstrctCertCompanyField.Text == _empty_txtbox)
            {
                _message_type = _error;
                _message = "Company not entered";
                _all_good = false;
            }
            else if (_main_form.dstrctCertCntactPersonField.Text == _empty_txtbox)
            {
                _message_type = _error;
                _message = "Contact Person not entered";
                _all_good = false;
            }
            else if (_main_form.dstrctCertCntactNumField.Text == _empty_txtbox)
            {
                _message_type = _error;
                _message = "Contact number not entered";
                _all_good = false;
            }
            else if (_main_form.dstrctCertEmailAddressField.Text == _empty_txtbox)
            {
                _message_type = _error;
                _message = "Email Address not entered";
                _all_good = false;
            }
            else if (_main_form.dstrctCertDescripOfProdField.Text == _empty_txtbox)
            {
                _message_type = _error;
                _message = "No product has been entered";
                _all_good = false;
            }
            else if (_main_form.dstrctCertQuantityNumBox.Text == "0.000")
            {
                _message_type = _error;
                _message = "Quantity not entered";
                _all_good = false;
            }
            else if (System.IO.File.Exists(_save_pdf_path))
            {
                _message_type = _error;
                _message = "PDF with similar company name already exists";
                _all_good = false;
            }
            else
            {
                _message_type = _success;
                _message = "Destruction Certificate has been successfully generated";
                _all_good = true;
            }

            Tuple<bool, string, string,string> _new_tuple = new Tuple<bool, string, string,string>(_all_good, _message_type, _message,_save_pdf_path);
            return _new_tuple;
        }

        private void ClearDCFields()
        {
            _main_form.dstrctCertificateDayList.SelectedIndex = 0;
            _main_form.dstrctCertificateMonthList.SelectedIndex = 0;
            _main_form.dstrctCertificateYearList.SelectedIndex = 0;
            _main_form.dstrctCertCompanyField.Clear();
            _main_form.dstrctCertCntactPersonField.Clear();
            _main_form.dstrctCertCntactNumField.Clear();
            _main_form.dstrctCertEmailAddressField.Clear();
            _main_form.dstrctCertDescripOfProdField.Clear();
            _main_form.dstrctCertQuantityNumBox.ResetText();
            _main_form.dstrctCertQuantityUnit.SelectedIndex = 0;
        }

        private void GenerateExtractionDateList()
        {
            // Make a list for the item
            System.Web.UI.WebControls.ListItem _date;

            //-----------------------------------------------------------------------------------------------------
            //First lets generate the days of the month
            for (int day = 1; day <= System.DateTime.DaysInMonth(DateTime.Now.Year, DateTime.Now.Month);day++)
            {
                _main_form.dstrctCertificateDayList.Items.Add(day.ToString());
            }
            _main_form.dstrctCertificateDayList.Items.Insert(0, "Select");
            _main_form.dstrctCertificateDayList.SelectedIndex = 0;

            //------------------------------------------------------------------------------------------------------
            //Generating the months
            foreach (var months in DateTimeFormatInfo.CurrentInfo.MonthNames)
            {
               if (months != "")
                {
                    _date = new System.Web.UI.WebControls.ListItem();
                    _date.Text = months;
                    _date.Value = months;
                    _main_form.dstrctCertificateMonthList.Items.Add(_date);
                }
            }
            _main_form.dstrctCertificateMonthList.Items.Insert(0, "Select");
            _main_form.dstrctCertificateMonthList.SelectedIndex = 0;

            //--------------------------------------------------------------------------------------------------------
            // Generating the years
            for (int year = 2000; year <= System.DateTime.Now.Year; year++)
            {
                _main_form.dstrctCertificateYearList.Items.Add(year.ToString());
            }
            _main_form.dstrctCertificateYearList.Items.Insert(0, "Select");
            _main_form.dstrctCertificateYearList.SelectedIndex = 0;

        }
        private void QuantityOfProducts()
        {
            _main_form.dstrctCertQuantityUnit.Items.Insert(0, "Select");
            _main_form.dstrctCertQuantityUnit.Items.Insert(1,"PALLETS");
            _main_form.dstrctCertQuantityUnit.Items.Insert(2,"Kg");
            _main_form.dstrctCertQuantityUnit.SelectedIndex = 0;
            Console.WriteLine("In");
            if (_main_form.dstrctCertQuantityUnit.SelectedIndex > 0)
            {
                Console.WriteLine("First in");
                MessageBox.Show("You selected PALLETS");
                Console.WriteLine("First out");
            }/*
            if (_main_form.dstrctCertQuantityUnit.SelectedIndex == 2)
            {
                MessageBox.Show("You selected Kg");
            }*/
            //CalculateQuantityOfProduct();
        }

        private void CalculateQuantityOfProduct()
        {
            string _pallet = "PALLETS";
            string _kg = "Kg";
            string _object = _main_form.dstrctCertQuantityUnit.GetItemText(_main_form.dstrctCertQuantityUnit.SelectedItem);

            if (_main_form.dstrctCertQuantityUnit.SelectedIndex == 1 )
            {
                MessageBox.Show("You selected PALLETS");
            }
            if (_main_form.dstrctCertQuantityUnit.SelectedIndex == 2)
            {
                MessageBox.Show("You selected Kg");
            }
        }
        private Tuple<string,string> GetQuantity()
        {
            string _value_in_kg = "";
            string _value_in_pallets = "";

            if (_main_form.dstrctCertQuantityUnit.SelectedItem.ToString() == "PALLETS")
            {
                MessageBox.Show("You selected PALLETS");
                _value_in_pallets = _main_form.dstrctCertQuantityNumBox.Value.ToString();
                 
            }
            else if (_main_form.dstrctCertQuantityUnit.SelectedItem.ToString() == "Kg")
            {
                MessageBox.Show("You selected Kg");
                _value_in_kg = _main_form.dstrctCertQuantityNumBox.Value.ToString();
            }
            else MessageBox.Show("Nothing occuring");

            var _quantity = new Tuple<string, string>(_value_in_kg, _value_in_pallets);
            return _quantity;
        }
    }
}
