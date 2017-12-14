using System;
using System.Collections.Generic;
using System.Linq;

namespace BusinessLogic
{
    public class Diastolic : ICalculateSysDia
    {
        // vi anvender timediff til at indele målingen, således at vi kun ser på den sidste del af listen hvor der er én systole og én diastole. 

        /// <summary>
        /// Finds diastolic pressure for the latest heart cycle
        /// </summary>
        /// <param name="btList">Bloodpressure values</param>
        /// <param name="timediff">Mean time difference between peaks</param>
        /// <returns>Diastolic pressure</returns>
        public int Calculate(List<double> btList, int timediff)
        {
            //If there is for some reason an error with the time difference, return 0
            if (timediff == 0)
            {
                return 0;
            }

            var startIndex = btList.Count - timediff;
            var currentSamples = btList.Skip(startIndex);

            var diastolic = Convert.ToInt32(currentSamples.Min());
            return diastolic;
        }
    }
}
