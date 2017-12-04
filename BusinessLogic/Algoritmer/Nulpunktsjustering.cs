using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using Interfaces;

namespace BusinessLogic
{
    public class Nulpunktsjustering
    {
        private VoltageToPressureConversion _conversion;
        private IDataAccess _dataAccess;

        public Nulpunktsjustering(IDataAccess dataAccess)
        {
            _conversion = new VoltageToPressureConversion();
            _dataAccess = dataAccess;
        }

        public NulpunktsjusteringDTO PerformAdjustment(double voltage)
        {
            var nulpunkt = new NulpunktsjusteringDTO();
            nulpunkt.Nulpunktsjustering = _dataAccess.GetSinglePressureValue();

            return nulpunkt;
        }


    }
}
