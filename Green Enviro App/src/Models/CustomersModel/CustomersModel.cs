using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FastMember;
using Green_Enviro_App.src.DataAccess;
namespace Green_Enviro_App
{
	/// <summary>
	/// Class to handle all the business logic related to customers.
	/// </summary>
	public class CustomersModel
	{
		/// <summary>
		/// Gets all the customers.
		/// </summary>
		/// <returns>A DataTable with all the customers information.</returns>
		public DataTable getCustomers() 
		{
			DataTable customers = new DataTable();
			using (DataEntities context = new DataEntities()) 
			{
				string customerNumber = "CustomerNumber";
				string id = "ID";
				string name = "Name";
				string surname = "Surname";
				string cell = "Cell";
				string address = "Address";
				List<Customer> customersList = context.Customers.ToList();
				using (ObjectReader reader = ObjectReader.Create(customersList, customerNumber, id, name, surname, cell, address)) 
				{
					customers.Load(reader);
				}
			}
			return customers;
		}

		/// <summary>
		/// Gets the customer's ID picture.
		/// </summary>
		/// <param name="customerNumber">The customer number.</param>
		/// <returns>An Image of the customer or Null if the customer has no save ID picture.</returns>
		public Image getIdPicture(int customerNumber) 
		{
			byte[] imageBytes;
			using (DataEntities context = new DataEntities()) 
			{
				imageBytes = context.Customers.FirstOrDefault(_customer => _customer.CustomerNumber == customerNumber).IDPicture;
			}
			Image image;
			if (imageBytes.Length > 0)
			{
				image = (Bitmap)((new ImageConverter()).ConvertFrom(imageBytes));
			}
			else 
			{
				image = null;
			}
			return image;
		}
	}
}
