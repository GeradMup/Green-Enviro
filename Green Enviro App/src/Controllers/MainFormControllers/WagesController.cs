using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Green_Enviro_App
{
	using GridViewData = DGVOps.GridViewData;
	using WageInfo = WagesModel.WageInfo;

	public partial class Main_Form : Form
	{
		DGVOps wagesDgvOps;
		/// <summary>Initializes all the controls on the wages tab.</summary>
		private void initializeWagesTab() 
		{
			//DGVOps contains methods that makes use of the type ComboBox but since we do not have one for wages, we will create
			//a fake one.
			ComboBox fakeType = new ComboBox();
			wagesDgvOps = new DGVOps(WageLogGridView, WageLogMonths, WageLogStartDate, WageLogEndDate, fakeType, _mainForm);
			wagesDgvOps.populateLogMonths(_wagesModel.getMonths());
			wagesDgvOps.populateComboBox(WagesEmployeeName, _wagesModel.getEmployees());
			WageDate.Value = DateTime.Now;
			wagesDgvOps.setupTotalsRow(_wagesModel.getAmountColumn());
		}

		/// <summary>Event called whenever a user changes wage log month.</summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The <see cref="EventArgs">EventArgs</see> instance containing the event data.</param>
		private void WageLogMonth_SelectedIndexChanged(object sender, EventArgs e)
		{
			//Do nothing if no month is selected
			if (WageLogMonths.SelectedItem == null) return;
			string selectedMonth = WageLogMonths.SelectedItem.ToString();
 
			updateWagesGridView(_wagesModel.gridViewData(selectedMonth));
		}

		/// <summary>Updates the data grid view.</summary>
		/// <param name="gridData">The grid data.</param>
		private void updateWagesGridView(GridViewData gridData) 
		{
			wagesDgvOps.populateDates(gridData.dates);
			wagesDgvOps.changeBindingSource(gridData.data);
			wagesDgvOps.populateGridView(wageGridColumnWidths());
		}

		/// <summary>Defines the column widths for the wages grid view.</summary>
		/// <returns>A list of doubles containing all the column widths.</returns>
		private List<float> wageGridColumnWidths() 
		{
			List<float> colWidths = new List<float>();
			colWidths.Add(180F);
			colWidths.Add(180F);
			colWidths.Add(100F);
			return colWidths;
		}

		/// <summary>Handles the Click event of the DeleteWageBtn control.</summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
		private void DeleteWageBtn_Click(object sender, EventArgs e)
		{
			const string NO_SELECTION_ERROR = "Please select the wage to be deleted";
			const string DELETING_TOTALS_ERROR = "It's not possible to delete the TOTALS row";
			const string DELETING_WARNING_MESSAGE = "Are you sure you want to delete this entry?";
			//Verify that something is selected before attempting to delete
			if (wagesDgvOps.noRowSelected()) 
			{ GenericControllers.reportError(_mainForm , NO_SELECTION_ERROR); return; }

			//Confirm that the user is not trying to delete the totals row
			if (wagesDgvOps.totalsRowSelected())
			{ GenericControllers.reportError(_mainForm, DELETING_TOTALS_ERROR); return; }

			wagesDgvOps.highlightSelectedRowRed();
			_warnings.showWarning(_mainForm, DELETING_WARNING_MESSAGE, CustomWarning.WarningType.CriticalWarning);

			//Check if the user has confirmed the deletion of the row
			if (_warnings.actionConfirmed) 
			{
				string rowToDelete = wagesDgvOps.getSelectedRowInfo();
				string wageLogMonth = WageLogMonths.SelectedItem.ToString();
				GridViewData newGridData =_wagesModel.deleteWage(rowToDelete, wageLogMonth);
				updateWagesGridView(newGridData);
			}
			else wagesDgvOps.removeRowHighlights();
		}

		/// <summary>Handles the Click event of the AddWageBtn control.</summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
		private void AddWageBtn_Click(object sender, EventArgs e)
		{
			const string NO_AMOUNT_INSERTED = "Please Insert the Amount!";
			const string NO_EMPLOYEE_INSERTED = "Please Insert the Employee Name";
			const string WAGE_ADDED_SUCCESSFULLY = "Wage has been recorded!";

			//First check that an amount has been inserted by the user.
			if (WageAmount.Value == Constants.DECIMAL_ZERO)
			{ GenericControllers.reportError(_mainForm, NO_AMOUNT_INSERTED); return; }

			//Second check that the user has selected an employee to pay the wage.
			if (WagesEmployeeName.Text == Constants.EMPTY_TEXT)
			{ GenericControllers.reportError(_mainForm, NO_EMPLOYEE_INSERTED); return; }

			//Remove grid filters before trying to add a wage.

			WageInfo wageInfo = new WageInfo();
			wageInfo.employeeName = WagesEmployeeName.Text;
			wageInfo.paymentDate = WageDate.Value;
			wageInfo.amount = WageAmount.Value;
			string logMonth = WageDate.Value.ToString(Constants.LOG_NAME_DATE_FORMAT);
			try
			{
				GridViewData newGridData = _wagesModel.addWage(wageInfo);
				updateWagesGridView(newGridData);
				clearWageEntryFields();
				wagesDgvOps.selectMonth(logMonth);
				GenericControllers.reportSuccess(_mainForm, WAGE_ADDED_SUCCESSFULLY);
			}
			catch (Exception ex) 
			{
				GenericControllers.reportError(_mainForm, ex.Message);
			}
		}

		/// <summary>Handles the CheckedChanged event of the PartTimeEmployeeCheckBox control.</summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
		private void PartTimeEmployeeCheckBox_CheckedChanged(object sender, EventArgs e)
		{
			//Convert the drop down list into a drop down so that user can type in a new name.
			if (WagesEmployeeName.DropDownStyle == ComboBoxStyle.DropDown)
			{ WagesEmployeeName.DropDownStyle = ComboBoxStyle.DropDownList; return; }

			if (WagesEmployeeName.DropDownStyle == ComboBoxStyle.DropDownList)
			{ WagesEmployeeName.DropDownStyle = ComboBoxStyle.DropDown; return; }
		}

		/// <summary>
		/// Clears all fields on the Wages tab.
		/// </summary>
		private void resetWages()
		{
			WageLogMonths.SelectedItem = null;
			WageLogStartDate.SelectedItem = null;
			WageLogEndDate.SelectedItem = null;
			WageDate.Value = DateTime.Now;
			wagesDgvOps.resetGridView();
			clearWageEntryFields();
		}

		/// <summary>
		/// Clears the wage entry fields.
		/// </summary>
		private void clearWageEntryFields() 
		{
			WageAmount.Value = Constants.DECIMAL_ZERO;
			WagePartTimeEmployeeCheckBox.CheckState = CheckState.Unchecked;
			WagesEmployeeName.DropDownStyle = ComboBoxStyle.DropDownList;
			WagesEmployeeName.SelectedItem = null;
		}

		/// <summary>Handles the Click event of the ClearWageFieldsBtn control.</summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
		private void ClearWageFieldsBtn_Click(object sender, EventArgs e)
		{
			resetWages();
		}

		/// <summary>Handles the Click event of the WagesLogFilterBtn control.</summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The <see cref="T:System.EventArgs">EventArgs</see> instance containing the event data.</param>
		private void WagesLogFilterBtn_Click(object sender, EventArgs e)
		{
			wagesDgvOps.filterGridView();
		}

		/// <summary>Handles the Click event of the WagesLogRemoveFilterBtn control.</summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The <see cref="T:System.EventArgs">EventArgs</see> instance containing the event data.</param>
		private void WagesLogRemoveFilterBtn_Click(object sender, EventArgs e)
		{
			wagesDgvOps.removeGridViewFilters();
		}
	}
}
