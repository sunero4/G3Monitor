using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class Systolic
    {

        public Systolic()
        {
        }

        public int Calculate(List<double> btList)
        {
            var threshold = btList.Max() * 0.8;
            double max = 0;
            for (int i = 0; i < btList.Count; i++)
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
