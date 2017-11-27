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
        private Queue<double> _buffer;

        public Pulse()
        {
            _buffer = new Queue<double>(5);
        }

        private double TimeDifferences(List<int> times)
        {
            var differences = new List<double>();
            double oldDifference = 0;

            for (int i = 0; i < times.Count; i++)
            {
                var diff = times[i] - oldDifference;
                differences.Add(diff);
                oldDifference = times[i];
            }

            var averageDifference = differences.Average();

            return averageDifference;
        }

        private List<int> Times(List<double> btList)
        {
            ////FFT??
            //var complex = btList.Select(x => (Complex) x).ToArray();

            //FourierTransform.FFT(complex, FourierTransform.Direction.Forward);

            //var fftList = complex.Select(x => x.Magnitude).Where(y => y > 200).ToList();

            //List<double> timesList = new List<double>();
            //for (int i = 0, n = complex.Length; i < n; i++)
            //{
            //    if (complex[i].Magnitude > 200)
            //    {
            //        timesList.Add(i * 0.001);
            //    }
            //}

            double max = 0;
            var threshold = btList.Max() * 0.8;
            List<int> times = new List<int>();

            for (int i = 0, n = btList.Count - 1; i < n; i++)
            {
                if (btList[i] > btList[i + 1] && btList[i] > threshold && btList[i] >= max)
                {
                    max = btList[i];
                    times.Add(i);
                }
            }
            return times;
        }

        public int Calculate(List<double> btList)
        {
            var times = Times(btList);
            var diff = TimeDifferences(times);
            _buffer.Enqueue(diff);

            var pulse = 60000 / _buffer.Average();

            return Convert.ToInt32(pulse);
        }


    }
}
