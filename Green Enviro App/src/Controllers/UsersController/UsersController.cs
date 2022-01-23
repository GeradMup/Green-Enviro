using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Green_Enviro_App
{
	public partial class UsersViews : Form
	{
		DGVOps usersDGVOps;
		private bool editingUser = false;
		string currentUserName = "";


		/// <summary>
		/// Initializes the users form.
		/// </summary>
		private void initializeUsers()
		{
			usersDGVOps = new DGVOps(UsersDataGridView, this);
			refreshUsersGrid();
		}

		/// <summary>
		/// Refreshes the users data grid view.
		/// </summary>
		private void refreshUsersGrid() 
		{
			usersDGVOps.changeBindingSource(usersModel.getUsers());
			usersDGVOps.populateGridView(usersGridColumns());
		}

		/// <summary>
		/// Configures the column widths for the users data grid view.
		/// </summary>
		/// <returns></returns>
		private List<float> usersGridColumns() 
		{
			List<float> columns = new List<float>();
			columns.Add(75.0F);
			columns.Add(75.0F);
			columns.Add(75.0F);
			columns.Add(75.0F);
			return columns;
		}

		/// <summary>
		/// Clears the input fields on the users form.
		/// </summary>
		private void clearInputFields()
		{
			Username.Clear();
			Password.Clear();
			Email.Clear();
			PermissionLevel.Value = Constants.DECIMAL_ZERO;
			editingUser = false;
			currentUserName = "";
			Password.ReadOnly = false;
		}

		/// <summary>
		/// Handles the Click event of the UsersDoneBtn control.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
		private void UsersDoneBtn_Click(object sender, EventArgs e)
		{
			clearInputFields();
			closeForm();
		}

		/// <summary>
		/// Handles the CellDoubleClick event of the UsersDataGridView control.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The <see cref="DataGridViewCellEventArgs"/> instance containing the event data.</param>
		private void UsersDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			editingUser = true;
			List<string> selectedRow = usersDGVOps.getSeletedRow();

			Username.Text = selectedRow[0];
			Password.Text = selectedRow[1];
			Email.Text = selectedRow[2];
			PermissionLevel.Value = decimal.Parse(selectedRow[3]);
			Password.ReadOnly = true;
		}

		/// <summary>
		/// Handles the Click event of the UsersAddBtn control.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
		private void UsersAddBtn_Click(object sender, EventArgs e)
		{

		}
	}
}
