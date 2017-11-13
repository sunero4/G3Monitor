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
        public KalibreringsDTO GetCalibrationData()
        {

            var calibrations = XDocument.Load(FileInformation.FilePath);


            List<DateTime> dates = (from x in calibrations.Element("Calibrations").Elements("Calibration")
                    select (DateTime)x.Attribute("Time"))
                .ToList();

            var closestTime = dates.OrderBy(t => Math.Abs((DateTime.Now - t).Ticks)).First();
            Console.WriteLine(closestTime);

            var result = (from x in calibrations.Element("Calibrations").Elements("Calibration")
                select (string)x.Attribute("Technician")).First();

            var kal = new KalibreringsDTO()
            {
                
            }
        }
    }
}
