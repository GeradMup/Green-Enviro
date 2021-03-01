
namespace Green_Enviro_Sync
{
	partial class CopyDB
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CopyDB));
			this.saveEnquiry = new System.Windows.Forms.Label();
			this.YesBtn = new System.Windows.Forms.Button();
			this.NoBtn = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// saveEnquiry
			// 
			this.saveEnquiry.AutoSize = true;
			this.saveEnquiry.Font = new System.Drawing.Font("Consolas", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.saveEnquiry.Location = new System.Drawing.Point(57, 88);
			this.saveEnquiry.Name = "saveEnquiry";
			this.saveEnquiry.Size = new System.Drawing.Size(665, 38);
			this.saveEnquiry.TabIndex = 0;
			this.saveEnquiry.Text = "Do you want to syncronize your data?";
			// 
			// YesBtn
			// 
			this.YesBtn.Font = new System.Drawing.Font("Consolas", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.YesBtn.Location = new System.Drawing.Point(122, 258);
			this.YesBtn.Name = "YesBtn";
			this.YesBtn.Size = new System.Drawing.Size(189, 74);
			this.YesBtn.TabIndex = 1;
			this.YesBtn.Text = "YES";
			this.YesBtn.UseVisualStyleBackColor = true;
			this.YesBtn.Click += new System.EventHandler(this.YesBtn_Click);
			// 
			// NoBtn
			// 
			this.NoBtn.Font = new System.Drawing.Font("Consolas", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.NoBtn.Location = new System.Drawing.Point(481, 258);
			this.NoBtn.Name = "NoBtn";
			this.NoBtn.Size = new System.Drawing.Size(189, 74);
			this.NoBtn.TabIndex = 2;
			this.NoBtn.Text = "NO";
			this.NoBtn.UseVisualStyleBackColor = true;
			this.NoBtn.Click += new System.EventHandler(this.NoBtn_Click);
			// 
			// CopyDB
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.NoBtn);
			this.Controls.Add(this.YesBtn);
			this.Controls.Add(this.saveEnquiry);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "CopyDB";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Green Enviro Synchronizer";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CopyDB_FormClosing);
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CopyDB_FormClosed);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label saveEnquiry;
		private System.Windows.Forms.Button YesBtn;
		private System.Windows.Forms.Button NoBtn;
	}
}