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
	public partial class Float : Form
	{
		Receipt _receipt;
		public Float(Receipt rcpt)
		{
			InitializeComponent();

			_receipt = rcpt;
		}

		private void AddFloat_Click(object sender, EventArgs e)
		{
			if (AddedFloat.Value == (decimal)0.00)
			{
				CustomMessageBox mb = new CustomMessageBox(this, "Fail", "Please enter the float to be added");
				return;
			}
			else 
			{
				_receipt.UpdateFloat((float)AddedFloat.Value);
				Exit();
			}

		}

		private void AddFloatCancel_Click(object sender, EventArgs e)
		{
			Exit();
		}

		private void Exit() 
		{
			AddedFloat.Value = (decimal)0.00;
			this.Owner.Enabled = true;
			this.Owner.Show();
			this.Hide();
			this.Enabled = false;
		}
	}
}
