using System;
using System.Collections.Generic;
using System.Diagnostics;
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
		/// Verifies the user credentials and returns the user permission level.
		/// </summary>
		/// <param name="username">The username.</param>
		/// <param name="password">The password.</param>
		/// <returns>An integer representing the user permission level. -1 if the user does not exist.</returns>
		public int verifyCredentials(string username, string password) 
		{
			User user;
			using (DataEntities context = new DataEntities()) 
			{
				user = context.Users.SingleOrDefault(_user => _user.Username == username);
			}
			if (user == null) return -1;

			InformationEncryption infoEncryptor = new InformationEncryption();
			string storedPassword = infoEncryptor.Decrypt(user.Password);
			if (storedPassword != password) return -1;

			return user.PermissionLevel;
		}

		/// <summary>
		/// Information required to start the Database Sync Program.
		/// </summary>
		/// <param name="userPermissionLevel">The user permission level.</param>
		/// <returns></returns>
		public ProcessStartInfo processStartInfo(int userPermissionLevel) 
		{
			ProcessStartInfo info = new ProcessStartInfo(Constants.DATABASE_SYNC_PROGRAM_PATH);
			string permissionLevel = userPermissionLevel.ToString();
			string mainProgramPath = Constants.MAIN_PROGRAM_PATH;
			info.Arguments = permissionLevel + " " + base64Encoder(mainProgramPath);
			return info;
		}

		/// <summary>
		/// Converts a regular string into a Base64 string.
		/// </summary>
		/// <param name="plainString">The plain string.</param>
		/// <returns></returns>
		public string base64Encoder(string plainString) 
		{
			byte[] plainTextBytes = System.Text.Encoding.UTF8.GetBytes(plainString);
			return System.Convert.ToBase64String(plainTextBytes);
		}

		/// <summary>
		/// Converts a regular string into a base64 string.
		/// </summary>
		/// <param name="base64String">The base64 string.</param>
		/// <returns></returns>
		public string base64Decoder(string base64String) 
		{
			byte[] base64Bytes = System.Convert.FromBase64String(base64String);
			return System.Text.Encoding.UTF8.GetString(base64Bytes);
		}
	}
}
