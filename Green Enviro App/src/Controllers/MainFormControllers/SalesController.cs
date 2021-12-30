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
		DGVOps salesDgvOps;

		/// <summary>
		/// Initializes the sales tab.
		/// </summary>
		private void initializeSalesTab() 
		{
			salesDgvOps = new DGVOps(SalesLogGridView, SalesLogMonth, SalesLogStartDate, SalesLogEndDate, SalesLogType, _mainForm);
			salesDgvOps.populateLogMonths(_salesModel.getMonths());
			SaleDate.Value = DateTime.Now;
			salesDgvOps.setupTotalsRow(_salesModel.getAmountColumn(), _salesModel.getQuantityColumn());
			salesDgvOps.setTypes();
		}

		/// <summary>
		/// Updates the sales grid view.
		/// </summary>
		/// <param name="month">The month.</param>
		/// <returns></returns>
		private void updateSalesGridView(string month) 
		{
			try
			{
				DGVOps.GridViewData gridData = _salesModel.getGridData(month);
				salesDgvOps.populateDates(gridData.dates);
				salesDgvOps.changeBindingSource(gridData.data);
				salesDgvOps.populateGridView(salesGridColumnWidths());
			}
			catch (Exception ex) 
			{
				GenericControllers.reportError(_mainForm, ex.Message);
			}
		}

		/// <summary>
		/// Configures the column widths for the sales data grid view.
		/// </summary>
		/// <returns>A list of floatin point values representing the column widths</returns>
		private List<float> salesGridColumnWidths() 
		{
			List<float> columnWidths = new List<float>();
			columnWidths.Add(120.0F);
			columnWidths.Add(80.0F);
			columnWidths.Add(50.0F);
			columnWidths.Add(40.0F);
			columnWidths.Add(40.0F);
			
			return columnWidths;
		}

		/// <summary>Handles the SelectedIndexChanged event of the SalesLogMonth control.</summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
		private void SalesLogMonth_SelectedIndexChanged(object sender, EventArgs e)
		{
			if(salesDgvOps.logMonthSelected() == false) return;
			string month = SalesLogMonth.SelectedItem.ToString();
			updateSalesGridView(month);
		}

		/// <summary>Handles the Click event of the FilterSalesLogBtn control.</summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
		private void FilterSalesLogBtn_Click(object sender, EventArgs e)
		{
			salesDgvOps.filterGridView();
		}

		/// <summary>Handles the Click event of the SalesLogRemoveFiltersBtn control.</summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
		private void SalesLogRemoveFiltersBtn_Click(object sender, EventArgs e)
		{
			salesDgvOps.removeGridViewFilters();
		}

		private void resetSales() 
		{
		
		}

		private void SalesLogDeleteBtn_Click(object sender, EventArgs e)
		{
			const string CANNOT_DELETE_TOTALS = "You cannot delete the totals!";
			const string NO_ROW_SELECTED = "You have not selected a row to delete!";
			const string DELETION_WARNING = "Warning\nYou are about to delete the entry highlighted in red!";

			if (salesDgvOps.selectedRowEmpty()) return;
			if (salesDgvOps.noRowSelected()) { GenericControllers.reportError(_mainForm, NO_ROW_SELECTED); return; }
			if (salesDgvOps.totalsRowSelected()) { GenericControllers.reportError(_mainForm, CANNOT_DELETE_TOTALS); return; }

			salesDgvOps.highlightSelectedRowRed();
			//Show waring before proceeding.

			_warnings.showWarning(_mainForm, DELETION_WARNING, CustomWarning.WarningType.CriticalWarning);
			if (_warnings.actionConfirmed == false) { salesDgvOps.removeRowHighlights(); return; }



		}


		private void NewCompanyCheckBox_CheckedChanged(object sender, EventArgs e)
		{
			//_sales.UnknownCompany();
		}

		private void AddSaleBtn_Click(object sender, EventArgs e)
		{
			if ((_user_permission_level == 4) || (_user_permission_level == 5))
			{
				//_sales.AddSale();
			}
			else
			{
				PermissionDenied();
			}

		}

		private void ClearSalesFields_Click(object sender, EventArgs e)
		{
			//_sales.ClearFields();
		}
	}
}
