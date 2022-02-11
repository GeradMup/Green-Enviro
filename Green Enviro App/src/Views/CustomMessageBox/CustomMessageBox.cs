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

	/// <summary>
	/// Class CustomMessageBox is used to display any error or success messages to the user.
	/// </summary>
	public partial class CustomMessageBox : Form
	{

		/// <summary>
		/// The error message</summary>
		public const string error = "Error!";
		
		/// <summary>
		/// The success message</summary>
		public const string success = "Success!";

		/// <summary>Initializes a new instance of the <see cref="CustomMessageBox"></see> class.</summary>
		/// <param name="parent">The active form before activating the <see cref="CustomMessageBox"></see> form.</param>
		/// <param name="messageType">The type of message. Type can be 'Success' or 'Error'</param>
		/// <param name="message">The message to display.</param>
		public CustomMessageBox(Form parent, MessageType messageType, string message) 
		{
			InitializeComponent();
			string title = "";
			if (messageType == MessageType.error) 
			{
				title = error;
				this.BackColor = Color.Red;
			}
			else if (messageType == MessageType.success) 
			{
				title = success;
				this.BackColor = Color.GreenYellow;	
			}

			this.Text = title;
			this.CustomMsg.Text = title + "\n\n" + message;
			this.Owner = parent;
			this.Owner.Enabled = false;
			this.Enabled = true;
			this.Activate();
			this.Show();
		}

		/// <summary>Handles the Click event of the OkBtn control.</summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
		private void OkBtn_Click(object sender, EventArgs e)
		{
			this.Owner.Enabled = true;
			this.Owner.Show();
			this.Hide();
			this.Enabled = false;
			this.Close();
		}

		/// <summary>
		/// Enum class to describe the message types. Type is either success or error
		/// </summary>
		public enum MessageType 
		{
			error,
			success
		}
	}
}
