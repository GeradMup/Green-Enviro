using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Green_Enviro_App
{
	using GridViewData = DGVOps.GridViewData;

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
			WageDate.Value = DateTime.Now;
		}

		private void WageLogMonth_SelectedIndexChanged(object sender, EventArgs e)
		{
			//Do nothing if no month is selected
			if (WageLogMonths.SelectedItem == null) return;
			string selectedMonth = WageLogMonths.SelectedItem.ToString();

			GridViewData gridData = _wagesModel.gridViewData(selectedMonth);
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

		private void DeleteWageBtn_Click(object sender, EventArgs e)
		{
			//_wages.DeleteWage();
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

			if (_warnings.actionConfirmed) MessageBox.Show("Confirmed");
			else MessageBox.Show("Not Confirmed!");
		}

		/// <summary>
		/// Deletes a sale if user made mistake.
		/// </summary>
		public void DeleteWage()
		{
			
		}


	}
}
