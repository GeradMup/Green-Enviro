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
        //Error messages
        const string _error = "Error!";
        const string _empty_user_name_entered = "User name field cannot be empty";
        const string _empty_password_entered = "Password field cannot be empty";
        const string _empty_confirm_password_entered = "Confirm password field cannot be empty";
        const string _password_error = "Passwords do not match";
        const string _empty_email_entered = "Email field cannot be empty";
        const string _empty_master_password_entered = "Master password field cannot be empty";

        //Successfull messages
        const string _success = "Complete!";
        const string _all_fields_entered = "Accounts succesfully created";
        
        // Empty textbox
        const string _empty_txtbox = "";

        // Credentials struct
        public List<Credentials> _credentials = new List<Credentials>();

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
            ClearCredentials();
        }
        private void newAccountBtn_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Returns to Login From if the user presses the enter key while the CreateAccount Form is active
            if (e.KeyChar == (char)Keys.Enter)
            {
                accountCreationVerification();
                ClearCredentials();
            }
        }

        //Suggested alternative
        private Tuple<bool, string, string> verifyAccount()
        {
            string _message_type = "";
            string _message = "";
            bool _all_good = false;

            if (newUserNameField.Text == _empty_txtbox)
            {
                _message_type = _error;
                _message = _empty_user_name_entered;
                _all_good = false;
            }
            else if (newPasswordField.Text == _empty_txtbox) 
            {
                _message_type = _error;
                _message = _empty_password_entered;
                _all_good = false;
            }
            else if (confirmPasswordField.Text == _empty_txtbox)
            {
                _message_type = _error;
                _message = _empty_confirm_password_entered;
                _all_good = false;
            }
            else if (emailAddressField.Text == _empty_txtbox)
            {
                _message_type = _error;
                _message = _empty_email_entered;
                _all_good = false;
            }
            else if (masterPasswordField.Text == _empty_txtbox)
            {
                _message_type = _error;
                _message = _empty_master_password_entered;
                _all_good = false;
            }
            else if (confirmPasswordField.Text != newPasswordField.Text)
            {
                _message_type = _error;
                _message = _password_error;
                _all_good = false;
            }
            else
            {
                _message_type = _success;
                _message = _all_fields_entered;
                _all_good = true;
            }

            Tuple<bool, string, string> _new_tuple = new Tuple<bool, string, string>(_all_good, _message_type, _message);
            return _new_tuple;

        }
        private void accountCreationVerification()
        {
            //bool _acc_creation_validity = verifyAccountCreation();
            var _acc_creation_validity = verifyAccount();
            string _message = "";
            string _title = "";
            MessageBoxButtons _buttons;
            MessageBoxIcon _icon;

            if (_acc_creation_validity.Item1)
            {
                _message = _acc_creation_validity.Item3;
                _title = _acc_creation_validity.Item2;
                _buttons = MessageBoxButtons.OK;
                MessageBox.Show(_message, _title,_buttons);
                newAccountCredentials();
                returnToLoginForm();
            }
            else
            {
                _message = _acc_creation_validity.Item3;
                _title = _acc_creation_validity.Item2;
                _buttons = MessageBoxButtons.OK;
                _icon = MessageBoxIcon.Exclamation;
                MessageBox.Show(_message, _title,_buttons,_icon);
            }

        }
        

        private void returnToLoginForm()
        {
            this.Hide();
        }
        
        //Maybe this function could be named differently. Maybe "addNewUser?"
        private void newAccountCredentials()
        {
            Credentials _new_user = new Credentials(newUserNameField.Text, newPasswordField.Text, emailAddressField.Text);
            _credentials.Add(_new_user);
        }

        private void CreateAccount_Load(object sender, EventArgs e)
        {

        }
        private void ClearCredentials()
        {
            newUserNameField.Clear();
            newPasswordField.Clear();
            confirmPasswordField.Clear();
            emailAddressField.Clear();
            masterPasswordField.Clear();
        }
    }
}
