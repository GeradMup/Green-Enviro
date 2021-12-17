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

		/// <summary>Initializes all the controls on the Expenses Tab Page.</summary>
		DGVOps expensesDgvOps;
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

		private void updateExpensesGridView(GridViewData gridData) 
		{
			expensesDgvOps.populateDates(gridData.dates);
			expensesDgvOps.changeBindingSource(gridData.data);
			expensesDgvOps.populateGridView(expensesGridColumnWidths());
		}

		private List<float> expensesGridColumnWidths() 
		{
			List<float> colWidths = new List<float>();
			colWidths.Add(120.0F);
			colWidths.Add(150.0F);
			colWidths.Add(50.0F);
			return colWidths;
		}

		private void AddExpenseBtn_Click(object sender, EventArgs e)
		{
			// _expenses.AddExpense();
			// _expenses.DisplayExpensesLog();

			/*
            if ((_user_permission_level == 4) || (_user_permission_level == 5))
            {
                _expenses.AddExpense();
                _expenses.DisplayExpensesLog();
            }
            else 
            {
                PermissionDenied();
            }*/

		}

		private void ExpensesLogMonth_SelectedIndexChanged(object sender, EventArgs e)
		{
			if(ExpensesLogMonths.SelectedItem == null) return;
			string selectedMonth = ExpensesLogMonths.SelectedItem.ToString();
			updateExpensesGridView(_expensesModel.gridViewData(selectedMonth)); ;
		}



		private void ExpensesLogFilterBtn_Click(object sender, EventArgs e)
		{
			//_expenses.DisplayExpensesLog();
		}

		private void ExpensesLogRemoveFiltersBtn_Click(object sender, EventArgs e)
		{
			//_expenses.RemoveFilters();
		}

		private void ClearExpenseFieldsBtn_Click(object sender, EventArgs e)
		{
			//_expenses.ClearFields();
		}

		private void resetExpenses() { }
	}
}
