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
        public int TimeDifferences(List<double> data)
        {
            var times = Times(data);

            var differences = new List<double>();
            double oldDifference = 0;

            for (int i = 0; i < times.Count; i++)
            {
                var diff = times[i] - oldDifference;
                differences.Add(diff);
                oldDifference = times[i];
            }
            var averageDifference = differences.Average();

            return Convert.ToInt32(averageDifference);
        }
        public List<int> Times(List<double> btList)
        {
            double max = 0;
            var threshold = btList.Max() * 0.8;
            List<int> times = new List<int>();

            for (int i = 0; i < btList.Count; i++)
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
            var pulse = 60000 / diff / 1000; // 60000 sample divideret med den gennemsnitlige tidsforskel mellem toppunkterne og derefter dividere vi med en faktor 1000, da der er 1000 sample pr. sekund. 
            return Convert.ToInt32(pulse);

        }
    }
}
