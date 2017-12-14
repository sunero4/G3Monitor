using System;
using System.Collections.Generic;
using System.Linq;

namespace BusinessLogic
{
    public class AverageBloodPressure:IAverageBP
    {
        /// <summary>
        /// Finds the average bloodpressure by taking the average of the entire list of values
        /// </summary>
        /// <param name="btList">Bloodpressure values</param>
        /// <returns>Average bloodpressure</returns>
        public int Calculate(List<double> btList)
        {
            var average = btList.Average();

            return Convert.ToInt32(average);
        }
    }
}
