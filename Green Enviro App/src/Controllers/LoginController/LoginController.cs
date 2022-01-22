using System;
using System.Collections.Generic;
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

		/// <summary>
		/// Intializes the login form.
		/// </summary>
		private void intializeLoginForm() 
		{
			_loginModel = new LoginModel();
			_mainForm = new Main_Form(this, 2);
		}

		private void LoginBtn_Click(object sender, EventArgs e)
		{
			const string INVALID_CREDENTIALS_ERROR = "Invalid credentials!";

			if ((Username.Text == Constants.EMPTY_TEXT) || (Password.Text == Constants.EMPTY_TEXT)) 
			{ GenericControllers.reportError(this, INVALID_CREDENTIALS_ERROR); return; }

			bool validUser = _loginModel.verifyCredentials(Username.Text, Password.Text);

			if(!validUser) { GenericControllers.reportError(this, INVALID_CREDENTIALS_ERROR); return; }

			//If the password has been verified, lets start the main program.
			startMainProgram();
		}

		private void startMainProgram()
		{
			ClearFields();
			this.Hide();
			_mainForm._user_permission_level = _user_permission_level;
			_mainForm.Activate();
			_mainForm.Show();
		}
	}
}
