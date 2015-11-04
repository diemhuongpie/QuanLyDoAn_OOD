using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Presentation.Controls;

namespace Presentation.Controls
{
    public partial class NewProject : Form
    {
        public ProjectDisplay m_createdObject { get; set; }

        public NewProject()
        {
            InitializeComponent();
        }

        private void addAuthor(object sender, EventArgs e)
        {
            m_authorList.Rows.Add(m_txtboxAuthorName.Text, m_txtboxAInfo.Text);
            m_txtboxAuthorName.Clear();
            m_txtboxAInfo.Clear();
        }

        private void m_btnCancel_Click(object sender, EventArgs e)
        {
            m_createdObject = null;
            this.Close();
        }

        private void m_btnCreate_Click(object sender, EventArgs e)
        {
            m_createdObject = new ProjectDisplay();
            m_createdObject.SetGroupName(m_txtboxGroupName.Text);
            m_createdObject.SetProgess(0);
            m_createdObject.SetProjectName(m_txtboxProjectName.Text);
            m_createdObject.UpdateLastCheckedTime();
            this.Close();
        }
    }
}
