using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    public class PresentationDataContainer
    {
        public List<double> FilteredBPValues { get; set; }
        public int SystolicPressure { get; set; }
        public int DiastolicPressure { get; set; }
        public int AverageBloodPressure { get; set; }
        public int Pulse { get; set; }

    }
}
