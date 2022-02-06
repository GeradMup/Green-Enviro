using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Green_Enviro_App
{
	/// <summary>
	/// Class to handle all the customers controls.
	/// </summary>
	/// <seealso cref="System.Windows.Forms.Form" />
	public partial class CustomersViews : Form
	{
		DGVOps customersDgvOps;

		/// <summary>
		/// Initializes the customers form.
		/// </summary>
		private void initializeCustomers() 
		{
			customersDgvOps = new DGVOps(CustomersDataGrid, this);
			updateDataGrid();
		}

		/// <summary>
		/// Configures the column widths for the Customers data grid.
		/// </summary>
		/// <returns>A List of floats representing the column widths. </returns>
		private List<float> columnWidths() 
		{
			List<float> colWidths = new List<float>();
			colWidths.Add(20.0F); 
			colWidths.Add(50.0F); 
			colWidths.Add(40.0F); 
			colWidths.Add(40.0F); 
			colWidths.Add(40.0F); 
			colWidths.Add(60.0F);
			return colWidths;
		}

		/// <summary>
		/// Updates the customers data grid.
		/// </summary>
		private void updateDataGrid() 
		{
			customersDgvOps.changeBindingSource(customersModel.getCustomers());
			customersDgvOps.populateGridView(columnWidths());
		}

		/// <summary>
		/// Handles the Click event of the CustomersDoneBtn control.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
		private void CustomersDoneBtn_Click(object sender, EventArgs e)
		{
			Exit();
		}

		/// <summary>
		/// Handles the TextChanged event of the CustomersName control.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
		private void CustomersName_TextChanged(object sender, EventArgs e)
		{
			string columnName = "Name";
			string customerName = CustomersName.Text;
			customersDgvOps.filterGridView(columnName, customerName);
		}

		/// <summary>
		/// Handles the TextChanged event of the CustomersSurname control.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
		private void CustomersSurname_TextChanged(object sender, EventArgs e)
		{
			string columnName = "Surname";
			string customerSurname = CustomersSurname.Text;
			customersDgvOps.filterGridView(columnName, customerSurname);
		}

		/// <summary>
		/// Handles the TextChanged event of the CustomersIdentification control.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
		private void CustomersIdentification_TextChanged(object sender, EventArgs e)
		{
			string columnName = "ID";
			string customerId = CustomersIdentification.Text;
			customersDgvOps.filterGridView(columnName, customerId);
		}

	}
}