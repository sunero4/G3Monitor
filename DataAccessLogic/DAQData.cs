using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ST2Prj2LibNI_DAQ;

namespace DataAccessLogic
{
    public class DAQData
    {
        private NI_DAQVoltage _daq;

        public DAQData(DAQ daq)
        {
            _daq = daq.GetDaq();
        }

        public List<double> GetData()
        {
            _daq.getVoltageSeqBlocking();
            var data = _daq.currentVoltageSeq;

            return data;
        }
    }
}
