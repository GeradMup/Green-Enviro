using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Green_Enviro_App
{
	/// <summary>This is the Main_Form partial class class responsible for managing the Delivery Notes Tab</summary>
	public partial class Main_Form : Form
	{
		
		private const string ITEM_NOT_SELECTED_ERROR = "Please select an Item from the Items list!";
		private const string QUANTITY_NOT_INSERTED_ERROR = "Please insert the quantity!";
		private const string DELIVERY_COMPANY_NOT_SELECTED_ERROR = "Please select the name of the company!";
		private const string DRIVER_NOT_INSERTED_ERROR = "Please insert the name of the driver!";
		private const string VEHICLE_REG_NOT_INSERTED_ERROR = "Please insert the vehicle registration!";
		private const string VECHICLE_TYPE_NOT_SELECTED_ERROR = "Please select the vehicle type";
		private const string DRIVER_CELL_NOT_INSERTED_ERROR = "Please inserted the driver's contact details";
		private const string DELIVERY_NOTE_GENERATED_SUCCESSFULLY = "Your delivery note has been successfully generated!";

		private const string BUCKY = "BUCKY";
		private const string BIN_TRUCK = "BIN TRUCK";
		private const string RIGID_TRUCK = "RIGID TRUCK";
		private const string HORSE_AND_TRAILER = "HORSE AND TRAILER";

		/// <summary>
		/// Initialises the delivery notes tab.
		/// </summary>
		DGVOps deliveryNotesDgvOps;
		
		/// <summary>
		/// Initialises the delivery notes tab.
		/// </summary>
		public void initialiseDeliveryNotesTab()
		{

			populateDeliveryNotesItems();
			populateDeliveryNotesCompanies();
			populateDeliveryNotesMonths();
			initialiseVehicleTypes();
			configureDGVOps();
			activateDeliveryNotesGrid();

		}

		private void populateDeliveryNotesItems() 
		{
			List<string> itemNames = _deliveryNotesModel.getItemNames();
			//Populate the items list on the Delivery Notes Page
			DeliveryItemsList.Items.AddRange(itemNames.Cast<object>().ToArray());
		}

		private void populateDeliveryNotesCompanies() 
		{
			List<string> companyNames = _deliveryNotesModel.getCompanyNames();
			DeliveryCompaniesList.Items.AddRange(companyNames.Cast<object>().ToArray());
		}

		private void populateDeliveryNotesMonths() 
		{
			List<string> deliveryNotes = _deliveryNotesModel.getLogMonths();
			DeliveryNotesMonths.Items.AddRange(deliveryNotes.Cast<object>().ToArray());
		}

		private void DeliveryNotesMonths_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (DeliveryNotesMonths.SelectedItem == null) return;
			string selectedMonthAndYear = DeliveryNotesMonths.SelectedItem.ToString();
			List<string> deliveryNotes = _deliveryNotesModel.getDeliveryNotes(selectedMonthAndYear);
			DeliveryNotesList.Items.AddRange(deliveryNotes.Cast<object>().ToArray());
		}

		private void activateDeliveryNotesGrid() 
		{
			DeliveryNoteGrid.Visible = true;
			DeliveryNotePdfDisplay.Visible = false;
			DeliveryNoteDisplayPanel.Visible = false;
		}

		private void activateDeliveryNoteDisplay() 
		{
			DeliveryNoteGrid.Visible = false;
			DeliveryNoteDisplayPanel.Visible = true;
			DeliveryNotePdfDisplay.Visible = true;
		}

		private void initialiseVehicleTypes() 
		{
			DeliveryVehicleType.Items.Add(BUCKY);
			DeliveryVehicleType.Items.Add(BIN_TRUCK);
			DeliveryVehicleType.Items.Add(RIGID_TRUCK);
			DeliveryVehicleType.Items.Add(HORSE_AND_TRAILER);
		}

		private void configureDGVOps() 
		{
			ComboBox month = null;
			ComboBox startDate = null;
			ComboBox endDate = null;
			ComboBox type = null;
			Form parentForm = this;
			deliveryNotesDgvOps = new DGVOps(DeliveryNoteGrid,month,startDate,endDate,type,parentForm);
		}

		/// <summary>Handles the Click event of the DeliveryAddItem button control.</summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
		private void DeliveryAddItem_Click(object sender, EventArgs e)
		{
			if (DeliveryItemsList.SelectedItem == null) { reportError(ITEM_NOT_SELECTED_ERROR); return; }
			if (DeliveryQuantityBox.Value == Constants.DECIMAL_ZERO) { reportError(QUANTITY_NOT_INSERTED_ERROR); return; }

			string productName = DeliveryItemsList.SelectedItem.ToString();
			double mass = (double)DeliveryQuantityBox.Value;
			DataTable itemsTable = _deliveryNotesModel.addProduct(productName,mass);

			List<float> columnWidths = new List<float> { 300.0F, 100.0F};
			deliveryNotesDgvOps.changeBindingSource(itemsTable);
			deliveryNotesDgvOps.populateGridView(columnWidths);

			clearProductFields();
		}

		/// <summary>Handles the Click event of the DeliveryNoteGenerate button control.</summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
		private void DeliveryNoteGenerate_Click(object sender, EventArgs e)
		{
			if (DeliveryCompaniesList.SelectedItem == null) { reportError(DELIVERY_COMPANY_NOT_SELECTED_ERROR); return; }
			if (DeliveryDriverName.Text == Constants.EMPTY_TEXT) { reportError(DRIVER_NOT_INSERTED_ERROR); return; }
			if (DeliveryDriverCell.Text == Constants.EMPTY_TEXT) { reportError(DRIVER_CELL_NOT_INSERTED_ERROR); return; }
			if (DeliveryVehicleReg.Text == Constants.EMPTY_TEXT) { reportError(VEHICLE_REG_NOT_INSERTED_ERROR); return; }
			if (DeliveryVehicleType.SelectedItem == null) { reportError(VECHICLE_TYPE_NOT_SELECTED_ERROR); return; }

			string companyName = DeliveryCompaniesList.SelectedItem.ToString();
			DeliveryNotesModel.CollectorInformation collectorInfo = new DeliveryNotesModel.CollectorInformation();

			collectorInfo.name = DeliveryDriverName.Text;
			collectorInfo.cellNumber = DeliveryDriverCell.Text;
			collectorInfo.vehicleRegistration = DeliveryVehicleReg.Text;
			collectorInfo.vehicleType = DeliveryVehicleType.Text;

			try
			{
				string path = _deliveryNotesModel.generateDeliveryNote(companyName, collectorInfo);
				clearCollectorFields();
				displayDeliveryNote(path);
				reportSuccess(DELIVERY_NOTE_GENERATED_SUCCESSFULLY);
				deliveryNotesDgvOps.clearGridView();
			}
			catch (Exception ex) 
			{
				reportError(ex.Message);
			}
		}

		private void displayDeliveryNote(string path) 
		{
			DeliveryNotePdfDisplay.src = path;
			activateDeliveryNoteDisplay();
		}

		/// <summary>
		/// Clears the product name and the quantity.
		/// </summary>
		private void clearProductFields() 
		{
			DeliveryItemsList.SelectedItem = null;
			DeliveryQuantityBox.Value = Constants.DECIMAL_ZERO;
		}

		/// <summary>
		/// Clears all the fields that about the delivery driver's name and the company field.
		/// </summary>
		private void clearCollectorFields() 
		{
			DeliveryCompaniesList.SelectedItem = null;
			DeliveryDriverName.Clear();
			DeliveryDriverCell.Clear();
			DeliveryVehicleReg.Clear();
			DeliveryVehicleType.SelectedItem = null;
		}

		private void clearSelectedDeliveryNote() 
		{
			DeliveryNotesList.SelectedItem = null;
			DeliveryNotesMonths.SelectedItem = null;
		}

		private void DeliveryNotesList_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (DeliveryNotesList.SelectedItem == null) return;
			if (DeliveryNotesMonths.SelectedItem == null) return;

			string selectedDeliveryNote = DeliveryNotesList.SelectedItem.ToString();
			string selectedMonthAndYear = DeliveryNotesMonths.SelectedItem.ToString();
			string pathToDeliveryNote = _deliveryNotesModel.getPathToDeliveryNote(selectedDeliveryNote,selectedMonthAndYear);
			displayDeliveryNote(pathToDeliveryNote);
		}

		private void DeliveryNotePrint_Click(object sender, EventArgs e)
		{
			DeliveryNoteCancel_Click(sender, e);
		}

		private void DeliveryNoteCancel_Click(object sender, EventArgs e)
		{
			resetDeliveryNotes();
		}

		private void resetDeliveryNotes() 
		{
			clearProductFields();
			clearCollectorFields();
			activateDeliveryNotesGrid();
			clearSelectedDeliveryNote();
			deliveryNotesDgvOps.clearGridView();
		}
	}
}
