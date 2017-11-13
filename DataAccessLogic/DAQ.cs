using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ST2Prj2LibNI_DAQ;

namespace DataAccessLogic
{
    class DAQ
    {
        private NI_DAQVoltage _daq;

        public DAQ()
        {
            _daq = new NI_DAQVoltage()
            {
                //Jeg kan ikke huske, hvad den skal stå på, men opsætning af DAQ her
            };
        }

        public NI_DAQVoltage GetDaq()
        {
            return _daq;
        }

    }
}
