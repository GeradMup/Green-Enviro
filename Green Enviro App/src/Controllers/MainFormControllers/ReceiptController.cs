using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Green_Enviro_App
{
	using FloatLevel = ReceiptModel.FloatLevel;
	public partial class Main_Form : Form
	{
		DGVOps receiptDGVOps;

		/// <summary>
		/// Initialises the receipt tab.
		/// </summary>
		private void initialiseReceiptTab() 
		{
			receiptDGVOps = new DGVOps(this);

			receiptDGVOps.populateComboBox(ReceiptTransactionType, ReceiptModel.TRANSACTIONS);
			ReceiptTransactionType.SelectedIndex = 0;

			receiptDGVOps.populateComboBox(ReceiptItemList, _receiptModel.getItems());

			//Setup the float //Disable the side arrows
			RemainingFloat.Controls[0].Enabled = false;
			updateFloat();
			EditFloatGroup.Enabled = false;
			EditFloatGroup.Visible = false;
		}

		/// <summary>Handles the SelectedIndexChanged event of the ReceiptTransactionType control.</summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
		private void ReceiptTransactionType_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (ReceiptTransactionType.SelectedItem == null) return;
			string purchase = ReceiptModel.TRANSACTIONS[0];
			string casualSale = ReceiptModel.TRANSACTIONS[1];
			string formalSale = ReceiptModel.TRANSACTIONS[2];

			//Green colour represents a purchase
			if (ReceiptTransactionType.Text == purchase) 
			{
				ReceiptTransactionIndicator.Text = purchase;
				ReceiptTransactionIndicator.BackColor = Color.GreenYellow;
			}

			if (ReceiptTransactionType.Text == casualSale) 
			{
				ReceiptTransactionIndicator.Text = casualSale;
				ReceiptTransactionIndicator.BackColor = Color.Orange;
			}

			if(ReceiptTransactionType.Text == formalSale) 
			{
				ReceiptTransactionIndicator.Text = formalSale;
				ReceiptTransactionIndicator.BackColor = Color.Red;
			}
		}

		/// <summary>Handles the Click event of the ReceiptPriceEditBtn control.</summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
		private void ReceiptItemsEditBtn_Click(object sender, EventArgs e)
		{
			clearFields();

			ItemsViews items = new ItemsViews();
			items.activateForm(this);  
		}

		/// <summary>
		/// Handles the Click event of the AddFloatBtn control.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
		private void AddFloatBtn_Click(object sender, EventArgs e)
		{
			if (userPermissionLevel < Constants.ELEVATED_PERMISSION_LEVEL){ PermissionDenied(); return; }
			else
			{
				clearFields();
				AddFloatValue.Value = decimal.Zero;
				EditFloatGroup.Enabled = true;
				EditFloatGroup.Visible = true;
			}
		}

		/// <summary>
		/// Handles the Click event of the SaveFloat control.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
		private void SaveFloat_Click(object sender, EventArgs e)
		{
			const string NO_VALUE = "Please insert a value for float!";
			decimal floatValue = AddFloatValue.Value;
			if (AddFloatValue.Value == decimal.Zero) { GenericControllers.reportError(this, NO_VALUE); return; }
			try
			{
				_receiptModel.editFloat(floatValue);
				AddFloatValue.Value = decimal.Zero;
				EditFloatGroup.Enabled = false;
				EditFloatGroup.Visible = false;
				updateFloat();
			}
			catch (Exception ex) 
			{
				GenericControllers.reportError(this, ex.Message);
			}
		}

		/// <summary>
		/// Updates the float.
		/// </summary>
		private void updateFloat()
		{
			decimal floatValue = _receiptModel.getFloat();
			RemainingFloat.Value = floatValue;

			FloatLevel floatLevel = _receiptModel.floatLevel(floatValue);
			switch (floatLevel)
			{
				case FloatLevel.StillGood:
					RemainingFloat.BackColor = Color.GreenYellow;
					break;
				case FloatLevel.RunningOut:
					RemainingFloat.BackColor = Color.Orange;
					break;
				case FloatLevel.VeryLow:
					RemainingFloat.BackColor = Color.Red;
					break;
				default:
					break;
			}
		}

		private void clearFields() { }
	}
}
