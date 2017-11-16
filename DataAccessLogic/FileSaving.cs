using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;
using DTO;

namespace DataAccessLogic
{
    class FileSaving : ISaving
    {
        private XDocument _xDoc;

        /// <summary>
        /// Saves relevant data about the blood pressure, utilizing the two private methods in this class
        /// </summary>
        /// <param name="patient">DTO holding the patient data</param>
        /// <param name="maaling">DTO holding the blood pressure measurement data</param>
        public void SaveBloodPressureData(PatientDTO patient)
        {
            _xDoc = XDocument.Load(FileInformation.FilePath);

            //Select the first or default element for the patient with the given CPR
            var e = _xDoc.Descendants("Maaling")
                .FirstOrDefault(x => (string) x.Attribute("CPR") == patient.CPR);

            //If saving for patient is not already initiated in the XDocument, create a starting tag for it
            if (e == null)
            {
                SaveNewPatient(patient.Maalinger, patient.CPR, _xDoc);
            }
            //Save blood pressure values
            SaveValues(patient.Maalinger, patient.CPR, _xDoc);
        }

        /// <summary>
        /// Used to generate a starting tag for the measuring of a patient
        /// </summary>
        /// <param name="maaling">The DTO holding the values of the blood pressure measuring</param>
        /// <param name="cpr">The cpr-number of the patient in question</param>
        /// <param name="xDoc">The XDocument to save in</param>
        private void SaveNewPatient(MaalingDTO maaling, string cpr, XDocument xDoc)
        {
            var e = xDoc.Root;

            e.Add(new XElement("Maaling",
                new XAttribute("ID", maaling.MaaleID),
                new XAttribute("MaaleTidspunkt", maaling.MaaleTidspunkt),
                new XAttribute("CPR", "cpr"),
                new XElement("Kommentar", maaling.Kommentar)
            ));

            xDoc.Save(FileInformation.FilePath);
        }

        /// <summary>
        /// Saves a block of data from the MaalingDTO to the xml file
        /// </summary>
        /// <param name="maaling">The DTO holding the values of the blood pressure measuring</param>
        /// <param name="cpr">The cpr-number of the patient in question</param>
        /// <param name="xDoc">The XDocument to save in</param>
        private void SaveValues(MaalingDTO maaling, string cpr, XDocument xDoc)
        {

            var e = xDoc.Descendants("Maaling")
                .FirstOrDefault(x => (string) x.Attribute("CPR") == cpr);

            e?.Add(new XElement("Maalingdata", Convert.ToBase64String(maaling.MaaleData)));
            xDoc.Save(FileInformation.FilePath);
        }
    }
}
