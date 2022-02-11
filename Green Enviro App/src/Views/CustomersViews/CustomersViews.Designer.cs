
namespace Green_Enviro_App
{
	partial class CustomersViews
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomersViews));
			this.CustomersDataGrid = new System.Windows.Forms.DataGridView();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.CustomersDeleteBtn = new System.Windows.Forms.Button();
			this.CustomersSurname = new System.Windows.Forms.TextBox();
			this.CustomersIdentification = new System.Windows.Forms.TextBox();
			this.CustomersName = new System.Windows.Forms.TextBox();
			this.CustomersDoneBtn = new System.Windows.Forms.Button();
			this.EditCustomersFormLabel = new System.Windows.Forms.Label();
			this.CustomersNewCustomer = new System.Windows.Forms.Button();
			this.EditCustomersGroup = new System.Windows.Forms.GroupBox();
			this.EditCustomerNumberLabel = new System.Windows.Forms.Label();
			this.EditCustomerNumber = new System.Windows.Forms.NumericUpDown();
			this.UploadIdPicture = new System.Windows.Forms.Button();
			this.CancelEdit = new System.Windows.Forms.Button();
			this.SaveCustomer = new System.Windows.Forms.Button();
			this.EditAddressLabel = new System.Windows.Forms.Label();
			this.EditCellLabel = new System.Windows.Forms.Label();
			this.EditIdLabel = new System.Windows.Forms.Label();
			this.EditSurnameLabel = new System.Windows.Forms.Label();
			this.EditNameLabel = new System.Windows.Forms.Label();
			this.EditAddress = new System.Windows.Forms.TextBox();
			this.EditCellNumber = new System.Windows.Forms.TextBox();
			this.EditIDNumber = new System.Windows.Forms.TextBox();
			this.EditSurname = new System.Windows.Forms.TextBox();
			this.EditName = new System.Windows.Forms.TextBox();
			this.IdPictureBox = new System.Windows.Forms.PictureBox();
			this.EditCustomerEdit = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.CustomersDataGrid)).BeginInit();
			this.EditCustomersGroup.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.EditCustomerNumber)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.IdPictureBox)).BeginInit();
			this.SuspendLayout();
			// 
			// CustomersDataGrid
			// 
			this.CustomersDataGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.CustomersDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.CustomersDataGrid.BackgroundColor = System.Drawing.SystemColors.Control;
			this.CustomersDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.CustomersDataGrid.Location = new System.Drawing.Point(351, 125);
			this.CustomersDataGrid.Name = "CustomersDataGrid";
			this.CustomersDataGrid.ReadOnly = true;
			this.CustomersDataGrid.RowHeadersWidth = 51;
			this.CustomersDataGrid.RowTemplate.Height = 24;
			this.CustomersDataGrid.Size = new System.Drawing.Size(1153, 738);
			this.CustomersDataGrid.TabIndex = 0;
			this.CustomersDataGrid.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CustomersDataGrid_CellContentDoubleClick);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(36, 321);
			this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(135, 19);
			this.label4.TabIndex = 28;
			this.label4.Text = "Identification";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(36, 223);
			this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(72, 19);
			this.label3.TabIndex = 27;
			this.label3.Text = "Surname";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(36, 125);
			this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(45, 19);
			this.label2.TabIndex = 26;
			this.label2.Text = "Name";
			// 
			// CustomersDeleteBtn
			// 
			this.CustomersDeleteBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.CustomersDeleteBtn.Location = new System.Drawing.Point(40, 744);
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
			this.CustomersSurname.Size = new System.Drawing.Size(203, 26);
			this.CustomersSurname.TabIndex = 22;
			this.CustomersSurname.TextChanged += new System.EventHandler(this.CustomersSurname_TextChanged);
			// 
			// CustomersIdentification
			// 
			this.CustomersIdentification.Location = new System.Drawing.Point(40, 358);
			this.CustomersIdentification.Margin = new System.Windows.Forms.Padding(4);
			this.CustomersIdentification.Name = "CustomersIdentification";
			this.CustomersIdentification.Size = new System.Drawing.Size(203, 26);
			this.CustomersIdentification.TabIndex = 21;
			this.CustomersIdentification.TextChanged += new System.EventHandler(this.CustomersIdentification_TextChanged);
			// 
			// CustomersName
			// 
			this.CustomersName.Location = new System.Drawing.Point(40, 156);
			this.CustomersName.Margin = new System.Windows.Forms.Padding(4);
			this.CustomersName.Name = "CustomersName";
			this.CustomersName.Size = new System.Drawing.Size(203, 26);
			this.CustomersName.TabIndex = 20;
			this.CustomersName.TextChanged += new System.EventHandler(this.CustomersName_TextChanged);
			// 
			// CustomersDoneBtn
			// 
			this.CustomersDoneBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.CustomersDoneBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.CustomersDoneBtn.Location = new System.Drawing.Point(40, 815);
			this.CustomersDoneBtn.Margin = new System.Windows.Forms.Padding(4);
			this.CustomersDoneBtn.Name = "CustomersDoneBtn";
			this.CustomersDoneBtn.Size = new System.Drawing.Size(287, 48);
			this.CustomersDoneBtn.TabIndex = 30;
			this.CustomersDoneBtn.Text = "Done";
			this.CustomersDoneBtn.UseVisualStyleBackColor = false;
			this.CustomersDoneBtn.Click += new System.EventHandler(this.CustomersDoneBtn_Click);
			// 
			// EditCustomersFormLabel
			// 
			this.EditCustomersFormLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.EditCustomersFormLabel.Font = new System.Drawing.Font("Consolas", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.EditCustomersFormLabel.Location = new System.Drawing.Point(656, 23);
			this.EditCustomersFormLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.EditCustomersFormLabel.Name = "EditCustomersFormLabel";
			this.EditCustomersFormLabel.Size = new System.Drawing.Size(314, 45);
			this.EditCustomersFormLabel.TabIndex = 31;
			this.EditCustomersFormLabel.Text = "Edit Customers";
			// 
			// CustomersNewCustomer
			// 
			this.CustomersNewCustomer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.CustomersNewCustomer.Location = new System.Drawing.Point(40, 674);
			this.CustomersNewCustomer.Margin = new System.Windows.Forms.Padding(4);
			this.CustomersNewCustomer.Name = "CustomersNewCustomer";
			this.CustomersNewCustomer.Size = new System.Drawing.Size(287, 48);
			this.CustomersNewCustomer.TabIndex = 32;
			this.CustomersNewCustomer.Text = "New Customer";
			this.CustomersNewCustomer.UseVisualStyleBackColor = true;
			this.CustomersNewCustomer.Click += new System.EventHandler(this.CustomersNewCustomer_Click);
			// 
			// EditCustomersGroup
			// 
			this.EditCustomersGroup.BackColor = System.Drawing.Color.DarkGreen;
			this.EditCustomersGroup.Controls.Add(this.EditCustomerNumberLabel);
			this.EditCustomersGroup.Controls.Add(this.EditCustomerNumber);
			this.EditCustomersGroup.Controls.Add(this.UploadIdPicture);
			this.EditCustomersGroup.Controls.Add(this.CancelEdit);
			this.EditCustomersGroup.Controls.Add(this.SaveCustomer);
			this.EditCustomersGroup.Controls.Add(this.EditAddressLabel);
			this.EditCustomersGroup.Controls.Add(this.EditCellLabel);
			this.EditCustomersGroup.Controls.Add(this.EditIdLabel);
			this.EditCustomersGroup.Controls.Add(this.EditSurnameLabel);
			this.EditCustomersGroup.Controls.Add(this.EditNameLabel);
			this.EditCustomersGroup.Controls.Add(this.EditAddress);
			this.EditCustomersGroup.Controls.Add(this.EditCellNumber);
			this.EditCustomersGroup.Controls.Add(this.EditIDNumber);
			this.EditCustomersGroup.Controls.Add(this.EditSurname);
			this.EditCustomersGroup.Controls.Add(this.EditName);
			this.EditCustomersGroup.Controls.Add(this.IdPictureBox);
			this.EditCustomersGroup.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.EditCustomersGroup.Location = new System.Drawing.Point(156, 150);
			this.EditCustomersGroup.Name = "EditCustomersGroup";
			this.EditCustomersGroup.Size = new System.Drawing.Size(1348, 685);
			this.EditCustomersGroup.TabIndex = 34;
			this.EditCustomersGroup.TabStop = false;
			this.EditCustomersGroup.Text = "Edit Cusomers Group";
			// 
			// EditCustomerNumberLabel
			// 
			this.EditCustomerNumberLabel.AutoSize = true;
			this.EditCustomerNumberLabel.Location = new System.Drawing.Point(29, 67);
			this.EditCustomerNumberLabel.Name = "EditCustomerNumberLabel";
			this.EditCustomerNumberLabel.Size = new System.Drawing.Size(144, 19);
			this.EditCustomerNumberLabel.TabIndex = 15;
			this.EditCustomerNumberLabel.Text = "Customer Number";
			// 
			// EditCustomerNumber
			// 
			this.EditCustomerNumber.Location = new System.Drawing.Point(33, 94);
			this.EditCustomerNumber.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
			this.EditCustomerNumber.Name = "EditCustomerNumber";
			this.EditCustomerNumber.Size = new System.Drawing.Size(175, 26);
			this.EditCustomerNumber.TabIndex = 14;
			// 
			// UploadIdPicture
			// 
			this.UploadIdPicture.Location = new System.Drawing.Point(33, 532);
			this.UploadIdPicture.Name = "UploadIdPicture";
			this.UploadIdPicture.Size = new System.Drawing.Size(362, 56);
			this.UploadIdPicture.TabIndex = 13;
			this.UploadIdPicture.Text = "Updload ID Picture";
			this.UploadIdPicture.UseVisualStyleBackColor = true;
			this.UploadIdPicture.Click += new System.EventHandler(this.UploadIdPicture_Click);
			// 
			// CancelEdit
			// 
			this.CancelEdit.Location = new System.Drawing.Point(220, 610);
			this.CancelEdit.Name = "CancelEdit";
			this.CancelEdit.Size = new System.Drawing.Size(175, 56);
			this.CancelEdit.TabIndex = 12;
			this.CancelEdit.Text = "Cancel";
			this.CancelEdit.UseVisualStyleBackColor = true;
			this.CancelEdit.Click += new System.EventHandler(this.CancelEdit_Click);
			// 
			// SaveCustomer
			// 
			this.SaveCustomer.Location = new System.Drawing.Point(33, 610);
			this.SaveCustomer.Name = "SaveCustomer";
			this.SaveCustomer.Size = new System.Drawing.Size(175, 56);
			this.SaveCustomer.TabIndex = 11;
			this.SaveCustomer.Text = "Save";
			this.SaveCustomer.UseVisualStyleBackColor = true;
			this.SaveCustomer.Click += new System.EventHandler(this.SaveCustomer_Click);
			// 
			// EditAddressLabel
			// 
			this.EditAddressLabel.AutoSize = true;
			this.EditAddressLabel.Location = new System.Drawing.Point(29, 451);
			this.EditAddressLabel.Name = "EditAddressLabel";
			this.EditAddressLabel.Size = new System.Drawing.Size(72, 19);
			this.EditAddressLabel.TabIndex = 10;
			this.EditAddressLabel.Text = "Address";
			// 
			// EditCellLabel
			// 
			this.EditCellLabel.AutoSize = true;
			this.EditCellLabel.Location = new System.Drawing.Point(29, 378);
			this.EditCellLabel.Name = "EditCellLabel";
			this.EditCellLabel.Size = new System.Drawing.Size(108, 19);
			this.EditCellLabel.TabIndex = 9;
			this.EditCellLabel.Text = "Cell Number";
			// 
			// EditIdLabel
			// 
			this.EditIdLabel.AutoSize = true;
			this.EditIdLabel.Location = new System.Drawing.Point(29, 299);
			this.EditIdLabel.Name = "EditIdLabel";
			this.EditIdLabel.Size = new System.Drawing.Size(90, 19);
			this.EditIdLabel.TabIndex = 8;
			this.EditIdLabel.Text = "ID Number";
			// 
			// EditSurnameLabel
			// 
			this.EditSurnameLabel.AutoSize = true;
			this.EditSurnameLabel.Location = new System.Drawing.Point(29, 219);
			this.EditSurnameLabel.Name = "EditSurnameLabel";
			this.EditSurnameLabel.Size = new System.Drawing.Size(72, 19);
			this.EditSurnameLabel.TabIndex = 7;
			this.EditSurnameLabel.Text = "Surname";
			// 
			// EditNameLabel
			// 
			this.EditNameLabel.AutoSize = true;
			this.EditNameLabel.Location = new System.Drawing.Point(29, 140);
			this.EditNameLabel.Name = "EditNameLabel";
			this.EditNameLabel.Size = new System.Drawing.Size(45, 19);
			this.EditNameLabel.TabIndex = 6;
			this.EditNameLabel.Text = "Name";
			// 
			// EditAddress
			// 
			this.EditAddress.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.EditAddress.Location = new System.Drawing.Point(33, 477);
			this.EditAddress.Name = "EditAddress";
			this.EditAddress.Size = new System.Drawing.Size(362, 29);
			this.EditAddress.TabIndex = 5;
			// 
			// EditCellNumber
			// 
			this.EditCellNumber.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.EditCellNumber.Location = new System.Drawing.Point(33, 404);
			this.EditCellNumber.Name = "EditCellNumber";
			this.EditCellNumber.Size = new System.Drawing.Size(362, 29);
			this.EditCellNumber.TabIndex = 4;
			// 
			// EditIDNumber
			// 
			this.EditIDNumber.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.EditIDNumber.Location = new System.Drawing.Point(33, 325);
			this.EditIDNumber.Name = "EditIDNumber";
			this.EditIDNumber.Size = new System.Drawing.Size(362, 29);
			this.EditIDNumber.TabIndex = 3;
			// 
			// EditSurname
			// 
			this.EditSurname.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.EditSurname.Location = new System.Drawing.Point(33, 245);
			this.EditSurname.Name = "EditSurname";
			this.EditSurname.Size = new System.Drawing.Size(362, 29);
			this.EditSurname.TabIndex = 2;
			// 
			// EditName
			// 
			this.EditName.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.EditName.Location = new System.Drawing.Point(33, 166);
			this.EditName.Name = "EditName";
			this.EditName.Size = new System.Drawing.Size(362, 29);
			this.EditName.TabIndex = 1;
			// 
			// IdPictureBox
			// 
			this.IdPictureBox.BackColor = System.Drawing.Color.Honeydew;
			this.IdPictureBox.Location = new System.Drawing.Point(452, 73);
			this.IdPictureBox.Name = "IdPictureBox";
			this.IdPictureBox.Size = new System.Drawing.Size(879, 593);
			this.IdPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.IdPictureBox.TabIndex = 0;
			this.IdPictureBox.TabStop = false;
			// 
			// EditCustomerEdit
			// 
			this.EditCustomerEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.EditCustomerEdit.Location = new System.Drawing.Point(38, 595);
			this.EditCustomerEdit.Name = "EditCustomerEdit";
			this.EditCustomerEdit.Size = new System.Drawing.Size(291, 50);
			this.EditCustomerEdit.TabIndex = 35;
			this.EditCustomerEdit.Text = "Edit Customer";
			this.EditCustomerEdit.UseVisualStyleBackColor = true;
			this.EditCustomerEdit.Click += new System.EventHandler(this.EditCustomerEdit_Click);
			// 
			// CustomersViews
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Teal;
			this.ClientSize = new System.Drawing.Size(1516, 875);
			this.Controls.Add(this.EditCustomersGroup);
			this.Controls.Add(this.CustomersNewCustomer);
			this.Controls.Add(this.EditCustomersFormLabel);
			this.Controls.Add(this.CustomersDoneBtn);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.CustomersDeleteBtn);
			this.Controls.Add(this.CustomersSurname);
			this.Controls.Add(this.CustomersIdentification);
			this.Controls.Add(this.CustomersName);
			this.Controls.Add(this.CustomersDataGrid);
			this.Controls.Add(this.EditCustomerEdit);
			this.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "CustomersViews";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Customers";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			((System.ComponentModel.ISupportInitialize)(this.CustomersDataGrid)).EndInit();
			this.EditCustomersGroup.ResumeLayout(false);
			this.EditCustomersGroup.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.EditCustomerNumber)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.IdPictureBox)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView CustomersDataGrid;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button CustomersDeleteBtn;
		private System.Windows.Forms.TextBox CustomersSurname;
		private System.Windows.Forms.TextBox CustomersIdentification;
		private System.Windows.Forms.TextBox CustomersName;
		private System.Windows.Forms.Button CustomersDoneBtn;
		private System.Windows.Forms.Label EditCustomersFormLabel;
		private System.Windows.Forms.Button CustomersNewCustomer;
		private System.Windows.Forms.GroupBox EditCustomersGroup;
		private System.Windows.Forms.TextBox EditAddress;
		private System.Windows.Forms.TextBox EditCellNumber;
		private System.Windows.Forms.TextBox EditIDNumber;
		private System.Windows.Forms.TextBox EditSurname;
		private System.Windows.Forms.TextBox EditName;
		private System.Windows.Forms.PictureBox IdPictureBox;
		private System.Windows.Forms.Label EditAddressLabel;
		private System.Windows.Forms.Label EditCellLabel;
		private System.Windows.Forms.Label EditIdLabel;
		private System.Windows.Forms.Label EditSurnameLabel;
		private System.Windows.Forms.Label EditNameLabel;
		private System.Windows.Forms.Button UploadIdPicture;
		private System.Windows.Forms.Button CancelEdit;
		private System.Windows.Forms.Button SaveCustomer;
		private System.Windows.Forms.Label EditCustomerNumberLabel;
		private System.Windows.Forms.NumericUpDown EditCustomerNumber;
		private System.Windows.Forms.Button EditCustomerEdit;
	}
}