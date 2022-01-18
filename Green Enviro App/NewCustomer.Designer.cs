
namespace Green_Enviro_App
{
	partial class NewCustomer
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
			this.NewCustomerName = new System.Windows.Forms.TextBox();
			this.NewCustomerSurname = new System.Windows.Forms.TextBox();
			this.NewCustomerID = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.NewCustomerNumber = new System.Windows.Forms.NumericUpDown();
			this.label4 = new System.Windows.Forms.Label();
			this.NewCustomerAddIdPictureBtn = new System.Windows.Forms.Button();
			this.NewCustomerCancelBtn = new System.Windows.Forms.Button();
			this.NewCustomerConfirmBtn = new System.Windows.Forms.Button();
			this.label5 = new System.Windows.Forms.Label();
			this.NewCustomerIdPicture = new System.Windows.Forms.PictureBox();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.NewCustomerCell = new System.Windows.Forms.NumericUpDown();
			this.NewCustomerAddress = new System.Windows.Forms.TextBox();
			((System.ComponentModel.ISupportInitialize)(this.NewCustomerNumber)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.NewCustomerIdPicture)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.NewCustomerCell)).BeginInit();
			this.SuspendLayout();
			// 
			// NewCustomerName
			// 
			this.NewCustomerName.Location = new System.Drawing.Point(200, 124);
			this.NewCustomerName.Margin = new System.Windows.Forms.Padding(5);
			this.NewCustomerName.Name = "NewCustomerName";
			this.NewCustomerName.Size = new System.Drawing.Size(348, 29);
			this.NewCustomerName.TabIndex = 0;
			// 
			// NewCustomerSurname
			// 
			this.NewCustomerSurname.Location = new System.Drawing.Point(200, 195);
			this.NewCustomerSurname.Margin = new System.Windows.Forms.Padding(5);
			this.NewCustomerSurname.Name = "NewCustomerSurname";
			this.NewCustomerSurname.Size = new System.Drawing.Size(348, 29);
			this.NewCustomerSurname.TabIndex = 1;
			// 
			// NewCustomerID
			// 
			this.NewCustomerID.Location = new System.Drawing.Point(200, 270);
			this.NewCustomerID.Margin = new System.Windows.Forms.Padding(5);
			this.NewCustomerID.Name = "NewCustomerID";
			this.NewCustomerID.Size = new System.Drawing.Size(348, 29);
			this.NewCustomerID.TabIndex = 2;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(40, 130);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(50, 22);
			this.label1.TabIndex = 3;
			this.label1.Text = "Name";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(40, 273);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(30, 22);
			this.label2.TabIndex = 4;
			this.label2.Text = "ID";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(40, 198);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(80, 22);
			this.label3.TabIndex = 5;
			this.label3.Text = "Surname";
			// 
			// NewCustomerNumber
			// 
			this.NewCustomerNumber.Location = new System.Drawing.Point(351, 498);
			this.NewCustomerNumber.Maximum = new decimal(new int[] {
            20000,
            0,
            0,
            0});
			this.NewCustomerNumber.Name = "NewCustomerNumber";
			this.NewCustomerNumber.Size = new System.Drawing.Size(197, 29);
			this.NewCustomerNumber.TabIndex = 5;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(40, 500);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(130, 22);
			this.label4.TabIndex = 7;
			this.label4.Text = "Customer No.";
			// 
			// NewCustomerAddIdPictureBtn
			// 
			this.NewCustomerAddIdPictureBtn.Location = new System.Drawing.Point(45, 565);
			this.NewCustomerAddIdPictureBtn.Name = "NewCustomerAddIdPictureBtn";
			this.NewCustomerAddIdPictureBtn.Size = new System.Drawing.Size(226, 44);
			this.NewCustomerAddIdPictureBtn.TabIndex = 6;
			this.NewCustomerAddIdPictureBtn.Text = "Add Picture";
			this.NewCustomerAddIdPictureBtn.UseVisualStyleBackColor = true;
			this.NewCustomerAddIdPictureBtn.Click += new System.EventHandler(this.NewCustomerAddIdPictureBtn_Click);
			// 
			// NewCustomerCancelBtn
			// 
			this.NewCustomerCancelBtn.Location = new System.Drawing.Point(807, 565);
			this.NewCustomerCancelBtn.Name = "NewCustomerCancelBtn";
			this.NewCustomerCancelBtn.Size = new System.Drawing.Size(226, 44);
			this.NewCustomerCancelBtn.TabIndex = 9;
			this.NewCustomerCancelBtn.Text = "Cancel";
			this.NewCustomerCancelBtn.UseVisualStyleBackColor = true;
			this.NewCustomerCancelBtn.Click += new System.EventHandler(this.NewCustomerCancelBtn_Click);
			// 
			// NewCustomerConfirmBtn
			// 
			this.NewCustomerConfirmBtn.Location = new System.Drawing.Point(1072, 565);
			this.NewCustomerConfirmBtn.Name = "NewCustomerConfirmBtn";
			this.NewCustomerConfirmBtn.Size = new System.Drawing.Size(226, 44);
			this.NewCustomerConfirmBtn.TabIndex = 7;
			this.NewCustomerConfirmBtn.Text = "Confirm";
			this.NewCustomerConfirmBtn.UseVisualStyleBackColor = true;
			this.NewCustomerConfirmBtn.Click += new System.EventHandler(this.NewCustomerConfirmBtn_Click);
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Consolas", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(501, 9);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(336, 56);
			this.label5.TabIndex = 12;
			this.label5.Text = "New Customer";
			// 
			// NewCustomerIdPicture
			// 
			this.NewCustomerIdPicture.BackColor = System.Drawing.SystemColors.ControlLight;
			this.NewCustomerIdPicture.Location = new System.Drawing.Point(672, 114);
			this.NewCustomerIdPicture.Name = "NewCustomerIdPicture";
			this.NewCustomerIdPicture.Size = new System.Drawing.Size(625, 438);
			this.NewCustomerIdPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.NewCustomerIdPicture.TabIndex = 13;
			this.NewCustomerIdPicture.TabStop = false;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(40, 427);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(50, 22);
			this.label6.TabIndex = 14;
			this.label6.Text = "Cell";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(40, 351);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(80, 22);
			this.label7.TabIndex = 15;
			this.label7.Text = "Address";
			// 
			// NewCustomerCell
			// 
			this.NewCustomerCell.Location = new System.Drawing.Point(200, 424);
			this.NewCustomerCell.Maximum = new decimal(new int[] {
            1410065407,
            2,
            0,
            0});
			this.NewCustomerCell.Name = "NewCustomerCell";
			this.NewCustomerCell.Size = new System.Drawing.Size(348, 29);
			this.NewCustomerCell.TabIndex = 4;
			// 
			// NewCustomerAddress
			// 
			this.NewCustomerAddress.Location = new System.Drawing.Point(200, 348);
			this.NewCustomerAddress.Margin = new System.Windows.Forms.Padding(5);
			this.NewCustomerAddress.Name = "NewCustomerAddress";
			this.NewCustomerAddress.Size = new System.Drawing.Size(348, 29);
			this.NewCustomerAddress.TabIndex = 3;
			// 
			// NewCustomer
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Highlight;
			this.ClientSize = new System.Drawing.Size(1340, 655);
			this.Controls.Add(this.NewCustomerAddress);
			this.Controls.Add(this.NewCustomerCell);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.NewCustomerIdPicture);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.NewCustomerConfirmBtn);
			this.Controls.Add(this.NewCustomerCancelBtn);
			this.Controls.Add(this.NewCustomerAddIdPictureBtn);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.NewCustomerNumber);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.NewCustomerID);
			this.Controls.Add(this.NewCustomerSurname);
			this.Controls.Add(this.NewCustomerName);
			this.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Margin = new System.Windows.Forms.Padding(5);
			this.Name = "NewCustomer";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Green Envrio SA Recycling";
			((System.ComponentModel.ISupportInitialize)(this.NewCustomerNumber)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.NewCustomerIdPicture)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.NewCustomerCell)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox NewCustomerName;
		private System.Windows.Forms.TextBox NewCustomerSurname;
		private System.Windows.Forms.TextBox NewCustomerID;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.NumericUpDown NewCustomerNumber;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button NewCustomerAddIdPictureBtn;
		private System.Windows.Forms.Button NewCustomerCancelBtn;
		private System.Windows.Forms.Button NewCustomerConfirmBtn;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.PictureBox NewCustomerIdPicture;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.NumericUpDown NewCustomerCell;
		private System.Windows.Forms.TextBox NewCustomerAddress;
	}
}