using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
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

        public double GetCalibrationPoint()
        {
            var value = _dataAccess.GetSinglePressureValue();

            return value;
        }

    }
}
