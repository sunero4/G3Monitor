using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ObserverPattern;

namespace BusinessLogic
{
    public class ShowData : MeasurementSubjectBL
    {
        private Queue<double> _slidingWindow;
        private Filtering _filter;
        private Pulse _pulse;
        private Systolic _sys;
        private Diastolic _dia;
        private AverageBloodPressure _average;
        private PresentationDataContainer _container;
        private VoltageToPressureConversion _convert;

        public Queue<double> SlidingWindow
        {
            get => _slidingWindow;
            set
            {
                if (SlidingWindow.Count == 4000)
                {
                    SlidingWindow.DequeueMultipleElements(100);
                }
                _slidingWindow.EnqueueMultipleElements(value);
            }
        }


        public ShowData(PresentationDataContainer container)
        {
            _filter = new Filtering();
            _pulse = new Pulse();
            _average = new AverageBloodPressure();
            _dia = new Diastolic();
            _sys = new Systolic();
            _convert = new VoltageToPressureConversion();
            _container = container;
        }

        public void HandleData()
        {
            _container.AverageBloodPressure = _average.CalculateAverageBP();
            _container.SystolicPressure = _sys.CalculateSystolic();
            _container.DiastolicPressure = _dia.CalculateDiastolic();
            _container.Pulse = _pulse.CalculatePulse();
            _container.FilteredBPValues = _filter.FilterBloodPressure();
            Notify();
        }

        public void Start()
        {


        }



    }
}
