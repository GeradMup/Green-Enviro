using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FastMember;
using Green_Enviro_App.src.DataAccess;

namespace Green_Enviro_App
{
	using FixedExpensesTableColumns = Database.FixedExpensesTableColumns;

	/// <summary>
	/// Class to handle all the business logic regarding fixed expenses.</summary>
	public class FixedExpensesModel
	{


		/// <summary>
		/// Initializes a new instance of the <see cref="FixedExpensesModel" /> class.</summary>
		public FixedExpensesModel()
		{
		}

		/// <summary>Gets the expenses.</summary>
		/// <returns>A DataTable containing the expenses.</returns>
		public DataTable getExpenses()
		{
			DataTable expenses = new DataTable();
			List<FixedExpens> fixedExpenses;

			try
			{
				using (DataEntities context = new DataEntities()) 
				{
					string name = "Name";
					string amount = "Amount";
					string id = "Id";
					fixedExpenses = context.FixedExpenses.ToList();
					using (ObjectReader reader = ObjectReader.Create(fixedExpenses, id, name, amount )) 
					{
						expenses.Load(reader);
					}
				}

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
			DataTable expenses;
			try
			{
				using (DataEntities context = new DataEntities()) 
				{
					FixedExpens newExpense = new FixedExpens()
					{
						Name = expenseInfo.name,
						Amount = expenseInfo.amount
					};

					context.FixedExpenses.Add(newExpense);
					context.SaveChanges();
				}
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
			DataTable expenses;
			try
			{
				using (DataEntities context = new DataEntities()) 
				{
					FixedExpens expense = context.FixedExpenses.SingleOrDefault(_exp => _exp.Name == expenseName);
					if (expense != null) 
					{
						expense.Name = expenseInfo.name;
						expense.Amount = expenseInfo.amount;
						context.SaveChanges();
					}
				}
				expenses = getExpenses();
			}
			catch (Exception ex) 
			{
				throw new Exception(ex.Message);
			}
			return expenses;
		}

		/// <summary>Deletes the fixed expense given its name and returns an updated data grid after the deletion.</summary>
		/// <param name="expenseName">Name of the expense.</param>
		/// <returns>The updated fixed expenses after the deletion.</returns>
		/// <exception cref="System.Exception"></exception>
		public DataTable deleteExpense(string expenseName) 
		{
			DataTable expenses;
			try
			{
				using (DataEntities context = new DataEntities()) 
				{
					context.FixedExpenses.Remove(context.FixedExpenses.Single(exp => exp.Name == expenseName));
					context.SaveChanges();
				}

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
