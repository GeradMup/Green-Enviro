using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Green_Enviro_App
{
	using FixedExpensesTableColumns = Database.FixedExpensesTableColumns;

	/// <summary>
	/// Class to handle all the business logic regarding fixed expenses.</summary>
	public class FixedExpensesModel
	{
		Database database;

		/// <summary>Initializes a new instance of the <see cref="FixedExpensesModel" /> class.</summary>
		/// <param name="db">The database.</param>
		public FixedExpensesModel(Database db)
		{
			database = db;
		}

		/// <summary>Gets the expenses.</summary>
		/// <returns>A DataTable containing the expenses.</returns>
		public DataTable getExpenses()
		{
			DataTable expenses;

			try
			{
				expenses = database.selectAll(Database.Tables.FixedExpenses);
			}
			catch (Exception ex) 
			{
				throw new Exception(ex.Message);
			}
			return expenses;
		}

		/// <summary>Adds a new expense to the database.</summary>
		/// <returns>Returns a DataTable with the updated fixed expenses.</returns>
		public DataTable addExpense(FixedExpenseInfo expenseInfo) 
		{
			string[] expenseInfoString = {expenseInfo.name, expenseInfo.amount.ToString() };
			DataTable expenses;
			try
			{
				database.insert(Database.Tables.FixedExpenses, expenseInfoString);
				expenses = getExpenses();
			}
			catch (Exception ex) 
			{
				throw new Exception(ex.Message);
			}
			return expenses;
		}

		/// <summary>Updates expense information in the database.</summary>
		/// <param name="expenseInfo">The expense information.</param>
		/// <param name="expenseName">Name of the expense.</param>
		/// <returns>A DataTable with the updated expenses.</returns>
		/// <exception cref="System.Exception">If something goes wrong with the database update or selection.</exception>
		public DataTable updateExpense(FixedExpenseInfo expenseInfo, string expenseName) 
		{
			FixedExpensesTableColumns[] tableColumns = GenericModels.enumFieldsToList<FixedExpensesTableColumns>();
			FixedExpensesTableColumns expenseNameColumn = FixedExpensesTableColumns.Name;
			string[] expenseInfoString = { expenseInfo.name, expenseInfo.amount.ToString() };
			DataTable expenses;
			try
			{
				System.Windows.Forms.MessageBox.Show(expenseInfoString[1]);

				database.update<FixedExpensesTableColumns>(Database.Tables.FixedExpenses, tableColumns, expenseNameColumn, expenseName, expenseInfoString);
				expenses = getExpenses();
			}
			catch (Exception ex) 
			{
				throw new Exception(ex.Message);
			}
			return expenses;
		}

		/// <summary>
		/// Internal class to describe the FixedExpenses object.</summary>
		public class FixedExpenseInfo
		{
			/// <summary>
			/// Initializes a new instance of the <see cref="FixedExpenseInfo" /> class.</summary>
			public FixedExpenseInfo()
			{
				name = "";
				amount = Constants.DECIMAL_ZERO;
			}

			/// <summary>Gets or sets the name of the expense.</summary>
			/// <value>The name of the expense.</value>
			public string name { get; set; }

			/// <summary>Gets or sets the amount that the expense costs.</summary>
			/// <value>The amount that the expense costs.</value>
			public decimal amount { get; set; }
		}
	}
}
