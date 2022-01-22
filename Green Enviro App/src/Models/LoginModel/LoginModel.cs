using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Green_Enviro_App.src.DataAccess;

namespace Green_Enviro_App
{
	/// <summary>
	/// Class to handle all businees logic relating to users and loging in. 
	/// </summary>
	class LoginModel
	{
		List<User> allUsers;

		/// <summary>
		/// Initializes a new instance of the <see cref="LoginModel"/> class.
		/// </summary>
		public LoginModel() 
		{
		}

		/// <summary>
		/// Verifies the user credentials.
		/// </summary>
		/// <param name="username">The username.</param>
		/// <param name="password">The password.</param>
		/// <returns>True if user credentials are valid, otherwise false.</returns>
		public bool verifyCredentials(string username, string password) 
		{
			User user;
			using (DataEntities context = new DataEntities()) 
			{
				user = context.Users.SingleOrDefault(_user => _user.Username == username);
			}
			if (user == null) return false;

			InformationEncryption infoEncryptor = new InformationEncryption();
			string storedPassword = infoEncryptor.Decrypt(user.Password);
			if (storedPassword != password) return false;

			return true;
		}


	}
}
