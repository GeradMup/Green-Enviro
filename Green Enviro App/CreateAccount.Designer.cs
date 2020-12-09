
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
            this.label1 = new System.Windows.Forms.Label();
            this.newUserNameField = new System.Windows.Forms.TextBox();
            this.newPasswordField = new System.Windows.Forms.TextBox();
            this.confirmPasswordField = new System.Windows.Forms.TextBox();
            this.emailAddressField = new System.Windows.Forms.TextBox();
            this.securityQuestionField = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.newAccountButton = new System.Windows.Forms.Button();
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
            this.newUserNameField.Location = new System.Drawing.Point(386, 120);
            this.newUserNameField.Name = "newUserNameField";
            this.newUserNameField.Size = new System.Drawing.Size(169, 20);
            this.newUserNameField.TabIndex = 1;
            // 
            // newPasswordField
            // 
            this.newPasswordField.Location = new System.Drawing.Point(386, 156);
            this.newPasswordField.Name = "newPasswordField";
            this.newPasswordField.Size = new System.Drawing.Size(169, 20);
            this.newPasswordField.TabIndex = 2;
            // 
            // confirmPasswordField
            // 
            this.confirmPasswordField.Location = new System.Drawing.Point(386, 192);
            this.confirmPasswordField.Name = "confirmPasswordField";
            this.confirmPasswordField.Size = new System.Drawing.Size(169, 20);
            this.confirmPasswordField.TabIndex = 3;
            // 
            // emailAddressField
            // 
            this.emailAddressField.Location = new System.Drawing.Point(386, 227);
            this.emailAddressField.Name = "emailAddressField";
            this.emailAddressField.Size = new System.Drawing.Size(169, 20);
            this.emailAddressField.TabIndex = 4;
            // 
            // securityQuestionField
            // 
            this.securityQuestionField.Location = new System.Drawing.Point(386, 262);
            this.securityQuestionField.Name = "securityQuestionField";
            this.securityQuestionField.Size = new System.Drawing.Size(169, 20);
            this.securityQuestionField.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(247, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "User Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(247, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Password";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(247, 195);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Confirm Password";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(247, 230);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Email Address";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(247, 265);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Security Question";
            // 
            // newAccountButton
            // 
            this.newAccountButton.Location = new System.Drawing.Point(567, 334);
            this.newAccountButton.Name = "newAccountButton";
            this.newAccountButton.Size = new System.Drawing.Size(168, 36);
            this.newAccountButton.TabIndex = 11;
            this.newAccountButton.Text = "Register Account";
            this.newAccountButton.UseVisualStyleBackColor = true;
            // 
            // CreateAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 410);
            this.Controls.Add(this.newAccountButton);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.securityQuestionField);
            this.Controls.Add(this.emailAddressField);
            this.Controls.Add(this.confirmPasswordField);
            this.Controls.Add(this.newPasswordField);
            this.Controls.Add(this.newUserNameField);
            this.Controls.Add(this.label1);
            this.Name = "CreateAccount";
            this.Text = "CreateAccount";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox newUserNameField;
        private System.Windows.Forms.TextBox newPasswordField;
        private System.Windows.Forms.TextBox confirmPasswordField;
        private System.Windows.Forms.TextBox emailAddressField;
        private System.Windows.Forms.TextBox securityQuestionField;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button newAccountButton;
    }
}