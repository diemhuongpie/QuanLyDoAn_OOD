using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Presentation.Controls;

namespace Presentation.Controls
{
    public partial class ProjectExplorer : UserControl
    {
        public ProjectExplorer()
        {
            InitializeComponent();
        }

        public void AddProject(ProjectDisplay prjdp)
        {
            m_projectList.Controls.Add(prjdp);
            prjdp.Dock = DockStyle.Top;
        }

        private void deselectProjects(object sender, EventArgs e)
        {
            foreach (Control ctrl in m_projectList.Controls)
            {
                ProjectDisplay prj = ctrl as ProjectDisplay;
                prj.deselect(null, EventArgs.Empty);
            }
        }

        private void deleteSelectedProjects(object sender, EventArgs e)
        {
            int prevCount = m_projectList.Controls.Count;
            for (int i = 0; i < m_projectList.Controls.Count; ++i)
            {
                ProjectDisplay prj = m_projectList.Controls[i] as ProjectDisplay;
                if (prj.isSelected())
                {
                    m_projectList.Controls.Remove(prj);
                    i--;
                }
            }
            int newCount = m_projectList.Controls.Count;

            m_projectList.HorizontalScroll.Maximum *= (int)((double)newCount / (double)prevCount);
        }

        private void selectAllProjects(object sender, EventArgs e)
        {
            foreach (Control ctrl in m_projectList.Controls)
            {
                ProjectDisplay prj = ctrl as ProjectDisplay;
                prj.select();
            }
        }
    }
}
