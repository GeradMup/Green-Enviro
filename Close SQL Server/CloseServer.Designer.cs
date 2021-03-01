
namespace Close_SQL_Server
{
	partial class CloseServer
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CloseServer));
			this.MainText = new System.Windows.Forms.Label();
			this.Ok = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// MainText
			// 
			this.MainText.AutoSize = true;
			this.MainText.Font = new System.Drawing.Font("Consolas", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.MainText.ForeColor = System.Drawing.Color.Lime;
			this.MainText.Location = new System.Drawing.Point(66, 170);
			this.MainText.Name = "MainText";
			this.MainText.Size = new System.Drawing.Size(0, 38);
			this.MainText.TabIndex = 0;
			// 
			// Ok
			// 
			this.Ok.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Ok.Location = new System.Drawing.Point(332, 335);
			this.Ok.Name = "Ok";
			this.Ok.Size = new System.Drawing.Size(173, 61);
			this.Ok.TabIndex = 1;
			this.Ok.Text = "OK";
			this.Ok.UseVisualStyleBackColor = true;
			this.Ok.Click += new System.EventHandler(this.Ok_Click);
			// 
			// CloseServer
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(851, 422);
			this.Controls.Add(this.Ok);
			this.Controls.Add(this.MainText);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "CloseServer";
			this.Text = "Green Enviro SA Recycling";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CloseServer_FormClosed);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label MainText;
		private System.Windows.Forms.Button Ok;
	}
}

