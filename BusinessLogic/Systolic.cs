using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using ObserverPattern;

namespace BusinessLogic
{
    public class Systolic
    {
        // vi anvender timediff til at indele målingen, således at vi kun ser på den sidste del af listen hvor der er én systole og én diastole. 
        
        public int Calculate(List<double> btList, int timediff)
        {
            var startIndex = btList.Count - timediff;
            var currentSamples = btList.Skip(startIndex);

            var systolic = Convert.ToInt32(currentSamples.Max());
            return systolic;      
        }

    }
}
