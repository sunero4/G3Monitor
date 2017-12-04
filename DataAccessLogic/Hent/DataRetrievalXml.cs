using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            var xDoc = XDocument.Load(FileInformation.FilePath);

            var e = (from x in xDoc.Descendants("Operations").Elements("Operation")
                where (string) x.Attribute("CPR") == patient.CPR
                select x).ToList();

            var operation = new OperationsDTO()
            {
                OperationsID = (int) e[0].Parent.Attribute("OperationsId"),
                Maaling = new List<MaalingDTO>()
            };

            for (int i = 0; i < e.Count; i++)
            {
                var m = new MaalingDTO()
                {
                    MaaleData = Convert.FromBase64String(e[i].Value),
                    Sekvensnr = Convert.ToInt32(e[i].Attribute("SekvensNr"))
                };
                operation.Maaling.Add(m);
            }
            return operation;
        }
    }
}
