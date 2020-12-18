
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
			this.label2 = new System.Windows.Forms.Label();
			this.logo = new System.Windows.Forms.PictureBox();
			this.itemList = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.addItemBtn = new System.Windows.Forms.Button();
			this.receiptBox = new System.Windows.Forms.RichTextBox();
			this.PurchasesPage = new System.Windows.Forms.TabPage();
			this.SalesPage = new System.Windows.Forms.TabPage();
			this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
			this.quantityBox = new System.Windows.Forms.TextBox();
			this.mainTabControl.SuspendLayout();
			this.ReceiptPage.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
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
			this.mainTabControl.Size = new System.Drawing.Size(1227, 816);
			this.mainTabControl.TabIndex = 0;
			// 
			// ReceiptPage
			// 
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
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(29, 117);
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
			this.itemList.Location = new System.Drawing.Point(186, 46);
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
			// quantityBox
			// 
			this.quantityBox.Location = new System.Drawing.Point(189, 114);
			this.quantityBox.Name = "quantityBox";
			this.quantityBox.Size = new System.Drawing.Size(199, 31);
			this.quantityBox.TabIndex = 10;
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
			this.Load += new System.EventHandler(this.Main_Form_Load);
			this.mainTabControl.ResumeLayout(false);
			this.ReceiptPage.ResumeLayout(false);
			this.ReceiptPage.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
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
	}
}