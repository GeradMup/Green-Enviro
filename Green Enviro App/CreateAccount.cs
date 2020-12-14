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
        private bool verifyAccountCreation()
        {
            //Maybe you can split these checks into different functions so that the code becomes easy to read.
            //Or we can maybe find a different way of doing this part so that the code becomes a little more readable.
            if (newUserNameField.Text == _empty_txtbox || newPasswordField.Text == _empty_txtbox || confirmPasswordField.Text == _empty_txtbox || emailAddressField.Text == _empty_txtbox || masterPasswordField.Text == _empty_txtbox || newPasswordField.Text != confirmPasswordField.Text)
            {
                return false;
            } 
            else
            {
                return true;
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
            
            }

            Tuple<bool, string, string> _new_tuple = new Tuple<bool, string, string>(_all_good, _message_type, _message);
            return _new_tuple;
        }
        private void accountCreationVerification()
        {
            bool _acc_creation_validity = verifyAccountCreation();
            string _message = "";
            string _title = "";
            MessageBoxButtons _buttons;
            MessageBoxIcon _icon;

            if (_acc_creation_validity)
            {
                //How about we have only one place within this function that does the message box pop. Right now you are repeating code. 
                _message = "Account Succesfully Created";
                _title = "Create Account";
                _buttons = MessageBoxButtons.OK;
                MessageBox.Show(_message, _title,_buttons);
                newAccountCredentials();
                returnToLoginForm();

            } 
            else if (newPasswordField.Text != confirmPasswordField.Text)
            {
                _message = "Passwords do not match";
                _title = "ERROR!";
                _buttons = MessageBoxButtons.OK;
                _icon = MessageBoxIcon.Exclamation;
                MessageBox.Show(_message, _title, _buttons, _icon);
            }
            else
            {
                _message = "Missing Credentials";
                _title = "ERROR!";
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
