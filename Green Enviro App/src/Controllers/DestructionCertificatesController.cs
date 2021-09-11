using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DCModel = Green_Enviro_App.DestructionCertificatesModel;

namespace Green_Enviro_App
{
	public partial class Main_Form : Form
	{
        //******************************************************************************************************************************
        //DESTRUCTION CERTIFICATE RELATED CALLS
        //******************************************************************************************************************************
       
        const string EXTRACTION_DATE_NOT_SELECTED_ERROR = "Extraction Date has not been selected!";
        const string COMPANY_NOT_SELECTED_ERROR = "Company not inserted!";
        const string CONTACT_PERSON_NOT_INSERTED_ERROR = "Contact person not inserted!";
        const string CONTACT_NUMBER_NOT_INSERTED_ERROR = "Contact numbers not inserted!";
        const string EMAIL_NOT_INSERTED_ERROR = "Email address not inserted!";
        const string PRODUCT_DESCRIPTION_NOT_INSERTED_ERROR = "Product description not inserted!";
        const string PRODUCT_QUANTITY_NOT_INSERTED_ERROR = "Product quantity not inserted!";
        const string QUANTITY_UNITS_NOT_SELECTED_ERROR = "Please selected the unit of products quantity!";
        const string COMPANY_ADDRESS_NOT_INSERTED_ERROR = "Please insert the company address";
        const string DC_GENERATION_SUCCESS = "Destruction certificate has been generated successfully!";

        private void initializeDestructionCertificatesTab() 
        {
            setUpProductUnits();
            resetDestructionCertificateFields();
            setUpCompaniesList();
        }
        private void setUpProductUnits()
        {
            string select = Generics.enumToString<DCModel.QuantityUnits>(DCModel.QuantityUnits.Select);
            string pallets = Generics.enumToString<DCModel.QuantityUnits>(DCModel.QuantityUnits.PALLETS);
            string kg = Generics.enumToString<DCModel.QuantityUnits>(DCModel.QuantityUnits.KG);

            dstrctCertQuantityUnit.Items.Insert(0,select);
            dstrctCertQuantityUnit.Items.Insert(1, pallets);
            dstrctCertQuantityUnit.Items.Insert(2, kg);
            dstrctCertQuantityUnit.SelectedIndex = 0;
        }

        private void setUpCompaniesList() 
        {
            List<string> companies = _destructionCertificatesModel.getCompanies();
            dstrctCertCompanyField.Items.AddRange(companies.Cast<object>().ToArray());
        }

		/// <summary>Handles the Click event of the generateDstrCertBtn control.</summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
		private void generateDstrCertBtn_Click(object sender, EventArgs e)
        {
            //First we verify that all the input fields have valid information
            const int zeroIndex = 0;
            if (dstrctCertExtractionDate.Checked == false) { reportError(EXTRACTION_DATE_NOT_SELECTED_ERROR); return; }
            if (dstrctCertCompanyField.Text == Constants.EMPTY_TEXT) { reportError(COMPANY_NOT_SELECTED_ERROR); return; }
            if (dstrctCertCntactPersonField.Text == Constants.EMPTY_TEXT) { reportError(CONTACT_PERSON_NOT_INSERTED_ERROR); return; }
            if (dstrctCertCntactNumField.Text == Constants.EMPTY_TEXT) { reportError(CONTACT_NUMBER_NOT_INSERTED_ERROR); return; }
            if (dstrctCertEmailAddressField.Text == Constants.EMPTY_TEXT) { reportError(EMAIL_NOT_INSERTED_ERROR); return; }
            if (dstrctCertDescripOfProdField.Text == Constants.EMPTY_TEXT) { reportError(PRODUCT_DESCRIPTION_NOT_INSERTED_ERROR); return; }
            if (dstrctCertQuantityNumBox.Value == Constants.DECIMAL_ZERO) { reportError(PRODUCT_QUANTITY_NOT_INSERTED_ERROR); return; }
            if (dstrctCertQuantityUnit.SelectedIndex == zeroIndex) { reportError(QUANTITY_UNITS_NOT_SELECTED_ERROR); return; }
            if (dstcrtCompanyAddress.Text == Constants.EMPTY_TEXT) { reportError(COMPANY_ADDRESS_NOT_INSERTED_ERROR); return; }
            
            string measurementUnits = dstrctCertQuantityUnit.SelectedItem.ToString();
            DCModel.DestructionCertificateInfo destructionInfo = new DCModel.DestructionCertificateInfo();
            destructionInfo.companyAddress = dstcrtCompanyAddress.Text;
            destructionInfo.companyName = dstrctCertCompanyField.Text;
            destructionInfo.contactNumber = dstrctCertCntactNumField.Text;
            destructionInfo.contactPerson = dstrctCertCntactPersonField.Text;
            destructionInfo.emailAddress = dstrctCertEmailAddressField.Text;
            destructionInfo.extractionDate = dstrctCertExtractionDate.Value;
            destructionInfo.newCompany = dstcrtNewCompanyCheckbox.Checked;
            destructionInfo.productDescription = dstrctCertDescripOfProdField.Text;
            destructionInfo.productQuantity = dstrctCertQuantityNumBox.Value;
            destructionInfo.selectedUnits = Generics.stringToEnum<DCModel.QuantityUnits>(measurementUnits);

            try
            {
                _destructionCertificatesModel.generateCertificate(destructionInfo);
                resetDestructionCertificateFields();
                reportSuccess(DC_GENERATION_SUCCESS);
            }
            catch (Exception ex) 
            {
                reportError(ex.Message);
            }
            
        }

		/// <summary>Handles the SelectedIndexChanged event of the dstrctCertCompanyField control.</summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
		private void dstrctCertCompanyField_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (dstrctCertCompanyField.SelectedItem == null) return;

            string companyName = dstrctCertCompanyField.SelectedItem.ToString();

            try
            {
                Generics.CompanyInfo companyInfo = _destructionCertificatesModel.getCompanyInfo(companyName);
                dstrctCertCntactPersonField.Text = companyInfo.contactPerson;
                dstrctCertCntactNumField.Text = companyInfo.contactNumber;
                dstrctCertEmailAddressField.Text = companyInfo.emailAddress;
                dstcrtCompanyAddress.Text = companyInfo.physicalAddress;
            }
            catch (Exception ex) 
            {
                reportError(ex.Message);
            }
        }

		/// <summary>Handles the CheckedChanged event of the dstcrtNewCompanyCheckbox control.</summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
		private void dstcrtNewCompanyCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            if (dstcrtNewCompanyCheckbox.Checked)
            {
                dstrctCertCntactPersonField.ReadOnly = false;
                dstrctCertCntactNumField.ReadOnly = false;
                dstrctCertCompanyField.DropDownStyle = ComboBoxStyle.DropDown;
                dstrctCertEmailAddressField.ReadOnly = false;
                dstcrtCompanyAddress.ReadOnly = false;
                resetDestructionCertificateFields();
            }
            else
            {
                dstrctCertCntactPersonField.ReadOnly = true;
                dstrctCertCntactNumField.ReadOnly = true;
                dstrctCertCompanyField.DropDownStyle = ComboBoxStyle.DropDownList;
                dstrctCertEmailAddressField.ReadOnly = true;
                dstcrtCompanyAddress.ReadOnly = true;
            }   
        }

		/// <summary>Resets the destruction certificate fields.</summary>
		private void resetDestructionCertificateFields() 
        {
            dstcrtCompanyAddress.Clear();
            dstrctCertCompanyField.SelectedItem = null;
            dstrctCertCntactNumField.Clear();
            dstrctCertCntactPersonField.Clear();
            dstrctCertEmailAddressField.Clear();
            dstrctCertExtractionDate.Value = DateTime.Now;
            dstcrtNewCompanyCheckbox.CheckState = CheckState.Unchecked;
            dstrctCertDescripOfProdField.Clear();
            dstrctCertQuantityNumBox.Value = Constants.DECIMAL_ZERO;
            dstrctCertQuantityUnit.SelectedIndex = 0;
        }
    }
}
