using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
      }
}
