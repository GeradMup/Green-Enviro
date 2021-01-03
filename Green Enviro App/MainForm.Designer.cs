
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
			this.SalesPage = new System.Windows.Forms.TabPage();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.UploadDataBtn = new System.Windows.Forms.Button();
			this.UpDownProgressBar = new System.Windows.Forms.ProgressBar();
			this.SyncDataBtn = new System.Windows.Forms.Button();
			this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
			this.PurchaseBtn = new System.Windows.Forms.Button();
			this.mainTabControl.SuspendLayout();
			this.ReceiptPage.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.IDPictureBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
			this.tabPage1.SuspendLayout();
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
			this.mainTabControl.Controls.Add(this.tabPage1);
			this.mainTabControl.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.mainTabControl.Location = new System.Drawing.Point(0, 0);
			this.mainTabControl.Name = "mainTabControl";
			this.mainTabControl.SelectedIndex = 0;
			this.mainTabControl.Size = new System.Drawing.Size(1227, 816);
			this.mainTabControl.TabIndex = 0;
			// 
			// ReceiptPage
			// 
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
			this.ReceiptPage.Size = new System.Drawing.Size(1219, 780);
			this.ReceiptPage.TabIndex = 0;
			this.ReceiptPage.Text = "Receipt";
			this.ReceiptPage.UseVisualStyleBackColor = true;
			// 
			// CustomerNameTextBox
			// 
			this.CustomerNameTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.CustomerNameTextBox.Location = new System.Drawing.Point(511, 184);
			this.CustomerNameTextBox.Name = "CustomerNameTextBox";
			this.CustomerNameTextBox.ReadOnly = true;
			this.CustomerNameTextBox.Size = new System.Drawing.Size(257, 31);
			this.CustomerNameTextBox.TabIndex = 22;
			// 
			// CustomerSurnameTextBox
			// 
			this.CustomerSurnameTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.CustomerSurnameTextBox.Location = new System.Drawing.Point(534, 250);
			this.CustomerSurnameTextBox.Name = "CustomerSurnameTextBox";
			this.CustomerSurnameTextBox.ReadOnly = true;
			this.CustomerSurnameTextBox.Size = new System.Drawing.Size(234, 31);
			this.CustomerSurnameTextBox.TabIndex = 21;
			// 
			// label7
			// 
			this.label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(422, 187);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(54, 23);
			this.label7.TabIndex = 20;
			this.label7.Text = "Name";
			// 
			// label6
			// 
			this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(422, 253);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(87, 23);
			this.label6.TabIndex = 19;
			this.label6.Text = "Surname";
			// 
			// CustomerIDNumberTextBox
			// 
			this.CustomerIDNumberTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.CustomerIDNumberTextBox.Location = new System.Drawing.Point(479, 116);
			this.CustomerIDNumberTextBox.Name = "CustomerIDNumberTextBox";
			this.CustomerIDNumberTextBox.ReadOnly = true;
			this.CustomerIDNumberTextBox.Size = new System.Drawing.Size(289, 31);
			this.CustomerIDNumberTextBox.TabIndex = 18;
			// 
			// label5
			// 
			this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(422, 122);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(32, 23);
			this.label5.TabIndex = 17;
			this.label5.Text = "ID";
			// 
			// label4
			// 
			this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(422, 49);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(175, 23);
			this.label4.TabIndex = 16;
			this.label4.Text = "Customer Number";
			this.label4.Click += new System.EventHandler(this.label4_Click);
			// 
			// customerNumbersList
			// 
			this.customerNumbersList.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.customerNumbersList.DropDownHeight = 300;
			this.customerNumbersList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.customerNumbersList.FormattingEnabled = true;
			this.customerNumbersList.IntegralHeight = false;
			this.customerNumbersList.ItemHeight = 23;
			this.customerNumbersList.Location = new System.Drawing.Point(629, 46);
			this.customerNumbersList.Name = "customerNumbersList";
			this.customerNumbersList.Size = new System.Drawing.Size(73, 31);
			this.customerNumbersList.TabIndex = 15;
			this.customerNumbersList.SelectedIndexChanged += new System.EventHandler(this.customerNumbersList_SelectedIndexChanged);
			// 
			// IDPictureBox
			// 
			this.IDPictureBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.IDPictureBox.Location = new System.Drawing.Point(185, 328);
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
			this.logo.Location = new System.Drawing.Point(780, 9);
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
			this.receiptBox.Location = new System.Drawing.Point(774, 6);
			this.receiptBox.Name = "receiptBox";
			this.receiptBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.receiptBox.Size = new System.Drawing.Size(400, 645);
			this.receiptBox.TabIndex = 0;
			this.receiptBox.Text = "";
			this.receiptBox.WordWrap = false;
			this.receiptBox.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
			// 
			// PurchasesPage
			// 
			this.PurchasesPage.Location = new System.Drawing.Point(4, 32);
			this.PurchasesPage.Name = "PurchasesPage";
			this.PurchasesPage.Padding = new System.Windows.Forms.Padding(3);
			this.PurchasesPage.Size = new System.Drawing.Size(1219, 780);
			this.PurchasesPage.TabIndex = 1;
			this.PurchasesPage.Text = "Purchases";
			this.PurchasesPage.UseVisualStyleBackColor = true;
			// 
			// SalesPage
			// 
			this.SalesPage.Location = new System.Drawing.Point(4, 32);
			this.SalesPage.Name = "SalesPage";
			this.SalesPage.Size = new System.Drawing.Size(1219, 780);
			this.SalesPage.TabIndex = 2;
			this.SalesPage.Text = "Sales";
			this.SalesPage.UseVisualStyleBackColor = true;
			// 
			// tabPage1
			// 
			this.tabPage1.Controls.Add(this.UploadDataBtn);
			this.tabPage1.Controls.Add(this.UpDownProgressBar);
			this.tabPage1.Controls.Add(this.SyncDataBtn);
			this.tabPage1.Location = new System.Drawing.Point(4, 32);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Size = new System.Drawing.Size(1219, 780);
			this.tabPage1.TabIndex = 3;
			this.tabPage1.Text = "Sync ";
			this.tabPage1.UseVisualStyleBackColor = true;
			// 
			// UploadDataBtn
			// 
			this.UploadDataBtn.Location = new System.Drawing.Point(692, 55);
			this.UploadDataBtn.Name = "UploadDataBtn";
			this.UploadDataBtn.Size = new System.Drawing.Size(354, 144);
			this.UploadDataBtn.TabIndex = 2;
			this.UploadDataBtn.Text = "Upload Data";
			this.UploadDataBtn.UseVisualStyleBackColor = true;
			this.UploadDataBtn.Click += new System.EventHandler(this.UploadDataBtn_Click);
			// 
			// UpDownProgressBar
			// 
			this.UpDownProgressBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.UpDownProgressBar.BackColor = System.Drawing.SystemColors.Control;
			this.UpDownProgressBar.Location = new System.Drawing.Point(62, 576);
			this.UpDownProgressBar.MarqueeAnimationSpeed = 1000;
			this.UpDownProgressBar.Name = "UpDownProgressBar";
			this.UpDownProgressBar.Size = new System.Drawing.Size(1109, 153);
			this.UpDownProgressBar.TabIndex = 1;
			this.UpDownProgressBar.Visible = false;
			// 
			// SyncDataBtn
			// 
			this.SyncDataBtn.Location = new System.Drawing.Point(131, 55);
			this.SyncDataBtn.Name = "SyncDataBtn";
			this.SyncDataBtn.Size = new System.Drawing.Size(354, 144);
			this.SyncDataBtn.TabIndex = 0;
			this.SyncDataBtn.Text = "Sync Data";
			this.SyncDataBtn.UseVisualStyleBackColor = true;
			this.SyncDataBtn.Click += new System.EventHandler(this.SyncDataBtn_Click);
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
			// Main_Form
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1236, 817);
			this.Controls.Add(this.mainTabControl);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimumSize = new System.Drawing.Size(800, 600);
			this.Name = "Main_Form";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Green Enviro";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_Form_FormClosing);
			this.Load += new System.EventHandler(this.Main_Form_Load);
			this.mainTabControl.ResumeLayout(false);
			this.ReceiptPage.ResumeLayout(false);
			this.ReceiptPage.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.IDPictureBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
			this.tabPage1.ResumeLayout(false);
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
		private System.Windows.Forms.TabPage tabPage1;
		public System.Windows.Forms.Button SyncDataBtn;
		public System.Windows.Forms.ProgressBar UpDownProgressBar;
		public System.Windows.Forms.Button UploadDataBtn;
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
	}
}