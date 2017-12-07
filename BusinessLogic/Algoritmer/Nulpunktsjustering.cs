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
        private IDataAccess _dataAccess;

        public Nulpunktsjustering(IDataAccess dataAccess)
        {
            _dataAccess = dataAccess;
        }

        public NulpunktsjusteringDTO PerformAdjustment()
        {
            var nulpunkt = new NulpunktsjusteringDTO();
            nulpunkt.Nulpunktsjustering = _dataAccess.GetSinglePressureValue();

            return nulpunkt;
        }


    }
}
