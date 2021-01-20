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
using System.IO;
using System.Diagnostics;

namespace Green_Enviro_App
{
	/// <summary>
	///   <br />
	/// </summary>
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


	/// <summary>
	/// Class for handling all the Login related tasks.  
    /// <br />
	/// </summary>
	public partial class LoginForm : Form
    {

        //Creates a variable of type Database
        static Database _database;

        //Creates the main form for the program
        Main_Form _mainForm;

        //Instance to view user data table for deletion
        static UserDatabaseForm _user_db_deletion;


        //Creates a single instance of the CreateAccount class
        CreateAccount _account;

        //Master Password (Changeable depending on the devs)
        const string _master_password = "1234";

        //Encryption instantiation 
        InformationEncryption _client_password = new InformationEncryption();

        string _sync_exe_path = @"..//..//..//Green Enviro Sync//bin//Debug//Green Enviro Sync.exe";

        bool _main_program_pass = false;
        public LoginForm(string[] args)
        {

            if (args.Length > 0)
            {
                _main_program_pass = true;
                
            }

            InitializeComponent();

            //Creates an Instance of the Database class
            _database = new Database();

            //Creates the main form for the program
            _mainForm = new Main_Form(_database);

            //Creates a new instances of UserDatabaseForm class
            _user_db_deletion = new UserDatabaseForm(_database);

            //Creates a new instance of CreateAccoutn class
            _account = new CreateAccount(_database, _user_db_deletion);

            //This is in order to render passwords into characters as to hide them
            //passwordField.PasswordChar = '*';
        }

        //********************************************************************************************************

        void PromptDatabaseSnyc()
        {
            //First open the Sync App to prompt users if they want to synchronize data 
            string _absolute_path = Path.GetFullPath(_sync_exe_path);
            Process.Start(_absolute_path);
            this.Close();
        }

        //********************************************************************************************************

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
            bool _user_exists = false;
            InformationEncryption _decryption = new InformationEncryption();
            List<Credentials> _all_credentials = _account._credentials;

            int index = 0;

            while (index < _all_credentials.Count) 
            {

                if (_all_credentials[index].user_name.Contains(usernameField.Text)) 
                {
                    _user_name = _all_credentials[index].user_name;
                    _user_exists = true;
                    break;
                }
                index++;
            }

			if (_user_exists) 
            {
                // First Decrypt the password at the correct index and the check if the entered password matches
                string _decrypted_psword = _decryption.Decrypt(_all_credentials[index].password);
                if (_decrypted_psword == passwordField.Text)
                {
                    return true;
                }
            }
            return false;
        }

        private void login() 
        {
            if (_main_program_pass == true) 
            {
                this.Hide();
                _mainForm.Activate();
                _mainForm.Show();
                return;
            }

            if (_main_program_pass == false)
            {
                bool validLogin = verifyCredentials();
				if (validLogin) 
                {
                    PromptDatabaseSnyc();
                }
                
            }
            else
            {
                MessageBox.Show("Incorrect Credentials", "ERROR!",
                MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation);
                //_client_password.PrintCryptography(passwordField.Text);
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
            bool _entered_admin_psword = AdminPass();
            OpenCreateAccountFrom(_entered_admin_psword);
        }
        private bool AdminPass()
        {
            string content = Interaction.InputBox("Enter Master Password: ", "Administrator", default);
            if (content == _master_password)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void OpenCreateAccountFrom(bool _pswrd)
        {
            bool _correct_admin_psword = _pswrd;
            if (_correct_admin_psword)
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
        private void checkBox_Show_Hide_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_Show_Hide.Checked)
            {
                passwordField.UseSystemPasswordChar = true;
            }
            else
            {
                passwordField.UseSystemPasswordChar = false;
            }
        }

        private void AccountRemovalField_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //Firstly when the link is clicked upon request
            bool _admin_password = AdminPass();
            OpenDeleteAccountForm(_admin_password);

        }

        private void OpenDeleteAccountForm(bool _pswrd)
        {
            bool _correct_admin_psword = _pswrd;
            if (_correct_admin_psword)
            {
                // MessageBox.Show("Correct master Password", "Administrator", MessageBoxButtons.OK);
                //_user_db_deletion.BindDataGridToUserTable();
                _user_db_deletion.Activate();

                _user_db_deletion.Show();
            }
            else
            {
                MessageBox.Show("Incorrect master password", "Administrator", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

		private void LoginForm_Activated(object sender, EventArgs e)
		{
            if (_main_program_pass) 
            {
                login();
            }
		}
	}
}
