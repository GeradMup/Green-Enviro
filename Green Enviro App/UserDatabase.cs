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

        public UserDatabaseForm(Database _db)
        {
            InitializeComponent();
            _database = _db;
            //BindDataGridToUserTable();
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

            int _accountId_number_column = 0;

            foreach (DataRow row in _data_table.Rows)
            {
                //Selects the users account ID and adds to the drop down list on the User Database form
                accountIdList.Items.Add(row[_accountId_number_column]);
            }
        }
    }
}
