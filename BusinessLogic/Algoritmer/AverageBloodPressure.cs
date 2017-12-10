using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class AverageBloodPressure:IAverageBP
    {
        public int Calculate(List<double> btList)
        {
            var average = btList.Average();

            return Convert.ToInt32(average);
        }
    }
}
