using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Filter
{
    public class RawFilter : IFilter
    {
        private List<double> ChartList;
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

