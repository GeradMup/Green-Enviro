using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.NetworkInformation;
using System.Runtime;
using System.Runtime.InteropServices;

namespace Green_Enviro_Sync
{
	public partial class Sync : Form
	{
		[DllImport("wininet.dll")]
		private extern static bool InternetGetConnectedState(out int description, int resultValue);

		ErrorMsgBox _errorBox;
		public Sync()
		{
			InitializeComponent();
		}

		private void UploadBtn_Click(object sender, EventArgs e)
		{
			CheckConnectivity();

			
		}

		private void DownloadBtn_Click(object sender, EventArgs e)
		{
			CheckConnectivity();
		}

		private bool CheckConnectivity() 
		{
			int _description;
			bool _isConnected = InternetGetConnectedState(out _description, 0);


			if (_isConnected == false)
			{
				_errorBox = new ErrorMsgBox();
				_errorBox.Activate();
				_errorBox.Show();
			}

			return _isConnected;
		}
	}
}
