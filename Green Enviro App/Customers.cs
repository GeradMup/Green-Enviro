using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TableCols = Green_Enviro_App.Database.CustomersTableColumns;
namespace Green_Enviro_App
{
	public partial class Customers : Form
	{

        //Here we generate the database so as to interact with the database
        Database _database;
        //Here we generate a data table so as to interact with the tables of the database
        DataTable _data_table = new DataTable();
        BindingSource _binding_source = new BindingSource();
        NewCustomer _new_customer;
        Receipt _receipt;

        /*
         * Loading the database table for the new users into the class 
         */
        public Customers(Main_Form main, Database _db, Receipt receipt)
        {
            InitializeComponent();
            _database = _db;
            this.Owner = main;
            _receipt = receipt;
            _new_customer = new NewCustomer(this, main, _database, _receipt);
            LoadCustomersDataTable();
        }

        public void ActivateForm()
        {
            this.Owner.Enabled = false;
            this.Activate();
            this.Enabled = true;
            this.Show();
        }

        private void Exit()
        {
            ClearFields();
            //_receipt.ResetReceipt();
            this.Owner.Enabled = true;
            this.Owner.Show();
            this.Hide();
            this.Enabled = false;
        }

        private void ClearFields()
        {
            CustomersName.Text = "";
            CustomersSurname.Text = "";
            CustomersIdentification.Text = "";
        }
        /*
         * Loading the Users data table from the database at run time 
         */
        /// <summary>Loads the customers data table.</summary>
        public void LoadCustomersDataTable()
        {
            //Gets all user details and stores them in a DataTable 
            _data_table = _database.selectAll(Database.Tables.Customers);
            _data_table.Columns.RemoveAt(_data_table.Columns.Count - 1);
            _binding_source.DataSource = _data_table;
            CustomersDataGridView.DataSource = _binding_source;
        }

        public void filterCustomersTable(string condition, string value) 
        {
            _binding_source.Filter = string.Format("{0} like '%{1}%'", condition, value);
            CustomersDataGridView.Refresh();
        }

		private void CustomersDoneBtn_Click(object sender, EventArgs e)
		{
           // _receipt.setupCustomerList();
            LoadCustomersDataTable();
            Exit();
		}

		private void CustomersName_TextChanged(object sender, EventArgs e)
		{
            string _name_column_header = "Name";
            string _customer_name = CustomersName.Text;
            filterCustomersTable(_name_column_header, _customer_name);
		}

		private void CustomersSurname_TextChanged(object sender, EventArgs e)
		{
            string _surname_column_header = "Surname";
            string _customer_surname = CustomersSurname.Text;
            filterCustomersTable(_surname_column_header, _customer_surname);
        }

		private void CustomersIdentification_TextChanged(object sender, EventArgs e)
		{
            string _id_column_header = "ID";
            string _customer_id = CustomersIdentification.Text;
            filterCustomersTable(_id_column_header, _customer_id);
        }

		private void CustomersNewCustomer_Click(object sender, EventArgs e)
		{
            _new_customer.ActivateForm(false);
		}

		private void CustomersDeleteBtn_Click(object sender, EventArgs e)
		{
            int _current_row = CustomersDataGridView.CurrentCell.RowIndex;
            string customerNumber = CustomersDataGridView[0, _current_row].Value.ToString();

            Int32 _rows_affected = _database.delete<TableCols>(Database.Tables.Customers, TableCols.CustomerNumber,customerNumber);
            if (_rows_affected == 1)
            {
                LoadCustomersDataTable();
                CustomMessageBox mb = new CustomMessageBox(this, "Success!", "Customer Deleted");
            }
        }

		private void CustomersEditBtn_Click(object sender, EventArgs e)
		{
            if (CustomersDataGridView.SelectedCells.Count == 0) 
            {
                CustomMessageBox mb = new CustomMessageBox(this, CustomMessageBox.error, "Please select a customer to edit");
                return;
            }

            NewCustomer.CustomerInfo editCustomer = new NewCustomer.CustomerInfo();

            int _current_row = CustomersDataGridView.CurrentCell.RowIndex;
            editCustomer._number = CustomersDataGridView[0, _current_row].Value.ToString();
            editCustomer._id = CustomersDataGridView[1, _current_row].Value.ToString();
            editCustomer._name = CustomersDataGridView[2, _current_row].Value.ToString();
            editCustomer._surname = CustomersDataGridView[3, _current_row].Value.ToString();
            editCustomer._cell = CustomersDataGridView[4, _current_row].Value.ToString();
            editCustomer._address = CustomersDataGridView[5, _current_row].Value.ToString();

            string _path_to_id_picture = @"..//..//Customers//" + editCustomer._number + ".jpg";
            Image _id_picture = Image.FromFile(_path_to_id_picture);
            editCustomer._image = _id_picture;

            _new_customer.ActivateForm(true, editCustomer);
        }
	}
}