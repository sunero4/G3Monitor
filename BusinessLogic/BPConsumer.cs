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
    public class BPConsumer
    {
        private ConcurrentQueue<BPDataContainer> _queue;
        public List<double> BPState { get; set; }
        private VoltageToPressureConversion _conversion;


        public BPConsumer(ConcurrentQueue<BPDataContainer> queue)
        {
            _queue = queue;
            _conversion = new VoltageToPressureConversion();
        }

        public void HandleData()
        {
            BPDataContainer container;
            while (!_queue.TryDequeue(out container))
            {
                Thread.Sleep(0);
            }
            var convertedData = _conversion.ConvertToPressure()
            BPState = container.BloodPressure;
        }
    }
}
