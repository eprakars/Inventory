namespace WindowsFormsApp1
{
    partial class Login
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
            this.Password = new System.Windows.Forms.Label();
            this.passwordTextbox = new System.Windows.Forms.TextBox();
            this.LoginOkButton = new System.Windows.Forms.Button();
            this.LoginCancelButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // Password
            // 
            this.Password.AutoEllipsis = true;
            this.Password.AutoSize = true;
            this.Password.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Password.Location = new System.Drawing.Point(43, 67);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(76, 19);
            this.Password.TabIndex = 1;
            this.Password.Text = "Password :";
            // 
            // passwordTextbox
            // 
            this.passwordTextbox.Location = new System.Drawing.Point(125, 66);
            this.passwordTextbox.Name = "passwordTextbox";
            this.passwordTextbox.Size = new System.Drawing.Size(100, 20);
            this.passwordTextbox.TabIndex = 1;
            this.passwordTextbox.UseSystemPasswordChar = true;
            // 
            // LoginOkButton
            // 
            this.LoginOkButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.LoginOkButton.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginOkButton.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.LoginOkButton.Location = new System.Drawing.Point(60, 136);
            this.LoginOkButton.Name = "LoginOkButton";
            this.LoginOkButton.Size = new System.Drawing.Size(75, 23);
            this.LoginOkButton.TabIndex = 2;
            this.LoginOkButton.Text = "Ok";
            this.LoginOkButton.UseVisualStyleBackColor = true;
            this.LoginOkButton.Click += new System.EventHandler(this.LoginOkButton_Click);
            // 
            // LoginCancelButton
            // 
            this.LoginCancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.LoginCancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.LoginCancelButton.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginCancelButton.Location = new System.Drawing.Point(150, 136);
            this.LoginCancelButton.Name = "LoginCancelButton";
            this.LoginCancelButton.Size = new System.Drawing.Size(75, 23);
            this.LoginCancelButton.TabIndex = 3;
            this.LoginCancelButton.Text = "Cancel";
            this.LoginCancelButton.UseVisualStyleBackColor = true;
            this.LoginCancelButton.Click += new System.EventHandler(this.LoginCancelButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(122, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Incorrect Password !";
            this.label1.Visible = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Login
            // 
            this.AcceptButton = this.LoginOkButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(288, 171);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LoginCancelButton);
            this.Controls.Add(this.LoginOkButton);
            this.Controls.Add(this.passwordTextbox);
            this.Controls.Add(this.Password);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label Password;
        private System.Windows.Forms.TextBox passwordTextbox;
        private System.Windows.Forms.Button LoginOkButton;
        private System.Windows.Forms.Button LoginCancelButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
    }
}