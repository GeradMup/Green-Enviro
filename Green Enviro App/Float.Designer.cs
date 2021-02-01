
namespace Green_Enviro_App
{
	partial class Float
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
			this.AddFloat = new System.Windows.Forms.Button();
			this.AddedFloat = new System.Windows.Forms.NumericUpDown();
			this.label1 = new System.Windows.Forms.Label();
			this.AddFloatCancel = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.AddedFloat)).BeginInit();
			this.SuspendLayout();
			// 
			// AddFloat
			// 
			this.AddFloat.Location = new System.Drawing.Point(31, 125);
			this.AddFloat.Margin = new System.Windows.Forms.Padding(5);
			this.AddFloat.Name = "AddFloat";
			this.AddFloat.Size = new System.Drawing.Size(200, 61);
			this.AddFloat.TabIndex = 0;
			this.AddFloat.Text = "Add ";
			this.AddFloat.UseVisualStyleBackColor = true;
			this.AddFloat.Click += new System.EventHandler(this.AddFloat_Click);
			// 
			// AddedFloat
			// 
			this.AddedFloat.DecimalPlaces = 2;
			this.AddedFloat.Location = new System.Drawing.Point(159, 73);
			this.AddedFloat.Margin = new System.Windows.Forms.Padding(4);
			this.AddedFloat.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
			this.AddedFloat.Name = "AddedFloat";
			this.AddedFloat.Size = new System.Drawing.Size(178, 34);
			this.AddedFloat.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Consolas", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(131, 20);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(233, 38);
			this.label1.TabIndex = 2;
			this.label1.Text = "Adding Float";
			// 
			// AddFloatCancel
			// 
			this.AddFloatCancel.Location = new System.Drawing.Point(266, 125);
			this.AddFloatCancel.Margin = new System.Windows.Forms.Padding(5);
			this.AddFloatCancel.Name = "AddFloatCancel";
			this.AddFloatCancel.Size = new System.Drawing.Size(200, 61);
			this.AddFloatCancel.TabIndex = 3;
			this.AddFloatCancel.Text = "Cancel";
			this.AddFloatCancel.UseVisualStyleBackColor = true;
			this.AddFloatCancel.Click += new System.EventHandler(this.AddFloatCancel_Click);
			// 
			// Float
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 27F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.MenuHighlight;
			this.ClientSize = new System.Drawing.Size(495, 218);
			this.Controls.Add(this.AddFloatCancel);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.AddedFloat);
			this.Controls.Add(this.AddFloat);
			this.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Margin = new System.Windows.Forms.Padding(5);
			this.Name = "Float";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Float";
			((System.ComponentModel.ISupportInitialize)(this.AddedFloat)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button AddFloat;
		private System.Windows.Forms.NumericUpDown AddedFloat;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button AddFloatCancel;
	}
}