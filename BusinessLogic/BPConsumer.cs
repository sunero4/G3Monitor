using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Interfaces;
using ObserverPattern;

namespace BusinessLogic
{
    public class BPConsumer : MeasurementSubjectBL
    {
        private ConcurrentQueue<BPDataContainer> _queue;
        private AutoResetEvent _event;
        public List<double> BPState { get; set; }
        private VoltageToPressureConversion _conversion;
        private IDataAccess _dataAccess;

        public bool CanRun { get; set; }

        public BPConsumer(ConcurrentQueue<BPDataContainer> queue, IDataAccess dataAccess, AutoResetEvent autoResetEvent)
        {
            _queue = queue;
            _conversion = new VoltageToPressureConversion();
            _dataAccess = dataAccess;
            _event = autoResetEvent;
        }

        public void HandleData()
        {
            BPDataContainer container;
            while (!_queue.TryDequeue(out container))
            {
                Thread.Sleep(0);
            }
            //Konverter (og måske filtrer) data her, så vi kan regne på det i controlleren
            //var convertedData = _conversion.ConvertToPressure(container.BloodPressure);
            BPState = container.BloodPressure;
            //Set eventet sååååå controlleren får at vide den skal læse BPState
            _event.Set();
        }

        public void Run()
        {
            CanRun = true;
            while (CanRun)
            {
                HandleData();
            }
        }
    }
}
