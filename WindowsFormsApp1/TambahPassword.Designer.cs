namespace WindowsFormsApp1
{
    partial class TambahPassword
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
            this.TambahPasswordNewUserGroupBox = new System.Windows.Forms.GroupBox();
            this.TambahPasswordRoleComboBox = new System.Windows.Forms.ComboBox();
            this.TambahPasswordNewPassTextBox = new System.Windows.Forms.TextBox();
            this.TambahPasswordRoleLabel = new System.Windows.Forms.Label();
            this.TambahPasswordNewPassLabel = new System.Windows.Forms.Label();
            this.TambahPasswordRoleDetailsGroupBox = new System.Windows.Forms.GroupBox();
            this.TambahPasswordRoleDetailsLabel3 = new System.Windows.Forms.Label();
            this.TambahPasswordRoleDetailsLabel2 = new System.Windows.Forms.Label();
            this.TambahPasswordRoleDetailsLabel1 = new System.Windows.Forms.Label();
            this.TambahPasswordOkButton = new System.Windows.Forms.Button();
            this.TambahPasswordCancelButton = new System.Windows.Forms.Button();
            this.TambahPasswordRoleDetailsLabel4 = new System.Windows.Forms.Label();
            this.TambahPasswordNewUserGroupBox.SuspendLayout();
            this.TambahPasswordRoleDetailsGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // TambahPasswordNewUserGroupBox
            // 
            this.TambahPasswordNewUserGroupBox.Controls.Add(this.TambahPasswordRoleComboBox);
            this.TambahPasswordNewUserGroupBox.Controls.Add(this.TambahPasswordNewPassTextBox);
            this.TambahPasswordNewUserGroupBox.Controls.Add(this.TambahPasswordRoleLabel);
            this.TambahPasswordNewUserGroupBox.Controls.Add(this.TambahPasswordNewPassLabel);
            this.TambahPasswordNewUserGroupBox.Location = new System.Drawing.Point(12, 12);
            this.TambahPasswordNewUserGroupBox.Name = "TambahPasswordNewUserGroupBox";
            this.TambahPasswordNewUserGroupBox.Size = new System.Drawing.Size(255, 117);
            this.TambahPasswordNewUserGroupBox.TabIndex = 0;
            this.TambahPasswordNewUserGroupBox.TabStop = false;
            this.TambahPasswordNewUserGroupBox.Text = "New User";
            // 
            // TambahPasswordRoleComboBox
            // 
            this.TambahPasswordRoleComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TambahPasswordRoleComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.TambahPasswordRoleComboBox.FormattingEnabled = true;
            this.TambahPasswordRoleComboBox.Location = new System.Drawing.Point(99, 70);
            this.TambahPasswordRoleComboBox.Name = "TambahPasswordRoleComboBox";
            this.TambahPasswordRoleComboBox.Size = new System.Drawing.Size(148, 29);
            this.TambahPasswordRoleComboBox.TabIndex = 2;
            this.TambahPasswordRoleComboBox.SelectedIndexChanged += new System.EventHandler(this.TambahPasswordRoleComboBox_SelectedIndexChanged);
            // 
            // TambahPasswordNewPassTextBox
            // 
            this.TambahPasswordNewPassTextBox.Location = new System.Drawing.Point(99, 31);
            this.TambahPasswordNewPassTextBox.Name = "TambahPasswordNewPassTextBox";
            this.TambahPasswordNewPassTextBox.PasswordChar = '*';
            this.TambahPasswordNewPassTextBox.Size = new System.Drawing.Size(148, 29);
            this.TambahPasswordNewPassTextBox.TabIndex = 1;
            // 
            // TambahPasswordRoleLabel
            // 
            this.TambahPasswordRoleLabel.AutoSize = true;
            this.TambahPasswordRoleLabel.Location = new System.Drawing.Point(46, 73);
            this.TambahPasswordRoleLabel.Name = "TambahPasswordRoleLabel";
            this.TambahPasswordRoleLabel.Size = new System.Drawing.Size(59, 21);
            this.TambahPasswordRoleLabel.TabIndex = 1;
            this.TambahPasswordRoleLabel.Text = "Role : ";
            // 
            // TambahPasswordNewPassLabel
            // 
            this.TambahPasswordNewPassLabel.AutoSize = true;
            this.TambahPasswordNewPassLabel.Location = new System.Drawing.Point(6, 34);
            this.TambahPasswordNewPassLabel.Name = "TambahPasswordNewPassLabel";
            this.TambahPasswordNewPassLabel.Size = new System.Drawing.Size(98, 21);
            this.TambahPasswordNewPassLabel.TabIndex = 0;
            this.TambahPasswordNewPassLabel.Text = "Password : ";
            // 
            // TambahPasswordRoleDetailsGroupBox
            // 
            this.TambahPasswordRoleDetailsGroupBox.Controls.Add(this.TambahPasswordRoleDetailsLabel4);
            this.TambahPasswordRoleDetailsGroupBox.Controls.Add(this.TambahPasswordRoleDetailsLabel3);
            this.TambahPasswordRoleDetailsGroupBox.Controls.Add(this.TambahPasswordRoleDetailsLabel2);
            this.TambahPasswordRoleDetailsGroupBox.Controls.Add(this.TambahPasswordRoleDetailsLabel1);
            this.TambahPasswordRoleDetailsGroupBox.Location = new System.Drawing.Point(279, 11);
            this.TambahPasswordRoleDetailsGroupBox.Name = "TambahPasswordRoleDetailsGroupBox";
            this.TambahPasswordRoleDetailsGroupBox.Size = new System.Drawing.Size(182, 179);
            this.TambahPasswordRoleDetailsGroupBox.TabIndex = 4;
            this.TambahPasswordRoleDetailsGroupBox.TabStop = false;
            this.TambahPasswordRoleDetailsGroupBox.Text = "Role Details";
            // 
            // TambahPasswordRoleDetailsLabel3
            // 
            this.TambahPasswordRoleDetailsLabel3.AutoSize = true;
            this.TambahPasswordRoleDetailsLabel3.Location = new System.Drawing.Point(15, 79);
            this.TambahPasswordRoleDetailsLabel3.Name = "TambahPasswordRoleDetailsLabel3";
            this.TambahPasswordRoleDetailsLabel3.Size = new System.Drawing.Size(36, 21);
            this.TambahPasswordRoleDetailsLabel3.TabIndex = 2;
            // 
            // TambahPasswordRoleDetailsLabel2
            // 
            this.TambahPasswordRoleDetailsLabel2.AutoSize = true;
            this.TambahPasswordRoleDetailsLabel2.Location = new System.Drawing.Point(15, 52);
            this.TambahPasswordRoleDetailsLabel2.Name = "TambahPasswordRoleDetailsLabel2";
            this.TambahPasswordRoleDetailsLabel2.Size = new System.Drawing.Size(36, 21);
            this.TambahPasswordRoleDetailsLabel2.TabIndex = 1;
            // 
            // TambahPasswordRoleDetailsLabel1
            // 
            this.TambahPasswordRoleDetailsLabel1.AutoSize = true;
            this.TambahPasswordRoleDetailsLabel1.Location = new System.Drawing.Point(15, 25);
            this.TambahPasswordRoleDetailsLabel1.Name = "TambahPasswordRoleDetailsLabel1";
            this.TambahPasswordRoleDetailsLabel1.Size = new System.Drawing.Size(36, 21);
            this.TambahPasswordRoleDetailsLabel1.TabIndex = 0;
            // 
            // TambahPasswordOkButton
            // 
            this.TambahPasswordOkButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.TambahPasswordOkButton.Location = new System.Drawing.Point(41, 154);
            this.TambahPasswordOkButton.Name = "TambahPasswordOkButton";
            this.TambahPasswordOkButton.Size = new System.Drawing.Size(75, 36);
            this.TambahPasswordOkButton.TabIndex = 3;
            this.TambahPasswordOkButton.Text = "Ok";
            this.TambahPasswordOkButton.UseVisualStyleBackColor = true;
            // 
            // TambahPasswordCancelButton
            // 
            this.TambahPasswordCancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.TambahPasswordCancelButton.Location = new System.Drawing.Point(148, 154);
            this.TambahPasswordCancelButton.Name = "TambahPasswordCancelButton";
            this.TambahPasswordCancelButton.Size = new System.Drawing.Size(75, 36);
            this.TambahPasswordCancelButton.TabIndex = 4;
            this.TambahPasswordCancelButton.Text = "Cancel";
            this.TambahPasswordCancelButton.UseVisualStyleBackColor = true;
            // 
            // TambahPasswordRoleDetailsLabel4
            // 
            this.TambahPasswordRoleDetailsLabel4.AutoSize = true;
            this.TambahPasswordRoleDetailsLabel4.Location = new System.Drawing.Point(15, 106);
            this.TambahPasswordRoleDetailsLabel4.Name = "TambahPasswordRoleDetailsLabel4";
            this.TambahPasswordRoleDetailsLabel4.Size = new System.Drawing.Size(36, 21);
            this.TambahPasswordRoleDetailsLabel4.TabIndex = 3;
            // 
            // TambahPassword
            // 
            this.AcceptButton = this.TambahPasswordOkButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.TambahPasswordCancelButton;
            this.ClientSize = new System.Drawing.Size(474, 204);
            this.ControlBox = false;
            this.Controls.Add(this.TambahPasswordCancelButton);
            this.Controls.Add(this.TambahPasswordOkButton);
            this.Controls.Add(this.TambahPasswordRoleDetailsGroupBox);
            this.Controls.Add(this.TambahPasswordNewUserGroupBox);
            this.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "TambahPassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "TambahPassword";
            this.Load += new System.EventHandler(this.TambahPassword_Load);
            this.TambahPasswordNewUserGroupBox.ResumeLayout(false);
            this.TambahPasswordNewUserGroupBox.PerformLayout();
            this.TambahPasswordRoleDetailsGroupBox.ResumeLayout(false);
            this.TambahPasswordRoleDetailsGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox TambahPasswordNewUserGroupBox;
        private System.Windows.Forms.ComboBox TambahPasswordRoleComboBox;
        private System.Windows.Forms.TextBox TambahPasswordNewPassTextBox;
        private System.Windows.Forms.Label TambahPasswordRoleLabel;
        private System.Windows.Forms.Label TambahPasswordNewPassLabel;
        private System.Windows.Forms.GroupBox TambahPasswordRoleDetailsGroupBox;
        private System.Windows.Forms.Button TambahPasswordOkButton;
        private System.Windows.Forms.Button TambahPasswordCancelButton;
        private System.Windows.Forms.Label TambahPasswordRoleDetailsLabel1;
        private System.Windows.Forms.Label TambahPasswordRoleDetailsLabel3;
        private System.Windows.Forms.Label TambahPasswordRoleDetailsLabel2;
        private System.Windows.Forms.Label TambahPasswordRoleDetailsLabel4;
    }
}