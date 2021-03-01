using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Close_SQL_Server
{
	public partial class CloseServer : Form
	{
		public CloseServer()
		{
			InitializeComponent();

			MainText.ForeColor = Color.Black;
			try
			{
				foreach (Process proc in Process.GetProcessesByName("sqlservr"))
				{
					proc.Kill();
					MainText.Text = "Closed SQL Server";
					
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Failed to Close Server : " + ex.Message);
			}
			MainText.Text = "SQL Server Already Closed";

		}

		private void CloseServer_FormClosed(object sender, FormClosedEventArgs e)
		{
			Application.Exit();
		}

		private void Ok_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
