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
		WarningInterface callerClass;
		RequestedAction actionRequested;

		/// <summary>
		/// Initializes a new instance of the <see cref="Warning"/> class.
		/// </summary>
		/// <param name="parent">The form to return to after displaying the error message form</param>
		/// <param name="message">The message.</param>
		/// <param name="callingClass">The class from which the WarningInterface class was invoked</param>
		/// <param name="requestedAction">The action that the user was trying to perform before the warning popped up</param>
		public Warning(Form parent, string message, WarningInterface callingClass, RequestedAction requestedAction)
		{
			InitializeComponent();
			callerClass = callingClass;
			actionRequested = requestedAction;

			this.BackColor = FormColor(requestedAction);
			
			this.Title.Text = FormTitles(requestedAction);
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
			if (actionRequested == RequestedAction.DeleteEntry)
			{
				callerClass.DeleteEntriesWarning(actionConfirmed);
			}
			else if (actionRequested == RequestedAction.AddPurchaseToPr)
			{
				callerClass.PurchasePRWarning(actionConfirmed);
			}
			else if (actionRequested == RequestedAction.AddSaleToPr) 
			{
				
			}
			
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

		private string FormTitles(RequestedAction action) 
		{
			string formTitle = "";
			switch (action) 
			{
				case RequestedAction.DeleteEntry:
					formTitle = "*******WARNING*******";
					break;
				case RequestedAction.AddPurchaseToPr:
					formTitle = "*******CONFIRM*******";
					break;
				case RequestedAction.AddSaleToPr:
					formTitle = "*******CONFIRM*******";
					break;
				default:
					break;
			}
			return formTitle;
		}

		private Color FormColor(RequestedAction action) 
		{
			Color formColor = Color.White;
			switch (action)
			{
				case RequestedAction.DeleteEntry:
					formColor = Color.OrangeRed;
					break;
				case RequestedAction.AddPurchaseToPr:
					formColor = Color.GreenYellow;
					break;
				case RequestedAction.AddSaleToPr:
					formColor = Color.Green;
					break;
				default:
					break;
			}
			return formColor;
		}
	}
}
