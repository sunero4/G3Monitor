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

            for (int i = 0; i < containerData.Count; i = i + 5)
            {
                double average = (containerData.GetRange(i, 5).Average());
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

