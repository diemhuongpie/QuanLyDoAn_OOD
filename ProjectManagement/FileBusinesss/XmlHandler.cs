using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace FileBusiness
{
    public class XmlHandler
    {
        public static bool writeToFile(string fullPath, XDocument document, bool overrideAuthencation)
        {
            if (File.Exists(fullPath) && !overrideAuthencation)
            {
                return false;
            }

            document.Save(fullPath);
            return true;
        }

        /// <summary>
        /// Generate an XDocument by the data read from the XML file specified in the path.
        /// </summary>
        /// <param name="fullPath">Apsolute path to xml file.</param>
        /// <param name="nodeName">Name of the node in the file which will be read.</param>
        /// <returns>XDocument file contain the data have read</returns>
        public static XDocument readFromFile(string fullPath, string nodeName)
        {
            XDocument result = new XDocument();
            XmlReader reader = XmlReader.Create(fullPath);

            if (reader.Read())
            {
                reader.MoveToContent();
                if (reader.Name == nodeName)
                {
                    result = XDocument.Load(reader);
                }
                else
                {
                    //TODO: file does not contain any requirement.
                }
            }

            return result;
        }
    }
}
