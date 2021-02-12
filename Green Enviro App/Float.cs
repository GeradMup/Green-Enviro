using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Green_Enviro_App
{
	public partial class Float : Form
	{
		Receipt _receipt;
		Main_Form _main_form;
		float _float_value;
		float _total_float;

		static string _month = DateTime.Now.ToString("MMMM yyyy");
		string _path_to_float = @"..//..//resources//Float//" + _month + "_float.csv";
		string _path_to_total_float = @"..//..//resources//Float//" + _month + "_total_float.csv";

		public Float(Receipt rcpt, Main_Form main)
		{
			InitializeComponent();

			_receipt = rcpt;
			_main_form = main;

			SetupFloat();
		}

		private void AddFloat_Click(object sender, EventArgs e)
		{
			if (AddedFloat.Value == (decimal)0.00)
			{
				CustomMessageBox mb = new CustomMessageBox(this, "Error!", "Please enter the float to be added");
				return;
			}
			else 
			{
				UpdateFloat((float)AddedFloat.Value);
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

		public void UpdateFloat(float AddedAmout)
		{
			float _new_float = _float_value + AddedAmout;
			UpdateFloatFiles(_new_float, _path_to_float);

			if (AddedAmout > 0)
			{
				float _new_total_float = _total_float + AddedAmout;
				UpdateFloatFiles(_new_total_float, _path_to_total_float);
			}
		}

		private void UpdateFloatFiles(float _new_float, string _path_to_file) 
		{
			FileStream fWrite = new FileStream(_path_to_file,
			FileMode.Open, FileAccess.Write, FileShare.None);

			byte[] writeArr = Encoding.UTF8.GetBytes(_new_float.ToString());
			fWrite.Write(writeArr, 0, _new_float.ToString().Length);
			fWrite.Close();
			SetupFloat();
		}

		private void SetupFloat()
		{
			//Create the float file
			if (!File.Exists(_path_to_float))
			{
				string _float_values = "0";
				StringBuilder _csv_content = new StringBuilder();
				_csv_content.AppendLine(_float_values);
				File.AppendAllText(_path_to_float, _csv_content.ToString());
				File.AppendAllText(_path_to_total_float, _csv_content.ToString());
			}
			//

			_float_value = float.Parse(File.ReadAllText(_path_to_float));
			_total_float = float.Parse(File.ReadAllText(_path_to_total_float));

			_main_form.FloatBox.Text = "R " + String.Format("{0:n}", _float_value);

			if (_float_value > 5000)
			{
				_main_form.FloatBox.BackColor = Color.GreenYellow;
			}
			else
			{
				_main_form.FloatBox.BackColor = Color.Red;
			}
		}
	}
}
