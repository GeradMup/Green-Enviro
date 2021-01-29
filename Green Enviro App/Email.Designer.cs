
namespace Green_Enviro_App
{
    partial class Email
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Email));
            this.emailBodyField = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.emailAddressFromField = new System.Windows.Forms.TextBox();
            this.emailAddressToField = new System.Windows.Forms.TextBox();
            this.emailAddressSubjectField = new System.Windows.Forms.TextBox();
            this.emailAddressUsernameField = new System.Windows.Forms.TextBox();
            this.emailAddressPasswordField = new System.Windows.Forms.TextBox();
            this.emailAddressPDFAttachmentField = new System.Windows.Forms.TextBox();
            this.SendEmail = new System.Windows.Forms.Button();
            this.emailAddressSMTPServerList = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // emailBodyField
            // 
            this.emailBodyField.Location = new System.Drawing.Point(12, 12);
            this.emailBodyField.Name = "emailBodyField";
            this.emailBodyField.Size = new System.Drawing.Size(312, 346);
            this.emailBodyField.TabIndex = 0;
            this.emailBodyField.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(363, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "From";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(363, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "To";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(363, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Subject";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(363, 162);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Smtp Server";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(363, 202);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Username";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(363, 242);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Password";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(363, 282);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Attachment";
            // 
            // emailAddressFromField
            // 
            this.emailAddressFromField.Location = new System.Drawing.Point(485, 42);
            this.emailAddressFromField.Name = "emailAddressFromField";
            this.emailAddressFromField.Size = new System.Drawing.Size(201, 20);
            this.emailAddressFromField.TabIndex = 8;
            // 
            // emailAddressToField
            // 
            this.emailAddressToField.Location = new System.Drawing.Point(485, 82);
            this.emailAddressToField.Name = "emailAddressToField";
            this.emailAddressToField.Size = new System.Drawing.Size(201, 20);
            this.emailAddressToField.TabIndex = 9;
            // 
            // emailAddressSubjectField
            // 
            this.emailAddressSubjectField.Location = new System.Drawing.Point(485, 122);
            this.emailAddressSubjectField.Name = "emailAddressSubjectField";
            this.emailAddressSubjectField.Size = new System.Drawing.Size(201, 20);
            this.emailAddressSubjectField.TabIndex = 10;
            // 
            // emailAddressUsernameField
            // 
            this.emailAddressUsernameField.Location = new System.Drawing.Point(485, 199);
            this.emailAddressUsernameField.Name = "emailAddressUsernameField";
            this.emailAddressUsernameField.Size = new System.Drawing.Size(201, 20);
            this.emailAddressUsernameField.TabIndex = 12;
            this.emailAddressUsernameField.TextChanged += new System.EventHandler(this.emailAddressUsernameField_TextChanged);
            // 
            // emailAddressPasswordField
            // 
            this.emailAddressPasswordField.Location = new System.Drawing.Point(485, 242);
            this.emailAddressPasswordField.Name = "emailAddressPasswordField";
            this.emailAddressPasswordField.Size = new System.Drawing.Size(201, 20);
            this.emailAddressPasswordField.TabIndex = 13;
            // 
            // emailAddressPDFAttachmentField
            // 
            this.emailAddressPDFAttachmentField.Location = new System.Drawing.Point(485, 279);
            this.emailAddressPDFAttachmentField.Name = "emailAddressPDFAttachmentField";
            this.emailAddressPDFAttachmentField.Size = new System.Drawing.Size(201, 20);
            this.emailAddressPDFAttachmentField.TabIndex = 14;
            // 
            // SendEmail
            // 
            this.SendEmail.Location = new System.Drawing.Point(366, 324);
            this.SendEmail.Name = "SendEmail";
            this.SendEmail.Size = new System.Drawing.Size(112, 34);
            this.SendEmail.TabIndex = 15;
            this.SendEmail.Text = "Send";
            this.SendEmail.UseVisualStyleBackColor = true;
            this.SendEmail.Click += new System.EventHandler(this.button1_Click);
            // 
            // emailAddressSMTPServerList
            // 
            this.emailAddressSMTPServerList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.emailAddressSMTPServerList.FormattingEnabled = true;
            this.emailAddressSMTPServerList.Location = new System.Drawing.Point(485, 162);
            this.emailAddressSMTPServerList.Name = "emailAddressSMTPServerList";
            this.emailAddressSMTPServerList.Size = new System.Drawing.Size(201, 21);
            this.emailAddressSMTPServerList.TabIndex = 16;
            this.emailAddressSMTPServerList.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // Email
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(754, 370);
            this.Controls.Add(this.emailAddressSMTPServerList);
            this.Controls.Add(this.SendEmail);
            this.Controls.Add(this.emailAddressPDFAttachmentField);
            this.Controls.Add(this.emailAddressPasswordField);
            this.Controls.Add(this.emailAddressUsernameField);
            this.Controls.Add(this.emailAddressSubjectField);
            this.Controls.Add(this.emailAddressToField);
            this.Controls.Add(this.emailAddressFromField);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.emailBodyField);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Email";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Email";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox emailBodyField;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox emailAddressFromField;
        private System.Windows.Forms.TextBox emailAddressToField;
        private System.Windows.Forms.TextBox emailAddressSubjectField;
        private System.Windows.Forms.TextBox emailAddressUsernameField;
        private System.Windows.Forms.TextBox emailAddressPasswordField;
        private System.Windows.Forms.TextBox emailAddressPDFAttachmentField;
        private System.Windows.Forms.Button SendEmail;
        private System.Windows.Forms.ComboBox emailAddressSMTPServerList;
    }
}