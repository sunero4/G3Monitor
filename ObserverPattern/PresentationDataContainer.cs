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
            Fill(_slidingWindow);
        }

        private void Fill(Queue<double> queue)
        {
            for (int i = 0; i < 500; i++)
            {
                queue.Enqueue(0);
            }
        }

        public void SetSlidingWindow(List<double> data)
        {
            if (_slidingWindow.Count >= 1000)
            {
                _slidingWindow.DequeueMultipleElements(data.Count);
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
