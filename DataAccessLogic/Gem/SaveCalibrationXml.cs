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
        /// <summary>
        /// Saves calibration data
        /// </summary>
        /// <param name="kalibrering">DTO holding the calibration values</param>
        public void Save(KalibreringsDTO kalibrering)
        {
            try
            {
                var xDoc = XDocument.Load(FileInformation.CalibrationFilePath);

                var e = xDoc.Root;

                //If root element is not null, add new element "Calibration" with two attributes,
                //time and technician
                e?.Add(new XElement("Calibration",
                    new XAttribute("Time", kalibrering.Time),
                    new XAttribute("Technician", kalibrering.Technician)));


                //Get the time attribute closest to now, to get the most recent calibration
                var e1 = xDoc.Descendants("Calibration")
                    .FirstOrDefault(x => (DateTime)x.Attribute("Time") == kalibrering.Time);

                if (e1 != null)
                {
                    e1.Add(new XElement("Slope", kalibrering.Slope));
                    e1.Add(new XElement("Intercept", kalibrering.Intercept));
                    //Save all the expected and actual values
                    for (int i = 0; i < kalibrering.ActualValue.Count; i++)
                    {
                        var e2 = new XElement("CalibrationValues");

                        e2.Add(new XElement("ExpectedValue", kalibrering.ExpectedValue[i]),
                            new XElement("ActualValue", kalibrering.ActualValue[i]));

                        e1.Add(e2);
                    }
                }

                xDoc.Save(FileInformation.CalibrationFilePath);

            }
            catch (XmlException exception)
            {
                //Exception handling here
                Console.WriteLine(exception.Message);
            }
            
        }
    }
}
