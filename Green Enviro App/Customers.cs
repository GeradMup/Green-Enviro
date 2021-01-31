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
	public partial class Customers : Form
	{
		Database _database;
		Main_Form _main_form;
		public Customers(Main_Form main, Database data)
		{
			InitializeComponent();

			_database = data;
			this.Owner = main;
			_main_form = main;
		}

		public void NewCustomer() 
		{
			ActivateForm();
		}

		private void ActivateForm() 
		{
			this.Owner.Enabled = false;
			this.Activate();
			this.Enabled = true;
			this.Show();
		}

		private void Exit() 
		{
			this.Owner.Enabled = true;
			this.Owner.Show();
			this.Hide();
			this.Enabled = false;
		}


		private bool ValidateEntries() 
		{
			return false;
		}

		private void NewCustomerAddIdPictureBtn_Click(object sender, EventArgs e)
		{
			OpenFileDialog _new_dialog = new OpenFileDialog();

			if (_new_dialog.ShowDialog() == DialogResult.OK) 
			{
				NewCustomerIdPictureBox.Image = new Bitmap(_new_dialog.FileName);
			}
		}

		private void NewCustomerCancelBtn_Click(object sender, EventArgs e)
		{
			Exit();
		}

		private void NewCustomerConfirmBtn_Click(object sender, EventArgs e)
		{
			Exit();
		}
	}
}
