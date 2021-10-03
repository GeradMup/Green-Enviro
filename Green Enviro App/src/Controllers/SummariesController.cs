using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Green_Enviro_App
{
	using SummariesInfo = SummariesModel.Summaries;
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
			//Do nothing if no month is selected
			if (SummariesMonths.SelectedItem == null) return;
			string selectedMonth = SummariesMonths.SelectedItem.ToString();
			SummariesInfo summaries =_summariesModel.getSummaries(selectedMonth);
		}
	}
}
