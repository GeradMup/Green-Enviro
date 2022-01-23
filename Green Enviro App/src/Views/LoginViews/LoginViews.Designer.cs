
namespace Green_Enviro_App
{
    partial class LoginViews
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginViews));
			this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.LoginBtn = new System.Windows.Forms.Button();
			this.Username = new System.Windows.Forms.TextBox();
			this.UserNameLabel = new System.Windows.Forms.Label();
			this.PasswordLabel = new System.Windows.Forms.Label();
			this.Password = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.ClearBtn = new System.Windows.Forms.Button();
			this.CreateAccountButton = new System.Windows.Forms.Button();
			this.ShowPassword = new System.Windows.Forms.CheckBox();
			this.Users = new System.Windows.Forms.LinkLabel();
			this.SuspendLayout();
			// 
			// contextMenuStrip1
			// 
			this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.contextMenuStrip1.Name = "contextMenuStrip1";
			this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
			// 
			// LoginBtn
			// 
			this.LoginBtn.Location = new System.Drawing.Point(92, 361);
			this.LoginBtn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.LoginBtn.Name = "LoginBtn";
			this.LoginBtn.Size = new System.Drawing.Size(157, 53);
			this.LoginBtn.TabIndex = 2;
			this.LoginBtn.Text = "Login";
			this.LoginBtn.UseVisualStyleBackColor = true;
			this.LoginBtn.Click += new System.EventHandler(this.LoginBtn_Click);
			// 
			// Username
			// 
			this.Username.Location = new System.Drawing.Point(243, 203);
			this.Username.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.Username.Name = "Username";
			this.Username.Size = new System.Drawing.Size(286, 26);
			this.Username.TabIndex = 3;
			this.Username.Text = "GerryMup";
			// 
			// UserNameLabel
			// 
			this.UserNameLabel.AutoSize = true;
			this.UserNameLabel.Location = new System.Drawing.Point(88, 209);
			this.UserNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.UserNameLabel.Name = "UserNameLabel";
			this.UserNameLabel.Size = new System.Drawing.Size(90, 19);
			this.UserNameLabel.TabIndex = 4;
			this.UserNameLabel.Text = "User Name";
			// 
			// PasswordLabel
			// 
			this.PasswordLabel.AutoSize = true;
			this.PasswordLabel.Location = new System.Drawing.Point(88, 282);
			this.PasswordLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.PasswordLabel.Name = "PasswordLabel";
			this.PasswordLabel.Size = new System.Drawing.Size(81, 19);
			this.PasswordLabel.TabIndex = 5;
			this.PasswordLabel.Text = "Password";
			// 
			// Password
			// 
			this.Password.Location = new System.Drawing.Point(243, 282);
			this.Password.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.Password.Multiline = true;
			this.Password.Name = "Password";
			this.Password.PasswordChar = '*';
			this.Password.Size = new System.Drawing.Size(284, 32);
			this.Password.TabIndex = 6;
			this.Password.Text = "Master";
			this.Password.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Password_KeyPress);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Consolas", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.Color.Green;
			this.label3.Location = new System.Drawing.Point(82, 35);
			this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(674, 56);
			this.label3.TabIndex = 7;
			this.label3.Text = "Green Enviro SA Recycling";
			// 
			// ClearBtn
			// 
			this.ClearBtn.Location = new System.Drawing.Point(586, 361);
			this.ClearBtn.Margin = new System.Windows.Forms.Padding(6);
			this.ClearBtn.Name = "ClearBtn";
			this.ClearBtn.Size = new System.Drawing.Size(131, 53);
			this.ClearBtn.TabIndex = 8;
			this.ClearBtn.Text = "Clear";
			this.ClearBtn.UseVisualStyleBackColor = true;
			this.ClearBtn.Click += new System.EventHandler(this.clear_button_Click);
			// 
			// CreateAccountButton
			// 
			this.CreateAccountButton.Location = new System.Drawing.Point(306, 361);
			this.CreateAccountButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.CreateAccountButton.Name = "CreateAccountButton";
			this.CreateAccountButton.Size = new System.Drawing.Size(223, 53);
			this.CreateAccountButton.TabIndex = 9;
			this.CreateAccountButton.Text = "Create Account";
			this.CreateAccountButton.UseVisualStyleBackColor = true;
			// 
			// ShowPassword
			// 
			this.ShowPassword.AutoSize = true;
			this.ShowPassword.Location = new System.Drawing.Point(629, 281);
			this.ShowPassword.Margin = new System.Windows.Forms.Padding(6);
			this.ShowPassword.Name = "ShowPassword";
			this.ShowPassword.Size = new System.Drawing.Size(64, 23);
			this.ShowPassword.TabIndex = 10;
			this.ShowPassword.Text = "Show";
			this.ShowPassword.UseVisualStyleBackColor = true;
			this.ShowPassword.CheckedChanged += new System.EventHandler(this.checkBox_Show_Hide_CheckedChanged);
			// 
			// Users
			// 
			this.Users.AutoSize = true;
			this.Users.Location = new System.Drawing.Point(759, 282);
			this.Users.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
			this.Users.Name = "Users";
			this.Users.Size = new System.Drawing.Size(54, 19);
			this.Users.TabIndex = 11;
			this.Users.TabStop = true;
			this.Users.Text = "Users";
			// 
			// LoginViews
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(983, 458);
			this.Controls.Add(this.Users);
			this.Controls.Add(this.ShowPassword);
			this.Controls.Add(this.CreateAccountButton);
			this.Controls.Add(this.ClearBtn);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.Password);
			this.Controls.Add(this.PasswordLabel);
			this.Controls.Add(this.UserNameLabel);
			this.Controls.Add(this.Username);
			this.Controls.Add(this.LoginBtn);
			this.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.Name = "LoginViews";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Green Enviro SA Recycling";
			this.Activated += new System.EventHandler(this.LoginForm_Activated);
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.LoginForm_FormClosing);
			this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.LoginForm_KeyPress);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button LoginBtn;
        private System.Windows.Forms.TextBox Username;
        private System.Windows.Forms.Label UserNameLabel;
        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.TextBox Password;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button ClearBtn;
        private System.Windows.Forms.Button CreateAccountButton;
        private System.Windows.Forms.CheckBox ShowPassword;
        private System.Windows.Forms.LinkLabel Users;
    }
}

