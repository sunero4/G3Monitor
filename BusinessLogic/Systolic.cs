using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;
using Accord.Math;
using Accord.Math.Transforms;

namespace BusinessLogic
{
    public class Systolic
    {

        public Systolic()
        {
        }

        public int Calculate(List<double> btList)
        {
            //var complex = btList.Select(x => (Complex) x).ToArray();

            //FourierTransform2.FFT(complex, FourierTransform.Direction.Forward);

            //var sys = complex.Select(x => x.Magnitude).Max();

            //return Convert.ToInt32(sys);
            double max = 0;
            var threshold = btList.Max() * 0.8;
            for (int i = 0, n = btList.Count; i < n; i++)
            {
                if (btList[i] > btList[i + 1] && btList[i] > threshold && btList[i] >= max)
                {
                    max = btList[i];
                }
            }
            return Convert.ToInt32(max);
        }

    }
}
