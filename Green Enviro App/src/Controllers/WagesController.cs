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

		private void initializeWagesTab() 
		{
			//DGVOps contains methods that makes use of the type ComboBox but since we do not have one for wages, we will create
			//a fake one.
			ComboBox type = new ComboBox();
			wagesDgvOps = new DGVOps(WageLogGridView, WageLogMonths, WageLogStartDate, WageLogEndDate, type, _mainForm);
			wagesDgvOps.populateLogMonths(_wagesModel.getMonths());
			wagesDgvOps.populateComboBox(WagesEmployeeName, _wagesModel.getEmployees());
			
			WageDate.Value = DateTime.Now;
		}

		private void WageLogMonth_SelectedIndexChanged(object sender, EventArgs e)
		{
			//Do nothing if no month is selected
			if (WageLogMonths.SelectedItem == null) return;
			string selectedMonth = WageLogMonths.SelectedItem.ToString();

			GridViewData gridData = _wagesModel.gridViewData(selectedMonth);
			updateDataGridView(gridData);
		}

		private void updateDataGridView(GridViewData gridData) 
		{
			wagesDgvOps.populateDates(gridData.dates);
			wagesDgvOps.changeBindingSource(gridData.data);
			wagesDgvOps.populateGridView(wageGridColumnWidths());
		}

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
			if (WageLogGridView.SelectedCells.Count == 0) 
			{ GenericControllers.reportError(_mainForm , NO_SELECTION_ERROR); return; }

			//Confirm that the user is not trying to delete the totals row
			if (WageLogGridView.CurrentCell.RowIndex == WageLogGridView.Rows.Count - 1)
			{ GenericControllers.reportError(_mainForm, DELETING_TOTALS_ERROR); return; }

			//Highlight the rows that will be deleted if the user chooses to confirm
			int selectedRow = WageLogGridView.CurrentCell.RowIndex;
			wagesDgvOps.highlightRowRed(selectedRow);
			_warnings.showWarning(_mainForm, DELETING_WARNING_MESSAGE, Warning.WarningType.CriticalWarning);

			//Check if the user has confirmed the deletion of the row
			if (_warnings.actionConfirmed) 
			{
				string rowToDelete = wagesDgvOps.getRowInfo(selectedRow);
				string wageLogMonth = WageLogMonths.SelectedItem.ToString();
				GridViewData newGridData =_wagesModel.deleteWage(rowToDelete, wageLogMonth);
				updateDataGridView(newGridData);
			}
			else wagesDgvOps.removeRowHighlights(selectedRow);
		}

		/// <summary>Handles the Click event of the AddWageBtn control.</summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
		private void AddWageBtn_Click(object sender, EventArgs e)
		{
			const string NO_AMOUNT_INSERTED = "Please Insert the Amount!";
			const string NO_EMPLOYEE_INSERTED = "Please Insert the Employee Name";

			//First check that an amount has been inserted by the user.
			if (WageAmount.Value == Constants.DECIMAL_ZERO)
			{ GenericControllers.reportError(_mainForm, NO_AMOUNT_INSERTED); return; }

			//Second check that the user has selected an employee to pay the wage.
			if (WagesEmployeeName.Text == Constants.EMPTY_TEXT)
			{ GenericControllers.reportError(_mainForm, NO_EMPLOYEE_INSERTED); return; }

			WageInfo wageInfo = new WageInfo();
			wageInfo.employeeName = getEmployeeName();
			wageInfo.paymentDate = WageDate.Value;
			wageInfo.amount = WageAmount.Value;
			GridViewData newGridData = _wagesModel.addWage(wageInfo);
			updateDataGridView(newGridData);
		}

		//A helper function to check if the user is trying to pay a part time employee or existing employees.
		private string getEmployeeName() 
		{
			if (WagePartTimeEmployeeCheckBox.CheckState == CheckState.Checked) return WagesEmployeeName.Text;
			return WagesEmployeeName.SelectedItem.ToString();
		}


	}
}
