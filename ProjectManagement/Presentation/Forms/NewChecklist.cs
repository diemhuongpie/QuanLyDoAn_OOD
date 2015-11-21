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
    public partial class NewChecklist : Form
    {
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
