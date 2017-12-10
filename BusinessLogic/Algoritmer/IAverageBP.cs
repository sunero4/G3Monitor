using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public interface IAverageBP
    {
        int Calculate(List<double> btList); 
    }
}
