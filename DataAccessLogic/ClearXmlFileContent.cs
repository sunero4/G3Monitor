using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DataAccessLogic
{
    public class ClearXmlFileContent : IDataRemoval
    {

        /// <summary>
        /// Deletes all content from the file except the root node
        /// </summary>
        public void ClearData()
        {
            ClearFile();
        }

        /// <summary>
        /// Deletes all content from the file except the root node
        /// </summary>
        private void ClearFile()
        {
            var xDoc = XDocument.Load(FileInformation.FilePath);

            var root = xDoc.Root;

            root?.RemoveAll();

            xDoc.Save(FileInformation.FilePath);
        }
    }
}
