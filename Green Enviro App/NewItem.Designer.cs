
namespace Green_Enviro_App
{
	partial class NewItem
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewItem));
			this.NewItemAddBtn = new System.Windows.Forms.Button();
			this.NewItemCnclBtn = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.NewItemNameBox = new System.Windows.Forms.TextBox();
			this.NewItemPrice = new System.Windows.Forms.NumericUpDown();
			this.NewItemDealerPrice = new System.Windows.Forms.NumericUpDown();
			this.NewItemType = new System.Windows.Forms.ComboBox();
			((System.ComponentModel.ISupportInitialize)(this.NewItemPrice)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.NewItemDealerPrice)).BeginInit();
			this.SuspendLayout();
			// 
			// NewItemAddBtn
			// 
			this.NewItemAddBtn.Location = new System.Drawing.Point(81, 248);
			this.NewItemAddBtn.Margin = new System.Windows.Forms.Padding(5);
			this.NewItemAddBtn.Name = "NewItemAddBtn";
			this.NewItemAddBtn.Size = new System.Drawing.Size(304, 64);
			this.NewItemAddBtn.TabIndex = 0;
			this.NewItemAddBtn.Text = "Add Item";
			this.NewItemAddBtn.UseVisualStyleBackColor = true;
			this.NewItemAddBtn.Click += new System.EventHandler(this.NewItemAddBtn_Click);
			// 
			// NewItemCnclBtn
			// 
			this.NewItemCnclBtn.Location = new System.Drawing.Point(471, 248);
			this.NewItemCnclBtn.Margin = new System.Windows.Forms.Padding(5);
			this.NewItemCnclBtn.Name = "NewItemCnclBtn";
			this.NewItemCnclBtn.Size = new System.Drawing.Size(283, 64);
			this.NewItemCnclBtn.TabIndex = 1;
			this.NewItemCnclBtn.Text = "Cancel";
			this.NewItemCnclBtn.UseVisualStyleBackColor = true;
			this.NewItemCnclBtn.Click += new System.EventHandler(this.NewItemCnclBtn_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.label1.Location = new System.Drawing.Point(82, 78);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(129, 28);
			this.label1.TabIndex = 2;
			this.label1.Text = "Item Name";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.label2.Location = new System.Drawing.Point(519, 76);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(168, 28);
			this.label2.TabIndex = 3;
			this.label2.Text = "Dealer Price";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.label3.Location = new System.Drawing.Point(313, 76);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(77, 28);
			this.label3.TabIndex = 4;
			this.label3.Text = "Price";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.label4.Location = new System.Drawing.Point(743, 76);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(64, 28);
			this.label4.TabIndex = 5;
			this.label4.Text = "Type";
			// 
			// NewItemNameBox
			// 
			this.NewItemNameBox.Location = new System.Drawing.Point(81, 111);
			this.NewItemNameBox.Name = "NewItemNameBox";
			this.NewItemNameBox.Size = new System.Drawing.Size(194, 34);
			this.NewItemNameBox.TabIndex = 6;
			// 
			// NewItemPrice
			// 
			this.NewItemPrice.DecimalPlaces = 2;
			this.NewItemPrice.Location = new System.Drawing.Point(313, 109);
			this.NewItemPrice.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
			this.NewItemPrice.Name = "NewItemPrice";
			this.NewItemPrice.Size = new System.Drawing.Size(167, 34);
			this.NewItemPrice.TabIndex = 7;
			// 
			// NewItemDealerPrice
			// 
			this.NewItemDealerPrice.DecimalPlaces = 2;
			this.NewItemDealerPrice.Location = new System.Drawing.Point(519, 109);
			this.NewItemDealerPrice.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
			this.NewItemDealerPrice.Name = "NewItemDealerPrice";
			this.NewItemDealerPrice.Size = new System.Drawing.Size(173, 34);
			this.NewItemDealerPrice.TabIndex = 8;
			// 
			// NewItemType
			// 
			this.NewItemType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.NewItemType.FormattingEnabled = true;
			this.NewItemType.Location = new System.Drawing.Point(743, 110);
			this.NewItemType.Name = "NewItemType";
			this.NewItemType.Size = new System.Drawing.Size(206, 35);
			this.NewItemType.TabIndex = 9;
			// 
			// NewItem
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 27F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Highlight;
			this.ClientSize = new System.Drawing.Size(1036, 359);
			this.Controls.Add(this.NewItemType);
			this.Controls.Add(this.NewItemDealerPrice);
			this.Controls.Add(this.NewItemPrice);
			this.Controls.Add(this.NewItemNameBox);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.NewItemCnclBtn);
			this.Controls.Add(this.NewItemAddBtn);
			this.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(5);
			this.Name = "NewItem";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "NewItem";
			this.Load += new System.EventHandler(this.NewItem_Load);
			((System.ComponentModel.ISupportInitialize)(this.NewItemPrice)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.NewItemDealerPrice)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button NewItemAddBtn;
		private System.Windows.Forms.Button NewItemCnclBtn;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox NewItemNameBox;
		private System.Windows.Forms.NumericUpDown NewItemPrice;
		private System.Windows.Forms.NumericUpDown NewItemDealerPrice;
		private System.Windows.Forms.ComboBox NewItemType;
	}
}