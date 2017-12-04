using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public interface IPulse
    {
        double Calculate(List<double> btList);
        int TimeDifferences(List<double> data);
        List<int> Times(List<double> btList);
    }
}
