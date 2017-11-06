using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;
using DTO;

namespace DataAccessLogic
{
    class FileSaving : ISaving
    {
        public void SaveBloodPressureData(PatientDTO patient)
        {
            try
            {
                var xSerializer = new XmlSerializer(typeof(PatientDTO));

                using (var writer = new StreamWriter(FileInformation.FilePath))
                {
                    xSerializer.Serialize(writer, patient);
                }
            }
            catch (XmlException e)
            {
                Console.WriteLine(e.Message);
                //Handle exception here
            }

        }
    }
}
