using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace Green_Enviro_App
{
    public partial class UserDatabaseForm : Form
    {
        //Here we generate the database so as to interact with the database
        Database _database;
        //Here we generate a data table so as to interact with the tables of the database
        DataTable _data_table = new DataTable();
        // Lets see if with the binding source we can move
        BindingSource _binding_source = new BindingSource();
        bool _accountId_selected = false;
        string _db_table = "Users";
        string _deletion_information = "";
        int _deleted_row_index = 0;

        public UserDatabaseForm(Database _db)
        {
            InitializeComponent();
            _database = _db;
            LoadUserDataTable();
        }

        private void UserAccountsForm_Load(object sender, EventArgs e)
        {
            BindDataGridToUserTable();
        }

        private void BindDataGridToUserTable()
        {
            _data_table = _database.SelectAll("Users");
            userTableDataGridView.DataSource = _data_table.DefaultView;
            // fill the gridview to its container
            //userTableDataGridView.AutoResizeRows(DataGridViewAutoSizeRowsMode.AllCells);
            //userTableDataGridView.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            // userTableDataGridView.AutoResizeRows(DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders);
        }

        private void userDeletionCancelBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void LoadUserDataTable()
        {
            //Gets all user details and stores them in a DataTable 
            _data_table = _database.SelectAll("Users");

            accountIdList.Items.Clear();

            int _accountId_number_column = 0;

            foreach (DataRow row in _data_table.Rows)
            {
                //Selects the users account ID and adds to the drop down list on the User Database form
                accountIdList.Items.Add(row[_accountId_number_column]);
            }
        }

        private void accountIdList_SelectedIndexChanged(object sender, EventArgs e)
        {
            AccountID_Selected();
        }

        private void AccountID_Selected()
        {

            if (accountIdList.SelectedItem == null)
            {
                usernameSelectedForDeletionField.Text = "";
                passwordSelectedForDeletionField.Text = "";
                emailSelectedForDeletionField.Text = "";
                _accountId_selected = false;
                return;
            }

            string _user_account_id = accountIdList.SelectedItem.ToString();
            _db_table = "Users";
            _deletion_information = "AccountId = '" + _user_account_id + "'";
            _data_table = _database.SelectAll(_db_table);
            DataView _data_view = _data_table.DefaultView;
            DataRow[] _row = _data_table.Select(_deletion_information);

            foreach(DataRow _deleting_row in _row)
            {
                _deleted_row_index = _data_table.Rows.IndexOf(_deleting_row);
            }


            int _index = 0;

            string _accountId_username = _row[_index].Field<string>("Username");
            string _accountId_password = _row[_index].Field<string>("Password");
            string _accountId_email = _row[_index].Field<string>("Email");

            usernameSelectedForDeletionField.Text = _accountId_username;
            passwordSelectedForDeletionField.Text = _accountId_password;
            emailSelectedForDeletionField.Text = _accountId_email;

            //Here we say that if we select an Account Id and all textbox display the correct information
            //A user account is displayed and therefore can be deleted hence the variable is true
            _accountId_selected = true;
        }

        private void userDeletionBtn_Click(object sender, EventArgs e)
        {
            if (_accountId_selected == true)
            {
                DialogResult d;
                d = MessageBox.Show("Do you really want to delete this account from the system?", "User Account Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (d == DialogResult.Yes)
                {
                    _database.DeleteFromDatabase(_db_table, _deletion_information);
                    userTableDataGridView.Rows.RemoveAt(_deleted_row_index);
                    ClearUserDBFields();
                    MessageBox.Show("Account succesfully deleted");
                    LoadUserDataTable();
                    this.Hide();
                }
                if (d == DialogResult.No)
                {
                    return;
                }

            }
            else
            {
                MessageBox.Show("No Account Id selected");
            }
        }
        public void RefreshDataGridTable()
        {
            _data_table = _database.SelectAll("Users");
            //DataTable t = new DataTable();
            //_data_table.Fill(t);
            userTableDataGridView.DataSource = _data_table;
        }
        private void ClearUserDBFields()
        {
            accountIdList.SelectedItem = null;
            usernameSelectedForDeletionField.Clear();
            passwordSelectedForDeletionField.Clear();
            emailSelectedForDeletionField.Clear();
        }
    }
}
