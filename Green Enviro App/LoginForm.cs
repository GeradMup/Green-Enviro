using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace Green_Enviro_App
{

    public struct Credentials 
    {
        public Credentials(string _name, string psword, string mail) 
        {
            user_name = _name;
            password = psword;
            email = mail;
        }

        public string user_name;
        public string password;
        public string email;
    }
    public partial class LoginForm : Form
    {

        //Creates a single instance of the CreateAccount class
        CreateAccount _account = new CreateAccount();

        //Master Password (Changeable depending on the devs)
        const string _master_password = "1234";
        

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
            List<Credentials> _all_credentials = _account._credentials;

            int index = 0;

            while (index < _all_credentials.Count) 
            {

                if (_all_credentials[index].user_name.Contains(usernameField.Text)) 
                {
                    _user_name = _all_credentials[index].user_name;
                    break;
                }
                index++;
            }

            if (_all_credentials[index].password == passwordField.Text)
            {
                return true;
            }
            else return false;

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
            AdminPass();
        }
        private void AdminPass()
        {
            string content = Interaction.InputBox("Enter Master Password: ", "Administrator", default);
            if (content == _master_password)
            {
                //Creates a new instance everytime the new account button is clicked.
                _account.Activate();
                _account.Show();
            }
            else
            {
                MessageBox.Show("Incorrect master password", "Administrator", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
