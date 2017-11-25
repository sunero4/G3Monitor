using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Accord.Statistics.Distributions.Fitting;
using Accord.Statistics.Models.Regression.Linear;
using MathNet.Filtering;

namespace BusinessLogic.Filter
{
    class Filter:IFilter
    {
        public List<double> Filtrer(List<double> containerData)
        {
            
            for (int i = 0; i < containerData.Count; i++)
            {
                
            }
            containerData.smooth();
            return containerData;
        }
    }
}
