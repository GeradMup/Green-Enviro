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
            resetDestructionCertificate();
            setUpCompaniesList();
        }
        private void setUpProductUnits()
        {
            string select = GenericModels.enumToString<DCModel.QuantityUnits>(DCModel.QuantityUnits.Select);
            string pallets = GenericModels.enumToString<DCModel.QuantityUnits>(DCModel.QuantityUnits.PALLETS);
            string kg = GenericModels.enumToString<DCModel.QuantityUnits>(DCModel.QuantityUnits.KG);

            DestructionCertQnttyUnit.Items.Insert(0,select);
            DestructionCertQnttyUnit.Items.Insert(1, pallets);
            DestructionCertQnttyUnit.Items.Insert(2, kg);
            DestructionCertQnttyUnit.SelectedIndex = 0;
        }

        private void setUpCompaniesList() 
        {
            List<string> companies = _destructionCertificatesModel.getCompanies();
            DestructionCertCompany.Items.AddRange(companies.Cast<object>().ToArray());
        }

		/// <summary>Handles the Click event of the generateDstrCertBtn control.</summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
		private void generateDstrCertBtn_Click(object sender, EventArgs e)
        {
            //First we verify that all the input fields have valid information
            const int zeroIndex = 0;
            if (DestructionCertExtractionDate.Checked == false) { GenericControllers.reportError(_mainForm, EXTRACTION_DATE_NOT_SELECTED_ERROR); return; }
            if (DestructionCertCompany.Text == Constants.EMPTY_TEXT) { GenericControllers.reportError(_mainForm, COMPANY_NOT_SELECTED_ERROR); return; }
            if (DestructionCertCntactPerson.Text == Constants.EMPTY_TEXT) { GenericControllers.reportError(_mainForm, CONTACT_PERSON_NOT_INSERTED_ERROR); return; }
            if (DestructionCertCntactNum.Text == Constants.EMPTY_TEXT) { GenericControllers.reportError(_mainForm, CONTACT_NUMBER_NOT_INSERTED_ERROR); return; }
            if (DestructionCertEmailAddress.Text == Constants.EMPTY_TEXT) { GenericControllers.reportError(_mainForm, EMAIL_NOT_INSERTED_ERROR); return; }
            if (DestructionCertDescripOfPrdct.Text == Constants.EMPTY_TEXT) { GenericControllers.reportError(_mainForm, PRODUCT_DESCRIPTION_NOT_INSERTED_ERROR); return; }
            if (DestructionCertQntty.Value == Constants.DECIMAL_ZERO) { GenericControllers.reportError(_mainForm, PRODUCT_QUANTITY_NOT_INSERTED_ERROR); return; }
            if (DestructionCertQnttyUnit.SelectedIndex == zeroIndex) { GenericControllers.reportError(_mainForm, QUANTITY_UNITS_NOT_SELECTED_ERROR); return; }
            if (DestructionCertCmpnyAddress.Text == Constants.EMPTY_TEXT) { GenericControllers.reportError(_mainForm, COMPANY_ADDRESS_NOT_INSERTED_ERROR); return; }
            
            string measurementUnits = DestructionCertQnttyUnit.SelectedItem.ToString();
            DCModel.DestructionCertificateInfo destructionInfo = new DCModel.DestructionCertificateInfo();
            destructionInfo.companyAddress = DestructionCertCmpnyAddress.Text;
            destructionInfo.companyName = DestructionCertCompany.Text;
            destructionInfo.contactNumber = DestructionCertCntactNum.Text;
            destructionInfo.contactPerson = DestructionCertCntactPerson.Text;
            destructionInfo.emailAddress = DestructionCertEmailAddress.Text;
            destructionInfo.extractionDate = DestructionCertExtractionDate.Value;
            destructionInfo.newCompany = DestructionCertNewCompanyCheckbox.Checked;
            destructionInfo.productDescription = DestructionCertDescripOfPrdct.Text;
            destructionInfo.productQuantity = DestructionCertQntty.Value;
            destructionInfo.selectedUnits = GenericModels.stringToEnum<DCModel.QuantityUnits>(measurementUnits);

            try
            {
                _destructionCertificatesModel.generateCertificate(destructionInfo);
                resetDestructionCertificate();
                GenericControllers.reportSuccess(_mainForm, DC_GENERATION_SUCCESS);
            }
            catch (Exception ex) 
            {
                GenericControllers.reportError(_mainForm, ex.Message);
            }
            
        }

		/// <summary>Handles the SelectedIndexChanged event of the dstrctCertCompanyField control.</summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
		private void dstrctCertCompanyField_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (DestructionCertCompany.SelectedItem == null) return;

            string companyName = DestructionCertCompany.SelectedItem.ToString();

            try
            {
                GenericModels.CompanyInfo companyInfo = _destructionCertificatesModel.getCompanyInfo(companyName);
                DestructionCertCntactPerson.Text = companyInfo.contactPerson;
                DestructionCertCntactNum.Text = companyInfo.contactNumber;
                DestructionCertEmailAddress.Text = companyInfo.emailAddress;
                DestructionCertCmpnyAddress.Text = companyInfo.physicalAddress;
            }
            catch (Exception ex) 
            {
                GenericControllers.reportError(_mainForm, ex.Message);
            }
        }

		/// <summary>Handles the CheckedChanged event of the dstcrtNewCompanyCheckbox control.</summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
		private void dstcrtNewCompanyCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            if (DestructionCertNewCompanyCheckbox.Checked)
            {
                DestructionCertCntactPerson.ReadOnly = false;
                DestructionCertCntactNum.ReadOnly = false;
                DestructionCertCompany.DropDownStyle = ComboBoxStyle.DropDown;
                DestructionCertEmailAddress.ReadOnly = false;
                DestructionCertCmpnyAddress.ReadOnly = false;
                resetDestructionCertificate();
            }
            else
            {
                DestructionCertCntactPerson.ReadOnly = true;
                DestructionCertCntactNum.ReadOnly = true;
                DestructionCertCompany.DropDownStyle = ComboBoxStyle.DropDownList;
                DestructionCertEmailAddress.ReadOnly = true;
                DestructionCertCmpnyAddress.ReadOnly = true;
            }   
        }

		/// <summary>Resets the destruction certificate fields.</summary>
		private void resetDestructionCertificate() 
        {
            DestructionCertCmpnyAddress.Clear();
            DestructionCertCompany.SelectedItem = null;
            DestructionCertCntactNum.Clear();
            DestructionCertCntactPerson.Clear();
            DestructionCertEmailAddress.Clear();
            DestructionCertExtractionDate.Value = DateTime.Now;
            DestructionCertNewCompanyCheckbox.CheckState = CheckState.Unchecked;
            DestructionCertDescripOfPrdct.Clear();
            DestructionCertQntty.Value = Constants.DECIMAL_ZERO;
            DestructionCertQnttyUnit.SelectedIndex = 0;
        }
    }
}
