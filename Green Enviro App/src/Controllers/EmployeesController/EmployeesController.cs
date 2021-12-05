using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Green_Enviro_App
{
	using EmployeeInfo = EmployeesModel.EmployeeInfo;

	/// <summary>
	/// Class to handle all the details about the employees.
	/// </summary>
	public partial class Employees : Form
	{
		DataTable _employees_data_table = new DataTable();
		Main_Form _mainForm;
		EmployeesModel _employeesModel;
		DGVOps employeesDgvOps;
		
		/// <summary>Initializes a new instance of the <see cref="Employees" />Employees class.</summary>
		/// <param name="main">The main.</param>
		/// <param name="em">The employees model object.</param>
		public Employees(Main_Form main, EmployeesModel em)
		{
			InitializeComponent();

			_mainForm = main;
			_employeesModel = em;

			employeesDgvOps = new DGVOps(EmployeesGridView, this);
			updateGridView();
		}

		/// <summary>
		/// Updates the employees data grid view if some changes take place.
		/// </summary>
		private void updateGridView() 
		{
			employeesDgvOps.changeBindingSource(_employeesModel.getEmployees());
			employeesDgvOps.populateGridView(employeesGridColumnWidths());
		}

		/// <summary>Configures the column widths for the employees Data Grid View.</summary>
		/// <returns>A list of floats containing the column widths.</returns>
		private List<float> employeesGridColumnWidths()
		{
			List<float> columnWidths = new List<float>();
			columnWidths.Add(20.0F);
			columnWidths.Add(70.0F);
			columnWidths.Add(70.0F);
			columnWidths.Add(100.0F);
			columnWidths.Add(40.0F);
			columnWidths.Add(250.0F);
			columnWidths.Add(75.0F);
			return columnWidths;
		}

		private void LoadEmployees()
		{

			//_employees_data_table = _database.selectAll(Database.Tables.Employees);
			string _employee_name = "";

			//_main_form.WagesEmployeeName.Items.Clear();
			foreach (DataRow row in _employees_data_table.Rows)
			{
				_employee_name = row[1].ToString() + " " + row[2].ToString();
				//_main_form.WagesEmployeeName.Items.Add(_employee_name);
			}
		}

		/*
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
		*/
		private bool validEntries()
		{
			bool _all_good = false;
			string _message_title = "Error!";
			string _error_message = "";
			string _no_text = "";

			if (EmployeeName.Text == _no_text)
			{
				_error_message = "Employee Name Not Entered";
			}
			else if (EmployeeSurname.Text == _no_text)
			{
				_error_message = "Employee Surname Not Entered";
			}
			else if (EmployeeIdentification.Text == _no_text)
			{
				_error_message = "Employee Identification Not Entered";
			}
			else if (EmployeeGender.SelectedItem == null)
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
			EmployeeName.Text = "";
			EmployeeSurname.Text = "";
			EmployeeIdentification.Text = "";
			EmployeeGender.SelectedItem = null;
		}

		public void Exit()
		{
			_mainForm.Enabled = true;
			_mainForm.Show();
			this.Hide();
			this.Enabled = false;
		}

		//* * * * * * * * * * * * * * * * * EVENT HANDLERS * * * * * * * * * * * * * * * * * * * 
		
		/// <summary>Handles the Click event of the EmployeesViewGridBtn control.</summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
		private void EmployeesViewGridBtn_Click(object sender, EventArgs e)
		{
			EmployeesGridPanel.Dock = DockStyle.Fill;
		}

		/// <summary>Handles the Click event of the EmployeesCloseGridBtn control.</summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The <see cref="System.EventArgs" /> instance containing the event data.</param>
		private void EmployeesCloseGridBtn_Click(object sender, System.EventArgs e)
		{
			EmployeesGridPanel.Dock = DockStyle.None;
		}

		/// <summary>Handles the Click event of the EmployeesAddEmployeeBtn control.</summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
		private void EmployeesAddEmployeeBtn_Click(object sender, EventArgs e) 
		{
			const string NO_NAME_ERROR = "Please insert the Employee Name!";
			const string NO_SURNAME_ERROR = "Please insert the Employee Surname!";
			const string NO_ID_ERROR = "Please insert the Employee Identification Number!";
			const string NO_GENDER_ERROR = "Please insert the Employee Gender!";
			const string NO_ADDRESS_ERROR = "Please insert the Employee Address!";
			const string NO_CELL_ERROR = "Please insert the Employee Cell Number!";
			const string EMPLOYEE_ADDED = "New Employee has been added to the Database!";

			if (EmployeeName.Text == Constants.EMPTY_TEXT) { GenericControllers.reportError(this, NO_NAME_ERROR); return; }
			if (EmployeeSurname.Text == Constants.EMPTY_TEXT) { GenericControllers.reportError(this, NO_SURNAME_ERROR); return; }
			if (EmployeeIdentification.Text == Constants.EMPTY_TEXT) { GenericControllers.reportError(this, NO_ID_ERROR); return; }
			if (EmployeeGender.SelectedItem == null) { GenericControllers.reportError(this, NO_GENDER_ERROR); return; }
			if (EmployeeAddress.Text == Constants.EMPTY_TEXT) { GenericControllers.reportError(this, NO_ADDRESS_ERROR); return; }
			if (EmployeeCellNumber.Text == Constants.EMPTY_TEXT) { GenericControllers.reportError(this, NO_CELL_ERROR); return; }

			EmployeeInfo employeeInfo = new EmployeeInfo();
			employeeInfo.employeeName = EmployeeName.Text;
			employeeInfo.employeeSurname = EmployeeSurname.Text;
			employeeInfo.employeeId = EmployeeIdentification.Text;
			employeeInfo.employeeGender = EmployeeGender.Text;
			employeeInfo.employeeAddress = EmployeeAddress.Text;
			employeeInfo.employeeCell = EmployeeCellNumber.Text;

			try
			{
				_employeesModel.addEmployee(employeeInfo);
				updateGridView();
				GenericControllers.reportSuccess(this, EMPLOYEE_ADDED);
			}
			catch (Exception ex) 
			{
				GenericControllers.reportError(this, ex.Message);
			}
			
		}
	}
}
