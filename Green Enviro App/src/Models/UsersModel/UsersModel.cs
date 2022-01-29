using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FastMember;
using Green_Enviro_App.src.DataAccess;
using System.Data.Entity.Validation;
using System.Data.SqlClient;

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

		/// <summary>
		/// Deletes the user from the database given the user name.
		/// </summary>
		/// <param name="userName">Name of the user.</param>
		public void deleteUser(string userName)
		{
			using (DataEntities context = new DataEntities())
			{
				User user = context.Users.FirstOrDefault(_user => _user.Username == userName);
				if (user != null)
				{
					context.Users.Remove(user);
					context.SaveChanges();
				}
			}
		}

		/// <summary>
		/// Adds the new user to the database.
		/// </summary>
		/// <param name="newUser">The user.</param>
		public void addUser(User newUser)
		{
			newUser.Password = InforEncryptor.Encrypt(newUser.Password);
			try
			{
				using (DataEntities context = new DataEntities())
				{
					User checkUser = context.Users.FirstOrDefault(_user => _user.Username == newUser.Username);

					if (checkUser != null)
					{
						throw new DuplicateNameException();
					}
					else
					{
						context.Users.Add(newUser);
						context.SaveChanges();
					}
				}
			}
			catch (DuplicateNameException)
			{
				throw new DuplicateUsernameException();
			}

			catch (Exception) 
			{
				throw new DatabaseInsertionException();
			}

		}

		/// <summary>
		/// Updates the user password.
		/// </summary>
		/// <param name="username">The username.</param>
		/// <param name="oldPassword">The old password.</param>
		/// <param name="newPassword">The new password.</param>
		/// <returns>True if password was updated, False otherwise.</returns>
		public bool updatePassword(string username, string oldPassword, string newPassword) 
		{
			string encryptedOldPassword = InforEncryptor.Encrypt(oldPassword);
			
			using (DataEntities context = new DataEntities()) 
			{
				User user = context.Users.FirstOrDefault(_user => _user.Username == username);
				if (user.Password != encryptedOldPassword) return false;
				else 
				{
					string encryptedNewPassword = InforEncryptor.Encrypt(newPassword);
					user.Password = encryptedNewPassword;
					context.SaveChanges();
					return true;
				}
			}
		}

		/// <summary>
		/// Updates the user information.
		/// </summary>
		/// <param name="currentUserName">Name of the current user.</param>
		/// <param name="updatedUser"></param>
		public void updateUser(string currentUserName, User updatedUser) 
		{
			using (DataEntities context = new DataEntities()) 
			{
				User user = context.Users.FirstOrDefault(_user => _user.Username == currentUserName);
				user.Username = updatedUser.Username;
				user.Email = updatedUser.Email;
				user.PermissionLevel = updatedUser.PermissionLevel;

				context.SaveChanges();
			}
		}
	}

	/// <summary>
	/// Exception to be thrown if the user tries to add duplicate names to the database..
	/// </summary>
	/// <seealso cref="System.Exception" />
	class DuplicateUsernameException : Exception
	{
		const string ERROR_MESSAGE = "Failed to add new user!\nA User with the given name already exists!\nPlease choose another name!";
		public DuplicateUsernameException() : base(ERROR_MESSAGE) { }
	}

	class DatabaseInsertionException : Exception 
	{
		const string ERROR_MESSAGE  = "An Error occured while trying to add the new user to the Database!";
		public DatabaseInsertionException() : base(ERROR_MESSAGE) { }
	}
}
