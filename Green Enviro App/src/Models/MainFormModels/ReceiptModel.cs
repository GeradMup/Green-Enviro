using System;
using System.Collections.Generic;
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

		public static readonly List<string> TRANSACTIONS = new List<string>() { "PURCHASE" , "CASUAL SALE" , "FORMAL SALE"};
		/// <summary>Initializes a new instance of the <see cref="ReceiptModel" /> class.</summary>
		/// <param name="fh">Object of the file handles class.</param>
		/// <param name="csvh">Object of the CSVHandles class.</param>
		public ReceiptModel(FileHandles fh, CSVHandles csvh) 
		{
			fileHandles = fh;
			csvHandles = csvh;
		}

		public List<string> getItems() 
		{
			List<string> items;
			using (DataEntities context = new DataEntities()) 
			{
				items = context.Items.Select(_item => _item.Name).ToList();
			}
			return items;
		}
	}
}
