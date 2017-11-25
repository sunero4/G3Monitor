using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Filter
{
    class RawFilter:IFilter
    {
        public List<double> Filtrer(List<double> containerData)
        {
            containerData.smooth();
            return containerData;
        }
    }
}
