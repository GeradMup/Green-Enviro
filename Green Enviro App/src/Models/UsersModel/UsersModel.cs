using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FastMember;
using Green_Enviro_App.src.DataAccess;

namespace Green_Enviro_App
{
	
	/// <summary>
	/// Class to Handle all the business logic relating to the users and user account management.
	/// </summary>
	public class UsersModel
	{

		/// <summary>
		/// Gets all the users from the database.
		/// </summary>
		/// <returns>A DataTable with all the user information.</returns>
		public DataTable getUsers() 
		{
			List<User> allUsers;
			DataTable usersTable = new DataTable();

			using (DataEntities context = new DataEntities()) 
			{
				allUsers = context.Users.ToList();
			}

			string name = "Username";
			string password = "Password";
			string email = "Email";
			string permissionLevel = "PermissionLevel";
			using (ObjectReader reader = ObjectReader.Create(allUsers, name, password, email, permissionLevel)) 
			{
				usersTable.Load(reader);
			}
			return usersTable;
		}


	}
}
