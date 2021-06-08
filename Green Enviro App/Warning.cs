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
	public partial class Warning : Form
	{
		WarningInterface callerClass;

		/// <summary>
		/// Initializes a new instance of the <see cref="Warning"/> class.
		/// </summary>
		/// <param name="parent">The parent.</param>
		/// <param name="title">The title.</param>
		/// <param name="message">The message.</param>
		public Warning(Form parent, string message, WarningInterface callingClass)
		{
			InitializeComponent();
			callerClass = callingClass;

			this.BackColor = Color.Orange;
			
			this.Title.Text = "*******WARNING*******";
			this.CustomMsg.Text = message;
			this.Owner = parent;
			this.Owner.Enabled = false;
			this.Enabled = true;
			

			this.Location = new Point(Screen.PrimaryScreen.WorkingArea.Width - this.Width, Screen.PrimaryScreen.WorkingArea.Height - this.Height);
			this.Activate();
			this.Show();
		}

		/// <summary>
		/// The deletion confirmed,
		/// True if the user presses the confirm button
		/// False if the user presses the cancel button
		/// </summary>
		public bool actionConfirmed = false;

		private void Exit()
		{
			this.Owner.Enabled = true;
			this.Owner.Show();
			this.Hide();
			this.Enabled = false;
			callerClass.WarningWaitingFunction(actionConfirmed);
			this.Close();
		}

		private void ConfirmBtn_Click(object sender, EventArgs e)
		{
			actionConfirmed = true;
			Exit();
		}

		private void CancelBtn_Click(object sender, EventArgs e)
		{
			actionConfirmed = false;
			Exit();
		}
	}
}
