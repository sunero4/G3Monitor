using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using Accord.Math;
using Accord.Math.Transforms;

namespace BusinessLogic
{
    public class Pulse:IPulse
    {
        private double _lastPulse;
        /// <summary>
        /// Finds the differences between the indexes of peaks in the bloodpressure values
        /// </summary>
        /// <param name="data">Bloodpressure values</param>
        /// <returns>Mean time difference between peaks as an integer</returns>
        public int TimeDifferences(List<double> data)
        {
            var times = Times(data);

            var differences = new List<double>();

            //var oldDifference = 0;
            for (int i = 1; i < times.Count; i++)
            {
                var diff = times[i] - times[i - 1];
                differences.Add(diff);
            }
            double averageDifference;

            //If for some reason an error occurred and no time difference was found, return last measured
            //pulse
            if (differences.Count == 0)
            {
                averageDifference = _lastPulse;
            }
            else
            {
                averageDifference = differences.Average();
            }

            _lastPulse = averageDifference;

            return Convert.ToInt32(averageDifference);
        }


        /// <summary>
        /// Takes a list of blood pressure values and finds the indexes of the peaks in the measurement
        /// </summary>
        /// <param name="values">Blood pressure values</param>
        /// <returns>A list of the indexes of the peaks in the measurement</returns>
        public List<int> Times(List<double> values)
        {
            var peaks = new List<int>();
            var count = 0;
            var threshold = values.Max() * 0.8;

            for (int i = 20; i < values.Count - 20; i += 20)
            {
                if (values[i] > threshold)
                {
                    if (values[i] > values[i - 20] && values[i] > values[i + 20])
                    {
                        peaks.Add(i);
                    }
                }
            }

            return peaks;
        }

        /// <summary>
        /// Takes the mean time variance between peaks and calculates the pulse from that
        /// </summary>
        /// <param name="btList">The bloodpressure values</param>
        /// <returns>Pulse as an integer</returns>
        public int Calculate(List<double> btList)
        {
            int pulse = 0;
            var diff = TimeDifferences(btList);

            //60000 samples = 1 minute, divide with average time difference to find beats per minute
            if (diff != 0)
            {
                pulse = 60000 / diff; 
            }
            
            return Convert.ToInt32(pulse * 0.9);
        }
    }
}
