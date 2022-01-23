using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Green_Enviro_App.src.DataAccess;

namespace Green_Enviro_App
{
	public partial class LoginViews : Form
	{
		Main_Form _mainForm;
		LoginModel _loginModel;
		private const int adminUserLevel = 3;

		/// <summary>
		/// Intializes the login form.
		/// </summary>
		private void intializeLoginForm() 
		{
			_loginModel = new LoginModel();
			if (userPermissionLevel != -1) 
			{
				_mainForm = new Main_Form(this, userPermissionLevel);
				startMainProgram();
			}
			
		}

		/// <summary>
		/// Handles the Click event of the LoginBtn control.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
		private void LoginBtn_Click(object sender, EventArgs e)
		{
			const string INVALID_CREDENTIALS_ERROR = "Invalid credentials!";

			if ((Username.Text == Constants.EMPTY_TEXT) || (Password.Text == Constants.EMPTY_TEXT)) 
			{ GenericControllers.reportError(this, INVALID_CREDENTIALS_ERROR); return; }

			string userName = Username.Text.Trim();
			string password = Password.Text.Trim();
			userPermissionLevel = _loginModel.verifyCredentials(userName, password);

			if(userPermissionLevel == -1) { GenericControllers.reportError(this, INVALID_CREDENTIALS_ERROR); return; }

			//If the password has been verified, lets start the main program.
			promptDatabaseSnyc();
			
		}

		/// <summary>
		/// Handles the Click event of the ManageUsers control.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
		private void ManageUsers_Click(object sender, EventArgs e)
		{
			UsersModel usersModel = new UsersModel();
			UsersViews usersVeiws = new UsersViews(usersModel);
			usersVeiws.activateForm(this);
		}

		/// <summary>
		/// Starts the main program.
		/// </summary>
		private void startMainProgram()
		{
			clearLoginFields();
			this.Hide();
			_mainForm.Activate();
			_mainForm.Show();
		}

		/// <summary>
		/// Prompts the user if they want to update the database if there is an active internet connection.
		/// This process will close the main program and opens the sync program.
		/// </summary>
		void promptDatabaseSnyc()
		{
			if (userPermissionLevel < adminUserLevel) { startMainProgram(); return; }
			Process.Start(_loginModel.processStartInfo(userPermissionLevel));
			this.Close();
		}

		/// <summary>
		/// Handles the KeyPress event of the Password control.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The <see cref="KeyPressEventArgs"/> instance containing the event data.</param>
		private void Password_KeyPress(object sender, KeyPressEventArgs e)
		{
			//Try to Login if the user presses the enter key while the password field is active
			if (e.KeyChar == (char)Keys.Enter)
			{
				login();
			}
		}
	}
}
