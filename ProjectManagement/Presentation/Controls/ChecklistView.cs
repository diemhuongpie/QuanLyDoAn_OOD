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
            if (m_requestTree.SelectedNode == m_root)
                return;

            m_requestTree.SelectedNode.Remove();
        }

        private void m_newSubRequest_Click(object sender, EventArgs e)
        {
            TreeNode node = new TreeNode();
            node.Text = "New request";
            node.ContextMenuStrip = m_rightClickMenu;
            m_requestTree.SelectedNode.Nodes.Add(node);
            m_requestTree.SelectedNode.Expand();
            node.BeginEdit();
        }

        private void renameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            m_requestTree.SelectedNode.BeginEdit();
        }
    }
}
