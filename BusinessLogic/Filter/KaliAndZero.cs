using System.Collections.Generic;
using DTO;


namespace BusinessLogic.Filter
{
    public class KaliAndZero
    {
        public NulpunktsjusteringDTO Nulpunkt { get { return _nulpunkt; } set { _nulpunkt = value; } }
        private NulpunktsjusteringDTO _nulpunkt;
        private KalibreringsDTO _kalibrering;

        public KaliAndZero(NulpunktsjusteringDTO nulpunkt, KalibreringsDTO kalibrering)
        {
            _nulpunkt = nulpunkt;
            _kalibrering = kalibrering;
        }


        /// <summary>
        /// Adjusts the measured voltages to the corresponding pressure value by utilizing the calibration
        /// and zero point adjustment
        /// </summary>
        /// <param name="containerData">Bloodpressure values as voltage</param>
        /// <returns>Bloodpressure values as pressure</returns>
        public List<double> AddKalibreringAndZero(List<double> containerData)
        {
            var nul = _nulpunkt.Nulpunktsjustering;

            double kali = _kalibrering.Slope;
            for (int i = 0; i < containerData.Count; i++)
            {
                containerData[i] = kali * containerData[i] - (nul * kali);
            }
            return containerData;
        }
    


    }
}

