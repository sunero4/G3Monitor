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
    class KalibreringsAlgoritme
    {
        private IDataAccess _iDataAccess;
        private KalibreringsDTO _kalibreringsDto;
        public KalibreringsAlgoritme()
        {
            _iDataAccess = new SCDataAcess();
            
            _kalibreringsDto = new KalibreringsDTO();
        }

        public void calibrateSystem()
        {
          
            List<double> expected = _kalibreringsDto.ExpectedValue.Select<int, double>(i => i).ToList();
            List<double> actual = _kalibreringsDto.ActualValue.Select<int, double>(i => i).ToList();

            OrdinaryLeastSquares ols = new OrdinaryLeastSquares();
            SimpleLinearRegression _linearRegression = ols.Learn(expected.ToArray(), actual.ToArray());

            double slope = _linearRegression.Slope;
            double intercept = _linearRegression.Intercept;

            _kalibreringsDto.Slope = slope;
            _kalibreringsDto.Intercept = intercept;

            _iDataAccess.uploadCalibation(_kalibreringsDto); // opdateres af Anders - evt. andet metodenavn
        }
    }
}
