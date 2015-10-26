using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

using BusinessLogic;
using Presentation.Controlers;
using Presentation.Forms;

namespace Presentation
{
    public partial class MainForm : Form
    {
        private MainFormBusiness m_business;

        public MainForm()
        {
            m_business = new MainFormBusiness();
            InitializeComponent();
            m_projectList.Controls.Add(new ProjectDisplay());
            m_projectList.Controls.Add(new ProjectDisplay());
            m_projectList.Controls.Add(new ProjectDisplay());
            m_projectList.Controls.Add(new ProjectDisplay());
            m_projectList.Controls.Add(new ProjectDisplay());
            m_projectList.Controls.Add(new ProjectDisplay());
            m_projectList.Controls.Add(new ProjectDisplay());
            m_projectList.Controls.Add(new ProjectDisplay());
            m_projectList.Controls.Add(new ProjectDisplay());
            m_projectList.Controls.Add(new ProjectDisplay());
            m_projectList.Controls.Add(new ProjectDisplay());
            m_projectList.Controls.Add(new ProjectDisplay());
            m_projectList.Controls.Add(new ProjectDisplay());
            m_projectList.Controls.Add(new ProjectDisplay());
            m_projectList.Controls.Add(new ProjectDisplay());
            m_projectList.Controls.Add(new ProjectDisplay());
            m_projectList.Controls.Add(new ProjectDisplay());
            m_projectList.Controls.Add(new ProjectDisplay());
            m_projectList.Controls.Add(new ProjectDisplay());
            m_projectList.Controls.Add(new ProjectDisplay());
            m_projectList.Controls.Add(new ProjectDisplay());
            foreach (ProjectDisplay prds in m_projectList.Controls)
            {
                prds.Dock = DockStyle.Top;
            }
        }

        private void FillChildNodes (TreeNode node)
        {
            DirectoryInfo[] childs = m_business.GetChildDirectories(node.FullPath);

            foreach (DirectoryInfo info in childs)
            {
                TreeNode childNode = new TreeNode(info.Name);
                node.Nodes.Add(childNode);
                childNode.Nodes.Add("*");
            }
        }

        private void LoadingContent (object sender, EventArgs e)
        {
            TreeNode rootNode = new TreeNode("Root");
            
            this.m_directoryTreeView.Nodes.Add(rootNode);
            rootNode.Nodes.Add("*");
        }

        private void ExpandTreeNode(object sender, TreeViewCancelEventArgs e)
        {
            if (e.Node.Nodes[0].Text == "*")
            {
                e.Node.Nodes.Clear();
                FillChildNodes(e.Node);
            }
        }

        private void AddNewProject(object sender, EventArgs e)
        {
            NewProject newPrjDialog = new NewProject();
            newPrjDialog.ShowDialog();
        }
    }
}
