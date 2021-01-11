
namespace Green_Enviro_App
{
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
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.DestrctCertificatePage = new System.Windows.Forms.TabPage();
            this.companyDCField = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.contactPersonDCField = new System.Windows.Forms.TextBox();
            this.emailAddressDCField = new System.Windows.Forms.TextBox();
            this.contactNumbersDCField = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.quantityDCField = new System.Windows.Forms.TextBox();
            this.descriptionOfProductDCField = new System.Windows.Forms.TextBox();
            this.extractionDateDCField = new System.Windows.Forms.TextBox();
            this.generateDCBtn = new System.Windows.Forms.Button();
            this.mainTabControl.SuspendLayout();
            this.ReceiptPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IDPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.PurchasesPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PurchseLogGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.DestrctCertificatePage.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainTabControl
            // 
            this.mainTabControl.Controls.Add(this.ReceiptPage);
            this.mainTabControl.Controls.Add(this.PurchasesPage);
            this.mainTabControl.Controls.Add(this.SalesPage);
            this.mainTabControl.Controls.Add(this.DestrctCertificatePage);
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
            this.logo.Location = new System.Drawing.Point(821, 5);
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
            this.PurchasesPage.Size = new System.Drawing.Size(1020, 577);
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
            this.PurchseLogGridView.Size = new System.Drawing.Size(1005, 440);
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
            this.SalesPage.Location = new System.Drawing.Point(4, 28);
            this.SalesPage.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.SalesPage.Name = "SalesPage";
            this.SalesPage.Size = new System.Drawing.Size(1020, 577);
            this.SalesPage.TabIndex = 2;
            this.SalesPage.Text = "Sales Logs";
            this.SalesPage.UseVisualStyleBackColor = true;
            // 
            // DestrctCertificatePage
            // 
            this.DestrctCertificatePage.Controls.Add(this.generateDCBtn);
            this.DestrctCertificatePage.Controls.Add(this.extractionDateDCField);
            this.DestrctCertificatePage.Controls.Add(this.descriptionOfProductDCField);
            this.DestrctCertificatePage.Controls.Add(this.quantityDCField);
            this.DestrctCertificatePage.Controls.Add(this.label18);
            this.DestrctCertificatePage.Controls.Add(this.label17);
            this.DestrctCertificatePage.Controls.Add(this.label16);
            this.DestrctCertificatePage.Controls.Add(this.contactNumbersDCField);
            this.DestrctCertificatePage.Controls.Add(this.emailAddressDCField);
            this.DestrctCertificatePage.Controls.Add(this.contactPersonDCField);
            this.DestrctCertificatePage.Controls.Add(this.label15);
            this.DestrctCertificatePage.Controls.Add(this.label14);
            this.DestrctCertificatePage.Controls.Add(this.label13);
            this.DestrctCertificatePage.Controls.Add(this.label12);
            this.DestrctCertificatePage.Controls.Add(this.companyDCField);
            this.DestrctCertificatePage.Location = new System.Drawing.Point(4, 28);
            this.DestrctCertificatePage.Name = "DestrctCertificatePage";
            this.DestrctCertificatePage.Size = new System.Drawing.Size(1020, 577);
            this.DestrctCertificatePage.TabIndex = 3;
            this.DestrctCertificatePage.Text = "Destruction Certificate";
            this.DestrctCertificatePage.UseVisualStyleBackColor = true;
            this.DestrctCertificatePage.Click += new System.EventHandler(this.DestrctCertificatePage_Click);
            // 
            // companyDCField
            // 
            this.companyDCField.Location = new System.Drawing.Point(225, 51);
            this.companyDCField.Name = "companyDCField";
            this.companyDCField.Size = new System.Drawing.Size(202, 26);
            this.companyDCField.TabIndex = 0;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(54, 147);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(126, 19);
            this.label12.TabIndex = 4;
            this.label12.Text = "Email Address";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(499, 139);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(144, 19);
            this.label13.TabIndex = 5;
            this.label13.Text = "Contact Numbers";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(80, 54);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(72, 19);
            this.label14.TabIndex = 6;
            this.label14.Text = "Company";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(508, 54);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(135, 19);
            this.label15.TabIndex = 7;
            this.label15.Text = "Contact Person";
            // 
            // contactPersonDCField
            // 
            this.contactPersonDCField.Location = new System.Drawing.Point(665, 51);
            this.contactPersonDCField.Name = "contactPersonDCField";
            this.contactPersonDCField.Size = new System.Drawing.Size(202, 26);
            this.contactPersonDCField.TabIndex = 8;
            // 
            // emailAddressDCField
            // 
            this.emailAddressDCField.Location = new System.Drawing.Point(225, 144);
            this.emailAddressDCField.Name = "emailAddressDCField";
            this.emailAddressDCField.Size = new System.Drawing.Size(202, 26);
            this.emailAddressDCField.TabIndex = 9;
            // 
            // contactNumbersDCField
            // 
            this.contactNumbersDCField.Location = new System.Drawing.Point(665, 136);
            this.contactNumbersDCField.Name = "contactNumbersDCField";
            this.contactNumbersDCField.Size = new System.Drawing.Size(202, 26);
            this.contactNumbersDCField.TabIndex = 10;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(562, 339);
            this.label16.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(81, 19);
            this.label16.TabIndex = 11;
            this.label16.Text = "Quantity";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(54, 339);
            this.label17.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(207, 19);
            this.label17.TabIndex = 12;
            this.label17.Text = "Description of Product";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(54, 241);
            this.label18.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(144, 19);
            this.label18.TabIndex = 13;
            this.label18.Text = "Extraction Date";
            // 
            // quantityDCField
            // 
            this.quantityDCField.Location = new System.Drawing.Point(665, 336);
            this.quantityDCField.Name = "quantityDCField";
            this.quantityDCField.Size = new System.Drawing.Size(202, 26);
            this.quantityDCField.TabIndex = 14;
            // 
            // descriptionOfProductDCField
            // 
            this.descriptionOfProductDCField.Location = new System.Drawing.Point(278, 336);
            this.descriptionOfProductDCField.Name = "descriptionOfProductDCField";
            this.descriptionOfProductDCField.Size = new System.Drawing.Size(202, 26);
            this.descriptionOfProductDCField.TabIndex = 15;
            // 
            // extractionDateDCField
            // 
            this.extractionDateDCField.Location = new System.Drawing.Point(225, 238);
            this.extractionDateDCField.Name = "extractionDateDCField";
            this.extractionDateDCField.Size = new System.Drawing.Size(202, 26);
            this.extractionDateDCField.TabIndex = 16;
            // 
            // generateDCBtn
            // 
            this.generateDCBtn.Location = new System.Drawing.Point(637, 461);
            this.generateDCBtn.Name = "generateDCBtn";
            this.generateDCBtn.Size = new System.Drawing.Size(287, 60);
            this.generateDCBtn.TabIndex = 17;
            this.generateDCBtn.Text = "Generate Certificate";
            this.generateDCBtn.UseVisualStyleBackColor = true;
            this.generateDCBtn.Click += new System.EventHandler(this.generateDCBtn_Click);
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
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.DestrctCertificatePage.ResumeLayout(false);
            this.DestrctCertificatePage.PerformLayout();
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
		public System.Windows.Forms.RichTextBox receiptBox;
		public System.Windows.Forms.ComboBox itemList;
		private System.Windows.Forms.Label label2;
		public System.Windows.Forms.TextBox quantityBox;
		public System.Windows.Forms.PictureBox logo;
		public System.Windows.Forms.TextBox PriceBox;
		private System.Windows.Forms.Label label3;
		public System.Windows.Forms.CheckBox DealerPriceCheckBox;
		public System.Windows.Forms.CheckBox PriceOverrideCheckBox;
		public System.Windows.Forms.TextBox CustomerIDNumberTextBox;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		public System.Windows.Forms.ComboBox customerNumbersList;
		public System.Windows.Forms.TextBox CustomerNameTextBox;
		public System.Windows.Forms.TextBox CustomerSurnameTextBox;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label6;
		public System.Windows.Forms.PictureBox IDPictureBox;
		private System.Windows.Forms.Button PurchaseBtn;
		private System.Windows.Forms.Button CancelPurchaseBtn;
		public System.Windows.Forms.ComboBox PurchaseLogType;
		public System.Windows.Forms.ComboBox PurchaseLogEndDate;
		public System.Windows.Forms.ComboBox PurchaseLogStartDate;
		private System.Windows.Forms.Button GeneratePurchaseLogBtn;
		private System.Windows.Forms.Label label11;
		public System.Windows.Forms.ComboBox PurchaseLogMonth;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label8;
		public System.Windows.Forms.DataGridView PurchseLogGridView;
		private System.Windows.Forms.Button removeFiltersBtn;
        private System.Windows.Forms.TabPage DestrctCertificatePage;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox companyDCField;
        private System.Windows.Forms.Button generateDCBtn;
        private System.Windows.Forms.TextBox extractionDateDCField;
        private System.Windows.Forms.TextBox descriptionOfProductDCField;
        private System.Windows.Forms.TextBox quantityDCField;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox contactNumbersDCField;
        private System.Windows.Forms.TextBox emailAddressDCField;
        private System.Windows.Forms.TextBox contactPersonDCField;
        private System.Windows.Forms.Label label15;
    }
}