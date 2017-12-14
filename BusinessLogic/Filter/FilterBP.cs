using System.Collections.Generic;
using System.Linq;

namespace BusinessLogic.Filter
{
    public class FilterBP : IFilter
    {
        private List<double> ChartList;
        private List<double> OutList;

        public FilterBP()
        {
            ChartList = new List<double>();
            OutList = new List<double>();
        }

        /// <summary>
        /// Filters the supplied data with a smoothing filter using both average and moving average
        /// </summary>
        /// <param name="containerData">Bloodpressure values</param>
        /// <returns>Smoothed bloodpressure values</returns>
        public List<double> Smoothing(List<double> containerData)
        {
            ChartList.Clear();
            OutList.Clear();
            double sum = 0;

            for (int i = 0, n = containerData.Count; i < n - 5; i += 5)
            {
                double average = (containerData.GetRange(i, 5).Average());
                ChartList.Add(average);
            }

            for (int i = 0, n = ChartList.Count; i < n - 2; i++)
            {
                sum = ChartList[i] + ChartList[i + 1] + ChartList[i + 2];
                OutList.Add(sum / 3);
            }
            OutList.Add(ChartList[ChartList.Count - 2]);
            OutList.Add(ChartList[ChartList.Count - 1]);
            return OutList;
        }
    }
}
