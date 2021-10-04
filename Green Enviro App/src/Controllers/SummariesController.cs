using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Green_Enviro_App
{
	using SummariesInfo = SummariesModel.AllSummaries;
	// *******************************************************************************************************************
	// SUMMARIES RELATED CALLS
	// *******************************************************************************************************************
	public partial class Main_Form : Form
	{
		/// <summary>
		/// Intializes all the controls on the summaries tab.
		/// </summary>
		private void intializeSummariesTab() 
		{
			List<string> months = _summariesModel.getMonths();
			//Pupulates the summaries months box with the available months.
			SummariesMonths.Items.AddRange(months.Cast<object>().ToArray());
		}

		private void SummariesMonthSelector_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (SummariesMonths.SelectedItem == null) return;
			string selectedMonth = SummariesMonths.SelectedItem.ToString();
			SummariesInfo summaries =_summariesModel.getSummaries(selectedMonth);
			displaySummaries(summaries);
		}

		private void displaySummaries(SummariesInfo summaries)
		{
			const string rands = "\n R ";
			resetSummaries();
			SummariesFPurchasesBox.AppendText(rands + summaries.totalFerrousPurchases.ToString());
			SummariesNFPurchasesBox.AppendText(rands + summaries.totalNonFerrousPurchases.ToString());
			SummariesTotalPurchases.AppendText(rands + summaries.totalPurchases.ToString());
			SummariesFSalesBox.AppendText(rands + summaries.totalFerrousSales.ToString());
			SummariesNFSalesBox.AppendText(rands + summaries.totalNonFerrousSales.ToString());
			SummariesTotalSales.AppendText(rands + summaries.totalSales.ToString());
			SummariesWagesBox.AppendText(rands + summaries.totalWages.ToString());
			SummariesExpensesBox.AppendText(rands + summaries.totalExpenses.ToString());
			SummariesProfitBox.AppendText(rands + summaries.totalProfit.ToString());

			if (summaries.profitMade) SummariesProfitBox.BackColor = Color.LawnGreen;
			else SummariesProfitBox.BackColor = Color.Red;
		}

		private void resetSummaries()
		{
			SummariesFPurchasesBox.Clear();
			SummariesNFPurchasesBox.Clear();
			SummariesTotalPurchases.Clear();
			SummariesFSalesBox.Clear();
			SummariesNFSalesBox.Clear();
			SummariesTotalSales.Clear();
			SummariesWagesBox.Clear();
			SummariesExpensesBox.Clear();
			SummariesProfitBox.Clear();
			SummariesProfitBox.BackColor = Color.White;
		}
	}
}
