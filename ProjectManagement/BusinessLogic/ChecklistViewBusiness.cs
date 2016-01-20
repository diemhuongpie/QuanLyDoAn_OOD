using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;
using System.Xml.Linq;
using System.Xml;
using System.IO;

using FileBusiness;

namespace BusinessLogic
{
    public enum PriorityIconIndex
    {
        PRIORITY_NONE = 0,
        PRIORITY_MOST,
        PRIORITY_1 = PRIORITY_MOST,
        PRIORITY_2,
        PRIORITY_3,
        PRIORITY_4,
        PRIORITY_5,
        PRIORITY_LEAST = PRIORITY_5
    }

    public class ChecklistViewBusiness
    {
        private class RequestDataObject
        {
            public RequestDataObject()
            {
                m_name = null;
                m_priority = 0;
            }

            public void SetName(string name)
            {
                m_name = name;
            }

            public void SetPriority(int priority)
            {
                m_priority = priority;
            }

            public TreeNode GenerateNode()
            {
                TreeNode result = new TreeNode();
                result.Text = m_name;
                //TODO: business for priority.

                return result;
            }

            private string m_name;
            private int m_priority;
        }

        private enum XmlObjectProcessStatus
        {
            INVALID = -1,
            PROCESSING,
            DONE
        }

        public TreeNode CreateRequest(string text, 
            PriorityIconIndex priority = PriorityIconIndex.PRIORITY_NONE, 
            bool status = false,
            string desc = "")
        {
            TreeNode result = new TreeNode();
            result.Text = text;
            result.ImageIndex
                = result.SelectedImageIndex
                = (int)priority;
            result.Checked = status;
            result.ToolTipText = desc;

            return result;
        }

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
            bool isExportSuccessful = FileBusiness.XmlHandler.writeToFile(fullPath, checklistDocument, saveType == SaveType.OVERRIDE);
            if (!isExportSuccessful)
            {
                return Config.ERROR_CODE_FILE_NOT_EXISTS;
            }

            return Config.ERROR_CODE_NONE;
        }

        /// <summary>
        /// Create an XML-formed data-type from the imported TreeView.
        /// </summary>
        /// <param name="checklistTree">the checklist tree used to generate the file.</param>
        /// <returns>an XDocument contain the checklist tree information.</returns>
        public XDocument GenerateChecklistDocument(TreeView checklistTree)
        {
            XElement requestTree = new XElement(Config.XML_KEY_HEAD_REQUEST);
            XDocument result = new XDocument(requestTree);

            foreach (TreeNode node in checklistTree.Nodes)
            {
                requestTree.Add(GenerateCheclistElementFromNode(node));
            }

            return result;
        }

        /// <summary>
        /// The method to generate a TreeView as checklist tree from the file specified by the path.
        /// </summary>
        /// <param name="fullPath">Path to ".req" file to read.</param>
        /// <returns>A TreeView as checklist tree</returns>
        public TreeView GenerateChecklistTree(string fullPath)
        {
            TreeView result = new TreeView();
            XDocument data = FileBusiness.XmlHandler.readFromFile(fullPath, BusinessLogic.Config.XML_KEY_HEAD_REQUEST);

            foreach (XElement elem in data.Root.Elements(BusinessLogic.Config.XML_KEY_SUB_REQUEST))
            {
                result.Nodes.Add(ReadXmlChildNode(elem));
            }
            
            return result;
        }

        /// <summary>
        /// Read the node and it child into a TreeNode.
        /// </summary>
        /// <param name="node">XElement contain node data</param>
        /// <returns>Generated TreeNode</returns>
        private TreeNode ReadXmlChildNode(XElement node)
        {
            TreeNode result = CreteTreeNodeFromElement(node);

            foreach (XElement child in node.Elements())
            {
                result.Nodes.Add(ReadXmlChildNode(child));
            }

            return result;
        }

        /// <summary>
        /// Create an requirement TreeNode from XElement.
        /// </summary>
        /// <param name="elem">XElement contain requirement data</param>
        /// <returns>Generated TreeNode</returns>
        private TreeNode CreteTreeNodeFromElement(XElement elem)
        {
            string name;
            PriorityIconIndex priority;
            bool isDone;
            string desc;

            XName attributeName = XName.Get(BusinessLogic.Config.XML_KEY_REQUEST_NAME);
            name = elem.Attribute(attributeName).Value;

            attributeName = XName.Get(BusinessLogic.Config.XML_KEY_REQUEST_PRIORITY);
            priority = (PriorityIconIndex)int.Parse(elem.Attribute(attributeName).Value);

            attributeName = XName.Get(BusinessLogic.Config.XML_KEY_REQUEST_ISDONE);
            isDone = bool.Parse(elem.Attribute(attributeName).Value);

            desc = elem.Value;

            return CreateRequest(name, priority, isDone, desc);
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
            object[] attribute = {
                new XAttribute(Config.XML_KEY_REQUEST_NAME, checklistNode.Text),
                new XAttribute(Config.XML_KEY_REQUEST_PRIORITY, checklistNode.SelectedImageIndex.ToString()),
                new XAttribute(Config.XML_KEY_REQUEST_ISDONE, checklistNode.Checked.ToString())
            };

            XElement result = new XElement(Config.XML_KEY_SUB_REQUEST, attribute);
            result.Value = checklistNode.ToolTipText;

            foreach (TreeNode node in checklistNode.Nodes)
            {
                result.Add(GenerateCheclistElementFromNode(node));
            }

            return result;
        }
    }
}
