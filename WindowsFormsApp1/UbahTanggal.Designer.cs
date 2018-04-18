namespace WindowsFormsApp1
{
    partial class UbahTanggal
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
            this.UbahTanggalDariDatePicker = new System.Windows.Forms.DateTimePicker();
            this.UbahTanggalSampaiDatePicker = new System.Windows.Forms.DateTimePicker();
            this.UbahTanggalDariLabel = new System.Windows.Forms.Label();
            this.UbahTanggalSampaiLabel = new System.Windows.Forms.Label();
            this.UbahTanggalOkButton = new System.Windows.Forms.Button();
            this.UbahTanggalCancelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // UbahTanggalDariDatePicker
            // 
            this.UbahTanggalDariDatePicker.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UbahTanggalDariDatePicker.Location = new System.Drawing.Point(160, 20);
            this.UbahTanggalDariDatePicker.Name = "UbahTanggalDariDatePicker";
            this.UbahTanggalDariDatePicker.Size = new System.Drawing.Size(276, 29);
            this.UbahTanggalDariDatePicker.TabIndex = 0;
            // 
            // UbahTanggalSampaiDatePicker
            // 
            this.UbahTanggalSampaiDatePicker.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UbahTanggalSampaiDatePicker.Location = new System.Drawing.Point(160, 76);
            this.UbahTanggalSampaiDatePicker.Name = "UbahTanggalSampaiDatePicker";
            this.UbahTanggalSampaiDatePicker.Size = new System.Drawing.Size(276, 29);
            this.UbahTanggalSampaiDatePicker.TabIndex = 1;
            // 
            // UbahTanggalDariLabel
            // 
            this.UbahTanggalDariLabel.AutoSize = true;
            this.UbahTanggalDariLabel.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UbahTanggalDariLabel.Location = new System.Drawing.Point(12, 26);
            this.UbahTanggalDariLabel.Name = "UbahTanggalDariLabel";
            this.UbahTanggalDariLabel.Size = new System.Drawing.Size(118, 21);
            this.UbahTanggalDariLabel.TabIndex = 2;
            this.UbahTanggalDariLabel.Text = "Dari Tanggal : ";
            // 
            // UbahTanggalSampaiLabel
            // 
            this.UbahTanggalSampaiLabel.AutoSize = true;
            this.UbahTanggalSampaiLabel.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UbahTanggalSampaiLabel.Location = new System.Drawing.Point(12, 82);
            this.UbahTanggalSampaiLabel.Name = "UbahTanggalSampaiLabel";
            this.UbahTanggalSampaiLabel.Size = new System.Drawing.Size(142, 21);
            this.UbahTanggalSampaiLabel.TabIndex = 3;
            this.UbahTanggalSampaiLabel.Text = "Sampai Tanggal : ";
            // 
            // UbahTanggalOkButton
            // 
            this.UbahTanggalOkButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.UbahTanggalOkButton.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UbahTanggalOkButton.Location = new System.Drawing.Point(103, 122);
            this.UbahTanggalOkButton.Name = "UbahTanggalOkButton";
            this.UbahTanggalOkButton.Size = new System.Drawing.Size(75, 36);
            this.UbahTanggalOkButton.TabIndex = 4;
            this.UbahTanggalOkButton.Text = "Ok";
            this.UbahTanggalOkButton.UseVisualStyleBackColor = true;
            // 
            // UbahTanggalCancelButton
            // 
            this.UbahTanggalCancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.UbahTanggalCancelButton.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UbahTanggalCancelButton.Location = new System.Drawing.Point(249, 122);
            this.UbahTanggalCancelButton.Name = "UbahTanggalCancelButton";
            this.UbahTanggalCancelButton.Size = new System.Drawing.Size(75, 36);
            this.UbahTanggalCancelButton.TabIndex = 5;
            this.UbahTanggalCancelButton.Text = "Cancel";
            this.UbahTanggalCancelButton.UseVisualStyleBackColor = true;
            // 
            // UbahTanggal
            // 
            this.AcceptButton = this.UbahTanggalOkButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.CancelButton = this.UbahTanggalCancelButton;
            this.ClientSize = new System.Drawing.Size(497, 181);
            this.ControlBox = false;
            this.Controls.Add(this.UbahTanggalCancelButton);
            this.Controls.Add(this.UbahTanggalOkButton);
            this.Controls.Add(this.UbahTanggalSampaiLabel);
            this.Controls.Add(this.UbahTanggalDariLabel);
            this.Controls.Add(this.UbahTanggalSampaiDatePicker);
            this.Controls.Add(this.UbahTanggalDariDatePicker);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Name = "UbahTanggal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Ubah Tanggal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker UbahTanggalDariDatePicker;
        private System.Windows.Forms.DateTimePicker UbahTanggalSampaiDatePicker;
        private System.Windows.Forms.Label UbahTanggalDariLabel;
        private System.Windows.Forms.Label UbahTanggalSampaiLabel;
        private System.Windows.Forms.Button UbahTanggalOkButton;
        private System.Windows.Forms.Button UbahTanggalCancelButton;
    }
}