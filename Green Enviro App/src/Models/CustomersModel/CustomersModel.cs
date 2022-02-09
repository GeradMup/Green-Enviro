using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
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
			if (imageBytes != null)
			{
				deleteTempPicture();
				using (var ms = new MemoryStream(imageBytes))
				{
					using (var fs = new FileStream(Constants.TEMP_IMAGE_PATH, FileMode.Create))
					{
						ms.WriteTo(fs);
					}
				}
				return new Bitmap(Constants.TEMP_IMAGE_PATH);
			}
			else return null;
		}

		/// <summary>
		/// Inserts a new customer into the database.
		/// </summary>
		/// <param name="customer"></param>
		/// <param name="idPicture">The identifier pic.</param>
		public void addCustomer(Customer customer, Image idPicture)  
		{
			using (DataEntities context = new DataEntities()) 
			{
				Customer testCustomer = context.Customers.FirstOrDefault(_customer => _customer.CustomerNumber == customer.CustomerNumber);


				if (testCustomer.CustomerNumber == customer.CustomerNumber) { throw new CustomerNumberExistsException(customer.CustomerNumber); }
				Customer newCustomer = new Customer
				{
					CustomerNumber = customer.CustomerNumber,
					ID = customer.ID,
					Name = customer.Name,
					Surname = customer.Surname,
					Cell = customer.Cell,
					Address = customer.Address,
				};

				newCustomer.IDPicture = (idPicture == null) ? new byte[] { } : imageToByteArray(idPicture);
				context.Customers.Add(newCustomer);
				context.SaveChanges();
			}
		}

		/// <summary>
		/// converts an Image to byte array.
		/// </summary>
		/// <param name="image">The image.</param>
		/// <returns>The byte array representation of the image.</returns>
		private byte[] imageToByteArray(Image image) 
		{
			using (MemoryStream mStream = new MemoryStream())
			{
				image.Save(mStream, image.RawFormat);
				return mStream.ToArray();
			}
		}

		/// <summary>
		/// Converts byte array to image.
		/// </summary>
		/// <param name="imageBytes"></param>
		/// <returns></returns>
		private Image byteArrayToImage(byte[] imageBytes) 
		{
			using (MemoryStream mStream = new MemoryStream(imageBytes))
			{
				return Image.FromStream(mStream);
			}
		}

		/// <summary>
		/// Updates a customer information.
		/// </summary>
		/// <param name="customer"></param>
		/// <param name="image"></param>
		public void updateCustomer(Customer customer, Image image)
		{
			using (DataEntities context = new DataEntities()) 
			{
				Customer updateCustomer = context.Customers.FirstOrDefault(_customer => _customer.CustomerNumber == customer.CustomerNumber);
				updateCustomer.ID = customer.ID;
				updateCustomer.Name = customer.Name;
				updateCustomer.Surname = customer.Surname;
				updateCustomer.Cell = customer.Cell;
				updateCustomer.Address = customer.Address;
				updateCustomer.IDPicture = (image == null) ? new byte[] { } : imageToByteArray(image);
				context.SaveChanges();
			}
		}

		/// <summary>
		/// Deletes the temporary image stored.
		/// </summary>
		private void deleteTempPicture()
		{
			if (File.Exists(Constants.TEMP_IMAGE_PATH))
			{
				File.Delete(Constants.TEMP_IMAGE_PATH);
			}
		}
	}

	/// <summary>
	/// Exception thrown when a customer number has been duplicated.
	/// </summary>
	/// <seealso cref="System.Exception" />
	public class CustomerNumberExistsException : Exception 
	{
		const string message1 = "Customer number ";
		const string message2 = " already exists!";

		/// <summary>
		/// Initializes a new instance of the <see cref="CustomerNumberExistsException"/> class.
		/// </summary>
		/// <param name="number">The number.</param>
		public CustomerNumberExistsException(int number) : base(message1 + number.ToString() + message2){ }
	}
}
