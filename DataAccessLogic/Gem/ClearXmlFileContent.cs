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
            var xDoc = XDocument.Load(FileInformation.BPFilePath);

            var root = xDoc.Root;

            root?.RemoveAll();

            xDoc.Save(FileInformation.BPFilePath);
        }
    }
}
