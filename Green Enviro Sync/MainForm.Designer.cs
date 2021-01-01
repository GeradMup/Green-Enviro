
namespace Green_Enviro_Sync
{
	partial class Sync
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Sync));
			this.UploadBtn = new System.Windows.Forms.Button();
			this.DownloadBtn = new System.Windows.Forms.Button();
			this.UpDownPgBar = new System.Windows.Forms.ProgressBar();
			this.SuspendLayout();
			// 
			// UploadBtn
			// 
			this.UploadBtn.Font = new System.Drawing.Font("Consolas", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.UploadBtn.Location = new System.Drawing.Point(67, 54);
			this.UploadBtn.Name = "UploadBtn";
			this.UploadBtn.Size = new System.Drawing.Size(221, 114);
			this.UploadBtn.TabIndex = 0;
			this.UploadBtn.Text = "Upload";
			this.UploadBtn.UseVisualStyleBackColor = true;
			this.UploadBtn.Click += new System.EventHandler(this.UploadBtn_Click);
			// 
			// DownloadBtn
			// 
			this.DownloadBtn.Font = new System.Drawing.Font("Consolas", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.DownloadBtn.Location = new System.Drawing.Point(492, 54);
			this.DownloadBtn.Name = "DownloadBtn";
			this.DownloadBtn.Size = new System.Drawing.Size(221, 114);
			this.DownloadBtn.TabIndex = 1;
			this.DownloadBtn.Text = "Download";
			this.DownloadBtn.UseVisualStyleBackColor = true;
			this.DownloadBtn.Click += new System.EventHandler(this.DownloadBtn_Click);
			// 
			// UpDownPgBar
			// 
			this.UpDownPgBar.Location = new System.Drawing.Point(67, 343);
			this.UpDownPgBar.Name = "UpDownPgBar";
			this.UpDownPgBar.Size = new System.Drawing.Size(769, 131);
			this.UpDownPgBar.TabIndex = 2;
			this.UpDownPgBar.Visible = false;
			// 
			// Sync
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(868, 509);
			this.Controls.Add(this.UpDownPgBar);
			this.Controls.Add(this.DownloadBtn);
			this.Controls.Add(this.UploadBtn);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "Sync";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Green Enviro Synchronizer";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button UploadBtn;
		private System.Windows.Forms.Button DownloadBtn;
		private System.Windows.Forms.ProgressBar UpDownPgBar;
	}
}

