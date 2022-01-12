using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Green_Enviro_App
{
	using TransactionType = ReceiptModel.TransactionType;
	using CustomerInfo = PurchasesModel.CustomerInfo;
	public partial class Main_Form : Form
	{
		DGVOps receiptDgvOps;

		/// <summary>
		/// Initializes the receipt tab.
		/// </summary>
		private void initializeReceiptTab()
		{
			receiptDgvOps = new DGVOps(_mainForm);
			setupTransactionTypes();
			setupItems();
			setupCustomers();
		}

		/// <summary>
		/// Sets up the transaction types.</summary>
		private void setupTransactionTypes() 
		{
			const int purchaseIndex = (int)TransactionType.Purchase;
			receiptDgvOps.populateComboBox(ReceiptTransactionType, _receiptModel.transactionTypes());
			ReceiptTransactionType.SelectedIndex = purchaseIndex;
		}

		/// <summary>
		/// Sets ups the item names on the receipt page.</summary>
		private void setupItems() 
		{
			try
			{
				receiptDgvOps.populateComboBox(ReceiptItems, _receiptModel.getItems());
			}
			catch (Exception ex)
			{
				GenericControllers.reportError(_mainForm, ex.Message);
			}
		}

		/// <summary>
		/// Sets up the customers list on the receipt page.
		/// </summary>
		private void setupCustomers() 
		{
			try
			{
				receiptDgvOps.populateComboBox(ReceiptCustomerNumbers, _receiptModel.getCustomerNumbers());
			}
			catch (Exception ex) 
			{
				GenericControllers.reportError(_mainForm, ex.Message);
			}
		}

		/// <summary>Handles the SelectedIndexChanged event of the ReceiptTransactionType control.</summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
		private void ReceiptTransactionType_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (ReceiptTransactionType.SelectedItem == null) return;

			const int purchaseIndex = (int)TransactionType.Purchase;
			const int formalSaleIndex = (int)TransactionType.Formal_Sale;
			const int casualSaleIndex = (int)TransactionType.Causual_Sale;

			ReceiptTransactionTypeIndicator.Text = ReceiptTransactionType.Text;
			if (ReceiptTransactionType.SelectedIndex == purchaseIndex)
			{
				ReceiptTransactionTypeIndicator.BackColor = Color.GreenYellow;
			}
			if (ReceiptTransactionType.SelectedIndex == formalSaleIndex)
			{
				ReceiptTransactionTypeIndicator.BackColor = Color.Red;
			}
			if (ReceiptTransactionType.SelectedIndex == casualSaleIndex)
			{
				ReceiptTransactionTypeIndicator.BackColor = Color.Yellow;
			}
		}

		/// <summary>Handles the SelectedIndexChanged event of the itemList control.</summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
		private void itemList_SelectedIndexChanged(object sender, EventArgs e)
		{
			insertItemPrice();
		}

		/// <summary>Handles the CheckedChanged event of the DealerPriceCheckBox control.</summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
		private void DealerPriceCheckBox_CheckedChanged(object sender, EventArgs e)
		{
			insertItemPrice();
		}

		/// <summary>Handles the CheckedChanged event of the ReceiptPriceOverride control.</summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
		private void ReceiptPriceOverride_CheckedChanged(object sender, EventArgs e)
		{
			ReceiptItemPrice.ReadOnly = (ReceiptPriceOverride.Checked) ? false : true;
		}

		/// <summary>Handles the SelectedIndexChanged event of the ReceiptCustomerNumbers control.</summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
		private void ReceiptCustomerNumbers_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (ReceiptCustomerNumbers.SelectedItem == null) return;
			updateCustomerDetails(); 
		}

		/// <summary>Handles the KeyDown event of the ReceiptCustomerNumbers control.</summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The <see cref="KeyEventArgs" /> instance containing the event data.</param>
		private void ReceiptCustomerNumbers_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter) updateCustomerDetails();
		}

		/// <summary>
		/// Updates the customer details on the Receipt page.
		/// </summary>
		private void updateCustomerDetails() 
		{
			int customerNumber = int.Parse(ReceiptCustomerNumbers.Text);
			CustomerInfo customerInfo = _receiptModel.getCustomerInfo(customerNumber);

			ReceiptCustomerName.Text = customerInfo.name;
			ReceiptCustomerSurname.Text = customerInfo.surname;
			ReceiptCustomerID.Text = customerInfo.id;
			ReceiptCustomerCellNum.Text = customerInfo.cell;
			ReceiptCustomerAddress.Text = customerInfo.address;
			ReceiptIDPicture.Image = customerInfo.idPicture;
		}

		private void EditCustomers_Click(object sender, EventArgs e)
		{
			_customers.ActivateForm();
		}


		/// <summary>
		/// Inserts the price of the selected item.</summary>
		private void insertItemPrice() 
		{
			if (ReceiptItems.SelectedItem == null) return;
			string itemName = ReceiptItems.Text;
			bool isDealer = (ReceiptDealerPrice.Checked) ? true : false;
			decimal itemPrice = _receiptModel.getPrice(itemName, isDealer);

			ReceiptItemPrice.Value = itemPrice;
		}
	}
}

