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
	public partial class Customers : Form
	{

        //Here we generate the database so as to interact with the database
        Database _database;
        //Here we generate a data table so as to interact with the tables of the database
        DataTable _data_table = new DataTable();
        string _customers_table_name = "Customers";
        BindingSource _binding_source = new BindingSource();
        NewCustomer _new_customer;

        /*
         * Loading the database table for the new users into the class 
         */
        public Customers(Main_Form main, Database _db, Receipt _receipt)
        {
            InitializeComponent();
            _database = _db;
            this.Owner = main;
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
            _data_table = _database.SelectAll(_customers_table_name);
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
            _new_customer.ActivateForm();
		}

		private void CustomersDeleteBtn_Click(object sender, EventArgs e)
		{
            int _current_row = CustomersDataGridView.CurrentCell.RowIndex;
            string _customer_number = CustomersDataGridView[0, _current_row].Value.ToString();

            string _deletion_condition = "CustomerNumber = '" + _customer_number + "'";

            Int32 _rows_affected = _database.DeleteFromDatabase(_customers_table_name, _deletion_condition);
            if (_rows_affected == 1)
            {
                LoadCustomersDataTable();
                CustomMessageBox mb = new CustomMessageBox(this, "Success!", "Customer Deleted");
            }
        }
	}
}