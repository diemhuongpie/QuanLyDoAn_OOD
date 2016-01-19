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

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = BusinessLogic.Config.FILE_DIALOG_FILTER_CHECKLIST;
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                m_checklistView.LoadChecklist(dialog.FileName);
            }
        }

        private void saveToolStripMenuItem2_Click(object sender, EventArgs e)
        {

        }
    }
}