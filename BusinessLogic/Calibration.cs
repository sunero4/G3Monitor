using Interfaces;

namespace BusinessLogic
{
    public class Calibration
    {
        private KalibreringsAlgoritme _kalibreringsAlgoritme;
        private IDataAccess _dataAccess;

        public Calibration(IDataAccess dataAccess)
        {
            _kalibreringsAlgoritme = new KalibreringsAlgoritme();
            _dataAccess = dataAccess;
        }

        /// <summary>
        /// Gets a single pressure value from the transducer (average over a second)
        /// </summary>
        /// <returns>Single pressure value</returns>
        public double GetCalibrationPoint()
        {
            var value = _dataAccess.GetSinglePressureValue();

            return value;
        }

    }
}
