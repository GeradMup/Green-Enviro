using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TableCols = Green_Enviro_App.Database.ItemsTableColumns;
namespace Green_Enviro_App
{
	public partial class Items : Form
	{

		Database _database;
		Receipt _receit;
		NewItem _new_item;
		string _previous_value = "";
		DataTable _items;
		/// <summary>
		/// Initializes a new instance of the <see cref="Items" /> class.
		/// Class/Form used to all the price related editing
		/// </summary>
		public Items(Receipt rcpt, Database db)
		{
			InitializeComponent();

			_database = db;
			_receit = rcpt;
			_new_item = new NewItem(this);
			_new_item.Owner = this;
			LoadItems();
		}

		public void LoadItems() 
		{
			_items = _database.selectAll(Database.Tables.Items);

			PricesGridView.DataSource = _items;
			PricesGridView.Columns[0].ReadOnly = true;
			PricesGridView.Columns[1].ReadOnly = true;
			PricesGridView.Columns[4].ReadOnly = true;

			//Makes sure that users cannot add the wrong data types
			PricesGridView.Columns[2].ValueType = typeof(float);
			PricesGridView.Columns[3].ValueType = typeof(float);

			foreach (DataGridViewColumn _column in PricesGridView.Columns)
			{
				_column.SortMode = DataGridViewColumnSortMode.NotSortable;
			}
		}

		private void PricesGridView_CellEndEdit(object sender, DataGridViewCellEventArgs e)
		{
			if (ValidEditEntry(e) == false) 
			{
				CancelEdit(e);
				return;
			}

			string _item_name = PricesGridView[1, e.RowIndex].Value.ToString();
			string _price = PricesGridView[2, e.RowIndex].Value.ToString();
			string _dealer_price = PricesGridView[3, e.RowIndex].Value.ToString();

			DialogResult dialogResult = MessageBox.Show("Are you sure you want to change the price?", "Confirm Edit", MessageBoxButtons.YesNo);
			if (dialogResult == DialogResult.Yes)
			{
				
				string[] values = { _price, _dealer_price };   
				string identifier = _item_name;

				Database.ItemsTableColumns[] columnsToUpdate = {Database.ItemsTableColumns.Price, Database.ItemsTableColumns.DealerPrice };
				Database.ItemsTableColumns tableIdentifier = Database.ItemsTableColumns.Name;
				Int32 rowsAffected = _database.update<Database.ItemsTableColumns>(
					Database.Tables.Items, columnsToUpdate, tableIdentifier, identifier, values);

				if (rowsAffected == 1)
				{
					CustomMessageBox mb = new CustomMessageBox(this, "Success!", "Price has been updated");
				}
				else 
				{
					CustomMessageBox mb = new CustomMessageBox(this, "Error!", "Failed to update price");
				}
			}
			else if (dialogResult == DialogResult.No)
			{
				CancelEdit(e);
			}
		}

		private void PricesGridView_CellBeginEdit(object sender, DataGridViewCellEventArgs e)
		{
			_previous_value = PricesGridView[e.ColumnIndex, e.RowIndex].Value.ToString();
		}

		private void CancelEdit(DataGridViewCellEventArgs e) 
		{
			PricesGridView[e.ColumnIndex, e.RowIndex].Value = _previous_value;
			PricesGridView.Refresh();
		}

		private void PriceChangeCpltBtn_Click(object sender, EventArgs e)
		{
			_receit.SetupPriceList();

			this.Owner.Enabled = true;
			this.Owner.Show();
			this.Hide();
			this.Enabled = false;

		}

		private bool ValidEditEntry(DataGridViewCellEventArgs e) 
		{
			bool _valid_entry = false;

			if (PricesGridView[e.ColumnIndex, e.RowIndex].Value.ToString() == "")
			{
				MessageBox.Show("Please insert a price");
				_valid_entry = false;
			}
			else 
			{
				_valid_entry = true;
			}

			return _valid_entry;
		}

		public void AddNewItem(string itemName, float _itemPrice, float _dealerPrice, string itemType) 
		{
			string threeDecimalPlaces = "0.000";
			string itemPrice = _itemPrice.ToString(threeDecimalPlaces);
			string dealerPrice = _dealerPrice.ToString(threeDecimalPlaces);
			string[] values = { itemName, itemPrice, dealerPrice, itemType };
			bool _item_exist = false;

			foreach (DataRow _row in _items.Rows) 
			{
				if (_row[1].ToString() == itemName) 
				{
					_item_exist = true;
				}
			}

			if (_item_exist == false)
			{
				Int32 _rows_affected = _database.insert(Database.Tables.Items, values);

				if (_rows_affected == 1)
				{
					CustomMessageBox mb = new CustomMessageBox(this, "Success!", "New Item Added");
					LoadItems();
					PricesGridView.Refresh();
				}
			}
			else 
			{
				CustomMessageBox mb = new CustomMessageBox(this, "Error!", "Item Already Exist");
			}
		}

		private void PricesNewItemBtn_Click(object sender, EventArgs e)
		{
			_new_item.Activate();
			_new_item.Enabled = true;
			_new_item.Show();
		}

		private void Items_Load(object sender, EventArgs e)
		{
			this.Owner.Enabled = false;
		}

		private void ItemsDeleteItemBtn_Click(object sender, EventArgs e)
		{
			int _current_row = PricesGridView.CurrentCell.RowIndex;
			string itemId = PricesGridView[0,_current_row].Value.ToString();

			Int32 _rows_affected = _database.delete<TableCols>(Database.Tables.Items,TableCols.Id,itemId);
			if (_rows_affected == 1) 
			{
				LoadItems();
				CustomMessageBox mb = new CustomMessageBox(this, "Success!", "Item Deleted");
			}
		}
	}
}
