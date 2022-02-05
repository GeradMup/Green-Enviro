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
	}
}
