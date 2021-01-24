
namespace Green_Enviro_App
{
	/// <summary>
	/// Main file that initializes all the project compenents.
	/// Entry point for interaction with form controls in the Main_Form
	///   <br />
	/// </summary>
	partial class Main_Form
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main_Form));
			this.mainTabControl = new System.Windows.Forms.TabControl();
			this.ReceiptPage = new System.Windows.Forms.TabPage();
			this.PriceBox = new System.Windows.Forms.NumericUpDown();
			this.quantityBox = new System.Windows.Forms.NumericUpDown();
			this.CancelPurchaseBtn = new System.Windows.Forms.Button();
			this.PurchaseBtn = new System.Windows.Forms.Button();
			this.CustomerNameTextBox = new System.Windows.Forms.TextBox();
			this.CustomerSurnameTextBox = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.CustomerIDNumberTextBox = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.customerNumbersList = new System.Windows.Forms.ComboBox();
			this.IDPictureBox = new System.Windows.Forms.PictureBox();
			this.DealerPriceCheckBox = new System.Windows.Forms.CheckBox();
			this.PriceOverrideCheckBox = new System.Windows.Forms.CheckBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.logo = new System.Windows.Forms.PictureBox();
			this.itemList = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.addItemBtn = new System.Windows.Forms.Button();
			this.receiptBox = new System.Windows.Forms.RichTextBox();
			this.PurchasesPage = new System.Windows.Forms.TabPage();
			this.removeFiltersBtn = new System.Windows.Forms.Button();
			this.PurchseLogGridView = new System.Windows.Forms.DataGridView();
			this.FilterPurchaseLogBtn = new System.Windows.Forms.Button();
			this.label11 = new System.Windows.Forms.Label();
			this.PurchaseLogMonth = new System.Windows.Forms.ComboBox();
			this.label10 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.PurchaseLogType = new System.Windows.Forms.ComboBox();
			this.PurchaseLogEndDate = new System.Windows.Forms.ComboBox();
			this.PurchaseLogStartDate = new System.Windows.Forms.ComboBox();
			this.SalesPage = new System.Windows.Forms.TabPage();
			this.SaleAmount = new System.Windows.Forms.NumericUpDown();
			this.SaleQuantityBx = new System.Windows.Forms.NumericUpDown();
			this.NewCompanyCheckBox = new System.Windows.Forms.CheckBox();
			this.SaleDate = new System.Windows.Forms.DateTimePicker();
			this.RemoveSalesLogFiltersBtn = new System.Windows.Forms.Button();
			this.FilterSalesLogBtn = new System.Windows.Forms.Button();
			this.label17 = new System.Windows.Forms.Label();
			this.SalesLogMonth = new System.Windows.Forms.ComboBox();
			this.label18 = new System.Windows.Forms.Label();
			this.label19 = new System.Windows.Forms.Label();
			this.label20 = new System.Windows.Forms.Label();
			this.SalesLogType = new System.Windows.Forms.ComboBox();
			this.SalesLogEndDate = new System.Windows.Forms.ComboBox();
			this.SalesLogStartDate = new System.Windows.Forms.ComboBox();
			this.SalesLogGridView = new System.Windows.Forms.DataGridView();
			this.ClearSalesFields = new System.Windows.Forms.Button();
			this.AddSaleBtn = new System.Windows.Forms.Button();
			this.label16 = new System.Windows.Forms.Label();
			this.SaleTypeBx = new System.Windows.Forms.ComboBox();
			this.SaleCompanyNameList = new System.Windows.Forms.ComboBox();
			this.label15 = new System.Windows.Forms.Label();
			this.label14 = new System.Windows.Forms.Label();
			this.label13 = new System.Windows.Forms.Label();
			this.label12 = new System.Windows.Forms.Label();
			this.DestructionCertificates = new System.Windows.Forms.TabPage();
			this.DCNewCompany = new System.Windows.Forms.CheckBox();
			this.dstrctCertCompanyField = new System.Windows.Forms.ComboBox();
			this.dstrctCertQuantityNumBox = new System.Windows.Forms.NumericUpDown();
			this.dstrctCertificateYearList = new System.Windows.Forms.ComboBox();
			this.dstrctCertificateMonthList = new System.Windows.Forms.ComboBox();
			this.dstrctCertificateDayList = new System.Windows.Forms.ComboBox();
			this.dstrctCertQuantityUnit = new System.Windows.Forms.ComboBox();
			this.generateDstrCertBtn = new System.Windows.Forms.Button();
			this.dstrctCertEmailAddressField = new System.Windows.Forms.TextBox();
			this.dstrctCertDescripOfProdField = new System.Windows.Forms.TextBox();
			this.dstrctCertCntactNumField = new System.Windows.Forms.TextBox();
			this.dstrctCertCntactPersonField = new System.Windows.Forms.TextBox();
			this.label27 = new System.Windows.Forms.Label();
			this.label26 = new System.Windows.Forms.Label();
			this.label25 = new System.Windows.Forms.Label();
			this.label24 = new System.Windows.Forms.Label();
			this.label23 = new System.Windows.Forms.Label();
			this.label22 = new System.Windows.Forms.Label();
			this.label21 = new System.Windows.Forms.Label();
			this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
			this.customersTableAdapter1 = new Green_Enviro_App.Green_Enviro_DataDataSetTableAdapters.CustomersTableAdapter();
			this.mainTabControl.SuspendLayout();
			this.ReceiptPage.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.PriceBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.quantityBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.IDPictureBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
			this.PurchasesPage.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.PurchseLogGridView)).BeginInit();
			this.SalesPage.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.SaleAmount)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.SaleQuantityBx)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.SalesLogGridView)).BeginInit();
			this.DestructionCertificates.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dstrctCertQuantityNumBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
			this.SuspendLayout();
			// 
			// mainTabControl
			// 
			this.mainTabControl.Controls.Add(this.ReceiptPage);
			this.mainTabControl.Controls.Add(this.PurchasesPage);
			this.mainTabControl.Controls.Add(this.SalesPage);
			this.mainTabControl.Controls.Add(this.DestructionCertificates);
			this.mainTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
			this.mainTabControl.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.mainTabControl.HotTrack = true;
			this.mainTabControl.Location = new System.Drawing.Point(0, 0);
			this.mainTabControl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.mainTabControl.Name = "mainTabControl";
			this.mainTabControl.SelectedIndex = 0;
			this.mainTabControl.Size = new System.Drawing.Size(1546, 750);
			this.mainTabControl.TabIndex = 0;
			this.mainTabControl.TabStop = false;
			this.mainTabControl.SelectedIndexChanged += new System.EventHandler(this.mainTabControl_SelectedIndexChanged);
			// 
			// ReceiptPage
			// 
			this.ReceiptPage.Controls.Add(this.PriceBox);
			this.ReceiptPage.Controls.Add(this.quantityBox);
			this.ReceiptPage.Controls.Add(this.CancelPurchaseBtn);
			this.ReceiptPage.Controls.Add(this.PurchaseBtn);
			this.ReceiptPage.Controls.Add(this.CustomerNameTextBox);
			this.ReceiptPage.Controls.Add(this.CustomerSurnameTextBox);
			this.ReceiptPage.Controls.Add(this.label7);
			this.ReceiptPage.Controls.Add(this.label6);
			this.ReceiptPage.Controls.Add(this.CustomerIDNumberTextBox);
			this.ReceiptPage.Controls.Add(this.label5);
			this.ReceiptPage.Controls.Add(this.label4);
			this.ReceiptPage.Controls.Add(this.customerNumbersList);
			this.ReceiptPage.Controls.Add(this.IDPictureBox);
			this.ReceiptPage.Controls.Add(this.DealerPriceCheckBox);
			this.ReceiptPage.Controls.Add(this.PriceOverrideCheckBox);
			this.ReceiptPage.Controls.Add(this.label3);
			this.ReceiptPage.Controls.Add(this.label2);
			this.ReceiptPage.Controls.Add(this.logo);
			this.ReceiptPage.Controls.Add(this.itemList);
			this.ReceiptPage.Controls.Add(this.label1);
			this.ReceiptPage.Controls.Add(this.addItemBtn);
			this.ReceiptPage.Controls.Add(this.receiptBox);
			this.ReceiptPage.Location = new System.Drawing.Point(4, 32);
			this.ReceiptPage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.ReceiptPage.Name = "ReceiptPage";
			this.ReceiptPage.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.ReceiptPage.Size = new System.Drawing.Size(1538, 714);
			this.ReceiptPage.TabIndex = 0;
			this.ReceiptPage.Text = "Receipt";
			this.ReceiptPage.UseVisualStyleBackColor = true;
			// 
			// PriceBox
			// 
			this.PriceBox.DecimalPlaces = 2;
			this.PriceBox.Location = new System.Drawing.Point(187, 187);
			this.PriceBox.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
			this.PriceBox.Name = "PriceBox";
			this.PriceBox.ReadOnly = true;
			this.PriceBox.Size = new System.Drawing.Size(197, 31);
			this.PriceBox.TabIndex = 26;
			this.PriceBox.ThousandsSeparator = true;
			// 
			// quantityBox
			// 
			this.quantityBox.DecimalPlaces = 2;
			this.quantityBox.Location = new System.Drawing.Point(187, 254);
			this.quantityBox.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
			this.quantityBox.Name = "quantityBox";
			this.quantityBox.Size = new System.Drawing.Size(197, 31);
			this.quantityBox.TabIndex = 25;
			this.quantityBox.ThousandsSeparator = true;
			// 
			// CancelPurchaseBtn
			// 
			this.CancelPurchaseBtn.AllowDrop = true;
			this.CancelPurchaseBtn.Location = new System.Drawing.Point(185, 657);
			this.CancelPurchaseBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.CancelPurchaseBtn.Name = "CancelPurchaseBtn";
			this.CancelPurchaseBtn.Size = new System.Drawing.Size(212, 50);
			this.CancelPurchaseBtn.TabIndex = 24;
			this.CancelPurchaseBtn.Text = "Cancel Purchase";
			this.CancelPurchaseBtn.UseVisualStyleBackColor = true;
			this.CancelPurchaseBtn.Click += new System.EventHandler(this.CancelPurchaseBtn_Click);
			// 
			// PurchaseBtn
			// 
			this.PurchaseBtn.AllowDrop = true;
			this.PurchaseBtn.Location = new System.Drawing.Point(23, 657);
			this.PurchaseBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.PurchaseBtn.Name = "PurchaseBtn";
			this.PurchaseBtn.Size = new System.Drawing.Size(143, 50);
			this.PurchaseBtn.TabIndex = 23;
			this.PurchaseBtn.Text = "Purchase";
			this.PurchaseBtn.UseVisualStyleBackColor = true;
			this.PurchaseBtn.Click += new System.EventHandler(this.PurchaseBtn_Click);
			// 
			// CustomerNameTextBox
			// 
			this.CustomerNameTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.CustomerNameTextBox.Location = new System.Drawing.Point(727, 185);
			this.CustomerNameTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.CustomerNameTextBox.Name = "CustomerNameTextBox";
			this.CustomerNameTextBox.ReadOnly = true;
			this.CustomerNameTextBox.Size = new System.Drawing.Size(257, 31);
			this.CustomerNameTextBox.TabIndex = 22;
			// 
			// CustomerSurnameTextBox
			// 
			this.CustomerSurnameTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.CustomerSurnameTextBox.Location = new System.Drawing.Point(749, 250);
			this.CustomerSurnameTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.CustomerSurnameTextBox.Name = "CustomerSurnameTextBox";
			this.CustomerSurnameTextBox.ReadOnly = true;
			this.CustomerSurnameTextBox.Size = new System.Drawing.Size(233, 31);
			this.CustomerSurnameTextBox.TabIndex = 21;
			// 
			// label7
			// 
			this.label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(637, 187);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(54, 23);
			this.label7.TabIndex = 20;
			this.label7.Text = "Name";
			// 
			// label6
			// 
			this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(637, 254);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(87, 23);
			this.label6.TabIndex = 19;
			this.label6.Text = "Surname";
			// 
			// CustomerIDNumberTextBox
			// 
			this.CustomerIDNumberTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.CustomerIDNumberTextBox.Location = new System.Drawing.Point(695, 116);
			this.CustomerIDNumberTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.CustomerIDNumberTextBox.Name = "CustomerIDNumberTextBox";
			this.CustomerIDNumberTextBox.ReadOnly = true;
			this.CustomerIDNumberTextBox.Size = new System.Drawing.Size(289, 31);
			this.CustomerIDNumberTextBox.TabIndex = 18;
			// 
			// label5
			// 
			this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(637, 122);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(32, 23);
			this.label5.TabIndex = 17;
			this.label5.Text = "ID";
			// 
			// label4
			// 
			this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(637, 49);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(175, 23);
			this.label4.TabIndex = 16;
			this.label4.Text = "Customer Number";
			// 
			// customerNumbersList
			// 
			this.customerNumbersList.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.customerNumbersList.DropDownHeight = 300;
			this.customerNumbersList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.customerNumbersList.FormattingEnabled = true;
			this.customerNumbersList.IntegralHeight = false;
			this.customerNumbersList.ItemHeight = 23;
			this.customerNumbersList.Location = new System.Drawing.Point(845, 46);
			this.customerNumbersList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.customerNumbersList.Name = "customerNumbersList";
			this.customerNumbersList.Size = new System.Drawing.Size(73, 31);
			this.customerNumbersList.TabIndex = 15;
			this.customerNumbersList.SelectedIndexChanged += new System.EventHandler(this.customerNumbersList_SelectedIndexChanged);
			// 
			// IDPictureBox
			// 
			this.IDPictureBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.IDPictureBox.Location = new System.Drawing.Point(400, 327);
			this.IDPictureBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.IDPictureBox.Name = "IDPictureBox";
			this.IDPictureBox.Size = new System.Drawing.Size(583, 428);
			this.IDPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.IDPictureBox.TabIndex = 1;
			this.IDPictureBox.TabStop = false;
			// 
			// DealerPriceCheckBox
			// 
			this.DealerPriceCheckBox.AutoSize = true;
			this.DealerPriceCheckBox.Location = new System.Drawing.Point(185, 104);
			this.DealerPriceCheckBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.DealerPriceCheckBox.Name = "DealerPriceCheckBox";
			this.DealerPriceCheckBox.Size = new System.Drawing.Size(164, 27);
			this.DealerPriceCheckBox.TabIndex = 14;
			this.DealerPriceCheckBox.Text = "Dealer Price";
			this.DealerPriceCheckBox.UseVisualStyleBackColor = true;
			this.DealerPriceCheckBox.CheckedChanged += new System.EventHandler(this.DealerPriceCheckBox_CheckedChanged);
			// 
			// PriceOverrideCheckBox
			// 
			this.PriceOverrideCheckBox.AutoSize = true;
			this.PriceOverrideCheckBox.Location = new System.Drawing.Point(185, 144);
			this.PriceOverrideCheckBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.PriceOverrideCheckBox.Name = "PriceOverrideCheckBox";
			this.PriceOverrideCheckBox.Size = new System.Drawing.Size(164, 27);
			this.PriceOverrideCheckBox.TabIndex = 13;
			this.PriceOverrideCheckBox.Text = "Manual Price";
			this.PriceOverrideCheckBox.UseVisualStyleBackColor = true;
			this.PriceOverrideCheckBox.CheckedChanged += new System.EventHandler(this.PriceOverrideCheckBox_CheckedChanged);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(27, 187);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(65, 23);
			this.label3.TabIndex = 11;
			this.label3.Text = "Price";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(27, 249);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(98, 23);
			this.label2.TabIndex = 9;
			this.label2.Text = "Quantity";
			// 
			// logo
			// 
			this.logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.logo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.logo.Image = ((System.Drawing.Image)(resources.GetObject("logo.Image")));
			this.logo.InitialImage = null;
			this.logo.Location = new System.Drawing.Point(1135, 11);
			this.logo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.logo.Name = "logo";
			this.logo.Size = new System.Drawing.Size(319, 136);
			this.logo.TabIndex = 8;
			this.logo.TabStop = false;
			this.logo.Visible = false;
			// 
			// itemList
			// 
			this.itemList.DropDownHeight = 300;
			this.itemList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.itemList.FormattingEnabled = true;
			this.itemList.IntegralHeight = false;
			this.itemList.ItemHeight = 23;
			this.itemList.Location = new System.Drawing.Point(187, 46);
			this.itemList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.itemList.Name = "itemList";
			this.itemList.Size = new System.Drawing.Size(203, 31);
			this.itemList.TabIndex = 7;
			this.itemList.SelectedIndexChanged += new System.EventHandler(this.itemList_SelectedIndexChanged);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(27, 54);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(54, 23);
			this.label1.TabIndex = 3;
			this.label1.Text = "Item";
			// 
			// addItemBtn
			// 
			this.addItemBtn.AllowDrop = true;
			this.addItemBtn.Location = new System.Drawing.Point(23, 582);
			this.addItemBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.addItemBtn.Name = "addItemBtn";
			this.addItemBtn.Size = new System.Drawing.Size(143, 50);
			this.addItemBtn.TabIndex = 1;
			this.addItemBtn.Text = "Add Item";
			this.addItemBtn.UseVisualStyleBackColor = true;
			this.addItemBtn.Click += new System.EventHandler(this.addItemBtn_Click);
			// 
			// receiptBox
			// 
			this.receiptBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.receiptBox.BackColor = System.Drawing.Color.White;
			this.receiptBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.receiptBox.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.receiptBox.Location = new System.Drawing.Point(1135, 6);
			this.receiptBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.receiptBox.Name = "receiptBox";
			this.receiptBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.receiptBox.Size = new System.Drawing.Size(400, 645);
			this.receiptBox.TabIndex = 0;
			this.receiptBox.Text = "";
			this.receiptBox.WordWrap = false;
			// 
			// PurchasesPage
			// 
			this.PurchasesPage.Controls.Add(this.removeFiltersBtn);
			this.PurchasesPage.Controls.Add(this.PurchseLogGridView);
			this.PurchasesPage.Controls.Add(this.FilterPurchaseLogBtn);
			this.PurchasesPage.Controls.Add(this.label11);
			this.PurchasesPage.Controls.Add(this.PurchaseLogMonth);
			this.PurchasesPage.Controls.Add(this.label10);
			this.PurchasesPage.Controls.Add(this.label9);
			this.PurchasesPage.Controls.Add(this.label8);
			this.PurchasesPage.Controls.Add(this.PurchaseLogType);
			this.PurchasesPage.Controls.Add(this.PurchaseLogEndDate);
			this.PurchasesPage.Controls.Add(this.PurchaseLogStartDate);
			this.PurchasesPage.Location = new System.Drawing.Point(4, 32);
			this.PurchasesPage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.PurchasesPage.Name = "PurchasesPage";
			this.PurchasesPage.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.PurchasesPage.Size = new System.Drawing.Size(1538, 714);
			this.PurchasesPage.TabIndex = 1;
			this.PurchasesPage.Text = "Purchases Logs";
			this.PurchasesPage.UseVisualStyleBackColor = true;
			// 
			// removeFiltersBtn
			// 
			this.removeFiltersBtn.Location = new System.Drawing.Point(339, 97);
			this.removeFiltersBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.removeFiltersBtn.Name = "removeFiltersBtn";
			this.removeFiltersBtn.Size = new System.Drawing.Size(316, 46);
			this.removeFiltersBtn.TabIndex = 18;
			this.removeFiltersBtn.Text = "Remove Filters";
			this.removeFiltersBtn.UseVisualStyleBackColor = true;
			this.removeFiltersBtn.Click += new System.EventHandler(this.removeFiltersBtn_Click);
			// 
			// PurchseLogGridView
			// 
			this.PurchseLogGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.PurchseLogGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.PurchseLogGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
			this.PurchseLogGridView.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
			this.PurchseLogGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.PurchseLogGridView.Location = new System.Drawing.Point(6, 157);
			this.PurchseLogGridView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.PurchseLogGridView.Name = "PurchseLogGridView";
			this.PurchseLogGridView.ReadOnly = true;
			this.PurchseLogGridView.RowHeadersWidth = 51;
			this.PurchseLogGridView.RowTemplate.Height = 24;
			this.PurchseLogGridView.Size = new System.Drawing.Size(1357, 550);
			this.PurchseLogGridView.TabIndex = 17;
			// 
			// FilterPurchaseLogBtn
			// 
			this.FilterPurchaseLogBtn.Location = new System.Drawing.Point(49, 97);
			this.FilterPurchaseLogBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.FilterPurchaseLogBtn.Name = "FilterPurchaseLogBtn";
			this.FilterPurchaseLogBtn.Size = new System.Drawing.Size(199, 46);
			this.FilterPurchaseLogBtn.TabIndex = 16;
			this.FilterPurchaseLogBtn.Text = "Filter";
			this.FilterPurchaseLogBtn.UseVisualStyleBackColor = true;
			this.FilterPurchaseLogBtn.Click += new System.EventHandler(this.FilterPurchaseLogBtn_Click);
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Location = new System.Drawing.Point(45, 21);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(65, 23);
			this.label11.TabIndex = 15;
			this.label11.Text = "Month";
			// 
			// PurchaseLogMonth
			// 
			this.PurchaseLogMonth.DropDownHeight = 300;
			this.PurchaseLogMonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.PurchaseLogMonth.FormattingEnabled = true;
			this.PurchaseLogMonth.IntegralHeight = false;
			this.PurchaseLogMonth.ItemHeight = 23;
			this.PurchaseLogMonth.Location = new System.Drawing.Point(49, 47);
			this.PurchaseLogMonth.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.PurchaseLogMonth.Name = "PurchaseLogMonth";
			this.PurchaseLogMonth.Size = new System.Drawing.Size(203, 31);
			this.PurchaseLogMonth.TabIndex = 14;
			this.PurchaseLogMonth.SelectedIndexChanged += new System.EventHandler(this.PurchaseLogMonth_SelectedIndexChanged);
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Location = new System.Drawing.Point(1123, 21);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(54, 23);
			this.label10.TabIndex = 13;
			this.label10.Text = "Type";
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(747, 21);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(98, 23);
			this.label9.TabIndex = 12;
			this.label9.Text = "End Date";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(333, 21);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(120, 23);
			this.label8.TabIndex = 11;
			this.label8.Text = "Start Date";
			// 
			// PurchaseLogType
			// 
			this.PurchaseLogType.DropDownHeight = 300;
			this.PurchaseLogType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.PurchaseLogType.FormattingEnabled = true;
			this.PurchaseLogType.IntegralHeight = false;
			this.PurchaseLogType.ItemHeight = 23;
			this.PurchaseLogType.Location = new System.Drawing.Point(1127, 47);
			this.PurchaseLogType.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.PurchaseLogType.Name = "PurchaseLogType";
			this.PurchaseLogType.Size = new System.Drawing.Size(203, 31);
			this.PurchaseLogType.TabIndex = 10;
			// 
			// PurchaseLogEndDate
			// 
			this.PurchaseLogEndDate.DropDownHeight = 300;
			this.PurchaseLogEndDate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.PurchaseLogEndDate.FormattingEnabled = true;
			this.PurchaseLogEndDate.IntegralHeight = false;
			this.PurchaseLogEndDate.ItemHeight = 23;
			this.PurchaseLogEndDate.Location = new System.Drawing.Point(751, 47);
			this.PurchaseLogEndDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.PurchaseLogEndDate.Name = "PurchaseLogEndDate";
			this.PurchaseLogEndDate.Size = new System.Drawing.Size(291, 31);
			this.PurchaseLogEndDate.TabIndex = 9;
			// 
			// PurchaseLogStartDate
			// 
			this.PurchaseLogStartDate.DropDownHeight = 300;
			this.PurchaseLogStartDate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.PurchaseLogStartDate.FormattingEnabled = true;
			this.PurchaseLogStartDate.IntegralHeight = false;
			this.PurchaseLogStartDate.ItemHeight = 23;
			this.PurchaseLogStartDate.Location = new System.Drawing.Point(339, 47);
			this.PurchaseLogStartDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.PurchaseLogStartDate.Name = "PurchaseLogStartDate";
			this.PurchaseLogStartDate.Size = new System.Drawing.Size(316, 31);
			this.PurchaseLogStartDate.TabIndex = 8;
			// 
			// SalesPage
			// 
			this.SalesPage.Controls.Add(this.SaleAmount);
			this.SalesPage.Controls.Add(this.SaleQuantityBx);
			this.SalesPage.Controls.Add(this.NewCompanyCheckBox);
			this.SalesPage.Controls.Add(this.SaleDate);
			this.SalesPage.Controls.Add(this.RemoveSalesLogFiltersBtn);
			this.SalesPage.Controls.Add(this.FilterSalesLogBtn);
			this.SalesPage.Controls.Add(this.label17);
			this.SalesPage.Controls.Add(this.SalesLogMonth);
			this.SalesPage.Controls.Add(this.label18);
			this.SalesPage.Controls.Add(this.label19);
			this.SalesPage.Controls.Add(this.label20);
			this.SalesPage.Controls.Add(this.SalesLogType);
			this.SalesPage.Controls.Add(this.SalesLogEndDate);
			this.SalesPage.Controls.Add(this.SalesLogStartDate);
			this.SalesPage.Controls.Add(this.SalesLogGridView);
			this.SalesPage.Controls.Add(this.ClearSalesFields);
			this.SalesPage.Controls.Add(this.AddSaleBtn);
			this.SalesPage.Controls.Add(this.label16);
			this.SalesPage.Controls.Add(this.SaleTypeBx);
			this.SalesPage.Controls.Add(this.SaleCompanyNameList);
			this.SalesPage.Controls.Add(this.label15);
			this.SalesPage.Controls.Add(this.label14);
			this.SalesPage.Controls.Add(this.label13);
			this.SalesPage.Controls.Add(this.label12);
			this.SalesPage.Location = new System.Drawing.Point(4, 32);
			this.SalesPage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.SalesPage.Name = "SalesPage";
			this.SalesPage.Size = new System.Drawing.Size(1538, 714);
			this.SalesPage.TabIndex = 2;
			this.SalesPage.Text = "Sales Logs";
			this.SalesPage.UseVisualStyleBackColor = true;
			// 
			// SaleAmount
			// 
			this.SaleAmount.DecimalPlaces = 2;
			this.SaleAmount.Location = new System.Drawing.Point(121, 299);
			this.SaleAmount.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
			this.SaleAmount.Name = "SaleAmount";
			this.SaleAmount.Size = new System.Drawing.Size(278, 31);
			this.SaleAmount.TabIndex = 31;
			this.SaleAmount.ThousandsSeparator = true;
			// 
			// SaleQuantityBx
			// 
			this.SaleQuantityBx.DecimalPlaces = 2;
			this.SaleQuantityBx.Location = new System.Drawing.Point(121, 169);
			this.SaleQuantityBx.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
			this.SaleQuantityBx.Name = "SaleQuantityBx";
			this.SaleQuantityBx.Size = new System.Drawing.Size(278, 31);
			this.SaleQuantityBx.TabIndex = 30;
			this.SaleQuantityBx.ThousandsSeparator = true;
			// 
			// NewCompanyCheckBox
			// 
			this.NewCompanyCheckBox.AutoSize = true;
			this.NewCompanyCheckBox.Location = new System.Drawing.Point(129, 64);
			this.NewCompanyCheckBox.Name = "NewCompanyCheckBox";
			this.NewCompanyCheckBox.Size = new System.Drawing.Size(153, 27);
			this.NewCompanyCheckBox.TabIndex = 29;
			this.NewCompanyCheckBox.Text = "New Company";
			this.NewCompanyCheckBox.UseVisualStyleBackColor = true;
			this.NewCompanyCheckBox.CheckedChanged += new System.EventHandler(this.NewCompanyCheckBox_CheckedChanged);
			// 
			// SaleDate
			// 
			this.SaleDate.CalendarFont = new System.Drawing.Font("Consolas", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.SaleDate.Location = new System.Drawing.Point(127, 12);
			this.SaleDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.SaleDate.MaxDate = new System.DateTime(2028, 7, 1, 0, 0, 0, 0);
			this.SaleDate.MinDate = new System.DateTime(2019, 1, 1, 0, 0, 0, 0);
			this.SaleDate.Name = "SaleDate";
			this.SaleDate.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.SaleDate.Size = new System.Drawing.Size(396, 31);
			this.SaleDate.TabIndex = 0;
			this.SaleDate.TabStop = false;
			this.SaleDate.Value = new System.DateTime(2021, 1, 22, 0, 0, 0, 0);
			// 
			// RemoveSalesLogFiltersBtn
			// 
			this.RemoveSalesLogFiltersBtn.Location = new System.Drawing.Point(875, 88);
			this.RemoveSalesLogFiltersBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.RemoveSalesLogFiltersBtn.Name = "RemoveSalesLogFiltersBtn";
			this.RemoveSalesLogFiltersBtn.Size = new System.Drawing.Size(230, 46);
			this.RemoveSalesLogFiltersBtn.TabIndex = 28;
			this.RemoveSalesLogFiltersBtn.Text = "Remove Filters";
			this.RemoveSalesLogFiltersBtn.UseVisualStyleBackColor = true;
			this.RemoveSalesLogFiltersBtn.Click += new System.EventHandler(this.RemoveSalesLogFiltersBtn_Click);
			// 
			// FilterSalesLogBtn
			// 
			this.FilterSalesLogBtn.Location = new System.Drawing.Point(610, 88);
			this.FilterSalesLogBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.FilterSalesLogBtn.Name = "FilterSalesLogBtn";
			this.FilterSalesLogBtn.Size = new System.Drawing.Size(238, 46);
			this.FilterSalesLogBtn.TabIndex = 27;
			this.FilterSalesLogBtn.Text = "Filter";
			this.FilterSalesLogBtn.UseVisualStyleBackColor = true;
			this.FilterSalesLogBtn.Click += new System.EventHandler(this.FilterSalesLogBtn_Click);
			// 
			// label17
			// 
			this.label17.AutoSize = true;
			this.label17.Location = new System.Drawing.Point(606, 13);
			this.label17.Name = "label17";
			this.label17.Size = new System.Drawing.Size(65, 23);
			this.label17.TabIndex = 26;
			this.label17.Text = "Month";
			// 
			// SalesLogMonth
			// 
			this.SalesLogMonth.DropDownHeight = 300;
			this.SalesLogMonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.SalesLogMonth.FormattingEnabled = true;
			this.SalesLogMonth.IntegralHeight = false;
			this.SalesLogMonth.ItemHeight = 23;
			this.SalesLogMonth.Location = new System.Drawing.Point(610, 38);
			this.SalesLogMonth.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.SalesLogMonth.Name = "SalesLogMonth";
			this.SalesLogMonth.Size = new System.Drawing.Size(238, 31);
			this.SalesLogMonth.TabIndex = 25;
			this.SalesLogMonth.SelectedIndexChanged += new System.EventHandler(this.SalesLogMonth_SelectedIndexChanged);
			// 
			// label18
			// 
			this.label18.AutoSize = true;
			this.label18.Location = new System.Drawing.Point(1369, 11);
			this.label18.Name = "label18";
			this.label18.Size = new System.Drawing.Size(54, 23);
			this.label18.TabIndex = 24;
			this.label18.Text = "Type";
			// 
			// label19
			// 
			this.label19.AutoSize = true;
			this.label19.Location = new System.Drawing.Point(1129, 11);
			this.label19.Name = "label19";
			this.label19.Size = new System.Drawing.Size(98, 23);
			this.label19.TabIndex = 23;
			this.label19.Text = "End Date";
			// 
			// label20
			// 
			this.label20.AutoSize = true;
			this.label20.Location = new System.Drawing.Point(871, 11);
			this.label20.Name = "label20";
			this.label20.Size = new System.Drawing.Size(120, 23);
			this.label20.TabIndex = 22;
			this.label20.Text = "Start Date";
			// 
			// SalesLogType
			// 
			this.SalesLogType.DropDownHeight = 300;
			this.SalesLogType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.SalesLogType.FormattingEnabled = true;
			this.SalesLogType.IntegralHeight = false;
			this.SalesLogType.ItemHeight = 23;
			this.SalesLogType.Location = new System.Drawing.Point(1373, 38);
			this.SalesLogType.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.SalesLogType.Name = "SalesLogType";
			this.SalesLogType.Size = new System.Drawing.Size(157, 31);
			this.SalesLogType.TabIndex = 21;
			// 
			// SalesLogEndDate
			// 
			this.SalesLogEndDate.DropDownHeight = 300;
			this.SalesLogEndDate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.SalesLogEndDate.FormattingEnabled = true;
			this.SalesLogEndDate.IntegralHeight = false;
			this.SalesLogEndDate.ItemHeight = 23;
			this.SalesLogEndDate.Location = new System.Drawing.Point(1133, 38);
			this.SalesLogEndDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.SalesLogEndDate.Name = "SalesLogEndDate";
			this.SalesLogEndDate.Size = new System.Drawing.Size(209, 31);
			this.SalesLogEndDate.TabIndex = 20;
			// 
			// SalesLogStartDate
			// 
			this.SalesLogStartDate.DropDownHeight = 300;
			this.SalesLogStartDate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.SalesLogStartDate.FormattingEnabled = true;
			this.SalesLogStartDate.IntegralHeight = false;
			this.SalesLogStartDate.ItemHeight = 23;
			this.SalesLogStartDate.Location = new System.Drawing.Point(875, 38);
			this.SalesLogStartDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.SalesLogStartDate.Name = "SalesLogStartDate";
			this.SalesLogStartDate.Size = new System.Drawing.Size(230, 31);
			this.SalesLogStartDate.TabIndex = 19;
			// 
			// SalesLogGridView
			// 
			this.SalesLogGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.SalesLogGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.SalesLogGridView.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
			this.SalesLogGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.SalesLogGridView.Location = new System.Drawing.Point(610, 155);
			this.SalesLogGridView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.SalesLogGridView.Name = "SalesLogGridView";
			this.SalesLogGridView.RowHeadersWidth = 51;
			this.SalesLogGridView.RowTemplate.Height = 24;
			this.SalesLogGridView.Size = new System.Drawing.Size(925, 552);
			this.SalesLogGridView.TabIndex = 15;
			// 
			// ClearSalesFields
			// 
			this.ClearSalesFields.Location = new System.Drawing.Point(195, 378);
			this.ClearSalesFields.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.ClearSalesFields.Name = "ClearSalesFields";
			this.ClearSalesFields.Size = new System.Drawing.Size(131, 47);
			this.ClearSalesFields.TabIndex = 14;
			this.ClearSalesFields.Text = "Clear";
			this.ClearSalesFields.UseVisualStyleBackColor = true;
			// 
			// AddSaleBtn
			// 
			this.AddSaleBtn.Location = new System.Drawing.Point(12, 378);
			this.AddSaleBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.AddSaleBtn.Name = "AddSaleBtn";
			this.AddSaleBtn.Size = new System.Drawing.Size(131, 47);
			this.AddSaleBtn.TabIndex = 13;
			this.AddSaleBtn.Text = "Add Sale";
			this.AddSaleBtn.UseVisualStyleBackColor = true;
			this.AddSaleBtn.Click += new System.EventHandler(this.AddSaleBtn_Click);
			// 
			// label16
			// 
			this.label16.AutoSize = true;
			this.label16.Location = new System.Drawing.Point(8, 299);
			this.label16.Name = "label16";
			this.label16.Size = new System.Drawing.Size(76, 23);
			this.label16.TabIndex = 12;
			this.label16.Text = "Amount";
			// 
			// SaleTypeBx
			// 
			this.SaleTypeBx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.SaleTypeBx.FormattingEnabled = true;
			this.SaleTypeBx.Location = new System.Drawing.Point(121, 231);
			this.SaleTypeBx.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.SaleTypeBx.Name = "SaleTypeBx";
			this.SaleTypeBx.Size = new System.Drawing.Size(278, 31);
			this.SaleTypeBx.TabIndex = 10;
			// 
			// SaleCompanyNameList
			// 
			this.SaleCompanyNameList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.SaleCompanyNameList.FormattingEnabled = true;
			this.SaleCompanyNameList.Location = new System.Drawing.Point(127, 96);
			this.SaleCompanyNameList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.SaleCompanyNameList.Name = "SaleCompanyNameList";
			this.SaleCompanyNameList.Size = new System.Drawing.Size(396, 31);
			this.SaleCompanyNameList.TabIndex = 9;
			// 
			// label15
			// 
			this.label15.AutoSize = true;
			this.label15.Location = new System.Drawing.Point(8, 234);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(54, 23);
			this.label15.TabIndex = 7;
			this.label15.Text = "Type";
			// 
			// label14
			// 
			this.label14.AutoSize = true;
			this.label14.Location = new System.Drawing.Point(8, 171);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(98, 23);
			this.label14.TabIndex = 6;
			this.label14.Text = "Quantity";
			// 
			// label13
			// 
			this.label13.AutoSize = true;
			this.label13.Location = new System.Drawing.Point(8, 100);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(87, 23);
			this.label13.TabIndex = 5;
			this.label13.Text = "Company";
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Location = new System.Drawing.Point(8, 20);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(54, 23);
			this.label12.TabIndex = 4;
			this.label12.Text = "Date";
			// 
			// DestructionCertificates
			// 
			this.DestructionCertificates.Controls.Add(this.DCNewCompany);
			this.DestructionCertificates.Controls.Add(this.dstrctCertCompanyField);
			this.DestructionCertificates.Controls.Add(this.dstrctCertQuantityNumBox);
			this.DestructionCertificates.Controls.Add(this.dstrctCertificateYearList);
			this.DestructionCertificates.Controls.Add(this.dstrctCertificateMonthList);
			this.DestructionCertificates.Controls.Add(this.dstrctCertificateDayList);
			this.DestructionCertificates.Controls.Add(this.dstrctCertQuantityUnit);
			this.DestructionCertificates.Controls.Add(this.generateDstrCertBtn);
			this.DestructionCertificates.Controls.Add(this.dstrctCertEmailAddressField);
			this.DestructionCertificates.Controls.Add(this.dstrctCertDescripOfProdField);
			this.DestructionCertificates.Controls.Add(this.dstrctCertCntactNumField);
			this.DestructionCertificates.Controls.Add(this.dstrctCertCntactPersonField);
			this.DestructionCertificates.Controls.Add(this.label27);
			this.DestructionCertificates.Controls.Add(this.label26);
			this.DestructionCertificates.Controls.Add(this.label25);
			this.DestructionCertificates.Controls.Add(this.label24);
			this.DestructionCertificates.Controls.Add(this.label23);
			this.DestructionCertificates.Controls.Add(this.label22);
			this.DestructionCertificates.Controls.Add(this.label21);
			this.DestructionCertificates.Location = new System.Drawing.Point(4, 32);
			this.DestructionCertificates.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.DestructionCertificates.Name = "DestructionCertificates";
			this.DestructionCertificates.Size = new System.Drawing.Size(1538, 714);
			this.DestructionCertificates.TabIndex = 3;
			this.DestructionCertificates.Text = "Destruction Certificate";
			this.DestructionCertificates.UseVisualStyleBackColor = true;
			// 
			// DCNewCompany
			// 
			this.DCNewCompany.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.DCNewCompany.AutoSize = true;
			this.DCNewCompany.Location = new System.Drawing.Point(381, 209);
			this.DCNewCompany.Name = "DCNewCompany";
			this.DCNewCompany.Size = new System.Drawing.Size(153, 27);
			this.DCNewCompany.TabIndex = 37;
			this.DCNewCompany.Text = "New Company";
			this.DCNewCompany.UseVisualStyleBackColor = true;
			this.DCNewCompany.CheckedChanged += new System.EventHandler(this.DCNewCompany_CheckedChanged);
			// 
			// dstrctCertCompanyField
			// 
			this.dstrctCertCompanyField.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.dstrctCertCompanyField.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.dstrctCertCompanyField.FormattingEnabled = true;
			this.dstrctCertCompanyField.Location = new System.Drawing.Point(381, 242);
			this.dstrctCertCompanyField.Name = "dstrctCertCompanyField";
			this.dstrctCertCompanyField.Size = new System.Drawing.Size(239, 31);
			this.dstrctCertCompanyField.TabIndex = 36;
			// 
			// dstrctCertQuantityNumBox
			// 
			this.dstrctCertQuantityNumBox.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.dstrctCertQuantityNumBox.DecimalPlaces = 3;
			this.dstrctCertQuantityNumBox.Location = new System.Drawing.Point(381, 434);
			this.dstrctCertQuantityNumBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.dstrctCertQuantityNumBox.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
			this.dstrctCertQuantityNumBox.Name = "dstrctCertQuantityNumBox";
			this.dstrctCertQuantityNumBox.Size = new System.Drawing.Size(129, 31);
			this.dstrctCertQuantityNumBox.TabIndex = 35;
			this.dstrctCertQuantityNumBox.ThousandsSeparator = true;
			// 
			// dstrctCertificateYearList
			// 
			this.dstrctCertificateYearList.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.dstrctCertificateYearList.DropDownHeight = 300;
			this.dstrctCertificateYearList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.dstrctCertificateYearList.FormattingEnabled = true;
			this.dstrctCertificateYearList.IntegralHeight = false;
			this.dstrctCertificateYearList.ItemHeight = 23;
			this.dstrctCertificateYearList.Location = new System.Drawing.Point(336, 53);
			this.dstrctCertificateYearList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.dstrctCertificateYearList.Name = "dstrctCertificateYearList";
			this.dstrctCertificateYearList.Size = new System.Drawing.Size(101, 31);
			this.dstrctCertificateYearList.TabIndex = 34;
			// 
			// dstrctCertificateMonthList
			// 
			this.dstrctCertificateMonthList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.dstrctCertificateMonthList.DropDownHeight = 300;
			this.dstrctCertificateMonthList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.dstrctCertificateMonthList.FormattingEnabled = true;
			this.dstrctCertificateMonthList.IntegralHeight = false;
			this.dstrctCertificateMonthList.ItemHeight = 23;
			this.dstrctCertificateMonthList.Location = new System.Drawing.Point(-148, 53);
			this.dstrctCertificateMonthList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.dstrctCertificateMonthList.Name = "dstrctCertificateMonthList";
			this.dstrctCertificateMonthList.Size = new System.Drawing.Size(144, 31);
			this.dstrctCertificateMonthList.TabIndex = 33;
			// 
			// dstrctCertificateDayList
			// 
			this.dstrctCertificateDayList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.dstrctCertificateDayList.DropDownHeight = 300;
			this.dstrctCertificateDayList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.dstrctCertificateDayList.FormattingEnabled = true;
			this.dstrctCertificateDayList.IntegralHeight = false;
			this.dstrctCertificateDayList.ItemHeight = 23;
			this.dstrctCertificateDayList.Location = new System.Drawing.Point(-247, 53);
			this.dstrctCertificateDayList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.dstrctCertificateDayList.Name = "dstrctCertificateDayList";
			this.dstrctCertificateDayList.Size = new System.Drawing.Size(95, 31);
			this.dstrctCertificateDayList.TabIndex = 32;
			// 
			// dstrctCertQuantityUnit
			// 
			this.dstrctCertQuantityUnit.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.dstrctCertQuantityUnit.DropDownHeight = 300;
			this.dstrctCertQuantityUnit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.dstrctCertQuantityUnit.FormattingEnabled = true;
			this.dstrctCertQuantityUnit.IntegralHeight = false;
			this.dstrctCertQuantityUnit.ItemHeight = 23;
			this.dstrctCertQuantityUnit.Location = new System.Drawing.Point(515, 433);
			this.dstrctCertQuantityUnit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.dstrctCertQuantityUnit.Name = "dstrctCertQuantityUnit";
			this.dstrctCertQuantityUnit.Size = new System.Drawing.Size(125, 31);
			this.dstrctCertQuantityUnit.TabIndex = 31;
			this.dstrctCertQuantityUnit.SelectedIndexChanged += new System.EventHandler(this.dstrctCertQuantityUnit_SelectedIndexChanged);
			// 
			// generateDstrCertBtn
			// 
			this.generateDstrCertBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.generateDstrCertBtn.Location = new System.Drawing.Point(75, 580);
			this.generateDstrCertBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.generateDstrCertBtn.Name = "generateDstrCertBtn";
			this.generateDstrCertBtn.Size = new System.Drawing.Size(263, 73);
			this.generateDstrCertBtn.TabIndex = 30;
			this.generateDstrCertBtn.Text = "Generate Certificate";
			this.generateDstrCertBtn.UseVisualStyleBackColor = true;
			this.generateDstrCertBtn.Click += new System.EventHandler(this.generateDstrCertBtn_Click);
			// 
			// dstrctCertEmailAddressField
			// 
			this.dstrctCertEmailAddressField.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.dstrctCertEmailAddressField.Location = new System.Drawing.Point(381, 301);
			this.dstrctCertEmailAddressField.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.dstrctCertEmailAddressField.Name = "dstrctCertEmailAddressField";
			this.dstrctCertEmailAddressField.ReadOnly = true;
			this.dstrctCertEmailAddressField.Size = new System.Drawing.Size(239, 31);
			this.dstrctCertEmailAddressField.TabIndex = 28;
			// 
			// dstrctCertDescripOfProdField
			// 
			this.dstrctCertDescripOfProdField.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.dstrctCertDescripOfProdField.Location = new System.Drawing.Point(381, 364);
			this.dstrctCertDescripOfProdField.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.dstrctCertDescripOfProdField.Name = "dstrctCertDescripOfProdField";
			this.dstrctCertDescripOfProdField.Size = new System.Drawing.Size(239, 31);
			this.dstrctCertDescripOfProdField.TabIndex = 27;
			// 
			// dstrctCertCntactNumField
			// 
			this.dstrctCertCntactNumField.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.dstrctCertCntactNumField.Location = new System.Drawing.Point(381, 154);
			this.dstrctCertCntactNumField.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.dstrctCertCntactNumField.Name = "dstrctCertCntactNumField";
			this.dstrctCertCntactNumField.ReadOnly = true;
			this.dstrctCertCntactNumField.Size = new System.Drawing.Size(239, 31);
			this.dstrctCertCntactNumField.TabIndex = 25;
			// 
			// dstrctCertCntactPersonField
			// 
			this.dstrctCertCntactPersonField.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.dstrctCertCntactPersonField.Location = new System.Drawing.Point(381, 100);
			this.dstrctCertCntactPersonField.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.dstrctCertCntactPersonField.Name = "dstrctCertCntactPersonField";
			this.dstrctCertCntactPersonField.ReadOnly = true;
			this.dstrctCertCntactPersonField.Size = new System.Drawing.Size(239, 31);
			this.dstrctCertCntactPersonField.TabIndex = 23;
			// 
			// label27
			// 
			this.label27.AutoSize = true;
			this.label27.Location = new System.Drawing.Point(69, 53);
			this.label27.Name = "label27";
			this.label27.Size = new System.Drawing.Size(175, 23);
			this.label27.TabIndex = 11;
			this.label27.Text = "Extraction Date";
			// 
			// label26
			// 
			this.label26.AutoSize = true;
			this.label26.Location = new System.Drawing.Point(69, 103);
			this.label26.Name = "label26";
			this.label26.Size = new System.Drawing.Size(164, 23);
			this.label26.TabIndex = 10;
			this.label26.Text = "Contact Person";
			// 
			// label25
			// 
			this.label25.AutoSize = true;
			this.label25.Location = new System.Drawing.Point(69, 162);
			this.label25.Name = "label25";
			this.label25.Size = new System.Drawing.Size(164, 23);
			this.label25.TabIndex = 9;
			this.label25.Text = "Contact Number";
			this.label25.Click += new System.EventHandler(this.label25_Click);
			// 
			// label24
			// 
			this.label24.AutoSize = true;
			this.label24.Location = new System.Drawing.Point(69, 305);
			this.label24.Name = "label24";
			this.label24.Size = new System.Drawing.Size(153, 23);
			this.label24.TabIndex = 8;
			this.label24.Text = "Email Address";
			// 
			// label23
			// 
			this.label23.AutoSize = true;
			this.label23.Location = new System.Drawing.Point(69, 368);
			this.label23.Name = "label23";
			this.label23.Size = new System.Drawing.Size(252, 23);
			this.label23.TabIndex = 7;
			this.label23.Text = "Description of Product";
			// 
			// label22
			// 
			this.label22.AutoSize = true;
			this.label22.Location = new System.Drawing.Point(69, 250);
			this.label22.Name = "label22";
			this.label22.Size = new System.Drawing.Size(87, 23);
			this.label22.TabIndex = 6;
			this.label22.Text = "Company";
			// 
			// label21
			// 
			this.label21.AutoSize = true;
			this.label21.Location = new System.Drawing.Point(69, 437);
			this.label21.Name = "label21";
			this.label21.Size = new System.Drawing.Size(98, 23);
			this.label21.TabIndex = 5;
			this.label21.Text = "Quantity";
			// 
			// customersTableAdapter1
			// 
			this.customersTableAdapter1.ClearBeforeFill = true;
			// 
			// Main_Form
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1546, 750);
			this.Controls.Add(this.mainTabControl);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.MaximizeBox = false;
			this.MinimumSize = new System.Drawing.Size(98, 596);
			this.Name = "Main_Form";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Green Enviro SA Recycling";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_Form_FormClosing);
			this.mainTabControl.ResumeLayout(false);
			this.ReceiptPage.ResumeLayout(false);
			this.ReceiptPage.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.PriceBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.quantityBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.IDPictureBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
			this.PurchasesPage.ResumeLayout(false);
			this.PurchasesPage.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.PurchseLogGridView)).EndInit();
			this.SalesPage.ResumeLayout(false);
			this.SalesPage.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.SaleAmount)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.SaleQuantityBx)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.SalesLogGridView)).EndInit();
			this.DestructionCertificates.ResumeLayout(false);
			this.DestructionCertificates.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dstrctCertQuantityNumBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TabControl mainTabControl;
		private System.Windows.Forms.TabPage ReceiptPage;
		private System.Windows.Forms.Button addItemBtn;
		private System.Windows.Forms.TabPage PurchasesPage;
		private System.Windows.Forms.TabPage SalesPage;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.BindingSource bindingSource1;

		/// <summary>
		/// ComboBox for containing the design and contents of the receipt
		/// </summary>
		public System.Windows.Forms.RichTextBox receiptBox;

		/// <summary>
		/// List of Items that the company buys
		/// </summary>
		public System.Windows.Forms.ComboBox itemList;
		private System.Windows.Forms.Label label2;

		/// <summary>
		/// Picturebox for inserting the company logo that will go on the receipt
		/// </summary>
		public System.Windows.Forms.PictureBox logo;

		private System.Windows.Forms.Label label3;

		/// <summary>
		///  Check box that will allow users to chose whether to use dealer prices or not
		/// </summary>
		public System.Windows.Forms.CheckBox DealerPriceCheckBox;

		/// <summary>
		/// Check box for selecting whether users can manually insert the price of items or not
		/// </summary>
		public System.Windows.Forms.CheckBox PriceOverrideCheckBox;

		/// <summary>
		/// Field that will show the ID Number of the selected customer
		/// </summary>
		public System.Windows.Forms.TextBox CustomerIDNumberTextBox;

		private System.Windows.Forms.Label label5;

		private System.Windows.Forms.Label label4;

		/// <summary>
		/// Combo box from where the customer numbers can be selected
		/// </summary>
		public System.Windows.Forms.ComboBox customerNumbersList;

		/// <summary>
		/// Field that will show the name of the selected customer. 
		/// Selecting customers can only be done using the customer numbers combo box
		/// </summary>
		public System.Windows.Forms.TextBox CustomerNameTextBox;

		/// <summary>
		/// Field that will show the surname of the selected customer. 
		/// Selecting customers can only be done using the customer numbers combo box
		/// </summary>
		public System.Windows.Forms.TextBox CustomerSurnameTextBox;

		private System.Windows.Forms.Label label7;

		private System.Windows.Forms.Label label6;

		/// <summary>
		/// Picture box that will show the ID Picture of the selected customer. 
		/// Selecting customers can only be done using the customer numbers combo box
		/// </summary>
		public System.Windows.Forms.PictureBox IDPictureBox;

		private System.Windows.Forms.Button PurchaseBtn;

		private System.Windows.Forms.Button CancelPurchaseBtn;

		/// <summary>
		/// Combo box used to set the log filter to either ferrous or non ferrous
		/// </summary>
		public System.Windows.Forms.ComboBox PurchaseLogType;

		/// <summary>
		/// Combo box used to set the start date for the log filter.
		/// When set, the Data Grid View will filter out all entries that were made before this date
		/// </summary>
		public System.Windows.Forms.ComboBox PurchaseLogEndDate;

		/// <summary>
		/// Combo box used to set the end date for the log filter.
		/// When set, the Data Grid View will filter out all entries that were made after this date
		/// </summary>
		public System.Windows.Forms.ComboBox PurchaseLogStartDate;

		private System.Windows.Forms.Button FilterPurchaseLogBtn;

		private System.Windows.Forms.Label label11;


		/// <summary>
		/// Combo box used to select the month for which the user wants to view purchase logs
		/// </summary>
		public System.Windows.Forms.ComboBox PurchaseLogMonth;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label8;

		/// <summary>
		/// Data Grid View for viewing all the purchase logs
		/// </summary>
		public System.Windows.Forms.DataGridView PurchseLogGridView;
		private System.Windows.Forms.Button removeFiltersBtn;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.Label label16;
		private System.Windows.Forms.Button ClearSalesFields;
		private System.Windows.Forms.Button AddSaleBtn;
		private System.Windows.Forms.Button RemoveSalesLogFiltersBtn;
		private System.Windows.Forms.Button FilterSalesLogBtn;
		private System.Windows.Forms.Label label17;
		public System.Windows.Forms.ComboBox SalesLogMonth;
		private System.Windows.Forms.Label label18;
		private System.Windows.Forms.Label label19;
		private System.Windows.Forms.Label label20;
		public System.Windows.Forms.ComboBox SalesLogType;
		public System.Windows.Forms.ComboBox SalesLogEndDate;
		public System.Windows.Forms.ComboBox SalesLogStartDate;
        private System.Windows.Forms.TabPage DestructionCertificates;
        private System.Windows.Forms.Button generateDstrCertBtn;
        public System.Windows.Forms.TextBox dstrctCertEmailAddressField;
        public System.Windows.Forms.TextBox dstrctCertDescripOfProdField;
        public System.Windows.Forms.TextBox dstrctCertCntactNumField;
        public System.Windows.Forms.TextBox dstrctCertCntactPersonField;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label21;
        public System.Windows.Forms.ComboBox dstrctCertQuantityUnit;
		public System.Windows.Forms.DateTimePicker SaleDate;
        public System.Windows.Forms.ComboBox dstrctCertificateYearList;
        public System.Windows.Forms.ComboBox dstrctCertificateMonthList;
        public System.Windows.Forms.ComboBox dstrctCertificateDayList;
        public System.Windows.Forms.NumericUpDown dstrctCertQuantityNumBox;
		public System.Windows.Forms.ComboBox SaleTypeBx;
		public System.Windows.Forms.ComboBox SaleCompanyNameList;
		public System.Windows.Forms.DataGridView SalesLogGridView;
		public System.Windows.Forms.CheckBox NewCompanyCheckBox;
		public System.Windows.Forms.ComboBox dstrctCertCompanyField;
		public System.Windows.Forms.CheckBox DCNewCompany;
		private Green_Enviro_DataDataSetTableAdapters.CustomersTableAdapter customersTableAdapter1;
		public System.Windows.Forms.NumericUpDown SaleQuantityBx;
		public System.Windows.Forms.NumericUpDown PriceBox;
		public System.Windows.Forms.NumericUpDown quantityBox;
		public System.Windows.Forms.NumericUpDown SaleAmount;
	}
}