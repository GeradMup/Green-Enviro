using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Green_Enviro_App.src.DataAccess;

namespace Green_Enviro_App
{
	using FloatLevel = ReceiptModel.FloatLevel;
	using PurchaseItem = ReceiptModel.PurchaseItem;
	public partial class Main_Form : Form
	{
		DGVOps receiptDGVOps;
		
		/// <summary>
		/// Initialises the receipt tab.
		/// </summary>
		private void initialiseReceiptTab()
		{
			receiptDGVOps = new DGVOps(receiptDataGrid, this);

			receiptDGVOps.populateComboBox(ReceiptTransactionType, ReceiptModel.TRANSACTIONS);
			ReceiptTransactionType.SelectedIndex = 0;

			refreshItemsList();
			refreshCustomersList();
			//Setup the float //Disable the side arrows
			RemainingFloat.Controls[0].Enabled = false;
			updateFloat();
			EditFloatGroup.Enabled = false;
			EditFloatGroup.Visible = false;

			//Receipt data table
			setupReceiptGrid();
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

			if (ReceiptTransactionType.Text == formalSale)
			{
				ReceiptTransactionIndicator.Text = formalSale;
				ReceiptTransactionIndicator.BackColor = Color.Red;
			}
		}

		#region RECEIPT GRID

		/// <summary>
		/// Setups the receipt grid.
		/// </summary>
		private void setupReceiptGrid() 
		{
			int amountColumn = 3;
			int kgsColumn = 1;
			receiptDGVOps.changeBindingSource(_receiptModel.receiptGrid());
			receiptDGVOps.populateGridView(receiptDGVColumns());
			receiptDGVOps.setupTotalsRow(amountColumn, kgsColumn);
		}

		/// <summary>
		/// Configures the column widths of the receipt grid view
		/// </summary>
		/// <returns>A List of floats representing the column widths. </returns>
		List<float> receiptDGVColumns() 
		{
			List<float> columnWidths = new List<float>();

			//columnWidths.Add(10.0F);
			columnWidths.Add(20.0F);
			columnWidths.Add(18.0F);
			columnWidths.Add(13.0F);
			columnWidths.Add(20.0F);
			columnWidths.Add(20.0F); 

			return columnWidths;
		}

		/// <summary>
		/// Handles the Click event of the addItemBtn control.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void addItemBtn_Click(object sender, EventArgs e)
		{
			const string NO_ITEM_ERROR = "No Item selected!";
			const string NO_PRICE_ERROR = "No Price inserted!";
			const string NO_QUANTITY_ERROR = "No Quantity inserted!";

			if (ReceiptItemList.SelectedItem == null) { GenericControllers.reportError(this, NO_ITEM_ERROR); return; }
			if (ReceiptItemPrice.Value == decimal.Zero) { GenericControllers.reportError(this, NO_PRICE_ERROR); return; }
			if (ReceiptItemPrice.Value.ToString() == string.Empty) { GenericControllers.reportError(this, NO_PRICE_ERROR); return; }
			if (ReceiptItemQuantity.Value == decimal.Zero) { GenericControllers.reportError(this, NO_QUANTITY_ERROR); return; }
			if (ReceiptItemQuantity.Value.ToString() == string.Empty) { GenericControllers.reportError(this, NO_QUANTITY_ERROR); return; }
			
			PurchaseItem item = new PurchaseItem();
			item.Name = ReceiptItemList.Text;
			item.Quantity = ReceiptItemQuantity.Value;
			item.Price = ReceiptItemPrice.Value;
			_receiptModel.addItem(item);
			clearItemFields();
			refreshReceiptGrid();
		}

		/// <summary>
		/// Refreshes the items receipt grid
		/// </summary>
		private void refreshReceiptGrid() 
		{
			receiptDGVOps.resetGridView();
			receiptDGVOps.changeBindingSource(_receiptModel.getAllItems());
			receiptDGVOps.populateGridView(receiptDGVColumns());
		}

		/// <summary>
		/// Clears the item fields.
		/// </summary>
		private void clearItemFields() 
		{
			ReceiptItemPrice.Value = decimal.Zero;
			ReceiptItemQuantity.Value = decimal.Zero;
			ReceiptItemList.SelectedItem = null;
			ReceiptDealerPrice.CheckState = CheckState.Unchecked;
			ReceiptPriceOverride.CheckState = CheckState.Unchecked;
			ReceiptItemPrice.ReadOnly = true;
		}

		/// <summary>
		/// Handles the Click event of the PurchaseBtn control.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
		private void PurchaseBtn_Click(object sender, EventArgs e)
		{
			const string USE_DELIVERY_NOTE = "Use the delivery note for formal sales!";
			const string NO_CUSTOMER_ERROR = "Please select a customer number or select default customer!";
			const string NO_ITEMS_ERROR = "Please insert items for purchasing!";
			const string PURCHASE_RECORDED = "Purchase has been recorded!";
			const string CASUAL_SALE_RECORDED = "Casual sale has been recorded!";

			string purchase = ReceiptModel.TRANSACTIONS[0];
			string casualSale = ReceiptModel.TRANSACTIONS[1];
			string formalSale = ReceiptModel.TRANSACTIONS[2];

			//Formal sales are no longer supported. We will now generate delivery notes for formal sales.
			if (ReceiptTransactionType.Text == formalSale)
			{ 
				GenericControllers.reportError(this, USE_DELIVERY_NOTE);
				ReceiptTransactionType.SelectedIndex = 0;
				return; 
			}

			//If no items were added for a purchase or a sale, it is an error.
			if (!_receiptModel.itemsAvailable()) { GenericControllers.reportError(this, NO_ITEMS_ERROR); return; }

			//If it is a casual sale, there is no need to check for other inputs.
			if (ReceiptTransactionType.Text == casualSale)
			{
				_receiptModel.casualSale();
				ReceiptTransactionType.SelectedIndex = 0;
				updateFloat();
				refreshReceiptGrid();
				GenericControllers.reportSuccess(this, CASUAL_SALE_RECORDED);
				return;
			}

			string customerNumber = CustomerNumbersList.Text.Trim();
			if ((customerNumber == string.Empty) && (UnknownCustomer.CheckState == CheckState.Unchecked)) 
			{ GenericControllers.reportError(this, NO_CUSTOMER_ERROR); return; }

			//Check if the current transaction is to be a purchase or sale first
			if (ReceiptTransactionType.SelectedItem.ToString() == purchase)
			{
				bool knownCustomer = (UnknownCustomer.CheckState == CheckState.Unchecked) ? true : false;
				string unknown = "Unknown";
				Customer customer = new Customer
				{
					CustomerNumber = (knownCustomer) ? int.Parse(CustomerNumbersList.Text) : 0,
					Name = (knownCustomer) ? CustomerName.Text : unknown,
					Surname = (knownCustomer) ? CustomerSurname.Text : unknown,
					ID = (knownCustomer) ?  CustomerIDNumber.Text : unknown,
					Address = (knownCustomer) ? CustomerAddress.Text : unknown,
					Cell = (knownCustomer) ? CustomerCellNumber.Text : unknown
				};

				decimal remainingFloat = RemainingFloat.Value;
				try
				{
					_receiptModel.completePurchase(customer, remainingFloat);
					refreshReceiptGrid();
					clearCustomerFields();
					GenericControllers.reportSuccess(this, PURCHASE_RECORDED);
					updateFloat();
				}
				catch (Exception ex)
				{
					GenericControllers.reportError(this, ex.Message);
				}
			}
		}

		/// <summary>
		/// Handles the MouseClick event of the ReceiptGridOptions control.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The <see cref="MouseEventArgs"/> instance containing the event data.</param>
		private void ReceiptGridOptions_MouseClick(object sender, MouseEventArgs e)
		{
			const string NO_SELECTION_ERROR = "Please select an entry that you'd like to delete!";
			const string DELETING_TOTALS_ERROR = "You cannot delete the totals row!";

			if (receiptDGVOps.noRowSelected()) { GenericControllers.reportError(this, NO_SELECTION_ERROR); return; }
			if (receiptDGVOps.totalsRowSelected()) { GenericControllers.reportError(this, DELETING_TOTALS_ERROR); return; }

			List<string> selectedRow = receiptDGVOps.getSeletedRow();
			string itemName = selectedRow[0];

			_receiptModel.deleteItem(itemName);
			refreshReceiptGrid();
		}
		#endregion RECEIPT GRID [ END ]

		#region FLOAT

		/// <summary>
		/// Handles the Click event of the AddFloatBtn control.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
		private void AddFloatBtn_Click(object sender, EventArgs e)
		{
			if (userPermissionLevel < Constants.ELEVATED_PERMISSION_LEVEL) { PermissionDenied(); return; }
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
				closeEditFloatGroup();
				updateFloat();
			}
			catch (Exception ex)
			{
				GenericControllers.reportError(this, ex.Message);
			}
		}

		/// <summary>
		/// Handles the Click event of the EditFloatCancel control.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void EditFloatCancel_Click(object sender, EventArgs e)
		{
			closeEditFloatGroup();
		}

		/// <summary>
		/// Closes the Edit Float Group
		/// </summary>
		private void closeEditFloatGroup()
		{
			AddFloatValue.Value = decimal.Zero;
			EditFloatGroup.Enabled = false;
			EditFloatGroup.Visible = false;
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

		#endregion FLOAT [ END ]

		#region ITEMS
		/// <summary>
		/// Refreshes the items list.
		/// </summary>
		private void refreshItemsList()
		{
			receiptDGVOps.populateComboBox(ReceiptItemList, _receiptModel.getItems());
		}

		/// <summary>
		/// Handles the SelectedIndexChanged event of the ReceiptItemList control.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void ReceiptItemList_SelectedIndexChanged(object sender, EventArgs e)
		{
			//Do nothing if no item has been selected.
			if (ReceiptItemList.SelectedItem == null) return; 

			//We always want to start with the normal proce.
			ReceiptDealerPrice.CheckState = CheckState.Unchecked;
			string itemName = ReceiptItemList.Text;
			decimal price = _receiptModel.getPrice(itemName);
			ReceiptItemPrice.Value = price;
		}

		/// <summary>
		/// Handles the CheckedChanged event of the DealerPriceCheckbox
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void ReceiptDealerPrice_CheckedChanged(object sender, EventArgs e)
		{
			//First check if we are removing the checkstate of the ReceiptDealerPrice CheckBox
			if ((ReceiptItemList.SelectedItem == null) && (ReceiptDealerPrice.CheckState == CheckState.Unchecked)) return;

			const string NO_ITEM_SELECTED = "No item selected!";
			if (ReceiptItemList.SelectedItem == null)
			{
				GenericControllers.reportError(this, NO_ITEM_SELECTED);
				ReceiptDealerPrice.CheckState = CheckState.Unchecked;
				return;
			}

			if (ReceiptDealerPrice.CheckState == CheckState.Checked)
			{
				string itemName = ReceiptItemList.Text;
				decimal dealerPrice = _receiptModel.getDealerPrice(itemName);
				ReceiptItemPrice.Value = dealerPrice;
			}
			else { ReceiptItemList_SelectedIndexChanged(sender, e); }
			//If the receipt is unchecked, call the normal function to put in the regular price
		}

		/// <summary>Handles the Click event of the ReceiptPriceEditBtn control.</summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
		private void ReceiptItemsEditBtn_Click(object sender, EventArgs e)
		{
			clearFields();
			ItemsViews.editingItemsCompleteCallback callback = editingItemsCompleted;
			ItemsViews items = new ItemsViews();
			items.activateForm(this, callback);
		}

		/// <summary>
		/// Function called when items editing is completed.
		/// </summary>
		public void editingItemsCompleted() 
		{
			refreshItemsList();
		}

		/// <summary>
		/// Handles the CheckedChanged event of the PriceOverrideCheckBox control.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
		private void PriceOverrideCheckBox_CheckedChanged(object sender, EventArgs e)
		{
			//First check if we are removing the checkstate of the PriceOverride CheckBox
			if ((ReceiptItemList.SelectedItem == null) && (ReceiptPriceOverride.CheckState == CheckState.Unchecked)) return;

			const string NO_ITEM_SELECTED = "No item selected!";
			if (ReceiptItemList.SelectedItem == null)
			{
				GenericControllers.reportError(this, NO_ITEM_SELECTED);
				ReceiptPriceOverride.CheckState = CheckState.Unchecked;
				return;
			}

			//Make the price editable when the price override checkbox is checked.
			if (ReceiptPriceOverride.CheckState == CheckState.Checked) { ReceiptItemPrice.ReadOnly = false; }
			else { ReceiptItemPrice.ReadOnly = true; }
		}

		#endregion ITEMS [ END ]

		#region CUSTOMERS		
		/// <summary>
		/// Refreshes the customers list.
		/// </summary>
		private void refreshCustomersList() 
		{
			receiptDGVOps.populateComboBox(CustomerNumbersList, _receiptModel.customerNumbers());
		}

		/// <summary>
		/// Handles the Click event of the EditCustomers control.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
		private void EditCustomers_Click(object sender, EventArgs e)
		{
			CustomersViews.editingCustomersCompleteCallback callback = editingCustomersCompleted;
			clearCustomerFields();
			CustomersModel customerModel = new CustomersModel();
			CustomersViews customersViews = new CustomersViews(customerModel);

			customersViews.activateForm(this, callback);
		}

		/// <summary>
		/// Function called when editing items has been complted.
		/// </summary>
		public void editingCustomersCompleted() 
		{
			refreshCustomersList();
		}

		/// <summary>
		/// Handles the SelectedIndexChanged event of the customerNumbersList control.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
		private void customerNumbersList_SelectedIndexChanged(object sender, EventArgs e)
		{

			//Do nothing if there is no customer selected.
			if (CustomerNumbersList.Text == string.Empty) return;
			UnknownCustomer.CheckState = CheckState.Unchecked;

			int customerNum = int.Parse(CustomerNumbersList.Text);
			Customer selectedCustomer = _receiptModel.getCustomer(customerNum);
			Image customerId = _receiptModel.getIdPicture(selectedCustomer.IDPicture);

			CustomerName.Text = selectedCustomer.Name;
			CustomerSurname.Text = selectedCustomer.Surname;
			CustomerAddress.Text = selectedCustomer.Address;
			CustomerCellNumber.Text = selectedCustomer.Cell;
			CustomerIDNumber.Text = selectedCustomer.ID;
			CustomerIDPicture.Image = customerId;
		}

		/// <summary>
		/// Handles the KeyDown event of the customerNumbersList control.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The <see cref="KeyEventArgs"/> instance containing the event data.</param>
		private void customerNumbersList_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
			{
				EventArgs fakeEvent = new EventArgs();
				customerNumbersList_SelectedIndexChanged(sender, fakeEvent);
			}
		}

		/// <summary>
		/// Clears the customers fields.
		/// </summary>
		private void clearCustomerFields() 
		{
			CustomerNumbersList.SelectedItem = null;
			CustomerNumbersList.Text = string.Empty;
			CustomerName.Clear();
			CustomerSurname.Clear();
			CustomerAddress.Clear();
			CustomerCellNumber.Clear();
			CustomerIDNumber.Clear();
			CustomerIDPicture.Image = null;
			UnknownCustomer.CheckState = CheckState.Unchecked;
			//CustomerIDPicture.Image.Dispose();
		}
		#endregion CUSTOMERS [ END ]

		private void clearFields() 
		{
		}
		/// <summary>
		/// Resets the receipt tab page.
		/// </summary>
		private void resetReceipt() 
		{
			clearItemFields();
			clearCustomerFields();
		}

		#region RECEIPT SLIP
		private void setupSlip() 
		{
			string transaction_time = DateTime.Now.ToString("HH:mm:ss");
			string transaction_date_and_time = DateTime.Now.ToString("dd MMMM yyyy") + " " + transaction_time;
			string _date = " Date: " + DateTime.Now.ToString("dd MMMM yyyy       ") + "\n Time: " + transaction_time + "\n";
			string _customer_details = " Customer: None, 0\n" + " ID: 0000000000000000\n" + " Cell: 00000000000\n";
			receiptBox.Clear();
			receiptBox.AppendText(" \n");
			receiptBox.AppendText(" ----------------------------\n");
			receiptBox.AppendText(" 5 Shaft Road, Knights,\n");
			receiptBox.AppendText(" Germiston, 1401\n");
			receiptBox.AppendText(" Phone: +27 61 588 7074\n");
			receiptBox.AppendText(" Tax Number: 9154951249\n");
			receiptBox.AppendText(" Reg Number: 2019/528743/07\n");
			receiptBox.AppendText(" ----------------------------\n");
			receiptBox.AppendText(_date);
			receiptBox.AppendText(_customer_details);
			receiptBox.AppendText(" ----------------------------\n ");
			receiptBox.AppendText(string.Format("{0,-9}", "ITEMS"));
			receiptBox.AppendText(string.Format("{0,-6}", "KGs"));
			receiptBox.AppendText(string.Format("{0,-8}", "P/Kg"));
			receiptBox.AppendText(string.Format("{0,-5}", "R"));
			receiptBox.AppendText("\n");
			receiptBox.AppendText(" ----------------------------\n");
			receiptBox.AppendText(_receipt_content);
			receiptBox.AppendText("\n");
			receiptBox.AppendText(" Total:    " + _running_kg_total + " Kgs");
			receiptBox.AppendText("\n");
			receiptBox.AppendText(" Total:    R " + _running_total.ToString());
			receiptBox.AppendText("\n");
			receiptBox.AppendText(" ----------------------------\n");
			receiptBox.AppendText(" * * * " + _type_of_transaction + " * * * ");
			receiptBox.AppendText("\n");
			receiptBox.AppendText(" * * * THANK YOU! * * * ");
		}
		#endregion RECEIPT SLIP [ END ]
	}
}
