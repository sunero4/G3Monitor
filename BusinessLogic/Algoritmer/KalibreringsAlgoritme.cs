using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Accord.Math;
using Accord.Statistics.Models.Regression.Linear;
using DTO;
using Interfaces;
using DataAccessLogic;

namespace BusinessLogic
{
    class KalibreringsAlgoritme: IKalibrering
    {
        private IDataAccess _iDataAccess;
        private KalibreringsDTO _kalibreringsDto;
        public KalibreringsAlgoritme()
        {
            //_iDataAccess = new SCDataAcess();
            _kalibreringsDto = new KalibreringsDTO();
        }

        public void CalibrateSystem(KalibreringsDTO calibration)
        {
            List<double> expected = calibration.ExpectedValue.Select<int, double>(i => i).ToList();
            List<double> actual = calibration.ActualValue.Select(i => i).ToList();

            OrdinaryLeastSquares ols = new OrdinaryLeastSquares();
            SimpleLinearRegression linearRegression = ols.Learn(actual.ToArray(), expected.ToArray());

            double slope = linearRegression.Slope;
            double intercept = linearRegression.Intercept;

            calibration.Slope = slope;
            calibration.Intercept = intercept;
        }

    }
}
