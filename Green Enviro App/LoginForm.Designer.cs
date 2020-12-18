
namespace Green_Enviro_App
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.loginBtn = new System.Windows.Forms.Button();
            this.usernameField = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.passwordField = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.clear_button = new System.Windows.Forms.Button();
            this.createAccountButton = new System.Windows.Forms.Button();
            this.checkBox_Show_Hide = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // loginBtn
            // 
            this.loginBtn.Location = new System.Drawing.Point(116, 316);
            this.loginBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(177, 42);
            this.loginBtn.TabIndex = 2;
            this.loginBtn.Text = "Login";
            this.loginBtn.UseVisualStyleBackColor = true;
            this.loginBtn.Click += new System.EventHandler(this.loginBtn_Click);
            // 
            // usernameField
            // 
            this.usernameField.Location = new System.Drawing.Point(198, 177);
            this.usernameField.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.usernameField.Name = "usernameField";
            this.usernameField.Size = new System.Drawing.Size(158, 20);
            this.usernameField.TabIndex = 3;
            this.usernameField.Text = "G";
            this.usernameField.TextChanged += new System.EventHandler(this.usernameField_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(113, 180);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "User Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(113, 222);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Password";
            // 
            // passwordField
            // 
            this.passwordField.Location = new System.Drawing.Point(198, 219);
            this.passwordField.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.passwordField.Multiline = true;
            this.passwordField.Name = "passwordField";
            this.passwordField.PasswordChar = '*';
            this.passwordField.Size = new System.Drawing.Size(157, 22);
            this.passwordField.TabIndex = 6;
            this.passwordField.Text = "G";
            this.passwordField.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.passwordField_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label3.Location = new System.Drawing.Point(108, 37);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(530, 46);
            this.label3.TabIndex = 7;
            this.label3.Text = "Green Enviro SA Recycling";
            // 
            // clear_button
            // 
            this.clear_button.Location = new System.Drawing.Point(506, 316);
            this.clear_button.Name = "clear_button";
            this.clear_button.Size = new System.Drawing.Size(181, 42);
            this.clear_button.TabIndex = 8;
            this.clear_button.Text = "Clear";
            this.clear_button.UseVisualStyleBackColor = true;
            this.clear_button.Click += new System.EventHandler(this.clear_button_Click);
            // 
            // createAccountButton
            // 
            this.createAccountButton.Location = new System.Drawing.Point(312, 316);
            this.createAccountButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.createAccountButton.Name = "createAccountButton";
            this.createAccountButton.Size = new System.Drawing.Size(177, 42);
            this.createAccountButton.TabIndex = 9;
            this.createAccountButton.Text = "Create Account";
            this.createAccountButton.UseVisualStyleBackColor = true;
            this.createAccountButton.Click += new System.EventHandler(this.createAccountButton_Click);
            // 
            // checkBox_Show_Hide
            // 
            this.checkBox_Show_Hide.AutoSize = true;
            this.checkBox_Show_Hide.Location = new System.Drawing.Point(409, 221);
            this.checkBox_Show_Hide.Name = "checkBox_Show_Hide";
            this.checkBox_Show_Hide.Size = new System.Drawing.Size(53, 17);
            this.checkBox_Show_Hide.TabIndex = 10;
            this.checkBox_Show_Hide.Text = "Show";
            this.checkBox_Show_Hide.UseVisualStyleBackColor = true;
            this.checkBox_Show_Hide.CheckedChanged += new System.EventHandler(this.checkBox_Show_Hide_CheckedChanged);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(779, 430);
            this.Controls.Add(this.checkBox_Show_Hide);
            this.Controls.Add(this.createAccountButton);
            this.Controls.Add(this.clear_button);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.passwordField);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.usernameField);
            this.Controls.Add(this.loginBtn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login Form";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.LoginForm_KeyPress);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button loginBtn;
        private System.Windows.Forms.TextBox usernameField;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox passwordField;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button clear_button;
        private System.Windows.Forms.Button createAccountButton;
        private System.Windows.Forms.CheckBox checkBox_Show_Hide;
    }
}

