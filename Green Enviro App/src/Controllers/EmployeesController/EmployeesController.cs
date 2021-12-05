using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Green_Enviro_App
{
	public partial class Employees : Form
	{
		DataTable _employees_data_table = new DataTable();
		Main_Form _main_form;
		Database _database;
		/// <summary>Initializes a new instance of the <see cref="Employees" /> class.</summary>
		/// <param name="main">The main.</param>
		/// <param name="data">The data.</param>
		public Employees(Main_Form main, Database data)
		{
			InitializeComponent();

			_main_form = main;
			_database = data;

			this.Owner = _main_form;

			LoadEmployees();
		}

		private void LoadEmployees()
		{

			_employees_data_table = _database.selectAll(Database.Tables.Employees);
			string _employee_name = "";

			//_main_form.WagesEmployeeName.Items.Clear();
			foreach (DataRow row in _employees_data_table.Rows)
			{
				_employee_name = row[1].ToString() + " " + row[2].ToString();
				//_main_form.WagesEmployeeName.Items.Add(_employee_name);
			}
		}

		private void EmployeesAddEmployeeBtn_Click(object sender, EventArgs e)
		{
			if (validEntries() == false)
			{
				return;
			}

			string name = EmployeeNameField.Text;
			string surname = EmployeeSurnameField.Text;
			string identification = EmployeeIdentificationField.Text;
			string gender = EmployeeGenderField.SelectedItem.ToString();
			string address = "Unknown";
			string cell = "0000000000";

			string[] values = { name, surname, identification, gender, address, cell };

			Int32 _rows_affected = _database.insert(Database.Tables.Employees, values);

			if (_rows_affected == 1)
			{
				CustomMessageBox box = new CustomMessageBox(this, "Success!", "New Employee Inserted!");
				LoadEmployees();
				ClearFields();
				Exit();
			}
			else
			{
				CustomMessageBox box = new CustomMessageBox(this, "Error!", "Failed To Inserted New Employee!");
			}
		}

		private bool validEntries()
		{
			bool _all_good = false;
			string _message_title = "Error!";
			string _error_message = "";
			string _no_text = "";

			if (EmployeeNameField.Text == _no_text)
			{
				_error_message = "Employee Name Not Entered";
			}
			else if (EmployeeSurnameField.Text == _no_text)
			{
				_error_message = "Employee Surname Not Entered";
			}
			else if (EmployeeIdentificationField.Text == _no_text)
			{
				_error_message = "Employee Identification Not Entered";
			}
			else if (EmployeeGenderField.SelectedItem == null)
			{
				_error_message = "Employee Gender Not Selected";
			}
			else
			{
				_all_good = true;
			}

			if (_all_good == false)
			{
				CustomMessageBox box = new CustomMessageBox(this, _message_title, _error_message);
			}

			return _all_good;

		}
		private void EmployeesCancelBtn_Click(object sender, EventArgs e)
		{
			ClearFields();
			Exit();
		}

		public void ClearFields()
		{
			EmployeeNameField.Text = "";
			EmployeeSurnameField.Text = "";
			EmployeeIdentificationField.Text = "";
			EmployeeGenderField.SelectedItem = null;
		}

		public void Exit()
		{
			this.Owner.Enabled = true;
			this.Owner.Show();
			this.Hide();
			this.Enabled = false;
		}

		private void EmployeesViewGridBtn_Click(object sender, EventArgs e)
		{
			EmployeesGridPanel.Dock = DockStyle.Fill;
		}

		private void EmployeesCloseGridBtn_Click(object sender, System.EventArgs e)
		{
			EmployeesGridPanel.Dock = DockStyle.None;
		}
	}
}
