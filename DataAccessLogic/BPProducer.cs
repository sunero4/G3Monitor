using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ObserverPattern;

namespace DataAccessLogic
{
    public class BPProducer
    {
        private ConcurrentQueue<BPDataContainer> _queue;
        private DAQData _daq;
        public BPProducer(ConcurrentQueue<BPDataContainer> queue, DAQData daq)
        {
            _queue = queue;
            _daq = daq;
        }

        public List<double> MeasureBP()
        {
            var data = _daq.GetData();

            return data;
        }

        public void GetData()
        { 
            var container = new BPDataContainer();
            while (true)
            {
                container.BloodPressure = MeasureBP();
                _queue.Enqueue(container);
            }
        }
    }
}
