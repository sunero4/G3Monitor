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
            var complex = btList.Select(x => (Complex) x).ToArray();

            FourierTransform2.FFT(complex, FourierTransform.Direction.Forward);

            var sys = complex.Select(x => x.Magnitude).Max();

            return Convert.ToInt32(sys);
        }

    }
}
