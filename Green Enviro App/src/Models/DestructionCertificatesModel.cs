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

namespace Green_Enviro_App
{
    /* This is the Destruction Certificate class
     * It is used to generate the destruction certificate pdf when selecting the
     * Destruction Certificate tab on the main page
     */
    class DestructionCertificatesModel
    {
        /* Here we generate the instances that will connect the class
         * with othe classes that are needed to make the certificate
         */
        Main_Form _main_form;
        Database _database;
        DataTable companiesDataTable;
        bool _is_company_selected = false;
        bool is_company_exist = false;
        List<string> companyNameList = new List<string>();

        const string DESTRUCTION_CERTIFICATE_EXCEPTION = "DESTRUCTION CERTIFICATE EXCEPTION";
        const string DUPLICATE_COMPANY_EXCEPTION = "The company you have entered already exists!";
        public DestructionCertificatesModel(Main_Form _form,Database _db)
        {
            _main_form = _form;
            _database = _db;
            companiesDataTable = _database.selectAll(Database.Tables.Companies);
            //Obtaining the present time so as to always make sure the dates are accurate at run time
            _main_form.dstrctCertExtractionDate.Value = DateTime.Now;
        }
        /* Function defining the structure of the Destruction PDF with the 
         * save path
         */
        private void generatePdf(string _pdf_save_path)
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

                // Lets open the pdf document
                pdfDocument.Open();

                // Here we need the path to the image or logo image
                var image_path = @"..//..//resources//Green Enviro Destruction Certificate Logo Better.png";

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
                img.ScalePercent(45f);
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
                //-----------------------------------------------------------------------------------------------------------
                //Exception for extraction date

                string extraction_date = GenerateExtractionDate();
                string _company_for_certificate = _main_form.dstrctCertCompanyField.Text;
                string _contact_person_of_certificate = _main_form.dstrctCertCntactPersonField.Text;
                string _contact_person_number_of_certificate = _main_form.dstrctCertCntactNumField.Text;
                string _contact_person_email_for_certificate = _main_form.dstrctCertEmailAddressField.Text;
                string _description_of_product_for_certificate = _main_form.dstrctCertDescripOfProdField.Text;
                string _product_quantity = _quantity_unit.Item1 + " kg ( " + _quantity_unit.Item2 + " PALLETS )"; //_main_form.dstrctCertQuantityNumBox.Text;

                //----------------------------------------------------------------------------------------------------------------
                //Constant paragraphs of the destruction certificate
                string introduction_text = "This is to certify that all products collected from your premises on the " + extraction_date + " \n";
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
                string signature_image_path = Constants.SINGNATURE_IMAGE_PATH;
                iTextSharp.text.Image _signature_img = iTextSharp.text.Image.GetInstance(signature_image_path);
                _signature_img.ScalePercent(10F);
                _signature_img.SetAbsolutePosition(x_coordinates - 10, y_coordinates + 90);
                cb.AddImage(_signature_img);


                cb.EndText();
                pdfDocument.Close();
                writer.Close();
                fs.Close();
            }
            catch (Exception ex)
            {
                throw new Exception(DESTRUCTION_CERTIFICATE_EXCEPTION, ex);
            }
        }
        /* Function that verifies if the PDF has all information and can be
         * generated
         */
        public void generateCertificate(DestructionCertificateInfo destructionCertificateInfo)
        { 
            if (destructionCertificateInfo.newCompany)
            {
                AddNewCompanyToDatabase(destructionCertificateInfo);
                
            }

            generatePdf(_store_path_of_pdf);
     
        }

        /* Function that acts with the behaviour of the New Company
         * checkbox on the Destruction Certificate tab. It enables you
         * to verify if a new company needs is entered and if so place it into the
         * database.
         */

        // Function that verifies if the SI Unit is selected and providing a conversion
        // From Kg to Pallets and Pallets to Kg. NB: the conversion of
        // Pallets and Kg is not a concrete fact its from given information.
        private Tuple<string,string,bool> GetQuantity()
        {
            string _value_in_kg = "";
            string _value_in_pallets = "";
            double _quantity_of_product = Convert.ToDouble(_main_form.dstrctCertQuantityNumBox.Value);
            bool _is_quantity_selected = false;


            if (_main_form.dstrctCertQuantityUnit.SelectedItem.ToString() == "PALLETS")
            {
                double _conversion = 0;
                _conversion = _quantity_of_product * 60;
                _value_in_pallets = _main_form.dstrctCertQuantityNumBox.Value.ToString();
                _value_in_kg = _conversion.ToString();
                _is_quantity_selected = true;

            }
            else if (_main_form.dstrctCertQuantityUnit.SelectedItem.ToString() == "Kg")
            {
                double _conversion = 0;
                if (_quantity_of_product > 60)
                {
                    _conversion = _quantity_of_product / 60;
                    _value_in_kg = _main_form.dstrctCertQuantityNumBox.Value.ToString();
                    _value_in_pallets = _conversion.ToString();
                }
                else
                {
                    _value_in_kg = _main_form.dstrctCertQuantityNumBox.Value.ToString();
                    _value_in_pallets = _conversion.ToString();
                }
                _is_quantity_selected = true;
            }
            else _is_quantity_selected = false;

            var _quantity = new Tuple<string, string,bool>(_value_in_kg, _value_in_pallets,_is_quantity_selected);
            return _quantity;
        }

        /* Selecting the Companies table from our Database and loading
         * it to the the main page at run time. All information is seen
         * at the Company list combobox and will continuously be updated per 
         * changes done to the database.
         */

        private void loadCompanies() 
        {
            companiesDataTable = _database.selectAll(Database.Tables.Companies);
            int companyNameColumn = 1;

            foreach (DataRow row in companiesDataTable.Rows)
            {
                companyNameList.Add(row[companyNameColumn].ToString());
            }
        }
        public List<string> getCompanies()
        {
            //List<string> companyNameList = new List<string>();
            //int companiyNameColumn = 1;

            //_main_form.dstrctCertCompanyField.Items.Clear();

            
        }

        /* Function acting with the Company Combobox, verifying if a company is selected 
         * and providing all the required information of the company selected.
         */
        public void Company_Selected()
        {
            //If no company selected do nothing
            if (_main_form.dstrctCertCompanyField.Text == "")
            {
                _main_form.dstrctCertCntactPersonField.Text = "";
                _main_form.dstrctCertCntactNumField.Text = "";
                _main_form.dstrctCertEmailAddressField.Text = "";
                _is_company_selected = false;
                return;
            }

            //Verifies if the New Company checkbox is not selected and in that case provides
            //all the relevant information with regards to the company selected
            if (_main_form.dstrctCertNewCompanyCheckBox.CheckState == CheckState.Unchecked) 
            {
                string _company_selected = _main_form.dstrctCertCompanyField.Text;
                string _company_information = "Name = '" + _company_selected + "'";
                companiesDataTable = _database.selectAll(Database.Tables.Companies);
                DataView _dataview = companiesDataTable.DefaultView;
                DataRow[] _row = companiesDataTable.Select(_company_information);

                int index = 0;

                string _company_contact_person = _row[index].Field<string>("ContactPerson");
                string _company_email = _row[index].Field<string>("Email");
                string _company_contact_number = _row[index].Field<string>("ContactNumbers");

                _main_form.dstrctCertCntactPersonField.Text = _company_contact_person;
                _main_form.dstrctCertCntactNumField.Text = _company_contact_number;
                _main_form.dstrctCertEmailAddressField.Text = _company_email;
            }

            _is_company_selected = true;
            is_company_exist = true;
        }
        /// <summary>
        /// Function clearing the company details when the new company checkbox is checked
        /// </summary>

		/// <summary>Adds the new company to database.</summary>
		/// <param name="destructionCertificateInfo">The destruction certificate information.</param>
		/// <exception cref="Green_Enviro_App.DestructionCertificatesModel.CompanyAlreadyExistsException">If the company being added already exists.</exception>
		/// <exception cref="System.Exception">If there is an error while trying to add the new company to the database.</exception>
		private void AddNewCompanyToDatabase(DestructionCertificateInfo destructionCertificateInfo)
        {
            //Throw an exception if the user tries to insert a company that already exists.
            if (_company_list.Contains(destructionCertificateInfo.companyName)) { throw new CompanyAlreadyExistsException(); }

            string companyName = destructionCertificateInfo.companyName;
            string contactPerson = destructionCertificateInfo.contactPerson;
            string contactNumber = destructionCertificateInfo.contactNumber;
            string email = destructionCertificateInfo.emailAddress;
            string address = destructionCertificateInfo.companyAddress;
            string[] values = { companyName, contactPerson, email, contactNumber, address };

            try
            {
                _database.insert(Database.Tables.Companies, values);
            }
            catch (Exception exception) 
            {
                throw new Exception(exception.Message);
            }
        }
        
        /* 
         * Function to verify the day of the date and to construct the correct sentence
         * for the destruction certificate.
         */
        private string GenerateExtractionDate ()
        {
            string _extraction_date = "";
            string _extraction_day = _main_form.dstrctCertExtractionDate.Value.ToString("dd");
            string _extraction_month = _main_form.dstrctCertExtractionDate.Value.ToString("MMMM");
            string _extraction_year = _main_form.dstrctCertExtractionDate.Value.ToString("yyyy");

            if (_extraction_day == "1" || _extraction_day == "31" || _extraction_day == "21")
            {
                _extraction_date = _extraction_day + "st of " + _extraction_month + " " + _extraction_year;
            }
            else if (_extraction_day == "2" || _extraction_day == "22")
            {
                _extraction_date = _extraction_day + "nd of " + _extraction_month + " " + _extraction_year;
            }
            else if (_extraction_day == "3" || _extraction_day == "23")
            {
                _extraction_date = _extraction_day + "rd of " + _extraction_month + " " + _extraction_year;
            }
            else
            {
                _extraction_date = _extraction_day + "th of " + _extraction_month + " " + _extraction_year;
            }

            return _extraction_date;
        }

		/// <summary>Class to describe all the destruction cerificate fields.</summary>
		internal class DestructionCertificateInfo 
        {

			/// <summary>Initializes a new instance of the <see cref="DestructionCertificateInfo" /> class.</summary>
			public DestructionCertificateInfo() 
            {
                extractionDate = "";
                companyName = "";
                contactPerson = "";
                contactNumber = "";
                emailAddress = "";
                productDescription = "";
                productQuantity = "";
                quantityUnit = "";
                newCompany = false;
            }
			/// <summary>Gets or sets the extraction date.</summary>
			/// <value>The extraction date.</value>
			public string extractionDate { set; get; }

			/// <summary>Gets or sets the name of the company.</summary>
			/// <value>The name of the company.</value>
			public string companyName { set; get; }

			/// <summary>Gets or sets the contact person.</summary>
			/// <value>The contact person.</value>
			public string contactPerson { set; get; }

			/// <summary>Gets or sets the contact number.</summary>
			/// <value>The contact number.</value>
			public string contactNumber { set; get; }

			/// <summary>Gets or sets the email address.</summary>
			/// <value>The email address.</value>
			public string emailAddress { set; get; }

			/// <summary>Gets or sets the product description.</summary>
			/// <value>The product description.</value>
			public string productDescription { set; get; }

			/// <summary>Gets or sets the product quantity.</summary>
			/// <value>The product quantity.</value>
			public string productQuantity { set; get; }

			/// <summary>Gets or sets the quantity unit.</summary>
			/// <value>The quantity unit.</value>
			public string quantityUnit { set; get; }

			/// <summary>Gets or sets a value indicating whether [new company].</summary>
			/// <value>
			///   <c>true</c> if [new company]; otherwise, <c>false</c>.</value>
			public bool newCompany { set; get; }

			/// <summary>Gets or sets the company address.</summary>
			/// <value>The company address.</value>
			public string companyAddress { set; get; }
        }

		/// <summary>Exception to throw if the user tries to insert a company that already exists</summary>
		/// <seealso cref="System.Exception" />
		public class CompanyAlreadyExistsException : Exception 
        {
            public CompanyAlreadyExistsException() : base(DUPLICATE_COMPANY_EXCEPTION) { }
        }
    }
}
