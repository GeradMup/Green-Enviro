
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
            this.tabControl = new System.Windows.Forms.TabControl();
            this.ReceiptPage = new System.Windows.Forms.TabPage();
            this.itemList = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.addItemBtn = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.PurchasesPage = new System.Windows.Forms.TabPage();
            this.SalesPage = new System.Windows.Forms.TabPage();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.tabControl.SuspendLayout();
            this.ReceiptPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.ReceiptPage);
            this.tabControl.Controls.Add(this.PurchasesPage);
            this.tabControl.Controls.Add(this.SalesPage);
            this.tabControl.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1096, 816);
            this.tabControl.TabIndex = 0;
            // 
            // ReceiptPage
            // 
            this.ReceiptPage.Controls.Add(this.itemList);
            this.ReceiptPage.Controls.Add(this.label1);
            this.ReceiptPage.Controls.Add(this.addItemBtn);
            this.ReceiptPage.Controls.Add(this.richTextBox1);
            this.ReceiptPage.Location = new System.Drawing.Point(4, 32);
            this.ReceiptPage.Name = "ReceiptPage";
            this.ReceiptPage.Padding = new System.Windows.Forms.Padding(3);
            this.ReceiptPage.Size = new System.Drawing.Size(1088, 780);
            this.ReceiptPage.TabIndex = 0;
            this.ReceiptPage.Text = "Receipt";
            this.ReceiptPage.UseVisualStyleBackColor = true;
            this.ReceiptPage.Click += new System.EventHandler(this.ReceiptPage_Click);
            // 
            // itemList
            // 
            this.itemList.DropDownHeight = 300;
            this.itemList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.itemList.FormattingEnabled = true;
            this.itemList.IntegralHeight = false;
            this.itemList.ItemHeight = 23;
            this.itemList.Location = new System.Drawing.Point(115, 50);
            this.itemList.Name = "itemList";
            this.itemList.Size = new System.Drawing.Size(178, 31);
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
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(622, 26);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(441, 645);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // PurchasesPage
            // 
            this.PurchasesPage.Location = new System.Drawing.Point(4, 32);
            this.PurchasesPage.Name = "PurchasesPage";
            this.PurchasesPage.Padding = new System.Windows.Forms.Padding(3);
            this.PurchasesPage.Size = new System.Drawing.Size(1088, 780);
            this.PurchasesPage.TabIndex = 1;
            this.PurchasesPage.Text = "Purchases";
            this.PurchasesPage.UseVisualStyleBackColor = true;
            // 
            // SalesPage
            // 
            this.SalesPage.Location = new System.Drawing.Point(4, 32);
            this.SalesPage.Name = "SalesPage";
            this.SalesPage.Size = new System.Drawing.Size(1088, 780);
            this.SalesPage.TabIndex = 2;
            this.SalesPage.Text = "Sales";
            this.SalesPage.UseVisualStyleBackColor = true;
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // Main_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1095, 817);
            this.Controls.Add(this.tabControl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Green Enviro";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Main_Form_Load);
            this.tabControl.ResumeLayout(false);
            this.ReceiptPage.ResumeLayout(false);
            this.ReceiptPage.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage ReceiptPage;
        private System.Windows.Forms.Button addItemBtn;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.TabPage PurchasesPage;
        private System.Windows.Forms.TabPage SalesPage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ComboBox itemList;
    }
}