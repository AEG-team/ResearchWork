using Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatchingLibrary.Interfaces
{
    public interface IIrisSignatureMatcher
    {
        bool MatchIrisSignature(IrisSignature firstIrisSegnature, IrisSignature secondIrisSignature);
    }
}
