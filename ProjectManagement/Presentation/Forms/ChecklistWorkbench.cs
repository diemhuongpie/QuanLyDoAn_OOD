using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentation.Forms
{
    public partial class ChecklistWorkbench : Form
    {
        public ChecklistWorkbench()
        {
            InitializeComponent();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Not implement yet
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = BusinessLogic.Config.FILE_DIALOG_FILTER_CHECKLIST;
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                // do open checklist.
            }
        }

        private void saveToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            // Not implement yet
        }

        private void saveAsNewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Not implement yet
        }
    }
}