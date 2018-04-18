namespace WindowsFormsApp1
{
    partial class UbahPassword
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
            this.UbahPasswordOkButton = new System.Windows.Forms.Button();
            this.ChangePasswordNewTextBox = new System.Windows.Forms.TextBox();
            this.UbahPasswordCancelButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ChangePasswordOldTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // UbahPasswordOkButton
            // 
            this.UbahPasswordOkButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.UbahPasswordOkButton.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UbahPasswordOkButton.Location = new System.Drawing.Point(70, 118);
            this.UbahPasswordOkButton.Name = "UbahPasswordOkButton";
            this.UbahPasswordOkButton.Size = new System.Drawing.Size(75, 36);
            this.UbahPasswordOkButton.TabIndex = 3;
            this.UbahPasswordOkButton.Text = "Ok";
            this.UbahPasswordOkButton.UseVisualStyleBackColor = true;
            this.UbahPasswordOkButton.Click += new System.EventHandler(this.UbahPasswordOkButton_Click);
            // 
            // ChangePasswordNewTextBox
            // 
            this.ChangePasswordNewTextBox.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChangePasswordNewTextBox.Location = new System.Drawing.Point(173, 67);
            this.ChangePasswordNewTextBox.Name = "ChangePasswordNewTextBox";
            this.ChangePasswordNewTextBox.PasswordChar = '*';
            this.ChangePasswordNewTextBox.Size = new System.Drawing.Size(157, 29);
            this.ChangePasswordNewTextBox.TabIndex = 2;
            // 
            // UbahPasswordCancelButton
            // 
            this.UbahPasswordCancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.UbahPasswordCancelButton.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UbahPasswordCancelButton.Location = new System.Drawing.Point(173, 118);
            this.UbahPasswordCancelButton.Name = "UbahPasswordCancelButton";
            this.UbahPasswordCancelButton.Size = new System.Drawing.Size(75, 36);
            this.UbahPasswordCancelButton.TabIndex = 4;
            this.UbahPasswordCancelButton.Text = "Cancel";
            this.UbahPasswordCancelButton.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 21);
            this.label1.TabIndex = 4;
            this.label1.Text = "Password Baru : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(29, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 21);
            this.label2.TabIndex = 5;
            this.label2.Text = "Password Lama : ";
            // 
            // ChangePasswordOldTextBox
            // 
            this.ChangePasswordOldTextBox.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChangePasswordOldTextBox.Location = new System.Drawing.Point(173, 35);
            this.ChangePasswordOldTextBox.Name = "ChangePasswordOldTextBox";
            this.ChangePasswordOldTextBox.PasswordChar = '*';
            this.ChangePasswordOldTextBox.Size = new System.Drawing.Size(157, 29);
            this.ChangePasswordOldTextBox.TabIndex = 1;
            // 
            // UbahPassword
            // 
            this.AcceptButton = this.UbahPasswordOkButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.CancelButton = this.UbahPasswordCancelButton;
            this.ClientSize = new System.Drawing.Size(342, 166);
            this.ControlBox = false;
            this.Controls.Add(this.ChangePasswordOldTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.UbahPasswordCancelButton);
            this.Controls.Add(this.ChangePasswordNewTextBox);
            this.Controls.Add(this.UbahPasswordOkButton);
            this.Name = "UbahPassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Ubah Password";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button UbahPasswordOkButton;
        private System.Windows.Forms.Button UbahPasswordCancelButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        internal System.Windows.Forms.TextBox ChangePasswordNewTextBox;
        internal System.Windows.Forms.TextBox ChangePasswordOldTextBox;
    }
}