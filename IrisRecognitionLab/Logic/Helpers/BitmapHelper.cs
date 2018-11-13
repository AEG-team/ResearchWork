using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IrisRecognitionLab.Logic.Helpers
{
    public static class BitmapHelper
    {
        public static double GetGrayPixel(this Bitmap image, int x, int y)
        {
            System.Drawing.Color pixel = image.GetPixel(x, y);
            return 0.299 * pixel.R + 0.587 * pixel.G + 0.114 * pixel.B;
        }
    }
}
