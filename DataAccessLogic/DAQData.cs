using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ObserverPattern;
using ST2Prj2LibNI_DAQ;

namespace DataAccessLogic
{
    public class DAQData
    {

        private ConcurrentQueue<BPDataContainer> _queue;
        private NI_DAQVoltage _daq;

        public DAQData(DAQ daq, ConcurrentQueue<BPDataContainer> queue)
        {
            _daq = daq.GetDaq();
            _queue = queue;
        }

        public List<double> GetData()
        {
            _daq.getVoltageSeqBlocking();
            var data = _daq.currentVoltageSeq;

            return data;
        }

        public void Start()
        {
            var container = new BPDataContainer();

            while (true)
            {
                container.BloodPressure = GetData();
                _queue.Enqueue(container);
            }
        }
    }
}
