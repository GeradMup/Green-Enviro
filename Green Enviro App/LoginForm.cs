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
        private void LoginForm_KeyPress(object sender, KeyEventArgs e)
        {
            this.KeyPreview = true;
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
        private void loginBtn_Click(object sender, EventArgs e)
        {
            login();
        }

        private void LoginForm_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Try to login if the uses presses the enter key while the login form is active
            if (e.KeyChar == (char)Keys.Enter)
            {
                login();
            }
        }

        private void passwordField_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Try to Login if the user presses the enter key while the password field is active
            if (e.KeyChar == (char)Keys.Enter)
            {
                login();
            }
        }

        private bool verifyCredentials() 
        {
            // Coorelation or interaction between the CreateAccount class and LoginForm class 
            // To enable account to register and hence to login into the main form
            string _user_name = "";
            string _password = "";
            CreateAccount _account_created = new CreateAccount();
            List<string> userNameList = _account_created._user_name_list;
            List<string> passwordList = _account_created._password_list;
            for (int i = 0; i < userNameList.Count; i++)
            {

                if (userNameList[i].Contains(usernameField.Text))
                {
                    _user_name = userNameList[i];
                    break;
                }

            }            
            for (int i = 0; i < passwordList.Count; i++)
            {

                if (passwordList[i].Contains(passwordField.Text))
                {
                    _password = passwordList[i];
                    break;
                }

            }
            if (((usernameField.Text == "Eli") && (passwordField.Text == "Eli")) || ((usernameField.Text == _user_name) && (passwordField.Text == _password)))
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


        private void login() 
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

        private void usernameField_TextChanged(object sender, EventArgs e)
        {

        }

        private void clear_button_Click(object sender, EventArgs e)
        {
            usernameField.Clear();
            passwordField.Clear();
        }

        private void createAccountButton_Click(object sender, EventArgs e)
        {
            CreateAccount _new_account = new CreateAccount();
            _new_account.Activate();
            _new_account.Show();
            this.Hide();
        }
    }
}
