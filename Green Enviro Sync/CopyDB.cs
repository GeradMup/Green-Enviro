using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Green_Enviro_Sync
{
	public partial class CopyDB : Form
	{
		int _permission_level;
		public CopyDB(string[] permissionLevel)
		{
			if(permissionLevel.Length > 0)
			{
				_permission_level = int.Parse(permissionLevel[0]);
			}
			InitializeComponent();
		}

		private void YesBtn_Click(object sender, EventArgs e)
		{
			Sync _sync_prog = new Sync(_permission_level);
			_sync_prog.Activate();
			_sync_prog.Show();
			this.Hide();
		}

		private void NoBtn_Click(object sender, EventArgs e)
		{
			Sync _sync_prog = new Sync(_permission_level);
			_sync_prog.LaunchMainApp();
			this.Close();
		}
	}
}
