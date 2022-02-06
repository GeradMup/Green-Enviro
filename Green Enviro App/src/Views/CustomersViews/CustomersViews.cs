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
using Green_Enviro_App.src.DataAccess;
using FastMember;

namespace Green_Enviro_App
{
	public partial class CustomersViews : Form
	{
        //Here we generate a data table so as to interact with the tables of the database
        DataTable _data_table = new DataTable();
        BindingSource _binding_source = new BindingSource();
        NewCustomer _new_customer;
        Receipt _receipt;

        /*
         * Loading the database table for the new users into the class 
         */

        Form parentForm;
        CustomersModel customersModel;

		/// <summary>
		/// Initializes a new instance of the <see cref="CustomersViews"/> class.
		/// </summary>
		/// <param name="cm">The cm.</param>
		public CustomersViews(CustomersModel cm)
        {
            InitializeComponent();

            customersModel = cm;
            initializeCustomers();
        }

		/// <summary>
		/// Activates the Customers form.
		/// </summary>
		public void activateForm(Form parent)
        {
            parentForm = parent;
            this.Activate();
            this.Enabled = true;
            this.Show();
            parentForm.Enabled = false;
            parentForm.Hide();
        }

        private void Exit()
        {
            ClearFields();
            //_receipt.ResetReceipt()
            this.Hide();
            this.Enabled = false;
            parentForm.Activate();
            parentForm.Enabled = true;
            parentForm.Show();
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
            //_data_table = _database.selectAll(Database.Tables.Customers);
            List<Customer> customers;
            using (DataEntities context = new DataEntities()) 
            {
                customers = context.Customers.ToList();
                string customerNum = "CustomerNumber";
                string id = "ID";
                string name = "Name";
                string surname = "Surname";
                string cell = "Cell";
                string address = "Address";

                using (ObjectReader reader = ObjectReader.Create(customers, customerNum, id, name, surname, cell, address)) 
                {
                    _data_table.Load(reader);
                }
            }

            _binding_source.DataSource = _data_table;
            CustomersDataGrid.DataSource = _binding_source;
        }

		private void CustomersNewCustomer_Click(object sender, EventArgs e)
		{
            _new_customer.ActivateForm(false);
		}

		private void CustomersDeleteBtn_Click(object sender, EventArgs e)
		{
            int _current_row = CustomersDataGrid.CurrentCell.RowIndex;
            int customerNumber = (int)CustomersDataGrid[0, _current_row].Value;
            using (DataEntities context = new DataEntities()) 
            {
                Customer customer = context.Customers.FirstOrDefault(_customer => _customer.CustomerNumber == customerNumber);

                if (customer != null) 
                {
                    context.Customers.Remove(customer);
                    context.SaveChanges();
                    LoadCustomersDataTable();
                    CustomMessageBox mb = new CustomMessageBox(this, "Success!", "Customer Deleted");
                }
            }
        }

		private void CustomersEditBtn_Click(object sender, EventArgs e)
		{
            if (CustomersDataGrid.SelectedCells.Count == 0) 
            {
                CustomMessageBox mb = new CustomMessageBox(this, CustomMessageBox.error, "Please select a customer to edit");
                return;
            }

            NewCustomer.CustomerInfo editCustomer = new NewCustomer.CustomerInfo();

            int _current_row = CustomersDataGrid.CurrentCell.RowIndex;
            editCustomer._number = CustomersDataGrid[0, _current_row].Value.ToString();
            editCustomer._id = CustomersDataGrid[1, _current_row].Value.ToString();
            editCustomer._name = CustomersDataGrid[2, _current_row].Value.ToString();
            editCustomer._surname = CustomersDataGrid[3, _current_row].Value.ToString();
            editCustomer._cell = CustomersDataGrid[4, _current_row].Value.ToString();
            editCustomer._address = CustomersDataGrid[5, _current_row].Value.ToString();

            string _path_to_id_picture = @"..//..//Customers//" + editCustomer._number + ".jpg";
            Image _id_picture = Image.FromFile(_path_to_id_picture);
            editCustomer._image = _id_picture;

            _new_customer.ActivateForm(true, editCustomer);
        }
	}
}