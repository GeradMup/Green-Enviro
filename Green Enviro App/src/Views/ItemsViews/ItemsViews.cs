using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TableCols = Green_Enviro_App.Database.ItemsTableColumns;
namespace Green_Enviro_App
{

	/// <summary>
	/// Class to do all the item related tasks.
	/// </summary>
	/// <seealso cref="System.Windows.Forms.Form" />
	public partial class ItemsViews : Form
	{

		Database _database;
		Receipt _receit;
		string _previous_value = "";
		DataTable _items;
		Form parentForm;
		/// <summary>
		/// Initializes a new instance of the <see cref="ItemsViews" /> class.
		/// Class/Form used to all the price related editing
		/// </summary>

		public ItemsViews()
		{
			InitializeComponent();
		}

		/// <summary>
		/// Activates the items form.
		/// </summary>
		/// <param name="parent">The parent.</param>
		public void activateForm(Form parent) 
		{
			parentForm = parent;
			this.Enabled = true;
			this.Activate();
			this.Show();
			parent.Enabled = false;
			initialiseItems();
		}

		/// <summary>
		/// Closes the items form.
		/// </summary>
		public void closeForm() 
		{
			this.Enabled = false;
			parentForm.Enabled = true;
			this.Close();
			
		}
	}
}
