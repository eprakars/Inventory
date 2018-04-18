namespace WindowsFormsApp1
{
    partial class ImageForm
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
            this.ItemJualPictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ItemJualPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // ItemJualPictureBox
            // 
            this.ItemJualPictureBox.Location = new System.Drawing.Point(12, 12);
            this.ItemJualPictureBox.Name = "ItemJualPictureBox";
            this.ItemJualPictureBox.Size = new System.Drawing.Size(293, 223);
            this.ItemJualPictureBox.TabIndex = 19;
            this.ItemJualPictureBox.TabStop = false;
            // 
            // ImageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(317, 247);
            this.Controls.Add(this.ItemJualPictureBox);
            this.Name = "ImageForm";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.ImageForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ItemJualPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ImageForm_FormClosing);

        }

        #endregion

        private System.Windows.Forms.PictureBox ItemJualPictureBox;
    }
}