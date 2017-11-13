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
                ActualValue = GetActualValues(closestTime, _calibrations)
            };

            return kal;
        }


        private string GetTechnician(DateTime closestTime, XDocument calibrations)
        {
            var tech = (from x in calibrations.Element("Calibrations")?.Elements("Calibration")
                where (DateTime)x.Attribute("Time") == closestTime
                select (string)x.Attribute("Technician")).First();

            byte[] mtinn = new byte[5];

            return tech;
        }

        private List<int> GetExpectedValues(DateTime closestTime, XDocument calibrations)
        {
            var exp = (from x in calibrations.Elements("Calibrations").Elements("Calibration")
                    .Elements("SingleCalibration")
                    where (DateTime)x.Parent.Attribute("Time") == closestTime
                    select (int)x.Element("ExpectedValue")).ToList();

            return exp;
        }

        private List<int> GetActualValues(DateTime closestTime, XDocument calibrations)
        {
            var act = (from x in calibrations.Elements("Calibrations").Elements("Calibration")
                    .Elements("SingleCalibration")
                where (DateTime)x.Parent.Attribute("Time") == closestTime
                select (int)x.Element("ActualValue")).ToList();

            return act;
        }
    }
}
