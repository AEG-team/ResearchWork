using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImageFast
{
    public partial class ExploreGradients : Form
    {
        public ExploreGradients(Bitmap image)
        {
            InitializeComponent();

            PictureMain.Image = image;
            // Process canny
        }

        private void PictureMain_MouseMove(object sender, MouseEventArgs e)
        {
            PictureBox pictureBox = (PictureBox)sender;
            LblCoords.Text = "X: " + (int)(e.X / (float)pictureBox.Width * pictureBox.Image.Width) + " | Y: " + (int)(e.Y / (float)pictureBox.Height * pictureBox.Image.Height);
        }
    }
}
