using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using DTO;

namespace DataAccessLogic
{
    class CalibrationRetrievalXml : ICalibrationDataRetrieval
    {
        private XDocument _calibrations;
        /// <summary>
        /// Reads values from xml file and maps them to a KalibreringDTO object
        /// </summary>
        /// <returns>The most recent calibration</returns>
        public KalibreringsDTO GetCalibrationData()
        {
            //Load the xml file into our XDocument
            _calibrations = XDocument.Load(FileInformation.FilePath);

            //Get the dates from all calibrations in file
            List<DateTime> dates = (from x in _calibrations.Element("Calibrations")?.Elements("Calibration")
                    select (DateTime)x.Attribute("Time"))
                .ToList();

            //Find the time closest to now, as we use that to retrieve the most recent calibration
            var closestTime = dates.OrderBy(t => Math.Abs((DateTime.Now - t).Ticks)).First();

            //Create calibration DTO with values from xml file
            var kal = new KalibreringsDTO()
            {
                Time = closestTime,
                Technician = GetTechnician(closestTime, _calibrations),
                ExpectedValue = GetExpectedValues(closestTime, _calibrations),
                ActualValue = GetActualValues(closestTime, _calibrations),
                Slope = GetSlope(closestTime, _calibrations),
                Intercept = GetInterCept(closestTime, _calibrations)
            };

            return kal;
        }


        /// <summary>
        /// Gets the username of the technician who made the calibration
        /// </summary>
        /// <param name="closestTime">The time for the most recent calibration</param>
        /// <param name="calibrations">The XDocument containing the calibration data</param>
        /// <returns>Name of the technician who made the calibration corresponding to the
        /// closestTime parameter</returns>
        private string GetTechnician(DateTime closestTime, XDocument calibrations)
        {
            var tech = (from x in calibrations.Element("Calibrations")?.Elements("Calibration")
                where (DateTime)x.Attribute("Time") == closestTime
                select (string)x.Attribute("Technician")).First();

            return tech;
        }

        /// <summary>
        /// Gets all expected values from a certain calibration
        /// </summary>
        /// <param name="closestTime">The time for the most recent calibration</param>
        /// <param name="calibrations">The XDocument containing the calibration data</param>
        /// <returns>All expected values from the calibration corresponding to the
        /// closestTime parameter</returns>
        private List<int> GetExpectedValues(DateTime closestTime, XDocument calibrations)
        {
            var exp = (from x in calibrations.Elements("Calibrations").Elements("Calibration")
                    .Elements("SingleCalibration")
                    where (DateTime)x.Parent.Attribute("Time") == closestTime
                    select (int)x.Element("ExpectedValue")).ToList();

            return exp;
        }

        /// <summary>
        /// Gets all actual values from a certain calibration
        /// </summary>
        /// <param name="closestTime">The time for the most recent calibration</param>
        /// <param name="calibrations">The XDocument containing the calibration data</param>
        /// <returns>All actual values measured from the calibration</returns>
        private List<int> GetActualValues(DateTime closestTime, XDocument calibrations)
        {
            var act = (from x in calibrations.Elements("Calibrations").Elements("Calibration")
                    .Elements("SingleCalibration")
                where (DateTime)x.Parent.Attribute("Time") == closestTime
                select (int)x.Element("ActualValue")).ToList();

            return act;
        }

        /// <summary>
        /// Gets the slope of the linear regression made from the calibration points
        /// </summary>
        /// <param name="closestTime">The time for the most recent calibration</param>
        /// <param name="calibrations">The XDocument containing the calibration data</param>
        /// <returns>The slope of the linear regression made from the calibration points</returns>
        private double GetSlope(DateTime closestTime, XDocument calibrations)
        {
            var slope = (from x in calibrations.Elements("Calibrations")
                    .Elements("Calibration")
                where (DateTime) x.Parent.Attribute("Time") == closestTime
                select (double) x.Element("Slope")).SingleOrDefault();

            return slope;
        }

        /// <summary>
        /// Gets the intercept of the linear regression made from the calibration points
        /// </summary>
        /// <param name="closestTime">The time for the most recent calibration</param>
        /// <param name="calibrations">The XDocument containing the calibration data</param>
        /// <returns>The intercept of the linear regression made from the calibration</returns>
        private double GetInterCept(DateTime closestTime, XDocument calibrations)
        {
            var intercept = (from x in calibrations.Elements("Calibrations")
                    .Elements("Calibration")
                where (DateTime) x.Parent.Attribute("Time") == closestTime
                select (double) x.Element("Slope")).SingleOrDefault();

            return intercept;
        }
    }
}
