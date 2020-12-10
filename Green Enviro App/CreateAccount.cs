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
        public List<string> _user_name_list = new List<string>();
        public List<string> _password_list = new List<string>();
        List<string> _confirm_password_list = new List<string>();
        List<string> _email_address_list = new List<string>();
        List<string> _master_password_list = new List<string>();

        public CreateAccount()
        {
            InitializeComponent();
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            returnToLoginForm();
        }

        private void newAccountButton_Click(object sender, EventArgs e)
        {
            accountCreationVerification();
        }
        private void newAccountBtn_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Returns to Login From if the user presses the enter key while the CreateAccount Form is active
            if (e.KeyChar == (char)Keys.Enter)
            {
                accountCreationVerification();
            }
        }
        private bool verifyAccountCreation()
        {
            if (newUserNameField.Text == _empty_txtbox || newPasswordField.Text == _empty_txtbox || confirmPasswordField.Text == _empty_txtbox || emailAddressField.Text == _empty_txtbox || masterPasswordField.Text == _empty_txtbox || newPasswordField.Text != confirmPasswordField.Text)
            {
                return false;
            } 
            else
            {
                return true;
            }
        }
        private void accountCreationVerification()
        {
            bool _acc_creation_validity = verifyAccountCreation();

            if (_acc_creation_validity)
            {
                string _message = "Account Succesfully Created";
                string _title = "Create Account";
                MessageBoxButtons _buttons = MessageBoxButtons.OK;
                MessageBox.Show(_message, _title,_buttons);
                newAccountCredentials();
                returnToLoginForm();

            } 
            else if (newPasswordField.Text != confirmPasswordField.Text)
            {
                string _message = "Passwords do not match";
                string _title = "ERROR!";
                MessageBoxButtons _buttons = MessageBoxButtons.OK;
                MessageBoxIcon _icon = MessageBoxIcon.Exclamation;
                MessageBox.Show(_message, _title, _buttons, _icon);
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

        private void returnToLoginForm()
        {
            LoginForm _accform_to_loginform = new LoginForm();
            _accform_to_loginform.Activate();
            _accform_to_loginform.Show();
            this.Hide();
        }
        
        private void newAccountCredentials()
        {
            _user_name_list.Add(newUserNameField.Text);
            _password_list.Add(newPasswordField.Text);
            _confirm_password_list.Add(confirmPasswordField.Text);
            _email_address_list.Add(emailAddressField.Text);
            _master_password_list.Add(masterPasswordField.Text);
            _user_name_list.ForEach(Console.WriteLine);
            _password_list.ForEach(Console.WriteLine);
            _confirm_password_list.ForEach(Console.WriteLine);
            _email_address_list.ForEach(Console.WriteLine);
            _master_password_list.ForEach(Console.WriteLine);
        }
    }
}
