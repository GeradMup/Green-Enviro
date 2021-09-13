namespace Green_Enviro_App
{

	partial class Main_Form
	{
		//Declarations of all the form controls used on the delivery notes tab.
		private System.Windows.Forms.ComboBox DeliveryItemsList;
		private System.Windows.Forms.Label DeliveryItemsLabel;
		private System.Windows.Forms.Button DeliveryAddItem;
		private System.Windows.Forms.NumericUpDown DeliveryQuantityBox;
		private System.Windows.Forms.Label DeliveryQuantityLabel;
		private System.Windows.Forms.Label CompanyNamesLabel;
		private System.Windows.Forms.ComboBox DeliveryCompaniesList;
		private System.Windows.Forms.Label VehicleTypeLabel;
		private System.Windows.Forms.Label VehicleRegLabel;
		private System.Windows.Forms.Label DriverCellLabel;
		private System.Windows.Forms.Label DriverNameLabel;
		private System.Windows.Forms.ComboBox DeliveryVehicleType;
		private System.Windows.Forms.TextBox DeliveryVehicleReg;
		private System.Windows.Forms.TextBox DeliveryDriverCell;
		private System.Windows.Forms.TextBox DeliveryDriverName;
		private System.Windows.Forms.Label DeliveryNoteGridLabel;
		private System.Windows.Forms.DataGridView DeliveryNoteGrid;
		private System.Windows.Forms.PictureBox VehicleTypePictureBox;
		private System.Windows.Forms.Button DeliveryNoteGenerate;
		private AxAcroPDFLib.AxAcroPDF DeliveryNotePdfDisplay;
		private System.Windows.Forms.ComboBox DeliveryNotesList;
		private System.Windows.Forms.ComboBox DeliveryNotesMonths;
		private System.Windows.Forms.Label DeliveryNotesMonth;
		private System.Windows.Forms.Label DeliveryNotesPrevLabel;
		private System.Windows.Forms.Panel DeliveryNoteDisplayPanel;
		private System.Windows.Forms.Button DeliveryNoteCancel;
		private System.Windows.Forms.Button DeliveryNotePrint;
		System.ComponentModel.ComponentResourceManager resources;
		private void initialiaseDeliveryNotesViews(System.ComponentModel.ComponentResourceManager rsrc)
		{
			resources = rsrc;
			createDeliveryNotesControls();

			suspendDeliveryNotesLayouts();
			addDeliveryNotesControls();
			setUpDeliveryNotesTab();
			setUpDeliveryNotesPrintBtn();
			setUpDeliveryNotesCancelBtn();
			setUpDeliveryNotesDisplayPanel();
			setUpDeliveryNotesPdfDisplay();
			setUpDeliveryNotesList();
			setUpDeliveryNotesMonths();
			setUpDeliveryNotesMonths();
			setUpDeliveryNotesPrevLable();
			setUpGenerateDeliveryNoteBtn();
			setUpDeliveryNoteGridLabel();
			setUpDeliveryNotesGrid();
			setUpDeliveryVehiclePictureBox();
			setUpDeliveryVehicleType();
			setUpVehicleRegTextbox();
			setUpDriverCellTextbox();
			setUpDriverNameTextbox();
			setUpVehicleTypeLabel();
			setUpVehicleRegLabel();
			setUpDriverCellLabel();
			setUpDriverNameLabel();
			setUpCompanyNamesLabel();
			setUpCompanyListCombobox();
			setUpAddDeliveryItemBtn();
			setUpDeliveryQuantityNumericBox();
			setUpDeliveryQuantityLabel();
			setUpDeliveryItemsCombobox();
			setUpDeliveryItemsLabel();
			resumeDeliveryNotesLayouts();
		}
		private void setUpDeliveryItemsLabel()
		{
			// 
			// DeliveryItemsLabel
			// 
			this.DeliveryItemsLabel.AutoSize = true;
			this.DeliveryItemsLabel.Location = new System.Drawing.Point(69, 148);
			this.DeliveryItemsLabel.Name = "DeliveryItemsLabel";
			this.DeliveryItemsLabel.Size = new System.Drawing.Size(65, 23);
			this.DeliveryItemsLabel.TabIndex = 1;
			this.DeliveryItemsLabel.Text = "Items";
		}
		private void setUpDeliveryItemsCombobox()
		{
			// 
			// DeliveryItemsList
			// 
			this.DeliveryItemsList.AllowDrop = true;
			this.DeliveryItemsList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.DeliveryItemsList.FormattingEnabled = true;
			this.DeliveryItemsList.Location = new System.Drawing.Point(392, 144);
			this.DeliveryItemsList.Name = "DeliveryItemsList";
			this.DeliveryItemsList.Size = new System.Drawing.Size(406, 31);
			this.DeliveryItemsList.TabIndex = 2;
		}
		private void setUpDeliveryQuantityLabel()
		{
			// 
			// DeliveryQuantityLabel
			// 
			this.DeliveryQuantityLabel.AllowDrop = true;
			this.DeliveryQuantityLabel.AutoSize = true;
			this.DeliveryQuantityLabel.Location = new System.Drawing.Point(69, 198);
			this.DeliveryQuantityLabel.Name = "DeliveryQuantityLabel";
			this.DeliveryQuantityLabel.Size = new System.Drawing.Size(98, 23);
			this.DeliveryQuantityLabel.TabIndex = 3;
			this.DeliveryQuantityLabel.Text = "Quantity";
		}
		private void setUpDeliveryQuantityNumericBox()
		{
			// 
			// DeliveryQuantityBox
			// 
			this.DeliveryQuantityBox.AllowDrop = true;
			this.DeliveryQuantityBox.DecimalPlaces = 3;
			this.DeliveryQuantityBox.Location = new System.Drawing.Point(392, 195);
			this.DeliveryQuantityBox.Maximum = new decimal(new int[] {
			100000,
			0,
			0,
			0});
			this.DeliveryQuantityBox.Name = "DeliveryQuantityBox";
			this.DeliveryQuantityBox.Size = new System.Drawing.Size(246, 31);
			this.DeliveryQuantityBox.TabIndex = 4;
		}
		private void setUpAddDeliveryItemBtn()
		{
			// 
			// DeliveryAddItem
			// 
			this.DeliveryAddItem.Location = new System.Drawing.Point(392, 247);
			this.DeliveryAddItem.Name = "DeliveryAddItem";
			this.DeliveryAddItem.Size = new System.Drawing.Size(237, 39);
			this.DeliveryAddItem.TabIndex = 5;
			this.DeliveryAddItem.Text = "Add Item";
			this.DeliveryAddItem.UseVisualStyleBackColor = true;
			this.DeliveryAddItem.Click += new System.EventHandler(this.DeliveryAddItem_Click);
		}
		private void setUpCompanyListCombobox()
		{
			// 
			// DeliveryCompaniesList
			// 
			this.DeliveryCompaniesList.AllowDrop = true;
			this.DeliveryCompaniesList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.DeliveryCompaniesList.FormattingEnabled = true;
			this.DeliveryCompaniesList.Location = new System.Drawing.Point(392, 308);
			this.DeliveryCompaniesList.Name = "DeliveryCompaniesList";
			this.DeliveryCompaniesList.Size = new System.Drawing.Size(406, 31);
			this.DeliveryCompaniesList.TabIndex = 6;
		}
		private void setUpCompanyNamesLabel()
		{
			// 
			// CompanyNamesLabel
			// 
			this.CompanyNamesLabel.AllowDrop = true;
			this.CompanyNamesLabel.AutoSize = true;
			this.CompanyNamesLabel.Location = new System.Drawing.Point(71, 319);
			this.CompanyNamesLabel.Name = "CompanyNamesLabel";
			this.CompanyNamesLabel.Size = new System.Drawing.Size(87, 23);
			this.CompanyNamesLabel.TabIndex = 7;
			this.CompanyNamesLabel.Text = "Company";
		}
		private void setUpDriverNameLabel()
		{
			// 
			// DriverNameLabel
			// 
			this.DriverNameLabel.AutoSize = true;
			this.DriverNameLabel.Location = new System.Drawing.Point(72, 367);
			this.DriverNameLabel.Name = "DriverNameLabel";
			this.DriverNameLabel.Size = new System.Drawing.Size(131, 23);
			this.DriverNameLabel.TabIndex = 8;
			this.DriverNameLabel.Text = "Driver Name";
		}
		private void setUpDriverCellLabel()
		{
			// 
			// DriverCellLabel
			// 
			this.DriverCellLabel.AutoSize = true;
			this.DriverCellLabel.Location = new System.Drawing.Point(70, 418);
			this.DriverCellLabel.Name = "DriverCellLabel";
			this.DriverCellLabel.Size = new System.Drawing.Size(208, 23);
			this.DriverCellLabel.TabIndex = 9;
			this.DriverCellLabel.Text = "Driver Cell Number";
		}
		private void setUpVehicleRegLabel()
		{
			// 
			// VehicleRegLabel
			// 
			this.VehicleRegLabel.AutoSize = true;
			this.VehicleRegLabel.Location = new System.Drawing.Point(71, 469);
			this.VehicleRegLabel.Name = "VehicleRegLabel";
			this.VehicleRegLabel.Size = new System.Drawing.Size(230, 23);
			this.VehicleRegLabel.TabIndex = 10;
			this.VehicleRegLabel.Text = "Vehicle Registration";
		}
		private void setUpVehicleTypeLabel()
		{
			// 
			// VehicleTypeLabel
			// 
			this.VehicleTypeLabel.AutoSize = true;
			this.VehicleTypeLabel.Location = new System.Drawing.Point(73, 517);
			this.VehicleTypeLabel.Name = "VehicleTypeLabel";
			this.VehicleTypeLabel.Size = new System.Drawing.Size(142, 23);
			this.VehicleTypeLabel.TabIndex = 11;
			this.VehicleTypeLabel.Text = "Vehicle Type";
		}
		private void setUpDriverNameTextbox()
		{
			// 
			// DeliveryDriverName
			// 
			this.DeliveryDriverName.Location = new System.Drawing.Point(392, 360);
			this.DeliveryDriverName.Name = "DeliveryDriverName";
			this.DeliveryDriverName.Size = new System.Drawing.Size(406, 31);
			this.DeliveryDriverName.TabIndex = 12;
		}
		private void setUpDriverCellTextbox()
		{
			// 
			// DeliveryDriverCell
			// 
			this.DeliveryDriverCell.Location = new System.Drawing.Point(392, 413);
			this.DeliveryDriverCell.Name = "DeliveryDriverCell";
			this.DeliveryDriverCell.Size = new System.Drawing.Size(406, 31);
			this.DeliveryDriverCell.TabIndex = 13;
		}
		private void setUpVehicleRegTextbox()
		{
			// 
			// DeliveryVehicleReg
			// 
			this.DeliveryVehicleReg.Location = new System.Drawing.Point(392, 465);
			this.DeliveryVehicleReg.Name = "DeliveryVehicleReg";
			this.DeliveryVehicleReg.Size = new System.Drawing.Size(406, 31);
			this.DeliveryVehicleReg.TabIndex = 14;
		}
		private void setUpDeliveryVehicleType()
		{
			// 
			// DeliveryVehicleType
			// 
			this.DeliveryVehicleType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.DeliveryVehicleType.FormattingEnabled = true;
			this.DeliveryVehicleType.Location = new System.Drawing.Point(392, 515);
			this.DeliveryVehicleType.Name = "DeliveryVehicleType";
			this.DeliveryVehicleType.Size = new System.Drawing.Size(405, 31);
			this.DeliveryVehicleType.TabIndex = 15;
		}
		private void setUpDeliveryVehiclePictureBox()
		{
			// 
			// VehicleTypePictureBox
			// 
			this.VehicleTypePictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.VehicleTypePictureBox.Location = new System.Drawing.Point(392, 574);
			this.VehicleTypePictureBox.Name = "VehicleTypePictureBox";
			this.VehicleTypePictureBox.Size = new System.Drawing.Size(406, 265);
			this.VehicleTypePictureBox.TabIndex = 16;
			this.VehicleTypePictureBox.TabStop = false;
		}
		private void setUpDeliveryNotesGrid()
		{
			// 
			// DeliveryNoteGrid
			// 
			this.DeliveryNoteGrid.AllowUserToDeleteRows = false;
			this.DeliveryNoteGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
			| System.Windows.Forms.AnchorStyles.Left)
			| System.Windows.Forms.AnchorStyles.Right)));
			this.DeliveryNoteGrid.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
			this.DeliveryNoteGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.DeliveryNoteGrid.Location = new System.Drawing.Point(834, 42);
			this.DeliveryNoteGrid.Name = "DeliveryNoteGrid";
			this.DeliveryNoteGrid.RowHeadersWidth = 51;
			this.DeliveryNoteGrid.RowTemplate.Height = 24;
			this.DeliveryNoteGrid.Size = new System.Drawing.Size(887, 817);
			this.DeliveryNoteGrid.TabIndex = 17;
		}
		private void setUpDeliveryNoteGridLabel()
		{
			// 
			// DeliveryNoteGridLabel
			// 
			this.DeliveryNoteGridLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
			| System.Windows.Forms.AnchorStyles.Right)));
			this.DeliveryNoteGridLabel.AutoSize = true;
			this.DeliveryNoteGridLabel.Location = new System.Drawing.Point(1158, 15);
			this.DeliveryNoteGridLabel.Name = "DeliveryNoteGridLabel";
			this.DeliveryNoteGridLabel.Size = new System.Drawing.Size(241, 23);
			this.DeliveryNoteGridLabel.TabIndex = 18;
			this.DeliveryNoteGridLabel.Text = "ITEMS TO BE DELIVERED";
		}
		private void setUpGenerateDeliveryNoteBtn()
		{
			// 
			// DeliveryNoteGenerate
			// 
			this.DeliveryNoteGenerate.Location = new System.Drawing.Point(78, 573);
			this.DeliveryNoteGenerate.Name = "DeliveryNoteGenerate";
			this.DeliveryNoteGenerate.Size = new System.Drawing.Size(214, 67);
			this.DeliveryNoteGenerate.TabIndex = 19;
			this.DeliveryNoteGenerate.Text = "Generate Delivery Note";
			this.DeliveryNoteGenerate.UseVisualStyleBackColor = true;
			this.DeliveryNoteGenerate.Click += new System.EventHandler(this.DeliveryNoteGenerate_Click);
		}
		private void setUpDeliveryNotesPrevLable()
		{
			// 
			// DeliveryNotesPrevLabel
			// 
			this.DeliveryNotesPrevLabel.AutoSize = true;
			this.DeliveryNotesPrevLabel.Location = new System.Drawing.Point(66, 96);
			this.DeliveryNotesPrevLabel.Name = "DeliveryNotesPrevLabel";
			this.DeliveryNotesPrevLabel.Size = new System.Drawing.Size(263, 23);
			this.DeliveryNotesPrevLabel.TabIndex = 22;
			this.DeliveryNotesPrevLabel.Text = "Previous Delivery Notes";
		}
		private void createDeliveryNotesControls()
		{ 
			this.DeliveryNotePrint = new System.Windows.Forms.Button();
			this.DeliveryNoteCancel = new System.Windows.Forms.Button();
			this.DeliveryNoteDisplayPanel = new System.Windows.Forms.Panel();
			this.DeliveryNotePdfDisplay = new AxAcroPDFLib.AxAcroPDF();
			this.DeliveryNotesList = new System.Windows.Forms.ComboBox();
			this.DeliveryNotesMonths = new System.Windows.Forms.ComboBox();
			this.DeliveryNotesMonth = new System.Windows.Forms.Label();
			this.DeliveryNotesPrevLabel = new System.Windows.Forms.Label();
			this.DeliveryNoteGenerate = new System.Windows.Forms.Button();
			this.DeliveryNoteGridLabel = new System.Windows.Forms.Label();
			this.DeliveryNoteGrid = new System.Windows.Forms.DataGridView();
			this.VehicleTypePictureBox = new System.Windows.Forms.PictureBox();
			this.DeliveryVehicleType = new System.Windows.Forms.ComboBox();
			this.DeliveryVehicleReg = new System.Windows.Forms.TextBox();
			this.DeliveryDriverCell = new System.Windows.Forms.TextBox();
			this.DeliveryDriverName = new System.Windows.Forms.TextBox();
			this.VehicleTypeLabel = new System.Windows.Forms.Label();
			this.VehicleRegLabel = new System.Windows.Forms.Label();
			this.DriverCellLabel = new System.Windows.Forms.Label();
			this.DriverNameLabel = new System.Windows.Forms.Label();
			this.CompanyNamesLabel = new System.Windows.Forms.Label();
			this.DeliveryCompaniesList = new System.Windows.Forms.ComboBox();
			this.DeliveryAddItem = new System.Windows.Forms.Button();
			this.DeliveryQuantityBox = new System.Windows.Forms.NumericUpDown();
			this.DeliveryQuantityLabel = new System.Windows.Forms.Label();
			this.DeliveryItemsList = new System.Windows.Forms.ComboBox();
			this.DeliveryItemsLabel = new System.Windows.Forms.Label();
		}
		private void suspendDeliveryNotesLayouts() 
		{
			this.DeliveryNote.SuspendLayout();
			this.DeliveryNoteDisplayPanel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.DeliveryNotePdfDisplay)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DeliveryNoteGrid)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.VehicleTypePictureBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DeliveryQuantityBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
		}
		private void addDeliveryNotesControls() 
		{
			this.DeliveryNote.AllowDrop = true;
			this.DeliveryNote.Controls.Add(this.DeliveryNotePrint);
			this.DeliveryNote.Controls.Add(this.DeliveryNoteCancel);
			this.DeliveryNote.Controls.Add(this.DeliveryNoteDisplayPanel);
			this.DeliveryNote.Controls.Add(this.DeliveryNotesList);
			this.DeliveryNote.Controls.Add(this.DeliveryNotesMonths);
			this.DeliveryNote.Controls.Add(this.DeliveryNotesMonth);
			this.DeliveryNote.Controls.Add(this.DeliveryNotesPrevLabel);
			this.DeliveryNote.Controls.Add(this.DeliveryNoteGenerate);
			this.DeliveryNote.Controls.Add(this.DeliveryNoteGridLabel);
			this.DeliveryNote.Controls.Add(this.DeliveryNoteGrid);
			this.DeliveryNote.Controls.Add(this.VehicleTypePictureBox);
			this.DeliveryNote.Controls.Add(this.DeliveryVehicleType);
			this.DeliveryNote.Controls.Add(this.DeliveryVehicleReg);
			this.DeliveryNote.Controls.Add(this.DeliveryDriverCell);
			this.DeliveryNote.Controls.Add(this.DeliveryDriverName);
			this.DeliveryNote.Controls.Add(this.VehicleTypeLabel);
			this.DeliveryNote.Controls.Add(this.VehicleRegLabel);
			this.DeliveryNote.Controls.Add(this.DriverCellLabel);
			this.DeliveryNote.Controls.Add(this.DriverNameLabel);
			this.DeliveryNote.Controls.Add(this.CompanyNamesLabel);
			this.DeliveryNote.Controls.Add(this.DeliveryCompaniesList);
			this.DeliveryNote.Controls.Add(this.DeliveryAddItem);
			this.DeliveryNote.Controls.Add(this.DeliveryQuantityBox);
			this.DeliveryNote.Controls.Add(this.DeliveryQuantityLabel);
			this.DeliveryNote.Controls.Add(this.DeliveryItemsList);
			this.DeliveryNote.Controls.Add(this.DeliveryItemsLabel);
		}
		private void setUpDeliveryNotesTab() 
		{
			this.DeliveryNote.Location = new System.Drawing.Point(4, 32);
			this.DeliveryNote.Name = "DeliveryNote";
			this.DeliveryNote.Size = new System.Drawing.Size(1724, 867);
			this.DeliveryNote.TabIndex = 10;
			this.DeliveryNote.Text = "Delivery Note";
			this.DeliveryNote.UseVisualStyleBackColor = true;
		}
		private void setUpDeliveryNotesPrintBtn() 
		{
			this.DeliveryNotePrint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.DeliveryNotePrint.BackColor = System.Drawing.Color.Turquoise;
			this.DeliveryNotePrint.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.DeliveryNotePrint.ForeColor = System.Drawing.SystemColors.ControlText;
			this.DeliveryNotePrint.Location = new System.Drawing.Point(79, 663);
			this.DeliveryNotePrint.Name = "DeliveryNotePrint";
			this.DeliveryNotePrint.Size = new System.Drawing.Size(211, 68);
			this.DeliveryNotePrint.TabIndex = 28;
			this.DeliveryNotePrint.Text = "Print";
			this.DeliveryNotePrint.UseVisualStyleBackColor = false;
			this.DeliveryNotePrint.Click += new System.EventHandler(this.DeliveryNotePrint_Click);
		}
		private void setUpDeliveryNotesCancelBtn() 
		{
			this.DeliveryNoteCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.DeliveryNoteCancel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.DeliveryNoteCancel.BackColor = System.Drawing.Color.Turquoise;
			this.DeliveryNoteCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.DeliveryNoteCancel.Location = new System.Drawing.Point(79, 754);
			this.DeliveryNoteCancel.Name = "DeliveryNoteCancel";
			this.DeliveryNoteCancel.Size = new System.Drawing.Size(212, 62);
			this.DeliveryNoteCancel.TabIndex = 27;
			this.DeliveryNoteCancel.Text = "Cancel";
			this.DeliveryNoteCancel.UseVisualStyleBackColor = false;
			this.DeliveryNoteCancel.Click += new System.EventHandler(this.DeliveryNoteCancel_Click);
		}
		private void setUpDeliveryNotesDisplayPanel() 
		{
			this.DeliveryNoteDisplayPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.DeliveryNoteDisplayPanel.Controls.Add(this.DeliveryNotePdfDisplay);
			this.DeliveryNoteDisplayPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.DeliveryNoteDisplayPanel.Location = new System.Drawing.Point(0, 0);
			this.DeliveryNoteDisplayPanel.Name = "DeliveryNoteDisplayPanel";
			this.DeliveryNoteDisplayPanel.Size = new System.Drawing.Size(1724, 867);
			this.DeliveryNoteDisplayPanel.TabIndex = 26;
		}
		private void setUpDeliveryNotesPdfDisplay() 
		{
			this.DeliveryNotePdfDisplay.AllowDrop = true;
			this.DeliveryNotePdfDisplay.Dock = System.Windows.Forms.DockStyle.Left;
			this.DeliveryNotePdfDisplay.Enabled = true;
			this.DeliveryNotePdfDisplay.Location = new System.Drawing.Point(0, 0);
			this.DeliveryNotePdfDisplay.Name = "DeliveryNotePdfDisplay";
			this.DeliveryNotePdfDisplay.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("DeliveryNotePdfDisplay.OcxState")));
			this.DeliveryNotePdfDisplay.Size = new System.Drawing.Size(1544, 865);
			this.DeliveryNotePdfDisplay.TabIndex = 21;
		}
		private void setUpDeliveryNotesList() 
		{
			this.DeliveryNotesList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.DeliveryNotesList.FormattingEnabled = true;
			this.DeliveryNotesList.Location = new System.Drawing.Point(392, 93);
			this.DeliveryNotesList.Name = "DeliveryNotesList";
			this.DeliveryNotesList.Size = new System.Drawing.Size(405, 31);
			this.DeliveryNotesList.TabIndex = 25;
			this.DeliveryNotesList.SelectedIndexChanged += new System.EventHandler(this.DeliveryNotesList_SelectedIndexChanged);
		}
		private void setUpDeliveryNotesMonths() 
		{
			this.DeliveryNotesMonths.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.DeliveryNotesMonths.FormattingEnabled = true;
			this.DeliveryNotesMonths.Location = new System.Drawing.Point(392, 39);
			this.DeliveryNotesMonths.Name = "DeliveryNotesMonths";
			this.DeliveryNotesMonths.Size = new System.Drawing.Size(405, 31);
			this.DeliveryNotesMonths.TabIndex = 24;
			this.DeliveryNotesMonths.SelectedIndexChanged += new System.EventHandler(this.DeliveryNotesMonths_SelectedIndexChanged);
		}
		private void resumeDeliveryNotesLayouts() 
		{
			this.DeliveryNote.ResumeLayout(false);
			this.DeliveryNote.PerformLayout();
			this.DeliveryNoteDisplayPanel.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.DeliveryNotePdfDisplay)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DeliveryNoteGrid)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.VehicleTypePictureBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DeliveryQuantityBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
		}
	}
}
