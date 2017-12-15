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

        /// <summary>
        /// Gets DTO holding the value measured
        /// </summary>
        /// <returns>DTO holding the value measured</returns>
        public NulpunktsjusteringDTO PerformAdjustment()
        {
            var nulpunkt = new NulpunktsjusteringDTO();
            nulpunkt.Nulpunktsjustering = _dataAccess.GetSinglePressureValue();

            return nulpunkt;
        }


    }
}
