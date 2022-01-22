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
		private void LoginBtn_Click(object sender, EventArgs e)
		{
			const string INVALID_CREDENTIALS_ERROR = "Invalid credentials!";

			if ((Username.Text == Constants.EMPTY_TEXT) || (Password.Text == Constants.EMPTY_TEXT)) 
			{ GenericControllers.reportError(this, INVALID_CREDENTIALS_ERROR); return; }

			bool validUser = _loginModel.verifyCredentials(Username.Text, Password.Text);

			if(!validUser) { GenericControllers.reportError(this, INVALID_CREDENTIALS_ERROR); return; }
		}
	}
}
