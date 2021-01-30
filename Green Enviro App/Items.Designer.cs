
namespace Green_Enviro_App
{
	partial class Items
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Items));
			this.PricesGridView = new System.Windows.Forms.DataGridView();
			this.ItemsChangeCpltBtn = new System.Windows.Forms.Button();
			this.ItemsNewItemBtn = new System.Windows.Forms.Button();
			this.ItemsDeleteItemBtn = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.PricesGridView)).BeginInit();
			this.SuspendLayout();
			// 
			// PricesGridView
			// 
			this.PricesGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.PricesGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.PricesGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
			this.PricesGridView.BackgroundColor = System.Drawing.SystemColors.Control;
			this.PricesGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.PricesGridView.Location = new System.Drawing.Point(82, 27);
			this.PricesGridView.Margin = new System.Windows.Forms.Padding(4);
			this.PricesGridView.Name = "PricesGridView";
			this.PricesGridView.RowHeadersWidth = 51;
			this.PricesGridView.RowTemplate.Height = 24;
			this.PricesGridView.Size = new System.Drawing.Size(819, 480);
			this.PricesGridView.TabIndex = 0;
			this.PricesGridView.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.PricesGridView_CellEndEdit);
			// 
			// ItemsChangeCpltBtn
			// 
			this.ItemsChangeCpltBtn.Location = new System.Drawing.Point(82, 525);
			this.ItemsChangeCpltBtn.Margin = new System.Windows.Forms.Padding(4);
			this.ItemsChangeCpltBtn.Name = "ItemsChangeCpltBtn";
			this.ItemsChangeCpltBtn.Size = new System.Drawing.Size(247, 51);
			this.ItemsChangeCpltBtn.TabIndex = 1;
			this.ItemsChangeCpltBtn.Text = "Done";
			this.ItemsChangeCpltBtn.UseVisualStyleBackColor = true;
			this.ItemsChangeCpltBtn.Click += new System.EventHandler(this.PriceChangeCpltBtn_Click);
			// 
			// ItemsNewItemBtn
			// 
			this.ItemsNewItemBtn.Location = new System.Drawing.Point(363, 525);
			this.ItemsNewItemBtn.Name = "ItemsNewItemBtn";
			this.ItemsNewItemBtn.Size = new System.Drawing.Size(239, 51);
			this.ItemsNewItemBtn.TabIndex = 2;
			this.ItemsNewItemBtn.Text = "New Item";
			this.ItemsNewItemBtn.UseVisualStyleBackColor = true;
			this.ItemsNewItemBtn.Click += new System.EventHandler(this.PricesNewItemBtn_Click);
			// 
			// ItemsDeleteItemBtn
			// 
			this.ItemsDeleteItemBtn.Location = new System.Drawing.Point(635, 525);
			this.ItemsDeleteItemBtn.Name = "ItemsDeleteItemBtn";
			this.ItemsDeleteItemBtn.Size = new System.Drawing.Size(239, 51);
			this.ItemsDeleteItemBtn.TabIndex = 3;
			this.ItemsDeleteItemBtn.Text = "Delete Item";
			this.ItemsDeleteItemBtn.UseVisualStyleBackColor = true;
			this.ItemsDeleteItemBtn.Click += new System.EventHandler(this.ItemsDeleteItemBtn_Click);
			// 
			// Items
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.DarkSlateGray;
			this.ClientSize = new System.Drawing.Size(982, 589);
			this.Controls.Add(this.ItemsDeleteItemBtn);
			this.Controls.Add(this.ItemsNewItemBtn);
			this.Controls.Add(this.ItemsChangeCpltBtn);
			this.Controls.Add(this.PricesGridView);
			this.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "Items";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Green Enviro SA Recycling";
			this.Load += new System.EventHandler(this.Items_Load);
			((System.ComponentModel.ISupportInitialize)(this.PricesGridView)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataGridView PricesGridView;
		private System.Windows.Forms.Button ItemsChangeCpltBtn;
		private System.Windows.Forms.Button ItemsNewItemBtn;
		private System.Windows.Forms.Button ItemsDeleteItemBtn;
	}
}