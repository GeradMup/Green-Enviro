using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Green_Enviro_App.src.DataAccess;

namespace Green_Enviro_App
{
	
	public partial class UsersViews : Form
	{
		DGVOps usersDGVOps;
		private bool editingUser = false;
		string currentlySelectedUserName = "";


		/// <summary>
		/// Initializes the users form.
		/// </summary>
		private void initializeUsers()
		{
			usersDGVOps = new DGVOps(UsersDataGridView, this);
			refreshUsersGrid();
			ChangePasswordGroup.Visible = false;
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
			ConfirmPassword.Clear();
			Email.Clear();
			PermissionLevel.Value = Constants.DECIMAL_ZERO;
			editingUser = false;
			currentlySelectedUserName = "";
			Password.ReadOnly = false;
			ConfirmPassword.ReadOnly = false;
		}

		/// <summary>
		/// Clears the password edit inputs.
		/// </summary>
		private void clearPasswordEditInputs() 
		{
			ChangePasswordUsername.Text = "";
			NewPassword.Clear();
			NewPasswordConfirm.Clear();
			OldPassword.Clear();
			currentlySelectedUserName = "";
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
			currentlySelectedUserName = selectedRow[0];
			Password.Text = selectedRow[1];
			ConfirmPassword.Text = selectedRow[1];
			Email.Text = selectedRow[2];
			PermissionLevel.Value = decimal.Parse(selectedRow[3]);
			Password.ReadOnly = true;
			ConfirmPassword.ReadOnly = true;
		}

		/// <summary>
		/// Handles the Click event of the UsersAddBtn control.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
		private void UsersAddBtn_Click(object sender, EventArgs e)
		{
			const string NO_USERNAME_ERROR = "Please insert the User Name!";
			const string NO_PASSWORD_ERROR = "Please insert the Password";
			const string PASSWORDS_ERROR = "Passwords do not match!";
			const string NO_EMAIL_ERROR = "Please insert an email address";
			const string INVALID_PERMISSIONS = "Invalid Permission Level!";
			const string USER_UPDATED = "User has been added or updated!";
			const decimal MAX_PERMISSION = 5;
			const decimal MIN_PERMISSION = 1;

			if(Username.Text == Constants.EMPTY_TEXT) { GenericControllers.reportError(this, NO_USERNAME_ERROR); return; }
			if(Password.Text == Constants.EMPTY_TEXT) { GenericControllers.reportError(this, NO_PASSWORD_ERROR); return; }
			if(Password.Text != ConfirmPassword.Text) { GenericControllers.reportError(this, PASSWORDS_ERROR); return; }
			if(Email.Text == Constants.EMPTY_TEXT) { GenericControllers.reportError(this, NO_EMAIL_ERROR); return; }
			if((PermissionLevel.Value < MIN_PERMISSION) || (PermissionLevel.Value > MAX_PERMISSION)) { GenericControllers.reportError(this, INVALID_PERMISSIONS); return; }

			User newUser = new User();
			newUser.Username = Username.Text;
			newUser.Password = Password.Text;
			newUser.Email = Email.Text;
			newUser.PermissionLevel = (int)PermissionLevel.Value;

			try
			{
				if (Password.ReadOnly == true)
				{
					//If the password field is read only, we are editing the user information.
					usersModel.updateUser(currentlySelectedUserName, newUser);
				}
				else 
				{
					//If the password field is not readonly, we are inserting a new user.
					usersModel.addUser(newUser);
				}
				clearInputFields();
				refreshUsersGrid();
				GenericControllers.reportSuccess(this, USER_UPDATED);
			}
			catch (Exception ex) 
			{
				GenericControllers.reportError(this, ex.Message);
			}
		}

		/// <summary>
		/// Handles the Click event of the UsersDeleteBtn control.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
		private void UsersDeleteBtn_Click(object sender, EventArgs e)
		{
			const string DELETE_WARNING = "You are about to delete the user from the database!";
			if (usersDGVOps.noRowSelected()) return;
			usersDGVOps.highlightSelectedRowRed(); ;

			bool deletionConfirmed = false;
			using (CustomWarning warning = new CustomWarning()) 
			{
				warning.showWarning(this, DELETE_WARNING, CustomWarning.WarningType.CriticalWarning);
				deletionConfirmed = warning.actionConfirmed;
			}

			if (deletionConfirmed)
			{
				List<string> selectedRow = usersDGVOps.getSeletedRow();
				string userName = selectedRow[0];
				usersModel.deleteUser(userName);
				refreshUsersGrid();
				clearInputFields();
			}
			else 
			{
				usersDGVOps.removeRowHighlights();
			}

		}

		/// <summary>
		/// Handles the Click event of the UsersCancelBtn control.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
		private void UsersCancelBtn_Click(object sender, EventArgs e)
		{
			clearInputFields();
		}

		/// <summary>
		/// Handles the Click event of the ChangePasswordBtn control.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
		private void ChangePasswordBtn_Click(object sender, EventArgs e)
		{
			const string ERROR = "Please double click on the user whose password you want to change!";

			if (Password.ReadOnly == false) { GenericControllers.reportError(this, ERROR); return; }

			ChangePasswordGroup.Visible = true;
			ChangePasswordUsername.Text = Username.Text;

		}

		/// <summary>
		/// Handles the Click event of the EditPasswordCancelBtn control.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
		private void EditPasswordCancelBtn_Click(object sender, EventArgs e)
		{
			clearPasswordEditInputs();
			ChangePasswordGroup.Visible = false;
		}

		/// <summary>
		/// Handles the Click event of the EditPasswordDoneBtn control.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
		private void EditPasswordDoneBtn_Click(object sender, EventArgs e)
		{
			const string OLD_PASSWORD_ERROR = "Incorrect old password!";
			const string NO_OLD_PASSWORD = "Please insert the old password!";
			const string NO_NEW_PASSORD = "Please insert the new password!";
			const string NO_CONFIRM_PASSWORD = "Please confirm the new new password!";
			const string PASSWORDS_NOT_MATCHING = "New passwords do not match!";
			const string PASSWORD_UPDATED = "Password has been updated successfully!";

			string oldPassword = OldPassword.Text.Trim();
			string newPassword = NewPassword.Text.Trim();
			string newPasswordConfirm = NewPasswordConfirm.Text.Trim();
			string userName = ChangePasswordUsername.Text;

			if (oldPassword == String.Empty) { GenericControllers.reportError(this, NO_OLD_PASSWORD); return; }
			if (newPassword == String.Empty) { GenericControllers.reportError(this, NO_NEW_PASSORD); return; }
			if (newPasswordConfirm == String.Empty) { GenericControllers.reportError(this, NO_CONFIRM_PASSWORD); return; }
			if (newPassword != newPasswordConfirm) { GenericControllers.reportError(this, PASSWORDS_NOT_MATCHING); return; }

			bool passwordUpdated = usersModel.updatePassword(userName, oldPassword, newPassword);

			if (passwordUpdated)
			{
				GenericControllers.reportSuccess(this, PASSWORD_UPDATED);
				clearPasswordEditInputs();
				clearInputFields();
				ChangePasswordGroup.Visible = false;
				refreshUsersGrid();
			}
			else 
			{
				GenericControllers.reportError(this, OLD_PASSWORD_ERROR);
			}
		}
	}
}
