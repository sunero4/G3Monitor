using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using Accord.Math;
using Accord.Math.Transforms;

namespace BusinessLogic
{
    public class Diastolic
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="btList"></param>
        /// <returns></returns>
        public double Calculate(List<double> btList)
        {
            ////FFT???
            //Converts the blood pressure values to complex numbers
            var complex = btList.Select(x => (Complex)x).ToArray();

            //Performs fast fourier transformation on the complex numbers
            FourierTransform2.FFT(complex, FourierTransform.Direction.Forward);

            //Creates an array of the magnitudes of the fft bins
            var diaFFT = complex.Select(x => x.Magnitude).ToArray();

            //Finds the index that holds the largest amplitude and takes the bloodpressure value at that index
            var diaIndex = IndexCalculation.FindMaxIndex(diaFFT);   
            var dia = btList[diaIndex];

            return dia;

        }

    }

    public class IndexCalculation
    {
        public static int FindMaxIndex(IEnumerable<double> collection)
        {
            int index = 0;
            if (collection == null) return index;

            var temp = collection.ToArray();

            double max = 0;
            for (int i = 0; i < temp.Length; i++)
            {
                if (temp[i] > max)
                {
                    max = temp[i];
                    index = i;
                }
            }

            return index;
        }
    }
}
