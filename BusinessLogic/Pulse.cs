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
    public class Pulse
    {
        private double _factor;

        public Pulse()
        {
            //Multiply the bin number from the FFT with this - nth bin has value of: n * F_s / N
            _factor = Convert.ToDouble(1000 / 4000);
        }
        public int Calculate(List<double> data)
        {
            var complex = data.Select(x => (Complex) x).ToArray();

            FourierTransform.FFT(complex, FourierTransform.Direction.Forward);

            double max = 0;
            double maxFrequency = -1;
            for (int i = 1; i < complex.Length; i++)
            {
                if (complex[i].Magnitude > max)
                {
                    max = complex[i].Magnitude;
                    maxFrequency = i * _factor;
                }
            }

            var result = maxFrequency * 120;
            return Convert.ToInt32(result);
        }


    }
}
