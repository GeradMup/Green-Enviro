
namespace Green_Enviro_App
{
	partial class ItemsViews
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ItemsViews));
			this.ItemsGrid = new System.Windows.Forms.DataGridView();
			this.ItemsDoneBtn = new System.Windows.Forms.Button();
			this.ItemsNewItemBtn = new System.Windows.Forms.Button();
			this.ItemsDeleteItemBtn = new System.Windows.Forms.Button();
			this.EditItemsLabel = new System.Windows.Forms.Label();
			this.EditItemGroupBox = new System.Windows.Forms.GroupBox();
			this.ItemDealerPrice = new System.Windows.Forms.NumericUpDown();
			this.ItemPrice = new System.Windows.Forms.NumericUpDown();
			this.ItemType = new System.Windows.Forms.ComboBox();
			this.ItemName = new System.Windows.Forms.TextBox();
			this.EditPriceCancel = new System.Windows.Forms.Button();
			this.EditPriceDone = new System.Windows.Forms.Button();
			this.ItemNameLabel = new System.Windows.Forms.Label();
			this.ItemTypeLabel = new System.Windows.Forms.Label();
			this.ItemPriceLabel = new System.Windows.Forms.Label();
			this.ItemDealerPriceLabel = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.ItemsGrid)).BeginInit();
			this.EditItemGroupBox.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.ItemDealerPrice)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemPrice)).BeginInit();
			this.SuspendLayout();
			// 
			// ItemsGrid
			// 
			this.ItemsGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.ItemsGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.ItemsGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
			this.ItemsGrid.BackgroundColor = System.Drawing.SystemColors.Control;
			this.ItemsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.ItemsGrid.Location = new System.Drawing.Point(32, 53);
			this.ItemsGrid.Margin = new System.Windows.Forms.Padding(4);
			this.ItemsGrid.Name = "ItemsGrid";
			this.ItemsGrid.ReadOnly = true;
			this.ItemsGrid.RowHeadersWidth = 51;
			this.ItemsGrid.RowTemplate.Height = 24;
			this.ItemsGrid.Size = new System.Drawing.Size(910, 454);
			this.ItemsGrid.TabIndex = 0;
			this.ItemsGrid.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ItemsGrid_CellDoubleClick);
			// 
			// ItemsDoneBtn
			// 
			this.ItemsDoneBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.ItemsDoneBtn.Location = new System.Drawing.Point(32, 525);
			this.ItemsDoneBtn.Margin = new System.Windows.Forms.Padding(4);
			this.ItemsDoneBtn.Name = "ItemsDoneBtn";
			this.ItemsDoneBtn.Size = new System.Drawing.Size(132, 51);
			this.ItemsDoneBtn.TabIndex = 1;
			this.ItemsDoneBtn.Text = "Done";
			this.ItemsDoneBtn.UseVisualStyleBackColor = true;
			this.ItemsDoneBtn.Click += new System.EventHandler(this.ItemsDoneBtn_Click);
			// 
			// ItemsNewItemBtn
			// 
			this.ItemsNewItemBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.ItemsNewItemBtn.Location = new System.Drawing.Point(208, 525);
			this.ItemsNewItemBtn.Name = "ItemsNewItemBtn";
			this.ItemsNewItemBtn.Size = new System.Drawing.Size(130, 51);
			this.ItemsNewItemBtn.TabIndex = 2;
			this.ItemsNewItemBtn.Text = "New Item";
			this.ItemsNewItemBtn.UseVisualStyleBackColor = true;
			this.ItemsNewItemBtn.Click += new System.EventHandler(this.ItemsNewItemBtn_Click);
			// 
			// ItemsDeleteItemBtn
			// 
			this.ItemsDeleteItemBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.ItemsDeleteItemBtn.Location = new System.Drawing.Point(381, 525);
			this.ItemsDeleteItemBtn.Name = "ItemsDeleteItemBtn";
			this.ItemsDeleteItemBtn.Size = new System.Drawing.Size(239, 51);
			this.ItemsDeleteItemBtn.TabIndex = 3;
			this.ItemsDeleteItemBtn.Text = "Delete Item";
			this.ItemsDeleteItemBtn.UseVisualStyleBackColor = true;
			this.ItemsDeleteItemBtn.Click += new System.EventHandler(this.ItemsDeleteItemBtn_Click);
			// 
			// EditItemsLabel
			// 
			this.EditItemsLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.EditItemsLabel.Font = new System.Drawing.Font("Consolas", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.EditItemsLabel.ForeColor = System.Drawing.SystemColors.Control;
			this.EditItemsLabel.Location = new System.Drawing.Point(389, 9);
			this.EditItemsLabel.Name = "EditItemsLabel";
			this.EditItemsLabel.Size = new System.Drawing.Size(197, 37);
			this.EditItemsLabel.TabIndex = 4;
			this.EditItemsLabel.Text = "Edit Items";
			this.EditItemsLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// EditItemGroupBox
			// 
			this.EditItemGroupBox.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.EditItemGroupBox.Controls.Add(this.ItemDealerPriceLabel);
			this.EditItemGroupBox.Controls.Add(this.ItemPriceLabel);
			this.EditItemGroupBox.Controls.Add(this.ItemTypeLabel);
			this.EditItemGroupBox.Controls.Add(this.ItemNameLabel);
			this.EditItemGroupBox.Controls.Add(this.ItemDealerPrice);
			this.EditItemGroupBox.Controls.Add(this.ItemPrice);
			this.EditItemGroupBox.Controls.Add(this.ItemType);
			this.EditItemGroupBox.Controls.Add(this.ItemName);
			this.EditItemGroupBox.Controls.Add(this.EditPriceCancel);
			this.EditItemGroupBox.Controls.Add(this.EditPriceDone);
			this.EditItemGroupBox.ForeColor = System.Drawing.SystemColors.ControlText;
			this.EditItemGroupBox.Location = new System.Drawing.Point(80, 199);
			this.EditItemGroupBox.Name = "EditItemGroupBox";
			this.EditItemGroupBox.Size = new System.Drawing.Size(792, 162);
			this.EditItemGroupBox.TabIndex = 5;
			this.EditItemGroupBox.TabStop = false;
			this.EditItemGroupBox.Text = "Edit Item";
			// 
			// ItemDealerPrice
			// 
			this.ItemDealerPrice.DecimalPlaces = 2;
			this.ItemDealerPrice.Location = new System.Drawing.Point(631, 52);
			this.ItemDealerPrice.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
			this.ItemDealerPrice.Name = "ItemDealerPrice";
			this.ItemDealerPrice.Size = new System.Drawing.Size(140, 26);
			this.ItemDealerPrice.TabIndex = 8;
			// 
			// ItemPrice
			// 
			this.ItemPrice.DecimalPlaces = 2;
			this.ItemPrice.Location = new System.Drawing.Point(485, 52);
			this.ItemPrice.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
			this.ItemPrice.Name = "ItemPrice";
			this.ItemPrice.Size = new System.Drawing.Size(140, 26);
			this.ItemPrice.TabIndex = 7;
			// 
			// ItemType
			// 
			this.ItemType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.ItemType.FormattingEnabled = true;
			this.ItemType.Location = new System.Drawing.Point(264, 52);
			this.ItemType.Name = "ItemType";
			this.ItemType.Size = new System.Drawing.Size(215, 27);
			this.ItemType.TabIndex = 6;
			// 
			// ItemName
			// 
			this.ItemName.Location = new System.Drawing.Point(22, 52);
			this.ItemName.Name = "ItemName";
			this.ItemName.Size = new System.Drawing.Size(236, 26);
			this.ItemName.TabIndex = 2;
			// 
			// EditPriceCancel
			// 
			this.EditPriceCancel.Location = new System.Drawing.Point(223, 96);
			this.EditPriceCancel.Name = "EditPriceCancel";
			this.EditPriceCancel.Size = new System.Drawing.Size(195, 42);
			this.EditPriceCancel.TabIndex = 1;
			this.EditPriceCancel.Text = "Cancel";
			this.EditPriceCancel.UseVisualStyleBackColor = true;
			this.EditPriceCancel.Click += new System.EventHandler(this.EditPriceCancel_Click);
			// 
			// EditPriceDone
			// 
			this.EditPriceDone.Location = new System.Drawing.Point(23, 96);
			this.EditPriceDone.Name = "EditPriceDone";
			this.EditPriceDone.Size = new System.Drawing.Size(194, 42);
			this.EditPriceDone.TabIndex = 0;
			this.EditPriceDone.Text = "Done";
			this.EditPriceDone.UseVisualStyleBackColor = true;
			this.EditPriceDone.Click += new System.EventHandler(this.EditPriceDone_Click);
			// 
			// ItemNameLabel
			// 
			this.ItemNameLabel.AutoSize = true;
			this.ItemNameLabel.BackColor = System.Drawing.Color.DarkSlateGray;
			this.ItemNameLabel.ForeColor = System.Drawing.SystemColors.ControlLight;
			this.ItemNameLabel.Location = new System.Drawing.Point(19, 30);
			this.ItemNameLabel.Name = "ItemNameLabel";
			this.ItemNameLabel.Size = new System.Drawing.Size(45, 19);
			this.ItemNameLabel.TabIndex = 9;
			this.ItemNameLabel.Text = "Name";
			// 
			// ItemTypeLabel
			// 
			this.ItemTypeLabel.AutoSize = true;
			this.ItemTypeLabel.ForeColor = System.Drawing.SystemColors.ControlLight;
			this.ItemTypeLabel.Location = new System.Drawing.Point(260, 30);
			this.ItemTypeLabel.Name = "ItemTypeLabel";
			this.ItemTypeLabel.Size = new System.Drawing.Size(45, 19);
			this.ItemTypeLabel.TabIndex = 10;
			this.ItemTypeLabel.Text = "Type";
			// 
			// ItemPriceLabel
			// 
			this.ItemPriceLabel.AutoSize = true;
			this.ItemPriceLabel.ForeColor = System.Drawing.SystemColors.ControlLight;
			this.ItemPriceLabel.Location = new System.Drawing.Point(481, 30);
			this.ItemPriceLabel.Name = "ItemPriceLabel";
			this.ItemPriceLabel.Size = new System.Drawing.Size(54, 19);
			this.ItemPriceLabel.TabIndex = 11;
			this.ItemPriceLabel.Text = "Price";
			// 
			// ItemDealerPriceLabel
			// 
			this.ItemDealerPriceLabel.AutoSize = true;
			this.ItemDealerPriceLabel.ForeColor = System.Drawing.SystemColors.ControlLight;
			this.ItemDealerPriceLabel.Location = new System.Drawing.Point(627, 30);
			this.ItemDealerPriceLabel.Name = "ItemDealerPriceLabel";
			this.ItemDealerPriceLabel.Size = new System.Drawing.Size(117, 19);
			this.ItemDealerPriceLabel.TabIndex = 12;
			this.ItemDealerPriceLabel.Text = "Dealer Price";
			// 
			// ItemsViews
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.DarkSlateGray;
			this.ClientSize = new System.Drawing.Size(982, 589);
			this.Controls.Add(this.EditItemGroupBox);
			this.Controls.Add(this.EditItemsLabel);
			this.Controls.Add(this.ItemsDeleteItemBtn);
			this.Controls.Add(this.ItemsNewItemBtn);
			this.Controls.Add(this.ItemsDoneBtn);
			this.Controls.Add(this.ItemsGrid);
			this.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "ItemsViews";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Green Enviro SA Recycling";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			((System.ComponentModel.ISupportInitialize)(this.ItemsGrid)).EndInit();
			this.EditItemGroupBox.ResumeLayout(false);
			this.EditItemGroupBox.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.ItemDealerPrice)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemPrice)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataGridView ItemsGrid;
		private System.Windows.Forms.Button ItemsDoneBtn;
		private System.Windows.Forms.Button ItemsNewItemBtn;
		private System.Windows.Forms.Button ItemsDeleteItemBtn;
		private System.Windows.Forms.Label EditItemsLabel;
		private System.Windows.Forms.GroupBox EditItemGroupBox;
		private System.Windows.Forms.NumericUpDown ItemDealerPrice;
		private System.Windows.Forms.NumericUpDown ItemPrice;
		private System.Windows.Forms.ComboBox ItemType;
		private System.Windows.Forms.TextBox ItemName;
		private System.Windows.Forms.Button EditPriceCancel;
		private System.Windows.Forms.Button EditPriceDone;
		private System.Windows.Forms.Label ItemDealerPriceLabel;
		private System.Windows.Forms.Label ItemPriceLabel;
		private System.Windows.Forms.Label ItemTypeLabel;
		private System.Windows.Forms.Label ItemNameLabel;
	}
}