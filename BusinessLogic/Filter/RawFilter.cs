using System.Collections.Generic;
using System.Linq;

namespace BusinessLogic.Filter
{
    public class RawFilter : IFilter
    {
        private List<double> ChartList;

        public RawFilter()
        {
            ChartList = new List<double>();
        }

        /// <summary>
        /// Filters the supplied data with a smoothing filter using only average
        /// </summary>
        /// <param name="containerData">Bloodpressure values</param>
        /// <returns>Smoothed bloodpressure values</returns>
        public List<double> Smoothing(List<double> containerData)
        {
            ChartList.Clear();
            for (int i = 0; i < containerData.Count - 5; i += 5)
            {
                double average = (containerData.GetRange(i, 5).Average());
                ChartList.Add(average);
            }
            return ChartList;
        }
    }
}

