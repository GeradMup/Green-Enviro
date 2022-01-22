using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FastMember;
using Green_Enviro_App.src.DataAccess;

namespace Green_Enviro_App.src.Models.ItemsModel
{
	/// <summary>
	/// Class to Handle all the business logic relating to items.
	/// </summary>
	class ItemsModel
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="ItemsModel"/> class.
		/// </summary>
		public ItemsModel() { }

		public DataTable getItems() 
		{
			DataTable items = new DataTable();
			List<Item> itemsList;
			using (DataEntities context = new DataEntities()) 
			{
				itemsList = context.Items.ToList();
			}

			const string name = "Name";
			const string price = "Price";
			const string dealerPrice = "DealerPrice";
			const string type = "Type";

			using (ObjectReader reader = ObjectReader.Create(itemsList, name, price, dealerPrice, type)) 
			{
				items.Load(reader);
			}

			return items;
		}

		/// <summary>
		/// Adds a new item into the database or updates an existing item.
		/// </summary>
		/// <param name="newItem">if set to <c>true</c> [we are adding a new item, otherwise we update an existing item].</param>
		/// <param name="item">The item.</param>
		/// <param name="itemName">The item name.</param>
		/// <returns>Void</returns>
		public void addItem(Item item, bool newItem = false, string itemName = "") 
		{
			using (DataEntities context = new DataEntities()) 
			{
				if (newItem)
				{
					context.Items.Add(item);
					context.SaveChanges();
				}
				else 
				{
					Item existingItem = context.Items.SingleOrDefault(_item => _item.Name == itemName);
					if (existingItem != null) 
					{
						existingItem.Name = item.Name;
						existingItem.Price = item.Price;
						existingItem.DealerPrice = item.DealerPrice;
						existingItem.Type = item.Type;

						context.SaveChanges();
					}
				}
			}
		}

		/// <summary>
		/// Deletes an item in the database given its name.
		/// </summary>
		/// <param name="itemName">The item.</param>
		public void deleteItem(string itemName) 
		{
			using (DataEntities context = new DataEntities()) 
			{
				Item item = context.Items.SingleOrDefault(_item => _item.Name == itemName);
				if (item != null) 
				{
					context.Items.Remove(item);
					context.SaveChanges();
				}
			}
		}
	}
}
