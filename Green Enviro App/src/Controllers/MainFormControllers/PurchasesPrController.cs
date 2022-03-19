using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Green_Enviro_App
{
	public partial class Main_Form : Form
	{
		/// <summary>
		/// The purchases pr DGV ops
		/// </summary>
		DGVOps purchasesPrDgvOps;

		/// <summary>
		/// Initialises the purchases police register tab
		/// </summary>
		private void initialisePurchasesPr() 
		{
			purchasesPrDgvOps = new DGVOps(PurchasesPRDataGridView, PurchasesPRMonth, PurchasePRStartDate, PurchasePREndDate, PurchasePRType, this);

			try
			{
				purchasesPrDgvOps.populateLogMonths(_purchasesPrModel.getMonths());
				purchasesPrDgvOps.setTypes();
			}
			catch (Exception ex) 
			{
				GenericControllers.reportError(this, ex.Message);
			}
		}

		/// <summary>
		/// Updates the purchases police register grid view.
		/// </summary>
		/// <param name="month">The month.</param>
		private void updatePurchasePrGridView(string month)
		{
			try
			{
				DGVOps.GridViewData gridData = _purchasesPrModel.getGridData(month);
				purchasesPrDgvOps.changeBindingSource(gridData.data);
				purchasesPrDgvOps.populateDates(gridData.dates);
				purchasesPrDgvOps.populateGridView(purchaseGridColumnWidths());
			}
			catch (Exception ex)
			{
				GenericControllers.reportError(_mainForm, ex.Message);
			}
		}

		/// <summary>
		/// Handles the SelectedIndexChanged event of the PurchasesPRMonth control.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
		private void PurchasesPRMonth_SelectedIndexChanged(object sender, EventArgs e)
		{
			//Check that nothing is selected on the DataGridView
			if (!purchasesPrDgvOps.logMonthSelected()) return;
			string month = PurchasesPRMonth.Text;
			updatePurchasePrGridView(month);
		}

		/// <summary>
		/// Handles the Click event of the DeletePREntry control.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
		private void DeletePREntry_Click(object sender, EventArgs e)
		{
			const string CONFIRM_DELETION = "Are you sure you want to delete the entry in RED?";
			const string DELETION_SUCCEEDED = "The entry has been deleted!";

			if (purchasesPrDgvOps.noRowSelected()) return;
			if (purchasesPrDgvOps.selectedRowEmpty()) return;

			purchasesPrDgvOps.highlightSelectedRowRed();

			_warnings.showWarning(_mainForm, CONFIRM_DELETION, CustomWarning.WarningType.CriticalWarning);

			if (_warnings.actionConfirmed)
			{
				string selectedRow = purchasesPrDgvOps.getSelectedRowInfo();
				string month = purchasesPrDgvOps.getSelectedMonth();

				try
				{
					_purchasesPrModel.deleteEntry(selectedRow, month);
					updatePurchasePrGridView(month);
					GenericControllers.reportSuccess(_mainForm, DELETION_SUCCEEDED);
				}
				catch (Exception ex)
				{
					GenericControllers.reportError(_mainForm, ex.Message);
				}
			}
			else 
			{
				purchasesPrDgvOps.removeRowHighlights();
			}
		}

		/// <summary>
		/// Resets the purchases police register.
		/// </summary>
		private void resetPurchasesPoliceRegister() 
		{
			purchasesPrDgvOps.clearGridView();
			PurchasesPRMonth.SelectedItem = null;
			PurchasePREndDate.SelectedItem = null;
			PurchasePRStartDate.SelectedItem = null;
			PurchasePRType.SelectedItem = null;
		}
	}
}
