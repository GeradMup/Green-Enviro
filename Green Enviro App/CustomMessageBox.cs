using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Green_Enviro_App
{
	public partial class CustomMessageBox : Form
	{
		public CustomMessageBox(string title, string message) 
		{
			InitializeComponent();

			this.Text = title;
			this.CustomMsg.Text = message;
			this.Activate();
			this.Show();
		}

		private void OkBtn_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
