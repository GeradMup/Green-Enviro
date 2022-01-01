using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Green_Enviro_App
{
	using SaleInfo = SalesModel.SaleInfo;
	public partial class Main_Form : Form
	{
		DGVOps salesDgvOps;

		/// <summary>
		/// Initializes the sales tab.
		/// </summary>
		private void initializeSalesTab() 
		{
			salesDgvOps = new DGVOps(SalesLogGridView, SalesLogMonth, SalesLogStartDate, SalesLogEndDate, SalesLogType, _mainForm);
			SaleDate.Value = DateTime.Now;
			salesDgvOps.setupTotalsRow(_salesModel.getAmountColumn(), _salesModel.getQuantityColumn());
			salesDgvOps.setTypes();
			salesDgvOps.populateComboBox(SaleType, new List<string>(){Constants.FERROUS, Constants.NON_FERROUS });
			try
			{
				salesDgvOps.populateComboBox(SaleCompanyName, _salesModel.getCompanies());
				salesDgvOps.populateLogMonths(_salesModel.getMonths());
			}
			catch (Exception ex) 
			{
				GenericControllers.reportError(_mainForm, ex.Message);
			}
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

		/// <summary>Handles the Click event of the SalesLogDeleteBtn control.</summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
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
			if (_warnings.actionConfirmed)
			{
				string rowToDelete = salesDgvOps.getSelectedRowInfo();
				string month = salesDgvOps.getSelectedMonth();
				try
				{
					_salesModel.deleteSale(rowToDelete, month);
					updateSalesGridView(month);
				}
				catch (Exception ex) 
				{
					GenericControllers.reportError(_mainForm, ex.Message);
				}
			}
			else 
			{
				salesDgvOps.removeRowHighlights(); 
				return;
			}
		}

		/// <summary>Handles the Click event of the AddSaleBtn control.</summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
		private void AddSaleBtn_Click(object sender, EventArgs e)
		{
			const string NO_COMPANY_ERROR = "Please selected the company where the sale was made!";
			const string NO_SALE_TYPE_ERROR = "Please selected the sale type!";
			const string NO_QUANTITY_ERROR = "Please insert the quanitity of the sale!";
			const string NO_AMOUNT_ERROR = "Please insert the amount of the sale!";
			const string SALE_RECORDED = "The sale has been recorded!";

			if (SaleCompanyName.Text == Constants.EMPTY_TEXT) { GenericControllers.reportError(_mainForm, NO_COMPANY_ERROR); return; }
			if (SaleType.Text == Constants.EMPTY_TEXT) { GenericControllers.reportError(_mainForm, NO_SALE_TYPE_ERROR); return; }
			if (SaleQuantity.Value == Constants.DECIMAL_ZERO) { GenericControllers.reportError(_mainForm, NO_QUANTITY_ERROR); return; }
			if (SaleAmount.Value == Constants.DECIMAL_ZERO) { GenericControllers.reportError(_mainForm, NO_AMOUNT_ERROR); return; }

			SaleInfo saleInfo = new SaleInfo();
			saleInfo.date = SaleDate.Value;
			saleInfo.company = SaleCompanyName.Text;
			saleInfo.quantity = SaleQuantity.Value;
			saleInfo.amount = SaleAmount.Value;
			saleInfo.type = SaleType.Text;

			string currentLogMonth = SaleDate.Value.ToString(Constants.LOG_NAME_DATE_FORMAT);

			try
			{
				_salesModel.addSale(saleInfo);
				salesDgvOps.selectMonth(currentLogMonth);
				GenericControllers.reportSuccess(_mainForm, SALE_RECORDED);
				clearSalesFields();
			}
			catch (Exception ex) 
			{
				GenericControllers.reportError(_mainForm, ex.Message);
			}
		}

		/// <summary>Handles the Click event of the ClearSalesFields control.</summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
		private void ClearSalesFields_Click(object sender, EventArgs e)
		{
			clearSalesFields();
		}

		/// <summary>
		/// Clears the sales ebtry fields except the date.
		/// </summary>
		private void clearSalesFields() 
		{
			SaleCompanyName.SelectedItem = null;
			SaleQuantity.Value = Constants.DECIMAL_ZERO;
			SaleAmount.Value = Constants.DECIMAL_ZERO;
			SaleType.SelectedItem = null;
		}

		/// <summary>
		/// Resets the sales tab page.</summary>
		private void resetSales()
		{
			clearSalesFields();
			SaleDate.Value = DateTime.Now;
			salesDgvOps.resetGridView();
			SalesLogMonth.SelectedItem = null;
			SalesLogStartDate.SelectedItem = null;
			SalesLogEndDate.SelectedItem = null;
			SalesLogType.SelectedItem = null;
		}
	}
}
