using Models.Common;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtractionLibrary.Interfaces
{
    public interface IIrisSignatureExtractor
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="normalizedImage"></param>
        /// <returns></returns>
        IrisSignature ExtractIrisSignature(Bitmap normalizedImage);
    }
}
