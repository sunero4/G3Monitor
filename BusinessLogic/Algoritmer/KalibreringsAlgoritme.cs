using System.Collections.Generic;
using System.Linq;
using Accord.Statistics.Models.Regression.Linear;
using DTO;

namespace BusinessLogic
{
    class KalibreringsAlgoritme: IKalibrering
    {
        /// <summary>
        /// Calculates a slope and intercept from the calibration points in the DTO
        /// </summary>
        /// <param name="calibration">Class holding the values of the calibration points</param>
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
