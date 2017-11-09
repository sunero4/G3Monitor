using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class KalibreringsDTO
    {
        public List<int> ExpectedValue { get; set; }
        public List<int> ActualValue { get; set; }
    }
}
