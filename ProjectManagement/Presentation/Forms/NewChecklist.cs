using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using BusinessLogic;

namespace Presentation.Forms
{
    public partial class NewChecklist : Form
    {
        private NewChecklistBusiness m_business;
        public NewChecklist()
        {
            InitializeComponent();
        }

        private void m_btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void m_btnCreate_Click(object sender, EventArgs e)
        {
            // TODO: create a process for this event in the BusinessLogic class.
            // Open a file explorer dialog and save the tree.

            if (m_txtboxExportLink.Text == "")
            {
                searchForExportDirectory();
            }

            if (m_txtboxFileName.Text == "")
            {
                MessageBox.Show("Please import file name.\nTip: Use Macro(s) for auto-naming files.", "Missing file name", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void m_btnSearchExportDirectory_Click(object sender, EventArgs e)
        {
            searchForExportDirectory();
        }

        public void searchForExportDirectory()
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                m_txtboxExportLink.Text = dialog.SelectedPath;
            }
        }
    }
}
