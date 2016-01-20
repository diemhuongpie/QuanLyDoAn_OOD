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
using BusinessLogic;
using DataTransfer;

namespace Presentation.Controls
{
    public partial class ProjectExplorer : UserControl
    {
        private ProjectExplorerBusiness m_business = new ProjectExplorerBusiness();

        public ProjectExplorer()
        {
            InitializeComponent();
            m_projectList.Controls.Add(new ProjectDisplay());
        }

        public void AddProject(ProjectDisplay prjdp)
        {
            m_projectList.Controls.Add(prjdp);
            prjdp.Dock = DockStyle.Top;
        }

        public void SeachForProjects (string name)
        {
            m_projectList.Controls.Clear();
            if (name.Length == 0)
                return;
            List<DTO_Project> projectInfoList = m_business.GetProjectByName(name);
            foreach (DTO_Project project in projectInfoList)
            {
                ProjectDisplay prj = new ProjectDisplay();
                /// TODO: change ProjectID to ProjectName.
                prj.SetProjectName(project.ProjectName);
                // seach for other info and set it here.
                
                m_projectList.Controls.Add(prj);
            }
        }

        public void SeachForGroups(string group)
        {
            m_projectList.Controls.Clear();
            if (group.Length == 0)
                return;
            List<DTO_Project> projectInfoList = m_business.GetProjectByGroup(group);
            foreach (DTO_Project project in projectInfoList)
            {
                ProjectDisplay prj = new ProjectDisplay();
                /// TODO: change ProjectID to ProjectName.
                prj.SetProjectName(project.ProjectName);
                // seach for other info and set it here.

                m_projectList.Controls.Add(prj);
            }
        }

        public void SeachForSubject(string subject)
        {
            m_projectList.Controls.Clear();
            if (subject.Length == 0)
                return;
            List<DTO_Project> projectInfoList = m_business.GetProjectBySubject(subject);
            foreach (DTO_Project project in projectInfoList)
            {
                ProjectDisplay prj = new ProjectDisplay();
                /// TODO: change ProjectID to ProjectName.
                prj.SetProjectName(project.ProjectName);
                // seach for other info and set it here.

                m_projectList.Controls.Add(prj);
            }
        }

        public void ExportSelectedProject(string exportDir)
        {
            // TODO: export
            //m_business.ExportProjectToCofFile()
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

        // Trung Le
        public  System.Windows.Forms.TableLayoutPanel getProjectList()
        {
            return m_projectList;
        }
    }
}
