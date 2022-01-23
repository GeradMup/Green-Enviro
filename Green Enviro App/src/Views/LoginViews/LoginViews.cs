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
		/// <summary>
        /// Initializes a new instance of the <see cref="Credentials" /> struct.
        /// The Struct contains required information to create a new user
        /// </summary>
		/// <param name="_name">The name.</param>
		/// <param name="psword">The psword.</param>
		/// <param name="mail">The mail.</param>
		public Credentials(string _name, string psword, string mail, int permission) 
        {
            user_name = _name;
            password = psword;
            email = mail;
            user_permission_level = permission;
        }

        public string user_name;
        public string password;
        public string email;
        public int user_permission_level;
    }


	/// <summary>
	/// Class for handling all the Login related tasks.  
    /// <br />
	/// </summary>
	public partial class LoginViews : Form
    {
        bool _application_runnig = true;

        //Creates the main form for the program
        int _user_permission_level = 0;

        List<Credentials> _all_credentials;
        string _sql_server_path = @"..//..//..//Close SQL Server//bin//Debug//Close SQL Server.exe";
        bool _main_program_pass = false;
        bool _already_logged_in = false;
        private int userPermissionLevel = -1;
		
        /// <summary>
		/// Initializes a new instance of the <see cref="LoginViews"/> class.
		/// </summary>
		/// <param name="args">Command line arguments.</param>
		public LoginViews(string[] args)
        { 
            if (args.Length > 0) userPermissionLevel = int.Parse(args[0]); 
            InitializeComponent();
            intializeLoginForm();  
        }

		/// <summary>
		/// Handles the KeyPress event of the LoginForm control.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The <see cref="KeyPressEventArgs"/> instance containing the event data.</param>
		private void LoginForm_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Try to login if the uses presses the enter key while the login form is active
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
            

            int index = 0;

            while (index < _all_credentials.Count) 
            {

                if (_all_credentials[index].user_name.Contains(Username.Text)) 
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
                if (_decrypted_psword == Password.Text)
                {
                    _user_permission_level = _all_credentials[index].user_permission_level;
                    return true;
                }
            }
            return false;
        }

        private void login() 
        {
            if (_already_logged_in) 
            {
                bool validLogin = verifyCredentials();
				if (validLogin) 
                {
					//StartMainProgram();
                }
            }

            if (_main_program_pass == true) 
            {
                _main_program_pass = false;
                _already_logged_in = true;
               // StartMainProgram();
                return;
            }

            if (_main_program_pass == false)
            {
                bool validLogin = verifyCredentials();
				if (validLogin) 
                {
                    promptDatabaseSnyc();
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

        private void clear_button_Click(object sender, EventArgs e)
        {
            clearLoginFields();
        }

        private void clearLoginFields()
        {
            Username.Clear();
            Password.Clear();
        }

        private void checkBox_Show_Hide_CheckedChanged(object sender, EventArgs e)
        {
            if (ShowPassword.Checked)
            {
                Password.UseSystemPasswordChar = true;
            }
            else
            {
                Password.UseSystemPasswordChar = false;
            }
        }

		private void LoginForm_Activated(object sender, EventArgs e)
		{
            if (_main_program_pass) 
            {
                login();
            }
		}

		private void LoginForm_FormClosing(object sender, FormClosingEventArgs e)
        { 
            Application.Exit();
        }


	}
}
