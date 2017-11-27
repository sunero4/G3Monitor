using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public interface IFilter
    {
        List<double> Smoothing(List<double> containerData); 
    }
}
