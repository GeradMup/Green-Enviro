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
		DGVOps purchasesDgvOps;

		/// <summary>
		/// Initializes the form controls on the tabs page.
		/// </summary>
		private void initializePurchasesTab()
		{
			purchasesDgvOps = new DGVOps(PurchasesLogGridView, PurchaseLogMonth, PurchaseLogStartDate, PurchaseLogEndDate, PurchaseLogType, _mainForm);
			try
			{
				purchasesDgvOps.populateLogMonths(_purchasesModel.getMonths());
				purchasesDgvOps.setTypes();
				purchasesDgvOps.setupTotalsRow(_purchasesModel.amountColumn(), _purchasesModel.quantityColumn());
			}
			catch (Exception ex)
			{
				GenericControllers.reportError(_mainForm, ex.Message);
			}
		}

		/// <summary>Updates the purchase grid view.</summary>
		/// <param name="month">The month.</param>
		private void updatePurchaseGridView(string month)
		{
			try
			{
				DGVOps.GridViewData gridData = _purchasesModel.getGridData(month);
				purchasesDgvOps.changeBindingSource(gridData.data);
				purchasesDgvOps.populateDates(gridData.dates);
				purchasesDgvOps.populateGridView(purchaseGridColumnWidths());
			}
			catch (Exception ex) 
			{
				GenericControllers.reportError(_mainForm, ex.Message);
			} 
		}

		/// <summary>Configures the column widths for the purchases data grid view.</summary>
		/// <returns>A List of floats representing the column widths.</returns>
		private List<float> purchaseGridColumnWidths()
		{
			List<float> colWidths = new List<float>();
			colWidths.Add(180F);
			colWidths.Add(110F);
			colWidths.Add(130F);
			colWidths.Add(130F);
			colWidths.Add(40F);
			colWidths.Add(80F);
			colWidths.Add(50F);
			colWidths.Add(50F);
			colWidths.Add(60F);

			return colWidths;
		}

		/// <summary>Handles the SelectedIndexChanged event of the PurchaseLogMonth control.</summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
		private void PurchaseLogMonth_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (!purchasesDgvOps.logMonthSelected()) return;
			string month = PurchaseLogMonth.Text;
			updatePurchaseGridView(month);
		}

		/// <summary>Handles the Click event of the FilterPurchaseLogBtn control.</summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
		private void FilterPurchaseLogBtn_Click(object sender, EventArgs e)
		{
			purchasesDgvOps.filterGridView();
		}

		/// <summary>Handles the Click event of the PurchaseLogRemoveFiltersBtn control.</summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
		private void PurchaseLogRemoveFiltersBtn_Click(object sender, EventArgs e)
		{
			purchasesDgvOps.removeGridViewFilters();
		}

		/// <summary>Handles the Click event of the DeletePurchaseBtn control.</summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
		private void DeletePurchaseBtn_Click(object sender, EventArgs e)
		{
			const string DELETING_TOTALS_ERROR = "You cannot delete the totals row!";
			const string NO_SELECTION_ERROR = "You have not selected any row to delete!";
			const string DELETION_COMPLETED = "Purchase entry has been deleted!";
			const string CONFIRM_DELETION = "Are you sure you want to delete the entry in RED?";

			if (purchasesDgvOps.noRowSelected()) { GenericControllers.reportError(_mainForm, NO_SELECTION_ERROR); return; }
			if (purchasesDgvOps.totalsRowSelected()) { GenericControllers.reportError(_mainForm, DELETING_TOTALS_ERROR); return; }
			if (purchasesDgvOps.selectedRowEmpty()) { GenericControllers.reportError(_mainForm, NO_SELECTION_ERROR); return; }

			purchasesDgvOps.highlightSelectedRowRed();

			_warnings.showWarning(_mainForm, CONFIRM_DELETION, CustomWarning.WarningType.CriticalWarning);

			if (_warnings.actionConfirmed)
			{
				string rowToDelete = purchasesDgvOps.getSelectedRowInfo();
				string month = purchasesDgvOps.getSelectedMonth();
				try
				{
					_purchasesModel.deleteEntry(rowToDelete, month);
					updatePurchaseGridView(month);
					GenericControllers.reportSuccess(_mainForm, DELETION_COMPLETED);				}
				catch (Exception ex) 
				{
					GenericControllers.reportError(_mainForm, ex.Message);
				}
			}
			else 
			{
				purchasesDgvOps.removeRowHighlights();
			}

		}

		/// <summary>
		/// Resets all the form controls on the purchases tab page.
		/// </summary>
		private void resetPurchases() 
		{
			PurchaseLogMonth.SelectedItem = null;
			PurchaseLogStartDate.SelectedItem = null;
			PurchaseLogEndDate.SelectedItem = null;
			PurchaseLogType.SelectedItem = null;
			purchasesDgvOps.resetGridView();

		}

		/// <summary>
		/// Handles the Click event of the AddToPRBtn control.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
		private void AddToPRBtn_Click(object sender, EventArgs e)
		{
			const string ENTRY_ADDED_TO_PR = "Entry has been added to the police register!";
			//First check if something is selected. 
			if (purchasesDgvOps.noRowSelected()) return;

			//Make sure that the totals row is not selected.
			if (purchasesDgvOps.totalsRowSelected()) return;

			//Make sure that the selected row has something in it.
			if (purchasesDgvOps.selectedRowEmpty()) return;

			string selectedItemInfo = purchasesDgvOps.getSelectedRowInfo();
			
			try
			{
				_purchasesPrModel.addToPurchasesPoliceRegister(selectedItemInfo);
				GenericControllers.reportSuccess(this, ENTRY_ADDED_TO_PR);
			}
			catch (Exception ex) 
			{
				GenericControllers.reportError(this, ex.Message);
			}
		}
	}
}
