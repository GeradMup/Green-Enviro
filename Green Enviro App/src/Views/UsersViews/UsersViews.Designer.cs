
namespace Green_Enviro_App
{
    partial class UsersViews
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UsersViews));
			this.UsersDataGridView = new System.Windows.Forms.DataGridView();
			this.greenEnviroDataDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.Username = new System.Windows.Forms.TextBox();
			this.Email = new System.Windows.Forms.TextBox();
			this.Password = new System.Windows.Forms.TextBox();
			this.UsersDeleteBtn = new System.Windows.Forms.Button();
			this.UsersCancelBtn = new System.Windows.Forms.Button();
			this.UsernameLabel = new System.Windows.Forms.Label();
			this.PasswordLabel = new System.Windows.Forms.Label();
			this.EmailLabel = new System.Windows.Forms.Label();
			this.PermissionLevelLabel = new System.Windows.Forms.Label();
			this.PermissionLevel = new System.Windows.Forms.NumericUpDown();
			this.UsersDoneBtn = new System.Windows.Forms.Button();
			this.UsersAddBtn = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.UsersDataGridView)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.greenEnviroDataDataSetBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.PermissionLevel)).BeginInit();
			this.SuspendLayout();
			// 
			// UsersDataGridView
			// 
			this.UsersDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.UsersDataGridView.BackgroundColor = System.Drawing.SystemColors.ControlLight;
			this.UsersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.UsersDataGridView.Location = new System.Drawing.Point(496, 13);
			this.UsersDataGridView.Margin = new System.Windows.Forms.Padding(4);
			this.UsersDataGridView.Name = "UsersDataGridView";
			this.UsersDataGridView.RowHeadersWidth = 51;
			this.UsersDataGridView.Size = new System.Drawing.Size(720, 496);
			this.UsersDataGridView.TabIndex = 0;
			this.UsersDataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.UsersDataGridView_CellDoubleClick);
			// 
			// Username
			// 
			this.Username.Location = new System.Drawing.Point(190, 24);
			this.Username.Margin = new System.Windows.Forms.Padding(4);
			this.Username.Name = "Username";
			this.Username.Size = new System.Drawing.Size(285, 25);
			this.Username.TabIndex = 9;
			// 
			// Email
			// 
			this.Email.Location = new System.Drawing.Point(190, 129);
			this.Email.Margin = new System.Windows.Forms.Padding(4);
			this.Email.Name = "Email";
			this.Email.Size = new System.Drawing.Size(285, 25);
			this.Email.TabIndex = 10;
			// 
			// Password
			// 
			this.Password.Location = new System.Drawing.Point(190, 77);
			this.Password.Margin = new System.Windows.Forms.Padding(4);
			this.Password.Name = "Password";
			this.Password.ReadOnly = true;
			this.Password.Size = new System.Drawing.Size(285, 25);
			this.Password.TabIndex = 11;
			// 
			// UsersDeleteBtn
			// 
			this.UsersDeleteBtn.Location = new System.Drawing.Point(35, 346);
			this.UsersDeleteBtn.Margin = new System.Windows.Forms.Padding(4);
			this.UsersDeleteBtn.Name = "UsersDeleteBtn";
			this.UsersDeleteBtn.Size = new System.Drawing.Size(199, 54);
			this.UsersDeleteBtn.TabIndex = 12;
			this.UsersDeleteBtn.Text = "Delete";
			this.UsersDeleteBtn.UseVisualStyleBackColor = true;
			// 
			// UsersCancelBtn
			// 
			this.UsersCancelBtn.Location = new System.Drawing.Point(261, 429);
			this.UsersCancelBtn.Margin = new System.Windows.Forms.Padding(4);
			this.UsersCancelBtn.Name = "UsersCancelBtn";
			this.UsersCancelBtn.Size = new System.Drawing.Size(199, 54);
			this.UsersCancelBtn.TabIndex = 14;
			this.UsersCancelBtn.Text = "Cancel";
			this.UsersCancelBtn.UseVisualStyleBackColor = true;
			// 
			// UsernameLabel
			// 
			this.UsernameLabel.AutoSize = true;
			this.UsernameLabel.Location = new System.Drawing.Point(32, 27);
			this.UsernameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.UsernameLabel.Name = "UsernameLabel";
			this.UsernameLabel.Size = new System.Drawing.Size(72, 18);
			this.UsernameLabel.TabIndex = 16;
			this.UsernameLabel.Text = "Username";
			// 
			// PasswordLabel
			// 
			this.PasswordLabel.AutoSize = true;
			this.PasswordLabel.Location = new System.Drawing.Point(32, 77);
			this.PasswordLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.PasswordLabel.Name = "PasswordLabel";
			this.PasswordLabel.Size = new System.Drawing.Size(72, 18);
			this.PasswordLabel.TabIndex = 17;
			this.PasswordLabel.Text = "Password";
			// 
			// EmailLabel
			// 
			this.EmailLabel.AutoSize = true;
			this.EmailLabel.Location = new System.Drawing.Point(32, 129);
			this.EmailLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.EmailLabel.Name = "EmailLabel";
			this.EmailLabel.Size = new System.Drawing.Size(48, 18);
			this.EmailLabel.TabIndex = 18;
			this.EmailLabel.Text = "Email";
			// 
			// PermissionLevelLabel
			// 
			this.PermissionLevelLabel.AutoSize = true;
			this.PermissionLevelLabel.Location = new System.Drawing.Point(32, 180);
			this.PermissionLevelLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.PermissionLevelLabel.Name = "PermissionLevelLabel";
			this.PermissionLevelLabel.Size = new System.Drawing.Size(136, 18);
			this.PermissionLevelLabel.TabIndex = 19;
			this.PermissionLevelLabel.Text = "Permission Level";
			// 
			// PermissionLevel
			// 
			this.PermissionLevel.Location = new System.Drawing.Point(190, 180);
			this.PermissionLevel.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
			this.PermissionLevel.Name = "PermissionLevel";
			this.PermissionLevel.Size = new System.Drawing.Size(64, 25);
			this.PermissionLevel.TabIndex = 20;
			// 
			// UsersDoneBtn
			// 
			this.UsersDoneBtn.Location = new System.Drawing.Point(35, 429);
			this.UsersDoneBtn.Margin = new System.Windows.Forms.Padding(4);
			this.UsersDoneBtn.Name = "UsersDoneBtn";
			this.UsersDoneBtn.Size = new System.Drawing.Size(199, 54);
			this.UsersDoneBtn.TabIndex = 21;
			this.UsersDoneBtn.Text = "Done";
			this.UsersDoneBtn.UseVisualStyleBackColor = true;
			this.UsersDoneBtn.Click += new System.EventHandler(this.UsersDoneBtn_Click);
			// 
			// UsersAddBtn
			// 
			this.UsersAddBtn.Location = new System.Drawing.Point(261, 346);
			this.UsersAddBtn.Margin = new System.Windows.Forms.Padding(4);
			this.UsersAddBtn.Name = "UsersAddBtn";
			this.UsersAddBtn.Size = new System.Drawing.Size(199, 54);
			this.UsersAddBtn.TabIndex = 22;
			this.UsersAddBtn.Text = "Add/Update";
			this.UsersAddBtn.UseVisualStyleBackColor = true;
			this.UsersAddBtn.Click += new System.EventHandler(this.UsersAddBtn_Click);
			// 
			// UsersViews
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1229, 522);
			this.Controls.Add(this.UsersAddBtn);
			this.Controls.Add(this.UsersDoneBtn);
			this.Controls.Add(this.PermissionLevel);
			this.Controls.Add(this.PermissionLevelLabel);
			this.Controls.Add(this.EmailLabel);
			this.Controls.Add(this.PasswordLabel);
			this.Controls.Add(this.UsernameLabel);
			this.Controls.Add(this.UsersCancelBtn);
			this.Controls.Add(this.UsersDeleteBtn);
			this.Controls.Add(this.Password);
			this.Controls.Add(this.Email);
			this.Controls.Add(this.Username);
			this.Controls.Add(this.UsersDataGridView);
			this.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "UsersViews";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Users";
			((System.ComponentModel.ISupportInitialize)(this.UsersDataGridView)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.greenEnviroDataDataSetBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.PermissionLevel)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView UsersDataGridView;
        private System.Windows.Forms.BindingSource greenEnviroDataDataSetBindingSource;
        private System.Windows.Forms.TextBox Username;
        private System.Windows.Forms.TextBox Email;
        private System.Windows.Forms.TextBox Password;
        private System.Windows.Forms.Button UsersDeleteBtn;
        private System.Windows.Forms.Button UsersCancelBtn;
        private System.Windows.Forms.Label UsernameLabel;
        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.Label EmailLabel;
		private System.Windows.Forms.Label PermissionLevelLabel;
		private System.Windows.Forms.NumericUpDown PermissionLevel;
		private System.Windows.Forms.Button UsersDoneBtn;
		private System.Windows.Forms.Button UsersAddBtn;
	}
}