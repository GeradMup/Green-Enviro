using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Green_Enviro_App.src.DataAccess;

namespace Green_Enviro_App
{
	/// <summary>
	/// Class to handle all the customers controls.
	/// </summary>
	/// <seealso cref="System.Windows.Forms.Form" />
	public partial class CustomersViews : Form
	{
		DGVOps customersDgvOps;
		private bool editingCustomer = false;

		/// <summary>
		/// Initializes the customers form.
		/// </summary>
		private void initializeCustomers() 
		{
			customersDgvOps = new DGVOps(CustomersDataGrid, this);
			updateDataGrid();

			EditCustomersGroup.Enabled = false;
			EditCustomersGroup.Visible = false;
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

		/// <summary>
		/// Handles the Click event of the SaveCustomer control.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
		private void SaveCustomer_Click(object sender, EventArgs e)
		{
			const string NO_NAME_ERROR = "Please insert the Customer's name!";
			const string NO_SURNAME_ERROR = "Please insert the Customer's surname!";
			const string NO_ID_ERROR = "Please insert the Customer's ID number!";
			const string NO_CELL_ERROR = "Please insert the Customer's cell number!";
			const string NO_ADDRESS_ERROR = "Please insert the Customer's address!";
			const string NO_CUSTOMER_NUMBER_ERROR = "Please insert the Customer Number!";
			const string CUSTOMER_ADDED = "Customer added or updated!";

			if (EditName.Text == string.Empty) { GenericControllers.reportError(this, NO_NAME_ERROR); return; }
			if (EditSurname.Text == string.Empty) { GenericControllers.reportError(this, NO_SURNAME_ERROR); return; }
			if (EditIDNumber.Text == string.Empty) { GenericControllers.reportError(this, NO_ID_ERROR); return; }
			if (EditCellNumber.Text == string.Empty) { GenericControllers.reportError(this, NO_CELL_ERROR); return; }
			if (EditAddress.Text == string.Empty) { GenericControllers.reportError(this, NO_ADDRESS_ERROR); return; }
			if (EditCustomerNumber.Value == decimal.Zero) { GenericControllers.reportError(this, NO_CUSTOMER_NUMBER_ERROR); return; }

			Customer customer = new Customer();
			customer.CustomerNumber = (int)EditCustomerNumber.Value;
			customer.Name = EditName.Text;
			customer.Surname = EditSurname.Text;
			customer.ID = EditIDNumber.Text;
			customer.Cell = EditCellNumber.Text;
			customer.Address = EditAddress.Text;
			Image idPicture = (IdPictureBox.Image == null) ? null : IdPictureBox.Image;

			try
			{
				if (editingCustomer) { customersModel.updateCustomer(customer, idPicture); }
				else { customersModel.addCustomer(customer, idPicture); }

				updateDataGrid();
				clearEditFields();
				GenericControllers.reportSuccess(this, CUSTOMER_ADDED);
				EditCustomersGroup.Enabled = false;
				EditCustomersGroup.Visible = false;
				EditCustomerNumber.ReadOnly = false;
			}
			catch (Exception ex) 
			{
				string errorMessage = ex.Message;
				GenericControllers.reportError(this, errorMessage);
			}
		}

		/// <summary>
		/// Handles the Click event of the CustomersNewCustomer control.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
		private void CustomersNewCustomer_Click(object sender, EventArgs e)
		{
			editingCustomer = false;
			EditCustomersGroup.Enabled = true;
			EditCustomersGroup.Visible = true;
			EditCustomerNumber.ReadOnly = false;
		}

		/// <summary>
		/// Handles the Click event of the CustomersDeleteBtn control.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
		private void CustomersDeleteBtn_Click(object sender, EventArgs e)
		{

		}

		/// <summary>
		/// Handles the CellContentDoubleClick event of the CustomersDataGrid control.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The <see cref="DataGridViewCellEventArgs"/> instance containing the event data.</param>
		private void CustomersDataGrid_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			const string NO_CUSTOMER_SELECTED = "No customer selected!";
			if (customersDgvOps.noRowSelected()) { GenericControllers.reportError(this, NO_CUSTOMER_SELECTED); return; }

			editingCustomer = true;
			EditCustomersGroup.Enabled = true;
			EditCustomersGroup.Visible = true;

			List<string> selectedRow = customersDgvOps.getSeletedRow();
			int customerNumber = int.Parse(selectedRow[0]);
			
			EditCustomerNumber.ReadOnly = true;
			EditCustomerNumber.Value = (decimal)customerNumber;
			EditIDNumber.Text = selectedRow[1];
			EditName.Text = selectedRow[2];
			EditSurname.Text = selectedRow[3];
			EditCellNumber.Text = selectedRow[4];
			EditAddress.Text = selectedRow[5];
			IdPictureBox.Image = customersModel.getIdPicture(customerNumber);
		}

		/// <summary>
		/// Clears the customer edit fields.
		/// </summary>
		private void clearEditFields() 
		{
			EditCustomerNumber.Value = decimal.Zero;
			EditIDNumber.Clear();
			EditName.Clear();
			EditSurname.Clear();
			EditCellNumber.Clear();
			EditAddress.Clear();
			if (IdPictureBox.Image != null) 
			{
				IdPictureBox.Image.Dispose();
				IdPictureBox.Image = null;
			}
			editingCustomer = false;
		}

		/// <summary>
		/// Handles the Click event of the CancelEdit control.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
		private void CancelEdit_Click(object sender, EventArgs e)
		{
			clearEditFields();
			EditCustomersGroup.Enabled = false;
			EditCustomersGroup.Visible = false;
		}

		/// <summary>
		/// Handles the Click event of the UploadIdPicture control.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
		private void UploadIdPicture_Click(object sender, EventArgs e)
		{
			// open file dialog   
			OpenFileDialog open = new OpenFileDialog();
			// image filters  
			open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
			if (open.ShowDialog() == DialogResult.OK)
			{
				// display image in picture box  
				IdPictureBox.Image = new Bitmap(open.FileName);
			}
		}

		/// <summary>
		/// Handles the Click event of the EditCustomerEdit control.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
		private void EditCustomerEdit_Click(object sender, EventArgs e)
		{
			Object fakeObject = new Object();
			DataGridViewCellEventArgs fakeEventArgument = new DataGridViewCellEventArgs(0,0);
			CustomersDataGrid_CellContentDoubleClick(sender, fakeEventArgument);
		}
	}
}