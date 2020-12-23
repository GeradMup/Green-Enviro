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
        //Variables
        string _message = "";
        string _title = "";

        //Master Password
        const string _admin_master_password = "1234";

        //Error messages
        const string _error = "Error!";
        const string _empty_user_name_entered = "User name cannot be empty";
        const string _user_name_error =  "User name already exist";
        const string _empty_password_entered = "Password cannot be empty";
        const string _empty_confirm_password_entered = "Confirm password cannot be empty";
        const string _password_error = "Passwords do not match";
        const string _empty_email_entered = "Email cannot be empty";
        const string _email_address_error = "Email address already used by another account";
        const string _empty_master_password_entered = "Master password cannot be empty";
        const string _incorrect_master_psword = "Incorrect Master password entered";

        //Successfull messages
        const string _success = "Complete!";
        const string _all_fields_entered = "Accounts succesfully created";
        
        // Empty textbox
        const string _empty_txtbox = "";

        // Credentials instance created
        public List<Credentials> _credentials = new List<Credentials>();

        public CreateAccount()
        {
            InitializeComponent();
            //Creates username and password G,G for development purposes
            defaultUser();

            //LOAD UP USER INFO FROM HE DATABASE
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

        // Function verifying the validity of all information inputted
        private Tuple<bool, string, string> verifyAccount()
        {
            string _message_type = "";
            string _message = "";
            bool _all_good = false;
            var _repeated_accounts = isAccountInfoRepeated();

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
            else if (confirmPasswordField.Text != newPasswordField.Text)
            {
                _message_type = _error;
                _message = _password_error;
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
            else if (_repeated_accounts.Item1 == true)
            {
                _message_type = _error;
                _message = _user_name_error;
                _all_good = false;
            }
            else if (_repeated_accounts.Item2 == true)
            {
                _message_type = _error;
                _message = _email_address_error;
                _all_good = false;
            }
            else if (masterPasswordField.Text != _admin_master_password)
            {
                _message_type = _error;
                _message = _incorrect_master_psword;
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
            var _acc_creation_validity = verifyAccount();
            MessageBoxButtons _buttons;
            MessageBoxIcon _icon;

            _message = _acc_creation_validity.Item3;
            _title = _acc_creation_validity.Item2;
            _buttons = MessageBoxButtons.OK;

            if (_acc_creation_validity.Item1)
            {
                _icon = MessageBoxIcon.None;
                addNewUser();
                MessageBox.Show(_message, _title, _buttons, _icon);
                returnToLoginForm();
            }
            else
            {
                _icon = MessageBoxIcon.Error;
                MessageBox.Show(_message, _title, _buttons, _icon);
            }
            
        }
        

        private void returnToLoginForm()
        {
            this.Hide();
            ClearCredentials();
        }
        
        private void addNewUser()
        {
            //Encrypting the password and storing not the password itself but its encryption using a 196 bit cipher key
            InformationEncryption __encryption = new InformationEncryption();
            string _encrypted_user_password = __encryption.Encrypt(newPasswordField.Text);
            Credentials _new_user = new Credentials(newUserNameField.Text, _encrypted_user_password, emailAddressField.Text);
            _credentials.Add(_new_user);
        }

        //This function needs to be deleted
        private void defaultUser()
        {
            InformationEncryption __encryption = new InformationEncryption();
            string _encrypted_user_password = __encryption.Encrypt("G");
            Credentials _new_user = new Credentials("G", _encrypted_user_password, "G");
            _credentials.Add(_new_user);
        }
        private Tuple<bool,bool> isAccountInfoRepeated()
        {
            int index = 0;
            bool _user_name_exist = true;
            bool _email_address_exist = true;
            bool isEmpty = !_credentials.Any();
            //If The list of credentials is empty then there are no user name that exist
            if (isEmpty)
            {
                _user_name_exist = false;
                _email_address_exist = false;
            }
            //If the list of credentials is not empty then verify if the user name exist already
            else
            {
                for (index = 0; index < _credentials.Count; index++)
                {
                    if (_credentials[index].user_name.Contains(newUserNameField.Text))
                    {
                        _user_name_exist = true;
                        break;
                    }
                    else if (_credentials[index].email.Contains(emailAddressField.Text))
                    {
                        _email_address_exist = true;
                        break;
                    }
                    else 
                    {
                        _user_name_exist = false;
                        _email_address_exist = false;

                    } 
                }

            }

            Tuple<bool, bool> _account_info = new Tuple<bool, bool>(_user_name_exist, _email_address_exist);
            return _account_info;
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
