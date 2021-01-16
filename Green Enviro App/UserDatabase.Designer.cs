
namespace Green_Enviro_App
{
    partial class UserDatabaseForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserDatabaseForm));
            this.userTableDataGridView = new System.Windows.Forms.DataGridView();
            this.green_Enviro_DataDataSet = new Green_Enviro_App.Green_Enviro_DataDataSet();
            this.greenEnviroDataDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.accountIdList = new System.Windows.Forms.ComboBox();
            this.usernameSelectedForDeletionField = new System.Windows.Forms.TextBox();
            this.emailSelectedForDeletionField = new System.Windows.Forms.TextBox();
            this.passwordSelectedForDeletionField = new System.Windows.Forms.TextBox();
            this.userDeletionBtn = new System.Windows.Forms.Button();
            this.userDeletionCancelBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.userTableDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.green_Enviro_DataDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.greenEnviroDataDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // userTableDataGridView
            // 
            this.userTableDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.userTableDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.userTableDataGridView.Location = new System.Drawing.Point(381, 43);
            this.userTableDataGridView.Name = "userTableDataGridView";
            this.userTableDataGridView.RowHeadersWidth = 51;
            this.userTableDataGridView.Size = new System.Drawing.Size(529, 302);
            this.userTableDataGridView.TabIndex = 0;
            // 
            // green_Enviro_DataDataSet
            // 
            this.green_Enviro_DataDataSet.DataSetName = "Green_Enviro_DataDataSet";
            this.green_Enviro_DataDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // greenEnviroDataDataSetBindingSource
            // 
            this.greenEnviroDataDataSetBindingSource.DataSource = this.green_Enviro_DataDataSet;
            this.greenEnviroDataDataSetBindingSource.Position = 0;
            // 
            // accountIdList
            // 
            this.accountIdList.DropDownHeight = 300;
            this.accountIdList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.accountIdList.FormattingEnabled = true;
            this.accountIdList.IntegralHeight = false;
            this.accountIdList.ItemHeight = 13;
            this.accountIdList.Location = new System.Drawing.Point(170, 43);
            this.accountIdList.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.accountIdList.Name = "accountIdList";
            this.accountIdList.Size = new System.Drawing.Size(153, 21);
            this.accountIdList.TabIndex = 8;
            this.accountIdList.SelectedIndexChanged += new System.EventHandler(this.accountIdList_SelectedIndexChanged);
            // 
            // usernameSelectedForDeletionField
            // 
            this.usernameSelectedForDeletionField.Location = new System.Drawing.Point(170, 93);
            this.usernameSelectedForDeletionField.Name = "usernameSelectedForDeletionField";
            this.usernameSelectedForDeletionField.ReadOnly = true;
            this.usernameSelectedForDeletionField.Size = new System.Drawing.Size(153, 20);
            this.usernameSelectedForDeletionField.TabIndex = 9;
            // 
            // emailSelectedForDeletionField
            // 
            this.emailSelectedForDeletionField.Location = new System.Drawing.Point(170, 183);
            this.emailSelectedForDeletionField.Name = "emailSelectedForDeletionField";
            this.emailSelectedForDeletionField.ReadOnly = true;
            this.emailSelectedForDeletionField.Size = new System.Drawing.Size(153, 20);
            this.emailSelectedForDeletionField.TabIndex = 10;
            // 
            // passwordSelectedForDeletionField
            // 
            this.passwordSelectedForDeletionField.Location = new System.Drawing.Point(170, 138);
            this.passwordSelectedForDeletionField.Name = "passwordSelectedForDeletionField";
            this.passwordSelectedForDeletionField.ReadOnly = true;
            this.passwordSelectedForDeletionField.Size = new System.Drawing.Size(153, 20);
            this.passwordSelectedForDeletionField.TabIndex = 11;
            // 
            // userDeletionBtn
            // 
            this.userDeletionBtn.Location = new System.Drawing.Point(26, 275);
            this.userDeletionBtn.Name = "userDeletionBtn";
            this.userDeletionBtn.Size = new System.Drawing.Size(149, 39);
            this.userDeletionBtn.TabIndex = 12;
            this.userDeletionBtn.Text = "Delete";
            this.userDeletionBtn.UseVisualStyleBackColor = true;
            this.userDeletionBtn.Click += new System.EventHandler(this.userDeletionBtn_Click);
            // 
            // userDeletionCancelBtn
            // 
            this.userDeletionCancelBtn.Location = new System.Drawing.Point(194, 275);
            this.userDeletionCancelBtn.Name = "userDeletionCancelBtn";
            this.userDeletionCancelBtn.Size = new System.Drawing.Size(149, 39);
            this.userDeletionCancelBtn.TabIndex = 14;
            this.userDeletionCancelBtn.Text = "Cancel";
            this.userDeletionCancelBtn.UseVisualStyleBackColor = true;
            this.userDeletionCancelBtn.Click += new System.EventHandler(this.userDeletionCancelBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "AccountID Number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(92, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Username";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(92, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Password";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(113, 186);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Email";
            // 
            // UserDatabaseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(922, 377);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.userDeletionCancelBtn);
            this.Controls.Add(this.userDeletionBtn);
            this.Controls.Add(this.passwordSelectedForDeletionField);
            this.Controls.Add(this.emailSelectedForDeletionField);
            this.Controls.Add(this.usernameSelectedForDeletionField);
            this.Controls.Add(this.accountIdList);
            this.Controls.Add(this.userTableDataGridView);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "UserDatabaseForm";
            this.Text = "User Database";
            this.Load += new System.EventHandler(this.UserAccountsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.userTableDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.green_Enviro_DataDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.greenEnviroDataDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView userTableDataGridView;
        private System.Windows.Forms.BindingSource greenEnviroDataDataSetBindingSource;
        private Green_Enviro_DataDataSet green_Enviro_DataDataSet;
        public System.Windows.Forms.ComboBox accountIdList;
        private System.Windows.Forms.TextBox usernameSelectedForDeletionField;
        private System.Windows.Forms.TextBox emailSelectedForDeletionField;
        private System.Windows.Forms.TextBox passwordSelectedForDeletionField;
        private System.Windows.Forms.Button userDeletionBtn;
        private System.Windows.Forms.Button userDeletionCancelBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}