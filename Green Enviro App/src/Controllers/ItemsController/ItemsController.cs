using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Green_Enviro_App.src.Models.ItemsModel;
using Green_Enviro_App.src.DataAccess;

namespace Green_Enviro_App
{

	/// <summary>
	/// Class to do all the item related tasks.
	/// </summary>
	/// <seealso cref="System.Windows.Forms.Form" />
	public partial class ItemsViews : Form
	{


		DGVOps itemsDGVOps;
		ItemsModel itemsModel;

		private bool newItem = true;
		private string previousItemName = "";
		/// <summary>Initialises the items form control.</summary>
		private void initialiseItems() 
		{
			itemsDGVOps = new DGVOps(ItemsGrid, this);
			itemsModel = new ItemsModel();
			refreshItemsGrid();
			itemsDGVOps.populateComboBox(ItemType, new List<string> {Constants.FERROUS, Constants.NON_FERROUS });
			
			EditItemGroupBox.Visible = false;
			ItemType.SelectedIndex = 0;
		}

		/// <summary>
		/// Populates the items grid.
		/// </summary>
		private void refreshItemsGrid() 
		{
			itemsDGVOps.changeBindingSource(itemsModel.getItems());
			itemsDGVOps.populateGridView(itemsGridColumnWidths());
		}

		/// <summary>
		/// Configures the column widths for the items data grid
		/// </summary>
		/// <returns>List of floats representing the column widths.</returns>
		List<float> itemsGridColumnWidths() 
		{
			List<float> columnWidths = new List<float>();
			columnWidths.Add(100.0F);
			columnWidths.Add(100.0F);
			columnWidths.Add(100.0F);
			columnWidths.Add(100.0F);
			return columnWidths;
		}

		/// <summary>
		/// Handles the Click event of the EditPriceDone control.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
		private void EditPriceDone_Click(object sender, EventArgs e)
		{
			const string NO_ITEM_NAME_ERROR = "Please insert item name!";
			const string NO_ITEM_TYPE_ERROR = "Please select the item type!";
			const string NO_PRICE_ERROR = "Please insert the Price";
			const string NO_DEALER_PRICE_ERROR = "Please insert the dealer Price";

			if (ItemName.Text == Constants.EMPTY_TEXT) { GenericControllers.reportError(this, NO_ITEM_NAME_ERROR); return; }
			if (ItemType.SelectedItem == null) { GenericControllers.reportError(this, NO_ITEM_TYPE_ERROR); return; }
			if (ItemPrice.Value == Constants.DECIMAL_ZERO) { GenericControllers.reportError(this, NO_PRICE_ERROR); return; }
			if (ItemDealerPrice.Value == Constants.DECIMAL_ZERO) { GenericControllers.reportError(this, NO_DEALER_PRICE_ERROR); return; }

			Item item = new Item();
			item.Name = ItemName.Text;
			item.Price = ItemPrice.Value;
			item.DealerPrice = ItemDealerPrice.Value;
			item.Type = ItemType.Text;

			itemsModel.addItem(item, newItem, previousItemName);
			refreshItemsGrid();
			clearEditEntries();
			EditItemGroupBox.Visible = false;
		}

		/// <summary>
		/// Handles the Click event of the EditPriceCancel control.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
		private void EditPriceCancel_Click(object sender, EventArgs e)
		{
			clearEditEntries();
			EditItemGroupBox.Visible = false;
		}

		/// <summary>
		/// Handles the Click event of the ItemsDoneBtn control.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
		private void ItemsDoneBtn_Click(object sender, EventArgs e)
		{
			closeForm();
		}

		/// <summary>
		/// Handles the CellDoubleClick event of the ItemsGrid control.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The <see cref="DataGridViewCellEventArgs"/> instance containing the event data.</param>
		private void ItemsGrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			EditItemGroupBox.Visible = true;
			List<string> selectedRow = itemsDGVOps.getSeletedRow();
			previousItemName = selectedRow[0];
			newItem = false;

			ItemName.Text = selectedRow[0];
			ItemPrice.Value = decimal.Parse(selectedRow[1]);
			ItemDealerPrice.Value = decimal.Parse(selectedRow[2]);
			ItemType.SelectedItem = selectedRow[3];
		}

		/// <summary>
		/// Handles the Click event of the ItemsNewItemBtn control.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
		private void ItemsNewItemBtn_Click(object sender, EventArgs e)
		{
			EditItemGroupBox.Visible = true;
		}

		/// <summary>
		/// Handles the Click event of the ItemsDeleteItemBtn control.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
		private void ItemsDeleteItemBtn_Click(object sender, EventArgs e)
		{
			const string DELETION_WARNING = "Warning!\nYou are about to delete the item highleted in Red!";

			List<string> selectedRow = itemsDGVOps.getSeletedRow();
			string itemName = selectedRow[0];
			itemsDGVOps.highlightSelectedRowRed();

			CustomWarning warning = new CustomWarning();
			
			warning.showWarning(this, DELETION_WARNING, CustomWarning.WarningType.CriticalWarning);

			if (warning.actionConfirmed)
			{
				itemsModel.deleteItem(itemName);
				refreshItemsGrid();
			}
			else 
			{
				itemsDGVOps.removeRowHighlights();
			}
		}

		/// <summary>
		/// Clears the price edit entries.
		/// </summary>
		private void clearEditEntries() 
		{
			ItemName.Clear();
			ItemType.SelectedItem = null;
			ItemPrice.Value = Constants.DECIMAL_ZERO;
			ItemDealerPrice.Value = Constants.DECIMAL_ZERO;
			newItem = true;
			previousItemName = "";
		}
	}
}