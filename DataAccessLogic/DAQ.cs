using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ST2Prj2LibNI_DAQ;

namespace DataAccessLogic
{
    public class DAQ
    {
        private NI_DAQVoltage _daq;

        public DAQ()
        {
            _daq = new NI_DAQVoltage()
            {
                deviceName = "Dev2/ai0",
                rangeMinimumVolt = 0,
                rangeMaximumVolt = 5,
                sampleRateInHz = 1000,
                samplesPerChannel = 200
            };
        }

        public NI_DAQVoltage GetDaq()
        {
            return _daq;
        }

    }
}
