
namespace Green_Enviro_App
{
	partial class CustomMessageBox
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomMessageBox));
			this.CustomMsgBox = new System.Windows.Forms.Label();
			this.CustomMsg = new System.Windows.Forms.Label();
			this.OkBtn = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// CustomMsgBox
			// 
			this.CustomMsgBox.AutoSize = true;
			this.CustomMsgBox.Font = new System.Drawing.Font("Consolas", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.CustomMsgBox.Location = new System.Drawing.Point(107, 111);
			this.CustomMsgBox.Name = "CustomMsgBox";
			this.CustomMsgBox.Size = new System.Drawing.Size(0, 70);
			this.CustomMsgBox.TabIndex = 0;
			// 
			// CustomMsg
			// 
			this.CustomMsg.Font = new System.Drawing.Font("Consolas", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.CustomMsg.Location = new System.Drawing.Point(38, 21);
			this.CustomMsg.Name = "CustomMsg";
			this.CustomMsg.Size = new System.Drawing.Size(726, 269);
			this.CustomMsg.TabIndex = 1;
			this.CustomMsg.Text = "label1";
			// 
			// OkBtn
			// 
			this.OkBtn.Font = new System.Drawing.Font("Consolas", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.OkBtn.Location = new System.Drawing.Point(328, 316);
			this.OkBtn.Name = "OkBtn";
			this.OkBtn.Size = new System.Drawing.Size(142, 55);
			this.OkBtn.TabIndex = 2;
			this.OkBtn.Text = "OK";
			this.OkBtn.UseVisualStyleBackColor = true;
			this.OkBtn.Click += new System.EventHandler(this.OkBtn_Click);
			// 
			// CustomMessageBox
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(816, 383);
			this.ControlBox = false;
			this.Controls.Add(this.OkBtn);
			this.Controls.Add(this.CustomMsg);
			this.Controls.Add(this.CustomMsgBox);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "CustomMessageBox";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Response";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		public System.Windows.Forms.Label CustomMsgBox;
		public System.Windows.Forms.Label CustomMsg;
		private System.Windows.Forms.Button OkBtn;
	}
}