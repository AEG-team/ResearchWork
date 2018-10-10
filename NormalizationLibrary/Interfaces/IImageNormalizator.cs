using Models.Common;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NormalizationLibrary.Interfaces
{
    public interface IImageNormalizator
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="bitmap"></param>
        /// <param name="irisCircles"></param>
        /// <returns></returns>
        Bitmap NormalizeImage(Bitmap bitmap, Tuple<Circle, Circle> irisCircles);
    }
}
