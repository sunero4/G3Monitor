using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class VoltageToPressureConversion
    {
        private readonly double _supplyVoltage;
        private readonly double _sensitivy;
        private readonly double _gain;

        public VoltageToPressureConversion()
        {
            _supplyVoltage = 5;
            _sensitivy = 0.000005;
            _gain = 909.09;
        }

        /// <summary>
        /// The transducer has a sensitivity of 5 μV / V / mmHg, meaning that 1 mmHg of pressure equals 5μV times
        /// our supply voltage, which is 5 V. We do amplify our voltage with a gain of 909.09 though, so we
        /// divide by that factor to get the pressure
        /// </summary>
        /// <param name="voltage">Voltage received from the DAQ</param>
        /// <returns></returns>
        public double ConvertToPressure(double voltage)
        {
            var pressure = (voltage / (_supplyVoltage * _sensitivy)) / _gain;
            return pressure;
        }


    }
}
