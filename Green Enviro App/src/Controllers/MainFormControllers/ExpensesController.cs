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
			//wagesDgvOps.populateComboBox(WagesEmployeeName, _wagesModel.getEmployees());
			//WageDate.Value = DateTime.Now;
		}
	}
}
