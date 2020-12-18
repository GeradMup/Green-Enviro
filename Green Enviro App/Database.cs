using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;

namespace Green_Enviro_App
{
	
	class Database
	{
		IFirebaseConfig config = new FirebaseConfig
		{
			AuthSecret = "SAn2zMDU2KlQ626lxLPOlO8JUlhdWJQvFqq0Yv3H",
			BasePath= "https://green-enviro-app-default-rtdb.firebaseio.com/"
		};

		IFirebaseClient client;

		public Database() 
		{
			client = new FireSharp.FirebaseClient(config);

			if (client != null)
			{
				MessageBox.Show("Connection Successful");
			}


		}

	}
}
