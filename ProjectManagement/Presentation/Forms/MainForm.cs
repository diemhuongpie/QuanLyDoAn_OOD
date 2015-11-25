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
using Presentation.Controls;
using Presentation.Forms;

namespace Presentation
{
    public partial class MainForm : Form
    {
        private MainFormBusiness m_business;
        private NewChecklist generateChecklistWindow = new NewChecklist();
                
        public MainForm()
        {
            m_business = new MainFormBusiness();
            InitializeComponent();
            m_projectExplorer.AddProject(new ProjectDisplay());
            m_projectExplorer.AddProject(new ProjectDisplay());
            m_projectExplorer.AddProject(new ProjectDisplay());
            m_projectExplorer.AddProject(new ProjectDisplay());
            m_projectExplorer.AddProject(new ProjectDisplay());
            m_projectExplorer.AddProject(new ProjectDisplay());
            m_projectExplorer.AddProject(new ProjectDisplay());
            m_projectExplorer.AddProject(new ProjectDisplay());
            m_projectExplorer.AddProject(new ProjectDisplay());
            m_projectExplorer.AddProject(new ProjectDisplay());
            m_projectExplorer.AddProject(new ProjectDisplay());
            m_projectExplorer.AddProject(new ProjectDisplay());
            m_projectExplorer.AddProject(new ProjectDisplay());
            m_projectExplorer.AddProject(new ProjectDisplay());
            m_projectExplorer.AddProject(new ProjectDisplay());
            m_projectExplorer.AddProject(new ProjectDisplay());
            m_projectExplorer.AddProject(new ProjectDisplay());
            m_projectExplorer.AddProject(new ProjectDisplay());
            m_projectExplorer.AddProject(new ProjectDisplay());
            m_projectExplorer.AddProject(new ProjectDisplay());
            m_projectExplorer.AddProject(new ProjectDisplay());
            m_projectExplorer.AddProject(new ProjectDisplay());
            m_projectExplorer.AddProject(new ProjectDisplay());
        }

        private void AddNewProject(object sender, EventArgs e)
        {
            NewProject newPrjDialog = new NewProject();
            newPrjDialog.ShowDialog();

            if (newPrjDialog.m_createdObject != null)
            {
                m_projectExplorer.AddProject(newPrjDialog.m_createdObject);
            }
        }

        private void compareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChecklistCompare cmpCheckListDialog = new ChecklistCompare();
            cmpCheckListDialog.ShowDialog();
        }

        private void createChecklist(object sender, EventArgs e)
        {
            generateChecklistWindow.Show();
            generateChecklistWindow.Focus();
        }

        private void changeCheckStatus(object sender, EventArgs e)
        {
            ToolStripMenuItem button = sender as ToolStripMenuItem;
            button.Checked = !button.Checked;
        }

        private void showHideDirectoryTree(object sender, EventArgs e)
        {
            changeCheckStatus(sender, e);
            m_directoryTreeView.Visible = directoryTreeToolStripMenuItem.Checked;
            m_splitContainerDirectoryTree.Panel1Collapsed = !directoryTreeToolStripMenuItem.Checked;
        }

        private void showHideStatusBar(object sender, EventArgs e)
        {
            changeCheckStatus(sender, e);
            m_statusBar.Visible = statusBarToolStripMenuItem.Checked;
        }

        private void showHidePreviewPane(object sender, EventArgs e)
        {
            changeCheckStatus(sender, e);
            m_previewPane.Visible = previewPaneToolStripMenuItem.Checked;
            m_spliterContainerPreviewPane.Panel2Collapsed = !previewPaneToolStripMenuItem.Checked;
        }

        private void showHideSeachPane(object sender, EventArgs e)
        {
            changeCheckStatus(sender, e);
            m_textboxSearchBox.Visible = seachPaneToolStripMenuItem.Checked;
            m_btnSearch.Visible = m_textboxSearchBox.Visible = seachPaneToolStripMenuItem.Checked;
            m_spliterContainerSeachBox.Panel1Collapsed = !seachPaneToolStripMenuItem.Checked;
        }

        private void m_btnAddFilter_Click(object sender, EventArgs e)
        {
            // TODO: call a filter list dialog to choose, then re-filtering project list.
            // TODO: re-compute the POINT_TO_PIXEL scale. I MEAN JUST NEED TO COMPUTE TAG WIDTH CORRECTLY.
            // Testing
            TagObject tag = new TagObject();
            tag.setTagName("Die Trying");
            m_filterContainer.Controls.Add(tag);
        }

        private void seachForProjects(object sender, EventArgs e)
        {
            switch (m_cboSeachType.Text)
            {
                case "Project Name":
                    {
                        m_projectExplorer.SeachForProjects(m_textboxSearchBox.Text);
                        break;
                    }

                case "Group Name":
                    {
                        break;
                    }

                case "Last Update Time":
                    {
                        break;
                    }

                default:
                    break;
            }
        }
    }
}
