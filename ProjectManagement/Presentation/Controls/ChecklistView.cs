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

namespace Presentation.Controls
{
    enum IconIndex
    {
        EMPTY = 0,
        ADD,
        REMOVE,
        CHECKED,
        UNCHECKED
    }

    public partial class ChecklistView : UserControl
    {
        ChecklistViewBusiness m_business = new ChecklistViewBusiness();

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
            }
        }

        private void m_newSubRequest_Click(object sender, EventArgs e)
        {
            TreeNode node = new TreeNode();
            node.Text = "New request";

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
            m_requestTree.SelectedNode = null;
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
            XDocument document = m_business.GenerateChecklistFile(m_requestTree);
            return m_business.SaveChecklistFile(
                document, 
                fullPath, 
                isOverride ? SaveType.OVERRIDE : SaveType.TRY);
        }
      }
}
