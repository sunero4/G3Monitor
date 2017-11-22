using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class Diastolic
    {
        public int Calculate(List<double> btList)
        {
            var threshold = btList.Max() * 0.7;
            double min = 0;
            for (int i = 0; i < btList.Count; i++)
            {
                if (btList[i] < btList[i + 1] && btList[i] < threshold && btList[i] <= min)
                {
                    min = btList[i];
                }
            }

            return Convert.ToInt32(min);
        }

    }
}
