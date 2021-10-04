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
        FileHandles fileHandles;
        DataTable companiesDataTable;
        List<string> companyNameList = new List<string>();

        const string DESTRUCTION_CERTIFICATE_EXCEPTION = "DESTRUCTION CERTIFICATE EXCEPTION";
        const string DUPLICATE_COMPANY_EXCEPTION = "THE COMPANY YOU HAVE INSERTED ALREADY EXISTS!";
        public DestructionCertificatesModel(Main_Form _form,Database _db, FileHandles fh)
        {
            _main_form = _form;
            _database = _db;
            fileHandles = fh;
            loadCompanies();
            setupDestructionCertificates();
        }
        private void setupDestructionCertificates() 
        {
            string path = Constants.DESTRUCTION_CERTIFICATES_BASE_PATH + @"\" + Constants.CURRENT_MONTH_AND_YEAR + @"\";
            fileHandles.createFolder(path);
        }
        /* Function defining the structure of the Destruction PDF with the 
         * save path
         */
        private void generatePdf(string _pdf_save_path, DestructionCertificateInfo certificateInfo)
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
    
               

                //-----------------------------------------------------------------------------------------------------------
                //Content of the pdf in strings
                string _date_of_certificate = DateTime.Now.ToString("dd MMMM yyyy       ");
                //-----------------------------------------------------------------------------------------------------------
                //Exception for extraction date

                string extraction_date = formatExtractionDate(certificateInfo.extractionDate);
                string _company_for_certificate = certificateInfo.companyName;
                string _contact_person_of_certificate = certificateInfo.contactPerson;
                string _contact_person_number_of_certificate = certificateInfo.contactNumber;
                string _contact_person_email_for_certificate = certificateInfo.emailAddress;
                string _description_of_product_for_certificate = certificateInfo.productDescription;
                string _product_quantity = getQuantities(certificateInfo.productQuantity, certificateInfo.selectedUnits);

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
                loadCompanies();
            }

            string dcStoragePath = generateSavePath(destructionCertificateInfo.companyName);
            try
            {
                generatePdf(dcStoragePath, destructionCertificateInfo);
            }
            catch (Exception ex) 
            {
                throw new Exception(DESTRUCTION_CERTIFICATE_EXCEPTION, ex);
            }
            
     
        }
        private string generateSavePath(string companyName)
        {
            string basePath = Constants.DESTRUCTION_CERTIFICATES_BASE_PATH;
            string month = Constants.CURRENT_MONTH_AND_YEAR;
            string date = Constants.DATE;
            string fileName = companyName + " " + date;
            string fileExtension = Constants.PDF_EXTENSION;

            string filePath = Generics.generateSavePath(basePath, month, fileName, fileExtension);
            return filePath;
        }


        /// <summary>Gets the quantities of the products entered in their respective quantities.</summary>
        /// <param name="quantity">The quantity.</param>
        /// <param name="units">The units.</param>
        /// <returns>A string containing the quanities of the products in kg's and in pallets.</returns>
        private string getQuantities(decimal quantity, QuantityUnits units)
        {
            string quantityInKg = "";
            string quantityInPallets = "";
            const decimal palletsToKgFactor = 60;
            decimal convertedQuantity = Constants.DECIMAL_ZERO;

            switch (units) 
            {
                case QuantityUnits.PALLETS:
                    quantityInPallets = quantity.ToString();
                    convertedQuantity = Decimal.Round(quantity * palletsToKgFactor, 2);
                    quantityInKg = convertedQuantity.ToString();
                    break;
                case QuantityUnits.KG:
                    quantityInKg = quantity.ToString();
                    convertedQuantity = Decimal.Round(quantity/palletsToKgFactor , 2);
                    quantityInPallets = convertedQuantity.ToString();
                    break;
                case QuantityUnits.Select:
                default:
                    break;
            }

            string quanties = quantityInKg + " KG ( " + quantityInPallets + " PALLETS )"; 
            return quanties;
        }

		/// <summary>Loads the companies from the database.</summary>
		private void loadCompanies() 
        {
            companiesDataTable = _database.selectAll(Database.Tables.Companies);
            int companyNameColumn = 1;

            foreach (DataRow row in companiesDataTable.Rows)
            {
                companyNameList.Add(row[companyNameColumn].ToString());
            }
        }

		/// <summary>Gets the companies names.</summary>
		/// <returns>A list of strings containing the company names.</returns>
		public List<string> getCompanies()
        {
            return companyNameList;   
        }

		/// <summary>Gets the company information given the company name.</summary>
		/// <param name="companyName">Name of the company name.</param>
		/// <returns>A CompanyInfo object with the information. Info includes the name, contact person, contact number, email address and physical address</returns>
        public Generics.CompanyInfo getCompanyInfo(string companyName) 
        {
            DataTable companyDetails = _database.select<Database.CompaniesTableColumns>(Database.Tables.Companies,
                                        Database.CompaniesTableColumns.Name, companyName);

            int nameColumn = 1;
            int contactPersonColumn = 2;
            int emailColumn = 3;
            int contactNumbersColumn = 4;
            int addressColumn = 5;
            int onlyRow = 0;

            Generics.CompanyInfo companyInfo = new Generics.CompanyInfo();
            companyInfo.companyName = companyDetails.Rows[onlyRow][nameColumn].ToString();
            companyInfo.contactPerson = companyDetails.Rows[onlyRow][contactPersonColumn].ToString();
            companyInfo.emailAddress = companyDetails.Rows[onlyRow][emailColumn].ToString();
            companyInfo.contactNumber = companyDetails.Rows[onlyRow][contactNumbersColumn].ToString();
            companyInfo.physicalAddress = companyDetails.Rows[onlyRow][addressColumn].ToString();

            return companyInfo;
        }

		/// <summary>Adds the new company to database.</summary>
		/// <param name="destructionCertificateInfo">The destruction certificate information.</param>
		/// <exception cref="Green_Enviro_App.DestructionCertificatesModel.CompanyAlreadyExistsException">If the company being added already exists.</exception>
		/// <exception cref="System.Exception">If there is an error while trying to add the new company to the database.</exception>
		private void AddNewCompanyToDatabase(DestructionCertificateInfo destructionCertificateInfo)
        {
            //Throw an exception if the user tries to insert a company that already exists.
            if (companyNameList.Contains(destructionCertificateInfo.companyName)) { throw new CompanyAlreadyExistsException(); }

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

		/// <summary>Formats the extraction date so that the days have ordinals.</summary>
		/// <param name="extractionDate">The extraction date.</param>
		/// <returns>A string representing the extraction date.</returns>
		private string formatExtractionDate (DateTime extractionDate)
        {

            string extractionDay = extractionDate.ToString("dd");
            string extractionMonth = extractionDate.ToString("MMMM");
            string extractionYear = extractionDate.ToString("yyyy");
            string daySuffix = "";

            if (extractionDay.ToString().EndsWith("11")) daySuffix = "th of";
            else if (extractionDay.ToString().EndsWith("12")) daySuffix = "th of";
            else if (extractionDay.ToString().EndsWith("13")) daySuffix = "th of";
            else if (extractionDay.ToString().EndsWith("1")) daySuffix = "st of";
            else if (extractionDay.ToString().EndsWith("2")) daySuffix = "nd of";
            else if (extractionDay.ToString().EndsWith("3")) daySuffix = "rd of";
            else daySuffix = "th of";

            string formatedDate = extractionDay + daySuffix + " " + extractionMonth + " " + extractionYear;
           
            return formatedDate;
        }

		/// <summary>Class to describe all the destruction cerificate fields.</summary>
		internal class DestructionCertificateInfo 
        {

			/// <summary>Initializes a new instance of the <see cref="DestructionCertificateInfo" /> class.</summary>
			public DestructionCertificateInfo() 
            {
                extractionDate = DateTime.Now;
                companyName = "";
                contactPerson = "";
                contactNumber = "";
                emailAddress = "";
                productDescription = "";
                productQuantity = Constants.DECIMAL_ZERO;
                newCompany = false;
                selectedUnits = QuantityUnits.Select;
            }
			/// <summary>Gets or sets the extraction date.</summary>
			/// <value>The extraction date.</value>
			public DateTime extractionDate { set; get; }

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
			public decimal productQuantity { set; get; }

			/// <summary>Gets or sets a value indicating whether [new company].</summary>
			/// <value>
			///   <c>true</c> if [new company]; otherwise, <c>false</c>.</value>
			public bool newCompany { set; get; }

			/// <summary>Gets or sets the company address.</summary>
			/// <value>The company address.</value>
			public string companyAddress { set; get; }

			/// <summary>Gets or sets the selected units of measurement.</summary>
			/// <value>The selected units.</value>
			public QuantityUnits selectedUnits { set; get; }
        }

		/// <summary>Exception to throw if the user tries to insert a company that already exists</summary>
		/// <seealso cref="System.Exception" />
		public class CompanyAlreadyExistsException : Exception 
        {
            public CompanyAlreadyExistsException() : base(DUPLICATE_COMPANY_EXCEPTION) { }
        }

		/// <summary>An enum to list the units of measurement that can be used on the destruction certificate.</summary>
		public enum QuantityUnits 
        {
            Select,
            KG,
            PALLETS
        }
    }
}
