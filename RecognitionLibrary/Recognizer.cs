using ExtractionLibrary.Interfaces;
using MatchingLibrary.Interfaces;
using Models.Common;
using NormalizationLibrary.Interfaces;
using SegmentationLibrary.Interfaces;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecognitionLibrary
{
    public class Recognizer
    {
        private IImageSegmentator imageSegmentator;
        private IImageNormalizator imageNormalizator;
        private IIrisSignatureExtractor irisSignatureExtractor;
        private IIrisSignatureMatcher irisSignatureMatcher;

        public Recognizer()
        {
            //imageSegmentator = ;
            //imageNormalizator = ;
            //irisSignatureExtractor = ;
            //irisSignatureMatcher = ;
        }

        public void RecognizeTwoIrises(Bitmap bitmap1, Bitmap bitmap2)
        {
            bool equals = irisSignatureMatcher.MatchIrisSignature(
                irisSignatureExtractor.ExtractIrisSignature(
                    imageNormalizator.NormalizeImage(bitmap1,
                        imageSegmentator.SegmentImage(bitmap1))),

                irisSignatureExtractor.ExtractIrisSignature(
                    imageNormalizator.NormalizeImage(bitmap2,
                        imageSegmentator.SegmentImage(bitmap2)))
            );

        }
    }
}
