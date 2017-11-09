using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using DTO;

namespace DataAccessLogic
{
    class CalibrationRetrieval : ICalibrationDataRetrieval
    {
        public KalibreringsDTO GetCalibrationData()
        {
            var calibrations = XDocument.Load(FileInformation.FilePath);

            
        }
    }
}
