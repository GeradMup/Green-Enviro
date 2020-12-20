using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Green_Enviro_App
{
	class CustomMsgBox
	{
		Main_Form _main_form;
		CustomMessageBox _custom_msg_box;
		public CustomMsgBox(Main_Form _form)
		{
			//Default constructor
			_main_form = _form;
			_custom_msg_box = new CustomMessageBox();
		}

		public void DisplayMsg(string msg) 
		{
			_custom_msg_box.CustomMsg.Text = msg;
			_custom_msg_box.Activate();
			_custom_msg_box.Show();
			_custom_msg_box.Refresh();
			System.Threading.Thread.Sleep(2000);
			_custom_msg_box.Close();
		}
	}
}
