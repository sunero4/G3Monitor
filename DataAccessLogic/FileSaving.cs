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
        public void SaveNewPatient(MaalingDTO maaling, string cpr)
        {
            _xDoc = XDocument.Load(FileInformation.FilePath);

            var e = _xDoc.Root;

            e.Add(new XElement("Maaling"),
                new XAttribute("ID", maaling.MaaleID),
                new XAttribute("MaaleTidspunkt", maaling.MaaleTidspunkt),
                new XAttribute("CPR", cpr)
                );
            e.Add(new XElement("Kommentar", maaling.Kommentar));

            _xDoc.Save(FileInformation.FilePath);
        }

        public void SaveValues(MaalingDTO maaling, string cpr)
        {
            _xDoc = XDocument.Load(FileInformation.FilePath);

            var e = _xDoc.Descendants("Maaling")
                .FirstOrDefault(x => (string) x.Attribute("CPR") == cpr);

            if (e != null)
            {
                e.Add(new XElement("Maalingdata", Convert.ToBase64String(maaling.MaaleData)));
            }
            _xDoc.Save(FileInformation.FilePath);
        }

    }
}
