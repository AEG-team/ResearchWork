using AForge.Imaging;
using AForge.Imaging.Filters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImageFast
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void ImgInput_Click(object sender, EventArgs e)
        {
            try
            {
                PictureBox pictureBox = (PictureBox)sender;

                OpenFileDialog fileDialog = new OpenFileDialog();
                fileDialog.ShowDialog();

                pictureBox.Image = new Bitmap(fileDialog.FileName); //fileDialog.OpenFile();
                ImgOutput.Image = null;
                ProgressBar.Value = 0;
            }
            catch (Exception excention)
            {
                MessageBox.Show(excention.Message);
            }
        }

        private void BtnProcess_Click(object sender, EventArgs e)
        {
            Bitmap image = (Bitmap)ImgInput.Image.Clone();
            ProgressBar.Maximum = image.Height * image.Width * (ChcMedianFilter.Checked ? 2 : 1);
            ProgressBar.Value = 0;
            for (int h = 0; h < image.Height; h++)
            {
                for (int w = 0; w < image.Width; w++)
                {
                    ProgressBar.Value = h * image.Width + w;

                    if (ChcBlackWhite.Checked)
                    {
                        Color color = image.GetPixel(w, h);
                        int intColor = (int)(color.R * 0.26 + color.G * 0.44 + color.B * 0.3);
                        Color newColor = Color.FromArgb(intColor, intColor, intColor);
                        image.SetPixel(w, h, newColor);
                    }

                    if (ChcInverse.Checked)
                    {
                        Color color = image.GetPixel(w, h);
                        image.SetPixel(w, h, Color.FromArgb(255 - color.R, 255 - color.G, 255 - color.B));
                    }
                }
            }
            if (ChcMedianFilter.Checked)
            {
                Bitmap copy = (Bitmap)image.Clone();
                for (int h = 0; h < image.Height; h++)
                {
                    for (int w = 0; w < image.Width; w++)
                    {
                        List<Color> colors = new List<Color>();
                        if (h == 0 || w == 0 || h == image.Height - 1 || w == image.Width - 1)
                        {
                            for (int y = -1; y < 2; y++)
                            {
                                for (int x = -1; x < 2; x++)
                                {
                                    colors.Add(copy.GetPixel(
                                        (w + x < 0 ? 0 : (w + x > image.Width - 1 ? image.Width - 1 : w + x)),
                                        (h + y < 0 ? 0 : (h + y > image.Height - 1 ? image.Height - 1 : h + y))  ));
                                }
                            }
                        }
                        else
                        {
                            for (int y = -1; y < 2; y++)
                            {
                                for (int x = -1; x < 2; x++)
                                {
                                    colors.Add(copy.GetPixel(w + x, h + y));
                                }
                            }
                            
                        }
                        List<List<byte>> colorParts = new List<List<byte>>() {
                                colors.Select(c => c.R).ToList(),
                                colors.Select(c => c.G).ToList(),
                                colors.Select(c => c.B).ToList()};
                        colorParts.ForEach((cp) => { cp.Sort(); });

                        image.SetPixel(w, h, Color.FromArgb(colorParts[0][4], colorParts[1][4], colorParts[2][4]));


                        ProgressBar.Value = ProgressBar.Maximum / 2 + h * image.Width + w;
                    }
                }
            } 

            ImgOutput.Image = image;
        }

        private void BtnResultToInput_Click(object sender, EventArgs e)
        {
            if (ImgOutput.Image != null)
            {
                ImgInput.Image = (Bitmap)ImgOutput.Image.Clone();
                ImgOutput.Image = null;
                ProgressBar.Value = 0;
            }
        }

        private void ImgOutput_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog fileDialog = new SaveFileDialog();
                fileDialog.ShowDialog();

                ImgOutput.Image.Save(fileDialog.FileName);
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void BtnMakeFractal_Click(object sender, EventArgs e)
        {
            new FractalForm((Bitmap)ImgInput.Image, this).Show();
        }

        private void BtnDetectEdges_Click(object sender, EventArgs e)
        {
            try
            {
                ProgressBar.Maximum = 3;
                ProgressBar.Value = 0;

                UnmanagedImage image = UnmanagedImage.FromManagedImage((Bitmap)ImgInput.Image);

                // 1 - grayscaling
                UnmanagedImage grayImage = null;

                if (image.PixelFormat == PixelFormat.Format8bppIndexed)
                {
                    grayImage = image;
                }
                else
                {
                    grayImage = UnmanagedImage.Create(image.Width, image.Height,
                        PixelFormat.Format8bppIndexed);
                    Grayscale.CommonAlgorithms.BT709.Apply(image, grayImage);
                }
                ProgressBar.Value++;

                // 2 - Edge detection
                DifferenceEdgeDetector edgeDetector = new DifferenceEdgeDetector();
                UnmanagedImage edgesImage = edgeDetector.Apply(grayImage);
                ProgressBar.Value++;

                // 3 - Threshold edges
                Threshold thresholdFilter = new Threshold((int)NumericTrashold.Value);
                thresholdFilter.ApplyInPlace(edgesImage);
                ProgressBar.Value++;

                ImgOutput.Image = edgesImage.ToManagedImage();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void BtnExplore_Click(object sender, EventArgs e)
        {
            new ExploreGradients((Bitmap)ImgOutput.Image).Show();
        }
    }
}
