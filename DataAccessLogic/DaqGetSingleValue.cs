using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ST2Prj2LibNI_DAQ;

namespace DataAccessLogic
{
    public class DaqGetSingleValue
    {
        private NI_DAQVoltage _daq;

        public DaqGetSingleValue()
        {
            _daq = new NI_DAQVoltage()
            {
                deviceName = "Dev3/ai0",
                rangeMinimumVolt = 0,
                rangeMaximumVolt = 5,
                sampleRateInHz = 1000,
                samplesPerChannel = 1000
            };
        }


        public double GetSingleValue()
        {
            _daq.getVoltageSeqBlocking();

            var value = _daq.currentVoltageSeq;

            return value.Average();
        }
    }
}
