using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        private void initializeDestructionCertificatesTab() 
        {
            setUpProductUnits();
        }
        private void setUpProductUnits()
        {
            dstrctCertQuantityUnit.Items.Insert(0, "Select");
            dstrctCertQuantityUnit.Items.Insert(1, "PALLETS");
            dstrctCertQuantityUnit.Items.Insert(2, "Kg");
            dstrctCertQuantityUnit.SelectedIndex = 0;
        }

        private void generateDstrCertBtn_Click(object sender, EventArgs e)
        {

            //First we verify that all the input fields have valid information
            if (dstrctCertExtractionDate.Checked == false) { reportError(EXTRACTION_DATE_NOT_SELECTED_ERROR); return; }
            if (dstrctCertCompanyField.Text == Constants.EMPTY_TEXT) { reportError(COMPANY_NOT_SELECTED_ERROR); return; }
            if (dstrctCertCntactPersonField.Text == Constants.EMPTY_TEXT) { reportError(CONTACT_PERSON_NOT_INSERTED_ERROR); return; }
            if (dstrctCertCntactNumField.Text == Constants.EMPTY_TEXT) { reportError(CONTACT_NUMBER_NOT_INSERTED_ERROR); return; }
            if (dstrctCertEmailAddressField.Text == Constants.EMPTY_TEXT) { reportError(EMAIL_NOT_INSERTED_ERROR); return; }
            if (dstrctCertDescripOfProdField.Text == Constants.EMPTY_TEXT) { reportError(PRODUCT_DESCRIPTION_NOT_INSERTED_ERROR); return; }
            if (dstrctCertQuantityNumBox.Value == Constants.DECIMAL_ZERO) { reportError(PRODUCT_QUANTITY_NOT_INSERTED_ERROR); return; }
            if (dstrctCertQuantityUnit.SelectedItem == null) { reportError(QUANTITY_UNITS_NOT_SELECTED_ERROR); return; }

             _destructionCertificatesModel.generateCertificate();
 
           

        }

        private void dstrctCertCompanyField_SelectedIndexChanged(object sender, EventArgs e)
        {
            _destructionCertificatesModel.Company_Selected();
        }
        private void dstrctCertCompanyField_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            _destructionCertificatesModel.Company_Selected();
        }

        private void dstrctCertCompanyField_Leave(object sender, EventArgs e)
        {
            _destructionCertificatesModel.Company_Selected();
        }

        private void dstcrtNewCompanyCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            _destructionCertificatesModel.FieldSettings();
        }


    }
}
