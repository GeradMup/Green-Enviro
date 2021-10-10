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
	///   The requested action is used to identify which class invoked this class 
	///   and hence figure out the correct return action after the warming message
	///   been displayed
	/// </summary>
	public enum RequestedAction 
	{
		/// <summary>The action of deleting a Sale, Purchase or any other recorded entries</summary>
		DeleteEntry,
		/// <summary>The action of adding a purchase entry to the police register</summary>
		AddPurchaseToPr,
		/// <summary>The action of adding a sale entry to a police register</summary>
		AddSaleToPr
	}
	public partial class Warning : Form
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="Warning"/> class.
		/// </summary>
		/// <param name="parent">The form to return to after displaying the error message form.</param>
		/// <param name="message">The message.</param>
		/// <param name="_warningType">The warning type.</param>
		public Warning()
		{
			InitializeComponent();
		}

		/// <summary>
		/// The deletion confirmed,
		/// True if the user presses the confirm button
		/// False if the user presses the cancel button
		/// </summary>
		public bool actionConfirmed = false;

		/// <summary>
		/// Shows the warning.
		/// </summary>
		/// <param name="parent">The parent form.</param>
		/// <param name="message">The warning message.</param>
		/// <param name="_warningType">Type of the warning.</param>
		public void showWarning(Form parent, string message, WarningType _warningType) 
		{
			this.BackColor = formColor(_warningType);
			this.Title.Text = formTitles(_warningType);
			this.CustomMsg.Text = message;

			this.Enabled = true;
			this.Location = new Point(Screen.PrimaryScreen.WorkingArea.Width - this.Width, Screen.PrimaryScreen.WorkingArea.Height - this.Height);
			this.Owner = parent;
			this.Owner.Enabled = false;
			this.Activate();
			this.ShowDialog();
		}

		private void exit()
		{
			this.Owner.Enabled = true;
			this.Owner.Show();
			this.Hide();
			this.Enabled = false;
			this.Close();
		}

		private void ConfirmBtn_Click(object sender, EventArgs e)
		{
			actionConfirmed = true;
			exit();
		}

		private void CancelBtn_Click(object sender, EventArgs e)
		{
			actionConfirmed = false;
			exit();
		}

		private string formTitles(WarningType warningType) 
		{
			string formTitle = "";
			switch (warningType) 
			{
				case WarningType.RegularWarning:
					formTitle = "*******WARNING*******";
					break;
				case WarningType.CriticalWarning:
					formTitle = "***CRITICAL WARNING***";
					break;
				case WarningType.ConfirmationWarning:
					formTitle = "*******CONFIRM*******";
					break;
				default:
					break;
			}
			return formTitle;
		}

		private Color formColor(WarningType warningType) 
		{
			Color formColor = Color.White;
			switch (warningType)
			{
				case WarningType.RegularWarning:
					formColor = Color.Orange;
					break;
				case WarningType.CriticalWarning:
					formColor = Color.OrangeRed;
					break;
				case WarningType.ConfirmationWarning:
					formColor = Color.Green;
					break;
				default:
					break;
			}
			return formColor;
		}

		/// <summary>
		/// Enum class to define the types of warnings that can occur.
		/// </summary>
		public enum WarningType 
		{
			/// <summary>
			/// The regular warning
			/// </summary>
			RegularWarning,
			/// <summary>
			/// The critical warning
			/// </summary>
			CriticalWarning,
			/// <summary>
			/// The confirmation warning
			/// </summary>
			ConfirmationWarning
		}
	}
}
