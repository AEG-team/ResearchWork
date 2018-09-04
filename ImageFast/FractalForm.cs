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
    public partial class FractalForm : Form
    {
        private Bitmap processingImage;

        public FractalForm(Bitmap image, Form form)
        {
            InitializeComponent();
            PictureOrigin.Image = image;

            processingImage = image;
        }

        private void Processing(Bitmap image)
        {
            List<PictureBox> pictureBoxes = new List<PictureBox>() {
                Picture1, Picture2, Picture3, Picture4, Picture5, Picture6, Picture7, Picture8
            };

            image = new Bitmap(image, 1024, 512);
            int globalWidth = image.Width,
                globalHeight = image.Height,
                localWidth = globalWidth,
                localHeight = globalHeight;

            for (int iteration = 0; iteration < 8; iteration++)
            {
                Bitmap newImage = new Bitmap(1024, 512);
                int divider = (int)Math.Pow(2, iteration); //2 ^ iteration;
                int blockHeight, blockWidth, limitY, limitX;
                int[] sum = new int[4];

                for (int subIterY = 0; subIterY < divider; subIterY++)
                {
                    for (int subIterX = 0; subIterX < divider; subIterX++)
                    {

                        for (int blockY = 0; blockY < 2; blockY++)
                        {
                            for (int blockX = 0; blockX < 2; blockX++)
                            {
                                blockHeight = localHeight / 2;
                                blockWidth = localWidth / 2;
                                limitY = subIterY * localHeight + (blockY + 1) * blockHeight;
                                limitX = subIterX * localWidth + (blockX + 1) * blockWidth;

                                for (int y = subIterY * localHeight + blockY * blockHeight; y < limitY; y++)
                                {
                                    for (int x = subIterX * localWidth + blockX * blockWidth; x < limitX; x++)
                                    {
                                        Color color = image.GetPixel(x, y);
                                        sum[blockY * 2 + blockX] += color.R + color.G + color.B;
                                    }
                                }
                            }
                        }

                        List<int> sorted = sum.ToList();
                        sorted.Sort();

                        int firstMax = sum.ToList().IndexOf(sorted[3]);
                        int secondMax = sum.ToList().IndexOf(sorted[2]);


                        for (int blockY = 0; blockY < 2; blockY++)
                        {
                            for (int blockX = 0; blockX < 2; blockX++)
                            {
                                blockHeight = localHeight / 2;
                                blockWidth = localWidth / 2;
                                limitY = subIterY * localHeight + (blockY + 1) * blockHeight;
                                limitX = subIterX * localWidth + (blockX + 1) * blockWidth;

                                if ((firstMax == (blockY * 2 + blockX)) || (secondMax == (blockY * 2 + blockX)))
                                {
                                    for (int y = subIterY * localHeight + blockY * blockHeight; y < limitY; y++)
                                    {
                                        for (int x = subIterX * localWidth + blockX * blockWidth; x < limitX; x++)
                                        {
                                            newImage.SetPixel(x, y, Color.White);
                                        }
                                    }
                                }
                                else
                                {
                                    for (int y = subIterY * localHeight + blockY * blockHeight; y < limitY; y++)
                                    {
                                        for (int x = subIterX * localWidth + blockX * blockWidth; x < limitX; x++)
                                        {
                                            newImage.SetPixel(x, y, Color.Black);
                                        }
                                    }
                                }
                            }
                        }

                    }
                }

                pictureBoxes[iteration].Image = newImage;

                localWidth /= 2;
                localHeight /= 2;
            }
        }

        private void FractalForm_Load(object sender, EventArgs e)
        {
            if (processingImage != null)
                Processing(processingImage);
        }

        private void SaveImage(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog fileDialog = new SaveFileDialog();
                fileDialog.ShowDialog();

                ((PictureBox)sender).Image.Save(fileDialog.FileName);
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

    }
}
