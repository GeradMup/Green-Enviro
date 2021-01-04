
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
			this.PurchseLogGridView = new System.Windows.Forms.DataGridView();
			this.GenerateLogBtn = new System.Windows.Forms.Button();
			this.label11 = new System.Windows.Forms.Label();
			this.comboBox4 = new System.Windows.Forms.ComboBox();
			this.label10 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.comboBox3 = new System.Windows.Forms.ComboBox();
			this.comboBox2 = new System.Windows.Forms.ComboBox();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.SalesPage = new System.Windows.Forms.TabPage();
			this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
			this.mainTabControl.SuspendLayout();
			this.ReceiptPage.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.IDPictureBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
			this.PurchasesPage.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.PurchseLogGridView)).BeginInit();
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
			this.mainTabControl.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.mainTabControl.Location = new System.Drawing.Point(0, 0);
			this.mainTabControl.Name = "mainTabControl";
			this.mainTabControl.SelectedIndex = 0;
			this.mainTabControl.Size = new System.Drawing.Size(1514, 816);
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
			this.ReceiptPage.Location = new System.Drawing.Point(4, 32);
			this.ReceiptPage.Name = "ReceiptPage";
			this.ReceiptPage.Padding = new System.Windows.Forms.Padding(3);
			this.ReceiptPage.Size = new System.Drawing.Size(1506, 780);
			this.ReceiptPage.TabIndex = 0;
			this.ReceiptPage.Text = "Receipt";
			this.ReceiptPage.UseVisualStyleBackColor = true;
			// 
			// CancelPurchaseBtn
			// 
			this.CancelPurchaseBtn.AllowDrop = true;
			this.CancelPurchaseBtn.Location = new System.Drawing.Point(185, 657);
			this.CancelPurchaseBtn.Name = "CancelPurchaseBtn";
			this.CancelPurchaseBtn.Size = new System.Drawing.Size(212, 51);
			this.CancelPurchaseBtn.TabIndex = 24;
			this.CancelPurchaseBtn.Text = "Cancel Purchase";
			this.CancelPurchaseBtn.UseVisualStyleBackColor = true;
			this.CancelPurchaseBtn.Click += new System.EventHandler(this.CancelPurchaseBtn_Click);
			// 
			// PurchaseBtn
			// 
			this.PurchaseBtn.AllowDrop = true;
			this.PurchaseBtn.Location = new System.Drawing.Point(23, 657);
			this.PurchaseBtn.Name = "PurchaseBtn";
			this.PurchaseBtn.Size = new System.Drawing.Size(143, 51);
			this.PurchaseBtn.TabIndex = 23;
			this.PurchaseBtn.Text = "Purchase";
			this.PurchaseBtn.UseVisualStyleBackColor = true;
			this.PurchaseBtn.Click += new System.EventHandler(this.PurchaseBtn_Click);
			// 
			// CustomerNameTextBox
			// 
			this.CustomerNameTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.CustomerNameTextBox.Location = new System.Drawing.Point(729, 184);
			this.CustomerNameTextBox.Name = "CustomerNameTextBox";
			this.CustomerNameTextBox.ReadOnly = true;
			this.CustomerNameTextBox.Size = new System.Drawing.Size(257, 31);
			this.CustomerNameTextBox.TabIndex = 22;
			// 
			// CustomerSurnameTextBox
			// 
			this.CustomerSurnameTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.CustomerSurnameTextBox.Location = new System.Drawing.Point(752, 250);
			this.CustomerSurnameTextBox.Name = "CustomerSurnameTextBox";
			this.CustomerSurnameTextBox.ReadOnly = true;
			this.CustomerSurnameTextBox.Size = new System.Drawing.Size(234, 31);
			this.CustomerSurnameTextBox.TabIndex = 21;
			// 
			// label7
			// 
			this.label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(640, 187);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(54, 23);
			this.label7.TabIndex = 20;
			this.label7.Text = "Name";
			// 
			// label6
			// 
			this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(640, 253);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(87, 23);
			this.label6.TabIndex = 19;
			this.label6.Text = "Surname";
			// 
			// CustomerIDNumberTextBox
			// 
			this.CustomerIDNumberTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.CustomerIDNumberTextBox.Location = new System.Drawing.Point(697, 116);
			this.CustomerIDNumberTextBox.Name = "CustomerIDNumberTextBox";
			this.CustomerIDNumberTextBox.ReadOnly = true;
			this.CustomerIDNumberTextBox.Size = new System.Drawing.Size(289, 31);
			this.CustomerIDNumberTextBox.TabIndex = 18;
			// 
			// label5
			// 
			this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(640, 122);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(32, 23);
			this.label5.TabIndex = 17;
			this.label5.Text = "ID";
			// 
			// label4
			// 
			this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(640, 49);
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
			this.customerNumbersList.Location = new System.Drawing.Point(847, 46);
			this.customerNumbersList.Name = "customerNumbersList";
			this.customerNumbersList.Size = new System.Drawing.Size(73, 31);
			this.customerNumbersList.TabIndex = 15;
			this.customerNumbersList.SelectedIndexChanged += new System.EventHandler(this.customerNumbersList_SelectedIndexChanged);
			// 
			// IDPictureBox
			// 
			this.IDPictureBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.IDPictureBox.Location = new System.Drawing.Point(403, 328);
			this.IDPictureBox.Name = "IDPictureBox";
			this.IDPictureBox.Size = new System.Drawing.Size(583, 428);
			this.IDPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.IDPictureBox.TabIndex = 1;
			this.IDPictureBox.TabStop = false;
			// 
			// DealerPriceCheckBox
			// 
			this.DealerPriceCheckBox.AutoSize = true;
			this.DealerPriceCheckBox.Location = new System.Drawing.Point(30, 102);
			this.DealerPriceCheckBox.Name = "DealerPriceCheckBox";
			this.DealerPriceCheckBox.Size = new System.Drawing.Size(164, 27);
			this.DealerPriceCheckBox.TabIndex = 14;
			this.DealerPriceCheckBox.Text = "Dealer Price";
			this.DealerPriceCheckBox.UseVisualStyleBackColor = true;
			// 
			// PriceOverrideCheckBox
			// 
			this.PriceOverrideCheckBox.AutoSize = true;
			this.PriceOverrideCheckBox.Location = new System.Drawing.Point(30, 135);
			this.PriceOverrideCheckBox.Name = "PriceOverrideCheckBox";
			this.PriceOverrideCheckBox.Size = new System.Drawing.Size(186, 27);
			this.PriceOverrideCheckBox.TabIndex = 13;
			this.PriceOverrideCheckBox.Text = "Override Price";
			this.PriceOverrideCheckBox.UseVisualStyleBackColor = true;
			this.PriceOverrideCheckBox.CheckedChanged += new System.EventHandler(this.PriceOverrideCheckBox_CheckedChanged);
			// 
			// PriceBox
			// 
			this.PriceBox.Location = new System.Drawing.Point(185, 184);
			this.PriceBox.Name = "PriceBox";
			this.PriceBox.ReadOnly = true;
			this.PriceBox.Size = new System.Drawing.Size(199, 31);
			this.PriceBox.TabIndex = 12;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(26, 187);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(65, 23);
			this.label3.TabIndex = 11;
			this.label3.Text = "Price";
			// 
			// quantityBox
			// 
			this.quantityBox.Location = new System.Drawing.Point(185, 245);
			this.quantityBox.Name = "quantityBox";
			this.quantityBox.Size = new System.Drawing.Size(199, 31);
			this.quantityBox.TabIndex = 10;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(26, 248);
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
			this.logo.Location = new System.Drawing.Point(1095, 6);
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
			this.itemList.Location = new System.Drawing.Point(181, 46);
			this.itemList.Name = "itemList";
			this.itemList.Size = new System.Drawing.Size(203, 31);
			this.itemList.TabIndex = 7;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(26, 54);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(54, 23);
			this.label1.TabIndex = 3;
			this.label1.Text = "Item";
			// 
			// addItemBtn
			// 
			this.addItemBtn.AllowDrop = true;
			this.addItemBtn.Location = new System.Drawing.Point(23, 582);
			this.addItemBtn.Name = "addItemBtn";
			this.addItemBtn.Size = new System.Drawing.Size(143, 51);
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
			this.receiptBox.Location = new System.Drawing.Point(1095, 6);
			this.receiptBox.Name = "receiptBox";
			this.receiptBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.receiptBox.Size = new System.Drawing.Size(400, 645);
			this.receiptBox.TabIndex = 0;
			this.receiptBox.Text = "";
			this.receiptBox.WordWrap = false;
			// 
			// PurchasesPage
			// 
			this.PurchasesPage.Controls.Add(this.PurchseLogGridView);
			this.PurchasesPage.Controls.Add(this.GenerateLogBtn);
			this.PurchasesPage.Controls.Add(this.label11);
			this.PurchasesPage.Controls.Add(this.comboBox4);
			this.PurchasesPage.Controls.Add(this.label10);
			this.PurchasesPage.Controls.Add(this.label9);
			this.PurchasesPage.Controls.Add(this.label8);
			this.PurchasesPage.Controls.Add(this.comboBox3);
			this.PurchasesPage.Controls.Add(this.comboBox2);
			this.PurchasesPage.Controls.Add(this.comboBox1);
			this.PurchasesPage.Location = new System.Drawing.Point(4, 32);
			this.PurchasesPage.Name = "PurchasesPage";
			this.PurchasesPage.Padding = new System.Windows.Forms.Padding(3);
			this.PurchasesPage.Size = new System.Drawing.Size(1506, 780);
			this.PurchasesPage.TabIndex = 1;
			this.PurchasesPage.Text = "Purchases Logs";
			this.PurchasesPage.UseVisualStyleBackColor = true;
			// 
			// PurchseLogGridView
			// 
			this.PurchseLogGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.PurchseLogGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.PurchseLogGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
			this.PurchseLogGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.PurchseLogGridView.Location = new System.Drawing.Point(8, 167);
			this.PurchseLogGridView.Name = "PurchseLogGridView";
			this.PurchseLogGridView.ReadOnly = true;
			this.PurchseLogGridView.RowHeadersWidth = 51;
			this.PurchseLogGridView.RowTemplate.Height = 24;
			this.PurchseLogGridView.Size = new System.Drawing.Size(1492, 606);
			this.PurchseLogGridView.TabIndex = 17;
			// 
			// GenerateLogBtn
			// 
			this.GenerateLogBtn.Location = new System.Drawing.Point(49, 97);
			this.GenerateLogBtn.Name = "GenerateLogBtn";
			this.GenerateLogBtn.Size = new System.Drawing.Size(199, 45);
			this.GenerateLogBtn.TabIndex = 16;
			this.GenerateLogBtn.Text = "Generate Log";
			this.GenerateLogBtn.UseVisualStyleBackColor = true;
			this.GenerateLogBtn.Click += new System.EventHandler(this.GenerateLogBtn_Click);
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
			// comboBox4
			// 
			this.comboBox4.DropDownHeight = 300;
			this.comboBox4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBox4.FormattingEnabled = true;
			this.comboBox4.IntegralHeight = false;
			this.comboBox4.ItemHeight = 23;
			this.comboBox4.Location = new System.Drawing.Point(49, 47);
			this.comboBox4.Name = "comboBox4";
			this.comboBox4.Size = new System.Drawing.Size(203, 31);
			this.comboBox4.TabIndex = 14;
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Location = new System.Drawing.Point(915, 21);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(54, 23);
			this.label10.TabIndex = 13;
			this.label10.Text = "Type";
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(625, 21);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(98, 23);
			this.label9.TabIndex = 12;
			this.label9.Text = "End Date";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(334, 21);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(120, 23);
			this.label8.TabIndex = 11;
			this.label8.Text = "Start Date";
			// 
			// comboBox3
			// 
			this.comboBox3.DropDownHeight = 300;
			this.comboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBox3.FormattingEnabled = true;
			this.comboBox3.IntegralHeight = false;
			this.comboBox3.ItemHeight = 23;
			this.comboBox3.Location = new System.Drawing.Point(919, 47);
			this.comboBox3.Name = "comboBox3";
			this.comboBox3.Size = new System.Drawing.Size(203, 31);
			this.comboBox3.TabIndex = 10;
			// 
			// comboBox2
			// 
			this.comboBox2.DropDownHeight = 300;
			this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBox2.FormattingEnabled = true;
			this.comboBox2.IntegralHeight = false;
			this.comboBox2.ItemHeight = 23;
			this.comboBox2.Location = new System.Drawing.Point(629, 47);
			this.comboBox2.Name = "comboBox2";
			this.comboBox2.Size = new System.Drawing.Size(203, 31);
			this.comboBox2.TabIndex = 9;
			// 
			// comboBox1
			// 
			this.comboBox1.DropDownHeight = 300;
			this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.IntegralHeight = false;
			this.comboBox1.ItemHeight = 23;
			this.comboBox1.Location = new System.Drawing.Point(338, 47);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(203, 31);
			this.comboBox1.TabIndex = 8;
			// 
			// SalesPage
			// 
			this.SalesPage.Location = new System.Drawing.Point(4, 32);
			this.SalesPage.Name = "SalesPage";
			this.SalesPage.Size = new System.Drawing.Size(1506, 780);
			this.SalesPage.TabIndex = 2;
			this.SalesPage.Text = "Sales Logs";
			this.SalesPage.UseVisualStyleBackColor = true;
			// 
			// Main_Form
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1523, 817);
			this.Controls.Add(this.mainTabControl);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimumSize = new System.Drawing.Size(800, 600);
			this.Name = "Main_Form";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Green Enviro";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Load += new System.EventHandler(this.Main_Form_Load);
			this.mainTabControl.ResumeLayout(false);
			this.ReceiptPage.ResumeLayout(false);
			this.ReceiptPage.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.IDPictureBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
			this.PurchasesPage.ResumeLayout(false);
			this.PurchasesPage.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.PurchseLogGridView)).EndInit();
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
		public System.Windows.Forms.ComboBox comboBox3;
		public System.Windows.Forms.ComboBox comboBox2;
		public System.Windows.Forms.ComboBox comboBox1;
		private System.Windows.Forms.Button GenerateLogBtn;
		private System.Windows.Forms.Label label11;
		public System.Windows.Forms.ComboBox comboBox4;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label8;
		public System.Windows.Forms.DataGridView PurchseLogGridView;
	}
}