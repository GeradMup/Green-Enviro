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

namespace Green_Enviro_Sync
{
	public partial class Sync : Form
	{

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
			//We will check for interntet connectivity by pining the IP Address where our database is stored.
			string host = "https://firebase.google.com/";  
			bool _isConnected = false;
			Ping _ping = new Ping();
			try
			{
				PingReply _reply = _ping.Send(host);
				if (_reply.Status == IPStatus.Success)
					_isConnected = true;
			}
			catch { }
			

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
