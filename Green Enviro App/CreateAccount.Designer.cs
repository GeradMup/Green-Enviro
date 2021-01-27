
namespace Green_Enviro_App
{
    partial class CreateAccount
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateAccount));
            this.label1 = new System.Windows.Forms.Label();
            this.newUserNameField = new System.Windows.Forms.TextBox();
            this.newPasswordField = new System.Windows.Forms.TextBox();
            this.confirmPasswordField = new System.Windows.Forms.TextBox();
            this.emailAddressField = new System.Windows.Forms.TextBox();
            this.masterPasswordField = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.newAccountButton = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.userPermissionLvlBx = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sitka Heading", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(239, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(316, 47);
            this.label1.TabIndex = 0;
            this.label1.Text = "Create A New Account";
            // 
            // newUserNameField
            // 
            this.newUserNameField.Location = new System.Drawing.Point(386, 107);
            this.newUserNameField.Name = "newUserNameField";
            this.newUserNameField.Size = new System.Drawing.Size(169, 20);
            this.newUserNameField.TabIndex = 1;
            // 
            // newPasswordField
            // 
            this.newPasswordField.Location = new System.Drawing.Point(386, 137);
            this.newPasswordField.Name = "newPasswordField";
            this.newPasswordField.Size = new System.Drawing.Size(169, 20);
            this.newPasswordField.TabIndex = 2;
            // 
            // confirmPasswordField
            // 
            this.confirmPasswordField.Location = new System.Drawing.Point(386, 167);
            this.confirmPasswordField.Name = "confirmPasswordField";
            this.confirmPasswordField.Size = new System.Drawing.Size(169, 20);
            this.confirmPasswordField.TabIndex = 3;
            // 
            // emailAddressField
            // 
            this.emailAddressField.Location = new System.Drawing.Point(386, 197);
            this.emailAddressField.Name = "emailAddressField";
            this.emailAddressField.Size = new System.Drawing.Size(169, 20);
            this.emailAddressField.TabIndex = 4;
            // 
            // masterPasswordField
            // 
            this.masterPasswordField.Location = new System.Drawing.Point(386, 257);
            this.masterPasswordField.Name = "masterPasswordField";
            this.masterPasswordField.Size = new System.Drawing.Size(169, 20);
            this.masterPasswordField.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(247, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "User Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(247, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Password";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(247, 170);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Confirm Password";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(247, 200);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Email Address";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(247, 260);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Master Password";
            // 
            // newAccountButton
            // 
            this.newAccountButton.Location = new System.Drawing.Point(452, 325);
            this.newAccountButton.Name = "newAccountButton";
            this.newAccountButton.Size = new System.Drawing.Size(168, 36);
            this.newAccountButton.TabIndex = 11;
            this.newAccountButton.Text = "Register Account";
            this.newAccountButton.UseVisualStyleBackColor = true;
            this.newAccountButton.Click += new System.EventHandler(this.newAccountButton_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.Location = new System.Drawing.Point(646, 325);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(168, 36);
            this.cancelBtn.TabIndex = 12;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(247, 230);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Permission Level";
            // 
            // userPermissionLvlBx
            // 
            this.userPermissionLvlBx.FormattingEnabled = true;
            this.userPermissionLvlBx.Location = new System.Drawing.Point(386, 227);
            this.userPermissionLvlBx.Name = "userPermissionLvlBx";
            this.userPermissionLvlBx.Size = new System.Drawing.Size(169, 21);
            this.userPermissionLvlBx.TabIndex = 14;
            this.userPermissionLvlBx.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // CreateAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(839, 410);
            this.Controls.Add(this.userPermissionLvlBx);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.newAccountButton);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.masterPasswordField);
            this.Controls.Add(this.emailAddressField);
            this.Controls.Add(this.confirmPasswordField);
            this.Controls.Add(this.newPasswordField);
            this.Controls.Add(this.newUserNameField);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CreateAccount";
            this.Text = "Green Enviro SA Recycling";
            this.Load += new System.EventHandler(this.CreateAccount_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox newUserNameField;
        private System.Windows.Forms.TextBox newPasswordField;
        private System.Windows.Forms.TextBox confirmPasswordField;
        private System.Windows.Forms.TextBox emailAddressField;
        private System.Windows.Forms.TextBox masterPasswordField;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button newAccountButton;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox userPermissionLvlBx;
    }
}