using Models.Common;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SegmentationLibrary.Interfaces
{
    public interface IImageSegmentator
    {

        /// <summary>
        /// 
        /// </summary>
        /// <param name="bitmap"> Input image </param>
        /// <returns> Returns two circle of pupil (first one) and iris </returns>
        Tuple<Circle, Circle> SegmentImage(Bitmap bitmap);
    }
}
