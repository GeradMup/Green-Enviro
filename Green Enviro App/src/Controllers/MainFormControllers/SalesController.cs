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

		private void initializeSalesTab() 
		{
			
		}

		private void resetSales() 
		{
		
		}

		private void DeleteSaleBtn_Click(object sender, EventArgs e)
		{
			//_sales.DeleteSale();
		}

		private void FilterSalesLogBtn_Click(object sender, EventArgs e)
		{
			//_sales.DisplaySalesLog();
		}

		private void SalesLogMonth_SelectedIndexChanged(object sender, EventArgs e)
		{
			//_sales.MonthSelected();
		}

		private void NewCompanyCheckBox_CheckedChanged(object sender, EventArgs e)
		{
			//_sales.UnknownCompany();
		}

		private void AddSaleBtn_Click(object sender, EventArgs e)
		{
			if ((_user_permission_level == 4) || (_user_permission_level == 5))
			{
				//_sales.AddSale();
			}
			else
			{
				PermissionDenied();
			}

		}

		private void RemoveSalesLogFiltersBtn_Click(object sender, EventArgs e)
		{
			//_sales.RemoveFilters();
		}

		private void ClearSalesFields_Click(object sender, EventArgs e)
		{
			//_sales.ClearFields();
		}
	}
}
