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
    public class Diastolic : ICalculateSysDia
    {
        // vi anvender timediff til at indele målingen, således at vi kun ser på den sidste del af listen hvor der er én systole og én diastole. 

        public int Calculate(List<double> btList, int timediff)
        {
            var startIndex = btList.Count - timediff;
            var currentSamples = btList.Skip(startIndex);

            var diastolic = Convert.ToInt32(currentSamples.Min());
            return diastolic;
        }
    }
}
