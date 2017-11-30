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
    public class FilterBP:IFilter
    {
        private List<double> ChartList;

        public FilterBP()
        {
            ChartList = new List<double>();
        }

        public List<double> Smoothing(List<double> containerData)
        {
            for (int i = 0; i < containerData.Count; i = i + 10)
            {
                double average = (containerData.GetRange(i, 10).Average());
                ChartList.Add(average);

                if (ChartList.Count > 400)
                {
                    ChartList.RemoveAt(0);
                }
            }
            return ChartList;
        }
    }
}
