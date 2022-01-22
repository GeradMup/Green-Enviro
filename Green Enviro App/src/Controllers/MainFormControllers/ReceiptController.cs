using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Green_Enviro_App
{
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

		private void clearFields() { }
	}
}
