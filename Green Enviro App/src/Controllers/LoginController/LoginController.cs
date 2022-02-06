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
		private const int masterUserLevel = 5;

		/// <summary>
		/// Intializes the login form.
		/// </summary>
		private void intializeLoginForm() 
		{
			_loginModel = new LoginModel();
			if (userPermissionLevel != -1) 
			{
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
			string userName = Username.Text.Trim();
			string password = Password.Text.Trim();

			if ((userName == string.Empty) || (Password.Text == string.Empty)) 
			{ GenericControllers.reportError(this, INVALID_CREDENTIALS_ERROR); return; }
			userPermissionLevel = _loginModel.verifyCredentials(userName, password);

			if(userPermissionLevel == -1) { GenericControllers.reportError(this, INVALID_CREDENTIALS_ERROR); return; }

			//If the password has been verified, lets start the main program.
			if (userPermissionLevel < adminUserLevel) { startMainProgram(); return; }
			else { promptDatabaseSnyc(); }
			
		}

		/// <summary>
		/// Handles the Click event of the ManageUsers control.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
		private void ManageUsers_Click(object sender, EventArgs e)
		{
			string userName = Username.Text.Trim();
			string password = Password.Text.Trim();
			userPermissionLevel = _loginModel.verifyCredentials(userName, password);

			if (userPermissionLevel < masterUserLevel) { GenericControllers.reportError(this, Constants.PERMISSION_DENIED); return; }
			UsersModel usersModel = new UsersModel();
			UsersViews usersVeiws = new UsersViews(usersModel);
			usersVeiws.activateForm(this);
		}

		/// <summary>
		/// Starts the main program.
		/// </summary>
		private void startMainProgram()
		{
			_mainForm = new Main_Form(this, userPermissionLevel);
			clearLoginFields();
			_mainForm.activateForm(this);
		}

		/// <summary>
		/// Prompts the user if they want to update the database if there is an active internet connection.
		/// This process will close the main program and opens the sync program.
		/// </summary>
		void promptDatabaseSnyc() { 
			Process.Start(_loginModel.processStartInfo(userPermissionLevel));
			this.Close();
		}

		/// <summary>
		/// Clears the login fields.
		/// </summary>
		private void clearLoginFields()
		{
			Username.Clear();
			Password.Clear();
		}
	}
}
