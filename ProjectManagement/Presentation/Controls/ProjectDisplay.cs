using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLogic;

namespace Presentation.Controls
{
    public partial class ProjectDisplay : UserControl
    {
        public string m_overview { get; set; }

        public ProjectDisplay()
        {
            InitializeComponent();
            m_splitContainerProgressBar.SplitterDistance = 5;
            Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top;
        }

        public void SetProjectName (string projectName)
        {
            m_lblProjectName.Text = projectName;
        }

        public void SetGroupName (string groupName)
        {
            m_lblGroupName.Text = groupName;
        }

        public void UpdateLastCheckedTime ()
        {
            m_lblLastUpdate.Text = "Last update: " + DateTime.Now.Date.ToShortDateString();
        }

        public void SetProgess (int percentage)
        {
            if (percentage > 100)
            {
                percentage = 100;
            }
            else if (percentage < 0)
            {
                percentage = 0;
            }

            m_progressBar.Value = percentage;
        }

        private void m_btnDelete_Click(object sender, EventArgs e)
        {
            this.Parent.Controls.Remove(this);
        }

        public void deselect(object sender, EventArgs e)
        {
            m_backgroundPanel.BackColor = Color.White;
        }

        public void select ()
        {
            m_backgroundPanel.BackColor = Color.Red;
        }

        public bool isSelected ()
        {
            return (m_backgroundPanel.BackColor == Color.Red);
        }

        private void changeSelectStatus(object sender, EventArgs e)
        {
            if (isSelected())
            {
                deselect(null, EventArgs.Empty);
            }
            else
            {
                select();
            }
        }


        private void m_btnSetting_Click(object sender, EventArgs e)
        {
            ExcelReport.createReport();
            
        }
    }
}
