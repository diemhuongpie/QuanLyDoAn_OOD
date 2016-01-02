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
        private NewChecklistBusiness m_business = new NewChecklistBusiness();
        private MacroHelper m_macroHelper = null;
        public NewChecklist()
        {
            InitializeComponent();
            m_macroHelper = new MacroHelper(ref m_txtboxFileName);
        }

        private void m_btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void m_btnCreate_Click(object sender, EventArgs e)
        {
            if (m_txtboxExportLink.Text == "")
            {
                searchForExportDirectory();
            }

            if (m_txtboxFileName.Text == "")
            {
                MessageBox.Show("Please import file name.\nTip: Use Macro(s) for auto-naming files.", "Missing file name", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            string processedPath = m_business.SaveLinkProcess(m_txtboxExportLink.Text, m_txtboxFileName.Text);

            int errorCode = m_checkList.SaveTheTree(processedPath, false);
            if (m_business.WarningErrorIfContinue(errorCode, processedPath))
            {
                m_checkList.SaveTheTree(processedPath, true);
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

        private void openMacroHelper(object sender, EventArgs e)
        {
            m_macroHelper.ShowDialog();
        }
    }
}
