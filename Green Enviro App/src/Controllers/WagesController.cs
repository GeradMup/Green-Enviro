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
		DGVOps wagesDgvOps;

		private void initializeWagesTab() 
		{
			//DGVOps contains methods that makes use of the type ComboBox but since we do not have one for wages, we will create
			//a fake one.
			ComboBox type = new ComboBox();
			wagesDgvOps = new DGVOps(WageLogGridView, WageLogMonths, WageLogStartDate, WageLogEndDate, type, _mainForm);
			wagesDgvOps.populateLogMonths(_wagesModel.getMonths());
			WageDate.Value = DateTime.Now;
		}

		private void WageLogMonth_SelectedIndexChanged(object sender, EventArgs e)
		{
			//Do nothing if no month is selected
			if (WageLogMonths.SelectedItem == null) return;
			string selectedMonth = WageLogMonths.SelectedItem.ToString();

			GridViewData gridData = _wagesModel.gridViewData(selectedMonth);
			wagesDgvOps.populateDates(gridData.dates);
			wagesDgvOps.changeBindingSource(gridData.data);
			wagesDgvOps.populateGridView(wageGridColumnWidths());
		}

		private List<float> wageGridColumnWidths() 
		{
			List<float> colWidths = new List<float>();
			colWidths.Add(180F);
			colWidths.Add(180F);
			colWidths.Add(100F);
			return colWidths;
		}

	}
}
