
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
			this.ConfirmPassword = new System.Windows.Forms.TextBox();
			this.ConfirmPasswordLabel = new System.Windows.Forms.Label();
			this.ChangePasswordBtn = new System.Windows.Forms.Button();
			this.ChangePasswordGroup = new System.Windows.Forms.GroupBox();
			this.EditPasswordCancelBtn = new System.Windows.Forms.Button();
			this.EditPasswordDoneBtn = new System.Windows.Forms.Button();
			this.ChangePasswordUsername = new System.Windows.Forms.Label();
			this.ConfirmNewPasswordLabel = new System.Windows.Forms.Label();
			this.NewPasswordConfirm = new System.Windows.Forms.TextBox();
			this.NewPasswordLabel = new System.Windows.Forms.Label();
			this.OldPasswordLabel = new System.Windows.Forms.Label();
			this.NewPassword = new System.Windows.Forms.TextBox();
			this.OldPassword = new System.Windows.Forms.TextBox();
			((System.ComponentModel.ISupportInitialize)(this.UsersDataGridView)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.greenEnviroDataDataSetBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.PermissionLevel)).BeginInit();
			this.ChangePasswordGroup.SuspendLayout();
			this.SuspendLayout();
			// 
			// UsersDataGridView
			// 
			this.UsersDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.UsersDataGridView.BackgroundColor = System.Drawing.SystemColors.ControlLight;
			this.UsersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.UsersDataGridView.Location = new System.Drawing.Point(518, 27);
			this.UsersDataGridView.Margin = new System.Windows.Forms.Padding(4);
			this.UsersDataGridView.Name = "UsersDataGridView";
			this.UsersDataGridView.ReadOnly = true;
			this.UsersDataGridView.RowHeadersWidth = 51;
			this.UsersDataGridView.Size = new System.Drawing.Size(698, 482);
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
			this.Email.Location = new System.Drawing.Point(190, 184);
			this.Email.Margin = new System.Windows.Forms.Padding(4);
			this.Email.Name = "Email";
			this.Email.Size = new System.Drawing.Size(285, 25);
			this.Email.TabIndex = 12;
			// 
			// Password
			// 
			this.Password.Location = new System.Drawing.Point(190, 77);
			this.Password.Margin = new System.Windows.Forms.Padding(4);
			this.Password.Name = "Password";
			this.Password.PasswordChar = '*';
			this.Password.Size = new System.Drawing.Size(285, 25);
			this.Password.TabIndex = 10;
			// 
			// UsersDeleteBtn
			// 
			this.UsersDeleteBtn.Location = new System.Drawing.Point(35, 356);
			this.UsersDeleteBtn.Margin = new System.Windows.Forms.Padding(4);
			this.UsersDeleteBtn.Name = "UsersDeleteBtn";
			this.UsersDeleteBtn.Size = new System.Drawing.Size(199, 54);
			this.UsersDeleteBtn.TabIndex = 12;
			this.UsersDeleteBtn.Text = "Delete";
			this.UsersDeleteBtn.UseVisualStyleBackColor = true;
			this.UsersDeleteBtn.Click += new System.EventHandler(this.UsersDeleteBtn_Click);
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
			this.UsersCancelBtn.Click += new System.EventHandler(this.UsersCancelBtn_Click);
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
			this.EmailLabel.Location = new System.Drawing.Point(32, 187);
			this.EmailLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.EmailLabel.Name = "EmailLabel";
			this.EmailLabel.Size = new System.Drawing.Size(48, 18);
			this.EmailLabel.TabIndex = 18;
			this.EmailLabel.Text = "Email";
			// 
			// PermissionLevelLabel
			// 
			this.PermissionLevelLabel.AutoSize = true;
			this.PermissionLevelLabel.Location = new System.Drawing.Point(32, 231);
			this.PermissionLevelLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.PermissionLevelLabel.Name = "PermissionLevelLabel";
			this.PermissionLevelLabel.Size = new System.Drawing.Size(136, 18);
			this.PermissionLevelLabel.TabIndex = 19;
			this.PermissionLevelLabel.Text = "Permission Level";
			// 
			// PermissionLevel
			// 
			this.PermissionLevel.Location = new System.Drawing.Point(190, 229);
			this.PermissionLevel.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
			this.PermissionLevel.Name = "PermissionLevel";
			this.PermissionLevel.Size = new System.Drawing.Size(64, 25);
			this.PermissionLevel.TabIndex = 13;
			// 
			// UsersDoneBtn
			// 
			this.UsersDoneBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.UsersDoneBtn.Location = new System.Drawing.Point(35, 429);
			this.UsersDoneBtn.Margin = new System.Windows.Forms.Padding(4);
			this.UsersDoneBtn.Name = "UsersDoneBtn";
			this.UsersDoneBtn.Size = new System.Drawing.Size(199, 54);
			this.UsersDoneBtn.TabIndex = 21;
			this.UsersDoneBtn.Text = "Done";
			this.UsersDoneBtn.UseVisualStyleBackColor = false;
			this.UsersDoneBtn.Click += new System.EventHandler(this.UsersDoneBtn_Click);
			// 
			// UsersAddBtn
			// 
			this.UsersAddBtn.Location = new System.Drawing.Point(261, 356);
			this.UsersAddBtn.Margin = new System.Windows.Forms.Padding(4);
			this.UsersAddBtn.Name = "UsersAddBtn";
			this.UsersAddBtn.Size = new System.Drawing.Size(199, 54);
			this.UsersAddBtn.TabIndex = 22;
			this.UsersAddBtn.Text = "Add/Update";
			this.UsersAddBtn.UseVisualStyleBackColor = true;
			this.UsersAddBtn.Click += new System.EventHandler(this.UsersAddBtn_Click);
			// 
			// ConfirmPassword
			// 
			this.ConfirmPassword.Location = new System.Drawing.Point(190, 133);
			this.ConfirmPassword.Margin = new System.Windows.Forms.Padding(4);
			this.ConfirmPassword.Name = "ConfirmPassword";
			this.ConfirmPassword.PasswordChar = '*';
			this.ConfirmPassword.Size = new System.Drawing.Size(285, 25);
			this.ConfirmPassword.TabIndex = 11;
			// 
			// ConfirmPasswordLabel
			// 
			this.ConfirmPasswordLabel.AutoSize = true;
			this.ConfirmPasswordLabel.Location = new System.Drawing.Point(32, 136);
			this.ConfirmPasswordLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.ConfirmPasswordLabel.Name = "ConfirmPasswordLabel";
			this.ConfirmPasswordLabel.Size = new System.Drawing.Size(136, 18);
			this.ConfirmPasswordLabel.TabIndex = 24;
			this.ConfirmPasswordLabel.Text = "Confirm Password";
			// 
			// ChangePasswordBtn
			// 
			this.ChangePasswordBtn.Location = new System.Drawing.Point(35, 284);
			this.ChangePasswordBtn.Margin = new System.Windows.Forms.Padding(4);
			this.ChangePasswordBtn.Name = "ChangePasswordBtn";
			this.ChangePasswordBtn.Size = new System.Drawing.Size(199, 54);
			this.ChangePasswordBtn.TabIndex = 25;
			this.ChangePasswordBtn.Text = "Change Password";
			this.ChangePasswordBtn.UseVisualStyleBackColor = true;
			this.ChangePasswordBtn.Click += new System.EventHandler(this.ChangePasswordBtn_Click);
			// 
			// ChangePasswordGroup
			// 
			this.ChangePasswordGroup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.ChangePasswordGroup.Controls.Add(this.EditPasswordCancelBtn);
			this.ChangePasswordGroup.Controls.Add(this.EditPasswordDoneBtn);
			this.ChangePasswordGroup.Controls.Add(this.ChangePasswordUsername);
			this.ChangePasswordGroup.Controls.Add(this.ConfirmNewPasswordLabel);
			this.ChangePasswordGroup.Controls.Add(this.NewPasswordConfirm);
			this.ChangePasswordGroup.Controls.Add(this.NewPasswordLabel);
			this.ChangePasswordGroup.Controls.Add(this.OldPasswordLabel);
			this.ChangePasswordGroup.Controls.Add(this.NewPassword);
			this.ChangePasswordGroup.Controls.Add(this.OldPassword);
			this.ChangePasswordGroup.Location = new System.Drawing.Point(352, 151);
			this.ChangePasswordGroup.Name = "ChangePasswordGroup";
			this.ChangePasswordGroup.Size = new System.Drawing.Size(479, 250);
			this.ChangePasswordGroup.TabIndex = 26;
			this.ChangePasswordGroup.TabStop = false;
			this.ChangePasswordGroup.Text = "Change Password";
			// 
			// EditPasswordCancelBtn
			// 
			this.EditPasswordCancelBtn.Location = new System.Drawing.Point(205, 196);
			this.EditPasswordCancelBtn.Name = "EditPasswordCancelBtn";
			this.EditPasswordCancelBtn.Size = new System.Drawing.Size(153, 34);
			this.EditPasswordCancelBtn.TabIndex = 8;
			this.EditPasswordCancelBtn.Text = "Cancel";
			this.EditPasswordCancelBtn.UseVisualStyleBackColor = true;
			this.EditPasswordCancelBtn.Click += new System.EventHandler(this.EditPasswordCancelBtn_Click);
			// 
			// EditPasswordDoneBtn
			// 
			this.EditPasswordDoneBtn.Location = new System.Drawing.Point(21, 196);
			this.EditPasswordDoneBtn.Name = "EditPasswordDoneBtn";
			this.EditPasswordDoneBtn.Size = new System.Drawing.Size(153, 34);
			this.EditPasswordDoneBtn.TabIndex = 7;
			this.EditPasswordDoneBtn.Text = "Done";
			this.EditPasswordDoneBtn.UseVisualStyleBackColor = true;
			this.EditPasswordDoneBtn.Click += new System.EventHandler(this.EditPasswordDoneBtn_Click);
			// 
			// ChangePasswordUsername
			// 
			this.ChangePasswordUsername.AutoSize = true;
			this.ChangePasswordUsername.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ChangePasswordUsername.ForeColor = System.Drawing.Color.Green;
			this.ChangePasswordUsername.Location = new System.Drawing.Point(18, 36);
			this.ChangePasswordUsername.Name = "ChangePasswordUsername";
			this.ChangePasswordUsername.Size = new System.Drawing.Size(106, 24);
			this.ChangePasswordUsername.TabIndex = 6;
			this.ChangePasswordUsername.Text = "Username";
			// 
			// ConfirmNewPasswordLabel
			// 
			this.ConfirmNewPasswordLabel.AutoSize = true;
			this.ConfirmNewPasswordLabel.Location = new System.Drawing.Point(18, 147);
			this.ConfirmNewPasswordLabel.Name = "ConfirmNewPasswordLabel";
			this.ConfirmNewPasswordLabel.Size = new System.Drawing.Size(168, 18);
			this.ConfirmNewPasswordLabel.TabIndex = 5;
			this.ConfirmNewPasswordLabel.Text = "Confirm New Password";
			// 
			// NewPasswordConfirm
			// 
			this.NewPasswordConfirm.Location = new System.Drawing.Point(205, 144);
			this.NewPasswordConfirm.Name = "NewPasswordConfirm";
			this.NewPasswordConfirm.Size = new System.Drawing.Size(244, 25);
			this.NewPasswordConfirm.TabIndex = 4;
			// 
			// NewPasswordLabel
			// 
			this.NewPasswordLabel.AutoSize = true;
			this.NewPasswordLabel.Location = new System.Drawing.Point(18, 111);
			this.NewPasswordLabel.Name = "NewPasswordLabel";
			this.NewPasswordLabel.Size = new System.Drawing.Size(104, 18);
			this.NewPasswordLabel.TabIndex = 3;
			this.NewPasswordLabel.Text = "New Password";
			// 
			// OldPasswordLabel
			// 
			this.OldPasswordLabel.AutoSize = true;
			this.OldPasswordLabel.Location = new System.Drawing.Point(18, 76);
			this.OldPasswordLabel.Name = "OldPasswordLabel";
			this.OldPasswordLabel.Size = new System.Drawing.Size(104, 18);
			this.OldPasswordLabel.TabIndex = 2;
			this.OldPasswordLabel.Text = "Old Password";
			// 
			// NewPassword
			// 
			this.NewPassword.Location = new System.Drawing.Point(205, 108);
			this.NewPassword.Name = "NewPassword";
			this.NewPassword.Size = new System.Drawing.Size(244, 25);
			this.NewPassword.TabIndex = 1;
			// 
			// OldPassword
			// 
			this.OldPassword.Location = new System.Drawing.Point(205, 73);
			this.OldPassword.Name = "OldPassword";
			this.OldPassword.Size = new System.Drawing.Size(244, 25);
			this.OldPassword.TabIndex = 0;
			// 
			// UsersViews
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1229, 522);
			this.Controls.Add(this.ChangePasswordGroup);
			this.Controls.Add(this.ChangePasswordBtn);
			this.Controls.Add(this.ConfirmPasswordLabel);
			this.Controls.Add(this.ConfirmPassword);
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
			this.ChangePasswordGroup.ResumeLayout(false);
			this.ChangePasswordGroup.PerformLayout();
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
		private System.Windows.Forms.TextBox ConfirmPassword;
		private System.Windows.Forms.Label ConfirmPasswordLabel;
		private System.Windows.Forms.Button ChangePasswordBtn;
		private System.Windows.Forms.GroupBox ChangePasswordGroup;
		private System.Windows.Forms.Button EditPasswordCancelBtn;
		private System.Windows.Forms.Button EditPasswordDoneBtn;
		private System.Windows.Forms.Label ChangePasswordUsername;
		private System.Windows.Forms.Label ConfirmNewPasswordLabel;
		private System.Windows.Forms.TextBox NewPasswordConfirm;
		private System.Windows.Forms.Label NewPasswordLabel;
		private System.Windows.Forms.Label OldPasswordLabel;
		private System.Windows.Forms.TextBox NewPassword;
		private System.Windows.Forms.TextBox OldPassword;
	}
}