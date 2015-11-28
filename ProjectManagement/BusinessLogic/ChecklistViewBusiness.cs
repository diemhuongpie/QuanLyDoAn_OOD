using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;
using System.Xml.Linq;
using System.IO;

namespace BusinessLogic
{
    public class ChecklistViewBusiness
    {
        /// <summary>
        /// Save the imported XDocument to the file specified by the strings.
        /// The file saved with the extension as ".req".
        /// IMPORTANT: the file name will be processed by the macros if possible.
        /// </summary>
        /// <param name="checklistDocument">The XDocument parameter contain the checklist tree information</param>
        /// <param name="fullPath">The absolute path with extension specify the file to save the document</param>
        /// <param name="saveType">Save type, see BusinessLogic.SaveType</param>
        /// <returns>
        ///     ERROR_CODE_NONE if save successfull.
        ///     ERROR_CODE_FILE_EXISTS if the file already exists and saveType is SaveType.TRY.
        /// </returns>
        public int SaveChecklistFile(XDocument checklistDocument, string fullPath, SaveType saveType = SaveType.TRY)
        {
            if (File.Exists(fullPath))
            {
                if (saveType == SaveType.TRY)
                {
                    return Config.ERROR_CODE_FILE_EXISTS;
                }
            }

            checklistDocument.Save(fullPath);

            return Config.ERROR_CODE_NONE;
        }

        /// <summary>
        /// Create an XML-formed data-type from the imported TreeView.
        /// </summary>
        /// <param name="checklistTree">the checklist tree used to generate the file.</param>
        /// <returns>an XDocument contain the checklist tree information.</returns>
        public XDocument GenerateChecklistFile(TreeView checklistTree)
        {
            XDocument result = new XDocument(new XElement(Config.XML_KEY_HEAD_REQUEST));

            foreach (TreeNode node in checklistTree.Nodes)
            {
                result.Add(GenerateCheclistElementFromNode(node));
            }

            return result;
        }

        /// <summary>
        /// Create an XElement from a TreeNode.
        /// IMPORTANT: in case the node is not the leaf,
        /// this method will be recursive-called for the final result.
        /// </summary>
        /// <param name="checklistNode">the node used to generate the element.</param>
        /// <returns>an XElement contain the node and all of it's childs information.</returns>
        private XElement GenerateCheclistElementFromNode(TreeNode checklistNode)
        {
            XElement result = new XElement(Config.XML_KEY_SUB_REQUEST,
                new XElement(Config.XML_KEY_REQUEST_NAME, checklistNode.Text));

            foreach (TreeNode node in checklistNode.Nodes)
            {
                result.Add(GenerateCheclistElementFromNode(node));
            }

            return result;
        }
    }
}
