using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace BusinessLogic
{
    public class Nulpunktsjustering
    {
        private VoltageToPressureConversion _conversion;

        public Nulpunktsjustering()
        {
            _conversion = new VoltageToPressureConversion();
        }

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
