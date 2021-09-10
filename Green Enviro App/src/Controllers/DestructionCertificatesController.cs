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

        private void generateDstrCertBtn_Click(object sender, EventArgs e)
        {
            if ((_user_permission_level == 3) || (_user_permission_level == 4) || (_user_permission_level == 5))
            {
                _destructionCertificatesModel.generateCertificate();
            }
            else
            {
                PermissionDenied();
            }
        }

        private void dstrctCertCompanyField_SelectedIndexChanged(object sender, EventArgs e)
        {
            _destructionCertificatesModel.Company_Selected();
        }
        private void dstrctCertCompanyField_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            _destructionCertificatesModel.Company_Selected();
        }
        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            _destructionCertificatesModel.FieldSettings();
        }

        private void dstrctCertCompanyField_Leave(object sender, EventArgs e)
        {
            _destructionCertificatesModel.Company_Selected();
        }

    }
}
