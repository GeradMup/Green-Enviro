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
        /*
         * Loading the database table for the new users into the class 
         */
        public Customers(Form owner, Database _db)
        {
            InitializeComponent();
            _database = _db;
            this.Owner = owner;
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
            CustomersCustomerNumber.Value = (decimal)0;
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

        public void filterByName() 
        {
            string _customer_name = CustomersName.Text;
            _binding_source.Filter = string.Format("Name like '%{0}%'", _customer_name);
            CustomersDataGridView.Refresh();
        }

		private void CustomersDoneBtn_Click(object sender, EventArgs e)
		{
            Exit();
		}

		private void CustomersName_TextChanged(object sender, EventArgs e)
		{
            filterByName();
		}
	}
}