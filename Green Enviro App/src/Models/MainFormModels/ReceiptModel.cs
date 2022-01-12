using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Green_Enviro_App
{
	using Item = Database.ItemsTableColumns;
	using CustomerInfo = PurchasesModel.CustomerInfo;
	using CustomersTable = Database.CustomersTableColumns;

	/// <summary>
	/// Class to handle all the business logic relating to the receipt.</summary>
	class ReceiptModel
	{
		Database database;
		FileHandles fileHandles;
		CSVHandles csvHandles;
		List<ItemInfo> items;
		List<CustomerInfo> customers;
		
		/// <summary>Initializes a new instance of the <see cref="ReceiptModel" /> class.</summary>
		/// <param name="db">The Database object.</param>
		/// <param name="fh">The FileHandles object.</param>
		/// <param name="csvh">The CSVHandles object.</param>
		public ReceiptModel(Database db, FileHandles fh, CSVHandles csvh) 
		{
			database = db;
			fileHandles = fh;
			csvHandles = csvh;
			items = new List<ItemInfo>();
			customers = new List<CustomerInfo>();
		}
		
		/// <summary>Gets all the possible transaction types.</summary>
		/// <returns>A list of strings representing all the transaction types.</returns>
		public List<string> transactionTypes() 
		{
			return GenericModels.enumFieldsToStringList<TransactionType>();
		}

		/// <summary>Gets alll the item names to be shown on the receipt page.</summary>
		/// <returns>A list of strings with all the items names.</returns>
		/// <exception cref="System.Exception">If something goes wrong while loading the item names from the database.</exception>
		public List<string> getItems() 
		{
			DataTable itemsDataTable = new DataTable();
			List<string> itemNamesList = new List<string>();
			items.Clear();

			const int nameIndex = (int)Item.Name;
			const int priceIndex = (int)Item.Price;
			const int dealerPriceIndex = (int)Item.DealerPrice;
			const int typeIndex = (int)Item.Type;

			try
			{
				itemsDataTable = database.selectAll(Database.Tables.Items);

				foreach (DataRow item in itemsDataTable.Rows) 
				{
					ItemInfo itemInfo = new ItemInfo();
					itemInfo.name = item[nameIndex].ToString();
					itemInfo.standardPrice = decimal.Parse(item[priceIndex].ToString());
					itemInfo.dealerPrice = decimal.Parse(item[dealerPriceIndex].ToString());
					itemInfo.type = item[typeIndex].ToString();
					
					items.Add(itemInfo);
					itemNamesList.Add(item[nameIndex].ToString());
				}
			}
			catch (Exception ex) 
			{
				throw new Exception(ex.Message);
			}
			return itemNamesList;
		}

		/// <summary>Gets the price of an item given its name.</summary>
		/// <param name="itemName">Name of the item.</param>
		/// <param name="isDealer">if set to <c>true</c> [is dealer].</param>
		/// <returns>A decimal value representing the item price.<br /></returns>
		public decimal getPrice(string itemName, bool isDealer) 
		{
			const int zeroIndex = 0;
			List<ItemInfo> itemInfo = items.FindAll(_item => _item.name == itemName).ToList();
			return (isDealer) ? itemInfo[zeroIndex].dealerPrice: itemInfo[zeroIndex].standardPrice;
		}

		/// <summary>Gets the customer numbers of all the registered customers.</summary>
		/// <returns>A list of integers with all the customer numbers.</returns>
		/// <exception cref="System.Exception">If something goes wrong while loading the customers from the database.</exception>
		public List<int> getCustomerNumbers() 
		{
			DataTable customersDataTable;
			List<int> customerNumbers = new List<int>();

			const int numberIndex = (int)CustomersTable.CustomerNumber;
			const int nameIndex = (int)CustomersTable.Name;
			const int surnameIndex = (int)CustomersTable.Surname;
			const int idIndex = (int)CustomersTable.ID;
			const int cellIndex = (int)CustomersTable.Cell;
			const int addressIndex = (int)CustomersTable.Address;
			const int idPictureIndex = (int)CustomersTable.IDPicture;

			try
			{
				customersDataTable = database.selectAll(Database.Tables.Customers);
				foreach (DataRow customer in customersDataTable.Rows) 
				{
					CustomerInfo customerInfo = new CustomerInfo();
					customerInfo.number = (int)customer[numberIndex];
					customerInfo.name = customer[nameIndex].ToString();
					customerInfo.surname = customer[surnameIndex].ToString();
					customerInfo.address = customer[addressIndex].ToString();
					customerInfo.cell = customer[cellIndex].ToString();
					customerInfo.id = customer[idIndex].ToString();
					string stringEncodedByteArray = customer[idPictureIndex].ToString();
					
					if (stringEncodedByteArray != Constants.EMPTY_TEXT) 
					{
						byte[] byteArrayPicture = Encoding.Default.GetBytes(stringEncodedByteArray);
						customerInfo.idPicture = GenericModels.byteArrayToImage(byteArrayPicture);
					}
					
					customerInfo.date = DateTime.Now;
					 
					customers.Add(customerInfo);
					customerNumbers.Add(customerInfo.number);
				}
			}
			catch (Exception ex) 
			{
				throw new Exception(ex.Message);
			}

			return customerNumbers;
		}



		/// <summary>Gets the customer information given the customer number.</summary>
		/// <param name="customerNumber">The customer number.</param>
		/// <returns>An object containing all the customer information.</returns>
		public CustomerInfo getCustomerInfo(int customerNumber) 
		{
			const int zeroIndex = 0;
			List<CustomerInfo> customerInfo = customers.FindAll(_customer => _customer.number == customerNumber).ToList();
			return customerInfo[zeroIndex];
		}

		/// <summary>
		/// Enum to give the Transaction type fields
		/// </summary>
		public enum TransactionType
		{
			Purchase,
			Formal_Sale,
			Causual_Sale
		}

		/// <summary>
		/// Class objec to describe an Item.</summary>
		internal class ItemInfo
		{
			public ItemInfo() 
			{
				name = "";
				standardPrice = Constants.DECIMAL_ZERO;
				dealerPrice = Constants.DECIMAL_ZERO;
				type = "";
			}
			/// <summary>Gets or sets the item name.</summary>
			/// <value>The name.</value>
			public string name { get; set; }
			/// <summary>Gets or sets the standard price of the item.</summary>
			/// <value>The standard price.</value>
			public decimal standardPrice { get; set; }
			/// <summary>Gets or sets the dealer price of the item.</summary>
			/// <value>The dealer price.</value>
			public decimal dealerPrice { get; set; }
			/// <summary>Gets or sets the type of the item. Types are Ferrous or Non-Ferrous.</summary>
			/// <value>The type.</value>
			public string type { get; set; }
		}

	}
}
