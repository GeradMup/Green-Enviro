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
		private const string COMPANY_NOT_SELECTED_ERROR = "Please select the name of the company!";
		private const string DRIVER_NOT_INSERTED_ERROR = "Please insert the name of the driver!";
		private const string VEHICLE_REG_NOT_INSERTED_ERROR = "Please insert the vehicle registration!";
		private const string VECHICLE_TYPE_NOT_SELECTED_ERROR = "Please select the vehicle type";
		private const string DRIVER_CELL_NOT_INSERTED_ERROR = "Please inserted the driver's contact details";

		private const string BUCKY = "BUCKY";
		private const string BIN_TRUCK = "BIN TRUCK";
		private const string RIGID_TRUCK = "RIGID TRUCK";
		private const string HORSE_AND_TRAILER = "HORSE AND TRAILER";
		/// <summary>Initialises the delivery notes tab.</summary>

		DGVOps deliveryNotesDgvOps;
		/// <summary>Initialises the delivery notes tab.</summary>
		public void initialiseDeliveryNotesTab()
		{
			List<string> itemNames = _deliveryNotesModel.getItemNames();
			//Populate the items list on the Delivery Notes Page
			DeliveryItemsList.Items.AddRange(itemNames.Cast<object>().ToArray());

			List<string> companyNames = _deliveryNotesModel.getCompanyNames();
			DeliveryCompaniesList.Items.AddRange(companyNames.Cast<object>().ToArray());
			initialiseVehicleTypes();
			configureDGVOps();

			DeliveryNoteGrid.Visible = true;
			DeliveryNotePDFReader.Visible = false;
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

		private void DeliveryNoteGenerate_Click(object sender, EventArgs e)
		{
			if (DeliveryCompaniesList.SelectedItem == null) { reportError(COMPANY_NOT_SELECTED_ERROR); return; }
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
				_deliveryNotesModel.generateDeliveryNote(companyName, collectorInfo);
			}
			catch (Exception ex) 
			{
				reportError(ex.Message);
			}
		}

		private void clearProductFields() 
		{
			DeliveryItemsList.SelectedItem = null;
			DeliveryQuantityBox.Value = Constants.DECIMAL_ZERO;
		}

		private void reportError(string errorMessage) 
		{
			new CustomMessageBox(this,CustomMessageBox.error,errorMessage);
		}
	}
}
