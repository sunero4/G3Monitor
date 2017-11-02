using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using DTO;

namespace DataAccessLogic
{
    class FileSaving : ISaving
    {
        public void SaveBloodPressureData(PatientDTO patient)
        {
            XDocument xDoc = new XDocument(FileInformation.FilePath);

            XElement xElement = new XElement(xDoc.Root);

        }
    }
}
