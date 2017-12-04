using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;
using DTO;

namespace DataAccessLogic
{
    class FileSaving : ISaving
    {
        public void SaveBloodPressureData(PatientDTO patient)
        {
            foreach (var m in patient.ListOperation[0].Maaling)
            {
                SaveData(patient.CPR, m, patient.ListOperation[0].OperationsID);
            }
        }

        /// <summary>
        /// Generates new operation tag if one doesn't already exist
        /// </summary>
        /// <param name="operationsid">Id for the current operation</param>
        /// <param name="cpr">CPR number for the patient</param>
        private void SaveNewPatient(int operationsid, string cpr)
        {
            var xdoc = XDocument.Load(FileInformation.FilePath);

            var e = xdoc.Root;
            e?.Add(new XElement("Operation", new XAttribute("OperationsId", operationsid), new XAttribute("CPR", cpr)));

            xdoc.Save(FileInformation.FilePath);
        }

        /// <summary>
        /// Saves measurement data and sequence number for given operation
        /// </summary>
        /// <param name="cpr">The CPR number for the patient</param>
        /// <param name="maaling">The measurement DTO holding measurement data</param>
        /// <param name="operationsId">Id for the current operation</param>
        public void SaveData(string cpr, MaalingDTO maaling, int operationsId)
        {
            var xDoc = XDocument.Load(FileInformation.FilePath);


            var e = xDoc.Descendants("Operation")
                .FirstOrDefault(x => (string)x.Attribute("CPR") == cpr);

            if (e == null)
            {
                SaveNewPatient(operationsId, cpr);
                xDoc = XDocument.Load(FileInformation.FilePath);
            }

            e = xDoc.Descendants("Operation")
                .FirstOrDefault(x => (string)x.Attribute("CPR") == cpr);

            e?.Add(new XElement("Maalingdata", Convert.ToBase64String(maaling.MaaleData), 
                new XAttribute("SekvensNr", maaling.Sekvensnr)));

            xDoc.Save(FileInformation.FilePath);
        }
    }
}
