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
    
    public partial class CreateAccount : Form
    {
        const string _empty_txtbox = "";
        public CreateAccount()
        {
            InitializeComponent();
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            LoginForm _cancel_account_creation = new LoginForm();
            _cancel_account_creation.Activate();
            _cancel_account_creation.Show();
            this.Hide();
        }

        private void newAccountButton_Click(object sender, EventArgs e)
        {
            returnToLoginForm();
        }
        private void newAccountBtn_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Returns to Login From if the user presses the enter key while the CreateAccount Form is active
            if (e.KeyChar == (char)Keys.Enter)
            {
                returnToLoginForm();
            }
        }
        private bool verifyAccountCreation()
        {
            if (newUserNameField.Text == _empty_txtbox || newPasswordField.Text == _empty_txtbox || confirmPasswordField.Text == _empty_txtbox || emailAddressField.Text == _empty_txtbox || masterPasswordField.Text == _empty_txtbox)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        private void returnToLoginForm()
        {
            bool _acc_creation_validity = verifyAccountCreation();

            if (_acc_creation_validity)
            {
                string _message = "Account Succesfully Created";
                string _title = "Account Creation";
                MessageBoxButtons _buttons = MessageBoxButtons.OK;
                MessageBox.Show(_message, _title,_buttons);
                LoginForm _account_created = new LoginForm();
                _account_created.Activate();
                _account_created.Show();
                this.Hide();
            }
            else
            {
                string _message = "Missing Credentials";
                string _title = "ERROR!";
                MessageBoxButtons _buttons = MessageBoxButtons.OK;
                MessageBoxIcon _icon = MessageBoxIcon.Exclamation;
                MessageBox.Show(_message, _title,_buttons,_icon);
            }

        }
    }
}
