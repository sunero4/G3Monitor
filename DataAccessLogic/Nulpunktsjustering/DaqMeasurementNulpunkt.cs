using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ST2Prj2LibNI_DAQ;

namespace DataAccessLogic
{
    class DaqMeasurementNulpunkt : IDaqMeasurement
    {
        private readonly NI_DAQVoltage _daq;
        public DaqMeasurementNulpunkt(NI_DAQVoltage daq)
        {
            _daq = daq;
        }

        /// <summary>
        /// Gets the measured voltage from the DAQ for the specified time/samplerate
        /// </summary>
        /// <returns>The average voltage for the measured sequence</returns>
        public double GetVoltage()
        {
            _daq.getVoltageSeqBlocking();

            var meanPressure = _daq.currentVoltageSeq.Average();

            return meanPressure;
        }
    }
}
