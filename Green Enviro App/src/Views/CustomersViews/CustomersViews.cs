using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TableCols = Green_Enviro_App.Database.CustomersTableColumns;
using Green_Enviro_App.src.DataAccess;
using FastMember;

namespace Green_Enviro_App
{
	public partial class CustomersViews : Form
	{
        Form parentForm;
        CustomersModel customersModel;
        editingCustomersCompleteCallback callback;

		/// <summary>
		/// Initializes a new instance of the <see cref="CustomersViews"/> class.
		/// </summary>
		/// <param name="cm">The cm.</param>
		public CustomersViews(CustomersModel cm)
        {
            InitializeComponent();
            customersModel = cm;
            initializeCustomers();
        }

		/// <summary>
		/// Activates the Customers form.
		/// </summary>
		public void activateForm(Form parent, editingCustomersCompleteCallback cb)
        {
            callback = cb;
            parentForm = parent;
            this.Activate();
            this.Enabled = true;
            this.Show();
            parentForm.Enabled = false;
            parentForm.Hide();
        }

		/// <summary>
		/// Closes the customers form and reactivats the parent form (Main Form)
		/// </summary>
		private void Exit()
        {
            //Callback function on the receipt page when customers have been updated.
            callback();
            ClearFields();
            this.Hide();
            this.Enabled = false;
            parentForm.Activate();
            parentForm.Enabled = true;
            parentForm.Show();
        }

		/// <summary>
		/// Delagate for the callback function when editing customers is completed.
		/// </summary>
		public delegate void editingCustomersCompleteCallback();
    }
}