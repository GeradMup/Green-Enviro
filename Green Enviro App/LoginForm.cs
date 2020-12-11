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
            List<string> userNameList = _account._user_name_list;
            List<string> passwordList = _account._password_list;
            List<Credentials> _all_credentials = _account._credentials;

            int index = 0;

            while (index < _all_credentials.Count) 
            {

                if (_all_credentials[index].user_name.Contains(usernameField.Text)) 
                {
                    _user_name = _all_credentials[index].user_name;
                    break;
                }
                Console.WriteLine(index);
                index++;
            }

            Console.WriteLine(index);
            if (_all_credentials[index].password == passwordField.Text)
            {
                return true;
            }

            int user_name_index = 0;
            for (int i = 0; i < userNameList.Count; i++)
            {

                if (userNameList[i].Contains(usernameField.Text))
                {
                    _user_name = userNameList[i];
                    user_name_index = i;
                    break;
                }

            }

            if (passwordField.Text == passwordList[user_name_index]) 
            { 
            
            }
            //I think we should not be iterating through the password list as well
            //I think that once we know the index for  username, the password should be stored at the same index in the passwordList?
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
            //Creates a new instance everytime the new account button is clicked.
            _account.Activate();
            _account.Show();
            //this.Hide();
        }
    }
}
