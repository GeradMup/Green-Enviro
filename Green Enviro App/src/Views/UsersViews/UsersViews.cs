using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Green_Enviro_App
{
	/// <summary>
	/// Class to describe the views on the users form.
	/// </summary>
	/// <seealso cref="System.Windows.Forms.Form" />
	public partial class UsersViews : Form
    {
        UsersModel usersModel;
		Form parentForm;
		
		/// <summary>
		/// Initializes a new instance of the <see cref="UsersViews"/> class.
		/// </summary>
		/// <param name="um">The um.</param>
		public UsersViews(UsersModel um)
        {
            InitializeComponent();
            usersModel = um;
        }

		/// <summary>
		/// Activates the users form.
		/// </summary>
		public void activateForm(Form parent) 
		{
			parentForm = parent;
			parent.Enabled = false;
			parent.Hide();
			this.Enabled = true;
			this.Show();
			this.Activate();
			initializeUsers();

		}

		/// <summary>
		/// Closes the users form.
		/// </summary>
		private void closeForm() 
		{
			parentForm.Enabled = true;
			parentForm.Show();
			this.Close();
		}
	}
}
