using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;
using DTO;

namespace DataAccessLogic
{
    class SaveCalibrationXml : ISaveCalibration
    {
        public void Save(KalibreringsDTO kalibrering)
        {
            try
            {
                var xDoc = XDocument.Load(FileInformation.FilePath);

                var e = xDoc.Root;

                e?.Add(new XElement("Calibration",
                    new XAttribute("Time", kalibrering.Time.Date),
                    new XAttribute("Technician", kalibrering.Technician)));

                var e1 = xDoc.Descendants("Calibration")
                    .FirstOrDefault(x => (DateTime)x.Attribute("Time") == kalibrering.Time);

                for (int i = 0; i < kalibrering.ActualValue.Count; i++)
                {
                    var e2 = new XElement("CalibrationValues");

                    e2.Add(new XElement("ExpectedValue", kalibrering.ExpectedValue[i]),
                        new XElement("ActualValue", kalibrering.ActualValue[i]));

                    if (e1 != null)
                        e1.Add(e2);
                }

                xDoc.Save(FileInformation.FilePath);

            }
            catch (XmlException exception)
            {
                //Exception handling here
                Console.WriteLine(exception.Message);
            }
            
        }
    }
}
