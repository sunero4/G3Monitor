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
        private XDocument _xDoc;


        //public void SaveBloodPressureData(PatientDTO patient)
        //{
        //    //_xDoc = XDocument.Load(FileInformation.FilePath);

        //    ////Select the first or default element for the patient with the given CPR
        //    //var e = _xDoc.Descendants("Maaling")
        //    //    .FirstOrDefault(x => (string) x.Attribute("CPR") == patient.CPR);

        //    ////If saving for patient is not already initiated in the XDocument, create a starting tag for it
        //    //if (e == null)
        //    //{
        //    //    SaveNewPatient(patient.Maalinger, patient.CPR, _xDoc);
        //    //}
        //    ////Save blood pressure values
        //    //SaveValues(patient.Maalinger, patient.CPR, _xDoc);
        //}

        /// <summary>
        /// Used to generate a starting tag for the measuring of a patient
        /// </summary>
        /// <param name="maaling">The DTO holding the values of the blood pressure measuring</param>
        /// <param name="cpr">The cpr-number of the patient in question</param>
        /// <param name="xDoc">The XDocument to save in</param>
        //private void SaveNewPatient(, string cpr, XDocument xDoc)
        //{
        //    //var e = xDoc.Root;

        //    //e.Add(new XElement("Maaling",
        //    //    new XAttribute("ID", maaling.MaaleID),
        //    //    new XAttribute("MaaleTidspunkt", maaling.MaaleTidspunkt),
        //    //    new XAttribute("CPR", "cpr"),
        //    //    new XElement("Kommentar", maaling.Kommentar)
        //    //));

        //    //xDoc.Save(FileInformation.FilePath);
        //}


        public void SaveBloodPressureData(PatientDTO patient)
        {
            foreach (var m in patient.ListOperation[0].Maaling)
            {
                SaveData(patient.CPR, m, patient.ListOperation[0].OperationsID);
            }
        }

        private void SaveNewPatient(int operationsid)
        {
            var xdoc = XDocument.Load(FileInformation.FilePath);

            var e = xdoc.Root;
            e?.Add(new XElement("Operation", new XAttribute("OperationsId", operationsid)));

            xdoc.Save(FileInformation.FilePath);
        }

        public void SaveData(string cpr, MaalingDTO maaling, int operationsId)
        {
            var xDoc = XDocument.Load(FileInformation.FilePath);


            var e = xDoc.Descendants("Operation")
                .FirstOrDefault(x => (string)x.Attribute("CPR") == cpr);

            if (e == null)
            {
                SaveNewPatient(operationsId);
            }

            e = xDoc.Descendants("Operation")
                .FirstOrDefault(x => (string)x.Attribute("CPR") == cpr);

            e?.Add(new XElement("Maalingdata", maaling.MaaleData, 
                new XAttribute("SekvensNr", maaling.Sekvensnr)));

            xDoc.Save(FileInformation.FilePath);
        }
    }
}
