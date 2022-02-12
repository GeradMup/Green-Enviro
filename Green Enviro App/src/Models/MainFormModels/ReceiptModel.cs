using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Green_Enviro_App.src.DataAccess;

namespace Green_Enviro_App
{

	/// <summary>
	/// Class to handle all the business logic relating to the receipt page.
	/// </summary>
	class ReceiptModel
	{
		FileHandles fileHandles;
		CSVHandles csvHandles;
		DataTable receiptTable;

		public static readonly List<string> TRANSACTIONS = new List<string>() { "PURCHASE", "CASUAL SALE", "FORMAL SALE" };
		/// <summary>Initializes a new instance of the <see cref="ReceiptModel" /> class.</summary>
		/// <param name="fh">Object of the file handles class.</param>
		/// <param name="csvh">Object of the CSVHandles class.</param>
		public ReceiptModel(FileHandles fh, CSVHandles csvh)
		{
			fileHandles = fh;
			csvHandles = csvh;
		}

		#region ITEMS
		/// <summary>
		/// Gets all the items that the company buys.
		/// </summary>
		/// <returns>A list of strings representing the item names.</returns>
		public List<string> getItems()
		{
			List<string> items;
			using (DataEntities context = new DataEntities())
			{
				items = context.Items
					.OrderBy(_item => _item.Id)
					.Select(_item => _item.Name)
					.ToList();
			}
			return items;
		}

		/// <summary>
		/// Gets the item's price given its name.
		/// </summary>
		/// <returns>A decimal value represneting the price.</returns>
		public decimal getPrice(string name)
		{
			decimal price;
			using (DataEntities context = new DataEntities())
			{
				price = context.Items.FirstOrDefault(_item => _item.Name == name).Price;
			}
			return price;
		}

		/// <summary>
		/// Gets the dealer price give the dealer price.
		/// </summary>
		/// <param name="name">The name.</param>
		/// <returns>A decimal value representing the dealer price.</returns>
		public decimal getDealerPrice(string name)
		{
			decimal dealerPrice;
			using (DataEntities context = new DataEntities())
			{
				dealerPrice = context.Items.FirstOrDefault(_item => _item.Name == name).DealerPrice;
			}
			return dealerPrice;
		}

		#endregion ITEMS [END]

		#region FLOAT
		/// <summary>
		/// Gets the float.
		/// </summary>
		/// <returns>A decimal value representing the float.</returns>
		public decimal getFloat()
		{
			decimal floatVal;
			using (DataEntities context = new DataEntities())
			{
				floatVal = context.Floats.First().FloatValue;
			}
			return floatVal;
		}

		/// <summary>
		/// Adds the float.
		/// </summary>
		/// <param name="value">The value.</param>
		public void editFloat(decimal value)
		{
			using (DataEntities context = new DataEntities())
			{
				Float savedFloat = context.Floats.First();
				savedFloat.FloatValue = savedFloat.FloatValue + value;
				context.SaveChanges();
			}
		}


		/// <summary>
		/// Indicates the current state of the float level.
		/// </summary>
		/// <param name="floatValue">The float value.</param>
		/// <returns>An object indicating the current state of the float level.</returns>
		public FloatLevel floatLevel(decimal floatValue)
		{
			decimal goodLevel = 5000;
			decimal runningOutLevel = 3000;

			if (floatValue > goodLevel) { return FloatLevel.StillGood; }
			if ((floatValue < goodLevel) && (floatValue > runningOutLevel)) { return FloatLevel.RunningOut; }
			else { return FloatLevel.VeryLow; }
		}

		/// <summary>
		/// Enum Values to describe the state of the float level
		/// </summary>
		public enum FloatLevel
		{
			StillGood,
			RunningOut,
			VeryLow
		}
		#endregion FLOAT [END]

		#region CUSTOMERS	
		/// <summary>
		/// Gets the customer numbers.
		/// </summary>
		/// <returns></returns>
		public List<int> customerNumbers()
		{
			List<int> customerNames;
			using (DataEntities context = new DataEntities())
			{
				customerNames = context.Customers
								.OrderBy(_customer => _customer.CustomerNumber)
								.Select(_customer => _customer.CustomerNumber)
								.ToList();
			}
			return customerNames;
		}

		/// <summary>
		/// Gets the customer information given the customer number.
		/// </summary>
		/// <param name="customerNum">The customer number.</param>
		/// <returns></returns>
		public Customer getCustomer(int customerNum)
		{
			Customer customer;

			using (DataEntities context = new DataEntities())
			{
				customer = context.Customers.FirstOrDefault(_customer => _customer.CustomerNumber == customerNum);
			}
			return customer;
		}

		/// <summary>
		/// Gets the customer's ID picture.
		/// </summary>
		/// <param name="imageBytes">The image bytes.</param>
		/// <returns></returns>
		public Image getIdPicture(byte[] imageBytes)
		{
			int zeroSize = 0;
			if (imageBytes.Length == zeroSize) return null;

			return GenericModels.byteArrayToImage(imageBytes);

		}
		#endregion CUSTOMERS [END]

		#region RECEIPT GRID		

		/// <summary>
		/// Gets the receipt grid.
		/// </summary>
		/// <returns>A DataTable to be used for the receipt.</returns>
		public DataTable receiptGrid()
		{
			receiptTable = new DataTable();
			DataColumn itemNumberCol = new DataColumn();
			//itemNumberCol.DataType = typeof(Int32);
			itemNumberCol.ColumnName = "Item";
			itemNumberCol.Caption = "Item";
			//itemNumberCol.ReadOnly = true; 

			DataColumn itemNameCol = new DataColumn();
			//itemNameCol.DataType = typeof(string);
			itemNameCol.ColumnName = "Name";
			itemNameCol.Caption = "Name";
			//itemNameCol.ReadOnly = true;

			DataColumn quantityCol = new DataColumn();
			//quantityCol.DataType = typeof(float);
			quantityCol.ColumnName = "kg";
			quantityCol.Caption = "kg";
			//quantityCol.ReadOnly = true;

			DataColumn priceCol = new DataColumn();
			//priceCol.DataType = typeof(float);
			priceCol.ColumnName = "Price";
			priceCol.Caption = "Price";
			//priceCol.ReadOnly = true;

			DataColumn amountCol = new DataColumn();
			//amountCol.DataType = typeof(float);
			amountCol.ColumnName = "Amount";
			amountCol.Caption = "Amount";
			//amountCol.ReadOnly = true;

			DataColumn typeCol = new DataColumn();
			//typeCol.DataType = typeof(string);
			typeCol.ColumnName = "Type";
			typeCol.Caption = "Type";
			//typeCol.ReadOnly = true;

			//receiptTable.Columns.Add(itemNumberCol);
			receiptTable.Columns.Add(itemNameCol);
			receiptTable.Columns.Add(quantityCol);
			receiptTable.Columns.Add(priceCol);
			receiptTable.Columns.Add(amountCol);
			receiptTable.Columns.Add(typeCol);

			return receiptTable;
		}

		/// <summary>
		/// Adds an item to the list items to be purchased
		/// </summary>
		/// <param name="item">The item.</param>
		/// <returns></returns>
		public void addItem(PurchaseItem item) 
		{
			string itemType;
			
			using (DataEntities context = new DataEntities()) 
			{
				itemType = context.Items
							.FirstOrDefault(_item => _item.Name == item.Name)
							.Type;
			}

			DataRow newRow = receiptTable.NewRow();
			newRow[0] = item.Name;
			newRow[1] = item.Quantity;
			newRow[2] = item.Price;
			newRow[3] = item.Price * item.Quantity;
			newRow[4] = itemType;

			receiptTable.Rows.Add(newRow);
		}

		/// <summary>
		/// Gets all items to be purchased.
		/// </summary>
		/// <returns></returns>
		public DataTable getAllItems() 
		{
			//Return a copy of the receiptTable because the original one will get modified by DGVOps when adding the totals.
			return receiptTable.Copy();
		}

		/// <summary>
		/// Class to describe the fields for purchasing
		/// </summary>
		internal class PurchaseItem
		{
			public PurchaseItem() { }
			/// <summary>
			/// Gets or sets the name.
			/// </summary>
			/// <value>
			/// The name.
			/// </value>
			public string Name { get; set; }
			
			/// <summary>
			/// Gets or sets the quantity.
			/// </summary>
			/// <value>
			/// The quantity.
			/// </value>
			public decimal Quantity { get; set; }
			
			/// <summary>
			/// Gets or sets the price.
			/// </summary>
			/// <value>
			/// The price.
			/// </value>
			public decimal Price { get; set; }
			
		}
		#endregion RECEIPT GRID [ END ]
	}
}
