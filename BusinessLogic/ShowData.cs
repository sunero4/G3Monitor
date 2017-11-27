using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using ObserverPattern;

namespace BusinessLogic
{
    public class ShowData : MeasurementSubjectBL
    {
        private Queue<double> _slidingWindow;
        private ConcurrentQueue<BPDataContainer> _queue;
        private FilterFactory _filter;
        private Pulse _pulse;
        private Systolic _sys;
        private Diastolic _dia;
        private AverageBloodPressure _average;
        private PresentationDataContainer _container;
        private VoltageToPressureConversion _convert;

        public bool CanRun { get; set; }

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


        public ShowData(PresentationDataContainer container, ConcurrentQueue<BPDataContainer> queue)
        {
            _filter = new FilterFactory();
            _pulse = new Pulse();
            _average = new AverageBloodPressure();
            _dia = new Diastolic();
            _sys = new Systolic();
            _convert = new VoltageToPressureConversion();
            _container = container;
            _queue = queue;
        }

        public void HandleData()
        {
            BPDataContainer container;
            while (!_queue.TryDequeue(out container))
            {
                Thread.Sleep(0);
            }

            var data = _convert.ConvertToPressure(container.BloodPressure);
            _container.FilteredBPValues = data;

            SetSlidingWindow(data);

            var bpData = GetSlidingWindow();

            _container.AverageBloodPressure = _average.Calculate(bpData);
            _container.SystolicPressure = _sys.Calculate(bpData);
            _container.DiastolicPressure = _dia.Calculate(bpData);
            _container.Pulse = _pulse.Calculate(bpData);


            Notify();
        }

        public void Start()
        {
            while (CanRun)
            {
                HandleData();
            }

        }



    }
}
