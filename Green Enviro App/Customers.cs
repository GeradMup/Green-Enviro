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
	public partial class Customers : Form
	{
		Database _database;
		Main_Form _main_form;
		DataTable _customers = new DataTable();
		string _customers_table_name = "Customers";
		public Customers(Main_Form main, Database data)
		{
			InitializeComponent();

			_database = data;
			this.Owner = main;
			_main_form = main;
			LoadCustomers();
		}

		private void LoadCustomers() 
		{
			_customers = _database.SelectAll(_customers_table_name);
		}

		public void NewCustomer() 
		{
			ActivateForm();

		}

		private bool NoDuplicates() 
		{
			bool _no_duplicates = true;
			
				foreach (DataRow _row in _customers.Rows)
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

		private void ActivateForm() 
		{
			this.Owner.Enabled = false;
			this.Activate();
			this.Enabled = true;
			this.Show();
		}

		private void Exit() 
		{
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
			else 
			{
				_all_good = true;
			}

			if (_all_good == false) 
			{
				CustomMessageBox mb = new CustomMessageBox(this, "Failed", _error_message);
			}
			return _all_good;
		}

		private void NewCustomerAddIdPictureBtn_Click(object sender, EventArgs e)
		{
			OpenFileDialog _new_dialog = new OpenFileDialog();

			if (_new_dialog.ShowDialog() == DialogResult.OK) 
			{
				NewCustomerIdPictureBox.Image = new Bitmap(_new_dialog.FileName);
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

			AddCustomer();
		}

		private void AddCustomer() 
		{
			string _number = NewCustomerNumber.Value.ToString();
			string _id = NewCustomerID.Text;
			string _name = NewCustomerName.Text;
			string _surname = NewCustomerSurname.Text;

			string _columns = "CustomerNumber,ID,Name,Surname";
			string _values = "'" + _number + "','" + _id + "','" + _name + "','" + _surname + "'";

			Int32 _rows_affected = _database.InsertIntoDatabase(_customers_table_name, _columns, _values);

			if (_rows_affected == 1) 
			{
				string _path_to_main_folder = Path.GetDirectoryName(Path.GetDirectoryName(Directory.GetCurrentDirectory()));
				string _path_to_images_folder = _path_to_main_folder + @"resources/Customers" + _number.ToString() + ".jpg";

				try
				{
					NewCustomerIdPictureBox.Image.Save(_path_to_images_folder, System.Drawing.Imaging.ImageFormat.Jpeg);
				}
				catch (Exception ex) 
				{
					MessageBox.Show("Failed to save image");
				}
			}
		}
	}
}
