
namespace Green_Enviro_App
{
	partial class Employees
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Employees));
			this.EmployeeName = new System.Windows.Forms.TextBox();
			this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.EmployeeSurname = new System.Windows.Forms.TextBox();
			this.EmployeeIdentification = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.EmployeeGenderLabel = new System.Windows.Forms.Label();
			this.EmployeeIDLabel = new System.Windows.Forms.Label();
			this.EmployeeSurnameLabel = new System.Windows.Forms.Label();
			this.EmployeeNameLabel = new System.Windows.Forms.Label();
			this.EmployeeGender = new System.Windows.Forms.ComboBox();
			this.EmployeesAddEmployeeBtn = new System.Windows.Forms.Button();
			this.EmployeesDoneBtn = new System.Windows.Forms.Button();
			this.EmployeeAddressLabel = new System.Windows.Forms.Label();
			this.EmployeeAddress = new System.Windows.Forms.TextBox();
			this.EmployeeCellNumberLabel = new System.Windows.Forms.Label();
			this.EmployeeCellNumber = new System.Windows.Forms.TextBox();
			this.EmployeesCancelBtn = new System.Windows.Forms.Button();
			this.EmployeesGridView = new System.Windows.Forms.DataGridView();
			this.EmployeesCloseGridBtn = new System.Windows.Forms.Button();
			this.EmployeesViewGridBtn = new System.Windows.Forms.Button();
			this.EmployeesGridPanel = new System.Windows.Forms.Panel();
			((System.ComponentModel.ISupportInitialize)(this.EmployeesGridView)).BeginInit();
			this.EmployeesGridPanel.SuspendLayout();
			this.SuspendLayout();
			// 
			// EmployeeName
			// 
			this.EmployeeName.Location = new System.Drawing.Point(267, 139);
			this.EmployeeName.Margin = new System.Windows.Forms.Padding(5);
			this.EmployeeName.Name = "EmployeeName";
			this.EmployeeName.Size = new System.Drawing.Size(371, 34);
			this.EmployeeName.TabIndex = 0;
			// 
			// contextMenuStrip1
			// 
			this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.contextMenuStrip1.Name = "contextMenuStrip1";
			this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
			// 
			// EmployeeSurname
			// 
			this.EmployeeSurname.Location = new System.Drawing.Point(267, 199);
			this.EmployeeSurname.Margin = new System.Windows.Forms.Padding(5);
			this.EmployeeSurname.Name = "EmployeeSurname";
			this.EmployeeSurname.Size = new System.Drawing.Size(371, 34);
			this.EmployeeSurname.TabIndex = 2;
			// 
			// EmployeeIdentification
			// 
			this.EmployeeIdentification.Location = new System.Drawing.Point(267, 260);
			this.EmployeeIdentification.Margin = new System.Windows.Forms.Padding(5);
			this.EmployeeIdentification.Name = "EmployeeIdentification";
			this.EmployeeIdentification.Size = new System.Drawing.Size(371, 34);
			this.EmployeeIdentification.TabIndex = 3;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Consolas", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(569, 18);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(426, 70);
			this.label1.TabIndex = 5;
			this.label1.Text = "New Employee";
			// 
			// EmployeeGenderLabel
			// 
			this.EmployeeGenderLabel.AutoSize = true;
			this.EmployeeGenderLabel.Location = new System.Drawing.Point(31, 328);
			this.EmployeeGenderLabel.Name = "EmployeeGenderLabel";
			this.EmployeeGenderLabel.Size = new System.Drawing.Size(90, 28);
			this.EmployeeGenderLabel.TabIndex = 6;
			this.EmployeeGenderLabel.Text = "Gender";
			// 
			// EmployeeIDLabel
			// 
			this.EmployeeIDLabel.AutoSize = true;
			this.EmployeeIDLabel.Location = new System.Drawing.Point(31, 266);
			this.EmployeeIDLabel.Name = "EmployeeIDLabel";
			this.EmployeeIDLabel.Size = new System.Drawing.Size(194, 28);
			this.EmployeeIDLabel.TabIndex = 7;
			this.EmployeeIDLabel.Text = "Identification";
			// 
			// EmployeeSurnameLabel
			// 
			this.EmployeeSurnameLabel.AutoSize = true;
			this.EmployeeSurnameLabel.Location = new System.Drawing.Point(31, 205);
			this.EmployeeSurnameLabel.Name = "EmployeeSurnameLabel";
			this.EmployeeSurnameLabel.Size = new System.Drawing.Size(103, 28);
			this.EmployeeSurnameLabel.TabIndex = 8;
			this.EmployeeSurnameLabel.Text = "Surname";
			// 
			// EmployeeNameLabel
			// 
			this.EmployeeNameLabel.AutoSize = true;
			this.EmployeeNameLabel.Location = new System.Drawing.Point(31, 145);
			this.EmployeeNameLabel.Name = "EmployeeNameLabel";
			this.EmployeeNameLabel.Size = new System.Drawing.Size(64, 28);
			this.EmployeeNameLabel.TabIndex = 9;
			this.EmployeeNameLabel.Text = "Name";
			// 
			// EmployeeGender
			// 
			this.EmployeeGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.EmployeeGender.FormattingEnabled = true;
			this.EmployeeGender.Items.AddRange(new object[] {
            "Male",
            "Female"});
			this.EmployeeGender.Location = new System.Drawing.Point(267, 321);
			this.EmployeeGender.Name = "EmployeeGender";
			this.EmployeeGender.Size = new System.Drawing.Size(318, 35);
			this.EmployeeGender.TabIndex = 10;
			// 
			// EmployeesAddEmployeeBtn
			// 
			this.EmployeesAddEmployeeBtn.Location = new System.Drawing.Point(36, 548);
			this.EmployeesAddEmployeeBtn.Name = "EmployeesAddEmployeeBtn";
			this.EmployeesAddEmployeeBtn.Size = new System.Drawing.Size(245, 57);
			this.EmployeesAddEmployeeBtn.TabIndex = 11;
			this.EmployeesAddEmployeeBtn.Text = "Add Employee";
			this.EmployeesAddEmployeeBtn.UseVisualStyleBackColor = true;
			this.EmployeesAddEmployeeBtn.Click += new System.EventHandler(this.EmployeesAddEmployeeBtn_Click);
			// 
			// EmployeesDoneBtn
			// 
			this.EmployeesDoneBtn.Location = new System.Drawing.Point(307, 548);
			this.EmployeesDoneBtn.Name = "EmployeesDoneBtn";
			this.EmployeesDoneBtn.Size = new System.Drawing.Size(138, 57);
			this.EmployeesDoneBtn.TabIndex = 12;
			this.EmployeesDoneBtn.Text = "Done";
			this.EmployeesDoneBtn.UseVisualStyleBackColor = true;
			this.EmployeesDoneBtn.Click += new System.EventHandler(this.EmployeesCancelBtn_Click);
			// 
			// EmployeeAddressLabel
			// 
			this.EmployeeAddressLabel.AutoSize = true;
			this.EmployeeAddressLabel.Location = new System.Drawing.Point(31, 392);
			this.EmployeeAddressLabel.Name = "EmployeeAddressLabel";
			this.EmployeeAddressLabel.Size = new System.Drawing.Size(103, 28);
			this.EmployeeAddressLabel.TabIndex = 13;
			this.EmployeeAddressLabel.Text = "Address";
			// 
			// EmployeeAddress
			// 
			this.EmployeeAddress.Location = new System.Drawing.Point(267, 386);
			this.EmployeeAddress.Margin = new System.Windows.Forms.Padding(5);
			this.EmployeeAddress.Name = "EmployeeAddress";
			this.EmployeeAddress.Size = new System.Drawing.Size(371, 34);
			this.EmployeeAddress.TabIndex = 14;
			// 
			// EmployeeCellNumberLabel
			// 
			this.EmployeeCellNumberLabel.AutoSize = true;
			this.EmployeeCellNumberLabel.Location = new System.Drawing.Point(31, 446);
			this.EmployeeCellNumberLabel.Name = "EmployeeCellNumberLabel";
			this.EmployeeCellNumberLabel.Size = new System.Drawing.Size(155, 28);
			this.EmployeeCellNumberLabel.TabIndex = 15;
			this.EmployeeCellNumberLabel.Text = "Cell Number";
			// 
			// EmployeeCellNumber
			// 
			this.EmployeeCellNumber.Location = new System.Drawing.Point(267, 446);
			this.EmployeeCellNumber.Margin = new System.Windows.Forms.Padding(5);
			this.EmployeeCellNumber.Name = "EmployeeCellNumber";
			this.EmployeeCellNumber.Size = new System.Drawing.Size(371, 34);
			this.EmployeeCellNumber.TabIndex = 16;
			// 
			// EmployeesCancelBtn
			// 
			this.EmployeesCancelBtn.Location = new System.Drawing.Point(484, 548);
			this.EmployeesCancelBtn.Name = "EmployeesCancelBtn";
			this.EmployeesCancelBtn.Size = new System.Drawing.Size(154, 57);
			this.EmployeesCancelBtn.TabIndex = 17;
			this.EmployeesCancelBtn.Text = "Cancel";
			this.EmployeesCancelBtn.UseVisualStyleBackColor = true;
			// 
			// EmployeesGridView
			// 
			this.EmployeesGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.EmployeesGridView.BackgroundColor = System.Drawing.SystemColors.ControlLight;
			this.EmployeesGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.EmployeesGridView.Location = new System.Drawing.Point(13, 12);
			this.EmployeesGridView.Name = "EmployeesGridView";
			this.EmployeesGridView.RowHeadersWidth = 51;
			this.EmployeesGridView.RowTemplate.Height = 24;
			this.EmployeesGridView.Size = new System.Drawing.Size(805, 502);
			this.EmployeesGridView.TabIndex = 19;
			// 
			// EmployeesCloseGridBtn
			// 
			this.EmployeesCloseGridBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.EmployeesCloseGridBtn.BackColor = System.Drawing.SystemColors.ControlLight;
			this.EmployeesCloseGridBtn.Location = new System.Drawing.Point(13, 524);
			this.EmployeesCloseGridBtn.Name = "EmployeesCloseGridBtn";
			this.EmployeesCloseGridBtn.Size = new System.Drawing.Size(245, 57);
			this.EmployeesCloseGridBtn.TabIndex = 20;
			this.EmployeesCloseGridBtn.Text = "Close Grid";
			this.EmployeesCloseGridBtn.UseVisualStyleBackColor = false;
			this.EmployeesCloseGridBtn.Click += new System.EventHandler(this.EmployeesCloseGridBtn_Click);
			// 
			// EmployeesViewGridBtn
			// 
			this.EmployeesViewGridBtn.BackColor = System.Drawing.SystemColors.ControlLight;
			this.EmployeesViewGridBtn.Location = new System.Drawing.Point(36, 642);
			this.EmployeesViewGridBtn.Name = "EmployeesViewGridBtn";
			this.EmployeesViewGridBtn.Size = new System.Drawing.Size(245, 57);
			this.EmployeesViewGridBtn.TabIndex = 21;
			this.EmployeesViewGridBtn.Text = "View Employees";
			this.EmployeesViewGridBtn.UseVisualStyleBackColor = false;
			this.EmployeesViewGridBtn.Click += new System.EventHandler(this.EmployeesViewGridBtn_Click);
			// 
			// EmployeesGridPanel
			// 
			this.EmployeesGridPanel.BackColor = System.Drawing.SystemColors.ControlDark;
			this.EmployeesGridPanel.Controls.Add(this.EmployeesGridView);
			this.EmployeesGridPanel.Controls.Add(this.EmployeesCloseGridBtn);
			this.EmployeesGridPanel.Location = new System.Drawing.Point(670, 133);
			this.EmployeesGridPanel.Name = "EmployeesGridPanel";
			this.EmployeesGridPanel.Size = new System.Drawing.Size(835, 596);
			this.EmployeesGridPanel.TabIndex = 22;
			// 
			// Employees
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 27F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Highlight;
			this.ClientSize = new System.Drawing.Size(1517, 741);
			this.Controls.Add(this.EmployeesGridPanel);
			this.Controls.Add(this.EmployeesViewGridBtn);
			this.Controls.Add(this.EmployeesCancelBtn);
			this.Controls.Add(this.EmployeeCellNumber);
			this.Controls.Add(this.EmployeeCellNumberLabel);
			this.Controls.Add(this.EmployeeAddress);
			this.Controls.Add(this.EmployeeAddressLabel);
			this.Controls.Add(this.EmployeesDoneBtn);
			this.Controls.Add(this.EmployeesAddEmployeeBtn);
			this.Controls.Add(this.EmployeeGender);
			this.Controls.Add(this.EmployeeNameLabel);
			this.Controls.Add(this.EmployeeSurnameLabel);
			this.Controls.Add(this.EmployeeIDLabel);
			this.Controls.Add(this.EmployeeGenderLabel);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.EmployeeIdentification);
			this.Controls.Add(this.EmployeeSurname);
			this.Controls.Add(this.EmployeeName);
			this.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(5);
			this.Name = "Employees";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Green Enviro SA Recycling";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			((System.ComponentModel.ISupportInitialize)(this.EmployeesGridView)).EndInit();
			this.EmployeesGridPanel.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox EmployeeName;
		private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
		private System.Windows.Forms.TextBox EmployeeSurname;
		private System.Windows.Forms.TextBox EmployeeIdentification;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label EmployeeGenderLabel;
		private System.Windows.Forms.Label EmployeeIDLabel;
		private System.Windows.Forms.Label EmployeeSurnameLabel;
		private System.Windows.Forms.Label EmployeeNameLabel;
		private System.Windows.Forms.ComboBox EmployeeGender;
		private System.Windows.Forms.Button EmployeesAddEmployeeBtn;
		private System.Windows.Forms.Button EmployeesDoneBtn;
		private System.Windows.Forms.Label EmployeeAddressLabel;
		private System.Windows.Forms.TextBox EmployeeAddress;
		private System.Windows.Forms.Label EmployeeCellNumberLabel;
		private System.Windows.Forms.TextBox EmployeeCellNumber;
		private System.Windows.Forms.Button EmployeesCancelBtn;
		private System.Windows.Forms.Button EmployeesCloseGridBtn;
		private System.Windows.Forms.Button EmployeesViewGridBtn;
		private System.Windows.Forms.DataGridView EmployeesGridView;
		private System.Windows.Forms.Panel EmployeesGridPanel;
	}
}