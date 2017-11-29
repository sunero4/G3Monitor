using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using BusinessLogic.Filter;
using Interfaces;
using ObserverPattern;

namespace BusinessLogic
{
    public class BPConsumer : MeasurementSubjectBL
    {
        private ConcurrentQueue<BPDataContainer> _queue;
        private AutoResetEvent _event;
        public List<double> BPState { get; set; }
        private IDataAccess _dataAccess;
        private IFilter _filtering;
        private KaliAndZero _kaliAndZero;

        public bool CanRun { get; set; }

        public BPConsumer(ConcurrentQueue<BPDataContainer> queue, IDataAccess dataAccess, AutoResetEvent autoResetEvent, IFilter filter, KaliAndZero kaliAndZero)
        {
            _queue = queue;
            _dataAccess = dataAccess;
            _event = autoResetEvent;
            _filtering = filter;
            _kaliAndZero = kaliAndZero;
            
        }

        public void HandleData()
        {
            BPDataContainer container;
            List<double> filteredData = new List<double>();
            while (!_queue.TryDequeue(out container))
            {
                Thread.Sleep(0);
            }
            //Konverter (og måske filtrer) data her, så vi kan regne på det i controlleren
            //var convertedData = _conversion.ConvertToPressure(container.BloodPressure);

            //filteredData = _kaliAndZero.AddKalibreringAndZero(container.BloodPressure);
            //filteredData = _filtering.Smoothing(container.BloodPressure);


            BPState = container.BloodPressure;
            //Set eventet sååååå controlleren får at vide den skal læse BPState
            _event.Set();
        }

        public void Run()
        {
            CanRun = true;

            var t1 = new Thread(_dataAccess.StartProducer);
            t1.IsBackground = true;
            t1.Start();

            while (CanRun)
            {
                HandleData();
            }
            if (!CanRun)
            {
                _dataAccess.StopProducer();
            }
        }
    }
}
