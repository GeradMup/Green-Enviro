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
	public partial class NewItem : Form
	{
		Items _items;
		public NewItem(Items p)
		{
			InitializeComponent();
			_items = p;

			NewItemType.Items.Add("Ferrous");
			NewItemType.Items.Add("Non-Ferrous");

		}

		private void NewItemAddBtn_Click(object sender, EventArgs e)
		{
			if (ValidaEntries()) 
			{
				string _item_name = NewItemNameBox.Text;
				float _item_price = (float)NewItemPrice.Value;
				float _dealer_price = (float)NewItemDealerPrice.Value;
				string _item_type = NewItemType.SelectedItem.ToString();

				_items.AddNewItem(_item_name,_item_price, _dealer_price, _item_type);
				Exit();
			}
		}

		private bool ValidaEntries() 
		{
			bool _valid_entries = false;
			string _no_entries = "";
			decimal _zero = (decimal)0.00;

			string _error_message = "";
			if (NewItemNameBox.Text == _no_entries)
			{
				_valid_entries = false;
				_error_message = "Please insert item Name";
			}
			else if (NewItemPrice.Value == _zero)
			{
				_valid_entries = false;
				_error_message = "Please insert Price";
			}
			else if (NewItemDealerPrice.Value == _zero)
			{
				_valid_entries = false;
				_error_message = "Please insert Dealer Price";
			}
			else if (NewItemType.SelectedItem == null)
			{
				_valid_entries = false;
				_error_message = "Please select item type";
			}
			else 
			{
				_valid_entries = true;
			}

			if (_valid_entries == false) 
			{
				CustomMessageBox box = new CustomMessageBox(this, "Error", _error_message);
			}

			return _valid_entries;
		}

		private void Exit() 
		{
			NewItemNameBox.Text = "";
			NewItemPrice.Value = (decimal)0.00;
			NewItemDealerPrice.Value = (decimal)0.00;
			NewItemType.SelectedItem = null;

			this.Owner.Enabled = true;
			this.Hide();
			this.Enabled = false;
		}

		private void NewItemCnclBtn_Click(object sender, EventArgs e)
		{
			Exit();
		}

		private void NewItem_Load(object sender, EventArgs e)
		{
			this.Owner.Enabled = false;
		}
	}
}
