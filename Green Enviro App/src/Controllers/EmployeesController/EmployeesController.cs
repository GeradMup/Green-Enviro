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
		private bool editingEmployee = false;
		private string employeeIdentifier = "";
		
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

		/// <summary>Handles the Click event of the EmployeesCancelBtn control.</summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
		private void EmployeesCancelBtn_Click(object sender, EventArgs e)
		{
			ClearFields();
			Exit();
		}

		/// <summary>
		/// Clears all the fields on the Employees page.
		/// </summary>
		public void ClearFields()
		{
			EmployeeName.Text = Constants.EMPTY_TEXT;
			EmployeeSurname.Text = Constants.EMPTY_TEXT;
			EmployeeIdentification.Text = Constants.EMPTY_TEXT;
			EmployeeGender.SelectedItem = null;
			EmployeeAddress.Text = Constants.EMPTY_TEXT;
			EmployeeCellNumber.Text = Constants.EMPTY_TEXT;
			employeeIdentifier = Constants.EMPTY_TEXT;
			EmployeeGender.DropDownStyle = ComboBoxStyle.DropDownList;
			EmployeeGender.SelectedItem = null;

			editingEmployee = false;

		}

		/// <summary>
		/// Closes the Employees form and opens the main form on the wages tab.
		/// </summary>
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
			
			//All the buttons added after the employees grid panel remain visible on top of the panel
			//Here wer hide them to ensure that when viewing the panel, we don't see the buttons.
			EmployeesEditBtn.Visible = false;
		}

		/// <summary>Handles the Click event of the EmployeesCloseGridBtn control.</summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The <see cref="System.EventArgs" /> instance containing the event data.</param>
		private void EmployeesCloseGridBtn_Click(object sender, System.EventArgs e)
		{
			EmployeesGridPanel.Dock = DockStyle.None;
			EmployeesEditBtn.Visible = true;
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
			const string EMPLOYEE_ADDED = "Employee details have been added or updated!";

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
				if (editingEmployee == true) _employeesModel.updateEmployee(employeeInfo, employeeIdentifier);
				else _employeesModel.addEmployee(employeeInfo);

				updateGridView();
				GenericControllers.reportSuccess(this, EMPLOYEE_ADDED);
				ClearFields();
			}
			catch (Exception ex) 
			{
				GenericControllers.reportError(this, ex.Message);
			}
			
		}

		/// <summary>Handles the Click event of the EmployeesEditBtn control.</summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
		private void EmployeesEditBtn_Click(object sender, EventArgs e)
		{
			List<string> selectedRowInfo = employeesDgvOps.getSeletedRow();
			EmployeeName.Text = selectedRowInfo[1];
			EmployeeSurname.Text = selectedRowInfo[2];
			EmployeeIdentification.Text = selectedRowInfo[3];
			EmployeeGender.DropDownStyle = ComboBoxStyle.DropDown;
			EmployeeGender.Text = selectedRowInfo[4];
			EmployeeAddress.Text = selectedRowInfo[5];
			EmployeeCellNumber.Text = selectedRowInfo[6];

			editingEmployee = true;
			employeeIdentifier = selectedRowInfo[3];
		}
	}
}
