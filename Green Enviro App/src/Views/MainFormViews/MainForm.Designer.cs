
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
			this.ReceiptTransactionTypeIndicator = new System.Windows.Forms.Label();
			this.ReceiptCustomerAddress = new System.Windows.Forms.TextBox();
			this.ReceiptCustomerCellNum = new System.Windows.Forms.TextBox();
			this.ReceiptCustomerAddressLabel = new System.Windows.Forms.Label();
			this.ReceiptCustomerCellNumLabel = new System.Windows.Forms.Label();
			this.LogOutBtn = new System.Windows.Forms.Button();
			this.ReceiptTransactionType = new System.Windows.Forms.ComboBox();
			this.ReceiptAddFloatBtn = new System.Windows.Forms.Button();
			this.ReceiptFloat = new System.Windows.Forms.TextBox();
			this.ReceiptFloatLabel = new System.Windows.Forms.Label();
			this.ReceiptReprintBtn = new System.Windows.Forms.Button();
			this.ReceiptDefaultCustomerCheckBox = new System.Windows.Forms.CheckBox();
			this.ReceiptEditCustomers = new System.Windows.Forms.Button();
			this.ReceiptEditItemsBtn = new System.Windows.Forms.Button();
			this.ReceiptItemPrice = new System.Windows.Forms.NumericUpDown();
			this.ReceiptItemQuantity = new System.Windows.Forms.NumericUpDown();
			this.ReceiptCancelBtn = new System.Windows.Forms.Button();
			this.ReceiptPurchaseBtn = new System.Windows.Forms.Button();
			this.ReceiptCustomerName = new System.Windows.Forms.TextBox();
			this.ReceiptCustomerSurname = new System.Windows.Forms.TextBox();
			this.ReceiptCustomerNameLabel = new System.Windows.Forms.Label();
			this.ReceiptCustomerSurnameLabel = new System.Windows.Forms.Label();
			this.ReceiptCustomerID = new System.Windows.Forms.TextBox();
			this.ReceiptCustomerIDLabel = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.ReceiptCustomerNumbers = new System.Windows.Forms.ComboBox();
			this.ReceiptIDPicture = new System.Windows.Forms.PictureBox();
			this.ReceiptDealerPrice = new System.Windows.Forms.CheckBox();
			this.ReceiptPriceOverride = new System.Windows.Forms.CheckBox();
			this.ReceiptItemPriceLabel = new System.Windows.Forms.Label();
			this.ReceiptItemQuantityLabel = new System.Windows.Forms.Label();
			this.logo = new System.Windows.Forms.PictureBox();
			this.ReceiptItems = new System.Windows.Forms.ComboBox();
			this.ReceiptItemLabel = new System.Windows.Forms.Label();
			this.ReceiptAddItemBtn = new System.Windows.Forms.Button();
			this.ReceiptSlip = new System.Windows.Forms.RichTextBox();
			this.PurchasesPage = new System.Windows.Forms.TabPage();
			this.PurchaseDeleteBtn = new System.Windows.Forms.Button();
			this.AddToPRBtn = new System.Windows.Forms.Button();
			this.PurchaseLogRemoveFiltersBtn = new System.Windows.Forms.Button();
			this.PurchasesLogGridView = new System.Windows.Forms.DataGridView();
			this.PurchaseLogFilterBtn = new System.Windows.Forms.Button();
			this.PurchaseLogMonthLabel = new System.Windows.Forms.Label();
			this.PurchaseLogMonth = new System.Windows.Forms.ComboBox();
			this.PurchaseLogTypeLabel = new System.Windows.Forms.Label();
			this.PurchaseLogEndDateLabel = new System.Windows.Forms.Label();
			this.PurchaseLogStartDateLabel = new System.Windows.Forms.Label();
			this.PurchaseLogType = new System.Windows.Forms.ComboBox();
			this.PurchaseLogEndDate = new System.Windows.Forms.ComboBox();
			this.PurchaseLogStartDate = new System.Windows.Forms.ComboBox();
			this.SalesPage = new System.Windows.Forms.TabPage();
			this.SalesLogDeleteBtn = new System.Windows.Forms.Button();
			this.SaleAmount = new System.Windows.Forms.NumericUpDown();
			this.SaleQuantity = new System.Windows.Forms.NumericUpDown();
			this.SaleDate = new System.Windows.Forms.DateTimePicker();
			this.SalesLogRemoveFiltersBtn = new System.Windows.Forms.Button();
			this.SalesLogFilterBtn = new System.Windows.Forms.Button();
			this.SalesLogMonthLabel = new System.Windows.Forms.Label();
			this.SalesLogMonth = new System.Windows.Forms.ComboBox();
			this.SaleItemTypeLabel = new System.Windows.Forms.Label();
			this.SalesLogEndDateLabel = new System.Windows.Forms.Label();
			this.SalesLogStartDateLabel = new System.Windows.Forms.Label();
			this.SalesLogType = new System.Windows.Forms.ComboBox();
			this.SalesLogEndDate = new System.Windows.Forms.ComboBox();
			this.SalesLogStartDate = new System.Windows.Forms.ComboBox();
			this.SalesLogGridView = new System.Windows.Forms.DataGridView();
			this.SalesClearBtn = new System.Windows.Forms.Button();
			this.SaleAddBtn = new System.Windows.Forms.Button();
			this.SaleAmountLabel = new System.Windows.Forms.Label();
			this.SaleType = new System.Windows.Forms.ComboBox();
			this.SaleCompanyName = new System.Windows.Forms.ComboBox();
			this.SaleTypeLabel = new System.Windows.Forms.Label();
			this.SaleQuantityLabel = new System.Windows.Forms.Label();
			this.SaleCompanyLabel = new System.Windows.Forms.Label();
			this.SaleDateLabel = new System.Windows.Forms.Label();
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
			this.EditFixedExpensesBtn = new System.Windows.Forms.Button();
			this.ExpensesDeleteBtn = new System.Windows.Forms.Button();
			this.ExpenseAmount = new System.Windows.Forms.NumericUpDown();
			this.ExpenseDescription = new System.Windows.Forms.TextBox();
			this.ExpenseDate = new System.Windows.Forms.DateTimePicker();
			this.ExpensesLogRemoveFiltersBtn = new System.Windows.Forms.Button();
			this.ExpensesLogFilterBtn = new System.Windows.Forms.Button();
			this.ExpensesLogMonthsLabel = new System.Windows.Forms.Label();
			this.ExpensesLogMonths = new System.Windows.Forms.ComboBox();
			this.ExpensesLogEndDateLabel = new System.Windows.Forms.Label();
			this.ExpensesLogStartDateLabel = new System.Windows.Forms.Label();
			this.ExpensesLogEndDate = new System.Windows.Forms.ComboBox();
			this.ExpensesLogStartDate = new System.Windows.Forms.ComboBox();
			this.ExpensesLogGridView = new System.Windows.Forms.DataGridView();
			this.ExpenseClearBtn = new System.Windows.Forms.Button();
			this.ExpenseAddBtn = new System.Windows.Forms.Button();
			this.ExpenseAmountLabel = new System.Windows.Forms.Label();
			this.ExpenseDescriptionLabel = new System.Windows.Forms.Label();
			this.ExpenseDateLabel = new System.Windows.Forms.Label();
			this.WagesNewEmployee = new System.Windows.Forms.TabPage();
			this.WagesEndDateLabel = new System.Windows.Forms.Label();
			this.WagesLogRemoveFilterBtn = new System.Windows.Forms.Button();
			this.WageLogEndDate = new System.Windows.Forms.ComboBox();
			this.WagesMonthLabel = new System.Windows.Forms.Label();
			this.WagesEditEmployeesBtn = new System.Windows.Forms.Button();
			this.WagesStartDateLabel = new System.Windows.Forms.Label();
			this.WagesLogFilterBtn = new System.Windows.Forms.Button();
			this.WageLogStartDate = new System.Windows.Forms.ComboBox();
			this.WageLogMonths = new System.Windows.Forms.ComboBox();
			this.WagePartTimeEmployeeCheckBox = new System.Windows.Forms.CheckBox();
			this.WagesEmployeeName = new System.Windows.Forms.ComboBox();
			this.WageAmount = new System.Windows.Forms.NumericUpDown();
			this.WageDeleteBtn = new System.Windows.Forms.Button();
			this.WageDate = new System.Windows.Forms.DateTimePicker();
			this.WageLogGridView = new System.Windows.Forms.DataGridView();
			this.WageClearFieldsBtn = new System.Windows.Forms.Button();
			this.WageAddBtn = new System.Windows.Forms.Button();
			this.WageAmountLabel = new System.Windows.Forms.Label();
			this.WageEmployeeLabel = new System.Windows.Forms.Label();
			this.WagesDateLabel = new System.Windows.Forms.Label();
			this.SalesPR = new System.Windows.Forms.TabPage();
			this.salesPRDataGridView = new System.Windows.Forms.DataGridView();
			this.PurchasesPR = new System.Windows.Forms.TabPage();
			this.button6 = new System.Windows.Forms.Button();
			this.PrintPRBtn = new System.Windows.Forms.Button();
			this.RemovePRFiltersBtn = new System.Windows.Forms.Button();
			this.FilterPRBtn = new System.Windows.Forms.Button();
			this.label66 = new System.Windows.Forms.Label();
			this.PurchasesPRMonth = new System.Windows.Forms.ComboBox();
			this.label67 = new System.Windows.Forms.Label();
			this.label68 = new System.Windows.Forms.Label();
			this.label69 = new System.Windows.Forms.Label();
			this.PurchasePRType = new System.Windows.Forms.ComboBox();
			this.PurchasePREndDate = new System.Windows.Forms.ComboBox();
			this.PurchasePRStartDate = new System.Windows.Forms.ComboBox();
			this.PurchasesPRDataGridView = new System.Windows.Forms.DataGridView();
			this.Summaries = new System.Windows.Forms.TabPage();
			this.SummariesTotalSalesLabel = new System.Windows.Forms.Label();
			this.SummariesTotalSales = new System.Windows.Forms.RichTextBox();
			this.SummariesTotalPurchasesLabel = new System.Windows.Forms.Label();
			this.SummariesTotalPurchases = new System.Windows.Forms.RichTextBox();
			this.SummariesProfitLabel = new System.Windows.Forms.Label();
			this.SummariesProfitBox = new System.Windows.Forms.RichTextBox();
			this.SummariesMonthsLabel = new System.Windows.Forms.Label();
			this.SummariesMonths = new System.Windows.Forms.ComboBox();
			this.SummariesExpensesBox = new System.Windows.Forms.RichTextBox();
			this.SummariesNFSalesBox = new System.Windows.Forms.RichTextBox();
			this.SummariesFSalesBox = new System.Windows.Forms.RichTextBox();
			this.SummariesWagesBox = new System.Windows.Forms.RichTextBox();
			this.SummariesNFPurchasesBox = new System.Windows.Forms.RichTextBox();
			this.SummariesFPurchasesBox = new System.Windows.Forms.RichTextBox();
			this.SummariesExpensesLabel = new System.Windows.Forms.Label();
			this.SummariesWagesLabel = new System.Windows.Forms.Label();
			this.SummariesNFSalesLabel = new System.Windows.Forms.Label();
			this.SummariesNFPurchasesLabel = new System.Windows.Forms.Label();
			this.SummariesFSalesLabel = new System.Windows.Forms.Label();
			this.SummariesFPurchasesLabel = new System.Windows.Forms.Label();
			this.DestructionCertificates = new System.Windows.Forms.TabPage();
			this.DestructionCertCmpnyAddress = new System.Windows.Forms.TextBox();
			this.DestructionCertCmpnyAddressLabel = new System.Windows.Forms.Label();
			this.DestructionCertNewCompanyCheckbox = new System.Windows.Forms.CheckBox();
			this.DestructionCertEmailBtn = new System.Windows.Forms.Button();
			this.DestructionCertExtractionDate = new System.Windows.Forms.DateTimePicker();
			this.DestructionCertCompany = new System.Windows.Forms.ComboBox();
			this.DestructionCertQntty = new System.Windows.Forms.NumericUpDown();
			this.DestructionCertQnttyUnit = new System.Windows.Forms.ComboBox();
			this.DestructionCertGenBtn = new System.Windows.Forms.Button();
			this.DestructionCertEmailAddress = new System.Windows.Forms.TextBox();
			this.DestructionCertDescripOfPrdct = new System.Windows.Forms.TextBox();
			this.DestructionCertCntactNum = new System.Windows.Forms.TextBox();
			this.DestructionCertCntactPerson = new System.Windows.Forms.TextBox();
			this.DestructionCertExtractionDateLabel = new System.Windows.Forms.Label();
			this.DestructionCertCntactPersonLabel = new System.Windows.Forms.Label();
			this.DestructionCertCntactNumLabel = new System.Windows.Forms.Label();
			this.DestructionCertEmailAddressLabel = new System.Windows.Forms.Label();
			this.DestructionCertDescripOfPrdctLabel = new System.Windows.Forms.Label();
			this.DestructionCertCompanyLabel = new System.Windows.Forms.Label();
			this.DestructionCertQnttyLabel = new System.Windows.Forms.Label();
			this.DeliveryNote = new System.Windows.Forms.TabPage();
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
			this.DeliveryVehicleTypePicture = new System.Windows.Forms.PictureBox();
			this.DeliveryVehicleType = new System.Windows.Forms.ComboBox();
			this.DeliveryVehicleReg = new System.Windows.Forms.TextBox();
			this.DeliveryDriverCell = new System.Windows.Forms.TextBox();
			this.DeliveryDriverName = new System.Windows.Forms.TextBox();
			this.DeliverVehicleTypeLabel = new System.Windows.Forms.Label();
			this.DeliveryVehicleRegLabel = new System.Windows.Forms.Label();
			this.DeliveryDriverCellLabel = new System.Windows.Forms.Label();
			this.DeliveryDriverNameLabel = new System.Windows.Forms.Label();
			this.DeliveryCompanyNameLabel = new System.Windows.Forms.Label();
			this.DeliveryCompaniesList = new System.Windows.Forms.ComboBox();
			this.DeliveryAddItem = new System.Windows.Forms.Button();
			this.DeliveryQuantityBox = new System.Windows.Forms.NumericUpDown();
			this.DeliveryQuantityLabel = new System.Windows.Forms.Label();
			this.DeliveryItemsList = new System.Windows.Forms.ComboBox();
			this.DeliveryItemsLabel = new System.Windows.Forms.Label();
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
			this.colorDialog1 = new System.Windows.Forms.ColorDialog();
			this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
			this.mainTabControl.SuspendLayout();
			this.ReceiptPage.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.ReceiptItemPrice)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ReceiptItemQuantity)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ReceiptIDPicture)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
			this.PurchasesPage.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.PurchasesLogGridView)).BeginInit();
			this.SalesPage.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.SaleAmount)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.SaleQuantity)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.SalesLogGridView)).BeginInit();
			this.Inventory.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.InventoryLogGridView)).BeginInit();
			this.Expenses.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.ExpenseAmount)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ExpensesLogGridView)).BeginInit();
			this.WagesNewEmployee.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.WageAmount)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.WageLogGridView)).BeginInit();
			this.SalesPR.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.salesPRDataGridView)).BeginInit();
			this.PurchasesPR.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.PurchasesPRDataGridView)).BeginInit();
			this.Summaries.SuspendLayout();
			this.DestructionCertificates.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.DestructionCertQntty)).BeginInit();
			this.DeliveryNote.SuspendLayout();
			this.DeliveryNoteDisplayPanel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.DeliveryNotePdfDisplay)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DeliveryNoteGrid)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DeliveryVehicleTypePicture)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DeliveryQuantityBox)).BeginInit();
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
			this.mainTabControl.Controls.Add(this.SalesPR);
			this.mainTabControl.Controls.Add(this.PurchasesPR);
			this.mainTabControl.Controls.Add(this.Summaries);
			this.mainTabControl.Controls.Add(this.DestructionCertificates);
			this.mainTabControl.Controls.Add(this.DeliveryNote);
			this.mainTabControl.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.mainTabControl.HotTrack = true;
			this.mainTabControl.Location = new System.Drawing.Point(0, 0);
			this.mainTabControl.Margin = new System.Windows.Forms.Padding(2);
			this.mainTabControl.Name = "mainTabControl";
			this.mainTabControl.SelectedIndex = 0;
			this.mainTabControl.Size = new System.Drawing.Size(1386, 722);
			this.mainTabControl.TabIndex = 0;
			this.mainTabControl.TabStop = false;
			this.mainTabControl.Selected += new System.Windows.Forms.TabControlEventHandler(this.mainTabControl_Selected);
			this.mainTabControl.Deselected += new System.Windows.Forms.TabControlEventHandler(this.mainTabControl_Deselected);
			// 
			// ReceiptPage
			// 
			this.ReceiptPage.Controls.Add(this.ReceiptTransactionTypeIndicator);
			this.ReceiptPage.Controls.Add(this.ReceiptCustomerAddress);
			this.ReceiptPage.Controls.Add(this.ReceiptCustomerCellNum);
			this.ReceiptPage.Controls.Add(this.ReceiptCustomerAddressLabel);
			this.ReceiptPage.Controls.Add(this.ReceiptCustomerCellNumLabel);
			this.ReceiptPage.Controls.Add(this.LogOutBtn);
			this.ReceiptPage.Controls.Add(this.ReceiptTransactionType);
			this.ReceiptPage.Controls.Add(this.ReceiptAddFloatBtn);
			this.ReceiptPage.Controls.Add(this.ReceiptFloat);
			this.ReceiptPage.Controls.Add(this.ReceiptFloatLabel);
			this.ReceiptPage.Controls.Add(this.ReceiptReprintBtn);
			this.ReceiptPage.Controls.Add(this.ReceiptDefaultCustomerCheckBox);
			this.ReceiptPage.Controls.Add(this.ReceiptEditCustomers);
			this.ReceiptPage.Controls.Add(this.ReceiptEditItemsBtn);
			this.ReceiptPage.Controls.Add(this.ReceiptItemPrice);
			this.ReceiptPage.Controls.Add(this.ReceiptItemQuantity);
			this.ReceiptPage.Controls.Add(this.ReceiptCancelBtn);
			this.ReceiptPage.Controls.Add(this.ReceiptPurchaseBtn);
			this.ReceiptPage.Controls.Add(this.ReceiptCustomerName);
			this.ReceiptPage.Controls.Add(this.ReceiptCustomerSurname);
			this.ReceiptPage.Controls.Add(this.ReceiptCustomerNameLabel);
			this.ReceiptPage.Controls.Add(this.ReceiptCustomerSurnameLabel);
			this.ReceiptPage.Controls.Add(this.ReceiptCustomerID);
			this.ReceiptPage.Controls.Add(this.ReceiptCustomerIDLabel);
			this.ReceiptPage.Controls.Add(this.label4);
			this.ReceiptPage.Controls.Add(this.ReceiptCustomerNumbers);
			this.ReceiptPage.Controls.Add(this.ReceiptIDPicture);
			this.ReceiptPage.Controls.Add(this.ReceiptDealerPrice);
			this.ReceiptPage.Controls.Add(this.ReceiptPriceOverride);
			this.ReceiptPage.Controls.Add(this.ReceiptItemPriceLabel);
			this.ReceiptPage.Controls.Add(this.ReceiptItemQuantityLabel);
			this.ReceiptPage.Controls.Add(this.logo);
			this.ReceiptPage.Controls.Add(this.ReceiptItems);
			this.ReceiptPage.Controls.Add(this.ReceiptItemLabel);
			this.ReceiptPage.Controls.Add(this.ReceiptAddItemBtn);
			this.ReceiptPage.Controls.Add(this.ReceiptSlip);
			this.ReceiptPage.Location = new System.Drawing.Point(4, 28);
			this.ReceiptPage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.ReceiptPage.Name = "ReceiptPage";
			this.ReceiptPage.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.ReceiptPage.Size = new System.Drawing.Size(1378, 690);
			this.ReceiptPage.TabIndex = 0;
			this.ReceiptPage.Text = "Receipt";
			this.ReceiptPage.UseVisualStyleBackColor = true;
			// 
			// ReceiptTransactionTypeIndicator
			// 
			this.ReceiptTransactionTypeIndicator.AutoSize = true;
			this.ReceiptTransactionTypeIndicator.BackColor = System.Drawing.Color.Red;
			this.ReceiptTransactionTypeIndicator.Font = new System.Drawing.Font("Consolas", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ReceiptTransactionTypeIndicator.Location = new System.Drawing.Point(240, 14);
			this.ReceiptTransactionTypeIndicator.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.ReceiptTransactionTypeIndicator.Name = "ReceiptTransactionTypeIndicator";
			this.ReceiptTransactionTypeIndicator.Size = new System.Drawing.Size(42, 47);
			this.ReceiptTransactionTypeIndicator.TabIndex = 78;
			this.ReceiptTransactionTypeIndicator.Text = " ";
			// 
			// ReceiptCustomerAddress
			// 
			this.ReceiptCustomerAddress.Location = new System.Drawing.Point(698, 314);
			this.ReceiptCustomerAddress.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.ReceiptCustomerAddress.Name = "ReceiptCustomerAddress";
			this.ReceiptCustomerAddress.ReadOnly = true;
			this.ReceiptCustomerAddress.Size = new System.Drawing.Size(261, 26);
			this.ReceiptCustomerAddress.TabIndex = 77;
			// 
			// ReceiptCustomerCellNum
			// 
			this.ReceiptCustomerCellNum.Location = new System.Drawing.Point(698, 262);
			this.ReceiptCustomerCellNum.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.ReceiptCustomerCellNum.Name = "ReceiptCustomerCellNum";
			this.ReceiptCustomerCellNum.ReadOnly = true;
			this.ReceiptCustomerCellNum.Size = new System.Drawing.Size(261, 26);
			this.ReceiptCustomerCellNum.TabIndex = 76;
			// 
			// ReceiptCustomerAddressLabel
			// 
			this.ReceiptCustomerAddressLabel.AutoSize = true;
			this.ReceiptCustomerAddressLabel.Location = new System.Drawing.Point(560, 321);
			this.ReceiptCustomerAddressLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.ReceiptCustomerAddressLabel.Name = "ReceiptCustomerAddressLabel";
			this.ReceiptCustomerAddressLabel.Size = new System.Drawing.Size(72, 19);
			this.ReceiptCustomerAddressLabel.TabIndex = 75;
			this.ReceiptCustomerAddressLabel.Text = "Address";
			// 
			// ReceiptCustomerCellNumLabel
			// 
			this.ReceiptCustomerCellNumLabel.AutoSize = true;
			this.ReceiptCustomerCellNumLabel.Location = new System.Drawing.Point(560, 265);
			this.ReceiptCustomerCellNumLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.ReceiptCustomerCellNumLabel.Name = "ReceiptCustomerCellNumLabel";
			this.ReceiptCustomerCellNumLabel.Size = new System.Drawing.Size(45, 19);
			this.ReceiptCustomerCellNumLabel.TabIndex = 74;
			this.ReceiptCustomerCellNumLabel.Text = "Cell";
			// 
			// LogOutBtn
			// 
			this.LogOutBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.LogOutBtn.Location = new System.Drawing.Point(1200, 634);
			this.LogOutBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.LogOutBtn.Name = "LogOutBtn";
			this.LogOutBtn.Size = new System.Drawing.Size(166, 46);
			this.LogOutBtn.TabIndex = 73;
			this.LogOutBtn.Text = "Log Out";
			this.LogOutBtn.UseVisualStyleBackColor = true;
			this.LogOutBtn.Click += new System.EventHandler(this.LogOutBtn_Click_1);
			// 
			// ReceiptTransactionType
			// 
			this.ReceiptTransactionType.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.ReceiptTransactionType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.ReceiptTransactionType.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ReceiptTransactionType.FormattingEnabled = true;
			this.ReceiptTransactionType.Location = new System.Drawing.Point(38, 18);
			this.ReceiptTransactionType.Margin = new System.Windows.Forms.Padding(2);
			this.ReceiptTransactionType.Name = "ReceiptTransactionType";
			this.ReceiptTransactionType.Size = new System.Drawing.Size(174, 27);
			this.ReceiptTransactionType.TabIndex = 35;
			this.ReceiptTransactionType.SelectedIndexChanged += new System.EventHandler(this.ReceiptTransactionType_SelectedIndexChanged);
			// 
			// ReceiptAddFloatBtn
			// 
			this.ReceiptAddFloatBtn.Location = new System.Drawing.Point(220, 110);
			this.ReceiptAddFloatBtn.Margin = new System.Windows.Forms.Padding(2);
			this.ReceiptAddFloatBtn.Name = "ReceiptAddFloatBtn";
			this.ReceiptAddFloatBtn.Size = new System.Drawing.Size(131, 38);
			this.ReceiptAddFloatBtn.TabIndex = 34;
			this.ReceiptAddFloatBtn.Text = "Add Float";
			this.ReceiptAddFloatBtn.UseVisualStyleBackColor = true;
			this.ReceiptAddFloatBtn.Click += new System.EventHandler(this.AddFloatBtn_Click);
			// 
			// ReceiptFloat
			// 
			this.ReceiptFloat.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ReceiptFloat.Location = new System.Drawing.Point(40, 113);
			this.ReceiptFloat.Margin = new System.Windows.Forms.Padding(2);
			this.ReceiptFloat.Name = "ReceiptFloat";
			this.ReceiptFloat.ReadOnly = true;
			this.ReceiptFloat.Size = new System.Drawing.Size(172, 36);
			this.ReceiptFloat.TabIndex = 33;
			this.ReceiptFloat.TabStop = false;
			// 
			// ReceiptFloatLabel
			// 
			this.ReceiptFloatLabel.AutoSize = true;
			this.ReceiptFloatLabel.Location = new System.Drawing.Point(37, 92);
			this.ReceiptFloatLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.ReceiptFloatLabel.Name = "ReceiptFloatLabel";
			this.ReceiptFloatLabel.Size = new System.Drawing.Size(144, 19);
			this.ReceiptFloatLabel.TabIndex = 32;
			this.ReceiptFloatLabel.Text = "Remaining Float";
			// 
			// ReceiptReprintBtn
			// 
			this.ReceiptReprintBtn.AllowDrop = true;
			this.ReceiptReprintBtn.Location = new System.Drawing.Point(33, 622);
			this.ReceiptReprintBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.ReceiptReprintBtn.Name = "ReceiptReprintBtn";
			this.ReceiptReprintBtn.Size = new System.Drawing.Size(328, 50);
			this.ReceiptReprintBtn.TabIndex = 31;
			this.ReceiptReprintBtn.Text = "Re-print Receipt";
			this.ReceiptReprintBtn.UseVisualStyleBackColor = true;
			this.ReceiptReprintBtn.Click += new System.EventHandler(this.ReprintReceiptBtn_Click);
			// 
			// ReceiptDefaultCustomerCheckBox
			// 
			this.ReceiptDefaultCustomerCheckBox.AutoSize = true;
			this.ReceiptDefaultCustomerCheckBox.Location = new System.Drawing.Point(563, 22);
			this.ReceiptDefaultCustomerCheckBox.Margin = new System.Windows.Forms.Padding(2);
			this.ReceiptDefaultCustomerCheckBox.Name = "ReceiptDefaultCustomerCheckBox";
			this.ReceiptDefaultCustomerCheckBox.Size = new System.Drawing.Size(91, 23);
			this.ReceiptDefaultCustomerCheckBox.TabIndex = 30;
			this.ReceiptDefaultCustomerCheckBox.Text = "Default";
			this.ReceiptDefaultCustomerCheckBox.UseVisualStyleBackColor = true;
			// 
			// ReceiptEditCustomers
			// 
			this.ReceiptEditCustomers.Location = new System.Drawing.Point(698, 354);
			this.ReceiptEditCustomers.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.ReceiptEditCustomers.Name = "ReceiptEditCustomers";
			this.ReceiptEditCustomers.Size = new System.Drawing.Size(178, 26);
			this.ReceiptEditCustomers.TabIndex = 28;
			this.ReceiptEditCustomers.Text = "Edit Customers";
			this.ReceiptEditCustomers.UseVisualStyleBackColor = true;
			this.ReceiptEditCustomers.Click += new System.EventHandler(this.EditCustomers_Click);
			// 
			// ReceiptEditItemsBtn
			// 
			this.ReceiptEditItemsBtn.Location = new System.Drawing.Point(162, 242);
			this.ReceiptEditItemsBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.ReceiptEditItemsBtn.Name = "ReceiptEditItemsBtn";
			this.ReceiptEditItemsBtn.Size = new System.Drawing.Size(190, 26);
			this.ReceiptEditItemsBtn.TabIndex = 27;
			this.ReceiptEditItemsBtn.Text = "Edit Items";
			this.ReceiptEditItemsBtn.UseVisualStyleBackColor = true;
			this.ReceiptEditItemsBtn.Click += new System.EventHandler(this.ReceiptPriceEditBtn_Click);
			// 
			// ReceiptItemPrice
			// 
			this.ReceiptItemPrice.DecimalPlaces = 2;
			this.ReceiptItemPrice.Location = new System.Drawing.Point(162, 351);
			this.ReceiptItemPrice.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.ReceiptItemPrice.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
			this.ReceiptItemPrice.Name = "ReceiptItemPrice";
			this.ReceiptItemPrice.ReadOnly = true;
			this.ReceiptItemPrice.Size = new System.Drawing.Size(131, 26);
			this.ReceiptItemPrice.TabIndex = 26;
			this.ReceiptItemPrice.ThousandsSeparator = true;
			// 
			// ReceiptItemQuantity
			// 
			this.ReceiptItemQuantity.DecimalPlaces = 2;
			this.ReceiptItemQuantity.Location = new System.Drawing.Point(162, 396);
			this.ReceiptItemQuantity.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.ReceiptItemQuantity.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
			this.ReceiptItemQuantity.Name = "ReceiptItemQuantity";
			this.ReceiptItemQuantity.Size = new System.Drawing.Size(189, 26);
			this.ReceiptItemQuantity.TabIndex = 25;
			this.ReceiptItemQuantity.ThousandsSeparator = true;
			// 
			// ReceiptCancelBtn
			// 
			this.ReceiptCancelBtn.AllowDrop = true;
			this.ReceiptCancelBtn.Location = new System.Drawing.Point(33, 550);
			this.ReceiptCancelBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.ReceiptCancelBtn.Name = "ReceiptCancelBtn";
			this.ReceiptCancelBtn.Size = new System.Drawing.Size(328, 50);
			this.ReceiptCancelBtn.TabIndex = 24;
			this.ReceiptCancelBtn.Text = "Cancel";
			this.ReceiptCancelBtn.UseVisualStyleBackColor = true;
			this.ReceiptCancelBtn.Click += new System.EventHandler(this.CancelPurchaseBtn_Click);
			// 
			// ReceiptPurchaseBtn
			// 
			this.ReceiptPurchaseBtn.AllowDrop = true;
			this.ReceiptPurchaseBtn.Location = new System.Drawing.Point(208, 475);
			this.ReceiptPurchaseBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.ReceiptPurchaseBtn.Name = "ReceiptPurchaseBtn";
			this.ReceiptPurchaseBtn.Size = new System.Drawing.Size(153, 50);
			this.ReceiptPurchaseBtn.TabIndex = 23;
			this.ReceiptPurchaseBtn.Text = "Purchase/Sale";
			this.ReceiptPurchaseBtn.UseVisualStyleBackColor = true;
			this.ReceiptPurchaseBtn.Click += new System.EventHandler(this.PurchaseBtn_Click);
			// 
			// ReceiptCustomerName
			// 
			this.ReceiptCustomerName.Location = new System.Drawing.Point(698, 150);
			this.ReceiptCustomerName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.ReceiptCustomerName.Name = "ReceiptCustomerName";
			this.ReceiptCustomerName.ReadOnly = true;
			this.ReceiptCustomerName.Size = new System.Drawing.Size(261, 26);
			this.ReceiptCustomerName.TabIndex = 22;
			// 
			// ReceiptCustomerSurname
			// 
			this.ReceiptCustomerSurname.Location = new System.Drawing.Point(698, 206);
			this.ReceiptCustomerSurname.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.ReceiptCustomerSurname.Name = "ReceiptCustomerSurname";
			this.ReceiptCustomerSurname.ReadOnly = true;
			this.ReceiptCustomerSurname.Size = new System.Drawing.Size(261, 26);
			this.ReceiptCustomerSurname.TabIndex = 21;
			// 
			// ReceiptCustomerNameLabel
			// 
			this.ReceiptCustomerNameLabel.AutoSize = true;
			this.ReceiptCustomerNameLabel.Location = new System.Drawing.Point(560, 152);
			this.ReceiptCustomerNameLabel.Name = "ReceiptCustomerNameLabel";
			this.ReceiptCustomerNameLabel.Size = new System.Drawing.Size(45, 19);
			this.ReceiptCustomerNameLabel.TabIndex = 20;
			this.ReceiptCustomerNameLabel.Text = "Name";
			// 
			// ReceiptCustomerSurnameLabel
			// 
			this.ReceiptCustomerSurnameLabel.AutoSize = true;
			this.ReceiptCustomerSurnameLabel.Location = new System.Drawing.Point(560, 206);
			this.ReceiptCustomerSurnameLabel.Name = "ReceiptCustomerSurnameLabel";
			this.ReceiptCustomerSurnameLabel.Size = new System.Drawing.Size(72, 19);
			this.ReceiptCustomerSurnameLabel.TabIndex = 19;
			this.ReceiptCustomerSurnameLabel.Text = "Surname";
			// 
			// ReceiptCustomerID
			// 
			this.ReceiptCustomerID.Location = new System.Drawing.Point(698, 99);
			this.ReceiptCustomerID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.ReceiptCustomerID.Name = "ReceiptCustomerID";
			this.ReceiptCustomerID.ReadOnly = true;
			this.ReceiptCustomerID.Size = new System.Drawing.Size(261, 26);
			this.ReceiptCustomerID.TabIndex = 18;
			// 
			// ReceiptCustomerIDLabel
			// 
			this.ReceiptCustomerIDLabel.AutoSize = true;
			this.ReceiptCustomerIDLabel.Location = new System.Drawing.Point(560, 102);
			this.ReceiptCustomerIDLabel.Name = "ReceiptCustomerIDLabel";
			this.ReceiptCustomerIDLabel.Size = new System.Drawing.Size(27, 19);
			this.ReceiptCustomerIDLabel.TabIndex = 17;
			this.ReceiptCustomerIDLabel.Text = "ID";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(560, 58);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(144, 19);
			this.label4.TabIndex = 16;
			this.label4.Text = "Customer Number";
			// 
			// ReceiptCustomerNumbers
			// 
			this.ReceiptCustomerNumbers.DropDownHeight = 300;
			this.ReceiptCustomerNumbers.FormattingEnabled = true;
			this.ReceiptCustomerNumbers.IntegralHeight = false;
			this.ReceiptCustomerNumbers.ItemHeight = 19;
			this.ReceiptCustomerNumbers.Location = new System.Drawing.Point(873, 56);
			this.ReceiptCustomerNumbers.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.ReceiptCustomerNumbers.Name = "ReceiptCustomerNumbers";
			this.ReceiptCustomerNumbers.Size = new System.Drawing.Size(86, 27);
			this.ReceiptCustomerNumbers.TabIndex = 15;
			this.ReceiptCustomerNumbers.SelectedIndexChanged += new System.EventHandler(this.ReceiptCustomerNumbers_SelectedIndexChanged);
			this.ReceiptCustomerNumbers.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ReceiptCustomerNumbers_KeyDown);
			// 
			// ReceiptIDPicture
			// 
			this.ReceiptIDPicture.BackColor = System.Drawing.Color.Transparent;
			this.ReceiptIDPicture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.ReceiptIDPicture.Location = new System.Drawing.Point(563, 396);
			this.ReceiptIDPicture.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.ReceiptIDPicture.Name = "ReceiptIDPicture";
			this.ReceiptIDPicture.Size = new System.Drawing.Size(396, 276);
			this.ReceiptIDPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.ReceiptIDPicture.TabIndex = 1;
			this.ReceiptIDPicture.TabStop = false;
			// 
			// ReceiptDealerPrice
			// 
			this.ReceiptDealerPrice.AutoSize = true;
			this.ReceiptDealerPrice.Location = new System.Drawing.Point(162, 290);
			this.ReceiptDealerPrice.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.ReceiptDealerPrice.Name = "ReceiptDealerPrice";
			this.ReceiptDealerPrice.Size = new System.Drawing.Size(136, 23);
			this.ReceiptDealerPrice.TabIndex = 14;
			this.ReceiptDealerPrice.Text = "Dealer Price";
			this.ReceiptDealerPrice.UseVisualStyleBackColor = true;
			this.ReceiptDealerPrice.CheckedChanged += new System.EventHandler(this.DealerPriceCheckBox_CheckedChanged);
			// 
			// ReceiptPriceOverride
			// 
			this.ReceiptPriceOverride.AutoSize = true;
			this.ReceiptPriceOverride.Location = new System.Drawing.Point(162, 318);
			this.ReceiptPriceOverride.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.ReceiptPriceOverride.Name = "ReceiptPriceOverride";
			this.ReceiptPriceOverride.Size = new System.Drawing.Size(136, 23);
			this.ReceiptPriceOverride.TabIndex = 13;
			this.ReceiptPriceOverride.Text = "Manual Price";
			this.ReceiptPriceOverride.UseVisualStyleBackColor = true;
			this.ReceiptPriceOverride.CheckedChanged += new System.EventHandler(this.ReceiptPriceOverride_CheckedChanged);
			// 
			// ReceiptItemPriceLabel
			// 
			this.ReceiptItemPriceLabel.AutoSize = true;
			this.ReceiptItemPriceLabel.Location = new System.Drawing.Point(35, 353);
			this.ReceiptItemPriceLabel.Name = "ReceiptItemPriceLabel";
			this.ReceiptItemPriceLabel.Size = new System.Drawing.Size(54, 19);
			this.ReceiptItemPriceLabel.TabIndex = 11;
			this.ReceiptItemPriceLabel.Text = "Price";
			// 
			// ReceiptItemQuantityLabel
			// 
			this.ReceiptItemQuantityLabel.AutoSize = true;
			this.ReceiptItemQuantityLabel.Location = new System.Drawing.Point(35, 398);
			this.ReceiptItemQuantityLabel.Name = "ReceiptItemQuantityLabel";
			this.ReceiptItemQuantityLabel.Size = new System.Drawing.Size(81, 19);
			this.ReceiptItemQuantityLabel.TabIndex = 9;
			this.ReceiptItemQuantityLabel.Text = "Quantity";
			// 
			// logo
			// 
			this.logo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.logo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.logo.Image = ((System.Drawing.Image)(resources.GetObject("logo.Image")));
			this.logo.InitialImage = null;
			this.logo.Location = new System.Drawing.Point(1026, 27);
			this.logo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.logo.Name = "logo";
			this.logo.Size = new System.Drawing.Size(340, 134);
			this.logo.TabIndex = 8;
			this.logo.TabStop = false;
			this.logo.Visible = false;
			// 
			// ReceiptItems
			// 
			this.ReceiptItems.DropDownHeight = 300;
			this.ReceiptItems.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.ReceiptItems.FormattingEnabled = true;
			this.ReceiptItems.IntegralHeight = false;
			this.ReceiptItems.ItemHeight = 19;
			this.ReceiptItems.Location = new System.Drawing.Point(162, 198);
			this.ReceiptItems.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.ReceiptItems.Name = "ReceiptItems";
			this.ReceiptItems.Size = new System.Drawing.Size(190, 27);
			this.ReceiptItems.TabIndex = 7;
			this.ReceiptItems.SelectedIndexChanged += new System.EventHandler(this.itemList_SelectedIndexChanged);
			// 
			// ReceiptItemLabel
			// 
			this.ReceiptItemLabel.AutoSize = true;
			this.ReceiptItemLabel.Location = new System.Drawing.Point(35, 199);
			this.ReceiptItemLabel.Name = "ReceiptItemLabel";
			this.ReceiptItemLabel.Size = new System.Drawing.Size(45, 19);
			this.ReceiptItemLabel.TabIndex = 3;
			this.ReceiptItemLabel.Text = "Item";
			// 
			// ReceiptAddItemBtn
			// 
			this.ReceiptAddItemBtn.AllowDrop = true;
			this.ReceiptAddItemBtn.Location = new System.Drawing.Point(33, 475);
			this.ReceiptAddItemBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.ReceiptAddItemBtn.Name = "ReceiptAddItemBtn";
			this.ReceiptAddItemBtn.Size = new System.Drawing.Size(153, 50);
			this.ReceiptAddItemBtn.TabIndex = 1;
			this.ReceiptAddItemBtn.Text = "Add Item";
			this.ReceiptAddItemBtn.UseVisualStyleBackColor = true;
			this.ReceiptAddItemBtn.Click += new System.EventHandler(this.addItemBtn_Click);
			// 
			// ReceiptSlip
			// 
			this.ReceiptSlip.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.ReceiptSlip.BackColor = System.Drawing.Color.White;
			this.ReceiptSlip.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.ReceiptSlip.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ReceiptSlip.Location = new System.Drawing.Point(1025, 26);
			this.ReceiptSlip.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.ReceiptSlip.Name = "ReceiptSlip";
			this.ReceiptSlip.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.ReceiptSlip.Size = new System.Drawing.Size(346, 589);
			this.ReceiptSlip.TabIndex = 0;
			this.ReceiptSlip.Text = "";
			this.ReceiptSlip.WordWrap = false;
			// 
			// PurchasesPage
			// 
			this.PurchasesPage.Controls.Add(this.PurchaseDeleteBtn);
			this.PurchasesPage.Controls.Add(this.AddToPRBtn);
			this.PurchasesPage.Controls.Add(this.PurchaseLogRemoveFiltersBtn);
			this.PurchasesPage.Controls.Add(this.PurchasesLogGridView);
			this.PurchasesPage.Controls.Add(this.PurchaseLogFilterBtn);
			this.PurchasesPage.Controls.Add(this.PurchaseLogMonthLabel);
			this.PurchasesPage.Controls.Add(this.PurchaseLogMonth);
			this.PurchasesPage.Controls.Add(this.PurchaseLogTypeLabel);
			this.PurchasesPage.Controls.Add(this.PurchaseLogEndDateLabel);
			this.PurchasesPage.Controls.Add(this.PurchaseLogStartDateLabel);
			this.PurchasesPage.Controls.Add(this.PurchaseLogType);
			this.PurchasesPage.Controls.Add(this.PurchaseLogEndDate);
			this.PurchasesPage.Controls.Add(this.PurchaseLogStartDate);
			this.PurchasesPage.Location = new System.Drawing.Point(4, 28);
			this.PurchasesPage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.PurchasesPage.Name = "PurchasesPage";
			this.PurchasesPage.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.PurchasesPage.Size = new System.Drawing.Size(1378, 690);
			this.PurchasesPage.TabIndex = 1;
			this.PurchasesPage.Text = "Purchases";
			this.PurchasesPage.UseVisualStyleBackColor = true;
			// 
			// PurchaseDeleteBtn
			// 
			this.PurchaseDeleteBtn.Location = new System.Drawing.Point(1010, 71);
			this.PurchaseDeleteBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.PurchaseDeleteBtn.Name = "PurchaseDeleteBtn";
			this.PurchaseDeleteBtn.Size = new System.Drawing.Size(215, 46);
			this.PurchaseDeleteBtn.TabIndex = 20;
			this.PurchaseDeleteBtn.Text = "Delete Purchase";
			this.PurchaseDeleteBtn.UseVisualStyleBackColor = true;
			this.PurchaseDeleteBtn.Click += new System.EventHandler(this.DeletePurchaseBtn_Click);
			// 
			// AddToPRBtn
			// 
			this.AddToPRBtn.Location = new System.Drawing.Point(676, 71);
			this.AddToPRBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.AddToPRBtn.Name = "AddToPRBtn";
			this.AddToPRBtn.Size = new System.Drawing.Size(328, 46);
			this.AddToPRBtn.TabIndex = 19;
			this.AddToPRBtn.Text = "Add to Police Register";
			this.AddToPRBtn.UseVisualStyleBackColor = true;
			this.AddToPRBtn.Click += new System.EventHandler(this.AddToPRBtn_Click);
			// 
			// PurchaseLogRemoveFiltersBtn
			// 
			this.PurchaseLogRemoveFiltersBtn.Location = new System.Drawing.Point(342, 71);
			this.PurchaseLogRemoveFiltersBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.PurchaseLogRemoveFiltersBtn.Name = "PurchaseLogRemoveFiltersBtn";
			this.PurchaseLogRemoveFiltersBtn.Size = new System.Drawing.Size(328, 46);
			this.PurchaseLogRemoveFiltersBtn.TabIndex = 18;
			this.PurchaseLogRemoveFiltersBtn.Text = "Remove Filters";
			this.PurchaseLogRemoveFiltersBtn.UseVisualStyleBackColor = true;
			this.PurchaseLogRemoveFiltersBtn.Click += new System.EventHandler(this.PurchaseLogRemoveFiltersBtn_Click);
			// 
			// PurchasesLogGridView
			// 
			this.PurchasesLogGridView.AllowUserToAddRows = false;
			this.PurchasesLogGridView.AllowUserToDeleteRows = false;
			this.PurchasesLogGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.PurchasesLogGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.PurchasesLogGridView.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
			this.PurchasesLogGridView.ColumnHeadersHeight = 29;
			this.PurchasesLogGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
			this.PurchasesLogGridView.Location = new System.Drawing.Point(8, 131);
			this.PurchasesLogGridView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.PurchasesLogGridView.Name = "PurchasesLogGridView";
			this.PurchasesLogGridView.ReadOnly = true;
			this.PurchasesLogGridView.RowHeadersWidth = 51;
			this.PurchasesLogGridView.RowTemplate.Height = 24;
			this.PurchasesLogGridView.Size = new System.Drawing.Size(1364, 557);
			this.PurchasesLogGridView.TabIndex = 17;
			// 
			// PurchaseLogFilterBtn
			// 
			this.PurchaseLogFilterBtn.Location = new System.Drawing.Point(8, 71);
			this.PurchaseLogFilterBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.PurchaseLogFilterBtn.Name = "PurchaseLogFilterBtn";
			this.PurchaseLogFilterBtn.Size = new System.Drawing.Size(328, 46);
			this.PurchaseLogFilterBtn.TabIndex = 16;
			this.PurchaseLogFilterBtn.Text = "Filter";
			this.PurchaseLogFilterBtn.UseVisualStyleBackColor = true;
			this.PurchaseLogFilterBtn.Click += new System.EventHandler(this.FilterPurchaseLogBtn_Click);
			// 
			// PurchaseLogMonthLabel
			// 
			this.PurchaseLogMonthLabel.AutoSize = true;
			this.PurchaseLogMonthLabel.Location = new System.Drawing.Point(8, 11);
			this.PurchaseLogMonthLabel.Name = "PurchaseLogMonthLabel";
			this.PurchaseLogMonthLabel.Size = new System.Drawing.Size(54, 19);
			this.PurchaseLogMonthLabel.TabIndex = 15;
			this.PurchaseLogMonthLabel.Text = "Month";
			// 
			// PurchaseLogMonth
			// 
			this.PurchaseLogMonth.DropDownHeight = 300;
			this.PurchaseLogMonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.PurchaseLogMonth.FormattingEnabled = true;
			this.PurchaseLogMonth.IntegralHeight = false;
			this.PurchaseLogMonth.ItemHeight = 19;
			this.PurchaseLogMonth.Location = new System.Drawing.Point(8, 36);
			this.PurchaseLogMonth.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.PurchaseLogMonth.Name = "PurchaseLogMonth";
			this.PurchaseLogMonth.Size = new System.Drawing.Size(328, 27);
			this.PurchaseLogMonth.TabIndex = 14;
			this.PurchaseLogMonth.SelectedIndexChanged += new System.EventHandler(this.PurchaseLogMonth_SelectedIndexChanged);
			// 
			// PurchaseLogTypeLabel
			// 
			this.PurchaseLogTypeLabel.AutoSize = true;
			this.PurchaseLogTypeLabel.Location = new System.Drawing.Point(1006, 15);
			this.PurchaseLogTypeLabel.Name = "PurchaseLogTypeLabel";
			this.PurchaseLogTypeLabel.Size = new System.Drawing.Size(45, 19);
			this.PurchaseLogTypeLabel.TabIndex = 13;
			this.PurchaseLogTypeLabel.Text = "Type";
			// 
			// PurchaseLogEndDateLabel
			// 
			this.PurchaseLogEndDateLabel.AutoSize = true;
			this.PurchaseLogEndDateLabel.Location = new System.Drawing.Point(672, 11);
			this.PurchaseLogEndDateLabel.Name = "PurchaseLogEndDateLabel";
			this.PurchaseLogEndDateLabel.Size = new System.Drawing.Size(81, 19);
			this.PurchaseLogEndDateLabel.TabIndex = 12;
			this.PurchaseLogEndDateLabel.Text = "End Date";
			// 
			// PurchaseLogStartDateLabel
			// 
			this.PurchaseLogStartDateLabel.AutoSize = true;
			this.PurchaseLogStartDateLabel.Location = new System.Drawing.Point(338, 15);
			this.PurchaseLogStartDateLabel.Name = "PurchaseLogStartDateLabel";
			this.PurchaseLogStartDateLabel.Size = new System.Drawing.Size(99, 19);
			this.PurchaseLogStartDateLabel.TabIndex = 11;
			this.PurchaseLogStartDateLabel.Text = "Start Date";
			// 
			// PurchaseLogType
			// 
			this.PurchaseLogType.DropDownHeight = 300;
			this.PurchaseLogType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.PurchaseLogType.FormattingEnabled = true;
			this.PurchaseLogType.IntegralHeight = false;
			this.PurchaseLogType.ItemHeight = 19;
			this.PurchaseLogType.Location = new System.Drawing.Point(1010, 36);
			this.PurchaseLogType.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.PurchaseLogType.Name = "PurchaseLogType";
			this.PurchaseLogType.Size = new System.Drawing.Size(216, 27);
			this.PurchaseLogType.TabIndex = 10;
			// 
			// PurchaseLogEndDate
			// 
			this.PurchaseLogEndDate.DropDownHeight = 300;
			this.PurchaseLogEndDate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.PurchaseLogEndDate.FormattingEnabled = true;
			this.PurchaseLogEndDate.IntegralHeight = false;
			this.PurchaseLogEndDate.ItemHeight = 19;
			this.PurchaseLogEndDate.Location = new System.Drawing.Point(676, 36);
			this.PurchaseLogEndDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.PurchaseLogEndDate.Name = "PurchaseLogEndDate";
			this.PurchaseLogEndDate.Size = new System.Drawing.Size(328, 27);
			this.PurchaseLogEndDate.TabIndex = 9;
			// 
			// PurchaseLogStartDate
			// 
			this.PurchaseLogStartDate.DropDownHeight = 300;
			this.PurchaseLogStartDate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.PurchaseLogStartDate.FormattingEnabled = true;
			this.PurchaseLogStartDate.IntegralHeight = false;
			this.PurchaseLogStartDate.ItemHeight = 19;
			this.PurchaseLogStartDate.Location = new System.Drawing.Point(342, 36);
			this.PurchaseLogStartDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.PurchaseLogStartDate.Name = "PurchaseLogStartDate";
			this.PurchaseLogStartDate.Size = new System.Drawing.Size(328, 27);
			this.PurchaseLogStartDate.TabIndex = 8;
			// 
			// SalesPage
			// 
			this.SalesPage.Controls.Add(this.SalesLogDeleteBtn);
			this.SalesPage.Controls.Add(this.SaleAmount);
			this.SalesPage.Controls.Add(this.SaleQuantity);
			this.SalesPage.Controls.Add(this.SaleDate);
			this.SalesPage.Controls.Add(this.SalesLogRemoveFiltersBtn);
			this.SalesPage.Controls.Add(this.SalesLogFilterBtn);
			this.SalesPage.Controls.Add(this.SalesLogMonthLabel);
			this.SalesPage.Controls.Add(this.SalesLogMonth);
			this.SalesPage.Controls.Add(this.SaleItemTypeLabel);
			this.SalesPage.Controls.Add(this.SalesLogEndDateLabel);
			this.SalesPage.Controls.Add(this.SalesLogStartDateLabel);
			this.SalesPage.Controls.Add(this.SalesLogType);
			this.SalesPage.Controls.Add(this.SalesLogEndDate);
			this.SalesPage.Controls.Add(this.SalesLogStartDate);
			this.SalesPage.Controls.Add(this.SalesLogGridView);
			this.SalesPage.Controls.Add(this.SalesClearBtn);
			this.SalesPage.Controls.Add(this.SaleAddBtn);
			this.SalesPage.Controls.Add(this.SaleAmountLabel);
			this.SalesPage.Controls.Add(this.SaleType);
			this.SalesPage.Controls.Add(this.SaleCompanyName);
			this.SalesPage.Controls.Add(this.SaleTypeLabel);
			this.SalesPage.Controls.Add(this.SaleQuantityLabel);
			this.SalesPage.Controls.Add(this.SaleCompanyLabel);
			this.SalesPage.Controls.Add(this.SaleDateLabel);
			this.SalesPage.Location = new System.Drawing.Point(4, 28);
			this.SalesPage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.SalesPage.Name = "SalesPage";
			this.SalesPage.Size = new System.Drawing.Size(1378, 690);
			this.SalesPage.TabIndex = 2;
			this.SalesPage.Text = "Sales";
			this.SalesPage.UseVisualStyleBackColor = true;
			// 
			// SalesLogDeleteBtn
			// 
			this.SalesLogDeleteBtn.Location = new System.Drawing.Point(1125, 74);
			this.SalesLogDeleteBtn.Margin = new System.Windows.Forms.Padding(2);
			this.SalesLogDeleteBtn.Name = "SalesLogDeleteBtn";
			this.SalesLogDeleteBtn.Size = new System.Drawing.Size(295, 37);
			this.SalesLogDeleteBtn.TabIndex = 32;
			this.SalesLogDeleteBtn.Text = "Delete Sale";
			this.SalesLogDeleteBtn.UseVisualStyleBackColor = true;
			this.SalesLogDeleteBtn.Click += new System.EventHandler(this.SalesLogDeleteBtn_Click);
			// 
			// SaleAmount
			// 
			this.SaleAmount.DecimalPlaces = 2;
			this.SaleAmount.Location = new System.Drawing.Point(129, 246);
			this.SaleAmount.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.SaleAmount.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
			this.SaleAmount.Name = "SaleAmount";
			this.SaleAmount.Size = new System.Drawing.Size(118, 26);
			this.SaleAmount.TabIndex = 31;
			this.SaleAmount.ThousandsSeparator = true;
			// 
			// SaleQuantity
			// 
			this.SaleQuantity.DecimalPlaces = 2;
			this.SaleQuantity.Location = new System.Drawing.Point(129, 160);
			this.SaleQuantity.Margin = new System.Windows.Forms.Padding(2);
			this.SaleQuantity.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
			this.SaleQuantity.Name = "SaleQuantity";
			this.SaleQuantity.Size = new System.Drawing.Size(118, 26);
			this.SaleQuantity.TabIndex = 30;
			this.SaleQuantity.ThousandsSeparator = true;
			// 
			// SaleDate
			// 
			this.SaleDate.CalendarFont = new System.Drawing.Font("Consolas", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.SaleDate.Location = new System.Drawing.Point(129, 38);
			this.SaleDate.Margin = new System.Windows.Forms.Padding(2);
			this.SaleDate.MaxDate = new System.DateTime(2028, 7, 1, 0, 0, 0, 0);
			this.SaleDate.MinDate = new System.DateTime(2019, 1, 1, 0, 0, 0, 0);
			this.SaleDate.Name = "SaleDate";
			this.SaleDate.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.SaleDate.Size = new System.Drawing.Size(331, 26);
			this.SaleDate.TabIndex = 0;
			this.SaleDate.TabStop = false;
			this.SaleDate.Value = new System.DateTime(2021, 1, 22, 0, 0, 0, 0);
			// 
			// SalesLogRemoveFiltersBtn
			// 
			this.SalesLogRemoveFiltersBtn.Location = new System.Drawing.Point(820, 74);
			this.SalesLogRemoveFiltersBtn.Margin = new System.Windows.Forms.Padding(2);
			this.SalesLogRemoveFiltersBtn.Name = "SalesLogRemoveFiltersBtn";
			this.SalesLogRemoveFiltersBtn.Size = new System.Drawing.Size(296, 37);
			this.SalesLogRemoveFiltersBtn.TabIndex = 28;
			this.SalesLogRemoveFiltersBtn.Text = "Remove Filters";
			this.SalesLogRemoveFiltersBtn.UseVisualStyleBackColor = true;
			this.SalesLogRemoveFiltersBtn.Click += new System.EventHandler(this.SalesLogRemoveFiltersBtn_Click);
			// 
			// SalesLogFilterBtn
			// 
			this.SalesLogFilterBtn.Location = new System.Drawing.Point(515, 74);
			this.SalesLogFilterBtn.Margin = new System.Windows.Forms.Padding(2);
			this.SalesLogFilterBtn.Name = "SalesLogFilterBtn";
			this.SalesLogFilterBtn.Size = new System.Drawing.Size(295, 37);
			this.SalesLogFilterBtn.TabIndex = 27;
			this.SalesLogFilterBtn.Text = "Filter";
			this.SalesLogFilterBtn.UseVisualStyleBackColor = true;
			this.SalesLogFilterBtn.Click += new System.EventHandler(this.FilterSalesLogBtn_Click);
			// 
			// SalesLogMonthLabel
			// 
			this.SalesLogMonthLabel.AutoSize = true;
			this.SalesLogMonthLabel.Location = new System.Drawing.Point(513, 15);
			this.SalesLogMonthLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.SalesLogMonthLabel.Name = "SalesLogMonthLabel";
			this.SalesLogMonthLabel.Size = new System.Drawing.Size(54, 19);
			this.SalesLogMonthLabel.TabIndex = 26;
			this.SalesLogMonthLabel.Text = "Month";
			// 
			// SalesLogMonth
			// 
			this.SalesLogMonth.DropDownHeight = 300;
			this.SalesLogMonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.SalesLogMonth.FormattingEnabled = true;
			this.SalesLogMonth.IntegralHeight = false;
			this.SalesLogMonth.ItemHeight = 19;
			this.SalesLogMonth.Location = new System.Drawing.Point(515, 37);
			this.SalesLogMonth.Margin = new System.Windows.Forms.Padding(2);
			this.SalesLogMonth.Name = "SalesLogMonth";
			this.SalesLogMonth.Size = new System.Drawing.Size(296, 27);
			this.SalesLogMonth.TabIndex = 25;
			this.SalesLogMonth.SelectedIndexChanged += new System.EventHandler(this.SalesLogMonth_SelectedIndexChanged);
			// 
			// SaleItemTypeLabel
			// 
			this.SaleItemTypeLabel.AutoSize = true;
			this.SaleItemTypeLabel.Location = new System.Drawing.Point(1426, 16);
			this.SaleItemTypeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.SaleItemTypeLabel.Name = "SaleItemTypeLabel";
			this.SaleItemTypeLabel.Size = new System.Drawing.Size(45, 19);
			this.SaleItemTypeLabel.TabIndex = 24;
			this.SaleItemTypeLabel.Text = "Type";
			// 
			// SalesLogEndDateLabel
			// 
			this.SalesLogEndDateLabel.AutoSize = true;
			this.SalesLogEndDateLabel.Location = new System.Drawing.Point(1123, 16);
			this.SalesLogEndDateLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.SalesLogEndDateLabel.Name = "SalesLogEndDateLabel";
			this.SalesLogEndDateLabel.Size = new System.Drawing.Size(81, 19);
			this.SalesLogEndDateLabel.TabIndex = 23;
			this.SalesLogEndDateLabel.Text = "End Date";
			// 
			// SalesLogStartDateLabel
			// 
			this.SalesLogStartDateLabel.AutoSize = true;
			this.SalesLogStartDateLabel.Location = new System.Drawing.Point(817, 15);
			this.SalesLogStartDateLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.SalesLogStartDateLabel.Name = "SalesLogStartDateLabel";
			this.SalesLogStartDateLabel.Size = new System.Drawing.Size(99, 19);
			this.SalesLogStartDateLabel.TabIndex = 22;
			this.SalesLogStartDateLabel.Text = "Start Date";
			// 
			// SalesLogType
			// 
			this.SalesLogType.DropDownHeight = 300;
			this.SalesLogType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.SalesLogType.FormattingEnabled = true;
			this.SalesLogType.IntegralHeight = false;
			this.SalesLogType.ItemHeight = 19;
			this.SalesLogType.Location = new System.Drawing.Point(1430, 37);
			this.SalesLogType.Margin = new System.Windows.Forms.Padding(2);
			this.SalesLogType.Name = "SalesLogType";
			this.SalesLogType.Size = new System.Drawing.Size(155, 27);
			this.SalesLogType.TabIndex = 21;
			// 
			// SalesLogEndDate
			// 
			this.SalesLogEndDate.DropDownHeight = 300;
			this.SalesLogEndDate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.SalesLogEndDate.FormattingEnabled = true;
			this.SalesLogEndDate.IntegralHeight = false;
			this.SalesLogEndDate.ItemHeight = 19;
			this.SalesLogEndDate.Location = new System.Drawing.Point(1125, 37);
			this.SalesLogEndDate.Margin = new System.Windows.Forms.Padding(2);
			this.SalesLogEndDate.Name = "SalesLogEndDate";
			this.SalesLogEndDate.Size = new System.Drawing.Size(296, 27);
			this.SalesLogEndDate.TabIndex = 20;
			// 
			// SalesLogStartDate
			// 
			this.SalesLogStartDate.DropDownHeight = 300;
			this.SalesLogStartDate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.SalesLogStartDate.FormattingEnabled = true;
			this.SalesLogStartDate.IntegralHeight = false;
			this.SalesLogStartDate.ItemHeight = 19;
			this.SalesLogStartDate.Location = new System.Drawing.Point(820, 37);
			this.SalesLogStartDate.Margin = new System.Windows.Forms.Padding(2);
			this.SalesLogStartDate.Name = "SalesLogStartDate";
			this.SalesLogStartDate.Size = new System.Drawing.Size(296, 27);
			this.SalesLogStartDate.TabIndex = 19;
			// 
			// SalesLogGridView
			// 
			this.SalesLogGridView.AllowUserToAddRows = false;
			this.SalesLogGridView.AllowUserToDeleteRows = false;
			this.SalesLogGridView.AllowUserToResizeColumns = false;
			this.SalesLogGridView.AllowUserToResizeRows = false;
			this.SalesLogGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.SalesLogGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.SalesLogGridView.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
			this.SalesLogGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.SalesLogGridView.Location = new System.Drawing.Point(516, 121);
			this.SalesLogGridView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.SalesLogGridView.Name = "SalesLogGridView";
			this.SalesLogGridView.ReadOnly = true;
			this.SalesLogGridView.RowHeadersWidth = 51;
			this.SalesLogGridView.RowTemplate.Height = 24;
			this.SalesLogGridView.Size = new System.Drawing.Size(860, 567);
			this.SalesLogGridView.TabIndex = 15;
			// 
			// SalesClearBtn
			// 
			this.SalesClearBtn.Location = new System.Drawing.Point(206, 334);
			this.SalesClearBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.SalesClearBtn.Name = "SalesClearBtn";
			this.SalesClearBtn.Size = new System.Drawing.Size(140, 46);
			this.SalesClearBtn.TabIndex = 14;
			this.SalesClearBtn.Text = "Clear";
			this.SalesClearBtn.UseVisualStyleBackColor = true;
			this.SalesClearBtn.Click += new System.EventHandler(this.ClearSalesFields_Click);
			// 
			// SaleAddBtn
			// 
			this.SaleAddBtn.Location = new System.Drawing.Point(12, 334);
			this.SaleAddBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.SaleAddBtn.Name = "SaleAddBtn";
			this.SaleAddBtn.Size = new System.Drawing.Size(140, 46);
			this.SaleAddBtn.TabIndex = 13;
			this.SaleAddBtn.Text = "Add Sale";
			this.SaleAddBtn.UseVisualStyleBackColor = true;
			this.SaleAddBtn.Click += new System.EventHandler(this.AddSaleBtn_Click);
			// 
			// SaleAmountLabel
			// 
			this.SaleAmountLabel.AutoSize = true;
			this.SaleAmountLabel.Location = new System.Drawing.Point(18, 248);
			this.SaleAmountLabel.Name = "SaleAmountLabel";
			this.SaleAmountLabel.Size = new System.Drawing.Size(63, 19);
			this.SaleAmountLabel.TabIndex = 12;
			this.SaleAmountLabel.Text = "Amount";
			// 
			// SaleType
			// 
			this.SaleType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.SaleType.FormattingEnabled = true;
			this.SaleType.Location = new System.Drawing.Point(129, 202);
			this.SaleType.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.SaleType.Name = "SaleType";
			this.SaleType.Size = new System.Drawing.Size(177, 27);
			this.SaleType.TabIndex = 10;
			// 
			// SaleCompanyName
			// 
			this.SaleCompanyName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.SaleCompanyName.FormattingEnabled = true;
			this.SaleCompanyName.Location = new System.Drawing.Point(129, 118);
			this.SaleCompanyName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.SaleCompanyName.Name = "SaleCompanyName";
			this.SaleCompanyName.Size = new System.Drawing.Size(331, 27);
			this.SaleCompanyName.TabIndex = 9;
			// 
			// SaleTypeLabel
			// 
			this.SaleTypeLabel.AutoSize = true;
			this.SaleTypeLabel.Location = new System.Drawing.Point(18, 205);
			this.SaleTypeLabel.Name = "SaleTypeLabel";
			this.SaleTypeLabel.Size = new System.Drawing.Size(45, 19);
			this.SaleTypeLabel.TabIndex = 7;
			this.SaleTypeLabel.Text = "Type";
			// 
			// SaleQuantityLabel
			// 
			this.SaleQuantityLabel.AutoSize = true;
			this.SaleQuantityLabel.Location = new System.Drawing.Point(18, 162);
			this.SaleQuantityLabel.Name = "SaleQuantityLabel";
			this.SaleQuantityLabel.Size = new System.Drawing.Size(81, 19);
			this.SaleQuantityLabel.TabIndex = 6;
			this.SaleQuantityLabel.Text = "Quantity";
			// 
			// SaleCompanyLabel
			// 
			this.SaleCompanyLabel.AutoSize = true;
			this.SaleCompanyLabel.Location = new System.Drawing.Point(18, 121);
			this.SaleCompanyLabel.Name = "SaleCompanyLabel";
			this.SaleCompanyLabel.Size = new System.Drawing.Size(72, 19);
			this.SaleCompanyLabel.TabIndex = 5;
			this.SaleCompanyLabel.Text = "Company";
			// 
			// SaleDateLabel
			// 
			this.SaleDateLabel.AutoSize = true;
			this.SaleDateLabel.Location = new System.Drawing.Point(18, 40);
			this.SaleDateLabel.Name = "SaleDateLabel";
			this.SaleDateLabel.Size = new System.Drawing.Size(45, 19);
			this.SaleDateLabel.TabIndex = 4;
			this.SaleDateLabel.Text = "Date";
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
			this.Inventory.Location = new System.Drawing.Point(4, 28);
			this.Inventory.Margin = new System.Windows.Forms.Padding(2);
			this.Inventory.Name = "Inventory";
			this.Inventory.Size = new System.Drawing.Size(1378, 690);
			this.Inventory.TabIndex = 7;
			this.Inventory.Text = "Inventory";
			this.Inventory.UseVisualStyleBackColor = true;
			// 
			// label63
			// 
			this.label63.AutoSize = true;
			this.label63.Location = new System.Drawing.Point(31, 21);
			this.label63.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label63.Name = "label63";
			this.label63.Size = new System.Drawing.Size(162, 19);
			this.label63.TabIndex = 12;
			this.label63.Text = "Summed/Not Summed";
			// 
			// label62
			// 
			this.label62.AutoSize = true;
			this.label62.Location = new System.Drawing.Point(1171, 21);
			this.label62.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label62.Name = "label62";
			this.label62.Size = new System.Drawing.Size(45, 19);
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
			this.InventoryLogType.Location = new System.Drawing.Point(1174, 42);
			this.InventoryLogType.Margin = new System.Windows.Forms.Padding(2);
			this.InventoryLogType.Name = "InventoryLogType";
			this.InventoryLogType.Size = new System.Drawing.Size(164, 27);
			this.InventoryLogType.TabIndex = 10;
			// 
			// InvetorySummedOrNot
			// 
			this.InvetorySummedOrNot.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.InvetorySummedOrNot.FormattingEnabled = true;
			this.InvetorySummedOrNot.Location = new System.Drawing.Point(34, 42);
			this.InvetorySummedOrNot.Margin = new System.Windows.Forms.Padding(2);
			this.InvetorySummedOrNot.Name = "InvetorySummedOrNot";
			this.InvetorySummedOrNot.Size = new System.Drawing.Size(213, 27);
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
			this.InventoryLogGridView.Location = new System.Drawing.Point(6, 152);
			this.InventoryLogGridView.Margin = new System.Windows.Forms.Padding(2);
			this.InventoryLogGridView.Name = "InventoryLogGridView";
			this.InventoryLogGridView.ReadOnly = true;
			this.InventoryLogGridView.RowHeadersWidth = 51;
			this.InventoryLogGridView.RowTemplate.Height = 24;
			this.InventoryLogGridView.Size = new System.Drawing.Size(1366, 535);
			this.InventoryLogGridView.TabIndex = 8;
			// 
			// InventoryLogRmvFilterBtn
			// 
			this.InventoryLogRmvFilterBtn.Location = new System.Drawing.Point(614, 92);
			this.InventoryLogRmvFilterBtn.Margin = new System.Windows.Forms.Padding(2);
			this.InventoryLogRmvFilterBtn.Name = "InventoryLogRmvFilterBtn";
			this.InventoryLogRmvFilterBtn.Size = new System.Drawing.Size(259, 42);
			this.InventoryLogRmvFilterBtn.TabIndex = 7;
			this.InventoryLogRmvFilterBtn.Text = "Remove Filter";
			this.InventoryLogRmvFilterBtn.UseVisualStyleBackColor = true;
			this.InventoryLogRmvFilterBtn.Click += new System.EventHandler(this.InventoryLogRmvFilterBtn_Click);
			// 
			// InventoryLogFilterBtn
			// 
			this.InventoryLogFilterBtn.Location = new System.Drawing.Point(333, 92);
			this.InventoryLogFilterBtn.Margin = new System.Windows.Forms.Padding(2);
			this.InventoryLogFilterBtn.Name = "InventoryLogFilterBtn";
			this.InventoryLogFilterBtn.Size = new System.Drawing.Size(260, 42);
			this.InventoryLogFilterBtn.TabIndex = 6;
			this.InventoryLogFilterBtn.Text = "Filter";
			this.InventoryLogFilterBtn.UseVisualStyleBackColor = true;
			this.InventoryLogFilterBtn.Click += new System.EventHandler(this.InventoryLogFilterBtn_Click);
			// 
			// label60
			// 
			this.label60.AutoSize = true;
			this.label60.Location = new System.Drawing.Point(610, 21);
			this.label60.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label60.Name = "label60";
			this.label60.Size = new System.Drawing.Size(99, 19);
			this.label60.TabIndex = 5;
			this.label60.Text = "Start Date";
			// 
			// label59
			// 
			this.label59.AutoSize = true;
			this.label59.Location = new System.Drawing.Point(890, 21);
			this.label59.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label59.Name = "label59";
			this.label59.Size = new System.Drawing.Size(81, 19);
			this.label59.TabIndex = 4;
			this.label59.Text = "End Date";
			// 
			// label58
			// 
			this.label58.AutoSize = true;
			this.label58.Location = new System.Drawing.Point(330, 21);
			this.label58.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label58.Name = "label58";
			this.label58.Size = new System.Drawing.Size(54, 19);
			this.label58.TabIndex = 3;
			this.label58.Text = "Month";
			// 
			// InventoryLogEndDate
			// 
			this.InventoryLogEndDate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.InventoryLogEndDate.FormattingEnabled = true;
			this.InventoryLogEndDate.Location = new System.Drawing.Point(893, 42);
			this.InventoryLogEndDate.Margin = new System.Windows.Forms.Padding(2);
			this.InventoryLogEndDate.Name = "InventoryLogEndDate";
			this.InventoryLogEndDate.Size = new System.Drawing.Size(261, 27);
			this.InventoryLogEndDate.TabIndex = 2;
			// 
			// InventoryLogStartDate
			// 
			this.InventoryLogStartDate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.InventoryLogStartDate.FormattingEnabled = true;
			this.InventoryLogStartDate.Location = new System.Drawing.Point(614, 42);
			this.InventoryLogStartDate.Margin = new System.Windows.Forms.Padding(2);
			this.InventoryLogStartDate.Name = "InventoryLogStartDate";
			this.InventoryLogStartDate.Size = new System.Drawing.Size(260, 27);
			this.InventoryLogStartDate.TabIndex = 1;
			// 
			// InventoryLogMonth
			// 
			this.InventoryLogMonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.InventoryLogMonth.FormattingEnabled = true;
			this.InventoryLogMonth.Location = new System.Drawing.Point(333, 42);
			this.InventoryLogMonth.Margin = new System.Windows.Forms.Padding(2);
			this.InventoryLogMonth.Name = "InventoryLogMonth";
			this.InventoryLogMonth.Size = new System.Drawing.Size(261, 27);
			this.InventoryLogMonth.TabIndex = 0;
			this.InventoryLogMonth.SelectedIndexChanged += new System.EventHandler(this.InventoryLogMonth_SelectedIndexChanged);
			// 
			// Expenses
			// 
			this.Expenses.Controls.Add(this.EditFixedExpensesBtn);
			this.Expenses.Controls.Add(this.ExpensesDeleteBtn);
			this.Expenses.Controls.Add(this.ExpenseAmount);
			this.Expenses.Controls.Add(this.ExpenseDescription);
			this.Expenses.Controls.Add(this.ExpenseDate);
			this.Expenses.Controls.Add(this.ExpensesLogRemoveFiltersBtn);
			this.Expenses.Controls.Add(this.ExpensesLogFilterBtn);
			this.Expenses.Controls.Add(this.ExpensesLogMonthsLabel);
			this.Expenses.Controls.Add(this.ExpensesLogMonths);
			this.Expenses.Controls.Add(this.ExpensesLogEndDateLabel);
			this.Expenses.Controls.Add(this.ExpensesLogStartDateLabel);
			this.Expenses.Controls.Add(this.ExpensesLogEndDate);
			this.Expenses.Controls.Add(this.ExpensesLogStartDate);
			this.Expenses.Controls.Add(this.ExpensesLogGridView);
			this.Expenses.Controls.Add(this.ExpenseClearBtn);
			this.Expenses.Controls.Add(this.ExpenseAddBtn);
			this.Expenses.Controls.Add(this.ExpenseAmountLabel);
			this.Expenses.Controls.Add(this.ExpenseDescriptionLabel);
			this.Expenses.Controls.Add(this.ExpenseDateLabel);
			this.Expenses.Location = new System.Drawing.Point(4, 28);
			this.Expenses.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.Expenses.Name = "Expenses";
			this.Expenses.Size = new System.Drawing.Size(1378, 690);
			this.Expenses.TabIndex = 5;
			this.Expenses.Text = "Expenses";
			this.Expenses.UseVisualStyleBackColor = true;
			// 
			// EditFixedExpensesBtn
			// 
			this.EditFixedExpensesBtn.Location = new System.Drawing.Point(16, 364);
			this.EditFixedExpensesBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.EditFixedExpensesBtn.Name = "EditFixedExpensesBtn";
			this.EditFixedExpensesBtn.Size = new System.Drawing.Size(214, 46);
			this.EditFixedExpensesBtn.TabIndex = 54;
			this.EditFixedExpensesBtn.Text = "Edit Fixed Expenses";
			this.EditFixedExpensesBtn.UseVisualStyleBackColor = true;
			this.EditFixedExpensesBtn.Click += new System.EventHandler(this.EditFixedExpensesBtn_Click);
			// 
			// ExpensesDeleteBtn
			// 
			this.ExpensesDeleteBtn.Location = new System.Drawing.Point(1156, 79);
			this.ExpensesDeleteBtn.Margin = new System.Windows.Forms.Padding(2);
			this.ExpensesDeleteBtn.Name = "ExpensesDeleteBtn";
			this.ExpensesDeleteBtn.Size = new System.Drawing.Size(302, 36);
			this.ExpensesDeleteBtn.TabIndex = 53;
			this.ExpensesDeleteBtn.Text = "Delete Expense";
			this.ExpensesDeleteBtn.UseVisualStyleBackColor = true;
			this.ExpensesDeleteBtn.Click += new System.EventHandler(this.DeleteExpenseBtn_Click);
			// 
			// ExpenseAmount
			// 
			this.ExpenseAmount.DecimalPlaces = 2;
			this.ExpenseAmount.Location = new System.Drawing.Point(141, 140);
			this.ExpenseAmount.Maximum = new decimal(new int[] {
            200000,
            0,
            0,
            0});
			this.ExpenseAmount.Name = "ExpenseAmount";
			this.ExpenseAmount.Size = new System.Drawing.Size(178, 26);
			this.ExpenseAmount.TabIndex = 51;
			// 
			// ExpenseDescription
			// 
			this.ExpenseDescription.Location = new System.Drawing.Point(141, 89);
			this.ExpenseDescription.Margin = new System.Windows.Forms.Padding(2);
			this.ExpenseDescription.Name = "ExpenseDescription";
			this.ExpenseDescription.Size = new System.Drawing.Size(338, 26);
			this.ExpenseDescription.TabIndex = 50;
			this.ExpenseDescription.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ExpenseDescription_KeyPress);
			// 
			// ExpenseDate
			// 
			this.ExpenseDate.CalendarFont = new System.Drawing.Font("Consolas", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ExpenseDate.Location = new System.Drawing.Point(141, 41);
			this.ExpenseDate.Margin = new System.Windows.Forms.Padding(2);
			this.ExpenseDate.MaxDate = new System.DateTime(2028, 7, 1, 0, 0, 0, 0);
			this.ExpenseDate.MinDate = new System.DateTime(2019, 1, 1, 0, 0, 0, 0);
			this.ExpenseDate.Name = "ExpenseDate";
			this.ExpenseDate.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.ExpenseDate.Size = new System.Drawing.Size(338, 26);
			this.ExpenseDate.TabIndex = 32;
			this.ExpenseDate.TabStop = false;
			this.ExpenseDate.Value = new System.DateTime(2021, 1, 22, 0, 0, 0, 0);
			// 
			// ExpensesLogRemoveFiltersBtn
			// 
			this.ExpensesLogRemoveFiltersBtn.Location = new System.Drawing.Point(845, 78);
			this.ExpensesLogRemoveFiltersBtn.Margin = new System.Windows.Forms.Padding(2);
			this.ExpensesLogRemoveFiltersBtn.Name = "ExpensesLogRemoveFiltersBtn";
			this.ExpensesLogRemoveFiltersBtn.Size = new System.Drawing.Size(302, 37);
			this.ExpensesLogRemoveFiltersBtn.TabIndex = 49;
			this.ExpensesLogRemoveFiltersBtn.Text = "Remove Filters";
			this.ExpensesLogRemoveFiltersBtn.UseVisualStyleBackColor = true;
			this.ExpensesLogRemoveFiltersBtn.Click += new System.EventHandler(this.ExpensesLogRemoveFiltersBtn_Click);
			// 
			// ExpensesLogFilterBtn
			// 
			this.ExpensesLogFilterBtn.Location = new System.Drawing.Point(535, 78);
			this.ExpensesLogFilterBtn.Margin = new System.Windows.Forms.Padding(2);
			this.ExpensesLogFilterBtn.Name = "ExpensesLogFilterBtn";
			this.ExpensesLogFilterBtn.Size = new System.Drawing.Size(302, 37);
			this.ExpensesLogFilterBtn.TabIndex = 48;
			this.ExpensesLogFilterBtn.Text = "Filter";
			this.ExpensesLogFilterBtn.UseVisualStyleBackColor = true;
			this.ExpensesLogFilterBtn.Click += new System.EventHandler(this.ExpensesLogFilterBtn_Click);
			// 
			// ExpensesLogMonthsLabel
			// 
			this.ExpensesLogMonthsLabel.AutoSize = true;
			this.ExpensesLogMonthsLabel.Location = new System.Drawing.Point(531, 18);
			this.ExpensesLogMonthsLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.ExpensesLogMonthsLabel.Name = "ExpensesLogMonthsLabel";
			this.ExpensesLogMonthsLabel.Size = new System.Drawing.Size(54, 19);
			this.ExpensesLogMonthsLabel.TabIndex = 47;
			this.ExpensesLogMonthsLabel.Text = "Month";
			// 
			// ExpensesLogMonths
			// 
			this.ExpensesLogMonths.DropDownHeight = 300;
			this.ExpensesLogMonths.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.ExpensesLogMonths.FormattingEnabled = true;
			this.ExpensesLogMonths.IntegralHeight = false;
			this.ExpensesLogMonths.ItemHeight = 19;
			this.ExpensesLogMonths.Location = new System.Drawing.Point(535, 40);
			this.ExpensesLogMonths.Margin = new System.Windows.Forms.Padding(2);
			this.ExpensesLogMonths.Name = "ExpensesLogMonths";
			this.ExpensesLogMonths.Size = new System.Drawing.Size(302, 27);
			this.ExpensesLogMonths.TabIndex = 46;
			this.ExpensesLogMonths.SelectedIndexChanged += new System.EventHandler(this.ExpensesLogMonth_SelectedIndexChanged);
			// 
			// ExpensesLogEndDateLabel
			// 
			this.ExpensesLogEndDateLabel.AutoSize = true;
			this.ExpensesLogEndDateLabel.Location = new System.Drawing.Point(1152, 19);
			this.ExpensesLogEndDateLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.ExpensesLogEndDateLabel.Name = "ExpensesLogEndDateLabel";
			this.ExpensesLogEndDateLabel.Size = new System.Drawing.Size(81, 19);
			this.ExpensesLogEndDateLabel.TabIndex = 45;
			this.ExpensesLogEndDateLabel.Text = "End Date";
			// 
			// ExpensesLogStartDateLabel
			// 
			this.ExpensesLogStartDateLabel.AutoSize = true;
			this.ExpensesLogStartDateLabel.Location = new System.Drawing.Point(841, 18);
			this.ExpensesLogStartDateLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.ExpensesLogStartDateLabel.Name = "ExpensesLogStartDateLabel";
			this.ExpensesLogStartDateLabel.Size = new System.Drawing.Size(99, 19);
			this.ExpensesLogStartDateLabel.TabIndex = 44;
			this.ExpensesLogStartDateLabel.Text = "Start Date";
			// 
			// ExpensesLogEndDate
			// 
			this.ExpensesLogEndDate.DropDownHeight = 300;
			this.ExpensesLogEndDate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.ExpensesLogEndDate.FormattingEnabled = true;
			this.ExpensesLogEndDate.IntegralHeight = false;
			this.ExpensesLogEndDate.ItemHeight = 19;
			this.ExpensesLogEndDate.Location = new System.Drawing.Point(1156, 40);
			this.ExpensesLogEndDate.Margin = new System.Windows.Forms.Padding(2);
			this.ExpensesLogEndDate.Name = "ExpensesLogEndDate";
			this.ExpensesLogEndDate.Size = new System.Drawing.Size(302, 27);
			this.ExpensesLogEndDate.TabIndex = 43;
			// 
			// ExpensesLogStartDate
			// 
			this.ExpensesLogStartDate.DropDownHeight = 300;
			this.ExpensesLogStartDate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.ExpensesLogStartDate.FormattingEnabled = true;
			this.ExpensesLogStartDate.IntegralHeight = false;
			this.ExpensesLogStartDate.ItemHeight = 19;
			this.ExpensesLogStartDate.Location = new System.Drawing.Point(845, 40);
			this.ExpensesLogStartDate.Margin = new System.Windows.Forms.Padding(2);
			this.ExpensesLogStartDate.Name = "ExpensesLogStartDate";
			this.ExpensesLogStartDate.Size = new System.Drawing.Size(302, 27);
			this.ExpensesLogStartDate.TabIndex = 42;
			// 
			// ExpensesLogGridView
			// 
			this.ExpensesLogGridView.AllowUserToAddRows = false;
			this.ExpensesLogGridView.AllowUserToResizeColumns = false;
			this.ExpensesLogGridView.AllowUserToResizeRows = false;
			this.ExpensesLogGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.ExpensesLogGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.ExpensesLogGridView.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
			this.ExpensesLogGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.ExpensesLogGridView.Location = new System.Drawing.Point(535, 128);
			this.ExpensesLogGridView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.ExpensesLogGridView.Name = "ExpensesLogGridView";
			this.ExpensesLogGridView.ReadOnly = true;
			this.ExpensesLogGridView.RowHeadersWidth = 51;
			this.ExpensesLogGridView.RowTemplate.Height = 24;
			this.ExpensesLogGridView.Size = new System.Drawing.Size(837, 560);
			this.ExpensesLogGridView.TabIndex = 41;
			// 
			// ExpenseClearBtn
			// 
			this.ExpenseClearBtn.Location = new System.Drawing.Point(286, 293);
			this.ExpenseClearBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.ExpenseClearBtn.Name = "ExpenseClearBtn";
			this.ExpenseClearBtn.Size = new System.Drawing.Size(140, 46);
			this.ExpenseClearBtn.TabIndex = 40;
			this.ExpenseClearBtn.Text = "Clear";
			this.ExpenseClearBtn.UseVisualStyleBackColor = true;
			this.ExpenseClearBtn.Click += new System.EventHandler(this.ClearExpenseFieldsBtn_Click);
			// 
			// ExpenseAddBtn
			// 
			this.ExpenseAddBtn.Location = new System.Drawing.Point(15, 293);
			this.ExpenseAddBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.ExpenseAddBtn.Name = "ExpenseAddBtn";
			this.ExpenseAddBtn.Size = new System.Drawing.Size(214, 46);
			this.ExpenseAddBtn.TabIndex = 39;
			this.ExpenseAddBtn.Text = "Add Expense";
			this.ExpenseAddBtn.UseVisualStyleBackColor = true;
			this.ExpenseAddBtn.Click += new System.EventHandler(this.AddExpenseBtn_Click);
			// 
			// ExpenseAmountLabel
			// 
			this.ExpenseAmountLabel.AutoSize = true;
			this.ExpenseAmountLabel.Location = new System.Drawing.Point(12, 142);
			this.ExpenseAmountLabel.Name = "ExpenseAmountLabel";
			this.ExpenseAmountLabel.Size = new System.Drawing.Size(63, 19);
			this.ExpenseAmountLabel.TabIndex = 38;
			this.ExpenseAmountLabel.Text = "Amount";
			// 
			// ExpenseDescriptionLabel
			// 
			this.ExpenseDescriptionLabel.AutoSize = true;
			this.ExpenseDescriptionLabel.Location = new System.Drawing.Point(12, 92);
			this.ExpenseDescriptionLabel.Name = "ExpenseDescriptionLabel";
			this.ExpenseDescriptionLabel.Size = new System.Drawing.Size(108, 19);
			this.ExpenseDescriptionLabel.TabIndex = 34;
			this.ExpenseDescriptionLabel.Text = "Description";
			// 
			// ExpenseDateLabel
			// 
			this.ExpenseDateLabel.AutoSize = true;
			this.ExpenseDateLabel.Location = new System.Drawing.Point(12, 43);
			this.ExpenseDateLabel.Name = "ExpenseDateLabel";
			this.ExpenseDateLabel.Size = new System.Drawing.Size(45, 19);
			this.ExpenseDateLabel.TabIndex = 33;
			this.ExpenseDateLabel.Text = "Date";
			// 
			// WagesNewEmployee
			// 
			this.WagesNewEmployee.Controls.Add(this.WagesEndDateLabel);
			this.WagesNewEmployee.Controls.Add(this.WagesLogRemoveFilterBtn);
			this.WagesNewEmployee.Controls.Add(this.WageLogEndDate);
			this.WagesNewEmployee.Controls.Add(this.WagesMonthLabel);
			this.WagesNewEmployee.Controls.Add(this.WagesEditEmployeesBtn);
			this.WagesNewEmployee.Controls.Add(this.WagesStartDateLabel);
			this.WagesNewEmployee.Controls.Add(this.WagesLogFilterBtn);
			this.WagesNewEmployee.Controls.Add(this.WageLogStartDate);
			this.WagesNewEmployee.Controls.Add(this.WageLogMonths);
			this.WagesNewEmployee.Controls.Add(this.WagePartTimeEmployeeCheckBox);
			this.WagesNewEmployee.Controls.Add(this.WagesEmployeeName);
			this.WagesNewEmployee.Controls.Add(this.WageAmount);
			this.WagesNewEmployee.Controls.Add(this.WageDeleteBtn);
			this.WagesNewEmployee.Controls.Add(this.WageDate);
			this.WagesNewEmployee.Controls.Add(this.WageLogGridView);
			this.WagesNewEmployee.Controls.Add(this.WageClearFieldsBtn);
			this.WagesNewEmployee.Controls.Add(this.WageAddBtn);
			this.WagesNewEmployee.Controls.Add(this.WageAmountLabel);
			this.WagesNewEmployee.Controls.Add(this.WageEmployeeLabel);
			this.WagesNewEmployee.Controls.Add(this.WagesDateLabel);
			this.WagesNewEmployee.Location = new System.Drawing.Point(4, 28);
			this.WagesNewEmployee.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.WagesNewEmployee.Name = "WagesNewEmployee";
			this.WagesNewEmployee.Size = new System.Drawing.Size(1378, 690);
			this.WagesNewEmployee.TabIndex = 4;
			this.WagesNewEmployee.Text = "Wages";
			this.WagesNewEmployee.UseVisualStyleBackColor = true;
			// 
			// WagesEndDateLabel
			// 
			this.WagesEndDateLabel.AutoSize = true;
			this.WagesEndDateLabel.Location = new System.Drawing.Point(1160, 12);
			this.WagesEndDateLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.WagesEndDateLabel.Name = "WagesEndDateLabel";
			this.WagesEndDateLabel.Size = new System.Drawing.Size(81, 19);
			this.WagesEndDateLabel.TabIndex = 62;
			this.WagesEndDateLabel.Text = "End Date";
			// 
			// WagesLogRemoveFilterBtn
			// 
			this.WagesLogRemoveFilterBtn.Location = new System.Drawing.Point(858, 70);
			this.WagesLogRemoveFilterBtn.Margin = new System.Windows.Forms.Padding(2);
			this.WagesLogRemoveFilterBtn.Name = "WagesLogRemoveFilterBtn";
			this.WagesLogRemoveFilterBtn.Size = new System.Drawing.Size(298, 37);
			this.WagesLogRemoveFilterBtn.TabIndex = 74;
			this.WagesLogRemoveFilterBtn.Text = "Remove Filters";
			this.WagesLogRemoveFilterBtn.UseVisualStyleBackColor = true;
			this.WagesLogRemoveFilterBtn.Click += new System.EventHandler(this.WagesLogRemoveFilterBtn_Click);
			// 
			// WageLogEndDate
			// 
			this.WageLogEndDate.DropDownHeight = 300;
			this.WageLogEndDate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.WageLogEndDate.FormattingEnabled = true;
			this.WageLogEndDate.IntegralHeight = false;
			this.WageLogEndDate.ItemHeight = 19;
			this.WageLogEndDate.Location = new System.Drawing.Point(1163, 32);
			this.WageLogEndDate.Margin = new System.Windows.Forms.Padding(2);
			this.WageLogEndDate.Name = "WageLogEndDate";
			this.WageLogEndDate.Size = new System.Drawing.Size(292, 27);
			this.WageLogEndDate.TabIndex = 60;
			// 
			// WagesMonthLabel
			// 
			this.WagesMonthLabel.AutoSize = true;
			this.WagesMonthLabel.Location = new System.Drawing.Point(545, 12);
			this.WagesMonthLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.WagesMonthLabel.Name = "WagesMonthLabel";
			this.WagesMonthLabel.Size = new System.Drawing.Size(54, 19);
			this.WagesMonthLabel.TabIndex = 64;
			this.WagesMonthLabel.Text = "Month";
			// 
			// WagesEditEmployeesBtn
			// 
			this.WagesEditEmployeesBtn.Location = new System.Drawing.Point(183, 77);
			this.WagesEditEmployeesBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.WagesEditEmployeesBtn.Name = "WagesEditEmployeesBtn";
			this.WagesEditEmployeesBtn.Size = new System.Drawing.Size(201, 30);
			this.WagesEditEmployeesBtn.TabIndex = 71;
			this.WagesEditEmployeesBtn.Text = "Edit Employees";
			this.WagesEditEmployeesBtn.UseVisualStyleBackColor = true;
			this.WagesEditEmployeesBtn.Click += new System.EventHandler(this.NewEmployee_Click);
			// 
			// WagesStartDateLabel
			// 
			this.WagesStartDateLabel.AutoSize = true;
			this.WagesStartDateLabel.Location = new System.Drawing.Point(854, 12);
			this.WagesStartDateLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.WagesStartDateLabel.Name = "WagesStartDateLabel";
			this.WagesStartDateLabel.Size = new System.Drawing.Size(99, 19);
			this.WagesStartDateLabel.TabIndex = 61;
			this.WagesStartDateLabel.Text = "Start Date";
			// 
			// WagesLogFilterBtn
			// 
			this.WagesLogFilterBtn.Location = new System.Drawing.Point(548, 70);
			this.WagesLogFilterBtn.Margin = new System.Windows.Forms.Padding(2);
			this.WagesLogFilterBtn.Name = "WagesLogFilterBtn";
			this.WagesLogFilterBtn.Size = new System.Drawing.Size(303, 37);
			this.WagesLogFilterBtn.TabIndex = 73;
			this.WagesLogFilterBtn.Text = "Filter";
			this.WagesLogFilterBtn.UseVisualStyleBackColor = true;
			this.WagesLogFilterBtn.Click += new System.EventHandler(this.WagesLogFilterBtn_Click);
			// 
			// WageLogStartDate
			// 
			this.WageLogStartDate.DropDownHeight = 300;
			this.WageLogStartDate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.WageLogStartDate.FormattingEnabled = true;
			this.WageLogStartDate.IntegralHeight = false;
			this.WageLogStartDate.ItemHeight = 19;
			this.WageLogStartDate.Location = new System.Drawing.Point(858, 32);
			this.WageLogStartDate.Margin = new System.Windows.Forms.Padding(2);
			this.WageLogStartDate.Name = "WageLogStartDate";
			this.WageLogStartDate.Size = new System.Drawing.Size(298, 27);
			this.WageLogStartDate.TabIndex = 59;
			// 
			// WageLogMonths
			// 
			this.WageLogMonths.DropDownHeight = 300;
			this.WageLogMonths.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.WageLogMonths.FormattingEnabled = true;
			this.WageLogMonths.IntegralHeight = false;
			this.WageLogMonths.ItemHeight = 19;
			this.WageLogMonths.Location = new System.Drawing.Point(548, 32);
			this.WageLogMonths.Margin = new System.Windows.Forms.Padding(2);
			this.WageLogMonths.Name = "WageLogMonths";
			this.WageLogMonths.Size = new System.Drawing.Size(303, 27);
			this.WageLogMonths.TabIndex = 63;
			this.WageLogMonths.SelectedIndexChanged += new System.EventHandler(this.WageLogMonth_SelectedIndexChanged);
			// 
			// WagePartTimeEmployeeCheckBox
			// 
			this.WagePartTimeEmployeeCheckBox.AutoSize = true;
			this.WagePartTimeEmployeeCheckBox.Location = new System.Drawing.Point(183, 126);
			this.WagePartTimeEmployeeCheckBox.Name = "WagePartTimeEmployeeCheckBox";
			this.WagePartTimeEmployeeCheckBox.Size = new System.Drawing.Size(190, 23);
			this.WagePartTimeEmployeeCheckBox.TabIndex = 70;
			this.WagePartTimeEmployeeCheckBox.Text = "Part Time Employee";
			this.WagePartTimeEmployeeCheckBox.UseVisualStyleBackColor = true;
			this.WagePartTimeEmployeeCheckBox.CheckedChanged += new System.EventHandler(this.PartTimeEmployeeCheckBox_CheckedChanged);
			// 
			// WagesEmployeeName
			// 
			this.WagesEmployeeName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.WagesEmployeeName.FormattingEnabled = true;
			this.WagesEmployeeName.Location = new System.Drawing.Point(183, 171);
			this.WagesEmployeeName.Name = "WagesEmployeeName";
			this.WagesEmployeeName.Size = new System.Drawing.Size(328, 27);
			this.WagesEmployeeName.TabIndex = 69;
			// 
			// WageAmount
			// 
			this.WageAmount.DecimalPlaces = 2;
			this.WageAmount.Location = new System.Drawing.Point(183, 228);
			this.WageAmount.Maximum = new decimal(new int[] {
            200000,
            0,
            0,
            0});
			this.WageAmount.Name = "WageAmount";
			this.WageAmount.Size = new System.Drawing.Size(138, 26);
			this.WageAmount.TabIndex = 68;
			// 
			// WageDeleteBtn
			// 
			this.WageDeleteBtn.Location = new System.Drawing.Point(1164, 70);
			this.WageDeleteBtn.Margin = new System.Windows.Forms.Padding(2);
			this.WageDeleteBtn.Name = "WageDeleteBtn";
			this.WageDeleteBtn.Size = new System.Drawing.Size(291, 37);
			this.WageDeleteBtn.TabIndex = 72;
			this.WageDeleteBtn.Text = "Delete Wage";
			this.WageDeleteBtn.UseVisualStyleBackColor = true;
			this.WageDeleteBtn.Click += new System.EventHandler(this.DeleteWageBtn_Click);
			// 
			// WageDate
			// 
			this.WageDate.CalendarFont = new System.Drawing.Font("Consolas", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.WageDate.Location = new System.Drawing.Point(183, 33);
			this.WageDate.Margin = new System.Windows.Forms.Padding(2);
			this.WageDate.MaxDate = new System.DateTime(2028, 7, 1, 0, 0, 0, 0);
			this.WageDate.MinDate = new System.DateTime(2019, 1, 1, 0, 0, 0, 0);
			this.WageDate.Name = "WageDate";
			this.WageDate.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.WageDate.Size = new System.Drawing.Size(328, 26);
			this.WageDate.TabIndex = 52;
			this.WageDate.TabStop = false;
			this.WageDate.Value = new System.DateTime(2021, 1, 22, 0, 0, 0, 0);
			// 
			// WageLogGridView
			// 
			this.WageLogGridView.AllowUserToAddRows = false;
			this.WageLogGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.WageLogGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.WageLogGridView.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
			this.WageLogGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.WageLogGridView.Location = new System.Drawing.Point(548, 126);
			this.WageLogGridView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.WageLogGridView.Name = "WageLogGridView";
			this.WageLogGridView.ReadOnly = true;
			this.WageLogGridView.RowHeadersWidth = 51;
			this.WageLogGridView.RowTemplate.Height = 24;
			this.WageLogGridView.Size = new System.Drawing.Size(824, 562);
			this.WageLogGridView.TabIndex = 58;
			// 
			// WageClearFieldsBtn
			// 
			this.WageClearFieldsBtn.Location = new System.Drawing.Point(227, 376);
			this.WageClearFieldsBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.WageClearFieldsBtn.Name = "WageClearFieldsBtn";
			this.WageClearFieldsBtn.Size = new System.Drawing.Size(145, 46);
			this.WageClearFieldsBtn.TabIndex = 57;
			this.WageClearFieldsBtn.Text = "Clear";
			this.WageClearFieldsBtn.UseVisualStyleBackColor = true;
			this.WageClearFieldsBtn.Click += new System.EventHandler(this.ClearWageFieldsBtn_Click);
			// 
			// WageAddBtn
			// 
			this.WageAddBtn.Location = new System.Drawing.Point(12, 376);
			this.WageAddBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.WageAddBtn.Name = "WageAddBtn";
			this.WageAddBtn.Size = new System.Drawing.Size(166, 46);
			this.WageAddBtn.TabIndex = 56;
			this.WageAddBtn.Text = "Add Wage";
			this.WageAddBtn.UseVisualStyleBackColor = true;
			this.WageAddBtn.Click += new System.EventHandler(this.AddWageBtn_Click);
			// 
			// WageAmountLabel
			// 
			this.WageAmountLabel.AutoSize = true;
			this.WageAmountLabel.Location = new System.Drawing.Point(9, 230);
			this.WageAmountLabel.Name = "WageAmountLabel";
			this.WageAmountLabel.Size = new System.Drawing.Size(63, 19);
			this.WageAmountLabel.TabIndex = 55;
			this.WageAmountLabel.Text = "Amount";
			// 
			// WageEmployeeLabel
			// 
			this.WageEmployeeLabel.AutoSize = true;
			this.WageEmployeeLabel.Location = new System.Drawing.Point(9, 174);
			this.WageEmployeeLabel.Name = "WageEmployeeLabel";
			this.WageEmployeeLabel.Size = new System.Drawing.Size(81, 19);
			this.WageEmployeeLabel.TabIndex = 54;
			this.WageEmployeeLabel.Text = "Employee";
			// 
			// WagesDateLabel
			// 
			this.WagesDateLabel.AutoSize = true;
			this.WagesDateLabel.Location = new System.Drawing.Point(9, 35);
			this.WagesDateLabel.Name = "WagesDateLabel";
			this.WagesDateLabel.Size = new System.Drawing.Size(45, 19);
			this.WagesDateLabel.TabIndex = 53;
			this.WagesDateLabel.Text = "Date";
			// 
			// SalesPR
			// 
			this.SalesPR.Controls.Add(this.salesPRDataGridView);
			this.SalesPR.Location = new System.Drawing.Point(4, 28);
			this.SalesPR.Margin = new System.Windows.Forms.Padding(2);
			this.SalesPR.Name = "SalesPR";
			this.SalesPR.Size = new System.Drawing.Size(1378, 690);
			this.SalesPR.TabIndex = 8;
			this.SalesPR.Text = "Sales PR";
			this.SalesPR.UseVisualStyleBackColor = true;
			// 
			// salesPRDataGridView
			// 
			this.salesPRDataGridView.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
			this.salesPRDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.salesPRDataGridView.GridColor = System.Drawing.SystemColors.ButtonHighlight;
			this.salesPRDataGridView.Location = new System.Drawing.Point(2, 137);
			this.salesPRDataGridView.Margin = new System.Windows.Forms.Padding(2);
			this.salesPRDataGridView.Name = "salesPRDataGridView";
			this.salesPRDataGridView.RowHeadersWidth = 51;
			this.salesPRDataGridView.RowTemplate.Height = 24;
			this.salesPRDataGridView.Size = new System.Drawing.Size(1370, 550);
			this.salesPRDataGridView.TabIndex = 0;
			// 
			// PurchasesPR
			// 
			this.PurchasesPR.Controls.Add(this.button6);
			this.PurchasesPR.Controls.Add(this.PrintPRBtn);
			this.PurchasesPR.Controls.Add(this.RemovePRFiltersBtn);
			this.PurchasesPR.Controls.Add(this.FilterPRBtn);
			this.PurchasesPR.Controls.Add(this.label66);
			this.PurchasesPR.Controls.Add(this.PurchasesPRMonth);
			this.PurchasesPR.Controls.Add(this.label67);
			this.PurchasesPR.Controls.Add(this.label68);
			this.PurchasesPR.Controls.Add(this.label69);
			this.PurchasesPR.Controls.Add(this.PurchasePRType);
			this.PurchasesPR.Controls.Add(this.PurchasePREndDate);
			this.PurchasesPR.Controls.Add(this.PurchasePRStartDate);
			this.PurchasesPR.Controls.Add(this.PurchasesPRDataGridView);
			this.PurchasesPR.Location = new System.Drawing.Point(4, 28);
			this.PurchasesPR.Margin = new System.Windows.Forms.Padding(2);
			this.PurchasesPR.Name = "PurchasesPR";
			this.PurchasesPR.Size = new System.Drawing.Size(1378, 690);
			this.PurchasesPR.TabIndex = 9;
			this.PurchasesPR.Text = "Purchases PR";
			this.PurchasesPR.UseVisualStyleBackColor = true;
			// 
			// button6
			// 
			this.button6.Location = new System.Drawing.Point(876, 88);
			this.button6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.button6.Name = "button6";
			this.button6.Size = new System.Drawing.Size(212, 46);
			this.button6.TabIndex = 31;
			this.button6.Text = "Print Register";
			this.button6.UseVisualStyleBackColor = true;
			// 
			// PrintPRBtn
			// 
			this.PrintPRBtn.Location = new System.Drawing.Point(589, 88);
			this.PrintPRBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.PrintPRBtn.Name = "PrintPRBtn";
			this.PrintPRBtn.Size = new System.Drawing.Size(212, 46);
			this.PrintPRBtn.TabIndex = 30;
			this.PrintPRBtn.Text = "Print Register";
			this.PrintPRBtn.UseVisualStyleBackColor = true;
			// 
			// RemovePRFiltersBtn
			// 
			this.RemovePRFiltersBtn.Location = new System.Drawing.Point(297, 88);
			this.RemovePRFiltersBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.RemovePRFiltersBtn.Name = "RemovePRFiltersBtn";
			this.RemovePRFiltersBtn.Size = new System.Drawing.Size(238, 46);
			this.RemovePRFiltersBtn.TabIndex = 29;
			this.RemovePRFiltersBtn.Text = "Remove Filters";
			this.RemovePRFiltersBtn.UseVisualStyleBackColor = true;
			// 
			// FilterPRBtn
			// 
			this.FilterPRBtn.Location = new System.Drawing.Point(29, 88);
			this.FilterPRBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.FilterPRBtn.Name = "FilterPRBtn";
			this.FilterPRBtn.Size = new System.Drawing.Size(212, 46);
			this.FilterPRBtn.TabIndex = 28;
			this.FilterPRBtn.Text = "Print Register";
			this.FilterPRBtn.UseVisualStyleBackColor = true;
			// 
			// label66
			// 
			this.label66.AutoSize = true;
			this.label66.Location = new System.Drawing.Point(25, 14);
			this.label66.Name = "label66";
			this.label66.Size = new System.Drawing.Size(54, 19);
			this.label66.TabIndex = 27;
			this.label66.Text = "Month";
			// 
			// PurchasesPRMonth
			// 
			this.PurchasesPRMonth.DropDownHeight = 300;
			this.PurchasesPRMonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.PurchasesPRMonth.FormattingEnabled = true;
			this.PurchasesPRMonth.IntegralHeight = false;
			this.PurchasesPRMonth.ItemHeight = 19;
			this.PurchasesPRMonth.Location = new System.Drawing.Point(29, 39);
			this.PurchasesPRMonth.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.PurchasesPRMonth.Name = "PurchasesPRMonth";
			this.PurchasesPRMonth.Size = new System.Drawing.Size(216, 27);
			this.PurchasesPRMonth.TabIndex = 26;
			this.PurchasesPRMonth.SelectedIndexChanged += new System.EventHandler(this.PurchasesPRMonth_SelectedIndexChanged);
			// 
			// label67
			// 
			this.label67.AutoSize = true;
			this.label67.Location = new System.Drawing.Point(873, 14);
			this.label67.Name = "label67";
			this.label67.Size = new System.Drawing.Size(45, 19);
			this.label67.TabIndex = 25;
			this.label67.Text = "Type";
			// 
			// label68
			// 
			this.label68.AutoSize = true;
			this.label68.Location = new System.Drawing.Point(586, 14);
			this.label68.Name = "label68";
			this.label68.Size = new System.Drawing.Size(81, 19);
			this.label68.TabIndex = 24;
			this.label68.Text = "End Date";
			// 
			// label69
			// 
			this.label69.AutoSize = true;
			this.label69.Location = new System.Drawing.Point(294, 14);
			this.label69.Name = "label69";
			this.label69.Size = new System.Drawing.Size(99, 19);
			this.label69.TabIndex = 23;
			this.label69.Text = "Start Date";
			// 
			// PurchasePRType
			// 
			this.PurchasePRType.DropDownHeight = 300;
			this.PurchasePRType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.PurchasePRType.FormattingEnabled = true;
			this.PurchasePRType.IntegralHeight = false;
			this.PurchasePRType.ItemHeight = 19;
			this.PurchasePRType.Location = new System.Drawing.Point(876, 39);
			this.PurchasePRType.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.PurchasePRType.Name = "PurchasePRType";
			this.PurchasePRType.Size = new System.Drawing.Size(216, 27);
			this.PurchasePRType.TabIndex = 22;
			// 
			// PurchasePREndDate
			// 
			this.PurchasePREndDate.DropDownHeight = 300;
			this.PurchasePREndDate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.PurchasePREndDate.FormattingEnabled = true;
			this.PurchasePREndDate.IntegralHeight = false;
			this.PurchasePREndDate.ItemHeight = 19;
			this.PurchasePREndDate.Location = new System.Drawing.Point(589, 39);
			this.PurchasePREndDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.PurchasePREndDate.Name = "PurchasePREndDate";
			this.PurchasePREndDate.Size = new System.Drawing.Size(232, 27);
			this.PurchasePREndDate.TabIndex = 21;
			// 
			// PurchasePRStartDate
			// 
			this.PurchasePRStartDate.DropDownHeight = 300;
			this.PurchasePRStartDate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.PurchasePRStartDate.FormattingEnabled = true;
			this.PurchasePRStartDate.IntegralHeight = false;
			this.PurchasePRStartDate.ItemHeight = 19;
			this.PurchasePRStartDate.Location = new System.Drawing.Point(297, 39);
			this.PurchasePRStartDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.PurchasePRStartDate.Name = "PurchasePRStartDate";
			this.PurchasePRStartDate.Size = new System.Drawing.Size(238, 27);
			this.PurchasePRStartDate.TabIndex = 20;
			// 
			// PurchasesPRDataGridView
			// 
			this.PurchasesPRDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.PurchasesPRDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.PurchasesPRDataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
			this.PurchasesPRDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.PurchasesPRDataGridView.Location = new System.Drawing.Point(29, 158);
			this.PurchasesPRDataGridView.Margin = new System.Windows.Forms.Padding(2);
			this.PurchasesPRDataGridView.Name = "PurchasesPRDataGridView";
			this.PurchasesPRDataGridView.RowHeadersWidth = 51;
			this.PurchasesPRDataGridView.RowTemplate.Height = 24;
			this.PurchasesPRDataGridView.Size = new System.Drawing.Size(1324, 529);
			this.PurchasesPRDataGridView.TabIndex = 0;
			// 
			// Summaries
			// 
			this.Summaries.Controls.Add(this.SummariesTotalSalesLabel);
			this.Summaries.Controls.Add(this.SummariesTotalSales);
			this.Summaries.Controls.Add(this.SummariesTotalPurchasesLabel);
			this.Summaries.Controls.Add(this.SummariesTotalPurchases);
			this.Summaries.Controls.Add(this.SummariesProfitLabel);
			this.Summaries.Controls.Add(this.SummariesProfitBox);
			this.Summaries.Controls.Add(this.SummariesMonthsLabel);
			this.Summaries.Controls.Add(this.SummariesMonths);
			this.Summaries.Controls.Add(this.SummariesExpensesBox);
			this.Summaries.Controls.Add(this.SummariesNFSalesBox);
			this.Summaries.Controls.Add(this.SummariesFSalesBox);
			this.Summaries.Controls.Add(this.SummariesWagesBox);
			this.Summaries.Controls.Add(this.SummariesNFPurchasesBox);
			this.Summaries.Controls.Add(this.SummariesFPurchasesBox);
			this.Summaries.Controls.Add(this.SummariesExpensesLabel);
			this.Summaries.Controls.Add(this.SummariesWagesLabel);
			this.Summaries.Controls.Add(this.SummariesNFSalesLabel);
			this.Summaries.Controls.Add(this.SummariesNFPurchasesLabel);
			this.Summaries.Controls.Add(this.SummariesFSalesLabel);
			this.Summaries.Controls.Add(this.SummariesFPurchasesLabel);
			this.Summaries.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Summaries.Location = new System.Drawing.Point(4, 28);
			this.Summaries.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.Summaries.Name = "Summaries";
			this.Summaries.Size = new System.Drawing.Size(1378, 690);
			this.Summaries.TabIndex = 6;
			this.Summaries.Text = "Summaries";
			this.Summaries.UseVisualStyleBackColor = true;
			// 
			// SummariesTotalSalesLabel
			// 
			this.SummariesTotalSalesLabel.AutoSize = true;
			this.SummariesTotalSalesLabel.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.SummariesTotalSalesLabel.Location = new System.Drawing.Point(750, 303);
			this.SummariesTotalSalesLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.SummariesTotalSalesLabel.Name = "SummariesTotalSalesLabel";
			this.SummariesTotalSalesLabel.Size = new System.Drawing.Size(120, 22);
			this.SummariesTotalSalesLabel.TabIndex = 19;
			this.SummariesTotalSalesLabel.Text = "Total Sales";
			// 
			// SummariesTotalSales
			// 
			this.SummariesTotalSales.Font = new System.Drawing.Font("Consolas", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.SummariesTotalSales.Location = new System.Drawing.Point(754, 328);
			this.SummariesTotalSales.Margin = new System.Windows.Forms.Padding(2);
			this.SummariesTotalSales.Name = "SummariesTotalSales";
			this.SummariesTotalSales.ReadOnly = true;
			this.SummariesTotalSales.Size = new System.Drawing.Size(301, 137);
			this.SummariesTotalSales.TabIndex = 18;
			this.SummariesTotalSales.Text = "";
			// 
			// SummariesTotalPurchasesLabel
			// 
			this.SummariesTotalPurchasesLabel.AutoSize = true;
			this.SummariesTotalPurchasesLabel.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.SummariesTotalPurchasesLabel.Location = new System.Drawing.Point(753, 103);
			this.SummariesTotalPurchasesLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.SummariesTotalPurchasesLabel.Name = "SummariesTotalPurchasesLabel";
			this.SummariesTotalPurchasesLabel.Size = new System.Drawing.Size(160, 22);
			this.SummariesTotalPurchasesLabel.TabIndex = 17;
			this.SummariesTotalPurchasesLabel.Text = "Total Purchases";
			// 
			// SummariesTotalPurchases
			// 
			this.SummariesTotalPurchases.Font = new System.Drawing.Font("Consolas", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.SummariesTotalPurchases.Location = new System.Drawing.Point(754, 128);
			this.SummariesTotalPurchases.Margin = new System.Windows.Forms.Padding(2);
			this.SummariesTotalPurchases.Name = "SummariesTotalPurchases";
			this.SummariesTotalPurchases.ReadOnly = true;
			this.SummariesTotalPurchases.Size = new System.Drawing.Size(303, 137);
			this.SummariesTotalPurchases.TabIndex = 16;
			this.SummariesTotalPurchases.Text = " ";
			// 
			// SummariesProfitLabel
			// 
			this.SummariesProfitLabel.AutoSize = true;
			this.SummariesProfitLabel.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.SummariesProfitLabel.Location = new System.Drawing.Point(750, 506);
			this.SummariesProfitLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.SummariesProfitLabel.Name = "SummariesProfitLabel";
			this.SummariesProfitLabel.Size = new System.Drawing.Size(70, 22);
			this.SummariesProfitLabel.TabIndex = 15;
			this.SummariesProfitLabel.Text = "Profit";
			// 
			// SummariesProfitBox
			// 
			this.SummariesProfitBox.Font = new System.Drawing.Font("Consolas", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.SummariesProfitBox.Location = new System.Drawing.Point(754, 531);
			this.SummariesProfitBox.Margin = new System.Windows.Forms.Padding(2);
			this.SummariesProfitBox.Name = "SummariesProfitBox";
			this.SummariesProfitBox.ReadOnly = true;
			this.SummariesProfitBox.Size = new System.Drawing.Size(301, 137);
			this.SummariesProfitBox.TabIndex = 14;
			this.SummariesProfitBox.Text = "";
			// 
			// SummariesMonthsLabel
			// 
			this.SummariesMonthsLabel.AutoSize = true;
			this.SummariesMonthsLabel.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.SummariesMonthsLabel.Location = new System.Drawing.Point(53, 31);
			this.SummariesMonthsLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.SummariesMonthsLabel.Name = "SummariesMonthsLabel";
			this.SummariesMonthsLabel.Size = new System.Drawing.Size(130, 22);
			this.SummariesMonthsLabel.TabIndex = 13;
			this.SummariesMonthsLabel.Text = "Select Month";
			// 
			// SummariesMonths
			// 
			this.SummariesMonths.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.SummariesMonths.FormattingEnabled = true;
			this.SummariesMonths.Location = new System.Drawing.Point(56, 60);
			this.SummariesMonths.Margin = new System.Windows.Forms.Padding(2);
			this.SummariesMonths.Name = "SummariesMonths";
			this.SummariesMonths.Size = new System.Drawing.Size(322, 30);
			this.SummariesMonths.TabIndex = 12;
			this.SummariesMonths.SelectedIndexChanged += new System.EventHandler(this.SummariesMonthSelector_SelectedIndexChanged);
			// 
			// SummariesExpensesBox
			// 
			this.SummariesExpensesBox.Font = new System.Drawing.Font("Consolas", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.SummariesExpensesBox.Location = new System.Drawing.Point(409, 526);
			this.SummariesExpensesBox.Margin = new System.Windows.Forms.Padding(2);
			this.SummariesExpensesBox.Name = "SummariesExpensesBox";
			this.SummariesExpensesBox.ReadOnly = true;
			this.SummariesExpensesBox.Size = new System.Drawing.Size(316, 142);
			this.SummariesExpensesBox.TabIndex = 11;
			this.SummariesExpensesBox.Text = "";
			// 
			// SummariesNFSalesBox
			// 
			this.SummariesNFSalesBox.Font = new System.Drawing.Font("Consolas", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.SummariesNFSalesBox.Location = new System.Drawing.Point(408, 328);
			this.SummariesNFSalesBox.Margin = new System.Windows.Forms.Padding(2);
			this.SummariesNFSalesBox.Name = "SummariesNFSalesBox";
			this.SummariesNFSalesBox.ReadOnly = true;
			this.SummariesNFSalesBox.Size = new System.Drawing.Size(316, 132);
			this.SummariesNFSalesBox.TabIndex = 10;
			this.SummariesNFSalesBox.Text = "";
			// 
			// SummariesFSalesBox
			// 
			this.SummariesFSalesBox.Font = new System.Drawing.Font("Consolas", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.SummariesFSalesBox.Location = new System.Drawing.Point(57, 328);
			this.SummariesFSalesBox.Margin = new System.Windows.Forms.Padding(2);
			this.SummariesFSalesBox.Name = "SummariesFSalesBox";
			this.SummariesFSalesBox.ReadOnly = true;
			this.SummariesFSalesBox.Size = new System.Drawing.Size(321, 132);
			this.SummariesFSalesBox.TabIndex = 9;
			this.SummariesFSalesBox.Text = "";
			// 
			// SummariesWagesBox
			// 
			this.SummariesWagesBox.Font = new System.Drawing.Font("Consolas", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.SummariesWagesBox.Location = new System.Drawing.Point(57, 526);
			this.SummariesWagesBox.Margin = new System.Windows.Forms.Padding(2);
			this.SummariesWagesBox.Name = "SummariesWagesBox";
			this.SummariesWagesBox.ReadOnly = true;
			this.SummariesWagesBox.Size = new System.Drawing.Size(321, 142);
			this.SummariesWagesBox.TabIndex = 8;
			this.SummariesWagesBox.Text = "";
			// 
			// SummariesNFPurchasesBox
			// 
			this.SummariesNFPurchasesBox.Font = new System.Drawing.Font("Consolas", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.SummariesNFPurchasesBox.Location = new System.Drawing.Point(408, 128);
			this.SummariesNFPurchasesBox.Margin = new System.Windows.Forms.Padding(2);
			this.SummariesNFPurchasesBox.Name = "SummariesNFPurchasesBox";
			this.SummariesNFPurchasesBox.ReadOnly = true;
			this.SummariesNFPurchasesBox.Size = new System.Drawing.Size(316, 137);
			this.SummariesNFPurchasesBox.TabIndex = 7;
			this.SummariesNFPurchasesBox.Text = "";
			// 
			// SummariesFPurchasesBox
			// 
			this.SummariesFPurchasesBox.Font = new System.Drawing.Font("Consolas", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.SummariesFPurchasesBox.Location = new System.Drawing.Point(56, 128);
			this.SummariesFPurchasesBox.Margin = new System.Windows.Forms.Padding(2);
			this.SummariesFPurchasesBox.Name = "SummariesFPurchasesBox";
			this.SummariesFPurchasesBox.ReadOnly = true;
			this.SummariesFPurchasesBox.Size = new System.Drawing.Size(322, 137);
			this.SummariesFPurchasesBox.TabIndex = 6;
			this.SummariesFPurchasesBox.Text = "";
			// 
			// SummariesExpensesLabel
			// 
			this.SummariesExpensesLabel.AutoSize = true;
			this.SummariesExpensesLabel.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.SummariesExpensesLabel.Location = new System.Drawing.Point(405, 502);
			this.SummariesExpensesLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.SummariesExpensesLabel.Name = "SummariesExpensesLabel";
			this.SummariesExpensesLabel.Size = new System.Drawing.Size(150, 22);
			this.SummariesExpensesLabel.TabIndex = 5;
			this.SummariesExpensesLabel.Text = "Total Expenses";
			// 
			// SummariesWagesLabel
			// 
			this.SummariesWagesLabel.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.SummariesWagesLabel.Location = new System.Drawing.Point(53, 502);
			this.SummariesWagesLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.SummariesWagesLabel.Name = "SummariesWagesLabel";
			this.SummariesWagesLabel.Size = new System.Drawing.Size(175, 27);
			this.SummariesWagesLabel.TabIndex = 4;
			this.SummariesWagesLabel.Text = "Total Wages";
			// 
			// SummariesNFSalesLabel
			// 
			this.SummariesNFSalesLabel.AutoSize = true;
			this.SummariesNFSalesLabel.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.SummariesNFSalesLabel.Location = new System.Drawing.Point(405, 303);
			this.SummariesNFSalesLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.SummariesNFSalesLabel.Name = "SummariesNFSalesLabel";
			this.SummariesNFSalesLabel.Size = new System.Drawing.Size(180, 22);
			this.SummariesNFSalesLabel.TabIndex = 3;
			this.SummariesNFSalesLabel.Text = "Non-Ferrous Sales";
			// 
			// SummariesNFPurchasesLabel
			// 
			this.SummariesNFPurchasesLabel.AutoSize = true;
			this.SummariesNFPurchasesLabel.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.SummariesNFPurchasesLabel.Location = new System.Drawing.Point(404, 107);
			this.SummariesNFPurchasesLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.SummariesNFPurchasesLabel.Name = "SummariesNFPurchasesLabel";
			this.SummariesNFPurchasesLabel.Size = new System.Drawing.Size(220, 22);
			this.SummariesNFPurchasesLabel.TabIndex = 2;
			this.SummariesNFPurchasesLabel.Text = "Non-Ferrous Purchases";
			// 
			// SummariesFSalesLabel
			// 
			this.SummariesFSalesLabel.AutoSize = true;
			this.SummariesFSalesLabel.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.SummariesFSalesLabel.Location = new System.Drawing.Point(53, 298);
			this.SummariesFSalesLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.SummariesFSalesLabel.Name = "SummariesFSalesLabel";
			this.SummariesFSalesLabel.Size = new System.Drawing.Size(140, 22);
			this.SummariesFSalesLabel.TabIndex = 1;
			this.SummariesFSalesLabel.Text = "Ferrous Sales";
			// 
			// SummariesFPurchasesLabel
			// 
			this.SummariesFPurchasesLabel.AutoSize = true;
			this.SummariesFPurchasesLabel.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.SummariesFPurchasesLabel.Location = new System.Drawing.Point(53, 107);
			this.SummariesFPurchasesLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.SummariesFPurchasesLabel.Name = "SummariesFPurchasesLabel";
			this.SummariesFPurchasesLabel.Size = new System.Drawing.Size(180, 22);
			this.SummariesFPurchasesLabel.TabIndex = 0;
			this.SummariesFPurchasesLabel.Text = "Ferrous Purchases";
			// 
			// DestructionCertificates
			// 
			this.DestructionCertificates.Controls.Add(this.DestructionCertCmpnyAddress);
			this.DestructionCertificates.Controls.Add(this.DestructionCertCmpnyAddressLabel);
			this.DestructionCertificates.Controls.Add(this.DestructionCertNewCompanyCheckbox);
			this.DestructionCertificates.Controls.Add(this.DestructionCertEmailBtn);
			this.DestructionCertificates.Controls.Add(this.DestructionCertExtractionDate);
			this.DestructionCertificates.Controls.Add(this.DestructionCertCompany);
			this.DestructionCertificates.Controls.Add(this.DestructionCertQntty);
			this.DestructionCertificates.Controls.Add(this.DestructionCertQnttyUnit);
			this.DestructionCertificates.Controls.Add(this.DestructionCertGenBtn);
			this.DestructionCertificates.Controls.Add(this.DestructionCertEmailAddress);
			this.DestructionCertificates.Controls.Add(this.DestructionCertDescripOfPrdct);
			this.DestructionCertificates.Controls.Add(this.DestructionCertCntactNum);
			this.DestructionCertificates.Controls.Add(this.DestructionCertCntactPerson);
			this.DestructionCertificates.Controls.Add(this.DestructionCertExtractionDateLabel);
			this.DestructionCertificates.Controls.Add(this.DestructionCertCntactPersonLabel);
			this.DestructionCertificates.Controls.Add(this.DestructionCertCntactNumLabel);
			this.DestructionCertificates.Controls.Add(this.DestructionCertEmailAddressLabel);
			this.DestructionCertificates.Controls.Add(this.DestructionCertDescripOfPrdctLabel);
			this.DestructionCertificates.Controls.Add(this.DestructionCertCompanyLabel);
			this.DestructionCertificates.Controls.Add(this.DestructionCertQnttyLabel);
			this.DestructionCertificates.Location = new System.Drawing.Point(4, 28);
			this.DestructionCertificates.Margin = new System.Windows.Forms.Padding(2);
			this.DestructionCertificates.Name = "DestructionCertificates";
			this.DestructionCertificates.Size = new System.Drawing.Size(1378, 690);
			this.DestructionCertificates.TabIndex = 3;
			this.DestructionCertificates.Text = "Destruction Certificate";
			this.DestructionCertificates.UseVisualStyleBackColor = true;
			// 
			// DestructionCertCmpnyAddress
			// 
			this.DestructionCertCmpnyAddress.Location = new System.Drawing.Point(329, 307);
			this.DestructionCertCmpnyAddress.Margin = new System.Windows.Forms.Padding(2);
			this.DestructionCertCmpnyAddress.Name = "DestructionCertCmpnyAddress";
			this.DestructionCertCmpnyAddress.ReadOnly = true;
			this.DestructionCertCmpnyAddress.Size = new System.Drawing.Size(696, 26);
			this.DestructionCertCmpnyAddress.TabIndex = 53;
			// 
			// DestructionCertCmpnyAddressLabel
			// 
			this.DestructionCertCmpnyAddressLabel.AutoSize = true;
			this.DestructionCertCmpnyAddressLabel.Location = new System.Drawing.Point(53, 314);
			this.DestructionCertCmpnyAddressLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.DestructionCertCmpnyAddressLabel.Name = "DestructionCertCmpnyAddressLabel";
			this.DestructionCertCmpnyAddressLabel.Size = new System.Drawing.Size(144, 19);
			this.DestructionCertCmpnyAddressLabel.TabIndex = 52;
			this.DestructionCertCmpnyAddressLabel.Text = "Company Address";
			// 
			// DestructionCertNewCompanyCheckbox
			// 
			this.DestructionCertNewCompanyCheckbox.AutoSize = true;
			this.DestructionCertNewCompanyCheckbox.Location = new System.Drawing.Point(775, 100);
			this.DestructionCertNewCompanyCheckbox.Margin = new System.Windows.Forms.Padding(2);
			this.DestructionCertNewCompanyCheckbox.Name = "DestructionCertNewCompanyCheckbox";
			this.DestructionCertNewCompanyCheckbox.Size = new System.Drawing.Size(127, 23);
			this.DestructionCertNewCompanyCheckbox.TabIndex = 51;
			this.DestructionCertNewCompanyCheckbox.Text = "New Company";
			this.DestructionCertNewCompanyCheckbox.UseVisualStyleBackColor = true;
			this.DestructionCertNewCompanyCheckbox.CheckedChanged += new System.EventHandler(this.dstcrtNewCompanyCheckbox_CheckedChanged);
			// 
			// DestructionCertEmailBtn
			// 
			this.DestructionCertEmailBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.DestructionCertEmailBtn.Location = new System.Drawing.Point(302, 521);
			this.DestructionCertEmailBtn.Margin = new System.Windows.Forms.Padding(2);
			this.DestructionCertEmailBtn.Name = "DestructionCertEmailBtn";
			this.DestructionCertEmailBtn.Size = new System.Drawing.Size(221, 62);
			this.DestructionCertEmailBtn.TabIndex = 50;
			this.DestructionCertEmailBtn.Text = "Generate and Email Certificate";
			this.DestructionCertEmailBtn.UseVisualStyleBackColor = true;
			this.DestructionCertEmailBtn.Click += new System.EventHandler(this.SendDstrctCertEmailBtn_Click);
			// 
			// DestructionCertExtractionDate
			// 
			this.DestructionCertExtractionDate.CalendarFont = new System.Drawing.Font("Consolas", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.DestructionCertExtractionDate.Location = new System.Drawing.Point(329, 46);
			this.DestructionCertExtractionDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.DestructionCertExtractionDate.MaxDate = new System.DateTime(2028, 7, 1, 0, 0, 0, 0);
			this.DestructionCertExtractionDate.MinDate = new System.DateTime(2019, 1, 1, 0, 0, 0, 0);
			this.DestructionCertExtractionDate.Name = "DestructionCertExtractionDate";
			this.DestructionCertExtractionDate.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.DestructionCertExtractionDate.Size = new System.Drawing.Size(347, 26);
			this.DestructionCertExtractionDate.TabIndex = 49;
			this.DestructionCertExtractionDate.TabStop = false;
			this.DestructionCertExtractionDate.Value = new System.DateTime(2021, 1, 22, 0, 0, 0, 0);
			// 
			// DestructionCertCompany
			// 
			this.DestructionCertCompany.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.DestructionCertCompany.FormattingEnabled = true;
			this.DestructionCertCompany.Location = new System.Drawing.Point(329, 98);
			this.DestructionCertCompany.Margin = new System.Windows.Forms.Padding(2);
			this.DestructionCertCompany.Name = "DestructionCertCompany";
			this.DestructionCertCompany.Size = new System.Drawing.Size(432, 27);
			this.DestructionCertCompany.TabIndex = 42;
			this.DestructionCertCompany.SelectedIndexChanged += new System.EventHandler(this.dstrctCertCompanyField_SelectedIndexChanged);
			// 
			// DestructionCertQntty
			// 
			this.DestructionCertQntty.DecimalPlaces = 3;
			this.DestructionCertQntty.Location = new System.Drawing.Point(329, 422);
			this.DestructionCertQntty.Margin = new System.Windows.Forms.Padding(2);
			this.DestructionCertQntty.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
			this.DestructionCertQntty.Name = "DestructionCertQntty";
			this.DestructionCertQntty.Size = new System.Drawing.Size(114, 26);
			this.DestructionCertQntty.TabIndex = 48;
			this.DestructionCertQntty.ThousandsSeparator = true;
			// 
			// DestructionCertQnttyUnit
			// 
			this.DestructionCertQnttyUnit.DropDownHeight = 300;
			this.DestructionCertQnttyUnit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.DestructionCertQnttyUnit.FormattingEnabled = true;
			this.DestructionCertQnttyUnit.IntegralHeight = false;
			this.DestructionCertQnttyUnit.ItemHeight = 19;
			this.DestructionCertQnttyUnit.Location = new System.Drawing.Point(452, 422);
			this.DestructionCertQnttyUnit.Margin = new System.Windows.Forms.Padding(2);
			this.DestructionCertQnttyUnit.Name = "DestructionCertQnttyUnit";
			this.DestructionCertQnttyUnit.Size = new System.Drawing.Size(134, 27);
			this.DestructionCertQnttyUnit.TabIndex = 47;
			// 
			// DestructionCertGenBtn
			// 
			this.DestructionCertGenBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.DestructionCertGenBtn.Location = new System.Drawing.Point(54, 520);
			this.DestructionCertGenBtn.Margin = new System.Windows.Forms.Padding(2);
			this.DestructionCertGenBtn.Name = "DestructionCertGenBtn";
			this.DestructionCertGenBtn.Size = new System.Drawing.Size(221, 62);
			this.DestructionCertGenBtn.TabIndex = 30;
			this.DestructionCertGenBtn.Text = "Generate Certificate";
			this.DestructionCertGenBtn.UseVisualStyleBackColor = true;
			this.DestructionCertGenBtn.Click += new System.EventHandler(this.generateDstrCertBtn_Click);
			// 
			// DestructionCertEmailAddress
			// 
			this.DestructionCertEmailAddress.Location = new System.Drawing.Point(329, 252);
			this.DestructionCertEmailAddress.Margin = new System.Windows.Forms.Padding(2);
			this.DestructionCertEmailAddress.Name = "DestructionCertEmailAddress";
			this.DestructionCertEmailAddress.ReadOnly = true;
			this.DestructionCertEmailAddress.Size = new System.Drawing.Size(432, 26);
			this.DestructionCertEmailAddress.TabIndex = 45;
			// 
			// DestructionCertDescripOfPrdct
			// 
			this.DestructionCertDescripOfPrdct.Location = new System.Drawing.Point(329, 363);
			this.DestructionCertDescripOfPrdct.Margin = new System.Windows.Forms.Padding(2);
			this.DestructionCertDescripOfPrdct.Name = "DestructionCertDescripOfPrdct";
			this.DestructionCertDescripOfPrdct.Size = new System.Drawing.Size(432, 26);
			this.DestructionCertDescripOfPrdct.TabIndex = 46;
			// 
			// DestructionCertCntactNum
			// 
			this.DestructionCertCntactNum.Location = new System.Drawing.Point(329, 200);
			this.DestructionCertCntactNum.Margin = new System.Windows.Forms.Padding(2);
			this.DestructionCertCntactNum.Name = "DestructionCertCntactNum";
			this.DestructionCertCntactNum.ReadOnly = true;
			this.DestructionCertCntactNum.Size = new System.Drawing.Size(255, 26);
			this.DestructionCertCntactNum.TabIndex = 44;
			// 
			// DestructionCertCntactPerson
			// 
			this.DestructionCertCntactPerson.Location = new System.Drawing.Point(329, 148);
			this.DestructionCertCntactPerson.Margin = new System.Windows.Forms.Padding(2);
			this.DestructionCertCntactPerson.Name = "DestructionCertCntactPerson";
			this.DestructionCertCntactPerson.ReadOnly = true;
			this.DestructionCertCntactPerson.Size = new System.Drawing.Size(255, 26);
			this.DestructionCertCntactPerson.TabIndex = 43;
			// 
			// DestructionCertExtractionDateLabel
			// 
			this.DestructionCertExtractionDateLabel.AutoSize = true;
			this.DestructionCertExtractionDateLabel.Location = new System.Drawing.Point(54, 51);
			this.DestructionCertExtractionDateLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.DestructionCertExtractionDateLabel.Name = "DestructionCertExtractionDateLabel";
			this.DestructionCertExtractionDateLabel.Size = new System.Drawing.Size(144, 19);
			this.DestructionCertExtractionDateLabel.TabIndex = 11;
			this.DestructionCertExtractionDateLabel.Text = "Extraction Date";
			// 
			// DestructionCertCntactPersonLabel
			// 
			this.DestructionCertCntactPersonLabel.AutoSize = true;
			this.DestructionCertCntactPersonLabel.Location = new System.Drawing.Point(54, 152);
			this.DestructionCertCntactPersonLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.DestructionCertCntactPersonLabel.Name = "DestructionCertCntactPersonLabel";
			this.DestructionCertCntactPersonLabel.Size = new System.Drawing.Size(135, 19);
			this.DestructionCertCntactPersonLabel.TabIndex = 10;
			this.DestructionCertCntactPersonLabel.Text = "Contact Person";
			// 
			// DestructionCertCntactNumLabel
			// 
			this.DestructionCertCntactNumLabel.AutoSize = true;
			this.DestructionCertCntactNumLabel.Location = new System.Drawing.Point(54, 205);
			this.DestructionCertCntactNumLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.DestructionCertCntactNumLabel.Name = "DestructionCertCntactNumLabel";
			this.DestructionCertCntactNumLabel.Size = new System.Drawing.Size(135, 19);
			this.DestructionCertCntactNumLabel.TabIndex = 9;
			this.DestructionCertCntactNumLabel.Text = "Contact Number";
			// 
			// DestructionCertEmailAddressLabel
			// 
			this.DestructionCertEmailAddressLabel.AutoSize = true;
			this.DestructionCertEmailAddressLabel.Location = new System.Drawing.Point(54, 255);
			this.DestructionCertEmailAddressLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.DestructionCertEmailAddressLabel.Name = "DestructionCertEmailAddressLabel";
			this.DestructionCertEmailAddressLabel.Size = new System.Drawing.Size(126, 19);
			this.DestructionCertEmailAddressLabel.TabIndex = 8;
			this.DestructionCertEmailAddressLabel.Text = "Email Address";
			// 
			// DestructionCertDescripOfPrdctLabel
			// 
			this.DestructionCertDescripOfPrdctLabel.AutoSize = true;
			this.DestructionCertDescripOfPrdctLabel.Location = new System.Drawing.Point(54, 368);
			this.DestructionCertDescripOfPrdctLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.DestructionCertDescripOfPrdctLabel.Name = "DestructionCertDescripOfPrdctLabel";
			this.DestructionCertDescripOfPrdctLabel.Size = new System.Drawing.Size(207, 19);
			this.DestructionCertDescripOfPrdctLabel.TabIndex = 7;
			this.DestructionCertDescripOfPrdctLabel.Text = "Description of Product";
			// 
			// DestructionCertCompanyLabel
			// 
			this.DestructionCertCompanyLabel.AutoSize = true;
			this.DestructionCertCompanyLabel.Location = new System.Drawing.Point(54, 103);
			this.DestructionCertCompanyLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.DestructionCertCompanyLabel.Name = "DestructionCertCompanyLabel";
			this.DestructionCertCompanyLabel.Size = new System.Drawing.Size(72, 19);
			this.DestructionCertCompanyLabel.TabIndex = 6;
			this.DestructionCertCompanyLabel.Text = "Company";
			// 
			// DestructionCertQnttyLabel
			// 
			this.DestructionCertQnttyLabel.AutoSize = true;
			this.DestructionCertQnttyLabel.Location = new System.Drawing.Point(54, 426);
			this.DestructionCertQnttyLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.DestructionCertQnttyLabel.Name = "DestructionCertQnttyLabel";
			this.DestructionCertQnttyLabel.Size = new System.Drawing.Size(81, 19);
			this.DestructionCertQnttyLabel.TabIndex = 5;
			this.DestructionCertQnttyLabel.Text = "Quantity";
			// 
			// DeliveryNote
			// 
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
			this.DeliveryNote.Controls.Add(this.DeliveryVehicleTypePicture);
			this.DeliveryNote.Controls.Add(this.DeliveryVehicleType);
			this.DeliveryNote.Controls.Add(this.DeliveryVehicleReg);
			this.DeliveryNote.Controls.Add(this.DeliveryDriverCell);
			this.DeliveryNote.Controls.Add(this.DeliveryDriverName);
			this.DeliveryNote.Controls.Add(this.DeliverVehicleTypeLabel);
			this.DeliveryNote.Controls.Add(this.DeliveryVehicleRegLabel);
			this.DeliveryNote.Controls.Add(this.DeliveryDriverCellLabel);
			this.DeliveryNote.Controls.Add(this.DeliveryDriverNameLabel);
			this.DeliveryNote.Controls.Add(this.DeliveryCompanyNameLabel);
			this.DeliveryNote.Controls.Add(this.DeliveryCompaniesList);
			this.DeliveryNote.Controls.Add(this.DeliveryAddItem);
			this.DeliveryNote.Controls.Add(this.DeliveryQuantityBox);
			this.DeliveryNote.Controls.Add(this.DeliveryQuantityLabel);
			this.DeliveryNote.Controls.Add(this.DeliveryItemsList);
			this.DeliveryNote.Controls.Add(this.DeliveryItemsLabel);
			this.DeliveryNote.Location = new System.Drawing.Point(4, 28);
			this.DeliveryNote.Margin = new System.Windows.Forms.Padding(2);
			this.DeliveryNote.Name = "DeliveryNote";
			this.DeliveryNote.Size = new System.Drawing.Size(1378, 690);
			this.DeliveryNote.TabIndex = 10;
			this.DeliveryNote.Text = "Delivery Note";
			this.DeliveryNote.UseVisualStyleBackColor = true;
			// 
			// DeliveryNotePrint
			// 
			this.DeliveryNotePrint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.DeliveryNotePrint.BackColor = System.Drawing.Color.Turquoise;
			this.DeliveryNotePrint.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.DeliveryNotePrint.ForeColor = System.Drawing.SystemColors.ControlText;
			this.DeliveryNotePrint.Location = new System.Drawing.Point(63, 530);
			this.DeliveryNotePrint.Margin = new System.Windows.Forms.Padding(2);
			this.DeliveryNotePrint.Name = "DeliveryNotePrint";
			this.DeliveryNotePrint.Size = new System.Drawing.Size(169, 54);
			this.DeliveryNotePrint.TabIndex = 28;
			this.DeliveryNotePrint.Text = "Print";
			this.DeliveryNotePrint.UseVisualStyleBackColor = false;
			this.DeliveryNotePrint.Click += new System.EventHandler(this.DeliveryNotePrint_Click);
			// 
			// DeliveryNoteCancel
			// 
			this.DeliveryNoteCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.DeliveryNoteCancel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.DeliveryNoteCancel.BackColor = System.Drawing.Color.Turquoise;
			this.DeliveryNoteCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.DeliveryNoteCancel.Location = new System.Drawing.Point(63, 603);
			this.DeliveryNoteCancel.Margin = new System.Windows.Forms.Padding(2);
			this.DeliveryNoteCancel.Name = "DeliveryNoteCancel";
			this.DeliveryNoteCancel.Size = new System.Drawing.Size(170, 50);
			this.DeliveryNoteCancel.TabIndex = 27;
			this.DeliveryNoteCancel.Text = "Cancel";
			this.DeliveryNoteCancel.UseVisualStyleBackColor = false;
			this.DeliveryNoteCancel.Click += new System.EventHandler(this.DeliveryNoteCancel_Click);
			// 
			// DeliveryNoteDisplayPanel
			// 
			this.DeliveryNoteDisplayPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.DeliveryNoteDisplayPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.DeliveryNoteDisplayPanel.Controls.Add(this.DeliveryNotePdfDisplay);
			this.DeliveryNoteDisplayPanel.Dock = System.Windows.Forms.DockStyle.Right;
			this.DeliveryNoteDisplayPanel.Location = new System.Drawing.Point(0, 0);
			this.DeliveryNoteDisplayPanel.Margin = new System.Windows.Forms.Padding(2);
			this.DeliveryNoteDisplayPanel.Name = "DeliveryNoteDisplayPanel";
			this.DeliveryNoteDisplayPanel.Size = new System.Drawing.Size(1378, 690);
			this.DeliveryNoteDisplayPanel.TabIndex = 26;
			// 
			// DeliveryNotePdfDisplay
			// 
			this.DeliveryNotePdfDisplay.AllowDrop = true;
			this.DeliveryNotePdfDisplay.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.DeliveryNotePdfDisplay.Enabled = true;
			this.DeliveryNotePdfDisplay.Location = new System.Drawing.Point(245, 2);
			this.DeliveryNotePdfDisplay.Margin = new System.Windows.Forms.Padding(2);
			this.DeliveryNotePdfDisplay.Name = "DeliveryNotePdfDisplay";
			this.DeliveryNotePdfDisplay.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("DeliveryNotePdfDisplay.OcxState")));
			this.DeliveryNotePdfDisplay.Size = new System.Drawing.Size(1125, 689);
			this.DeliveryNotePdfDisplay.TabIndex = 21;
			// 
			// DeliveryNotesList
			// 
			this.DeliveryNotesList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.DeliveryNotesList.FormattingEnabled = true;
			this.DeliveryNotesList.Location = new System.Drawing.Point(314, 74);
			this.DeliveryNotesList.Margin = new System.Windows.Forms.Padding(2);
			this.DeliveryNotesList.Name = "DeliveryNotesList";
			this.DeliveryNotesList.Size = new System.Drawing.Size(325, 27);
			this.DeliveryNotesList.TabIndex = 25;
			this.DeliveryNotesList.SelectedIndexChanged += new System.EventHandler(this.DeliveryNotesList_SelectedIndexChanged);
			// 
			// DeliveryNotesMonths
			// 
			this.DeliveryNotesMonths.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.DeliveryNotesMonths.FormattingEnabled = true;
			this.DeliveryNotesMonths.Location = new System.Drawing.Point(314, 31);
			this.DeliveryNotesMonths.Margin = new System.Windows.Forms.Padding(2);
			this.DeliveryNotesMonths.Name = "DeliveryNotesMonths";
			this.DeliveryNotesMonths.Size = new System.Drawing.Size(325, 27);
			this.DeliveryNotesMonths.TabIndex = 24;
			this.DeliveryNotesMonths.SelectedIndexChanged += new System.EventHandler(this.DeliveryNotesMonths_SelectedIndexChanged);
			// 
			// DeliveryNotesMonth
			// 
			this.DeliveryNotesMonth.AutoSize = true;
			this.DeliveryNotesMonth.Location = new System.Drawing.Point(54, 34);
			this.DeliveryNotesMonth.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.DeliveryNotesMonth.Name = "DeliveryNotesMonth";
			this.DeliveryNotesMonth.Size = new System.Drawing.Size(117, 19);
			this.DeliveryNotesMonth.TabIndex = 23;
			this.DeliveryNotesMonth.Text = "Select Month";
			// 
			// DeliveryNotesPrevLabel
			// 
			this.DeliveryNotesPrevLabel.AutoSize = true;
			this.DeliveryNotesPrevLabel.Location = new System.Drawing.Point(53, 77);
			this.DeliveryNotesPrevLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.DeliveryNotesPrevLabel.Name = "DeliveryNotesPrevLabel";
			this.DeliveryNotesPrevLabel.Size = new System.Drawing.Size(216, 19);
			this.DeliveryNotesPrevLabel.TabIndex = 22;
			this.DeliveryNotesPrevLabel.Text = "Previous Delivery Notes";
			// 
			// DeliveryNoteGenerate
			// 
			this.DeliveryNoteGenerate.Location = new System.Drawing.Point(62, 458);
			this.DeliveryNoteGenerate.Margin = new System.Windows.Forms.Padding(2);
			this.DeliveryNoteGenerate.Name = "DeliveryNoteGenerate";
			this.DeliveryNoteGenerate.Size = new System.Drawing.Size(171, 54);
			this.DeliveryNoteGenerate.TabIndex = 19;
			this.DeliveryNoteGenerate.Text = "Generate Delivery Note";
			this.DeliveryNoteGenerate.UseVisualStyleBackColor = true;
			this.DeliveryNoteGenerate.Click += new System.EventHandler(this.DeliveryNoteGenerate_Click);
			// 
			// DeliveryNoteGridLabel
			// 
			this.DeliveryNoteGridLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.DeliveryNoteGridLabel.AutoSize = true;
			this.DeliveryNoteGridLabel.Location = new System.Drawing.Point(926, 12);
			this.DeliveryNoteGridLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.DeliveryNoteGridLabel.Name = "DeliveryNoteGridLabel";
			this.DeliveryNoteGridLabel.Size = new System.Drawing.Size(198, 19);
			this.DeliveryNoteGridLabel.TabIndex = 18;
			this.DeliveryNoteGridLabel.Text = "ITEMS TO BE DELIVERED";
			// 
			// DeliveryNoteGrid
			// 
			this.DeliveryNoteGrid.AllowUserToDeleteRows = false;
			this.DeliveryNoteGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.DeliveryNoteGrid.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
			this.DeliveryNoteGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.DeliveryNoteGrid.Location = new System.Drawing.Point(667, 34);
			this.DeliveryNoteGrid.Margin = new System.Windows.Forms.Padding(2);
			this.DeliveryNoteGrid.Name = "DeliveryNoteGrid";
			this.DeliveryNoteGrid.RowHeadersWidth = 51;
			this.DeliveryNoteGrid.RowTemplate.Height = 24;
			this.DeliveryNoteGrid.Size = new System.Drawing.Size(710, 654);
			this.DeliveryNoteGrid.TabIndex = 17;
			// 
			// DeliveryVehicleTypePicture
			// 
			this.DeliveryVehicleTypePicture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.DeliveryVehicleTypePicture.Location = new System.Drawing.Point(314, 459);
			this.DeliveryVehicleTypePicture.Margin = new System.Windows.Forms.Padding(2);
			this.DeliveryVehicleTypePicture.Name = "DeliveryVehicleTypePicture";
			this.DeliveryVehicleTypePicture.Size = new System.Drawing.Size(325, 212);
			this.DeliveryVehicleTypePicture.TabIndex = 16;
			this.DeliveryVehicleTypePicture.TabStop = false;
			// 
			// DeliveryVehicleType
			// 
			this.DeliveryVehicleType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.DeliveryVehicleType.FormattingEnabled = true;
			this.DeliveryVehicleType.Location = new System.Drawing.Point(314, 412);
			this.DeliveryVehicleType.Margin = new System.Windows.Forms.Padding(2);
			this.DeliveryVehicleType.Name = "DeliveryVehicleType";
			this.DeliveryVehicleType.Size = new System.Drawing.Size(325, 27);
			this.DeliveryVehicleType.TabIndex = 15;
			// 
			// DeliveryVehicleReg
			// 
			this.DeliveryVehicleReg.Location = new System.Drawing.Point(314, 372);
			this.DeliveryVehicleReg.Margin = new System.Windows.Forms.Padding(2);
			this.DeliveryVehicleReg.Name = "DeliveryVehicleReg";
			this.DeliveryVehicleReg.Size = new System.Drawing.Size(326, 26);
			this.DeliveryVehicleReg.TabIndex = 14;
			// 
			// DeliveryDriverCell
			// 
			this.DeliveryDriverCell.Location = new System.Drawing.Point(314, 330);
			this.DeliveryDriverCell.Margin = new System.Windows.Forms.Padding(2);
			this.DeliveryDriverCell.Name = "DeliveryDriverCell";
			this.DeliveryDriverCell.Size = new System.Drawing.Size(326, 26);
			this.DeliveryDriverCell.TabIndex = 13;
			// 
			// DeliveryDriverName
			// 
			this.DeliveryDriverName.Location = new System.Drawing.Point(314, 288);
			this.DeliveryDriverName.Margin = new System.Windows.Forms.Padding(2);
			this.DeliveryDriverName.Name = "DeliveryDriverName";
			this.DeliveryDriverName.Size = new System.Drawing.Size(326, 26);
			this.DeliveryDriverName.TabIndex = 12;
			// 
			// DeliverVehicleTypeLabel
			// 
			this.DeliverVehicleTypeLabel.AutoSize = true;
			this.DeliverVehicleTypeLabel.Location = new System.Drawing.Point(58, 414);
			this.DeliverVehicleTypeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.DeliverVehicleTypeLabel.Name = "DeliverVehicleTypeLabel";
			this.DeliverVehicleTypeLabel.Size = new System.Drawing.Size(117, 19);
			this.DeliverVehicleTypeLabel.TabIndex = 11;
			this.DeliverVehicleTypeLabel.Text = "Vehicle Type";
			// 
			// DeliveryVehicleRegLabel
			// 
			this.DeliveryVehicleRegLabel.AutoSize = true;
			this.DeliveryVehicleRegLabel.Location = new System.Drawing.Point(57, 375);
			this.DeliveryVehicleRegLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.DeliveryVehicleRegLabel.Name = "DeliveryVehicleRegLabel";
			this.DeliveryVehicleRegLabel.Size = new System.Drawing.Size(189, 19);
			this.DeliveryVehicleRegLabel.TabIndex = 10;
			this.DeliveryVehicleRegLabel.Text = "Vehicle Registration";
			// 
			// DeliveryDriverCellLabel
			// 
			this.DeliveryDriverCellLabel.AutoSize = true;
			this.DeliveryDriverCellLabel.Location = new System.Drawing.Point(56, 334);
			this.DeliveryDriverCellLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.DeliveryDriverCellLabel.Name = "DeliveryDriverCellLabel";
			this.DeliveryDriverCellLabel.Size = new System.Drawing.Size(171, 19);
			this.DeliveryDriverCellLabel.TabIndex = 9;
			this.DeliveryDriverCellLabel.Text = "Driver Cell Number";
			// 
			// DeliveryDriverNameLabel
			// 
			this.DeliveryDriverNameLabel.AutoSize = true;
			this.DeliveryDriverNameLabel.Location = new System.Drawing.Point(58, 294);
			this.DeliveryDriverNameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.DeliveryDriverNameLabel.Name = "DeliveryDriverNameLabel";
			this.DeliveryDriverNameLabel.Size = new System.Drawing.Size(108, 19);
			this.DeliveryDriverNameLabel.TabIndex = 8;
			this.DeliveryDriverNameLabel.Text = "Driver Name";
			// 
			// DeliveryCompanyNameLabel
			// 
			this.DeliveryCompanyNameLabel.AllowDrop = true;
			this.DeliveryCompanyNameLabel.AutoSize = true;
			this.DeliveryCompanyNameLabel.Location = new System.Drawing.Point(57, 255);
			this.DeliveryCompanyNameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.DeliveryCompanyNameLabel.Name = "DeliveryCompanyNameLabel";
			this.DeliveryCompanyNameLabel.Size = new System.Drawing.Size(72, 19);
			this.DeliveryCompanyNameLabel.TabIndex = 7;
			this.DeliveryCompanyNameLabel.Text = "Company";
			// 
			// DeliveryCompaniesList
			// 
			this.DeliveryCompaniesList.AllowDrop = true;
			this.DeliveryCompaniesList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.DeliveryCompaniesList.FormattingEnabled = true;
			this.DeliveryCompaniesList.Location = new System.Drawing.Point(314, 246);
			this.DeliveryCompaniesList.Margin = new System.Windows.Forms.Padding(2);
			this.DeliveryCompaniesList.Name = "DeliveryCompaniesList";
			this.DeliveryCompaniesList.Size = new System.Drawing.Size(326, 27);
			this.DeliveryCompaniesList.TabIndex = 6;
			// 
			// DeliveryAddItem
			// 
			this.DeliveryAddItem.Location = new System.Drawing.Point(314, 198);
			this.DeliveryAddItem.Margin = new System.Windows.Forms.Padding(2);
			this.DeliveryAddItem.Name = "DeliveryAddItem";
			this.DeliveryAddItem.Size = new System.Drawing.Size(190, 31);
			this.DeliveryAddItem.TabIndex = 5;
			this.DeliveryAddItem.Text = "Add Item";
			this.DeliveryAddItem.UseVisualStyleBackColor = true;
			this.DeliveryAddItem.Click += new System.EventHandler(this.DeliveryAddItem_Click);
			// 
			// DeliveryQuantityBox
			// 
			this.DeliveryQuantityBox.AllowDrop = true;
			this.DeliveryQuantityBox.DecimalPlaces = 3;
			this.DeliveryQuantityBox.Location = new System.Drawing.Point(314, 156);
			this.DeliveryQuantityBox.Margin = new System.Windows.Forms.Padding(2);
			this.DeliveryQuantityBox.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
			this.DeliveryQuantityBox.Name = "DeliveryQuantityBox";
			this.DeliveryQuantityBox.Size = new System.Drawing.Size(197, 26);
			this.DeliveryQuantityBox.TabIndex = 4;
			// 
			// DeliveryQuantityLabel
			// 
			this.DeliveryQuantityLabel.AllowDrop = true;
			this.DeliveryQuantityLabel.AutoSize = true;
			this.DeliveryQuantityLabel.Location = new System.Drawing.Point(55, 158);
			this.DeliveryQuantityLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.DeliveryQuantityLabel.Name = "DeliveryQuantityLabel";
			this.DeliveryQuantityLabel.Size = new System.Drawing.Size(81, 19);
			this.DeliveryQuantityLabel.TabIndex = 3;
			this.DeliveryQuantityLabel.Text = "Quantity";
			// 
			// DeliveryItemsList
			// 
			this.DeliveryItemsList.AllowDrop = true;
			this.DeliveryItemsList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.DeliveryItemsList.FormattingEnabled = true;
			this.DeliveryItemsList.Location = new System.Drawing.Point(314, 115);
			this.DeliveryItemsList.Margin = new System.Windows.Forms.Padding(2);
			this.DeliveryItemsList.Name = "DeliveryItemsList";
			this.DeliveryItemsList.Size = new System.Drawing.Size(326, 27);
			this.DeliveryItemsList.TabIndex = 2;
			// 
			// DeliveryItemsLabel
			// 
			this.DeliveryItemsLabel.AutoSize = true;
			this.DeliveryItemsLabel.Location = new System.Drawing.Point(55, 118);
			this.DeliveryItemsLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.DeliveryItemsLabel.Name = "DeliveryItemsLabel";
			this.DeliveryItemsLabel.Size = new System.Drawing.Size(54, 19);
			this.DeliveryItemsLabel.TabIndex = 1;
			this.DeliveryItemsLabel.Text = "Items";
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
			this.comboBox1.Size = new System.Drawing.Size(191, 21);
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
			this.numericUpDown1.Size = new System.Drawing.Size(73, 20);
			this.numericUpDown1.TabIndex = 52;
			this.numericUpDown1.ThousandsSeparator = true;
			// 
			// comboBox2
			// 
			this.comboBox2.DropDownHeight = 300;
			this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBox2.FormattingEnabled = true;
			this.comboBox2.IntegralHeight = false;
			this.comboBox2.ItemHeight = 13;
			this.comboBox2.Location = new System.Drawing.Point(81, 33);
			this.comboBox2.Margin = new System.Windows.Forms.Padding(2);
			this.comboBox2.Name = "comboBox2";
			this.comboBox2.Size = new System.Drawing.Size(59, 21);
			this.comboBox2.TabIndex = 51;
			// 
			// comboBox3
			// 
			this.comboBox3.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.comboBox3.DropDownHeight = 300;
			this.comboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBox3.FormattingEnabled = true;
			this.comboBox3.IntegralHeight = false;
			this.comboBox3.ItemHeight = 13;
			this.comboBox3.Location = new System.Drawing.Point(181, 284);
			this.comboBox3.Margin = new System.Windows.Forms.Padding(2);
			this.comboBox3.Name = "comboBox3";
			this.comboBox3.Size = new System.Drawing.Size(72, 21);
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
			this.textBox1.Size = new System.Drawing.Size(136, 20);
			this.textBox1.TabIndex = 48;
			// 
			// textBox2
			// 
			this.textBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.textBox2.Location = new System.Drawing.Point(106, 238);
			this.textBox2.Margin = new System.Windows.Forms.Padding(2);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(136, 20);
			this.textBox2.TabIndex = 47;
			// 
			// textBox3
			// 
			this.textBox3.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.textBox3.Location = new System.Drawing.Point(106, 100);
			this.textBox3.Margin = new System.Windows.Forms.Padding(2);
			this.textBox3.Name = "textBox3";
			this.textBox3.ReadOnly = true;
			this.textBox3.Size = new System.Drawing.Size(136, 20);
			this.textBox3.TabIndex = 46;
			// 
			// textBox4
			// 
			this.textBox4.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.textBox4.Location = new System.Drawing.Point(106, 64);
			this.textBox4.Margin = new System.Windows.Forms.Padding(2);
			this.textBox4.Name = "textBox4";
			this.textBox4.ReadOnly = true;
			this.textBox4.Size = new System.Drawing.Size(136, 20);
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
			this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
			this.AutoSize = true;
			this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.BackColor = System.Drawing.Color.LightGray;
			this.ClientSize = new System.Drawing.Size(1386, 722);
			this.Controls.Add(this.mainTabControl);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(2);
			this.MaximizeBox = false;
			this.MinimumSize = new System.Drawing.Size(82, 481);
			this.Name = "Main_Form";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Green Enviro SA Recycling";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_Form_FormClosing);
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Main_Form_FormClosed);
			this.mainTabControl.ResumeLayout(false);
			this.ReceiptPage.ResumeLayout(false);
			this.ReceiptPage.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.ReceiptItemPrice)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ReceiptItemQuantity)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ReceiptIDPicture)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
			this.PurchasesPage.ResumeLayout(false);
			this.PurchasesPage.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.PurchasesLogGridView)).EndInit();
			this.SalesPage.ResumeLayout(false);
			this.SalesPage.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.SaleAmount)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.SaleQuantity)).EndInit();
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
			this.SalesPR.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.salesPRDataGridView)).EndInit();
			this.PurchasesPR.ResumeLayout(false);
			this.PurchasesPR.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.PurchasesPRDataGridView)).EndInit();
			this.Summaries.ResumeLayout(false);
			this.Summaries.PerformLayout();
			this.DestructionCertificates.ResumeLayout(false);
			this.DestructionCertificates.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.DestructionCertQntty)).EndInit();
			this.DeliveryNote.ResumeLayout(false);
			this.DeliveryNote.PerformLayout();
			this.DeliveryNoteDisplayPanel.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.DeliveryNotePdfDisplay)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DeliveryNoteGrid)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DeliveryVehicleTypePicture)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DeliveryQuantityBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TabControl mainTabControl;
		private System.Windows.Forms.TabPage ReceiptPage;
		private System.Windows.Forms.Button ReceiptAddItemBtn;
		private System.Windows.Forms.TabPage PurchasesPage;
		private System.Windows.Forms.TabPage SalesPage;
		private System.Windows.Forms.Label ReceiptItemLabel;
		private System.Windows.Forms.BindingSource bindingSource1;

		/// <summary>
		/// ComboBox for containing the design and contents of the receipt
		/// </summary>
		public System.Windows.Forms.RichTextBox ReceiptSlip;

		/// <summary>
		/// List of Items that the company buys
		/// </summary>
		public System.Windows.Forms.ComboBox ReceiptItems;
		private System.Windows.Forms.Label ReceiptItemQuantityLabel;

		/// <summary>
		/// Picturebox for inserting the company logo that will go on the receipt
		/// </summary>
		public System.Windows.Forms.PictureBox logo;

		private System.Windows.Forms.Label ReceiptItemPriceLabel;

		/// <summary>
		///  Check box that will allow users to chose whether to use dealer prices or not
		/// </summary>
		public System.Windows.Forms.CheckBox ReceiptDealerPrice;

		/// <summary>
		/// Check box for selecting whether users can manually insert the price of items or not
		/// </summary>
		public System.Windows.Forms.CheckBox ReceiptPriceOverride;

		/// <summary>
		/// Field that will show the ID Number of the selected customer
		/// </summary>
		public System.Windows.Forms.TextBox ReceiptCustomerID;

		private System.Windows.Forms.Label ReceiptCustomerIDLabel;

		private System.Windows.Forms.Label label4;

		/// <summary>
		/// Combo box from where the customer numbers can be selected
		/// </summary>
		public System.Windows.Forms.ComboBox ReceiptCustomerNumbers;

		/// <summary>
		/// Field that will show the name of the selected customer. 
		/// Selecting customers can only be done using the customer numbers combo box
		/// </summary>
		public System.Windows.Forms.TextBox ReceiptCustomerName;

		/// <summary>
		/// Field that will show the surname of the selected customer. 
		/// Selecting customers can only be done using the customer numbers combo box
		/// </summary>
		public System.Windows.Forms.TextBox ReceiptCustomerSurname;

		private System.Windows.Forms.Label ReceiptCustomerNameLabel;

		private System.Windows.Forms.Label ReceiptCustomerSurnameLabel;

		/// <summary>
		/// Picture box that will show the ID Picture of the selected customer. 
		/// Selecting customers can only be done using the customer numbers combo box
		/// </summary>
		public System.Windows.Forms.PictureBox ReceiptIDPicture;

		private System.Windows.Forms.Button ReceiptPurchaseBtn;

		private System.Windows.Forms.Button ReceiptCancelBtn;

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

		private System.Windows.Forms.Button PurchaseLogFilterBtn;

		private System.Windows.Forms.Label PurchaseLogMonthLabel;


		/// <summary>
		/// Combo box used to select the month for which the user wants to view purchase logs
		/// </summary>
		public System.Windows.Forms.ComboBox PurchaseLogMonth;
		private System.Windows.Forms.Label PurchaseLogTypeLabel;
		private System.Windows.Forms.Label PurchaseLogEndDateLabel;
		private System.Windows.Forms.Label PurchaseLogStartDateLabel;

		/// <summary>
		/// Data Grid View for viewing all the purchase logs
		/// </summary>
		public System.Windows.Forms.DataGridView PurchasesLogGridView;
		private System.Windows.Forms.Button PurchaseLogRemoveFiltersBtn;
		private System.Windows.Forms.Label SaleTypeLabel;
		private System.Windows.Forms.Label SaleQuantityLabel;
		private System.Windows.Forms.Label SaleCompanyLabel;
		private System.Windows.Forms.Label SaleDateLabel;
		private System.Windows.Forms.Label SaleAmountLabel;
		private System.Windows.Forms.Button SalesClearBtn;
		private System.Windows.Forms.Button SaleAddBtn;
		private System.Windows.Forms.Button SalesLogRemoveFiltersBtn;
		private System.Windows.Forms.Button SalesLogFilterBtn;
		private System.Windows.Forms.Label SalesLogMonthLabel;
		public System.Windows.Forms.ComboBox SalesLogMonth;
		private System.Windows.Forms.Label SaleItemTypeLabel;
		private System.Windows.Forms.Label SalesLogEndDateLabel;
		private System.Windows.Forms.Label SalesLogStartDateLabel;
		public System.Windows.Forms.ComboBox SalesLogType;
		public System.Windows.Forms.ComboBox SalesLogEndDate;
		public System.Windows.Forms.ComboBox SalesLogStartDate;
        private System.Windows.Forms.TabPage DestructionCertificates;
        private System.Windows.Forms.Button DestructionCertGenBtn;
        private System.Windows.Forms.Label DestructionCertExtractionDateLabel;
        private System.Windows.Forms.Label DestructionCertCntactPersonLabel;
        private System.Windows.Forms.Label DestructionCertCntactNumLabel;
        private System.Windows.Forms.Label DestructionCertEmailAddressLabel;
        private System.Windows.Forms.Label DestructionCertDescripOfPrdctLabel;
        private System.Windows.Forms.Label DestructionCertCompanyLabel;
        private System.Windows.Forms.Label DestructionCertQnttyLabel;
		public System.Windows.Forms.DateTimePicker SaleDate;
		public System.Windows.Forms.ComboBox SaleType;
		public System.Windows.Forms.ComboBox SaleCompanyName;
		public System.Windows.Forms.DataGridView SalesLogGridView;
		private Green_Enviro_DataDataSetTableAdapters.CustomersTableAdapter customersTableAdapter1;
		public System.Windows.Forms.NumericUpDown SaleQuantity;
		public System.Windows.Forms.NumericUpDown ReceiptItemPrice;
		public System.Windows.Forms.NumericUpDown ReceiptItemQuantity;
		public System.Windows.Forms.NumericUpDown SaleAmount;
		private System.Windows.Forms.TabPage WagesNewEmployee;
		private System.Windows.Forms.TabPage Expenses;
		private System.Windows.Forms.TabPage Summaries;
		private System.Windows.Forms.Button ReceiptEditItemsBtn;
		private System.Windows.Forms.Button ExpensesLogRemoveFiltersBtn;
		private System.Windows.Forms.Button ExpensesLogFilterBtn;
		private System.Windows.Forms.Label ExpensesLogMonthsLabel;
		private System.Windows.Forms.Label ExpensesLogEndDateLabel;
		private System.Windows.Forms.Label ExpensesLogStartDateLabel;
		private System.Windows.Forms.Button ExpenseClearBtn;
		private System.Windows.Forms.Button ExpenseAddBtn;
		private System.Windows.Forms.Label ExpenseAmountLabel;
		private System.Windows.Forms.Label ExpenseDescriptionLabel;
		private System.Windows.Forms.Label ExpenseDateLabel;
		public System.Windows.Forms.DataGridView WageLogGridView;
		private System.Windows.Forms.Button WageClearFieldsBtn;
		private System.Windows.Forms.Button WageAddBtn;
		private System.Windows.Forms.Label WageAmountLabel;
		private System.Windows.Forms.Label WageEmployeeLabel;
		private System.Windows.Forms.Label WagesDateLabel;
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
		private System.Windows.Forms.Label SummariesMonthsLabel;
		private System.Windows.Forms.Label SummariesExpensesLabel;
		private System.Windows.Forms.Label SummariesWagesLabel;
		private System.Windows.Forms.Label SummariesNFSalesLabel;
		private System.Windows.Forms.Label SummariesNFPurchasesLabel;
		private System.Windows.Forms.Label SummariesFSalesLabel;
		private System.Windows.Forms.Label SummariesFPurchasesLabel;
		private System.Windows.Forms.Label SummariesProfitLabel;
		private System.Windows.Forms.Button ReceiptEditCustomers;
		public System.Windows.Forms.CheckBox ReceiptDefaultCustomerCheckBox;
		private System.Windows.Forms.Button ReceiptReprintBtn;
		private System.Windows.Forms.Button ReceiptAddFloatBtn;
		private System.Windows.Forms.Label ReceiptFloatLabel;
		public System.Windows.Forms.TextBox ReceiptFloat;
        private System.Windows.Forms.Button DestructionCertEmailBtn;
		private System.Windows.Forms.Label SummariesTotalSalesLabel;
		private System.Windows.Forms.Label SummariesTotalPurchasesLabel;
		public System.Windows.Forms.ComboBox ReceiptTransactionType;
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
		private System.Windows.Forms.Button WagesEditEmployeesBtn;
		private System.Windows.Forms.Button LogOutBtn;
		public System.Windows.Forms.ComboBox InvetorySummedOrNot;
		private System.Windows.Forms.Label label62;
		public System.Windows.Forms.ComboBox InventoryLogType;
		private System.Windows.Forms.Label label63;
		private System.Windows.Forms.Button AddToPRBtn;
		public System.Windows.Forms.TextBox ReceiptCustomerAddress;
		public System.Windows.Forms.TextBox ReceiptCustomerCellNum;
		private System.Windows.Forms.Label ReceiptCustomerAddressLabel;
		private System.Windows.Forms.Label ReceiptCustomerCellNumLabel;
		private System.Windows.Forms.TabPage SalesPR;
		private System.Windows.Forms.TabPage PurchasesPR;
		private System.Windows.Forms.Button PrintPRBtn;
		private System.Windows.Forms.Button RemovePRFiltersBtn;
		private System.Windows.Forms.Button FilterPRBtn;
		private System.Windows.Forms.Label label66;
		public System.Windows.Forms.ComboBox PurchasesPRMonth;
		private System.Windows.Forms.Label label67;
		private System.Windows.Forms.Label label68;
		private System.Windows.Forms.Label label69;
		public System.Windows.Forms.ComboBox PurchasePRType;
		public System.Windows.Forms.ComboBox PurchasePREndDate;
		public System.Windows.Forms.ComboBox PurchasePRStartDate;
		private System.Windows.Forms.ColorDialog colorDialog1;
		public System.Windows.Forms.Label ReceiptTransactionTypeIndicator;
		private System.Windows.Forms.Button PurchaseDeleteBtn;
		private System.Windows.Forms.Button ExpensesDeleteBtn;
		private System.Windows.Forms.Button SalesLogDeleteBtn;
		private System.Windows.Forms.Button button6;
		public System.Windows.Forms.DataGridView PurchasesPRDataGridView;
		public System.Windows.Forms.DataGridView salesPRDataGridView;
		private System.Windows.Forms.TabPage DeliveryNote;
		private System.Windows.Forms.ComboBox DeliveryItemsList;
		private System.Windows.Forms.Label DeliveryItemsLabel;
		private System.Windows.Forms.Button DeliveryAddItem;
		private System.Windows.Forms.NumericUpDown DeliveryQuantityBox;
		private System.Windows.Forms.Label DeliveryQuantityLabel;
		private System.Windows.Forms.Label DeliveryCompanyNameLabel;
		private System.Windows.Forms.ComboBox DeliveryCompaniesList;
		private System.Windows.Forms.Label DeliverVehicleTypeLabel;
		private System.Windows.Forms.Label DeliveryVehicleRegLabel;
		private System.Windows.Forms.Label DeliveryDriverCellLabel;
		private System.Windows.Forms.Label DeliveryDriverNameLabel;
		private System.Windows.Forms.ComboBox DeliveryVehicleType;
		private System.Windows.Forms.TextBox DeliveryVehicleReg;
		private System.Windows.Forms.TextBox DeliveryDriverCell;
		private System.Windows.Forms.TextBox DeliveryDriverName;
		private System.Windows.Forms.Label DeliveryNoteGridLabel;
		private System.Windows.Forms.DataGridView DeliveryNoteGrid;
		private System.Windows.Forms.PictureBox DeliveryVehicleTypePicture;
		private System.Windows.Forms.Button DeliveryNoteGenerate;
		private AxAcroPDFLib.AxAcroPDF DeliveryNotePdfDisplay;
		private System.Windows.Forms.ComboBox DeliveryNotesList;
		private System.Windows.Forms.ComboBox DeliveryNotesMonths;
		private System.Windows.Forms.Label DeliveryNotesMonth;
		private System.Windows.Forms.Label DeliveryNotesPrevLabel;
		private System.Windows.Forms.Panel DeliveryNoteDisplayPanel;
		private System.Windows.Forms.Button DeliveryNoteCancel;
		private System.Windows.Forms.Button DeliveryNotePrint;
		private System.Windows.Forms.CheckBox DestructionCertNewCompanyCheckbox;
		private System.Windows.Forms.TextBox DestructionCertCmpnyAddress;
		private System.Windows.Forms.Label DestructionCertCmpnyAddressLabel;
		private System.Windows.Forms.NumericUpDown DestructionCertQntty;
		private System.Windows.Forms.ComboBox DestructionCertQnttyUnit;
		private System.Windows.Forms.TextBox DestructionCertDescripOfPrdct;
		private System.Windows.Forms.TextBox DestructionCertEmailAddress;
		private System.Windows.Forms.TextBox DestructionCertCntactNum;
		private System.Windows.Forms.TextBox DestructionCertCntactPerson;
		private System.Windows.Forms.ComboBox DestructionCertCompany;
		private System.Windows.Forms.DateTimePicker DestructionCertExtractionDate;
		private System.Windows.Forms.ComboBox SummariesMonths;
		private System.Windows.Forms.RichTextBox SummariesExpensesBox;
		private System.Windows.Forms.RichTextBox SummariesFSalesBox;
		private System.Windows.Forms.RichTextBox SummariesWagesBox;
		private System.Windows.Forms.RichTextBox SummariesNFPurchasesBox;
		private System.Windows.Forms.RichTextBox SummariesFPurchasesBox;
		private System.Windows.Forms.RichTextBox SummariesProfitBox;
		private System.Windows.Forms.RichTextBox SummariesTotalSales;
		private System.Windows.Forms.RichTextBox SummariesTotalPurchases;
		private System.Windows.Forms.RichTextBox SummariesNFSalesBox;
		private System.Windows.Forms.NumericUpDown WageAmount;
		private System.Windows.Forms.DateTimePicker WageDate;
		private System.Windows.Forms.ComboBox WagesEmployeeName;
		private System.Windows.Forms.CheckBox WagePartTimeEmployeeCheckBox;
		private System.Windows.Forms.DateTimePicker ExpenseDate;
		private System.Windows.Forms.ComboBox ExpensesLogMonths;
		private System.Windows.Forms.ComboBox ExpensesLogEndDate;
		private System.Windows.Forms.ComboBox ExpensesLogStartDate;
		private System.Windows.Forms.DataGridView ExpensesLogGridView;
		private System.Windows.Forms.NumericUpDown ExpenseAmount;
		private System.Windows.Forms.TextBox ExpenseDescription;
		private System.Windows.Forms.Label WagesEndDateLabel;
		private System.Windows.Forms.Button WagesLogRemoveFilterBtn;
		private System.Windows.Forms.ComboBox WageLogEndDate;
		private System.Windows.Forms.Label WagesMonthLabel;
		private System.Windows.Forms.Label WagesStartDateLabel;
		private System.Windows.Forms.Button WagesLogFilterBtn;
		private System.Windows.Forms.ComboBox WageLogStartDate;
		private System.Windows.Forms.ComboBox WageLogMonths;
		private System.Windows.Forms.Button WageDeleteBtn;
		private System.Windows.Forms.Button EditFixedExpensesBtn;
	}
}