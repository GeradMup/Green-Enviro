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
		DGVOps salesPrDgvOps;

		/// <summary>
		/// Initialises the sales police register tab.
		/// </summary>
		public void initialiseSalesPr() 
		{
			salesPrDgvOps = new DGVOps(salesPRDataGridView,SalesPRMonth, new ComboBox(), new ComboBox(), new ComboBox(), _mainForm);
			try
			{
				salesPrDgvOps.populateLogMonths(_salesPrModel.getMonths());
			}
			catch (Exception ex) 
			{
				throw new Exception(ex.Message);
			}
		}

		/// <summary>
		/// Updates the sales police register grid view.
		/// </summary>
		/// <param name="month">The month.</param>
		private void updateSalesPrGridView(string month) 
		{
			try
			{
				DGVOps.GridViewData gridData = _salesPrModel.getGridData(month);
				salesPrDgvOps.changeBindingSource(gridData.data);
				salesPrDgvOps.populateDates(gridData.dates);
				salesPrDgvOps.populateGridView(purchaseGridColumnWidths());
			}
			catch (Exception ex) 
			{
				GenericControllers.reportError(this, ex.Message);
			}
		}

		/// <summary>
		/// Handles the SelectedIndexChanged event of the SalesPRMonth control.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
		private void SalesPRMonth_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (!salesPrDgvOps.logMonthSelected()) return;
			string month = SalesPRMonth.Text;
			updateSalesPrGridView(month);
		}

		/// <summary>
		/// Handles the Click event of the SalesPRDeleteEntry control.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
		private void SalesPRDeleteEntry_Click(object sender, EventArgs e)
		{
			const string CONFIRM_DELETION = "Are you sure you want to delete the entry in RED?";
			const string DELETION_SUCCEEDED = "The entry has been deleted!";

			if (salesPrDgvOps.noRowSelected()) return;
			if (salesPrDgvOps.selectedRowEmpty()) return;

			salesPrDgvOps.highlightSelectedRowRed();

			_warnings.showWarning(_mainForm, CONFIRM_DELETION, CustomWarning.WarningType.CriticalWarning);

			if (_warnings.actionConfirmed)
			{
				string selectedRow = salesPrDgvOps.getSelectedRowInfo();
				string month = salesPrDgvOps.getSelectedMonth();

				try
				{
					_salesPrModel.deleteEntry(selectedRow, month);
					updateSalesPrGridView(month);
					GenericControllers.reportSuccess(_mainForm, DELETION_SUCCEEDED);
				}
				catch (Exception ex)
				{
					GenericControllers.reportError(_mainForm, ex.Message);
				}
			}
			else
			{
				salesPrDgvOps.removeRowHighlights();
			}
		}

		/// <summary>
		/// Resets the sales police register tab.
		/// </summary>
		private void resetSalesPoliceRegister() 
		{
			SalesPRMonth.SelectedItem = null;
			salesPrDgvOps.resetGridView();
		}
	}
}
