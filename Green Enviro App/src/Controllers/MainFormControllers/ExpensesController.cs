using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Green_Enviro_App
{
	using GridViewData = DGVOps.GridViewData;
	using ExpensesInfo = ExpensesModel.ExpenseInfo;

	public partial class Main_Form : Form
	{
		DGVOps expensesDgvOps;

		/// <summary>
		/// Initializes all the controls on the Expenses Tab Page.
		/// </summary>
		private void initializeExpensesTab()
		{
			//DGVOps contains methods that makes use of the type ComboBox but since we do not have one for wages, we will create
			//a fake one.
			ComboBox fakeType = new ComboBox();
			expensesDgvOps = new DGVOps(ExpensesLogGridView, ExpensesLogMonths, ExpensesLogStartDate, ExpensesLogEndDate, fakeType, _mainForm);
			expensesDgvOps.populateLogMonths(_expensesModel.getMonths());
			ExpenseDate.Value = DateTime.Now;
			expensesDgvOps.setupTotalsRow(_expensesModel.getAmountColumn());
		}

		/// <summary>Updates the expenses grid view given the grid data.</summary>
		/// <param name="gridData">The grid data.</param>
		private void updateExpensesGridView(GridViewData gridData) 
		{
			expensesDgvOps.populateDates(gridData.dates);
			expensesDgvOps.changeBindingSource(gridData.data);
			expensesDgvOps.populateGridView(expensesGridColumnWidths());
		}

		/// <summary>
		/// Configures the expenseses grid column widths.
		/// </summary>
		/// <returns>A list of floating point vaues representing the column widthsfrom left to right.</returns>
		private List<float> expensesGridColumnWidths() 
		{
			List<float> colWidths = new List<float>();
			colWidths.Add(120.0F);
			colWidths.Add(150.0F);
			colWidths.Add(50.0F);
			return colWidths;
		}

		/// <summary>Handles the Click event of the AddExpenseBtn control.</summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
		private void AddExpenseBtn_Click(object sender, EventArgs e)
		{
			const string NO_DESCRIPTION_ERROR = "Please insert the description of the expense!";
			const string NO_AMOUNT_ERROR = "Please insert the amount of the expense!";
			const string EXPENSE_ADDED_SUCCESSFULLY = "Expense has been recorded!";

			//First check that there is a description inserted.
			if (ExpenseDescription.Text == Constants.EMPTY_TEXT) 
			{ GenericControllers.reportError(_mainForm, NO_DESCRIPTION_ERROR); return; }

			//Check that the user has inserted tha amount of the expense.
			if (ExpenseAmount.Value == Constants.DECIMAL_ZERO) 
			{ GenericControllers.reportError(_mainForm, NO_AMOUNT_ERROR); return; }

			//Remove all filters before trying to add an expense.
			expensesDgvOps.removeGridViewFilters();

			ExpensesInfo expenseInfo = new ExpensesInfo();
			expenseInfo.date = ExpenseDate.Value;
			expenseInfo.description = ExpenseDescription.Text;
			expenseInfo.amount = ExpenseAmount.Value;
			string logMonth = ExpenseDate.Value.ToString(Constants.LOG_NAME_DATE_FORMAT);
			try
			{
				GridViewData updatedGridData = _expensesModel.addExpense(expenseInfo);
				updateExpensesGridView(updatedGridData);
				clearExpensesEntryFields();
				expensesDgvOps.selectMonth(logMonth);
				GenericControllers.reportSuccess(_mainForm, EXPENSE_ADDED_SUCCESSFULLY);
			}
			catch (Exception ex) 
			{
				GenericControllers.reportError(_mainForm, ex.Message);
			}

		}

		/// <summary>Handles the SelectedIndexChanged event of the ExpensesLogMonth control.</summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
		private void ExpensesLogMonth_SelectedIndexChanged(object sender, EventArgs e)
		{
			if(ExpensesLogMonths.SelectedItem == null) return;
			string selectedMonth = ExpensesLogMonths.SelectedItem.ToString();
			updateExpensesGridView(_expensesModel.gridViewData(selectedMonth)); ;
		}

		/// <summary>Handles the Click event of the ExpensesLogFilterBtn control.</summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
		private void ExpensesLogFilterBtn_Click(object sender, EventArgs e)
		{
			expensesDgvOps.filterGridView();
		}

		/// <summary>Handles the Click event of the ExpensesLogRemoveFiltersBtn control.</summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
		private void ExpensesLogRemoveFiltersBtn_Click(object sender, EventArgs e)
		{
			expensesDgvOps.removeGridViewFilters();
		}

		/// <summary>Handles the Click event of the DeleteExpenseBtn control.</summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
		private void DeleteExpenseBtn_Click(object sender, EventArgs e)
		{
			const string NO_SELECTION_ERROR = "Please select the expense to be deleted";
			const string DELETING_TOTALS_ERROR = "It's not possible to delete the TOTALS row";
			const string DELETING_WARNING_MESSAGE = "Are you sure you want to delete this entry?";
			//Verify that something is selected before attempting to delete
			if (expensesDgvOps.noRowSelected())
			{ GenericControllers.reportError(_mainForm, NO_SELECTION_ERROR); return; }

			//Confirm that the user is not trying to delete the totals row
			if (expensesDgvOps.totalsRowSelected())
			{ GenericControllers.reportError(_mainForm, DELETING_TOTALS_ERROR); return; }

			//Highlight the rows that will be deleted if the user chooses to confirm
			expensesDgvOps.highlightSelectedRowRed();
			_warnings.showWarning(_mainForm, DELETING_WARNING_MESSAGE, Warning.WarningType.CriticalWarning);

			//Check if the user has confirmed the deletion of the row
			if (_warnings.actionConfirmed)
			{
				string rowToDelete = expensesDgvOps.getSelectedRowInfo();
				string month = ExpensesLogMonths.SelectedItem.ToString();
				GridViewData newGridData = _expensesModel.deleteExpense(rowToDelete, month);
				updateExpensesGridView(newGridData);
			}
			else expensesDgvOps.removeRowHighlights();
		}

		/// <summary>Handles the Click event of the ClearExpenseFieldsBtn control.</summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
		private void ClearExpenseFieldsBtn_Click(object sender, EventArgs e)
		{
			resetExpenses();
		}

		/// <summary>
		/// Clears the expenses entry fields.</summary>
		private void clearExpensesEntryFields() 
		{
			ExpenseAmount.Value = Constants.DECIMAL_ZERO;
			ExpenseDescription.Text = Constants.EMPTY_TEXT;
		}

		/// <summary>
		/// Resets the expenses tab page.
		/// </summary>
		private void resetExpenses() 
		{
			clearExpensesEntryFields();
			ExpenseDate.Value = DateTime.Now;
			ExpensesLogMonths.SelectedItem = null;
			ExpensesLogStartDate.SelectedItem = null;
			ExpensesLogEndDate.SelectedItem = null;
			expensesDgvOps.resetGridView();
		}

		/// <summary>Handles the Click event of the EditFixedExpensesBtn control.</summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
		private void EditFixedExpensesBtn_Click(object sender, EventArgs e)
		{
			this.Enabled = false;
			_fixedExpensesViews.activateForm();
		}
	}
}
