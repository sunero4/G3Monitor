using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using Accord.Math;
using MathNet.Filtering;

namespace BusinessLogic.Filter
{
    class NetNoise
    {
        public List<double> Netnoise(List<double> containerData)
        {
            //Nedstående forlykke, kovertere til complex tal og derefter til array. 
            var complex = containerData.Select(x => (Complex)x).ToArray();
            //Nyquist 
            var N = complex.Length / 2;
            // fft tidsdomain -> frekvensdomain
            FourierTransform.FFT(complex, FourierTransform.Direction.Forward);
            // Bandstopfilter 
            var BandStopFilter = OnlineFilter.CreateBandstop(ImpulseResponse.Infinite, N, 49, 51, 4);
            // Konvertere til array med typen af double 
            var complexList = complex.Select(x => x.Magnitude).ToArray();
            // Anvender bandstopfilteret på vores data 
            var FilterValues = BandStopFilter.ProcessSamples(complexList);

            // Konverete det filtrede data over til complex og derefter array 
            var filtredeValues = FilterValues.Select(x => (Complex)x).ToArray();
            // fft frekvensdomain -> tidsdomain
            FourierTransform.FFT(filtredeValues, FourierTransform.Direction.Backward);
            // konvertere til størrelsen og list format 
            var filtredeValuesList = filtredeValues.Select(x => x.Magnitude).ToList();
            return filtredeValuesList;
        }
    }
}
