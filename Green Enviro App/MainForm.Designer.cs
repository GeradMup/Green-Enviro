
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
            this.PriceBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.quantityBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.logo = new System.Windows.Forms.PictureBox();
            this.itemList = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.addItemBtn = new System.Windows.Forms.Button();
            this.receiptBox = new System.Windows.Forms.RichTextBox();
            this.PurchasesPage = new System.Windows.Forms.TabPage();
            this.removeFiltersBtn = new System.Windows.Forms.Button();
            this.PurchseLogGridView = new System.Windows.Forms.DataGridView();
            this.GeneratePurchaseLogBtn = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.PurchaseLogMonth = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.PurchaseLogType = new System.Windows.Forms.ComboBox();
            this.PurchaseLogEndDate = new System.Windows.Forms.ComboBox();
            this.PurchaseLogStartDate = new System.Windows.Forms.ComboBox();
            this.SalesPage = new System.Windows.Forms.TabPage();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.comboBox5 = new System.Windows.Forms.ComboBox();
            this.comboBox6 = new System.Windows.Forms.ComboBox();
            this.comboBox7 = new System.Windows.Forms.ComboBox();
            this.SalesLogGridView = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.mainTabControl.SuspendLayout();
            this.ReceiptPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IDPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.PurchasesPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PurchseLogGridView)).BeginInit();
            this.SalesPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SalesLogGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // mainTabControl
            // 
            this.mainTabControl.Controls.Add(this.ReceiptPage);
            this.mainTabControl.Controls.Add(this.PurchasesPage);
            this.mainTabControl.Controls.Add(this.SalesPage);
            this.mainTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainTabControl.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainTabControl.Location = new System.Drawing.Point(0, 0);
            this.mainTabControl.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.mainTabControl.Name = "mainTabControl";
            this.mainTabControl.SelectedIndex = 0;
            this.mainTabControl.Size = new System.Drawing.Size(1028, 609);
            this.mainTabControl.TabIndex = 0;
            // 
            // ReceiptPage
            // 
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
            this.ReceiptPage.Controls.Add(this.PriceBox);
            this.ReceiptPage.Controls.Add(this.label3);
            this.ReceiptPage.Controls.Add(this.quantityBox);
            this.ReceiptPage.Controls.Add(this.label2);
            this.ReceiptPage.Controls.Add(this.logo);
            this.ReceiptPage.Controls.Add(this.itemList);
            this.ReceiptPage.Controls.Add(this.label1);
            this.ReceiptPage.Controls.Add(this.addItemBtn);
            this.ReceiptPage.Controls.Add(this.receiptBox);
            this.ReceiptPage.Location = new System.Drawing.Point(4, 28);
            this.ReceiptPage.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ReceiptPage.Name = "ReceiptPage";
            this.ReceiptPage.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ReceiptPage.Size = new System.Drawing.Size(1020, 577);
            this.ReceiptPage.TabIndex = 0;
            this.ReceiptPage.Text = "Receipt";
            this.ReceiptPage.UseVisualStyleBackColor = true;
            // 
            // CancelPurchaseBtn
            // 
            this.CancelPurchaseBtn.AllowDrop = true;
            this.CancelPurchaseBtn.Location = new System.Drawing.Point(139, 534);
            this.CancelPurchaseBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CancelPurchaseBtn.Name = "CancelPurchaseBtn";
            this.CancelPurchaseBtn.Size = new System.Drawing.Size(159, 41);
            this.CancelPurchaseBtn.TabIndex = 24;
            this.CancelPurchaseBtn.Text = "Cancel Purchase";
            this.CancelPurchaseBtn.UseVisualStyleBackColor = true;
            this.CancelPurchaseBtn.Click += new System.EventHandler(this.CancelPurchaseBtn_Click);
            // 
            // PurchaseBtn
            // 
            this.PurchaseBtn.AllowDrop = true;
            this.PurchaseBtn.Location = new System.Drawing.Point(17, 534);
            this.PurchaseBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.PurchaseBtn.Name = "PurchaseBtn";
            this.PurchaseBtn.Size = new System.Drawing.Size(107, 41);
            this.PurchaseBtn.TabIndex = 23;
            this.PurchaseBtn.Text = "Purchase";
            this.PurchaseBtn.UseVisualStyleBackColor = true;
            this.PurchaseBtn.Click += new System.EventHandler(this.PurchaseBtn_Click);
            // 
            // CustomerNameTextBox
            // 
            this.CustomerNameTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.CustomerNameTextBox.Location = new System.Drawing.Point(493, 150);
            this.CustomerNameTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CustomerNameTextBox.Name = "CustomerNameTextBox";
            this.CustomerNameTextBox.ReadOnly = true;
            this.CustomerNameTextBox.Size = new System.Drawing.Size(194, 26);
            this.CustomerNameTextBox.TabIndex = 22;
            // 
            // CustomerSurnameTextBox
            // 
            this.CustomerSurnameTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.CustomerSurnameTextBox.Location = new System.Drawing.Point(510, 203);
            this.CustomerSurnameTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CustomerSurnameTextBox.Name = "CustomerSurnameTextBox";
            this.CustomerSurnameTextBox.ReadOnly = true;
            this.CustomerSurnameTextBox.Size = new System.Drawing.Size(176, 26);
            this.CustomerSurnameTextBox.TabIndex = 21;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(426, 152);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 19);
            this.label7.TabIndex = 20;
            this.label7.Text = "Name";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(426, 206);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 19);
            this.label6.TabIndex = 19;
            this.label6.Text = "Surname";
            // 
            // CustomerIDNumberTextBox
            // 
            this.CustomerIDNumberTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.CustomerIDNumberTextBox.Location = new System.Drawing.Point(469, 94);
            this.CustomerIDNumberTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CustomerIDNumberTextBox.Name = "CustomerIDNumberTextBox";
            this.CustomerIDNumberTextBox.ReadOnly = true;
            this.CustomerIDNumberTextBox.Size = new System.Drawing.Size(218, 26);
            this.CustomerIDNumberTextBox.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(426, 99);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 19);
            this.label5.TabIndex = 17;
            this.label5.Text = "ID";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(426, 40);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(144, 19);
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
            this.customerNumbersList.ItemHeight = 19;
            this.customerNumbersList.Location = new System.Drawing.Point(581, 37);
            this.customerNumbersList.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.customerNumbersList.Name = "customerNumbersList";
            this.customerNumbersList.Size = new System.Drawing.Size(56, 27);
            this.customerNumbersList.TabIndex = 15;
            this.customerNumbersList.SelectedIndexChanged += new System.EventHandler(this.customerNumbersList_SelectedIndexChanged);
            // 
            // IDPictureBox
            // 
            this.IDPictureBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.IDPictureBox.Location = new System.Drawing.Point(248, 266);
            this.IDPictureBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.IDPictureBox.Name = "IDPictureBox";
            this.IDPictureBox.Size = new System.Drawing.Size(437, 348);
            this.IDPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.IDPictureBox.TabIndex = 1;
            this.IDPictureBox.TabStop = false;
            // 
            // DealerPriceCheckBox
            // 
            this.DealerPriceCheckBox.AutoSize = true;
            this.DealerPriceCheckBox.Location = new System.Drawing.Point(22, 83);
            this.DealerPriceCheckBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DealerPriceCheckBox.Name = "DealerPriceCheckBox";
            this.DealerPriceCheckBox.Size = new System.Drawing.Size(136, 23);
            this.DealerPriceCheckBox.TabIndex = 14;
            this.DealerPriceCheckBox.Text = "Dealer Price";
            this.DealerPriceCheckBox.UseVisualStyleBackColor = true;
            // 
            // PriceOverrideCheckBox
            // 
            this.PriceOverrideCheckBox.AutoSize = true;
            this.PriceOverrideCheckBox.Location = new System.Drawing.Point(22, 110);
            this.PriceOverrideCheckBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.PriceOverrideCheckBox.Name = "PriceOverrideCheckBox";
            this.PriceOverrideCheckBox.Size = new System.Drawing.Size(154, 23);
            this.PriceOverrideCheckBox.TabIndex = 13;
            this.PriceOverrideCheckBox.Text = "Override Price";
            this.PriceOverrideCheckBox.UseVisualStyleBackColor = true;
            this.PriceOverrideCheckBox.CheckedChanged += new System.EventHandler(this.PriceOverrideCheckBox_CheckedChanged);
            // 
            // PriceBox
            // 
            this.PriceBox.Location = new System.Drawing.Point(139, 150);
            this.PriceBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.PriceBox.Name = "PriceBox";
            this.PriceBox.ReadOnly = true;
            this.PriceBox.Size = new System.Drawing.Size(150, 26);
            this.PriceBox.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 152);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 19);
            this.label3.TabIndex = 11;
            this.label3.Text = "Price";
            // 
            // quantityBox
            // 
            this.quantityBox.Location = new System.Drawing.Point(139, 199);
            this.quantityBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.quantityBox.Name = "quantityBox";
            this.quantityBox.Size = new System.Drawing.Size(150, 26);
            this.quantityBox.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 202);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 19);
            this.label2.TabIndex = 9;
            this.label2.Text = "Quantity";
            // 
            // logo
            // 
            this.logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.logo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.logo.Image = ((System.Drawing.Image)(resources.GetObject("logo.Image")));
            this.logo.InitialImage = null;
            this.logo.Location = new System.Drawing.Point(828, 5);
            this.logo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(240, 111);
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
            this.itemList.ItemHeight = 19;
            this.itemList.Location = new System.Drawing.Point(136, 37);
            this.itemList.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.itemList.Name = "itemList";
            this.itemList.Size = new System.Drawing.Size(153, 27);
            this.itemList.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 44);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 19);
            this.label1.TabIndex = 3;
            this.label1.Text = "Item";
            // 
            // addItemBtn
            // 
            this.addItemBtn.AllowDrop = true;
            this.addItemBtn.Location = new System.Drawing.Point(17, 473);
            this.addItemBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.addItemBtn.Name = "addItemBtn";
            this.addItemBtn.Size = new System.Drawing.Size(107, 41);
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
            this.receiptBox.Location = new System.Drawing.Point(714, 5);
            this.receiptBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.receiptBox.Name = "receiptBox";
            this.receiptBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.receiptBox.Size = new System.Drawing.Size(301, 525);
            this.receiptBox.TabIndex = 0;
            this.receiptBox.Text = "";
            this.receiptBox.WordWrap = false;
            // 
            // PurchasesPage
            // 
            this.PurchasesPage.Controls.Add(this.removeFiltersBtn);
            this.PurchasesPage.Controls.Add(this.PurchseLogGridView);
            this.PurchasesPage.Controls.Add(this.GeneratePurchaseLogBtn);
            this.PurchasesPage.Controls.Add(this.label11);
            this.PurchasesPage.Controls.Add(this.PurchaseLogMonth);
            this.PurchasesPage.Controls.Add(this.label10);
            this.PurchasesPage.Controls.Add(this.label9);
            this.PurchasesPage.Controls.Add(this.label8);
            this.PurchasesPage.Controls.Add(this.PurchaseLogType);
            this.PurchasesPage.Controls.Add(this.PurchaseLogEndDate);
            this.PurchasesPage.Controls.Add(this.PurchaseLogStartDate);
            this.PurchasesPage.Location = new System.Drawing.Point(4, 28);
            this.PurchasesPage.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.PurchasesPage.Name = "PurchasesPage";
            this.PurchasesPage.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.PurchasesPage.Size = new System.Drawing.Size(1134, 632);
            this.PurchasesPage.TabIndex = 1;
            this.PurchasesPage.Text = "Purchases Logs";
            this.PurchasesPage.UseVisualStyleBackColor = true;
            // 
            // removeFiltersBtn
            // 
            this.removeFiltersBtn.Location = new System.Drawing.Point(254, 79);
            this.removeFiltersBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.removeFiltersBtn.Name = "removeFiltersBtn";
            this.removeFiltersBtn.Size = new System.Drawing.Size(237, 37);
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
            this.PurchseLogGridView.Location = new System.Drawing.Point(6, 133);
            this.PurchseLogGridView.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.PurchseLogGridView.Name = "PurchseLogGridView";
            this.PurchseLogGridView.ReadOnly = true;
            this.PurchseLogGridView.RowHeadersWidth = 51;
            this.PurchseLogGridView.RowTemplate.Height = 24;
            this.PurchseLogGridView.Size = new System.Drawing.Size(1119, 495);
            this.PurchseLogGridView.TabIndex = 17;
            // 
            // GeneratePurchaseLogBtn
            // 
            this.GeneratePurchaseLogBtn.Location = new System.Drawing.Point(37, 79);
            this.GeneratePurchaseLogBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.GeneratePurchaseLogBtn.Name = "GeneratePurchaseLogBtn";
            this.GeneratePurchaseLogBtn.Size = new System.Drawing.Size(149, 37);
            this.GeneratePurchaseLogBtn.TabIndex = 16;
            this.GeneratePurchaseLogBtn.Text = "Filter";
            this.GeneratePurchaseLogBtn.UseVisualStyleBackColor = true;
            this.GeneratePurchaseLogBtn.Click += new System.EventHandler(this.GeneratePurchaseLogBtn_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(34, 17);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(54, 19);
            this.label11.TabIndex = 15;
            this.label11.Text = "Month";
            // 
            // PurchaseLogMonth
            // 
            this.PurchaseLogMonth.DropDownHeight = 300;
            this.PurchaseLogMonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PurchaseLogMonth.FormattingEnabled = true;
            this.PurchaseLogMonth.IntegralHeight = false;
            this.PurchaseLogMonth.ItemHeight = 19;
            this.PurchaseLogMonth.Location = new System.Drawing.Point(37, 38);
            this.PurchaseLogMonth.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.PurchaseLogMonth.Name = "PurchaseLogMonth";
            this.PurchaseLogMonth.Size = new System.Drawing.Size(153, 27);
            this.PurchaseLogMonth.TabIndex = 14;
            this.PurchaseLogMonth.SelectedIndexChanged += new System.EventHandler(this.PurchaseLogMonth_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(842, 17);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(45, 19);
            this.label10.TabIndex = 13;
            this.label10.Text = "Type";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(560, 17);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(81, 19);
            this.label9.TabIndex = 12;
            this.label9.Text = "End Date";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(250, 17);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(99, 19);
            this.label8.TabIndex = 11;
            this.label8.Text = "Start Date";
            // 
            // PurchaseLogType
            // 
            this.PurchaseLogType.DropDownHeight = 300;
            this.PurchaseLogType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PurchaseLogType.FormattingEnabled = true;
            this.PurchaseLogType.IntegralHeight = false;
            this.PurchaseLogType.ItemHeight = 19;
            this.PurchaseLogType.Location = new System.Drawing.Point(845, 38);
            this.PurchaseLogType.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.PurchaseLogType.Name = "PurchaseLogType";
            this.PurchaseLogType.Size = new System.Drawing.Size(153, 27);
            this.PurchaseLogType.TabIndex = 10;
            // 
            // PurchaseLogEndDate
            // 
            this.PurchaseLogEndDate.DropDownHeight = 300;
            this.PurchaseLogEndDate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PurchaseLogEndDate.FormattingEnabled = true;
            this.PurchaseLogEndDate.IntegralHeight = false;
            this.PurchaseLogEndDate.ItemHeight = 19;
            this.PurchaseLogEndDate.Location = new System.Drawing.Point(563, 38);
            this.PurchaseLogEndDate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.PurchaseLogEndDate.Name = "PurchaseLogEndDate";
            this.PurchaseLogEndDate.Size = new System.Drawing.Size(219, 27);
            this.PurchaseLogEndDate.TabIndex = 9;
            // 
            // PurchaseLogStartDate
            // 
            this.PurchaseLogStartDate.DropDownHeight = 300;
            this.PurchaseLogStartDate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PurchaseLogStartDate.FormattingEnabled = true;
            this.PurchaseLogStartDate.IntegralHeight = false;
            this.PurchaseLogStartDate.ItemHeight = 19;
            this.PurchaseLogStartDate.Location = new System.Drawing.Point(254, 38);
            this.PurchaseLogStartDate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.PurchaseLogStartDate.Name = "PurchaseLogStartDate";
            this.PurchaseLogStartDate.Size = new System.Drawing.Size(238, 27);
            this.PurchaseLogStartDate.TabIndex = 8;
            // 
            // SalesPage
            // 
            this.SalesPage.Controls.Add(this.button3);
            this.SalesPage.Controls.Add(this.button4);
            this.SalesPage.Controls.Add(this.label17);
            this.SalesPage.Controls.Add(this.comboBox4);
            this.SalesPage.Controls.Add(this.label18);
            this.SalesPage.Controls.Add(this.label19);
            this.SalesPage.Controls.Add(this.label20);
            this.SalesPage.Controls.Add(this.comboBox5);
            this.SalesPage.Controls.Add(this.comboBox6);
            this.SalesPage.Controls.Add(this.comboBox7);
            this.SalesPage.Controls.Add(this.SalesLogGridView);
            this.SalesPage.Controls.Add(this.button2);
            this.SalesPage.Controls.Add(this.button1);
            this.SalesPage.Controls.Add(this.label16);
            this.SalesPage.Controls.Add(this.textBox1);
            this.SalesPage.Controls.Add(this.comboBox3);
            this.SalesPage.Controls.Add(this.comboBox2);
            this.SalesPage.Controls.Add(this.comboBox1);
            this.SalesPage.Controls.Add(this.label15);
            this.SalesPage.Controls.Add(this.label14);
            this.SalesPage.Controls.Add(this.label13);
            this.SalesPage.Controls.Add(this.label12);
            this.SalesPage.Controls.Add(this.textBox3);
            this.SalesPage.Location = new System.Drawing.Point(4, 28);
            this.SalesPage.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.SalesPage.Name = "SalesPage";
            this.SalesPage.Size = new System.Drawing.Size(1134, 632);
            this.SalesPage.TabIndex = 2;
            this.SalesPage.Text = "Sales Logs";
            this.SalesPage.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.Location = new System.Drawing.Point(504, 76);
            this.button3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(173, 37);
            this.button3.TabIndex = 28;
            this.button3.Text = "Remove Filters";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button4.Location = new System.Drawing.Point(287, 76);
            this.button4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(149, 37);
            this.button4.TabIndex = 27;
            this.button4.Text = "Filter";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // label17
            // 
            this.label17.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(284, 15);
            this.label17.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(54, 19);
            this.label17.TabIndex = 26;
            this.label17.Text = "Month";
            // 
            // comboBox4
            // 
            this.comboBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox4.DropDownHeight = 300;
            this.comboBox4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.IntegralHeight = false;
            this.comboBox4.ItemHeight = 19;
            this.comboBox4.Location = new System.Drawing.Point(287, 36);
            this.comboBox4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(153, 27);
            this.comboBox4.TabIndex = 25;
            // 
            // label18
            // 
            this.label18.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(950, 15);
            this.label18.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(45, 19);
            this.label18.TabIndex = 24;
            this.label18.Text = "Type";
            // 
            // label19
            // 
            this.label19.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(734, 15);
            this.label19.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(81, 19);
            this.label19.TabIndex = 23;
            this.label19.Text = "End Date";
            // 
            // label20
            // 
            this.label20.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(501, 15);
            this.label20.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(99, 19);
            this.label20.TabIndex = 22;
            this.label20.Text = "Start Date";
            // 
            // comboBox5
            // 
            this.comboBox5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox5.DropDownHeight = 300;
            this.comboBox5.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox5.FormattingEnabled = true;
            this.comboBox5.IntegralHeight = false;
            this.comboBox5.ItemHeight = 19;
            this.comboBox5.Location = new System.Drawing.Point(953, 36);
            this.comboBox5.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBox5.Name = "comboBox5";
            this.comboBox5.Size = new System.Drawing.Size(153, 27);
            this.comboBox5.TabIndex = 21;
            // 
            // comboBox6
            // 
            this.comboBox6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox6.DropDownHeight = 300;
            this.comboBox6.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox6.FormattingEnabled = true;
            this.comboBox6.IntegralHeight = false;
            this.comboBox6.ItemHeight = 19;
            this.comboBox6.Location = new System.Drawing.Point(736, 36);
            this.comboBox6.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBox6.Name = "comboBox6";
            this.comboBox6.Size = new System.Drawing.Size(164, 27);
            this.comboBox6.TabIndex = 20;
            // 
            // comboBox7
            // 
            this.comboBox7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox7.DropDownHeight = 300;
            this.comboBox7.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox7.FormattingEnabled = true;
            this.comboBox7.IntegralHeight = false;
            this.comboBox7.ItemHeight = 19;
            this.comboBox7.Location = new System.Drawing.Point(504, 36);
            this.comboBox7.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBox7.Name = "comboBox7";
            this.comboBox7.Size = new System.Drawing.Size(174, 27);
            this.comboBox7.TabIndex = 19;
            // 
            // SalesLogGridView
            // 
            this.SalesLogGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SalesLogGridView.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.SalesLogGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SalesLogGridView.Location = new System.Drawing.Point(273, 140);
            this.SalesLogGridView.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.SalesLogGridView.Name = "SalesLogGridView";
            this.SalesLogGridView.RowHeadersWidth = 51;
            this.SalesLogGridView.RowTemplate.Height = 24;
            this.SalesLogGridView.Size = new System.Drawing.Size(863, 492);
            this.SalesLogGridView.TabIndex = 15;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(146, 227);
            this.button2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(98, 38);
            this.button2.TabIndex = 14;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(9, 227);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(98, 38);
            this.button1.TabIndex = 13;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(6, 178);
            this.label16.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(63, 19);
            this.label16.TabIndex = 12;
            this.label16.Text = "Amount";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(95, 178);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(106, 26);
            this.textBox1.TabIndex = 11;
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(95, 137);
            this.comboBox3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(106, 27);
            this.comboBox3.TabIndex = 10;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(95, 54);
            this.comboBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(160, 27);
            this.comboBox2.TabIndex = 9;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(95, 14);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(160, 27);
            this.comboBox1.TabIndex = 8;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(6, 140);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(45, 19);
            this.label15.TabIndex = 7;
            this.label15.Text = "Type";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(6, 100);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(81, 19);
            this.label14.TabIndex = 6;
            this.label14.Text = "Quantity";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 57);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(72, 19);
            this.label13.TabIndex = 5;
            this.label13.Text = "Company";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 16);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(45, 19);
            this.label12.TabIndex = 4;
            this.label12.Text = "Date";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(95, 98);
            this.textBox3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(106, 26);
            this.textBox3.TabIndex = 2;
            // 
            // Main_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1028, 609);
            this.Controls.Add(this.mainTabControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(79, 495);
            this.Name = "Main_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Green Enviro";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.mainTabControl.ResumeLayout(false);
            this.ReceiptPage.ResumeLayout(false);
            this.ReceiptPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IDPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.PurchasesPage.ResumeLayout(false);
            this.PurchasesPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PurchseLogGridView)).EndInit();
            this.SalesPage.ResumeLayout(false);
            this.SalesPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SalesLogGridView)).EndInit();
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
		/// Field for entering the purchased quantity when adding to the receipt
		/// </summary>
		public System.Windows.Forms.TextBox quantityBox;

		/// <summary>
		/// Picturebox for inserting the company logo that will go on the receipt
		/// </summary>
		public System.Windows.Forms.PictureBox logo;

		/// <summary>
		/// A field where the price of items will appear or can be inserted before inserting into the receipt
		/// </summary>
		public System.Windows.Forms.TextBox PriceBox;

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

		private System.Windows.Forms.Button GeneratePurchaseLogBtn;

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
		private System.Windows.Forms.TextBox textBox3;
		private System.Windows.Forms.Label label16;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.ComboBox comboBox3;
		private System.Windows.Forms.ComboBox comboBox2;
		private System.Windows.Forms.ComboBox comboBox1;
		private System.Windows.Forms.DataGridView SalesLogGridView;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.Label label17;
		public System.Windows.Forms.ComboBox comboBox4;
		private System.Windows.Forms.Label label18;
		private System.Windows.Forms.Label label19;
		private System.Windows.Forms.Label label20;
		public System.Windows.Forms.ComboBox comboBox5;
		public System.Windows.Forms.ComboBox comboBox6;
		public System.Windows.Forms.ComboBox comboBox7;
	}
}