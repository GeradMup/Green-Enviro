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
        const string _permission_level = "Permission Level not selected";

        //Successfull messages
        const string _success = "Complete!";
        const string _all_fields_entered = "Accounts succesfully created";
        
        // Empty textbox
        const string _empty_txtbox = "";

        // Credentials instance created
        public List<Credentials> _credentials = new List<Credentials>();

        // Lets make a Data Table for the new user
        Database _database;
        DataTable _user;
        UserDatabaseForm _user_database ;

        /*
         * Create Account for new Employee users 
         */
        public CreateAccount(Database _db,UserDatabaseForm _user_db)
        {
            InitializeComponent();
            //Creates username and password G,G for development purposes
            defaultUser();
            _database = _db;
            _user_database = _user_db;
            //LOAD UP USER INFO FROM HE DATABASE
            LoadDataBase();
            SelectPermissionLevel();
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
            else if (userPermissionLvlBx.SelectedIndex == 0)
            {
                _message_type = _error;
                _message = _permission_level;
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
        
        /*
         * Verifying that all the information for the account creation is inputted
         * and therefore can generate a new user for the company.
         */
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
                CustomMessageBox msg = new CustomMessageBox(_title,_message);
                _user_database.LoadUserDataTable();
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
        
        /*
         * Adding a new user to the Database and list to contiuously update the valid account for use. 
         */
        private void addNewUser()
        {
            //Encrypting the password and storing not the password itself but its encryption using a 196 bit cipher key
            InformationEncryption __encryption = new InformationEncryption();
            string _encrypted_user_password = __encryption.Encrypt(newPasswordField.Text);
            int _permission_level_selected = 0;

            if (userPermissionLvlBx.SelectedItem != null)
            {
                 _permission_level_selected = int.Parse(userPermissionLvlBx.SelectedItem.ToString());
            }
            else return;

                // Alright here we will add the code so that we insert into the DB once we enter a new user
                // To add a new user its the same principle as adding a row 
                _database.InsertNewUser(newUserNameField.Text, _encrypted_user_password, emailAddressField.Text,_permission_level_selected);// Do not know if the list requires permission lvl

            // This is still the original list storage way to keep track of new users
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
        
        /*
         *  Verifies if the users account information are repeated. 
         */
        private Tuple<bool,bool> isAccountInfoRepeated()
        {
            int index = 0;
            bool _user_name_exist = true;
            bool _email_address_exist = true;
            bool isEmpty = !_credentials.Any();
            List<string> _store_user_name = new List<string>();

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

        /*
         * Functions that clear all textboxes  
         */
        private void ClearCredentials()
        {
            newUserNameField.Clear();
            newPasswordField.Clear();
            confirmPasswordField.Clear();
            emailAddressField.Clear();
            masterPasswordField.Clear();
            userPermissionLvlBx.SelectedIndex = 0;
        }

        private void ShowUsers()
        {
            //Display the amount of user currently in the Database
            _user = _database.SelectAll("Users");
           //MessageBox.Show("All Current Users " + _user.Rows.Count.ToString());
        }

        /*
         * Functions that shows the database of the Users account on the console 
         */
        private void PrintDataTable()
        {
            _user = _database.SelectAll("Users");
            DataRow[] currentRows = _user.Select(
    null, null, DataViewRowState.CurrentRows);

            if (currentRows.Length < 1)
                Console.WriteLine("No Current Rows Found");
            else
            {
                foreach (DataColumn column in _user.Columns)
                    Console.Write("\t{0}", column.ColumnName);

                Console.WriteLine("\tRowState");

                foreach (DataRow row in currentRows)
                {
                    foreach (DataColumn column in _user.Columns)
                        Console.Write("\t{0}", row[column]);

                    Console.WriteLine("\t" + row.RowState);
                }
            }
        }
        
        /*
         * Loading the constructor with the database information of any Users already entered
         * therefore at runtime, all required information are available.
         */
        private void LoadDataBase()
        {
            _user = _database.SelectAll("Users");
            string _db_username = "";
            string _db_email = "";
            string _db_psword = "";
            int index = 0;
            int _db_permission_level = 0;
            foreach (DataRow row in _user.Rows)
            {
                //Here we are checking the username and email address of people using the database and the user already within
                _db_username = _user.Rows[index].Field<string>("Username");
                _db_psword = _user.Rows[index].Field<string>("Password");
                _db_email = _user.Rows[index].Field<string>("Email");
                _db_permission_level = _user.Rows[index].Field<int>("PermissionLevel");
                Credentials _load_user_from_db = new Credentials(_db_username,_db_psword,_db_email);
                _credentials.Add(_load_user_from_db);
                index++;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        /*
         * Inserts the permission level to the permission level combo box.
         */
        private void SelectPermissionLevel()
        {
            userPermissionLvlBx.DropDownStyle = ComboBoxStyle.DropDownList;
            userPermissionLvlBx.Items.Insert(0, "Select Permission Level");
            userPermissionLvlBx.Items.Insert(1, "1");
            userPermissionLvlBx.Items.Insert(2, "2");
            userPermissionLvlBx.Items.Insert(3, "3");
            userPermissionLvlBx.SelectedIndex = 0;
        }
    }
}
