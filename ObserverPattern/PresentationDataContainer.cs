using System.Collections.Generic;

namespace ObserverPattern
{
    public class PresentationDataContainer : MeasurementSubjectBL
    {
        public List<double> FilteredBPValues { get; set; }
        public int SystolicPressure { get; set; }
        public int DiastolicPressure { get; set; }
        public int AverageBloodPressure { get; set; }
        public int Pulse { get; set; }

    }
}
