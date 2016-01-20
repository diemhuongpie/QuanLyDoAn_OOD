using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using BusinessLogic;
using System.Xml.Linq;
using Presentation.Forms;

namespace Presentation.Controls
{
    public partial class ChecklistView : UserControl
    {
        ChecklistViewBusiness m_business = new ChecklistViewBusiness();
        private List<TreeNode> m_selectedNodes = new List<TreeNode>();

        public ChecklistView()
        {
            InitializeComponent();
        }

        private void m_remove_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem item = (ToolStripMenuItem)sender;

            if (m_requestTree.SelectedNode != null)
            {
                m_requestTree.SelectedNode.Remove();
                m_requestTree.SelectedNode = null;
            }
        }

        private void m_newSubRequest_Click(object sender, EventArgs e)
        {
            TreeNode node = m_business.CreateRequest(BusinessLogic.Config.DEFAULT_STRING_NEW_REQUEST);
            node.ContextMenuStrip = m_requestContexMenu;

            if (m_requestTree.SelectedNode != null)
            {
                m_requestTree.SelectedNode.Nodes.Add(node);
                m_requestTree.SelectedNode.Expand();
            }
            else
            {
                m_requestTree.Nodes.Add(node);
            }

            node.BeginEdit();
        }

        private void renameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (m_requestTree.SelectedNode != null)
            {
                m_requestTree.SelectedNode.BeginEdit();
            }
        }

        private void deselecting(object sender, EventArgs e)
        {
            // Deprecated
            //m_requestTree.SelectedNode = null;
        }

        public void deactivate()
        {
            this.Enabled = false;
            this.m_menuBar.Visible = false;
        }

        public TreeView getChecklistTree()
        {
            return m_requestTree;
        }

        /// <summary>
        /// Save the current checklist tree to the file.
        /// </summary>
        /// <param name="fullPath">An absolute path with extension to the file save this tree</param>
        /// <param name="isOverride">Verify if user wanna override the exited file if there are</param>
        /// <returns>Error code from BusinessLogic.Config</returns>
        public int SaveTheTree (string fullPath, bool isOverride)
        {
            XDocument document = m_business.GenerateChecklistDocument(m_requestTree);
            return m_business.SaveChecklistFile(
                document, 
                fullPath, 
                isOverride ? SaveType.OVERRIDE : SaveType.TRY);
        }

        /// <summary>
        /// To load the checklist tree from the file specified by the path.
        /// </summary>
        /// <param name="fullPath">Path to "req" file.</param>
        /// <returns>Error code if the method is work probaly</returns>
        public int LoadChecklist(string fullPath)
        {
            m_requestTree.Nodes.Clear();
            foreach (TreeNode node in m_business.GenerateChecklistTree(fullPath).Nodes)
            {
                m_requestTree.Nodes.Add(node.Clone() as TreeNode);
            }

            foreach (TreeNode node in m_requestTree.Nodes)
            {
                postInit(node);
            }

            return BusinessLogic.Config.ERROR_CODE_NONE;
        }

        private void clear_Click(object sender, EventArgs e)
        {
            m_requestTree.Nodes.Clear();
        }

        private void changePriority(object sender, EventArgs e)
        {
            switch (sender.ToString())
            {
                case "Unset":
                    m_requestTree.SelectedNode.ImageIndex
                        = m_requestTree.SelectedNode.SelectedImageIndex
                        = (int)PriorityIconIndex.PRIORITY_NONE;
                    break;

                case "1 (Highest)":
                    m_requestTree.SelectedNode.ImageIndex
                        = m_requestTree.SelectedNode.SelectedImageIndex
                        = (int)PriorityIconIndex.PRIORITY_1;
                    break;

                case "2":
                    m_requestTree.SelectedNode.ImageIndex
                        = m_requestTree.SelectedNode.SelectedImageIndex 
                        = (int)PriorityIconIndex.PRIORITY_2;
                    break;

                case "3":
                    m_requestTree.SelectedNode.ImageIndex
                        = m_requestTree.SelectedNode.SelectedImageIndex 
                        = (int)PriorityIconIndex.PRIORITY_3;
                    break;
                    
                case "4":
                    m_requestTree.SelectedNode.ImageIndex
                        = m_requestTree.SelectedNode.SelectedImageIndex 
                        = (int)PriorityIconIndex.PRIORITY_4;
                    break;

                case "5 (Lowest)":
                    m_requestTree.SelectedNode.ImageIndex
                        = m_requestTree.SelectedNode.SelectedImageIndex 
                        = (int)PriorityIconIndex.PRIORITY_5;
                    break;

                default:
                    break;
            }

            m_requestTree.Invalidate();
        }

        private void readAsParent(TreeNode node)
        {
            string status = "Opening";
            if (node.Checked)
            {
                status = "Solved";
            }

            m_reqDecs.Text =
                "Request name: " + node.Text + "\n" +
                "Priority: " + node.SelectedImageIndex.ToString() + "\n" +
                "Status: " + status + "\n\n" +
                "Num of sub request: " + node.Nodes.Count.ToString();

            m_reqDecs.Invalidate();
        }

        private void readAsLeaf(TreeNode node)
        {
            string status = "Opening";
            if (node.Checked)
            {
                status = "Solved";
            }

            m_reqDecs.Text =
                "Request name: " + node.Text + "\n" +
                "Priority: " + node.SelectedImageIndex.ToString() + "\n" +
                "Status: " + status + "\n\n" +
                "Describtion:\n" + node.ToolTipText;

            m_reqDecs.Invalidate();
        }

        private void selectRequest(TreeNode node)
        {
            if (node.Nodes.Count > 0)
            {
                readAsParent(node);
            }
            else
            {
                readAsLeaf(node);
            }
        }

        private void nodeClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            m_requestTree.SelectedNode = e.Node;
            selectRequest(e.Node);
        }

        private void postInit(TreeNode node)
        {
            node.ContextMenuStrip = m_requestContexMenu;
            foreach (TreeNode child in node.Nodes)
            {
                postInit(child);
            }
        }

        private void m_editDesc_Click(object sender, EventArgs e)
        {
            if (m_requestTree.SelectedNode.Nodes.Count > 0)
            {
                MessageBox.Show("Only available for leaf request.");
                return;
            }

            TypingDialog diag = new TypingDialog();
            diag.SetDialogName("New Describtion");
            diag.ShowDialog();

            m_requestTree.SelectedNode.ToolTipText = diag.GetContent();
            selectRequest(m_requestTree.SelectedNode);
        }
      }
}
