using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Green_Enviro_App
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void loginBtn_Click(object sender, EventArgs e)
        {

            bool validLogin = verifyCredentials();

            if (validLogin)
            {
                Main_Form _mainForm = new Main_Form();
                _mainForm.Activate();
                _mainForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Incorrect Credentials", "ERROR!",
                MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation);
            }
   
        }

        private bool verifyCredentials() 
        {

            if ((usernameField.Text == "Eli") && (passwordField.Text == "Eli"))
            {
                return true;
            }
            else
            {
                return false;
            } 
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }
    }
}
