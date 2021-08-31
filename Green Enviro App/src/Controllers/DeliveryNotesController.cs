using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Green_Enviro_App
{
	/// <summary>This is the Main_Form partial class class responsible for managing the Delivery Notes Tab</summary>
	public partial class Main_Form : Form
	{
		private List<KeyValuePair<string, double>> deliveryItems = new List<KeyValuePair<string, double>>();

		/// <summary>Initialises the delivery notes tab.</summary>
		public void initialiseDeliveryNotesTab()
		{
			this.DeliveryItemsBox.Text = "********************Items For Delivery********************\n\n";

			List<string> itemNames = _deliveryNotesModel.itemNames(_database);

			//Populate the items list on the Delivery Notes Page
			this.DeliveryItemsList.Items.AddRange(itemNames.Cast<object>().ToArray());
			
			this.DeliveryItemsBox.ReadOnly = true;
		}

		private void DeliveryAddItem_Click(object sender, EventArgs e)
		{
			string errorMessage = "";
			if (DeliveryItemsList.SelectedItem == null) 
			{
				errorMessage = "Please select an Item from the Items list";
				reportError(errorMessage);
				return;
			}

			decimal zero = 0.0M;
			if (DeliveryQuantityBox.Value == zero)
			{
				errorMessage = "Please insert the quantity!";
				reportError(errorMessage);
				return;
			}
		}

		private void clearDeliveryNoteFields() { }

		private void reportError(string errorMessage) 
		{
			new CustomMessageBox(this,CustomMessageBox.error,errorMessage);
		}
	}
}
