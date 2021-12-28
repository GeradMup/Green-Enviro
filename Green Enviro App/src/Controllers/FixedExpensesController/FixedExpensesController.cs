using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Green_Enviro_App
{
	using FixedExpenseInfo = FixedExpensesModel.FixedExpenseInfo;
	public partial class FixedExpensesViews
	{
		DGVOps fixedExpensesDGVOps;
		CustomWarning warning;
		private string selectedItemName = "";
		private bool editingFixedExpense = false;
		private string previousExpenseName = "";

		/// <summary>
		/// Initializes the fixed expenses form.</summary>
		private void initializeFixedExpenses() 
		{
			fixedExpensesDGVOps = new DGVOps(FixedExpenseDGV, this);
			warning = new CustomWarning();
		}

		/// <summary>
		/// Updates the fixed expenses grid view.</summary>
		private void updateFixedExpensesGridView() 
		{
			fixedExpensesDGVOps.changeBindingSource(_fixedExpensesModel.getExpenses());
			fixedExpensesDGVOps.populateGridView(columnWidths());
		}

		/// <summary>Configures the column widths of the fixed expenses data grid view.</summary>
		/// <returns>A list of floating point values containing the column widths.</returns>
		private List<float> columnWidths() 
		{
			List<float> columnWidthsValues = new List<float>();
			columnWidthsValues.Add(10.0F);
			columnWidthsValues.Add(150.0F);
			columnWidthsValues.Add(150.0F);
			return columnWidthsValues;
		}

		/// <summary>
		/// Activates the fixed expenses form.</summary>
		public void activateForm() 
		{
			this.Enabled = true;
			this.Activate();
			this.Show();
			updateFixedExpensesGridView();
		}

		/// <summary>
		/// Closes the FixedExpenses form.</summary>
		private void closeForm() 
		{
			parentForm.Enabled = true;
			parentForm.Activate();
			parentForm.Show();

			this.Hide();
			this.Enabled = false;
		}

		/// <summary>Handles the Click event of the DoneBtn control.</summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
		private void DoneBtn_Click(object sender, EventArgs e)
		{
			closeForm();
		}

		/// <summary>
		/// Clears the fixed expense entry fields.</summary>
		private void clearEntryFields() 
		{
			ExpenseName.Text = Constants.EMPTY_TEXT;
			ExpenseAmount.Value = Constants.DECIMAL_ZERO;
			editingFixedExpense = false;
			previousExpenseName = "";
		}

		/// <summary>
		/// Handles the Click event of the AddExpenseBtn control.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
		/// <returns></returns>
		private void AddExpenseBtn_Click(object sender, EventArgs e)
		{
			const string EXPENSE_NAME_NOT_INSERTED = "Please insert the expense description!";
			const string EXPENSE_AMOUNT_NOT_INSERTED = "Please insert the expense amount!";
			const string EXPENSE_ADDED = "Expense added or updated!";

			if (ExpenseName.Text == Constants.EMPTY_TEXT)
			{ GenericControllers.reportError(this, EXPENSE_NAME_NOT_INSERTED); return; }
		
			if((ExpenseAmount.Value == Constants.DECIMAL_ZERO) || (ExpenseAmount.Value.ToString() == Constants.EMPTY_TEXT))
			{ GenericControllers.reportError(this, EXPENSE_AMOUNT_NOT_INSERTED); return; }


			FixedExpenseInfo expenseInfo = new FixedExpenseInfo();
			expenseInfo.name = ExpenseName.Text;
			expenseInfo.amount = ExpenseAmount.Value;

			try
			{
				if (editingFixedExpense) _fixedExpensesModel.updateExpense(expenseInfo, previousExpenseName);
				else _fixedExpensesModel.addExpense(expenseInfo);
				updateFixedExpensesGridView();
				clearEntryFields();
				GenericControllers.reportSuccess(this, EXPENSE_ADDED);
			}
			catch (Exception ex) 
			{
				GenericControllers.reportError(this, ex.Message);
			}
		}

		/// <summary>Handles the Click event of the EditExpenseBtn control.</summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
		private void EditExpenseBtn_Click(object sender, EventArgs e)
		{
			//First check that something is selected first. 
			if (fixedExpensesDGVOps.noRowSelected()) return;

			//Check if the selected row is empty.
			if (fixedExpensesDGVOps.selectedRowEmpty()) return;
			
			List<string> selectedRow = fixedExpensesDGVOps.getSeletedRow();
			selectedItemName = selectedRow[1];

			ExpenseName.Text = selectedRow[1];
			ExpenseAmount.Value = decimal.Parse(selectedRow[2], CultureInfo.InvariantCulture);

			//Flag to indicate that we are currently editing an expense instead of inserting a new expense.
			editingFixedExpense = true;

			//Get the value of the previous expense name so that it can be used as an identifier when updating 
			//the values in the database.
			previousExpenseName = selectedRow[1];

		}

		/// <summary>Handles the Click event of the DeleteExpenseBtn control.</summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
		private void DeleteExpenseBtn_Click(object sender, EventArgs e)
		{
			const string EXPENSE_DELETED = "The expense has been deleted!";
			const string DELETION_WARNING = "You are about to delete the row highlighted in red!";
			//Check if any row has been selected first
			if (fixedExpensesDGVOps.noRowSelected()) return;
			if (fixedExpensesDGVOps.selectedRowEmpty()) return;

			//Warn the user before deleting
			fixedExpensesDGVOps.highlightSelectedRowRed();
			warning.showWarning(this, DELETION_WARNING, CustomWarning.WarningType.CriticalWarning);
			if (warning.actionConfirmed == false) { fixedExpensesDGVOps.removeRowHighlights(); return; }

			List<string> selectedRow = fixedExpensesDGVOps.getSeletedRow();
			string expenseName = selectedRow[1];

			try
			{
				_fixedExpensesModel.deleteExpense(expenseName);
				updateFixedExpensesGridView();
				GenericControllers.reportSuccess(this, EXPENSE_DELETED);
			}
			catch (Exception ex) 
			{
				GenericControllers.reportError(this, ex.Message);
			}
		}
	}
}
