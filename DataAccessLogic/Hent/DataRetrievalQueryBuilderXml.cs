using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;

namespace DataAccessLogic
{
    class DataRetrievalQueryBuilderXml : IXmlQueryBuilder<IEnumerable<string>>
    {
        private XDocument _xDoc;
        /// <summary>
        /// Returns the measurement data from the file
        /// </summary>
        /// <returns>Measurement data</returns>
        public IEnumerable<string> BuildQuery()
        {
            _xDoc = new XDocument(FileInformation.BPFilePath);

            var e1 = (from x in _xDoc.Element("Calibrations")?.Elements("Calibration")
                select (string) x.Element("Maaledata"));

            return e1;
        }
    }
}
