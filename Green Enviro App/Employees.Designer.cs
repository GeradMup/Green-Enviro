
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
			this.EmployeeNameField = new System.Windows.Forms.TextBox();
			this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.EmployeeSurnameField = new System.Windows.Forms.TextBox();
			this.EmployeeIdentificationField = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.EmployeeGenderField = new System.Windows.Forms.ComboBox();
			this.EmployeesAddEmployeeBtn = new System.Windows.Forms.Button();
			this.EmployeesCancelBtn = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// EmployeeNameField
			// 
			this.EmployeeNameField.Location = new System.Drawing.Point(351, 145);
			this.EmployeeNameField.Margin = new System.Windows.Forms.Padding(5);
			this.EmployeeNameField.Name = "EmployeeNameField";
			this.EmployeeNameField.Size = new System.Drawing.Size(450, 34);
			this.EmployeeNameField.TabIndex = 0;
			// 
			// contextMenuStrip1
			// 
			this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.contextMenuStrip1.Name = "contextMenuStrip1";
			this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
			// 
			// EmployeeSurnameField
			// 
			this.EmployeeSurnameField.Location = new System.Drawing.Point(351, 220);
			this.EmployeeSurnameField.Margin = new System.Windows.Forms.Padding(5);
			this.EmployeeSurnameField.Name = "EmployeeSurnameField";
			this.EmployeeSurnameField.Size = new System.Drawing.Size(450, 34);
			this.EmployeeSurnameField.TabIndex = 2;
			// 
			// EmployeeIdentificationField
			// 
			this.EmployeeIdentificationField.Location = new System.Drawing.Point(351, 305);
			this.EmployeeIdentificationField.Margin = new System.Windows.Forms.Padding(5);
			this.EmployeeIdentificationField.Name = "EmployeeIdentificationField";
			this.EmployeeIdentificationField.Size = new System.Drawing.Size(450, 34);
			this.EmployeeIdentificationField.TabIndex = 3;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Consolas", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(247, 29);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(426, 70);
			this.label1.TabIndex = 5;
			this.label1.Text = "New Employee";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(77, 385);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(90, 28);
			this.label2.TabIndex = 6;
			this.label2.Text = "Gender";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(77, 308);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(194, 28);
			this.label3.TabIndex = 7;
			this.label3.Text = "Identification";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(77, 223);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(103, 28);
			this.label4.TabIndex = 8;
			this.label4.Text = "Surname";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(77, 148);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(64, 28);
			this.label5.TabIndex = 9;
			this.label5.Text = "Name";
			// 
			// EmployeeGenderField
			// 
			this.EmployeeGenderField.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.EmployeeGenderField.FormattingEnabled = true;
			this.EmployeeGenderField.Items.AddRange(new object[] {
            "Male",
            "Female"});
			this.EmployeeGenderField.Location = new System.Drawing.Point(355, 384);
			this.EmployeeGenderField.Name = "EmployeeGenderField";
			this.EmployeeGenderField.Size = new System.Drawing.Size(318, 35);
			this.EmployeeGenderField.TabIndex = 10;
			// 
			// EmployeesAddEmployeeBtn
			// 
			this.EmployeesAddEmployeeBtn.Location = new System.Drawing.Point(110, 494);
			this.EmployeesAddEmployeeBtn.Name = "EmployeesAddEmployeeBtn";
			this.EmployeesAddEmployeeBtn.Size = new System.Drawing.Size(309, 57);
			this.EmployeesAddEmployeeBtn.TabIndex = 11;
			this.EmployeesAddEmployeeBtn.Text = "Add Employee";
			this.EmployeesAddEmployeeBtn.UseVisualStyleBackColor = true;
			this.EmployeesAddEmployeeBtn.Click += new System.EventHandler(this.EmployeesAddEmployeeBtn_Click);
			// 
			// EmployeesCancelBtn
			// 
			this.EmployeesCancelBtn.Location = new System.Drawing.Point(479, 494);
			this.EmployeesCancelBtn.Name = "EmployeesCancelBtn";
			this.EmployeesCancelBtn.Size = new System.Drawing.Size(307, 57);
			this.EmployeesCancelBtn.TabIndex = 12;
			this.EmployeesCancelBtn.Text = "Cancel";
			this.EmployeesCancelBtn.UseVisualStyleBackColor = true;
			this.EmployeesCancelBtn.Click += new System.EventHandler(this.EmployeesCancelBtn_Click);
			// 
			// Employees
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 27F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Highlight;
			this.ClientSize = new System.Drawing.Size(911, 596);
			this.Controls.Add(this.EmployeesCancelBtn);
			this.Controls.Add(this.EmployeesAddEmployeeBtn);
			this.Controls.Add(this.EmployeeGenderField);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.EmployeeIdentificationField);
			this.Controls.Add(this.EmployeeSurnameField);
			this.Controls.Add(this.EmployeeNameField);
			this.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(5);
			this.Name = "Employees";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Green Enviro SA Recycling";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox EmployeeNameField;
		private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
		private System.Windows.Forms.TextBox EmployeeSurnameField;
		private System.Windows.Forms.TextBox EmployeeIdentificationField;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.ComboBox EmployeeGenderField;
		private System.Windows.Forms.Button EmployeesAddEmployeeBtn;
		private System.Windows.Forms.Button EmployeesCancelBtn;
	}
}