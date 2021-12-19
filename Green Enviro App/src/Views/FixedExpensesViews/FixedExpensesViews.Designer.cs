
namespace Green_Enviro_App.src.Views.FixedExpensesViews
{
	partial class FixedExpensesViews
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FixedExpensesViews));
			this.FixedExpensesFormHeading = new System.Windows.Forms.Label();
			this.ExpenseName = new System.Windows.Forms.TextBox();
			this.ExpenseNameLabel = new System.Windows.Forms.Label();
			this.ExpenseAmountLabel = new System.Windows.Forms.Label();
			this.ExpenseAmount = new System.Windows.Forms.NumericUpDown();
			this.AddExpenseBtn = new System.Windows.Forms.Button();
			this.FixedExpenseDGV = new System.Windows.Forms.DataGridView();
			this.DoneBtn = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.ExpenseAmount)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.FixedExpenseDGV)).BeginInit();
			this.SuspendLayout();
			// 
			// FixedExpensesFormHeading
			// 
			this.FixedExpensesFormHeading.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.FixedExpensesFormHeading.AutoSize = true;
			this.FixedExpensesFormHeading.Font = new System.Drawing.Font("Consolas", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FixedExpensesFormHeading.Location = new System.Drawing.Point(533, 9);
			this.FixedExpensesFormHeading.Name = "FixedExpensesFormHeading";
			this.FixedExpensesFormHeading.Size = new System.Drawing.Size(269, 37);
			this.FixedExpensesFormHeading.TabIndex = 0;
			this.FixedExpensesFormHeading.Text = "Fixed Expenses";
			// 
			// ExpenseName
			// 
			this.ExpenseName.Location = new System.Drawing.Point(230, 75);
			this.ExpenseName.Name = "ExpenseName";
			this.ExpenseName.Size = new System.Drawing.Size(290, 25);
			this.ExpenseName.TabIndex = 1;
			// 
			// ExpenseNameLabel
			// 
			this.ExpenseNameLabel.AutoSize = true;
			this.ExpenseNameLabel.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ExpenseNameLabel.Location = new System.Drawing.Point(68, 77);
			this.ExpenseNameLabel.Name = "ExpenseNameLabel";
			this.ExpenseNameLabel.Size = new System.Drawing.Size(117, 19);
			this.ExpenseNameLabel.TabIndex = 2;
			this.ExpenseNameLabel.Text = "Expense Name";
			// 
			// ExpenseAmountLabel
			// 
			this.ExpenseAmountLabel.AutoSize = true;
			this.ExpenseAmountLabel.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ExpenseAmountLabel.Location = new System.Drawing.Point(68, 122);
			this.ExpenseAmountLabel.Name = "ExpenseAmountLabel";
			this.ExpenseAmountLabel.Size = new System.Drawing.Size(135, 19);
			this.ExpenseAmountLabel.TabIndex = 4;
			this.ExpenseAmountLabel.Text = "Expense Amount";
			// 
			// ExpenseAmount
			// 
			this.ExpenseAmount.Location = new System.Drawing.Point(230, 121);
			this.ExpenseAmount.Name = "ExpenseAmount";
			this.ExpenseAmount.Size = new System.Drawing.Size(188, 25);
			this.ExpenseAmount.TabIndex = 5;
			// 
			// AddExpenseBtn
			// 
			this.AddExpenseBtn.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.AddExpenseBtn.Location = new System.Drawing.Point(72, 170);
			this.AddExpenseBtn.Name = "AddExpenseBtn";
			this.AddExpenseBtn.Size = new System.Drawing.Size(257, 50);
			this.AddExpenseBtn.TabIndex = 6;
			this.AddExpenseBtn.Text = "Add / Update Expense";
			this.AddExpenseBtn.UseVisualStyleBackColor = true;
			// 
			// FixedExpenseDGV
			// 
			this.FixedExpenseDGV.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.FixedExpenseDGV.BackgroundColor = System.Drawing.SystemColors.ControlLight;
			this.FixedExpenseDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.FixedExpenseDGV.Location = new System.Drawing.Point(539, 75);
			this.FixedExpenseDGV.Name = "FixedExpenseDGV";
			this.FixedExpenseDGV.ReadOnly = true;
			this.FixedExpenseDGV.Size = new System.Drawing.Size(1062, 771);
			this.FixedExpenseDGV.TabIndex = 7;
			// 
			// DoneBtn
			// 
			this.DoneBtn.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.DoneBtn.Location = new System.Drawing.Point(72, 243);
			this.DoneBtn.Name = "DoneBtn";
			this.DoneBtn.Size = new System.Drawing.Size(257, 50);
			this.DoneBtn.TabIndex = 8;
			this.DoneBtn.Text = "Done";
			this.DoneBtn.UseVisualStyleBackColor = true;
			// 
			// FixedExpensesViews
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1613, 858);
			this.Controls.Add(this.DoneBtn);
			this.Controls.Add(this.FixedExpenseDGV);
			this.Controls.Add(this.AddExpenseBtn);
			this.Controls.Add(this.ExpenseAmount);
			this.Controls.Add(this.ExpenseAmountLabel);
			this.Controls.Add(this.ExpenseNameLabel);
			this.Controls.Add(this.ExpenseName);
			this.Controls.Add(this.FixedExpensesFormHeading);
			this.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.Name = "FixedExpensesViews";
			this.Text = "FixedExpensesViews";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			((System.ComponentModel.ISupportInitialize)(this.ExpenseAmount)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.FixedExpenseDGV)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label FixedExpensesFormHeading;
		private System.Windows.Forms.TextBox ExpenseName;
		private System.Windows.Forms.Label ExpenseNameLabel;
		private System.Windows.Forms.Label ExpenseAmountLabel;
		private System.Windows.Forms.NumericUpDown ExpenseAmount;
		private System.Windows.Forms.Button AddExpenseBtn;
		private System.Windows.Forms.DataGridView FixedExpenseDGV;
		private System.Windows.Forms.Button DoneBtn;
	}
}