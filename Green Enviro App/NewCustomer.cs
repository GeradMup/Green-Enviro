using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Green_Enviro_App
{
	public partial class NewCustomer : Form
	{
		Database _database;
		Main_Form _main_form;
		Customers _customers;
		DataTable _customers_data_table = new DataTable();
		Receipt _receipt;
		string _customers_table_name = "Customers";
		bool _editing_customer = false;
		public NewCustomer(Customers customers,Main_Form main, Database data, Receipt receipt)
		{
			InitializeComponent();

			_database = data;
			this.Owner = customers;
			_main_form = main;
			_customers = customers;
			_receipt = receipt;
			LoadCustomers();
		}

		public struct CustomerInfo
		{
			public string _number { get; set; }

			public string _id { get; set; }

			public string _name { get; set; }

			public string _surname { get; set; }

			public string _cell { get; set; }

			public string _address { get; set; }
		}

		private void LoadCustomers() 
		{
			_customers_data_table = _database.SelectAll(_customers_table_name);
		}

		private bool NoDuplicates() 
		{
			bool _no_duplicates = true;

			if (_editing_customer) 
			{
				return _no_duplicates;
			}

				foreach (DataRow _row in _customers_data_table.Rows)
				{
					if (_row[0].ToString() == NewCustomerNumber.Value.ToString())
					{
						_no_duplicates = false;
						CustomMessageBox mb = new CustomMessageBox(this, "Error!", "Customer number already exists");
						break;
					}
					else if (_row[1].ToString() == NewCustomerID.Text)
					{
						_no_duplicates = false;
						CustomMessageBox mb = new CustomMessageBox(this, "Error!", "Customer ID/Passport number already exists");
						break;
					}
				}
			return _no_duplicates;
		}

		public void ActivateForm(bool editingCustomer, CustomerInfo customerInfo = new CustomerInfo()) 
		{
			_editing_customer = editingCustomer;

			this.Owner.Enabled = false;
			this.Activate();
			this.Enabled = true;
			this.Show();

			if (_editing_customer) 
			{
				PrefillFields(customerInfo);
			}
		}

		private void PrefillFields(CustomerInfo customerInfo) 
		{
			NewCustomerNumber.Value = decimal.Parse(customerInfo._number);
			NewCustomerName.Text = customerInfo._name;
			NewCustomerID.Text = customerInfo._id;
			NewCustomerSurname.Text = customerInfo._surname;
			NewCustomerCell.Value = decimal.Parse(customerInfo._cell);
			NewCustomerAddress.Text = customerInfo._address;

			NewCustomerNumber.ReadOnly = true;
		}

		private void Exit() 
		{
			ClearFields();
			_customers.LoadCustomersDataTable();
			this.Owner.Enabled = true;
			this.Owner.Show();
			this.Hide();
			this.Enabled = false;
		}

		private bool ValidEntries() 
		{
			bool _all_good = false;
			string _no_text = "";
			string _error_message = "";
			decimal _zero = (decimal)0.00;

			if (NewCustomerName.Text == _no_text)
			{
				_error_message = "Please Enter the Name";
			}
			else if (NewCustomerSurname.Text == _no_text)
			{
				_error_message = "Please Enter the Surname";
			}
			else if (NewCustomerID.Text == _no_text)
			{
				_error_message = "Please Enter the ID or Passport Number";
			}
			else if (NewCustomerIdPictureBox.Image == null)
			{
				_error_message = "Please Insert the ID/Passport Picture";
			}
			else if (NewCustomerNumber.Value == _zero)
			{
				_error_message = "Please Insert the Customer Number";
			}
			else if (NewCustomerAddress.Text == _no_text)
			{
				_error_message = "Please Insert the Address";
			}
			else if (NewCustomerCell.Value == _zero) 
			{
				_error_message = "Please Insert the Cell Phone Number";
			}
			else
			{
				_all_good = true;
			}

			if (_all_good == false) 
			{
				CustomMessageBox mb = new CustomMessageBox(this, "Error!", _error_message);
			}
			return _all_good;
		}

		private void NewCustomerAddIdPictureBtn_Click(object sender, EventArgs e)
		{
			OpenFileDialog _new_dialog = new OpenFileDialog();

			if (_new_dialog.ShowDialog() == DialogResult.OK) 
			{
				NewCustomerIdPictureBox.Image = Image.FromFile(_new_dialog.FileName);
			}
		}

		private void NewCustomerCancelBtn_Click(object sender, EventArgs e)
		{
			Exit();
		}

		private void NewCustomerConfirmBtn_Click(object sender, EventArgs e)
		{
			if (ValidEntries() == false) 
			{
				return;
			}

			if (NoDuplicates() == false) 
			{
				return;
			}

			if (_editing_customer)
			{
				EditCustomer();
				_editing_customer = false;
				return;
			}
			else 
			{
				AddCustomer();
			}
		}

		private void AddCustomer() 
		{
			string _number = NewCustomerNumber.Value.ToString();
			string _id = NewCustomerID.Text;
			string _name = NewCustomerName.Text;
			string _surname = NewCustomerSurname.Text;
			string _cell = "0" + NewCustomerCell.Value.ToString();
			string _address = NewCustomerAddress.Text;

			string _columns = "CustomerNumber,ID,Name,Surname,Cell,Address";
			string _values = "'" + _number + "','" + _id + "','" + _name + "','" + _surname + "','" + _cell + "','" + _address + "'";

			Int32 _rows_affected = _database.InsertIntoDatabase(_customers_table_name, _columns, _values);

			if (_rows_affected == 1) 
			{
				SaveIdPicture(_number);
			}
		}

		private void SaveIdPicture(string customerNumber) 
		{
			string _path_to_main_folder = Path.GetDirectoryName(Path.GetDirectoryName(Directory.GetCurrentDirectory()));
			string _path_to_image = _path_to_main_folder + @"\resources\Customers\" + customerNumber + ".jpg";
			try
			{
				NewCustomerIdPictureBox.Image.Save(_path_to_image, System.Drawing.Imaging.ImageFormat.Jpeg);
				_receipt.setupCustomerList();
				CustomMessageBox mb = new CustomMessageBox(this, CustomMessageBox.success, "Customer details saved");
				Exit();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Failed to save image: \n" + ex.Message);
			}
		}

		public void EditCustomer() 
		{

			string _customer_number = NewCustomerNumber.Value.ToString();
			string _customer_name = NewCustomerName.Text;
			string _customer_id = NewCustomerID.Text;
			string _customer_surname = NewCustomerSurname.Text;
			string _customer_cell = NewCustomerCell.Value.ToString();
			string _customer_address = NewCustomerAddress.Text;


			string _column_value_pairs = "ID = '" + _customer_id + "', Name = '" + _customer_name + "', Surname = '" + _customer_surname + "', Cell = '" + _customer_cell + "', Address = '" + _customer_address + "'";
			string _identification_column = "CustomerNumber";
			string _identifier = "'" + _customer_number + "'";

			Int32 rowsAffected = _database.UpdateDatabase(_customers_table_name, _column_value_pairs, _identification_column, _identifier);

			if (rowsAffected == 1)
			{
				SaveIdPicture(_customer_number);
			}
			else
			{
				CustomMessageBox mb = new CustomMessageBox(this, CustomMessageBox.error, "Failed to update customer details");
			}
		}
		

		private void ClearFields() 
		{
			NewCustomerNumber.Value = (decimal)0.00;
			NewCustomerID.Text = "";
			NewCustomerName.Text = "";
			NewCustomerSurname.Text = "";
			NewCustomerCell.Value = 0;
			NewCustomerAddress.Text = "";
			NewCustomerIdPictureBox.Image = null;
			NewCustomerNumber.ReadOnly = false;
		}
	}
}
