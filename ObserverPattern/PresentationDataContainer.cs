using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    public class PresentationDataContainer : MeasurementSubjectBL
    {
        private Queue<double> _slidingWindow;

        public PresentationDataContainer()
        {
            _slidingWindow = new Queue<double>();
        }

        public void SetSlidingWindow(List<double> data)
        {
            if (_slidingWindow.Count == 4000)
            {
                _slidingWindow.DequeueMultipleElements(100);
            }
            _slidingWindow.EnqueueMultipleElements(data);
        }

        public List<double> GetSlidingWindow()
        {
            return _slidingWindow.ToList();
        }

        public List<double> FilteredBPValues { get; set; }
        public int SystolicPressure { get; set; }
        public int DiastolicPressure { get; set; }
        public int AverageBloodPressure { get; set; }
        public int Pulse { get; set; }

    }
}
