
namespace Green_Enviro_App
{
	partial class Customers
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Customers));
			this.CustomersDataGridView = new System.Windows.Forms.DataGridView();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.CustomersDeleteBtn = new System.Windows.Forms.Button();
			this.CustomersSurname = new System.Windows.Forms.TextBox();
			this.CustomersIdentification = new System.Windows.Forms.TextBox();
			this.CustomersName = new System.Windows.Forms.TextBox();
			this.CustomersDoneBtn = new System.Windows.Forms.Button();
			this.label5 = new System.Windows.Forms.Label();
			this.CustomersNewCustomer = new System.Windows.Forms.Button();
			this.CustomersEditBtn = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.CustomersDataGridView)).BeginInit();
			this.SuspendLayout();
			// 
			// CustomersDataGridView
			// 
			this.CustomersDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.CustomersDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.CustomersDataGridView.BackgroundColor = System.Drawing.SystemColors.Control;
			this.CustomersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.CustomersDataGridView.Location = new System.Drawing.Point(351, 125);
			this.CustomersDataGridView.Name = "CustomersDataGridView";
			this.CustomersDataGridView.ReadOnly = true;
			this.CustomersDataGridView.RowHeadersWidth = 51;
			this.CustomersDataGridView.RowTemplate.Height = 24;
			this.CustomersDataGridView.Size = new System.Drawing.Size(1153, 708);
			this.CustomersDataGridView.TabIndex = 0;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(36, 321);
			this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(164, 23);
			this.label4.TabIndex = 28;
			this.label4.Text = "Identification";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(36, 223);
			this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(87, 23);
			this.label3.TabIndex = 27;
			this.label3.Text = "Surname";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(36, 125);
			this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(54, 23);
			this.label2.TabIndex = 26;
			this.label2.Text = "Name";
			// 
			// CustomersDeleteBtn
			// 
			this.CustomersDeleteBtn.Location = new System.Drawing.Point(40, 529);
			this.CustomersDeleteBtn.Margin = new System.Windows.Forms.Padding(4);
			this.CustomersDeleteBtn.Name = "CustomersDeleteBtn";
			this.CustomersDeleteBtn.Size = new System.Drawing.Size(287, 48);
			this.CustomersDeleteBtn.TabIndex = 23;
			this.CustomersDeleteBtn.Text = "Delete Customer";
			this.CustomersDeleteBtn.UseVisualStyleBackColor = true;
			this.CustomersDeleteBtn.Click += new System.EventHandler(this.CustomersDeleteBtn_Click);
			// 
			// CustomersSurname
			// 
			this.CustomersSurname.Location = new System.Drawing.Point(40, 260);
			this.CustomersSurname.Margin = new System.Windows.Forms.Padding(4);
			this.CustomersSurname.Name = "CustomersSurname";
			this.CustomersSurname.Size = new System.Drawing.Size(203, 31);
			this.CustomersSurname.TabIndex = 22;
			this.CustomersSurname.TextChanged += new System.EventHandler(this.CustomersSurname_TextChanged);
			// 
			// CustomersIdentification
			// 
			this.CustomersIdentification.Location = new System.Drawing.Point(40, 358);
			this.CustomersIdentification.Margin = new System.Windows.Forms.Padding(4);
			this.CustomersIdentification.Name = "CustomersIdentification";
			this.CustomersIdentification.Size = new System.Drawing.Size(203, 31);
			this.CustomersIdentification.TabIndex = 21;
			this.CustomersIdentification.TextChanged += new System.EventHandler(this.CustomersIdentification_TextChanged);
			// 
			// CustomersName
			// 
			this.CustomersName.Location = new System.Drawing.Point(40, 156);
			this.CustomersName.Margin = new System.Windows.Forms.Padding(4);
			this.CustomersName.Name = "CustomersName";
			this.CustomersName.Size = new System.Drawing.Size(203, 31);
			this.CustomersName.TabIndex = 20;
			this.CustomersName.TextChanged += new System.EventHandler(this.CustomersName_TextChanged);
			// 
			// CustomersDoneBtn
			// 
			this.CustomersDoneBtn.Location = new System.Drawing.Point(40, 692);
			this.CustomersDoneBtn.Margin = new System.Windows.Forms.Padding(4);
			this.CustomersDoneBtn.Name = "CustomersDoneBtn";
			this.CustomersDoneBtn.Size = new System.Drawing.Size(287, 48);
			this.CustomersDoneBtn.TabIndex = 30;
			this.CustomersDoneBtn.Text = "Done";
			this.CustomersDoneBtn.UseVisualStyleBackColor = true;
			this.CustomersDoneBtn.Click += new System.EventHandler(this.CustomersDoneBtn_Click);
			// 
			// label5
			// 
			this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Consolas", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(569, 31);
			this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(388, 56);
			this.label5.TabIndex = 31;
			this.label5.Text = "Edit Customers";
			// 
			// CustomersNewCustomer
			// 
			this.CustomersNewCustomer.Location = new System.Drawing.Point(40, 613);
			this.CustomersNewCustomer.Margin = new System.Windows.Forms.Padding(4);
			this.CustomersNewCustomer.Name = "CustomersNewCustomer";
			this.CustomersNewCustomer.Size = new System.Drawing.Size(287, 48);
			this.CustomersNewCustomer.TabIndex = 32;
			this.CustomersNewCustomer.Text = "New Customer";
			this.CustomersNewCustomer.UseVisualStyleBackColor = true;
			this.CustomersNewCustomer.Click += new System.EventHandler(this.CustomersNewCustomer_Click);
			// 
			// CustomersEditBtn
			// 
			this.CustomersEditBtn.Location = new System.Drawing.Point(40, 451);
			this.CustomersEditBtn.Margin = new System.Windows.Forms.Padding(4);
			this.CustomersEditBtn.Name = "CustomersEditBtn";
			this.CustomersEditBtn.Size = new System.Drawing.Size(287, 48);
			this.CustomersEditBtn.TabIndex = 33;
			this.CustomersEditBtn.Text = "Edit Customer";
			this.CustomersEditBtn.UseVisualStyleBackColor = true;
			this.CustomersEditBtn.Click += new System.EventHandler(this.CustomersEditBtn_Click);
			// 
			// Customers
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Teal;
			this.ClientSize = new System.Drawing.Size(1516, 875);
			this.Controls.Add(this.CustomersEditBtn);
			this.Controls.Add(this.CustomersNewCustomer);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.CustomersDoneBtn);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.CustomersDeleteBtn);
			this.Controls.Add(this.CustomersSurname);
			this.Controls.Add(this.CustomersIdentification);
			this.Controls.Add(this.CustomersName);
			this.Controls.Add(this.CustomersDataGridView);
			this.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "Customers";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Customers";
			((System.ComponentModel.ISupportInitialize)(this.CustomersDataGridView)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView CustomersDataGridView;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button CustomersDeleteBtn;
		private System.Windows.Forms.TextBox CustomersSurname;
		private System.Windows.Forms.TextBox CustomersIdentification;
		private System.Windows.Forms.TextBox CustomersName;
		private System.Windows.Forms.Button CustomersDoneBtn;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Button CustomersNewCustomer;
		private System.Windows.Forms.Button CustomersEditBtn;
	}
}