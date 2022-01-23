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

namespace Green_Enviro_Sync
{
	public partial class CopyDB : Form
	{
		string[] cmdArgs;
		public CopyDB(string[] args)
		{
			if(args.Length > 0)
			{
				cmdArgs = args;
			}
			InitializeComponent();
		}

		private void YesBtn_Click(object sender, EventArgs e)
		{
			Sync _sync_prog = new Sync(cmdArgs);
			_sync_prog.Activate();
			_sync_prog.Show();
			this.Hide();
		}

		private void NoBtn_Click(object sender, EventArgs e)
		{
			Sync _sync_prog = new Sync(cmdArgs);
			_sync_prog.LaunchMainApp();
			this.Close();
		}

		private void CopyDB_FormClosing(object sender, FormClosingEventArgs e)
		{
			try
			{
				foreach (Process proc in Process.GetProcessesByName("sqlservr"))
				{
					proc.Kill();
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		private void CopyDB_FormClosed(object sender, FormClosedEventArgs e)
		{
			Application.Exit();
		}
	}
}
