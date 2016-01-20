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
    public partial class Setting : Form
    {
        private string m_storageDirPath;
        public Setting()
        {
            InitializeComponent();
        }

        public void setDirPath(string newPath)
        {
            m_storageDirPath = newPath;
            m_txtboxCustomDirPath.Text = m_storageDirPath;
        }

        public string getDirPath()
        {
            return m_storageDirPath;
        }

        private void m_btnAccept_Click(object sender, EventArgs e)
        {
            string storageMode = BusinessLogic.Config.STORAGE_DIR_MODE_DEFAULT;
            if (m_radioCustomDir.Checked)
            {
                storageMode = BusinessLogic.Config.STORAGE_DIR_MODE_CUSTOMIZE;
            }
            int errCode = BusinessLogic.Config.GetInstance().SetConfig(m_txtboxCustomDirPath.Text,
                storageMode, false);

            if (errCode == BusinessLogic.Config.ERROR_CODE_FOLDER_NOT_EXITS)
            {
                MessageBox.Show("Folder not exists, please check again your path");
            }
            else
            {
                this.Close();
            }
        }

        private void m_btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void changeMode(object sender, EventArgs e)
        {
            if (!m_radioDefaulDir.Checked)
            {
                m_txtboxCustomDirPath.ReadOnly = false;
            }
            else
            {
                m_txtboxCustomDirPath.ReadOnly = true;
            }
        }

        private void Setting_Shown(object sender, EventArgs e)
        {
            if (BusinessLogic.Config.GetInstance().GetStorageDirMode() == BusinessLogic.Config.STORAGE_DIR_MODE_DEFAULT)
            {
                m_radioDefaulDir.Select();
            }
            else
            {
                m_radioCustomDir.Select();
            }

            m_txtboxCustomDirPath.Text = BusinessLogic.Config.GetInstance().GetRootDirPath();
        }
    }
}
