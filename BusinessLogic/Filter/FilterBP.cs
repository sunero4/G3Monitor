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
        private List<double> OutList;

        public FilterBP()
        {
            ChartList = new List<double>();
            OutList = new List<double>();
        }

        public List<double> Smoothing(List<double> containerData)
        {
            ChartList.Clear();
            OutList.Clear();

            for (int i = 0, n = containerData.Count; i < n - 10; i = i + 10)
            {
                double average = (containerData.GetRange(i, 10).Average());
                ChartList.Add(average);

                //if (ChartList.Count > 400)
                //{
                //    ChartList.RemoveAt(0);
                //}
            }

            for (int i = 0, n = ChartList.Count; i < n - 2; i++)
            {
                double average = (containerData.GetRange(i, 2).Average());
                OutList.Add(average);
            }
            return OutList;
            //ChartList.Clear();
        }
    }
}
