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

		/// <summary>The error message</summary>
		public const string error = "Error!";
		/// <summary>The success message</summary>
		public const string success = "Success!";

		public CustomMessageBox(Form parent, string title, string message) 
		{
			InitializeComponent();

			if (title == "Error!") 
			{
				this.BackColor = Color.Red;
			}

			if (title == "Success!") 
			{
				this.BackColor = Color.GreenYellow;	
			}

			this.Text = title;
			this.CustomMsg.Text = message;
			this.Owner = parent;
			this.Owner.Enabled = false;
			this.Enabled = true;
			this.Activate();
			this.Show();
		}

		private void OkBtn_Click(object sender, EventArgs e)
		{
			this.Owner.Enabled = true;
			this.Owner.Show();
			this.Hide();
			this.Enabled = false;
			this.Close();
		}
	}
}
