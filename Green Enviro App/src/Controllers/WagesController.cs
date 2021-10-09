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
		DGVOps wagesDgvOps;

		private void initializeWagesTab() 
		{
			ComboBox type = null;
			wagesDgvOps = new DGVOps(WageLogGridView, WageLogMonths, WageLogStartDate, WageLogEndDate, type, _mainForm);

			List<string> logMonths = _wagesModel.getMonths();
			WageLogMonths.Items.AddRange(logMonths.Cast<object>().ToArray());
		}
	}
}
