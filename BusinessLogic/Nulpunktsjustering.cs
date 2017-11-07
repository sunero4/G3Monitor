using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace BusinessLogic
{
    class Nulpunktsjustering
    {
        private VoltageToPressureConversion _conversion;
        public NulpunktsjusteringDTO PerformAdjustment(double voltage)
        {
            var result = new NulpunktsjusteringDTO()
            {
                Nulpunktsjustering = _conversion.ConvertToPressure(voltage)
            };
            return result;
        }


    }
}
