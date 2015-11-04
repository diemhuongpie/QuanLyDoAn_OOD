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

            TreeNode node = new TreeNode();
            node.Text = "test";
            node.ContextMenuStrip = m_rightClickMenu;
            m_requestTree.Nodes.Add(node);
        }

        private void m_remove_Click(object sender, EventArgs e)
        {
        }
    }
}
