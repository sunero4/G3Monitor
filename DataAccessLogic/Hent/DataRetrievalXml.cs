using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;
using DTO;

namespace DataAccessLogic.Hent
{
    public class DataRetrievalXml : IRetrievedData<OperationsDTO>
    {
        /// <summary>
        /// Gets all measurement data stored in the file with the corresponding cpr number
        /// </summary>
        /// <param name="cpr">The patients cpr number</param>
        /// <returns>Operation DTO containing all retrieved information</returns>
        public OperationsDTO HentData(PatientDTO patient)
        {
            try
            {
                var xDoc = XDocument.Load(FileInformation.BPFilePath);

                var e = (from x in xDoc.Descendants("Operationer").Elements("Operation")
                    where (string)x.Attribute("CPR") == patient.CPR
                    select x).ToList();

                var operation = new OperationsDTO()
                {
                    OperationsID = (int)e[0]?.Attribute("OperationsId"),
                    Maaling = new List<MaalingDTO>()
                };

                var data = (from x in e.Elements("Maalingdata")
                    select x).ToList();

                foreach (var element in data)
                {
                    var measurement = element.Value;
                    var m = new MaalingDTO()
                    {
                        MaaleData = Convert.FromBase64String(measurement),
                        Sekvensnr = Convert.ToInt32((string)element.Attribute("SekvensNr"))
                    };
                    operation.Maaling.Add(m);
                }

                return operation;
            }
            catch (Exception exception)
            {
                return null;
            }
          
        }
    }
}
