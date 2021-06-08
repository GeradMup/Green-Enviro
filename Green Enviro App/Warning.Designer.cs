
namespace Green_Enviro_App
{
	partial class Warning
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Warning));
			this.CustomMsg = new System.Windows.Forms.Label();
			this.ConfirmBtn = new System.Windows.Forms.Button();
			this.CancelBtn = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// CustomMsg
			// 
			this.CustomMsg.Font = new System.Drawing.Font("Consolas", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.CustomMsg.Location = new System.Drawing.Point(75, 19);
			this.CustomMsg.Name = "CustomMsg";
			this.CustomMsg.Size = new System.Drawing.Size(638, 196);
			this.CustomMsg.TabIndex = 0;
			this.CustomMsg.Text = "label1";
			// 
			// ConfirmBtn
			// 
			this.ConfirmBtn.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ConfirmBtn.Location = new System.Drawing.Point(82, 253);
			this.ConfirmBtn.Name = "ConfirmBtn";
			this.ConfirmBtn.Size = new System.Drawing.Size(241, 68);
			this.ConfirmBtn.TabIndex = 1;
			this.ConfirmBtn.Text = "Confirm";
			this.ConfirmBtn.UseVisualStyleBackColor = true;
			this.ConfirmBtn.Click += new System.EventHandler(this.ConfirmBtn_Click);
			// 
			// CancelBtn
			// 
			this.CancelBtn.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.CancelBtn.Location = new System.Drawing.Point(478, 253);
			this.CancelBtn.Name = "CancelBtn";
			this.CancelBtn.Size = new System.Drawing.Size(228, 68);
			this.CancelBtn.TabIndex = 2;
			this.CancelBtn.Text = "Cancel";
			this.CancelBtn.UseVisualStyleBackColor = true;
			this.CancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
			// 
			// Warning
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 349);
			this.Controls.Add(this.CancelBtn);
			this.Controls.Add(this.ConfirmBtn);
			this.Controls.Add(this.CustomMsg);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "Warning";
			this.Text = "Warning";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Label CustomMsg;
		private System.Windows.Forms.Button ConfirmBtn;
		private System.Windows.Forms.Button CancelBtn;
	}
}