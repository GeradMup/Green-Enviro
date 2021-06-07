
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
			this.purchaseOrSaleIndicator = new System.Windows.Forms.Label();
			this.CustomerAddress = new System.Windows.Forms.TextBox();
			this.CustomerCellNumber = new System.Windows.Forms.TextBox();
			this.label65 = new System.Windows.Forms.Label();
			this.label64 = new System.Windows.Forms.Label();
			this.LogOutBtn = new System.Windows.Forms.Button();
			this.ReceiptSaleOrPurchase = new System.Windows.Forms.ComboBox();
			this.AddFloatBtn = new System.Windows.Forms.Button();
			this.FloatBox = new System.Windows.Forms.TextBox();
			this.label55 = new System.Windows.Forms.Label();
			this.ReprintReceiptBtn = new System.Windows.Forms.Button();
			this.ReceiptDefaultCustomerCheckBox = new System.Windows.Forms.CheckBox();
			this.EditCustomers = new System.Windows.Forms.Button();
			this.ReceiptPriceEditBtn = new System.Windows.Forms.Button();
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
			this.PrintPoliceRegisterBtn = new System.Windows.Forms.Button();
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
			this.Inventory = new System.Windows.Forms.TabPage();
			this.label63 = new System.Windows.Forms.Label();
			this.label62 = new System.Windows.Forms.Label();
			this.InventoryLogType = new System.Windows.Forms.ComboBox();
			this.InvetorySummedOrNot = new System.Windows.Forms.ComboBox();
			this.InventoryLogGridView = new System.Windows.Forms.DataGridView();
			this.InventoryLogRmvFilterBtn = new System.Windows.Forms.Button();
			this.InventoryLogFilterBtn = new System.Windows.Forms.Button();
			this.label60 = new System.Windows.Forms.Label();
			this.label59 = new System.Windows.Forms.Label();
			this.label58 = new System.Windows.Forms.Label();
			this.InventoryLogEndDate = new System.Windows.Forms.ComboBox();
			this.InventoryLogStartDate = new System.Windows.Forms.ComboBox();
			this.InventoryLogMonth = new System.Windows.Forms.ComboBox();
			this.Expenses = new System.Windows.Forms.TabPage();
			this.ExpenseAmount = new System.Windows.Forms.NumericUpDown();
			this.ExpenseDescriptionBox = new System.Windows.Forms.TextBox();
			this.ExpenseDate = new System.Windows.Forms.DateTimePicker();
			this.ExpensesLogRemoveFiltersBtn = new System.Windows.Forms.Button();
			this.ExpensesLogFilterBtn = new System.Windows.Forms.Button();
			this.label28 = new System.Windows.Forms.Label();
			this.ExpensesLogMonth = new System.Windows.Forms.ComboBox();
			this.label29 = new System.Windows.Forms.Label();
			this.label30 = new System.Windows.Forms.Label();
			this.ExpensesLogEndDate = new System.Windows.Forms.ComboBox();
			this.ExpensesLogStartDate = new System.Windows.Forms.ComboBox();
			this.ExpensesLogGridView = new System.Windows.Forms.DataGridView();
			this.ClearExpenseFieldsBtn = new System.Windows.Forms.Button();
			this.AddExpenseBtn = new System.Windows.Forms.Button();
			this.label31 = new System.Windows.Forms.Label();
			this.label33 = new System.Windows.Forms.Label();
			this.label34 = new System.Windows.Forms.Label();
			this.WagesNewEmployee = new System.Windows.Forms.TabPage();
			this.NewEmployee = new System.Windows.Forms.Button();
			this.PartTimeEmployeeCheckBox = new System.Windows.Forms.CheckBox();
			this.WagesEmployeeName = new System.Windows.Forms.ComboBox();
			this.WageAmount = new System.Windows.Forms.NumericUpDown();
			this.WageDate = new System.Windows.Forms.DateTimePicker();
			this.WageLogRemoveFiltersBtn = new System.Windows.Forms.Button();
			this.WageLogFilterBtn = new System.Windows.Forms.Button();
			this.label32 = new System.Windows.Forms.Label();
			this.WageLogMonth = new System.Windows.Forms.ComboBox();
			this.label35 = new System.Windows.Forms.Label();
			this.label36 = new System.Windows.Forms.Label();
			this.WageLogEndDate = new System.Windows.Forms.ComboBox();
			this.WageLogStartDate = new System.Windows.Forms.ComboBox();
			this.WageLogGridView = new System.Windows.Forms.DataGridView();
			this.ClearWageFieldsBtn = new System.Windows.Forms.Button();
			this.AddWageBtn = new System.Windows.Forms.Button();
			this.label37 = new System.Windows.Forms.Label();
			this.label38 = new System.Windows.Forms.Label();
			this.label39 = new System.Windows.Forms.Label();
			this.Summaries = new System.Windows.Forms.TabPage();
			this.label61 = new System.Windows.Forms.Label();
			this.SummariesTotalFloat = new System.Windows.Forms.RichTextBox();
			this.label57 = new System.Windows.Forms.Label();
			this.SummariesTotalSales = new System.Windows.Forms.RichTextBox();
			this.label56 = new System.Windows.Forms.Label();
			this.SummariesTotalPurchases = new System.Windows.Forms.RichTextBox();
			this.label54 = new System.Windows.Forms.Label();
			this.SummariesProfitBox = new System.Windows.Forms.RichTextBox();
			this.label53 = new System.Windows.Forms.Label();
			this.SummariesMonthSelector = new System.Windows.Forms.ComboBox();
			this.SummariesExpensesBox = new System.Windows.Forms.RichTextBox();
			this.SummariesNFSalesBox = new System.Windows.Forms.RichTextBox();
			this.SummariesFSalesBox = new System.Windows.Forms.RichTextBox();
			this.SummariesWagesBox = new System.Windows.Forms.RichTextBox();
			this.SummariesNFPurchasesBox = new System.Windows.Forms.RichTextBox();
			this.SummariesFPurchasesBox = new System.Windows.Forms.RichTextBox();
			this.label52 = new System.Windows.Forms.Label();
			this.label51 = new System.Windows.Forms.Label();
			this.label50 = new System.Windows.Forms.Label();
			this.label49 = new System.Windows.Forms.Label();
			this.label48 = new System.Windows.Forms.Label();
			this.label47 = new System.Windows.Forms.Label();
			this.DestructionCertificates = new System.Windows.Forms.TabPage();
			this.SendDstrctCertEmailBtn = new System.Windows.Forms.Button();
			this.dstrctCertExtractionDate = new System.Windows.Forms.DateTimePicker();
			this.dstrctCertNewCompanyCheckBox = new System.Windows.Forms.CheckBox();
			this.dstrctCertCompanyField = new System.Windows.Forms.ComboBox();
			this.dstrctCertQuantityNumBox = new System.Windows.Forms.NumericUpDown();
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
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.salesPRDataGridView = new System.Windows.Forms.DataGridView();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.button2 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.button4 = new System.Windows.Forms.Button();
			this.label66 = new System.Windows.Forms.Label();
			this.comboBox4 = new System.Windows.Forms.ComboBox();
			this.label67 = new System.Windows.Forms.Label();
			this.label68 = new System.Windows.Forms.Label();
			this.label69 = new System.Windows.Forms.Label();
			this.comboBox5 = new System.Windows.Forms.ComboBox();
			this.comboBox6 = new System.Windows.Forms.ComboBox();
			this.comboBox7 = new System.Windows.Forms.ComboBox();
			this.PurchasesPRDataGridView = new System.Windows.Forms.DataGridView();
			this.customersTableAdapter1 = new Green_Enviro_App.Green_Enviro_DataDataSetTableAdapters.CustomersTableAdapter();
			this.checkBox1 = new System.Windows.Forms.CheckBox();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
			this.comboBox2 = new System.Windows.Forms.ComboBox();
			this.comboBox3 = new System.Windows.Forms.ComboBox();
			this.button1 = new System.Windows.Forms.Button();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.textBox4 = new System.Windows.Forms.TextBox();
			this.label40 = new System.Windows.Forms.Label();
			this.label41 = new System.Windows.Forms.Label();
			this.label42 = new System.Windows.Forms.Label();
			this.label43 = new System.Windows.Forms.Label();
			this.label44 = new System.Windows.Forms.Label();
			this.label45 = new System.Windows.Forms.Label();
			this.label46 = new System.Windows.Forms.Label();
			this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
			this.colorDialog1 = new System.Windows.Forms.ColorDialog();
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
			this.Inventory.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.InventoryLogGridView)).BeginInit();
			this.Expenses.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.ExpenseAmount)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ExpensesLogGridView)).BeginInit();
			this.WagesNewEmployee.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.WageAmount)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.WageLogGridView)).BeginInit();
			this.Summaries.SuspendLayout();
			this.DestructionCertificates.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dstrctCertQuantityNumBox)).BeginInit();
			this.tabPage1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.salesPRDataGridView)).BeginInit();
			this.tabPage2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.PurchasesPRDataGridView)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
			this.SuspendLayout();
			// 
			// mainTabControl
			// 
			this.mainTabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.mainTabControl.Controls.Add(this.ReceiptPage);
			this.mainTabControl.Controls.Add(this.PurchasesPage);
			this.mainTabControl.Controls.Add(this.SalesPage);
			this.mainTabControl.Controls.Add(this.Inventory);
			this.mainTabControl.Controls.Add(this.Expenses);
			this.mainTabControl.Controls.Add(this.WagesNewEmployee);
			this.mainTabControl.Controls.Add(this.Summaries);
			this.mainTabControl.Controls.Add(this.DestructionCertificates);
			this.mainTabControl.Controls.Add(this.tabPage1);
			this.mainTabControl.Controls.Add(this.tabPage2);
			this.mainTabControl.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.mainTabControl.HotTrack = true;
			this.mainTabControl.Location = new System.Drawing.Point(0, 0);
			this.mainTabControl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.mainTabControl.Name = "mainTabControl";
			this.mainTabControl.SelectedIndex = 0;
			this.mainTabControl.Size = new System.Drawing.Size(1732, 903);
			this.mainTabControl.TabIndex = 0;
			this.mainTabControl.TabStop = false;
			this.mainTabControl.Selected += new System.Windows.Forms.TabControlEventHandler(this.mainTabControl_Selected);
			this.mainTabControl.Deselected += new System.Windows.Forms.TabControlEventHandler(this.mainTabControl_Deselected);
			// 
			// ReceiptPage
			// 
			this.ReceiptPage.Controls.Add(this.purchaseOrSaleIndicator);
			this.ReceiptPage.Controls.Add(this.CustomerAddress);
			this.ReceiptPage.Controls.Add(this.CustomerCellNumber);
			this.ReceiptPage.Controls.Add(this.label65);
			this.ReceiptPage.Controls.Add(this.label64);
			this.ReceiptPage.Controls.Add(this.LogOutBtn);
			this.ReceiptPage.Controls.Add(this.ReceiptSaleOrPurchase);
			this.ReceiptPage.Controls.Add(this.AddFloatBtn);
			this.ReceiptPage.Controls.Add(this.FloatBox);
			this.ReceiptPage.Controls.Add(this.label55);
			this.ReceiptPage.Controls.Add(this.ReprintReceiptBtn);
			this.ReceiptPage.Controls.Add(this.ReceiptDefaultCustomerCheckBox);
			this.ReceiptPage.Controls.Add(this.EditCustomers);
			this.ReceiptPage.Controls.Add(this.ReceiptPriceEditBtn);
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
			this.ReceiptPage.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
			this.ReceiptPage.Name = "ReceiptPage";
			this.ReceiptPage.Padding = new System.Windows.Forms.Padding(4, 2, 4, 2);
			this.ReceiptPage.Size = new System.Drawing.Size(1724, 867);
			this.ReceiptPage.TabIndex = 0;
			this.ReceiptPage.Text = "Receipt";
			this.ReceiptPage.UseVisualStyleBackColor = true;
			// 
			// purchaseOrSaleIndicator
			// 
			this.purchaseOrSaleIndicator.AutoSize = true;
			this.purchaseOrSaleIndicator.BackColor = System.Drawing.Color.Red;
			this.purchaseOrSaleIndicator.Font = new System.Drawing.Font("Consolas", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.purchaseOrSaleIndicator.Location = new System.Drawing.Point(300, 17);
			this.purchaseOrSaleIndicator.Name = "purchaseOrSaleIndicator";
			this.purchaseOrSaleIndicator.Size = new System.Drawing.Size(160, 59);
			this.purchaseOrSaleIndicator.TabIndex = 78;
			this.purchaseOrSaleIndicator.Text = "Start";
			// 
			// CustomerAddress
			// 
			this.CustomerAddress.Location = new System.Drawing.Point(873, 393);
			this.CustomerAddress.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
			this.CustomerAddress.Name = "CustomerAddress";
			this.CustomerAddress.ReadOnly = true;
			this.CustomerAddress.Size = new System.Drawing.Size(325, 31);
			this.CustomerAddress.TabIndex = 77;
			// 
			// CustomerCellNumber
			// 
			this.CustomerCellNumber.Location = new System.Drawing.Point(873, 328);
			this.CustomerCellNumber.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
			this.CustomerCellNumber.Name = "CustomerCellNumber";
			this.CustomerCellNumber.ReadOnly = true;
			this.CustomerCellNumber.Size = new System.Drawing.Size(325, 31);
			this.CustomerCellNumber.TabIndex = 76;
			// 
			// label65
			// 
			this.label65.AutoSize = true;
			this.label65.Location = new System.Drawing.Point(700, 401);
			this.label65.Name = "label65";
			this.label65.Size = new System.Drawing.Size(87, 23);
			this.label65.TabIndex = 75;
			this.label65.Text = "Address";
			// 
			// label64
			// 
			this.label64.AutoSize = true;
			this.label64.Location = new System.Drawing.Point(700, 331);
			this.label64.Name = "label64";
			this.label64.Size = new System.Drawing.Size(54, 23);
			this.label64.TabIndex = 74;
			this.label64.Text = "Cell";
			// 
			// LogOutBtn
			// 
			this.LogOutBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.LogOutBtn.Location = new System.Drawing.Point(1500, 792);
			this.LogOutBtn.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
			this.LogOutBtn.Name = "LogOutBtn";
			this.LogOutBtn.Size = new System.Drawing.Size(208, 58);
			this.LogOutBtn.TabIndex = 73;
			this.LogOutBtn.Text = "Log Out";
			this.LogOutBtn.UseVisualStyleBackColor = true;
			this.LogOutBtn.Click += new System.EventHandler(this.LogOutBtn_Click_1);
			// 
			// ReceiptSaleOrPurchase
			// 
			this.ReceiptSaleOrPurchase.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.ReceiptSaleOrPurchase.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.ReceiptSaleOrPurchase.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ReceiptSaleOrPurchase.FormattingEnabled = true;
			this.ReceiptSaleOrPurchase.Location = new System.Drawing.Point(48, 23);
			this.ReceiptSaleOrPurchase.Name = "ReceiptSaleOrPurchase";
			this.ReceiptSaleOrPurchase.Size = new System.Drawing.Size(216, 31);
			this.ReceiptSaleOrPurchase.TabIndex = 35;
			this.ReceiptSaleOrPurchase.SelectedIndexChanged += new System.EventHandler(this.ReceiptSaleOrPurchase_SelectedIndexChanged);
			// 
			// AddFloatBtn
			// 
			this.AddFloatBtn.Location = new System.Drawing.Point(275, 138);
			this.AddFloatBtn.Name = "AddFloatBtn";
			this.AddFloatBtn.Size = new System.Drawing.Size(164, 48);
			this.AddFloatBtn.TabIndex = 34;
			this.AddFloatBtn.Text = "Add Float";
			this.AddFloatBtn.UseVisualStyleBackColor = true;
			this.AddFloatBtn.Click += new System.EventHandler(this.AddFloatBtn_Click);
			// 
			// FloatBox
			// 
			this.FloatBox.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FloatBox.Location = new System.Drawing.Point(50, 141);
			this.FloatBox.Name = "FloatBox";
			this.FloatBox.ReadOnly = true;
			this.FloatBox.Size = new System.Drawing.Size(214, 43);
			this.FloatBox.TabIndex = 33;
			this.FloatBox.TabStop = false;
			// 
			// label55
			// 
			this.label55.AutoSize = true;
			this.label55.Location = new System.Drawing.Point(46, 115);
			this.label55.Name = "label55";
			this.label55.Size = new System.Drawing.Size(175, 23);
			this.label55.TabIndex = 32;
			this.label55.Text = "Remaining Float";
			// 
			// ReprintReceiptBtn
			// 
			this.ReprintReceiptBtn.AllowDrop = true;
			this.ReprintReceiptBtn.Location = new System.Drawing.Point(41, 778);
			this.ReprintReceiptBtn.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
			this.ReprintReceiptBtn.Name = "ReprintReceiptBtn";
			this.ReprintReceiptBtn.Size = new System.Drawing.Size(410, 62);
			this.ReprintReceiptBtn.TabIndex = 31;
			this.ReprintReceiptBtn.Text = "Re-print Receipt";
			this.ReprintReceiptBtn.UseVisualStyleBackColor = true;
			this.ReprintReceiptBtn.Click += new System.EventHandler(this.ReprintReceiptBtn_Click);
			// 
			// ReceiptDefaultCustomerCheckBox
			// 
			this.ReceiptDefaultCustomerCheckBox.AutoSize = true;
			this.ReceiptDefaultCustomerCheckBox.Location = new System.Drawing.Point(704, 27);
			this.ReceiptDefaultCustomerCheckBox.Name = "ReceiptDefaultCustomerCheckBox";
			this.ReceiptDefaultCustomerCheckBox.Size = new System.Drawing.Size(109, 27);
			this.ReceiptDefaultCustomerCheckBox.TabIndex = 30;
			this.ReceiptDefaultCustomerCheckBox.Text = "Default";
			this.ReceiptDefaultCustomerCheckBox.UseVisualStyleBackColor = true;
			// 
			// EditCustomers
			// 
			this.EditCustomers.Location = new System.Drawing.Point(873, 443);
			this.EditCustomers.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
			this.EditCustomers.Name = "EditCustomers";
			this.EditCustomers.Size = new System.Drawing.Size(222, 32);
			this.EditCustomers.TabIndex = 28;
			this.EditCustomers.Text = "Edit Customers";
			this.EditCustomers.UseVisualStyleBackColor = true;
			this.EditCustomers.Click += new System.EventHandler(this.EditCustomers_Click);
			// 
			// ReceiptPriceEditBtn
			// 
			this.ReceiptPriceEditBtn.Location = new System.Drawing.Point(202, 303);
			this.ReceiptPriceEditBtn.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
			this.ReceiptPriceEditBtn.Name = "ReceiptPriceEditBtn";
			this.ReceiptPriceEditBtn.Size = new System.Drawing.Size(237, 32);
			this.ReceiptPriceEditBtn.TabIndex = 27;
			this.ReceiptPriceEditBtn.Text = "Edit Items";
			this.ReceiptPriceEditBtn.UseVisualStyleBackColor = true;
			this.ReceiptPriceEditBtn.Click += new System.EventHandler(this.ReceiptPriceEditBtn_Click);
			// 
			// PriceBox
			// 
			this.PriceBox.DecimalPlaces = 2;
			this.PriceBox.Location = new System.Drawing.Point(202, 439);
			this.PriceBox.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
			this.PriceBox.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
			this.PriceBox.Name = "PriceBox";
			this.PriceBox.ReadOnly = true;
			this.PriceBox.Size = new System.Drawing.Size(164, 31);
			this.PriceBox.TabIndex = 26;
			this.PriceBox.ThousandsSeparator = true;
			// 
			// quantityBox
			// 
			this.quantityBox.DecimalPlaces = 2;
			this.quantityBox.Location = new System.Drawing.Point(202, 495);
			this.quantityBox.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
			this.quantityBox.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
			this.quantityBox.Name = "quantityBox";
			this.quantityBox.Size = new System.Drawing.Size(164, 31);
			this.quantityBox.TabIndex = 25;
			this.quantityBox.ThousandsSeparator = true;
			// 
			// CancelPurchaseBtn
			// 
			this.CancelPurchaseBtn.AllowDrop = true;
			this.CancelPurchaseBtn.Location = new System.Drawing.Point(41, 688);
			this.CancelPurchaseBtn.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
			this.CancelPurchaseBtn.Name = "CancelPurchaseBtn";
			this.CancelPurchaseBtn.Size = new System.Drawing.Size(410, 62);
			this.CancelPurchaseBtn.TabIndex = 24;
			this.CancelPurchaseBtn.Text = "Cancel";
			this.CancelPurchaseBtn.UseVisualStyleBackColor = true;
			this.CancelPurchaseBtn.Click += new System.EventHandler(this.CancelPurchaseBtn_Click);
			// 
			// PurchaseBtn
			// 
			this.PurchaseBtn.AllowDrop = true;
			this.PurchaseBtn.Location = new System.Drawing.Point(260, 594);
			this.PurchaseBtn.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
			this.PurchaseBtn.Name = "PurchaseBtn";
			this.PurchaseBtn.Size = new System.Drawing.Size(191, 62);
			this.PurchaseBtn.TabIndex = 23;
			this.PurchaseBtn.Text = "Purchase/Sale";
			this.PurchaseBtn.UseVisualStyleBackColor = true;
			this.PurchaseBtn.Click += new System.EventHandler(this.PurchaseBtn_Click);
			// 
			// CustomerNameTextBox
			// 
			this.CustomerNameTextBox.Location = new System.Drawing.Point(873, 187);
			this.CustomerNameTextBox.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
			this.CustomerNameTextBox.Name = "CustomerNameTextBox";
			this.CustomerNameTextBox.ReadOnly = true;
			this.CustomerNameTextBox.Size = new System.Drawing.Size(325, 31);
			this.CustomerNameTextBox.TabIndex = 22;
			// 
			// CustomerSurnameTextBox
			// 
			this.CustomerSurnameTextBox.Location = new System.Drawing.Point(873, 258);
			this.CustomerSurnameTextBox.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
			this.CustomerSurnameTextBox.Name = "CustomerSurnameTextBox";
			this.CustomerSurnameTextBox.ReadOnly = true;
			this.CustomerSurnameTextBox.Size = new System.Drawing.Size(325, 31);
			this.CustomerSurnameTextBox.TabIndex = 21;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(700, 190);
			this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(54, 23);
			this.label7.TabIndex = 20;
			this.label7.Text = "Name";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(700, 258);
			this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(87, 23);
			this.label6.TabIndex = 19;
			this.label6.Text = "Surname";
			// 
			// CustomerIDNumberTextBox
			// 
			this.CustomerIDNumberTextBox.Location = new System.Drawing.Point(873, 124);
			this.CustomerIDNumberTextBox.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
			this.CustomerIDNumberTextBox.Name = "CustomerIDNumberTextBox";
			this.CustomerIDNumberTextBox.ReadOnly = true;
			this.CustomerIDNumberTextBox.Size = new System.Drawing.Size(325, 31);
			this.CustomerIDNumberTextBox.TabIndex = 18;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(700, 127);
			this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(32, 23);
			this.label5.TabIndex = 17;
			this.label5.Text = "ID";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(700, 73);
			this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(175, 23);
			this.label4.TabIndex = 16;
			this.label4.Text = "Customer Number";
			// 
			// customerNumbersList
			// 
			this.customerNumbersList.DropDownHeight = 300;
			this.customerNumbersList.FormattingEnabled = true;
			this.customerNumbersList.IntegralHeight = false;
			this.customerNumbersList.ItemHeight = 23;
			this.customerNumbersList.Location = new System.Drawing.Point(1091, 70);
			this.customerNumbersList.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
			this.customerNumbersList.Name = "customerNumbersList";
			this.customerNumbersList.Size = new System.Drawing.Size(107, 31);
			this.customerNumbersList.TabIndex = 15;
			this.customerNumbersList.SelectedIndexChanged += new System.EventHandler(this.customerNumbersList_SelectedIndexChanged);
			this.customerNumbersList.KeyDown += new System.Windows.Forms.KeyEventHandler(this.customerNumbersList_KeyDown);
			// 
			// IDPictureBox
			// 
			this.IDPictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.IDPictureBox.BackColor = System.Drawing.Color.Transparent;
			this.IDPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.IDPictureBox.Location = new System.Drawing.Point(704, 495);
			this.IDPictureBox.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
			this.IDPictureBox.Name = "IDPictureBox";
			this.IDPictureBox.Size = new System.Drawing.Size(560, 365);
			this.IDPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.IDPictureBox.TabIndex = 1;
			this.IDPictureBox.TabStop = false;
			// 
			// DealerPriceCheckBox
			// 
			this.DealerPriceCheckBox.AutoSize = true;
			this.DealerPriceCheckBox.Location = new System.Drawing.Point(202, 363);
			this.DealerPriceCheckBox.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
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
			this.PriceOverrideCheckBox.Location = new System.Drawing.Point(202, 398);
			this.PriceOverrideCheckBox.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
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
			this.label3.Location = new System.Drawing.Point(44, 441);
			this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(65, 23);
			this.label3.TabIndex = 11;
			this.label3.Text = "Price";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(44, 497);
			this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(98, 23);
			this.label2.TabIndex = 9;
			this.label2.Text = "Quantity";
			// 
			// logo
			// 
			this.logo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.logo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.logo.Image = ((System.Drawing.Image)(resources.GetObject("logo.Image")));
			this.logo.InitialImage = null;
			this.logo.Location = new System.Drawing.Point(1283, 34);
			this.logo.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
			this.logo.Name = "logo";
			this.logo.Size = new System.Drawing.Size(425, 167);
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
			this.itemList.Location = new System.Drawing.Point(202, 247);
			this.itemList.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
			this.itemList.Name = "itemList";
			this.itemList.Size = new System.Drawing.Size(237, 31);
			this.itemList.TabIndex = 7;
			this.itemList.SelectedIndexChanged += new System.EventHandler(this.itemList_SelectedIndexChanged);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(44, 249);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(54, 23);
			this.label1.TabIndex = 3;
			this.label1.Text = "Item";
			// 
			// addItemBtn
			// 
			this.addItemBtn.AllowDrop = true;
			this.addItemBtn.Location = new System.Drawing.Point(41, 594);
			this.addItemBtn.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
			this.addItemBtn.Name = "addItemBtn";
			this.addItemBtn.Size = new System.Drawing.Size(191, 62);
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
			this.receiptBox.Location = new System.Drawing.Point(1281, 32);
			this.receiptBox.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
			this.receiptBox.Name = "receiptBox";
			this.receiptBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.receiptBox.Size = new System.Drawing.Size(432, 735);
			this.receiptBox.TabIndex = 0;
			this.receiptBox.Text = "";
			this.receiptBox.WordWrap = false;
			// 
			// PurchasesPage
			// 
			this.PurchasesPage.Controls.Add(this.PrintPoliceRegisterBtn);
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
			this.PurchasesPage.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
			this.PurchasesPage.Name = "PurchasesPage";
			this.PurchasesPage.Padding = new System.Windows.Forms.Padding(4, 2, 4, 2);
			this.PurchasesPage.Size = new System.Drawing.Size(1724, 867);
			this.PurchasesPage.TabIndex = 1;
			this.PurchasesPage.Text = "Purchases";
			this.PurchasesPage.UseVisualStyleBackColor = true;
			// 
			// PrintPoliceRegisterBtn
			// 
			this.PrintPoliceRegisterBtn.Location = new System.Drawing.Point(765, 119);
			this.PrintPoliceRegisterBtn.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
			this.PrintPoliceRegisterBtn.Name = "PrintPoliceRegisterBtn";
			this.PrintPoliceRegisterBtn.Size = new System.Drawing.Size(265, 57);
			this.PrintPoliceRegisterBtn.TabIndex = 19;
			this.PrintPoliceRegisterBtn.Text = "Print Register";
			this.PrintPoliceRegisterBtn.UseVisualStyleBackColor = true;
			this.PrintPoliceRegisterBtn.Click += new System.EventHandler(this.PrintPoliceRegisterBtn_Click);
			// 
			// removeFiltersBtn
			// 
			this.removeFiltersBtn.Location = new System.Drawing.Point(400, 119);
			this.removeFiltersBtn.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
			this.removeFiltersBtn.Name = "removeFiltersBtn";
			this.removeFiltersBtn.Size = new System.Drawing.Size(297, 57);
			this.removeFiltersBtn.TabIndex = 18;
			this.removeFiltersBtn.Text = "Remove Filters";
			this.removeFiltersBtn.UseVisualStyleBackColor = true;
			this.removeFiltersBtn.Click += new System.EventHandler(this.removeFiltersBtn_Click);
			// 
			// PurchseLogGridView
			// 
			this.PurchseLogGridView.AllowUserToAddRows = false;
			this.PurchseLogGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.PurchseLogGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.PurchseLogGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
			this.PurchseLogGridView.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
			this.PurchseLogGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.PurchseLogGridView.Location = new System.Drawing.Point(64, 204);
			this.PurchseLogGridView.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
			this.PurchseLogGridView.Name = "PurchseLogGridView";
			this.PurchseLogGridView.ReadOnly = true;
			this.PurchseLogGridView.RowHeadersWidth = 51;
			this.PurchseLogGridView.RowTemplate.Height = 24;
			this.PurchseLogGridView.Size = new System.Drawing.Size(1651, 656);
			this.PurchseLogGridView.TabIndex = 17;
			// 
			// FilterPurchaseLogBtn
			// 
			this.FilterPurchaseLogBtn.Location = new System.Drawing.Point(65, 119);
			this.FilterPurchaseLogBtn.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
			this.FilterPurchaseLogBtn.Name = "FilterPurchaseLogBtn";
			this.FilterPurchaseLogBtn.Size = new System.Drawing.Size(265, 57);
			this.FilterPurchaseLogBtn.TabIndex = 16;
			this.FilterPurchaseLogBtn.Text = "Filter";
			this.FilterPurchaseLogBtn.UseVisualStyleBackColor = true;
			this.FilterPurchaseLogBtn.Click += new System.EventHandler(this.FilterPurchaseLogBtn_Click);
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Location = new System.Drawing.Point(60, 26);
			this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
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
			this.PurchaseLogMonth.Location = new System.Drawing.Point(65, 58);
			this.PurchaseLogMonth.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
			this.PurchaseLogMonth.Name = "PurchaseLogMonth";
			this.PurchaseLogMonth.Size = new System.Drawing.Size(269, 31);
			this.PurchaseLogMonth.TabIndex = 14;
			this.PurchaseLogMonth.SelectedIndexChanged += new System.EventHandler(this.PurchaseLogMonth_SelectedIndexChanged);
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Location = new System.Drawing.Point(1120, 26);
			this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(54, 23);
			this.label10.TabIndex = 13;
			this.label10.Text = "Type";
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(761, 26);
			this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(98, 23);
			this.label9.TabIndex = 12;
			this.label9.Text = "End Date";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(396, 26);
			this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
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
			this.PurchaseLogType.Location = new System.Drawing.Point(1124, 58);
			this.PurchaseLogType.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
			this.PurchaseLogType.Name = "PurchaseLogType";
			this.PurchaseLogType.Size = new System.Drawing.Size(269, 31);
			this.PurchaseLogType.TabIndex = 10;
			// 
			// PurchaseLogEndDate
			// 
			this.PurchaseLogEndDate.DropDownHeight = 300;
			this.PurchaseLogEndDate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.PurchaseLogEndDate.FormattingEnabled = true;
			this.PurchaseLogEndDate.IntegralHeight = false;
			this.PurchaseLogEndDate.ItemHeight = 23;
			this.PurchaseLogEndDate.Location = new System.Drawing.Point(765, 58);
			this.PurchaseLogEndDate.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
			this.PurchaseLogEndDate.Name = "PurchaseLogEndDate";
			this.PurchaseLogEndDate.Size = new System.Drawing.Size(289, 31);
			this.PurchaseLogEndDate.TabIndex = 9;
			// 
			// PurchaseLogStartDate
			// 
			this.PurchaseLogStartDate.DropDownHeight = 300;
			this.PurchaseLogStartDate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.PurchaseLogStartDate.FormattingEnabled = true;
			this.PurchaseLogStartDate.IntegralHeight = false;
			this.PurchaseLogStartDate.ItemHeight = 23;
			this.PurchaseLogStartDate.Location = new System.Drawing.Point(400, 58);
			this.PurchaseLogStartDate.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
			this.PurchaseLogStartDate.Name = "PurchaseLogStartDate";
			this.PurchaseLogStartDate.Size = new System.Drawing.Size(297, 31);
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
			this.SalesPage.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
			this.SalesPage.Name = "SalesPage";
			this.SalesPage.Size = new System.Drawing.Size(1724, 867);
			this.SalesPage.TabIndex = 2;
			this.SalesPage.Text = "Sales";
			this.SalesPage.UseVisualStyleBackColor = true;
			// 
			// SaleAmount
			// 
			this.SaleAmount.DecimalPlaces = 2;
			this.SaleAmount.Location = new System.Drawing.Point(161, 368);
			this.SaleAmount.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
			this.SaleAmount.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
			this.SaleAmount.Name = "SaleAmount";
			this.SaleAmount.Size = new System.Drawing.Size(148, 31);
			this.SaleAmount.TabIndex = 31;
			this.SaleAmount.ThousandsSeparator = true;
			// 
			// SaleQuantityBx
			// 
			this.SaleQuantityBx.DecimalPlaces = 2;
			this.SaleQuantityBx.Location = new System.Drawing.Point(161, 197);
			this.SaleQuantityBx.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.SaleQuantityBx.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
			this.SaleQuantityBx.Name = "SaleQuantityBx";
			this.SaleQuantityBx.Size = new System.Drawing.Size(148, 31);
			this.SaleQuantityBx.TabIndex = 30;
			this.SaleQuantityBx.ThousandsSeparator = true;
			// 
			// NewCompanyCheckBox
			// 
			this.NewCompanyCheckBox.AutoSize = true;
			this.NewCompanyCheckBox.Location = new System.Drawing.Point(161, 80);
			this.NewCompanyCheckBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
			this.SaleDate.Location = new System.Drawing.Point(161, 19);
			this.SaleDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.SaleDate.MaxDate = new System.DateTime(2028, 7, 1, 0, 0, 0, 0);
			this.SaleDate.MinDate = new System.DateTime(2019, 1, 1, 0, 0, 0, 0);
			this.SaleDate.Name = "SaleDate";
			this.SaleDate.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.SaleDate.Size = new System.Drawing.Size(413, 31);
			this.SaleDate.TabIndex = 0;
			this.SaleDate.TabStop = false;
			this.SaleDate.Value = new System.DateTime(2021, 1, 22, 0, 0, 0, 0);
			// 
			// RemoveSalesLogFiltersBtn
			// 
			this.RemoveSalesLogFiltersBtn.Location = new System.Drawing.Point(885, 94);
			this.RemoveSalesLogFiltersBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.RemoveSalesLogFiltersBtn.Name = "RemoveSalesLogFiltersBtn";
			this.RemoveSalesLogFiltersBtn.Size = new System.Drawing.Size(229, 46);
			this.RemoveSalesLogFiltersBtn.TabIndex = 28;
			this.RemoveSalesLogFiltersBtn.Text = "Remove Filters";
			this.RemoveSalesLogFiltersBtn.UseVisualStyleBackColor = true;
			this.RemoveSalesLogFiltersBtn.Click += new System.EventHandler(this.RemoveSalesLogFiltersBtn_Click);
			// 
			// FilterSalesLogBtn
			// 
			this.FilterSalesLogBtn.Location = new System.Drawing.Point(644, 94);
			this.FilterSalesLogBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.FilterSalesLogBtn.Name = "FilterSalesLogBtn";
			this.FilterSalesLogBtn.Size = new System.Drawing.Size(184, 46);
			this.FilterSalesLogBtn.TabIndex = 27;
			this.FilterSalesLogBtn.Text = "Filter";
			this.FilterSalesLogBtn.UseVisualStyleBackColor = true;
			this.FilterSalesLogBtn.Click += new System.EventHandler(this.FilterSalesLogBtn_Click);
			// 
			// label17
			// 
			this.label17.AutoSize = true;
			this.label17.Location = new System.Drawing.Point(641, 19);
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
			this.SalesLogMonth.Location = new System.Drawing.Point(644, 46);
			this.SalesLogMonth.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.SalesLogMonth.Name = "SalesLogMonth";
			this.SalesLogMonth.Size = new System.Drawing.Size(259, 31);
			this.SalesLogMonth.TabIndex = 25;
			this.SalesLogMonth.SelectedIndexChanged += new System.EventHandler(this.SalesLogMonth_SelectedIndexChanged);
			// 
			// label18
			// 
			this.label18.AutoSize = true;
			this.label18.Location = new System.Drawing.Point(1525, 19);
			this.label18.Name = "label18";
			this.label18.Size = new System.Drawing.Size(54, 23);
			this.label18.TabIndex = 24;
			this.label18.Text = "Type";
			// 
			// label19
			// 
			this.label19.AutoSize = true;
			this.label19.Location = new System.Drawing.Point(1238, 19);
			this.label19.Name = "label19";
			this.label19.Size = new System.Drawing.Size(98, 23);
			this.label19.TabIndex = 23;
			this.label19.Text = "End Date";
			// 
			// label20
			// 
			this.label20.AutoSize = true;
			this.label20.Location = new System.Drawing.Point(932, 19);
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
			this.SalesLogType.Location = new System.Drawing.Point(1528, 46);
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
			this.SalesLogEndDate.Location = new System.Drawing.Point(1241, 46);
			this.SalesLogEndDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.SalesLogEndDate.Name = "SalesLogEndDate";
			this.SalesLogEndDate.Size = new System.Drawing.Size(255, 31);
			this.SalesLogEndDate.TabIndex = 20;
			// 
			// SalesLogStartDate
			// 
			this.SalesLogStartDate.DropDownHeight = 300;
			this.SalesLogStartDate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.SalesLogStartDate.FormattingEnabled = true;
			this.SalesLogStartDate.IntegralHeight = false;
			this.SalesLogStartDate.ItemHeight = 23;
			this.SalesLogStartDate.Location = new System.Drawing.Point(935, 46);
			this.SalesLogStartDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.SalesLogStartDate.Name = "SalesLogStartDate";
			this.SalesLogStartDate.Size = new System.Drawing.Size(277, 31);
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
			this.SalesLogGridView.Location = new System.Drawing.Point(645, 182);
			this.SalesLogGridView.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
			this.SalesLogGridView.Name = "SalesLogGridView";
			this.SalesLogGridView.ReadOnly = true;
			this.SalesLogGridView.RowHeadersWidth = 51;
			this.SalesLogGridView.RowTemplate.Height = 24;
			this.SalesLogGridView.Size = new System.Drawing.Size(1075, 678);
			this.SalesLogGridView.TabIndex = 15;
			// 
			// ClearSalesFields
			// 
			this.ClearSalesFields.Location = new System.Drawing.Point(260, 465);
			this.ClearSalesFields.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
			this.ClearSalesFields.Name = "ClearSalesFields";
			this.ClearSalesFields.Size = new System.Drawing.Size(175, 58);
			this.ClearSalesFields.TabIndex = 14;
			this.ClearSalesFields.Text = "Clear";
			this.ClearSalesFields.UseVisualStyleBackColor = true;
			this.ClearSalesFields.Click += new System.EventHandler(this.ClearSalesFields_Click);
			// 
			// AddSaleBtn
			// 
			this.AddSaleBtn.Location = new System.Drawing.Point(16, 465);
			this.AddSaleBtn.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
			this.AddSaleBtn.Name = "AddSaleBtn";
			this.AddSaleBtn.Size = new System.Drawing.Size(175, 58);
			this.AddSaleBtn.TabIndex = 13;
			this.AddSaleBtn.Text = "Add Sale";
			this.AddSaleBtn.UseVisualStyleBackColor = true;
			this.AddSaleBtn.Click += new System.EventHandler(this.AddSaleBtn_Click);
			// 
			// label16
			// 
			this.label16.AutoSize = true;
			this.label16.Location = new System.Drawing.Point(11, 368);
			this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label16.Name = "label16";
			this.label16.Size = new System.Drawing.Size(76, 23);
			this.label16.TabIndex = 12;
			this.label16.Text = "Amount";
			// 
			// SaleTypeBx
			// 
			this.SaleTypeBx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.SaleTypeBx.FormattingEnabled = true;
			this.SaleTypeBx.Location = new System.Drawing.Point(161, 285);
			this.SaleTypeBx.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
			this.SaleTypeBx.Name = "SaleTypeBx";
			this.SaleTypeBx.Size = new System.Drawing.Size(220, 31);
			this.SaleTypeBx.TabIndex = 10;
			// 
			// SaleCompanyNameList
			// 
			this.SaleCompanyNameList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.SaleCompanyNameList.FormattingEnabled = true;
			this.SaleCompanyNameList.Location = new System.Drawing.Point(161, 120);
			this.SaleCompanyNameList.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
			this.SaleCompanyNameList.Name = "SaleCompanyNameList";
			this.SaleCompanyNameList.Size = new System.Drawing.Size(413, 31);
			this.SaleCompanyNameList.TabIndex = 9;
			// 
			// label15
			// 
			this.label15.AutoSize = true;
			this.label15.Location = new System.Drawing.Point(11, 288);
			this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(54, 23);
			this.label15.TabIndex = 7;
			this.label15.Text = "Type";
			// 
			// label14
			// 
			this.label14.AutoSize = true;
			this.label14.Location = new System.Drawing.Point(11, 199);
			this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(98, 23);
			this.label14.TabIndex = 6;
			this.label14.Text = "Quantity";
			// 
			// label13
			// 
			this.label13.AutoSize = true;
			this.label13.Location = new System.Drawing.Point(11, 123);
			this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(87, 23);
			this.label13.TabIndex = 5;
			this.label13.Text = "Company";
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Location = new System.Drawing.Point(11, 25);
			this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(54, 23);
			this.label12.TabIndex = 4;
			this.label12.Text = "Date";
			// 
			// Inventory
			// 
			this.Inventory.Controls.Add(this.label63);
			this.Inventory.Controls.Add(this.label62);
			this.Inventory.Controls.Add(this.InventoryLogType);
			this.Inventory.Controls.Add(this.InvetorySummedOrNot);
			this.Inventory.Controls.Add(this.InventoryLogGridView);
			this.Inventory.Controls.Add(this.InventoryLogRmvFilterBtn);
			this.Inventory.Controls.Add(this.InventoryLogFilterBtn);
			this.Inventory.Controls.Add(this.label60);
			this.Inventory.Controls.Add(this.label59);
			this.Inventory.Controls.Add(this.label58);
			this.Inventory.Controls.Add(this.InventoryLogEndDate);
			this.Inventory.Controls.Add(this.InventoryLogStartDate);
			this.Inventory.Controls.Add(this.InventoryLogMonth);
			this.Inventory.Location = new System.Drawing.Point(4, 32);
			this.Inventory.Name = "Inventory";
			this.Inventory.Size = new System.Drawing.Size(1724, 867);
			this.Inventory.TabIndex = 7;
			this.Inventory.Text = "Inventory";
			this.Inventory.UseVisualStyleBackColor = true;
			// 
			// label63
			// 
			this.label63.AutoSize = true;
			this.label63.Location = new System.Drawing.Point(39, 26);
			this.label63.Name = "label63";
			this.label63.Size = new System.Drawing.Size(197, 23);
			this.label63.TabIndex = 12;
			this.label63.Text = "Summed/Not Summed";
			// 
			// label62
			// 
			this.label62.AutoSize = true;
			this.label62.Location = new System.Drawing.Point(1464, 26);
			this.label62.Name = "label62";
			this.label62.Size = new System.Drawing.Size(54, 23);
			this.label62.TabIndex = 11;
			this.label62.Text = "Type";
			// 
			// InventoryLogType
			// 
			this.InventoryLogType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.InventoryLogType.FormattingEnabled = true;
			this.InventoryLogType.Items.AddRange(new object[] {
            "Ferrous",
            "Non-Ferrous"});
			this.InventoryLogType.Location = new System.Drawing.Point(1468, 52);
			this.InventoryLogType.Name = "InventoryLogType";
			this.InventoryLogType.Size = new System.Drawing.Size(204, 31);
			this.InventoryLogType.TabIndex = 10;
			// 
			// InvetorySummedOrNot
			// 
			this.InvetorySummedOrNot.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.InvetorySummedOrNot.FormattingEnabled = true;
			this.InvetorySummedOrNot.Location = new System.Drawing.Point(43, 52);
			this.InvetorySummedOrNot.Name = "InvetorySummedOrNot";
			this.InvetorySummedOrNot.Size = new System.Drawing.Size(265, 31);
			this.InvetorySummedOrNot.TabIndex = 9;
			this.InvetorySummedOrNot.SelectedIndexChanged += new System.EventHandler(this.InvetorySummedOrNot_SelectedIndexChanged);
			// 
			// InventoryLogGridView
			// 
			this.InventoryLogGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.InventoryLogGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.InventoryLogGridView.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
			this.InventoryLogGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.InventoryLogGridView.Location = new System.Drawing.Point(8, 190);
			this.InventoryLogGridView.Name = "InventoryLogGridView";
			this.InventoryLogGridView.ReadOnly = true;
			this.InventoryLogGridView.RowHeadersWidth = 51;
			this.InventoryLogGridView.RowTemplate.Height = 24;
			this.InventoryLogGridView.Size = new System.Drawing.Size(1708, 669);
			this.InventoryLogGridView.TabIndex = 8;
			// 
			// InventoryLogRmvFilterBtn
			// 
			this.InventoryLogRmvFilterBtn.Location = new System.Drawing.Point(767, 115);
			this.InventoryLogRmvFilterBtn.Name = "InventoryLogRmvFilterBtn";
			this.InventoryLogRmvFilterBtn.Size = new System.Drawing.Size(324, 52);
			this.InventoryLogRmvFilterBtn.TabIndex = 7;
			this.InventoryLogRmvFilterBtn.Text = "Remove Filter";
			this.InventoryLogRmvFilterBtn.UseVisualStyleBackColor = true;
			this.InventoryLogRmvFilterBtn.Click += new System.EventHandler(this.InventoryLogRmvFilterBtn_Click);
			// 
			// InventoryLogFilterBtn
			// 
			this.InventoryLogFilterBtn.Location = new System.Drawing.Point(416, 115);
			this.InventoryLogFilterBtn.Name = "InventoryLogFilterBtn";
			this.InventoryLogFilterBtn.Size = new System.Drawing.Size(325, 52);
			this.InventoryLogFilterBtn.TabIndex = 6;
			this.InventoryLogFilterBtn.Text = "Filter";
			this.InventoryLogFilterBtn.UseVisualStyleBackColor = true;
			this.InventoryLogFilterBtn.Click += new System.EventHandler(this.InventoryLogFilterBtn_Click);
			// 
			// label60
			// 
			this.label60.AutoSize = true;
			this.label60.Location = new System.Drawing.Point(763, 26);
			this.label60.Name = "label60";
			this.label60.Size = new System.Drawing.Size(120, 23);
			this.label60.TabIndex = 5;
			this.label60.Text = "Start Date";
			// 
			// label59
			// 
			this.label59.AutoSize = true;
			this.label59.Location = new System.Drawing.Point(1112, 26);
			this.label59.Name = "label59";
			this.label59.Size = new System.Drawing.Size(98, 23);
			this.label59.TabIndex = 4;
			this.label59.Text = "End Date";
			// 
			// label58
			// 
			this.label58.AutoSize = true;
			this.label58.Location = new System.Drawing.Point(412, 26);
			this.label58.Name = "label58";
			this.label58.Size = new System.Drawing.Size(65, 23);
			this.label58.TabIndex = 3;
			this.label58.Text = "Month";
			// 
			// InventoryLogEndDate
			// 
			this.InventoryLogEndDate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.InventoryLogEndDate.FormattingEnabled = true;
			this.InventoryLogEndDate.Location = new System.Drawing.Point(1116, 52);
			this.InventoryLogEndDate.Name = "InventoryLogEndDate";
			this.InventoryLogEndDate.Size = new System.Drawing.Size(325, 31);
			this.InventoryLogEndDate.TabIndex = 2;
			// 
			// InventoryLogStartDate
			// 
			this.InventoryLogStartDate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.InventoryLogStartDate.FormattingEnabled = true;
			this.InventoryLogStartDate.Location = new System.Drawing.Point(767, 52);
			this.InventoryLogStartDate.Name = "InventoryLogStartDate";
			this.InventoryLogStartDate.Size = new System.Drawing.Size(324, 31);
			this.InventoryLogStartDate.TabIndex = 1;
			// 
			// InventoryLogMonth
			// 
			this.InventoryLogMonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.InventoryLogMonth.FormattingEnabled = true;
			this.InventoryLogMonth.Location = new System.Drawing.Point(416, 52);
			this.InventoryLogMonth.Name = "InventoryLogMonth";
			this.InventoryLogMonth.Size = new System.Drawing.Size(325, 31);
			this.InventoryLogMonth.TabIndex = 0;
			this.InventoryLogMonth.SelectedIndexChanged += new System.EventHandler(this.InventoryLogMonth_SelectedIndexChanged);
			// 
			// Expenses
			// 
			this.Expenses.Controls.Add(this.ExpenseAmount);
			this.Expenses.Controls.Add(this.ExpenseDescriptionBox);
			this.Expenses.Controls.Add(this.ExpenseDate);
			this.Expenses.Controls.Add(this.ExpensesLogRemoveFiltersBtn);
			this.Expenses.Controls.Add(this.ExpensesLogFilterBtn);
			this.Expenses.Controls.Add(this.label28);
			this.Expenses.Controls.Add(this.ExpensesLogMonth);
			this.Expenses.Controls.Add(this.label29);
			this.Expenses.Controls.Add(this.label30);
			this.Expenses.Controls.Add(this.ExpensesLogEndDate);
			this.Expenses.Controls.Add(this.ExpensesLogStartDate);
			this.Expenses.Controls.Add(this.ExpensesLogGridView);
			this.Expenses.Controls.Add(this.ClearExpenseFieldsBtn);
			this.Expenses.Controls.Add(this.AddExpenseBtn);
			this.Expenses.Controls.Add(this.label31);
			this.Expenses.Controls.Add(this.label33);
			this.Expenses.Controls.Add(this.label34);
			this.Expenses.Location = new System.Drawing.Point(4, 32);
			this.Expenses.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
			this.Expenses.Name = "Expenses";
			this.Expenses.Size = new System.Drawing.Size(1724, 867);
			this.Expenses.TabIndex = 5;
			this.Expenses.Text = "Expenses";
			this.Expenses.UseVisualStyleBackColor = true;
			// 
			// ExpenseAmount
			// 
			this.ExpenseAmount.DecimalPlaces = 2;
			this.ExpenseAmount.Location = new System.Drawing.Point(176, 213);
			this.ExpenseAmount.Margin = new System.Windows.Forms.Padding(4);
			this.ExpenseAmount.Maximum = new decimal(new int[] {
            200000,
            0,
            0,
            0});
			this.ExpenseAmount.Name = "ExpenseAmount";
			this.ExpenseAmount.Size = new System.Drawing.Size(223, 31);
			this.ExpenseAmount.TabIndex = 51;
			// 
			// ExpenseDescriptionBox
			// 
			this.ExpenseDescriptionBox.Location = new System.Drawing.Point(176, 120);
			this.ExpenseDescriptionBox.Name = "ExpenseDescriptionBox";
			this.ExpenseDescriptionBox.Size = new System.Drawing.Size(422, 31);
			this.ExpenseDescriptionBox.TabIndex = 50;
			// 
			// ExpenseDate
			// 
			this.ExpenseDate.CalendarFont = new System.Drawing.Font("Consolas", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ExpenseDate.Location = new System.Drawing.Point(176, 23);
			this.ExpenseDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.ExpenseDate.MaxDate = new System.DateTime(2028, 7, 1, 0, 0, 0, 0);
			this.ExpenseDate.MinDate = new System.DateTime(2019, 1, 1, 0, 0, 0, 0);
			this.ExpenseDate.Name = "ExpenseDate";
			this.ExpenseDate.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.ExpenseDate.Size = new System.Drawing.Size(422, 31);
			this.ExpenseDate.TabIndex = 32;
			this.ExpenseDate.TabStop = false;
			this.ExpenseDate.Value = new System.DateTime(2021, 1, 22, 0, 0, 0, 0);
			// 
			// ExpensesLogRemoveFiltersBtn
			// 
			this.ExpensesLogRemoveFiltersBtn.Location = new System.Drawing.Point(1035, 101);
			this.ExpensesLogRemoveFiltersBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.ExpensesLogRemoveFiltersBtn.Name = "ExpensesLogRemoveFiltersBtn";
			this.ExpensesLogRemoveFiltersBtn.Size = new System.Drawing.Size(203, 46);
			this.ExpensesLogRemoveFiltersBtn.TabIndex = 49;
			this.ExpensesLogRemoveFiltersBtn.Text = "Remove Filters";
			this.ExpensesLogRemoveFiltersBtn.UseVisualStyleBackColor = true;
			this.ExpensesLogRemoveFiltersBtn.Click += new System.EventHandler(this.ExpensesLogRemoveFiltersBtn_Click);
			// 
			// ExpensesLogFilterBtn
			// 
			this.ExpensesLogFilterBtn.Location = new System.Drawing.Point(753, 98);
			this.ExpensesLogFilterBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.ExpensesLogFilterBtn.Name = "ExpensesLogFilterBtn";
			this.ExpensesLogFilterBtn.Size = new System.Drawing.Size(216, 46);
			this.ExpensesLogFilterBtn.TabIndex = 48;
			this.ExpensesLogFilterBtn.Text = "Filter";
			this.ExpensesLogFilterBtn.UseVisualStyleBackColor = true;
			this.ExpensesLogFilterBtn.Click += new System.EventHandler(this.ExpensesLogFilterBtn_Click);
			// 
			// label28
			// 
			this.label28.AutoSize = true;
			this.label28.Location = new System.Drawing.Point(750, 23);
			this.label28.Name = "label28";
			this.label28.Size = new System.Drawing.Size(65, 23);
			this.label28.TabIndex = 47;
			this.label28.Text = "Month";
			// 
			// ExpensesLogMonth
			// 
			this.ExpensesLogMonth.DropDownHeight = 300;
			this.ExpensesLogMonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.ExpensesLogMonth.FormattingEnabled = true;
			this.ExpensesLogMonth.IntegralHeight = false;
			this.ExpensesLogMonth.ItemHeight = 23;
			this.ExpensesLogMonth.Location = new System.Drawing.Point(753, 50);
			this.ExpensesLogMonth.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.ExpensesLogMonth.Name = "ExpensesLogMonth";
			this.ExpensesLogMonth.Size = new System.Drawing.Size(290, 31);
			this.ExpensesLogMonth.TabIndex = 46;
			this.ExpensesLogMonth.SelectedIndexChanged += new System.EventHandler(this.ExpensesLogMonth_SelectedIndexChanged);
			// 
			// label29
			// 
			this.label29.AutoSize = true;
			this.label29.Location = new System.Drawing.Point(1383, 24);
			this.label29.Name = "label29";
			this.label29.Size = new System.Drawing.Size(98, 23);
			this.label29.TabIndex = 45;
			this.label29.Text = "End Date";
			// 
			// label30
			// 
			this.label30.AutoSize = true;
			this.label30.Location = new System.Drawing.Point(1073, 23);
			this.label30.Name = "label30";
			this.label30.Size = new System.Drawing.Size(120, 23);
			this.label30.TabIndex = 44;
			this.label30.Text = "Start Date";
			// 
			// ExpensesLogEndDate
			// 
			this.ExpensesLogEndDate.DropDownHeight = 300;
			this.ExpensesLogEndDate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.ExpensesLogEndDate.FormattingEnabled = true;
			this.ExpensesLogEndDate.IntegralHeight = false;
			this.ExpensesLogEndDate.ItemHeight = 23;
			this.ExpensesLogEndDate.Location = new System.Drawing.Point(1387, 50);
			this.ExpensesLogEndDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.ExpensesLogEndDate.Name = "ExpensesLogEndDate";
			this.ExpensesLogEndDate.Size = new System.Drawing.Size(267, 31);
			this.ExpensesLogEndDate.TabIndex = 43;
			// 
			// ExpensesLogStartDate
			// 
			this.ExpensesLogStartDate.DropDownHeight = 300;
			this.ExpensesLogStartDate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.ExpensesLogStartDate.FormattingEnabled = true;
			this.ExpensesLogStartDate.IntegralHeight = false;
			this.ExpensesLogStartDate.ItemHeight = 23;
			this.ExpensesLogStartDate.Location = new System.Drawing.Point(1076, 50);
			this.ExpensesLogStartDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.ExpensesLogStartDate.Name = "ExpensesLogStartDate";
			this.ExpensesLogStartDate.Size = new System.Drawing.Size(279, 31);
			this.ExpensesLogStartDate.TabIndex = 42;
			// 
			// ExpensesLogGridView
			// 
			this.ExpensesLogGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.ExpensesLogGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.ExpensesLogGridView.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
			this.ExpensesLogGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.ExpensesLogGridView.Location = new System.Drawing.Point(753, 203);
			this.ExpensesLogGridView.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
			this.ExpensesLogGridView.Name = "ExpensesLogGridView";
			this.ExpensesLogGridView.ReadOnly = true;
			this.ExpensesLogGridView.RowHeadersWidth = 51;
			this.ExpensesLogGridView.RowTemplate.Height = 24;
			this.ExpensesLogGridView.Size = new System.Drawing.Size(962, 657);
			this.ExpensesLogGridView.TabIndex = 41;
			// 
			// ClearExpenseFieldsBtn
			// 
			this.ClearExpenseFieldsBtn.Location = new System.Drawing.Point(358, 366);
			this.ClearExpenseFieldsBtn.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
			this.ClearExpenseFieldsBtn.Name = "ClearExpenseFieldsBtn";
			this.ClearExpenseFieldsBtn.Size = new System.Drawing.Size(175, 58);
			this.ClearExpenseFieldsBtn.TabIndex = 40;
			this.ClearExpenseFieldsBtn.Text = "Clear";
			this.ClearExpenseFieldsBtn.UseVisualStyleBackColor = true;
			this.ClearExpenseFieldsBtn.Click += new System.EventHandler(this.ClearExpenseFieldsBtn_Click);
			// 
			// AddExpenseBtn
			// 
			this.AddExpenseBtn.Location = new System.Drawing.Point(19, 366);
			this.AddExpenseBtn.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
			this.AddExpenseBtn.Name = "AddExpenseBtn";
			this.AddExpenseBtn.Size = new System.Drawing.Size(267, 58);
			this.AddExpenseBtn.TabIndex = 39;
			this.AddExpenseBtn.Text = "Add Expense";
			this.AddExpenseBtn.UseVisualStyleBackColor = true;
			this.AddExpenseBtn.Click += new System.EventHandler(this.AddExpenseBtn_Click);
			// 
			// label31
			// 
			this.label31.AutoSize = true;
			this.label31.Location = new System.Drawing.Point(16, 215);
			this.label31.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label31.Name = "label31";
			this.label31.Size = new System.Drawing.Size(76, 23);
			this.label31.TabIndex = 38;
			this.label31.Text = "Amount";
			// 
			// label33
			// 
			this.label33.AutoSize = true;
			this.label33.Location = new System.Drawing.Point(15, 123);
			this.label33.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label33.Name = "label33";
			this.label33.Size = new System.Drawing.Size(131, 23);
			this.label33.TabIndex = 34;
			this.label33.Text = "Description";
			// 
			// label34
			// 
			this.label34.AutoSize = true;
			this.label34.Location = new System.Drawing.Point(15, 38);
			this.label34.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label34.Name = "label34";
			this.label34.Size = new System.Drawing.Size(54, 23);
			this.label34.TabIndex = 33;
			this.label34.Text = "Date";
			// 
			// WagesNewEmployee
			// 
			this.WagesNewEmployee.Controls.Add(this.NewEmployee);
			this.WagesNewEmployee.Controls.Add(this.PartTimeEmployeeCheckBox);
			this.WagesNewEmployee.Controls.Add(this.WagesEmployeeName);
			this.WagesNewEmployee.Controls.Add(this.WageAmount);
			this.WagesNewEmployee.Controls.Add(this.WageDate);
			this.WagesNewEmployee.Controls.Add(this.WageLogRemoveFiltersBtn);
			this.WagesNewEmployee.Controls.Add(this.WageLogFilterBtn);
			this.WagesNewEmployee.Controls.Add(this.label32);
			this.WagesNewEmployee.Controls.Add(this.WageLogMonth);
			this.WagesNewEmployee.Controls.Add(this.label35);
			this.WagesNewEmployee.Controls.Add(this.label36);
			this.WagesNewEmployee.Controls.Add(this.WageLogEndDate);
			this.WagesNewEmployee.Controls.Add(this.WageLogStartDate);
			this.WagesNewEmployee.Controls.Add(this.WageLogGridView);
			this.WagesNewEmployee.Controls.Add(this.ClearWageFieldsBtn);
			this.WagesNewEmployee.Controls.Add(this.AddWageBtn);
			this.WagesNewEmployee.Controls.Add(this.label37);
			this.WagesNewEmployee.Controls.Add(this.label38);
			this.WagesNewEmployee.Controls.Add(this.label39);
			this.WagesNewEmployee.Location = new System.Drawing.Point(4, 32);
			this.WagesNewEmployee.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
			this.WagesNewEmployee.Name = "WagesNewEmployee";
			this.WagesNewEmployee.Size = new System.Drawing.Size(1724, 867);
			this.WagesNewEmployee.TabIndex = 4;
			this.WagesNewEmployee.Text = "Wages";
			this.WagesNewEmployee.UseVisualStyleBackColor = true;
			// 
			// NewEmployee
			// 
			this.NewEmployee.Location = new System.Drawing.Point(229, 106);
			this.NewEmployee.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
			this.NewEmployee.Name = "NewEmployee";
			this.NewEmployee.Size = new System.Drawing.Size(251, 38);
			this.NewEmployee.TabIndex = 71;
			this.NewEmployee.Text = "New Employee";
			this.NewEmployee.UseVisualStyleBackColor = true;
			this.NewEmployee.Click += new System.EventHandler(this.NewEmployee_Click);
			// 
			// PartTimeEmployeeCheckBox
			// 
			this.PartTimeEmployeeCheckBox.AutoSize = true;
			this.PartTimeEmployeeCheckBox.Location = new System.Drawing.Point(229, 180);
			this.PartTimeEmployeeCheckBox.Margin = new System.Windows.Forms.Padding(4);
			this.PartTimeEmployeeCheckBox.Name = "PartTimeEmployeeCheckBox";
			this.PartTimeEmployeeCheckBox.Size = new System.Drawing.Size(230, 27);
			this.PartTimeEmployeeCheckBox.TabIndex = 70;
			this.PartTimeEmployeeCheckBox.Text = "Part Time Employee";
			this.PartTimeEmployeeCheckBox.UseVisualStyleBackColor = true;
			this.PartTimeEmployeeCheckBox.CheckedChanged += new System.EventHandler(this.PartTimeEmployeeCheckBox_CheckedChanged);
			// 
			// WagesEmployeeName
			// 
			this.WagesEmployeeName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.WagesEmployeeName.FormattingEnabled = true;
			this.WagesEmployeeName.Location = new System.Drawing.Point(229, 229);
			this.WagesEmployeeName.Margin = new System.Windows.Forms.Padding(4);
			this.WagesEmployeeName.Name = "WagesEmployeeName";
			this.WagesEmployeeName.Size = new System.Drawing.Size(409, 31);
			this.WagesEmployeeName.TabIndex = 69;
			// 
			// WageAmount
			// 
			this.WageAmount.DecimalPlaces = 2;
			this.WageAmount.Location = new System.Drawing.Point(229, 305);
			this.WageAmount.Margin = new System.Windows.Forms.Padding(4);
			this.WageAmount.Maximum = new decimal(new int[] {
            200000,
            0,
            0,
            0});
			this.WageAmount.Name = "WageAmount";
			this.WageAmount.Size = new System.Drawing.Size(172, 31);
			this.WageAmount.TabIndex = 68;
			// 
			// WageDate
			// 
			this.WageDate.CalendarFont = new System.Drawing.Font("Consolas", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.WageDate.Location = new System.Drawing.Point(229, 24);
			this.WageDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.WageDate.MaxDate = new System.DateTime(2028, 7, 1, 0, 0, 0, 0);
			this.WageDate.MinDate = new System.DateTime(2019, 1, 1, 0, 0, 0, 0);
			this.WageDate.Name = "WageDate";
			this.WageDate.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.WageDate.Size = new System.Drawing.Size(409, 31);
			this.WageDate.TabIndex = 52;
			this.WageDate.TabStop = false;
			this.WageDate.Value = new System.DateTime(2021, 1, 22, 0, 0, 0, 0);
			// 
			// WageLogRemoveFiltersBtn
			// 
			this.WageLogRemoveFiltersBtn.Location = new System.Drawing.Point(1137, 98);
			this.WageLogRemoveFiltersBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.WageLogRemoveFiltersBtn.Name = "WageLogRemoveFiltersBtn";
			this.WageLogRemoveFiltersBtn.Size = new System.Drawing.Size(251, 46);
			this.WageLogRemoveFiltersBtn.TabIndex = 66;
			this.WageLogRemoveFiltersBtn.Text = "Remove Filters";
			this.WageLogRemoveFiltersBtn.UseVisualStyleBackColor = true;
			this.WageLogRemoveFiltersBtn.Click += new System.EventHandler(this.WageLogRemoveFiltersBtn_Click);
			// 
			// WageLogFilterBtn
			// 
			this.WageLogFilterBtn.Location = new System.Drawing.Point(812, 98);
			this.WageLogFilterBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.WageLogFilterBtn.Name = "WageLogFilterBtn";
			this.WageLogFilterBtn.Size = new System.Drawing.Size(266, 46);
			this.WageLogFilterBtn.TabIndex = 65;
			this.WageLogFilterBtn.Text = "Filter";
			this.WageLogFilterBtn.UseVisualStyleBackColor = true;
			this.WageLogFilterBtn.Click += new System.EventHandler(this.WageLogFilterBtn_Click);
			// 
			// label32
			// 
			this.label32.AutoSize = true;
			this.label32.Location = new System.Drawing.Point(808, 20);
			this.label32.Name = "label32";
			this.label32.Size = new System.Drawing.Size(65, 23);
			this.label32.TabIndex = 64;
			this.label32.Text = "Month";
			// 
			// WageLogMonth
			// 
			this.WageLogMonth.DropDownHeight = 300;
			this.WageLogMonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.WageLogMonth.FormattingEnabled = true;
			this.WageLogMonth.IntegralHeight = false;
			this.WageLogMonth.ItemHeight = 23;
			this.WageLogMonth.Location = new System.Drawing.Point(812, 47);
			this.WageLogMonth.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.WageLogMonth.Name = "WageLogMonth";
			this.WageLogMonth.Size = new System.Drawing.Size(266, 31);
			this.WageLogMonth.TabIndex = 63;
			this.WageLogMonth.SelectedIndexChanged += new System.EventHandler(this.WageLogMonth_SelectedIndexChanged);
			// 
			// label35
			// 
			this.label35.AutoSize = true;
			this.label35.Location = new System.Drawing.Point(1452, 20);
			this.label35.Name = "label35";
			this.label35.Size = new System.Drawing.Size(98, 23);
			this.label35.TabIndex = 62;
			this.label35.Text = "End Date";
			// 
			// label36
			// 
			this.label36.AutoSize = true;
			this.label36.Location = new System.Drawing.Point(1133, 20);
			this.label36.Name = "label36";
			this.label36.Size = new System.Drawing.Size(120, 23);
			this.label36.TabIndex = 61;
			this.label36.Text = "Start Date";
			// 
			// WageLogEndDate
			// 
			this.WageLogEndDate.DropDownHeight = 300;
			this.WageLogEndDate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.WageLogEndDate.FormattingEnabled = true;
			this.WageLogEndDate.IntegralHeight = false;
			this.WageLogEndDate.ItemHeight = 23;
			this.WageLogEndDate.Location = new System.Drawing.Point(1456, 47);
			this.WageLogEndDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.WageLogEndDate.Name = "WageLogEndDate";
			this.WageLogEndDate.Size = new System.Drawing.Size(236, 31);
			this.WageLogEndDate.TabIndex = 60;
			// 
			// WageLogStartDate
			// 
			this.WageLogStartDate.DropDownHeight = 300;
			this.WageLogStartDate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.WageLogStartDate.FormattingEnabled = true;
			this.WageLogStartDate.IntegralHeight = false;
			this.WageLogStartDate.ItemHeight = 23;
			this.WageLogStartDate.Location = new System.Drawing.Point(1137, 47);
			this.WageLogStartDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.WageLogStartDate.Name = "WageLogStartDate";
			this.WageLogStartDate.Size = new System.Drawing.Size(251, 31);
			this.WageLogStartDate.TabIndex = 59;
			// 
			// WageLogGridView
			// 
			this.WageLogGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.WageLogGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.WageLogGridView.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
			this.WageLogGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.WageLogGridView.Location = new System.Drawing.Point(812, 158);
			this.WageLogGridView.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
			this.WageLogGridView.Name = "WageLogGridView";
			this.WageLogGridView.ReadOnly = true;
			this.WageLogGridView.RowHeadersWidth = 51;
			this.WageLogGridView.RowTemplate.Height = 24;
			this.WageLogGridView.Size = new System.Drawing.Size(903, 702);
			this.WageLogGridView.TabIndex = 58;
			// 
			// ClearWageFieldsBtn
			// 
			this.ClearWageFieldsBtn.Location = new System.Drawing.Point(284, 470);
			this.ClearWageFieldsBtn.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
			this.ClearWageFieldsBtn.Name = "ClearWageFieldsBtn";
			this.ClearWageFieldsBtn.Size = new System.Drawing.Size(181, 58);
			this.ClearWageFieldsBtn.TabIndex = 57;
			this.ClearWageFieldsBtn.Text = "Clear";
			this.ClearWageFieldsBtn.UseVisualStyleBackColor = true;
			this.ClearWageFieldsBtn.Click += new System.EventHandler(this.ClearWageFieldsBtn_Click);
			// 
			// AddWageBtn
			// 
			this.AddWageBtn.Location = new System.Drawing.Point(15, 470);
			this.AddWageBtn.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
			this.AddWageBtn.Name = "AddWageBtn";
			this.AddWageBtn.Size = new System.Drawing.Size(208, 58);
			this.AddWageBtn.TabIndex = 56;
			this.AddWageBtn.Text = "Add Wage";
			this.AddWageBtn.UseVisualStyleBackColor = true;
			this.AddWageBtn.Click += new System.EventHandler(this.AddWageBtn_Click);
			// 
			// label37
			// 
			this.label37.AutoSize = true;
			this.label37.Location = new System.Drawing.Point(11, 313);
			this.label37.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label37.Name = "label37";
			this.label37.Size = new System.Drawing.Size(76, 23);
			this.label37.TabIndex = 55;
			this.label37.Text = "Amount";
			// 
			// label38
			// 
			this.label38.AutoSize = true;
			this.label38.Location = new System.Drawing.Point(11, 237);
			this.label38.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label38.Name = "label38";
			this.label38.Size = new System.Drawing.Size(98, 23);
			this.label38.TabIndex = 54;
			this.label38.Text = "Employee";
			// 
			// label39
			// 
			this.label39.AutoSize = true;
			this.label39.Location = new System.Drawing.Point(9, 30);
			this.label39.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label39.Name = "label39";
			this.label39.Size = new System.Drawing.Size(54, 23);
			this.label39.TabIndex = 53;
			this.label39.Text = "Date";
			// 
			// Summaries
			// 
			this.Summaries.Controls.Add(this.label61);
			this.Summaries.Controls.Add(this.SummariesTotalFloat);
			this.Summaries.Controls.Add(this.label57);
			this.Summaries.Controls.Add(this.SummariesTotalSales);
			this.Summaries.Controls.Add(this.label56);
			this.Summaries.Controls.Add(this.SummariesTotalPurchases);
			this.Summaries.Controls.Add(this.label54);
			this.Summaries.Controls.Add(this.SummariesProfitBox);
			this.Summaries.Controls.Add(this.label53);
			this.Summaries.Controls.Add(this.SummariesMonthSelector);
			this.Summaries.Controls.Add(this.SummariesExpensesBox);
			this.Summaries.Controls.Add(this.SummariesNFSalesBox);
			this.Summaries.Controls.Add(this.SummariesFSalesBox);
			this.Summaries.Controls.Add(this.SummariesWagesBox);
			this.Summaries.Controls.Add(this.SummariesNFPurchasesBox);
			this.Summaries.Controls.Add(this.SummariesFPurchasesBox);
			this.Summaries.Controls.Add(this.label52);
			this.Summaries.Controls.Add(this.label51);
			this.Summaries.Controls.Add(this.label50);
			this.Summaries.Controls.Add(this.label49);
			this.Summaries.Controls.Add(this.label48);
			this.Summaries.Controls.Add(this.label47);
			this.Summaries.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Summaries.Location = new System.Drawing.Point(4, 32);
			this.Summaries.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
			this.Summaries.Name = "Summaries";
			this.Summaries.Size = new System.Drawing.Size(1724, 867);
			this.Summaries.TabIndex = 6;
			this.Summaries.Text = "Summaries";
			this.Summaries.UseVisualStyleBackColor = true;
			// 
			// label61
			// 
			this.label61.AutoSize = true;
			this.label61.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label61.Location = new System.Drawing.Point(1349, 129);
			this.label61.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label61.Name = "label61";
			this.label61.Size = new System.Drawing.Size(155, 28);
			this.label61.TabIndex = 21;
			this.label61.Text = "Total Float";
			// 
			// SummariesTotalFloat
			// 
			this.SummariesTotalFloat.Font = new System.Drawing.Font("Consolas", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.SummariesTotalFloat.Location = new System.Drawing.Point(1351, 160);
			this.SummariesTotalFloat.Margin = new System.Windows.Forms.Padding(2);
			this.SummariesTotalFloat.Name = "SummariesTotalFloat";
			this.SummariesTotalFloat.ReadOnly = true;
			this.SummariesTotalFloat.Size = new System.Drawing.Size(378, 170);
			this.SummariesTotalFloat.TabIndex = 20;
			this.SummariesTotalFloat.Text = " ";
			// 
			// label57
			// 
			this.label57.AutoSize = true;
			this.label57.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label57.Location = new System.Drawing.Point(938, 379);
			this.label57.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label57.Name = "label57";
			this.label57.Size = new System.Drawing.Size(155, 28);
			this.label57.TabIndex = 19;
			this.label57.Text = "Total Sales";
			// 
			// SummariesTotalSales
			// 
			this.SummariesTotalSales.Font = new System.Drawing.Font("Consolas", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.SummariesTotalSales.Location = new System.Drawing.Point(943, 410);
			this.SummariesTotalSales.Margin = new System.Windows.Forms.Padding(2);
			this.SummariesTotalSales.Name = "SummariesTotalSales";
			this.SummariesTotalSales.ReadOnly = true;
			this.SummariesTotalSales.Size = new System.Drawing.Size(375, 170);
			this.SummariesTotalSales.TabIndex = 18;
			this.SummariesTotalSales.Text = "";
			// 
			// label56
			// 
			this.label56.AutoSize = true;
			this.label56.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label56.Location = new System.Drawing.Point(941, 129);
			this.label56.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label56.Name = "label56";
			this.label56.Size = new System.Drawing.Size(207, 28);
			this.label56.TabIndex = 17;
			this.label56.Text = "Total Purchases";
			// 
			// SummariesTotalPurchases
			// 
			this.SummariesTotalPurchases.Font = new System.Drawing.Font("Consolas", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.SummariesTotalPurchases.Location = new System.Drawing.Point(943, 160);
			this.SummariesTotalPurchases.Margin = new System.Windows.Forms.Padding(2);
			this.SummariesTotalPurchases.Name = "SummariesTotalPurchases";
			this.SummariesTotalPurchases.ReadOnly = true;
			this.SummariesTotalPurchases.Size = new System.Drawing.Size(378, 170);
			this.SummariesTotalPurchases.TabIndex = 16;
			this.SummariesTotalPurchases.Text = " ";
			// 
			// label54
			// 
			this.label54.AutoSize = true;
			this.label54.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label54.Location = new System.Drawing.Point(938, 633);
			this.label54.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label54.Name = "label54";
			this.label54.Size = new System.Drawing.Size(90, 28);
			this.label54.TabIndex = 15;
			this.label54.Text = "Profit";
			// 
			// SummariesProfitBox
			// 
			this.SummariesProfitBox.Font = new System.Drawing.Font("Consolas", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.SummariesProfitBox.Location = new System.Drawing.Point(943, 664);
			this.SummariesProfitBox.Margin = new System.Windows.Forms.Padding(2);
			this.SummariesProfitBox.Name = "SummariesProfitBox";
			this.SummariesProfitBox.ReadOnly = true;
			this.SummariesProfitBox.Size = new System.Drawing.Size(375, 170);
			this.SummariesProfitBox.TabIndex = 14;
			this.SummariesProfitBox.Text = "";
			// 
			// label53
			// 
			this.label53.AutoSize = true;
			this.label53.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label53.Location = new System.Drawing.Point(66, 39);
			this.label53.Name = "label53";
			this.label53.Size = new System.Drawing.Size(168, 28);
			this.label53.TabIndex = 13;
			this.label53.Text = "Select Month";
			// 
			// SummariesMonthSelector
			// 
			this.SummariesMonthSelector.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.SummariesMonthSelector.FormattingEnabled = true;
			this.SummariesMonthSelector.Location = new System.Drawing.Point(70, 75);
			this.SummariesMonthSelector.Name = "SummariesMonthSelector";
			this.SummariesMonthSelector.Size = new System.Drawing.Size(346, 35);
			this.SummariesMonthSelector.TabIndex = 12;
			this.SummariesMonthSelector.SelectedIndexChanged += new System.EventHandler(this.SummariesMonthSelector_SelectedIndexChanged);
			// 
			// SummariesExpensesBox
			// 
			this.SummariesExpensesBox.Font = new System.Drawing.Font("Consolas", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.SummariesExpensesBox.Location = new System.Drawing.Point(511, 658);
			this.SummariesExpensesBox.Name = "SummariesExpensesBox";
			this.SummariesExpensesBox.ReadOnly = true;
			this.SummariesExpensesBox.Size = new System.Drawing.Size(394, 177);
			this.SummariesExpensesBox.TabIndex = 11;
			this.SummariesExpensesBox.Text = "";
			// 
			// SummariesNFSalesBox
			// 
			this.SummariesNFSalesBox.Font = new System.Drawing.Font("Consolas", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.SummariesNFSalesBox.Location = new System.Drawing.Point(510, 410);
			this.SummariesNFSalesBox.Name = "SummariesNFSalesBox";
			this.SummariesNFSalesBox.ReadOnly = true;
			this.SummariesNFSalesBox.Size = new System.Drawing.Size(394, 164);
			this.SummariesNFSalesBox.TabIndex = 10;
			this.SummariesNFSalesBox.Text = "";
			// 
			// SummariesFSalesBox
			// 
			this.SummariesFSalesBox.Font = new System.Drawing.Font("Consolas", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.SummariesFSalesBox.Location = new System.Drawing.Point(71, 410);
			this.SummariesFSalesBox.Name = "SummariesFSalesBox";
			this.SummariesFSalesBox.ReadOnly = true;
			this.SummariesFSalesBox.Size = new System.Drawing.Size(400, 164);
			this.SummariesFSalesBox.TabIndex = 9;
			this.SummariesFSalesBox.Text = "";
			// 
			// SummariesWagesBox
			// 
			this.SummariesWagesBox.Font = new System.Drawing.Font("Consolas", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.SummariesWagesBox.Location = new System.Drawing.Point(71, 658);
			this.SummariesWagesBox.Name = "SummariesWagesBox";
			this.SummariesWagesBox.ReadOnly = true;
			this.SummariesWagesBox.Size = new System.Drawing.Size(400, 177);
			this.SummariesWagesBox.TabIndex = 8;
			this.SummariesWagesBox.Text = "";
			// 
			// SummariesNFPurchasesBox
			// 
			this.SummariesNFPurchasesBox.Font = new System.Drawing.Font("Consolas", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.SummariesNFPurchasesBox.Location = new System.Drawing.Point(510, 160);
			this.SummariesNFPurchasesBox.Name = "SummariesNFPurchasesBox";
			this.SummariesNFPurchasesBox.ReadOnly = true;
			this.SummariesNFPurchasesBox.Size = new System.Drawing.Size(394, 170);
			this.SummariesNFPurchasesBox.TabIndex = 7;
			this.SummariesNFPurchasesBox.Text = "";
			// 
			// SummariesFPurchasesBox
			// 
			this.SummariesFPurchasesBox.Font = new System.Drawing.Font("Consolas", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.SummariesFPurchasesBox.Location = new System.Drawing.Point(70, 160);
			this.SummariesFPurchasesBox.Name = "SummariesFPurchasesBox";
			this.SummariesFPurchasesBox.ReadOnly = true;
			this.SummariesFPurchasesBox.Size = new System.Drawing.Size(401, 170);
			this.SummariesFPurchasesBox.TabIndex = 6;
			this.SummariesFPurchasesBox.Text = "";
			// 
			// label52
			// 
			this.label52.AutoSize = true;
			this.label52.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label52.Location = new System.Drawing.Point(506, 627);
			this.label52.Name = "label52";
			this.label52.Size = new System.Drawing.Size(194, 28);
			this.label52.TabIndex = 5;
			this.label52.Text = "Total Expenses";
			// 
			// label51
			// 
			this.label51.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label51.Location = new System.Drawing.Point(66, 627);
			this.label51.Name = "label51";
			this.label51.Size = new System.Drawing.Size(219, 34);
			this.label51.TabIndex = 4;
			this.label51.Text = "Total Wages";
			// 
			// label50
			// 
			this.label50.AutoSize = true;
			this.label50.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label50.Location = new System.Drawing.Point(506, 379);
			this.label50.Name = "label50";
			this.label50.Size = new System.Drawing.Size(233, 28);
			this.label50.TabIndex = 3;
			this.label50.Text = "Non-Ferrous Sales";
			// 
			// label49
			// 
			this.label49.AutoSize = true;
			this.label49.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label49.Location = new System.Drawing.Point(505, 134);
			this.label49.Name = "label49";
			this.label49.Size = new System.Drawing.Size(285, 28);
			this.label49.TabIndex = 2;
			this.label49.Text = "Non-Ferrous Purchases";
			// 
			// label48
			// 
			this.label48.AutoSize = true;
			this.label48.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label48.Location = new System.Drawing.Point(66, 372);
			this.label48.Name = "label48";
			this.label48.Size = new System.Drawing.Size(181, 28);
			this.label48.TabIndex = 1;
			this.label48.Text = "Ferrous Sales";
			// 
			// label47
			// 
			this.label47.AutoSize = true;
			this.label47.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label47.Location = new System.Drawing.Point(66, 134);
			this.label47.Name = "label47";
			this.label47.Size = new System.Drawing.Size(233, 28);
			this.label47.TabIndex = 0;
			this.label47.Text = "Ferrous Purchases";
			// 
			// DestructionCertificates
			// 
			this.DestructionCertificates.Controls.Add(this.SendDstrctCertEmailBtn);
			this.DestructionCertificates.Controls.Add(this.dstrctCertExtractionDate);
			this.DestructionCertificates.Controls.Add(this.dstrctCertNewCompanyCheckBox);
			this.DestructionCertificates.Controls.Add(this.dstrctCertCompanyField);
			this.DestructionCertificates.Controls.Add(this.dstrctCertQuantityNumBox);
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
			this.DestructionCertificates.Size = new System.Drawing.Size(1724, 867);
			this.DestructionCertificates.TabIndex = 3;
			this.DestructionCertificates.Text = "Destruction Certificate";
			this.DestructionCertificates.UseVisualStyleBackColor = true;
			// 
			// SendDstrctCertEmailBtn
			// 
			this.SendDstrctCertEmailBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.SendDstrctCertEmailBtn.Location = new System.Drawing.Point(67, 652);
			this.SendDstrctCertEmailBtn.Margin = new System.Windows.Forms.Padding(2);
			this.SendDstrctCertEmailBtn.Name = "SendDstrctCertEmailBtn";
			this.SendDstrctCertEmailBtn.Size = new System.Drawing.Size(276, 77);
			this.SendDstrctCertEmailBtn.TabIndex = 50;
			this.SendDstrctCertEmailBtn.Text = "Generate and Email Certificate";
			this.SendDstrctCertEmailBtn.UseVisualStyleBackColor = true;
			this.SendDstrctCertEmailBtn.Click += new System.EventHandler(this.SendDstrctCertEmailBtn_Click);
			// 
			// dstrctCertExtractionDate
			// 
			this.dstrctCertExtractionDate.CalendarFont = new System.Drawing.Font("Consolas", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dstrctCertExtractionDate.Location = new System.Drawing.Point(437, 62);
			this.dstrctCertExtractionDate.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
			this.dstrctCertExtractionDate.MaxDate = new System.DateTime(2028, 7, 1, 0, 0, 0, 0);
			this.dstrctCertExtractionDate.MinDate = new System.DateTime(2019, 1, 1, 0, 0, 0, 0);
			this.dstrctCertExtractionDate.Name = "dstrctCertExtractionDate";
			this.dstrctCertExtractionDate.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.dstrctCertExtractionDate.Size = new System.Drawing.Size(407, 31);
			this.dstrctCertExtractionDate.TabIndex = 49;
			this.dstrctCertExtractionDate.TabStop = false;
			this.dstrctCertExtractionDate.Value = new System.DateTime(2021, 1, 22, 0, 0, 0, 0);
			// 
			// dstrctCertNewCompanyCheckBox
			// 
			this.dstrctCertNewCompanyCheckBox.AutoSize = true;
			this.dstrctCertNewCompanyCheckBox.Location = new System.Drawing.Point(749, 123);
			this.dstrctCertNewCompanyCheckBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.dstrctCertNewCompanyCheckBox.Name = "dstrctCertNewCompanyCheckBox";
			this.dstrctCertNewCompanyCheckBox.Size = new System.Drawing.Size(153, 27);
			this.dstrctCertNewCompanyCheckBox.TabIndex = 41;
			this.dstrctCertNewCompanyCheckBox.Text = "New Company";
			this.dstrctCertNewCompanyCheckBox.UseVisualStyleBackColor = true;
			this.dstrctCertNewCompanyCheckBox.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
			// 
			// dstrctCertCompanyField
			// 
			this.dstrctCertCompanyField.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.dstrctCertCompanyField.FormattingEnabled = true;
			this.dstrctCertCompanyField.Location = new System.Drawing.Point(437, 123);
			this.dstrctCertCompanyField.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.dstrctCertCompanyField.Name = "dstrctCertCompanyField";
			this.dstrctCertCompanyField.Size = new System.Drawing.Size(295, 31);
			this.dstrctCertCompanyField.TabIndex = 42;
			this.dstrctCertCompanyField.SelectedIndexChanged += new System.EventHandler(this.dstrctCertCompanyField_SelectedIndexChanged_1);
			this.dstrctCertCompanyField.Leave += new System.EventHandler(this.dstrctCertCompanyField_Leave);
			// 
			// dstrctCertQuantityNumBox
			// 
			this.dstrctCertQuantityNumBox.DecimalPlaces = 3;
			this.dstrctCertQuantityNumBox.Location = new System.Drawing.Point(439, 441);
			this.dstrctCertQuantityNumBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.dstrctCertQuantityNumBox.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
			this.dstrctCertQuantityNumBox.Name = "dstrctCertQuantityNumBox";
			this.dstrctCertQuantityNumBox.Size = new System.Drawing.Size(147, 31);
			this.dstrctCertQuantityNumBox.TabIndex = 48;
			this.dstrctCertQuantityNumBox.ThousandsSeparator = true;
			// 
			// dstrctCertQuantityUnit
			// 
			this.dstrctCertQuantityUnit.DropDownHeight = 300;
			this.dstrctCertQuantityUnit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.dstrctCertQuantityUnit.FormattingEnabled = true;
			this.dstrctCertQuantityUnit.IntegralHeight = false;
			this.dstrctCertQuantityUnit.ItemHeight = 23;
			this.dstrctCertQuantityUnit.Location = new System.Drawing.Point(592, 440);
			this.dstrctCertQuantityUnit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.dstrctCertQuantityUnit.Name = "dstrctCertQuantityUnit";
			this.dstrctCertQuantityUnit.Size = new System.Drawing.Size(129, 31);
			this.dstrctCertQuantityUnit.TabIndex = 47;
			// 
			// generateDstrCertBtn
			// 
			this.generateDstrCertBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.generateDstrCertBtn.Location = new System.Drawing.Point(67, 554);
			this.generateDstrCertBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.generateDstrCertBtn.Name = "generateDstrCertBtn";
			this.generateDstrCertBtn.Size = new System.Drawing.Size(276, 78);
			this.generateDstrCertBtn.TabIndex = 30;
			this.generateDstrCertBtn.Text = "Generate Certificate";
			this.generateDstrCertBtn.UseVisualStyleBackColor = true;
			this.generateDstrCertBtn.Click += new System.EventHandler(this.generateDstrCertBtn_Click);
			// 
			// dstrctCertEmailAddressField
			// 
			this.dstrctCertEmailAddressField.Location = new System.Drawing.Point(437, 317);
			this.dstrctCertEmailAddressField.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.dstrctCertEmailAddressField.Name = "dstrctCertEmailAddressField";
			this.dstrctCertEmailAddressField.ReadOnly = true;
			this.dstrctCertEmailAddressField.Size = new System.Drawing.Size(513, 31);
			this.dstrctCertEmailAddressField.TabIndex = 45;
			// 
			// dstrctCertDescripOfProdField
			// 
			this.dstrctCertDescripOfProdField.Location = new System.Drawing.Point(437, 379);
			this.dstrctCertDescripOfProdField.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.dstrctCertDescripOfProdField.Name = "dstrctCertDescripOfProdField";
			this.dstrctCertDescripOfProdField.Size = new System.Drawing.Size(513, 31);
			this.dstrctCertDescripOfProdField.TabIndex = 46;
			// 
			// dstrctCertCntactNumField
			// 
			this.dstrctCertCntactNumField.Location = new System.Drawing.Point(437, 250);
			this.dstrctCertCntactNumField.Margin = new System.Windows.Forms.Padding(2);
			this.dstrctCertCntactNumField.Name = "dstrctCertCntactNumField";
			this.dstrctCertCntactNumField.ReadOnly = true;
			this.dstrctCertCntactNumField.Size = new System.Drawing.Size(292, 31);
			this.dstrctCertCntactNumField.TabIndex = 44;
			// 
			// dstrctCertCntactPersonField
			// 
			this.dstrctCertCntactPersonField.Location = new System.Drawing.Point(437, 180);
			this.dstrctCertCntactPersonField.Margin = new System.Windows.Forms.Padding(2);
			this.dstrctCertCntactPersonField.Name = "dstrctCertCntactPersonField";
			this.dstrctCertCntactPersonField.ReadOnly = true;
			this.dstrctCertCntactPersonField.Size = new System.Drawing.Size(292, 31);
			this.dstrctCertCntactPersonField.TabIndex = 43;
			// 
			// label27
			// 
			this.label27.AutoSize = true;
			this.label27.Location = new System.Drawing.Point(67, 62);
			this.label27.Name = "label27";
			this.label27.Size = new System.Drawing.Size(175, 23);
			this.label27.TabIndex = 11;
			this.label27.Text = "Extraction Date";
			// 
			// label26
			// 
			this.label26.AutoSize = true;
			this.label26.Location = new System.Drawing.Point(67, 197);
			this.label26.Name = "label26";
			this.label26.Size = new System.Drawing.Size(164, 23);
			this.label26.TabIndex = 10;
			this.label26.Text = "Contact Person";
			// 
			// label25
			// 
			this.label25.AutoSize = true;
			this.label25.Location = new System.Drawing.Point(67, 258);
			this.label25.Name = "label25";
			this.label25.Size = new System.Drawing.Size(164, 23);
			this.label25.TabIndex = 9;
			this.label25.Text = "Contact Number";
			// 
			// label24
			// 
			this.label24.AutoSize = true;
			this.label24.Location = new System.Drawing.Point(67, 320);
			this.label24.Name = "label24";
			this.label24.Size = new System.Drawing.Size(153, 23);
			this.label24.TabIndex = 8;
			this.label24.Text = "Email Address";
			// 
			// label23
			// 
			this.label23.AutoSize = true;
			this.label23.Location = new System.Drawing.Point(67, 382);
			this.label23.Name = "label23";
			this.label23.Size = new System.Drawing.Size(252, 23);
			this.label23.TabIndex = 7;
			this.label23.Text = "Description of Product";
			// 
			// label22
			// 
			this.label22.AutoSize = true;
			this.label22.Location = new System.Drawing.Point(67, 123);
			this.label22.Name = "label22";
			this.label22.Size = new System.Drawing.Size(87, 23);
			this.label22.TabIndex = 6;
			this.label22.Text = "Company";
			// 
			// label21
			// 
			this.label21.AutoSize = true;
			this.label21.Location = new System.Drawing.Point(67, 443);
			this.label21.Name = "label21";
			this.label21.Size = new System.Drawing.Size(98, 23);
			this.label21.TabIndex = 5;
			this.label21.Text = "Quantity";
			// 
			// tabPage1
			// 
			this.tabPage1.Controls.Add(this.salesPRDataGridView);
			this.tabPage1.Location = new System.Drawing.Point(4, 32);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Size = new System.Drawing.Size(1724, 867);
			this.tabPage1.TabIndex = 8;
			this.tabPage1.Text = "Sales PR";
			this.tabPage1.UseVisualStyleBackColor = true;
			// 
			// salesPRDataGridView
			// 
			this.salesPRDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.salesPRDataGridView.Location = new System.Drawing.Point(3, 171);
			this.salesPRDataGridView.Name = "salesPRDataGridView";
			this.salesPRDataGridView.RowHeadersWidth = 51;
			this.salesPRDataGridView.RowTemplate.Height = 24;
			this.salesPRDataGridView.Size = new System.Drawing.Size(1713, 688);
			this.salesPRDataGridView.TabIndex = 0;
			// 
			// tabPage2
			// 
			this.tabPage2.Controls.Add(this.button2);
			this.tabPage2.Controls.Add(this.button3);
			this.tabPage2.Controls.Add(this.button4);
			this.tabPage2.Controls.Add(this.label66);
			this.tabPage2.Controls.Add(this.comboBox4);
			this.tabPage2.Controls.Add(this.label67);
			this.tabPage2.Controls.Add(this.label68);
			this.tabPage2.Controls.Add(this.label69);
			this.tabPage2.Controls.Add(this.comboBox5);
			this.tabPage2.Controls.Add(this.comboBox6);
			this.tabPage2.Controls.Add(this.comboBox7);
			this.tabPage2.Controls.Add(this.PurchasesPRDataGridView);
			this.tabPage2.Location = new System.Drawing.Point(4, 32);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Size = new System.Drawing.Size(1724, 867);
			this.tabPage2.TabIndex = 9;
			this.tabPage2.Text = "Purchases PR";
			this.tabPage2.UseVisualStyleBackColor = true;
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(736, 110);
			this.button2.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(265, 57);
			this.button2.TabIndex = 30;
			this.button2.Text = "Print Register";
			this.button2.UseVisualStyleBackColor = true;
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(371, 110);
			this.button3.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(297, 57);
			this.button3.TabIndex = 29;
			this.button3.Text = "Remove Filters";
			this.button3.UseVisualStyleBackColor = true;
			// 
			// button4
			// 
			this.button4.Location = new System.Drawing.Point(36, 110);
			this.button4.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(265, 57);
			this.button4.TabIndex = 28;
			this.button4.Text = "Filter";
			this.button4.UseVisualStyleBackColor = true;
			// 
			// label66
			// 
			this.label66.AutoSize = true;
			this.label66.Location = new System.Drawing.Point(31, 17);
			this.label66.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label66.Name = "label66";
			this.label66.Size = new System.Drawing.Size(65, 23);
			this.label66.TabIndex = 27;
			this.label66.Text = "Month";
			// 
			// comboBox4
			// 
			this.comboBox4.DropDownHeight = 300;
			this.comboBox4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBox4.FormattingEnabled = true;
			this.comboBox4.IntegralHeight = false;
			this.comboBox4.ItemHeight = 23;
			this.comboBox4.Location = new System.Drawing.Point(36, 49);
			this.comboBox4.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
			this.comboBox4.Name = "comboBox4";
			this.comboBox4.Size = new System.Drawing.Size(269, 31);
			this.comboBox4.TabIndex = 26;
			// 
			// label67
			// 
			this.label67.AutoSize = true;
			this.label67.Location = new System.Drawing.Point(1091, 17);
			this.label67.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label67.Name = "label67";
			this.label67.Size = new System.Drawing.Size(54, 23);
			this.label67.TabIndex = 25;
			this.label67.Text = "Type";
			// 
			// label68
			// 
			this.label68.AutoSize = true;
			this.label68.Location = new System.Drawing.Point(732, 17);
			this.label68.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label68.Name = "label68";
			this.label68.Size = new System.Drawing.Size(98, 23);
			this.label68.TabIndex = 24;
			this.label68.Text = "End Date";
			// 
			// label69
			// 
			this.label69.AutoSize = true;
			this.label69.Location = new System.Drawing.Point(367, 17);
			this.label69.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label69.Name = "label69";
			this.label69.Size = new System.Drawing.Size(120, 23);
			this.label69.TabIndex = 23;
			this.label69.Text = "Start Date";
			// 
			// comboBox5
			// 
			this.comboBox5.DropDownHeight = 300;
			this.comboBox5.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBox5.FormattingEnabled = true;
			this.comboBox5.IntegralHeight = false;
			this.comboBox5.ItemHeight = 23;
			this.comboBox5.Location = new System.Drawing.Point(1095, 49);
			this.comboBox5.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
			this.comboBox5.Name = "comboBox5";
			this.comboBox5.Size = new System.Drawing.Size(269, 31);
			this.comboBox5.TabIndex = 22;
			// 
			// comboBox6
			// 
			this.comboBox6.DropDownHeight = 300;
			this.comboBox6.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBox6.FormattingEnabled = true;
			this.comboBox6.IntegralHeight = false;
			this.comboBox6.ItemHeight = 23;
			this.comboBox6.Location = new System.Drawing.Point(736, 49);
			this.comboBox6.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
			this.comboBox6.Name = "comboBox6";
			this.comboBox6.Size = new System.Drawing.Size(289, 31);
			this.comboBox6.TabIndex = 21;
			// 
			// comboBox7
			// 
			this.comboBox7.DropDownHeight = 300;
			this.comboBox7.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBox7.FormattingEnabled = true;
			this.comboBox7.IntegralHeight = false;
			this.comboBox7.ItemHeight = 23;
			this.comboBox7.Location = new System.Drawing.Point(371, 49);
			this.comboBox7.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
			this.comboBox7.Name = "comboBox7";
			this.comboBox7.Size = new System.Drawing.Size(297, 31);
			this.comboBox7.TabIndex = 20;
			// 
			// PurchasesPRDataGridView
			// 
			this.PurchasesPRDataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
			this.PurchasesPRDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.PurchasesPRDataGridView.Location = new System.Drawing.Point(36, 198);
			this.PurchasesPRDataGridView.Name = "PurchasesPRDataGridView";
			this.PurchasesPRDataGridView.RowHeadersWidth = 51;
			this.PurchasesPRDataGridView.RowTemplate.Height = 24;
			this.PurchasesPRDataGridView.Size = new System.Drawing.Size(1655, 661);
			this.PurchasesPRDataGridView.TabIndex = 0;
			// 
			// customersTableAdapter1
			// 
			this.customersTableAdapter1.ClearBeforeFill = true;
			// 
			// checkBox1
			// 
			this.checkBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.checkBox1.AutoSize = true;
			this.checkBox1.Location = new System.Drawing.Point(136, 29);
			this.checkBox1.Margin = new System.Windows.Forms.Padding(2);
			this.checkBox1.Name = "checkBox1";
			this.checkBox1.Size = new System.Drawing.Size(127, 23);
			this.checkBox1.TabIndex = 54;
			this.checkBox1.Text = "New Company";
			this.checkBox1.UseVisualStyleBackColor = true;
			// 
			// comboBox1
			// 
			this.comboBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Location = new System.Drawing.Point(51, 158);
			this.comboBox1.Margin = new System.Windows.Forms.Padding(2);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(191, 25);
			this.comboBox1.TabIndex = 53;
			// 
			// numericUpDown1
			// 
			this.numericUpDown1.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.numericUpDown1.DecimalPlaces = 3;
			this.numericUpDown1.Location = new System.Drawing.Point(106, 285);
			this.numericUpDown1.Margin = new System.Windows.Forms.Padding(2);
			this.numericUpDown1.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
			this.numericUpDown1.Name = "numericUpDown1";
			this.numericUpDown1.Size = new System.Drawing.Size(73, 22);
			this.numericUpDown1.TabIndex = 52;
			this.numericUpDown1.ThousandsSeparator = true;
			// 
			// comboBox2
			// 
			this.comboBox2.DropDownHeight = 300;
			this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBox2.FormattingEnabled = true;
			this.comboBox2.IntegralHeight = false;
			this.comboBox2.ItemHeight = 16;
			this.comboBox2.Location = new System.Drawing.Point(81, 33);
			this.comboBox2.Margin = new System.Windows.Forms.Padding(2);
			this.comboBox2.Name = "comboBox2";
			this.comboBox2.Size = new System.Drawing.Size(59, 25);
			this.comboBox2.TabIndex = 51;
			// 
			// comboBox3
			// 
			this.comboBox3.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.comboBox3.DropDownHeight = 300;
			this.comboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBox3.FormattingEnabled = true;
			this.comboBox3.IntegralHeight = false;
			this.comboBox3.ItemHeight = 16;
			this.comboBox3.Location = new System.Drawing.Point(181, 284);
			this.comboBox3.Margin = new System.Windows.Forms.Padding(2);
			this.comboBox3.Name = "comboBox3";
			this.comboBox3.Size = new System.Drawing.Size(72, 25);
			this.comboBox3.TabIndex = 50;
			// 
			// button1
			// 
			this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.button1.Location = new System.Drawing.Point(66, 338);
			this.button1.Margin = new System.Windows.Forms.Padding(2);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(148, 48);
			this.button1.TabIndex = 49;
			this.button1.Text = "Generate Certificate";
			this.button1.UseVisualStyleBackColor = true;
			// 
			// textBox1
			// 
			this.textBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.textBox1.Location = new System.Drawing.Point(106, 197);
			this.textBox1.Margin = new System.Windows.Forms.Padding(2);
			this.textBox1.Name = "textBox1";
			this.textBox1.ReadOnly = true;
			this.textBox1.Size = new System.Drawing.Size(136, 22);
			this.textBox1.TabIndex = 48;
			// 
			// textBox2
			// 
			this.textBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.textBox2.Location = new System.Drawing.Point(106, 238);
			this.textBox2.Margin = new System.Windows.Forms.Padding(2);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(136, 22);
			this.textBox2.TabIndex = 47;
			// 
			// textBox3
			// 
			this.textBox3.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.textBox3.Location = new System.Drawing.Point(106, 100);
			this.textBox3.Margin = new System.Windows.Forms.Padding(2);
			this.textBox3.Name = "textBox3";
			this.textBox3.ReadOnly = true;
			this.textBox3.Size = new System.Drawing.Size(136, 22);
			this.textBox3.TabIndex = 46;
			// 
			// textBox4
			// 
			this.textBox4.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.textBox4.Location = new System.Drawing.Point(106, 64);
			this.textBox4.Margin = new System.Windows.Forms.Padding(2);
			this.textBox4.Name = "textBox4";
			this.textBox4.ReadOnly = true;
			this.textBox4.Size = new System.Drawing.Size(136, 22);
			this.textBox4.TabIndex = 45;
			// 
			// label40
			// 
			this.label40.AutoSize = true;
			this.label40.Location = new System.Drawing.Point(63, 47);
			this.label40.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label40.Name = "label40";
			this.label40.Size = new System.Drawing.Size(144, 19);
			this.label40.TabIndex = 44;
			this.label40.Text = "Extraction Date";
			// 
			// label41
			// 
			this.label41.AutoSize = true;
			this.label41.Location = new System.Drawing.Point(63, 158);
			this.label41.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label41.Name = "label41";
			this.label41.Size = new System.Drawing.Size(135, 19);
			this.label41.TabIndex = 43;
			this.label41.Text = "Contact Person";
			// 
			// label42
			// 
			this.label42.AutoSize = true;
			this.label42.Location = new System.Drawing.Point(63, 203);
			this.label42.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label42.Name = "label42";
			this.label42.Size = new System.Drawing.Size(135, 19);
			this.label42.TabIndex = 42;
			this.label42.Text = "Contact Number";
			// 
			// label43
			// 
			this.label43.AutoSize = true;
			this.label43.Location = new System.Drawing.Point(63, 244);
			this.label43.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label43.Name = "label43";
			this.label43.Size = new System.Drawing.Size(126, 19);
			this.label43.TabIndex = 41;
			this.label43.Text = "Email Address";
			// 
			// label44
			// 
			this.label44.AutoSize = true;
			this.label44.Location = new System.Drawing.Point(63, 286);
			this.label44.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label44.Name = "label44";
			this.label44.Size = new System.Drawing.Size(207, 19);
			this.label44.TabIndex = 40;
			this.label44.Text = "Description of Product";
			// 
			// label45
			// 
			this.label45.AutoSize = true;
			this.label45.Location = new System.Drawing.Point(63, 100);
			this.label45.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label45.Name = "label45";
			this.label45.Size = new System.Drawing.Size(72, 19);
			this.label45.TabIndex = 39;
			this.label45.Text = "Company";
			// 
			// label46
			// 
			this.label46.AutoSize = true;
			this.label46.Location = new System.Drawing.Point(63, 329);
			this.label46.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label46.Name = "label46";
			this.label46.Size = new System.Drawing.Size(81, 19);
			this.label46.TabIndex = 38;
			this.label46.Text = "Quantity";
			// 
			// Main_Form
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
			this.AutoSize = true;
			this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.BackColor = System.Drawing.Color.LightGray;
			this.ClientSize = new System.Drawing.Size(1732, 903);
			this.Controls.Add(this.mainTabControl);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.MaximizeBox = false;
			this.MinimumSize = new System.Drawing.Size(98, 593);
			this.Name = "Main_Form";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Green Enviro SA Recycling";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_Form_FormClosing);
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Main_Form_FormClosed);
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
			this.Inventory.ResumeLayout(false);
			this.Inventory.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.InventoryLogGridView)).EndInit();
			this.Expenses.ResumeLayout(false);
			this.Expenses.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.ExpenseAmount)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ExpensesLogGridView)).EndInit();
			this.WagesNewEmployee.ResumeLayout(false);
			this.WagesNewEmployee.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.WageAmount)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.WageLogGridView)).EndInit();
			this.Summaries.ResumeLayout(false);
			this.Summaries.PerformLayout();
			this.DestructionCertificates.ResumeLayout(false);
			this.DestructionCertificates.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dstrctCertQuantityNumBox)).EndInit();
			this.tabPage1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.salesPRDataGridView)).EndInit();
			this.tabPage2.ResumeLayout(false);
			this.tabPage2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.PurchasesPRDataGridView)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
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
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label21;
		public System.Windows.Forms.DateTimePicker SaleDate;
		public System.Windows.Forms.ComboBox SaleTypeBx;
		public System.Windows.Forms.ComboBox SaleCompanyNameList;
		public System.Windows.Forms.DataGridView SalesLogGridView;
		public System.Windows.Forms.CheckBox NewCompanyCheckBox;
		private Green_Enviro_DataDataSetTableAdapters.CustomersTableAdapter customersTableAdapter1;
		public System.Windows.Forms.NumericUpDown SaleQuantityBx;
		public System.Windows.Forms.NumericUpDown PriceBox;
		public System.Windows.Forms.NumericUpDown quantityBox;
		public System.Windows.Forms.NumericUpDown SaleAmount;
		private System.Windows.Forms.TabPage WagesNewEmployee;
		private System.Windows.Forms.TabPage Expenses;
		private System.Windows.Forms.TabPage Summaries;
		private System.Windows.Forms.Button ReceiptPriceEditBtn;
		public System.Windows.Forms.DateTimePicker ExpenseDate;
		private System.Windows.Forms.Button ExpensesLogRemoveFiltersBtn;
		private System.Windows.Forms.Button ExpensesLogFilterBtn;
		private System.Windows.Forms.Label label28;
		public System.Windows.Forms.ComboBox ExpensesLogMonth;
		private System.Windows.Forms.Label label29;
		private System.Windows.Forms.Label label30;
		public System.Windows.Forms.ComboBox ExpensesLogEndDate;
		public System.Windows.Forms.ComboBox ExpensesLogStartDate;
		public System.Windows.Forms.DataGridView ExpensesLogGridView;
		private System.Windows.Forms.Button ClearExpenseFieldsBtn;
		private System.Windows.Forms.Button AddExpenseBtn;
		private System.Windows.Forms.Label label31;
		private System.Windows.Forms.Label label33;
		private System.Windows.Forms.Label label34;
		public System.Windows.Forms.NumericUpDown ExpenseAmount;
		public System.Windows.Forms.TextBox ExpenseDescriptionBox;
		public System.Windows.Forms.NumericUpDown WageAmount;
		public System.Windows.Forms.DateTimePicker WageDate;
		private System.Windows.Forms.Button WageLogRemoveFiltersBtn;
		private System.Windows.Forms.Button WageLogFilterBtn;
		private System.Windows.Forms.Label label32;
		public System.Windows.Forms.ComboBox WageLogMonth;
		private System.Windows.Forms.Label label35;
		private System.Windows.Forms.Label label36;
		public System.Windows.Forms.ComboBox WageLogEndDate;
		public System.Windows.Forms.ComboBox WageLogStartDate;
		public System.Windows.Forms.DataGridView WageLogGridView;
		private System.Windows.Forms.Button ClearWageFieldsBtn;
		private System.Windows.Forms.Button AddWageBtn;
		private System.Windows.Forms.Label label37;
		private System.Windows.Forms.Label label38;
		private System.Windows.Forms.Label label39;
        public System.Windows.Forms.CheckBox checkBox1;
        public System.Windows.Forms.ComboBox comboBox1;
        public System.Windows.Forms.NumericUpDown numericUpDown1;
        public System.Windows.Forms.ComboBox comboBox2;
        public System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.TextBox textBox1;
        public System.Windows.Forms.TextBox textBox2;
        public System.Windows.Forms.TextBox textBox3;
        public System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label40;
        private System.Windows.Forms.Label label41;
        private System.Windows.Forms.Label label42;
        private System.Windows.Forms.Label label43;
        private System.Windows.Forms.Label label44;
        private System.Windows.Forms.Label label45;
        private System.Windows.Forms.Label label46;
		public System.Windows.Forms.ComboBox WagesEmployeeName;
		public System.Windows.Forms.CheckBox PartTimeEmployeeCheckBox;
        public System.Windows.Forms.CheckBox dstrctCertNewCompanyCheckBox;
        public System.Windows.Forms.NumericUpDown dstrctCertQuantityNumBox;
        public System.Windows.Forms.ComboBox dstrctCertQuantityUnit;
        public System.Windows.Forms.TextBox dstrctCertDescripOfProdField;
        public System.Windows.Forms.TextBox dstrctCertEmailAddressField;
        public System.Windows.Forms.TextBox dstrctCertCntactNumField;
        public System.Windows.Forms.TextBox dstrctCertCntactPersonField;
        public System.Windows.Forms.ComboBox dstrctCertCompanyField;
        public System.Windows.Forms.DateTimePicker dstrctCertExtractionDate;
		private System.Windows.Forms.Label label53;
		private System.Windows.Forms.Label label52;
		private System.Windows.Forms.Label label51;
		private System.Windows.Forms.Label label50;
		private System.Windows.Forms.Label label49;
		private System.Windows.Forms.Label label48;
		private System.Windows.Forms.Label label47;
		public System.Windows.Forms.ComboBox SummariesMonthSelector;
		public System.Windows.Forms.RichTextBox SummariesExpensesBox;
		public System.Windows.Forms.RichTextBox SummariesFSalesBox;
		public System.Windows.Forms.RichTextBox SummariesWagesBox;
		public System.Windows.Forms.RichTextBox SummariesNFPurchasesBox;
		public System.Windows.Forms.RichTextBox SummariesFPurchasesBox;
		private System.Windows.Forms.Label label54;
		public System.Windows.Forms.RichTextBox SummariesProfitBox;
		private System.Windows.Forms.Button EditCustomers;
		public System.Windows.Forms.CheckBox ReceiptDefaultCustomerCheckBox;
		private System.Windows.Forms.Button ReprintReceiptBtn;
		private System.Windows.Forms.Button AddFloatBtn;
		private System.Windows.Forms.Label label55;
		public System.Windows.Forms.TextBox FloatBox;
        private System.Windows.Forms.Button SendDstrctCertEmailBtn;
		private System.Windows.Forms.Label label57;
		public System.Windows.Forms.RichTextBox SummariesTotalSales;
		private System.Windows.Forms.Label label56;
		public System.Windows.Forms.RichTextBox SummariesTotalPurchases;
		public System.Windows.Forms.RichTextBox SummariesNFSalesBox;
		public System.Windows.Forms.ComboBox ReceiptSaleOrPurchase;
		private System.Windows.Forms.TabPage Inventory;
		public System.Windows.Forms.ComboBox InventoryLogMonth;
		public System.Windows.Forms.ComboBox InventoryLogEndDate;
		public System.Windows.Forms.ComboBox InventoryLogStartDate;
		private System.Windows.Forms.Label label60;
		private System.Windows.Forms.Label label59;
		private System.Windows.Forms.Label label58;
		private System.Windows.Forms.Button InventoryLogRmvFilterBtn;
		private System.Windows.Forms.Button InventoryLogFilterBtn;
		public System.Windows.Forms.DataGridView InventoryLogGridView;
		private System.Windows.Forms.Label label61;
		public System.Windows.Forms.RichTextBox SummariesTotalFloat;
		private System.Windows.Forms.Button NewEmployee;
		private System.Windows.Forms.Button LogOutBtn;
		public System.Windows.Forms.ComboBox InvetorySummedOrNot;
		private System.Windows.Forms.Label label62;
		public System.Windows.Forms.ComboBox InventoryLogType;
		private System.Windows.Forms.Label label63;
		private System.Windows.Forms.Button PrintPoliceRegisterBtn;
		public System.Windows.Forms.TextBox CustomerAddress;
		public System.Windows.Forms.TextBox CustomerCellNumber;
		private System.Windows.Forms.Label label65;
		private System.Windows.Forms.Label label64;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.TabPage tabPage2;
		private System.Windows.Forms.DataGridView salesPRDataGridView;
		private System.Windows.Forms.DataGridView PurchasesPRDataGridView;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.Label label66;
		public System.Windows.Forms.ComboBox comboBox4;
		private System.Windows.Forms.Label label67;
		private System.Windows.Forms.Label label68;
		private System.Windows.Forms.Label label69;
		public System.Windows.Forms.ComboBox comboBox5;
		public System.Windows.Forms.ComboBox comboBox6;
		public System.Windows.Forms.ComboBox comboBox7;
		private System.Windows.Forms.ColorDialog colorDialog1;
		public System.Windows.Forms.Label purchaseOrSaleIndicator;
	}
}