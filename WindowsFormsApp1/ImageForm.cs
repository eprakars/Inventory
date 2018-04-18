using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class ImageForm : Form
    {
        public ImageForm()
        {
            InitializeComponent();
        }

        private void ImageForm_Load(object sender, EventArgs e)
        {
            ItemJualPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        public void setImage(string filePath)
        {
            if (!filePath.Equals(""))
            {
                try
                {
                    ItemJualPictureBox.Image = new Bitmap(filePath);
                }
                catch
                {
                }
            } else
            {
                ItemJualPictureBox.Image = null;
            }

        }

        private void ImageForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
                this.Hide();
            }
        }
    }
}
