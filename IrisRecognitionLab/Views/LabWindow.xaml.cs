using Emgu.CV;
using Emgu.CV.Structure;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace IrisRecognitionLab.Views
{
    /// <summary>
    /// Interaction logic for LabWindow.xaml
    /// </summary>
    public partial class LabWindow : Window
    {
        public LabWindow()
        {
            InitializeComponent();
        }

        private Bitmap workingImage;

        private void OpenImage_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog()
            {
                Filter = "JPEG Files (*.jpeg)|*.jpeg|PNG Files (*.png)|*.png|JPG Files (*.jpg)|*.jpg",
                FilterIndex = 2,
                Multiselect = false
            };

            if (dialog.ShowDialog() == true)
            {
                workingImage = new Bitmap(dialog.FileName);
                MainImageBox.Source = new BitmapImage(new Uri(dialog.FileName));
            }
        }

        private void SegmentEye_Click(object sender, RoutedEventArgs e)
        {
            SegmentEyeOptions.Visibility = Visibility.Visible;
        }

        public static Bitmap ConvertToBitmap(BitmapSource bitmapSource)
        {
            var width = bitmapSource.PixelWidth;
            var height = bitmapSource.PixelHeight;
            var stride = width * ((bitmapSource.Format.BitsPerPixel + 7) / 8);
            var memoryBlockPointer = Marshal.AllocHGlobal(height * stride);
            bitmapSource.CopyPixels(new Int32Rect(0, 0, width, height), memoryBlockPointer, height * stride, stride);
            var bitmap = new Bitmap(width, height, stride, System.Drawing.Imaging.PixelFormat.Format32bppPArgb, memoryBlockPointer);
            return bitmap;
        }

        public BitmapImage ConvertToBitmapImage(Bitmap src)
        {
            MemoryStream ms = new MemoryStream();
            ((System.Drawing.Bitmap)src).Save(ms, System.Drawing.Imaging.ImageFormat.Bmp);
            BitmapImage image = new BitmapImage();
            image.BeginInit();
            ms.Seek(0, SeekOrigin.Begin);
            image.StreamSource = ms;
            image.EndInit();
            return image;
        }

        private void SegmentEyeButton_Click(object sender, RoutedEventArgs e)
        {
            if (MainImageBox.Source == null)
                return;

            double cannyThreshold = CannyThresholdSlider.Value;
            double circleAccumulatorThreshold = CircleAccumulatorThresholdSlider.Value;

            Image<Rgb, byte> eyeImage = new Image<Rgb, byte>(workingImage);
            Image<Gray, byte> gray = new Image<Gray, byte>(workingImage);

            CircleF[] circles = gray.HoughCircles(
                new Gray(cannyThreshold),
                new Gray(circleAccumulatorThreshold),
                2.0, //Resolution of the accumulator used to detect centers of the circles 
                20.0, //min distance 
                5, //min radius 
                0 //max radius 
                )[0]; //Get the circles from the first channel 

            

            CircleF Iris = new CircleF();

            foreach (CircleF circle in circles)
            {
                eyeImage.Draw(circle, new Rgb(System.Drawing.Color.Red), 2);
                Iris = circle;
            }

            MainImageBox.Source = ConvertToBitmapImage(eyeImage.Bitmap);
        }
    }
}
