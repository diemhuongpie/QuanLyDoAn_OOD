using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.IO;
using BusinessLogic;

namespace Presentation.Controls
{
    public partial class TreeviewExplorer : UserControl
    {
        private TreeviewExplorerBusiness m_business = new TreeviewExplorerBusiness();
        
        public TreeviewExplorer()
        {
            InitializeComponent();
        }

        // Add these folder into the node.
        // In case the node is null, the dirs will be added to root.
        private void AddChildDirectories(DirectoryInfo[] dirs, TreeNode node = null)
        {
            foreach (DirectoryInfo info in dirs)
            {
                TreeNode childNode = new TreeNode(info.Name);

                if (m_isCountFolders.Checked)
                {
                    // Add folder and file counter to name.
                    DirectoryInfo[] folders = m_business.GetChildDirectories(info.FullName);
                    int childFolderNum = folders.GetLength(0);

                    childNode.Text += " (" + childFolderNum.ToString() + " folder ";

                    FileInfo[] files = m_business.GetChildFiles(info.FullName);
                    int childFileNum = files.GetLength(0);

                    childNode.Text += childFileNum.ToString() + " file)";
                }

                // IMPORTANT: this name is used by many methods, do not mess with it.
                childNode.Name = info.FullName;
                // ===============================================

                childNode.ContextMenuStrip = m_ctxmenuDirectoryTree;
                childNode.Nodes.Add("*");

                if (node != null)
                {
                    node.Nodes.Add(childNode);
                }
                else
                {
                    m_directoryTreeView.Nodes.Add(childNode);
                }
            }
        }

        // To fill the treeview with directory nodes.
        // Incase the node is null, it'll fill the root.
        private void FillChildNodes(TreeNode node = null)
        {
            DirectoryInfo[] childs;
            if (node != null)
            {
                childs = m_business.GetChildDirectories(node.Name);
            }
            else
            {
                childs = m_business.GetChildDirectories(m_business.GetRootFolderFullPath());
            }

            AddChildDirectories(childs, node);
        }

        private void reloadChildFolder(object sender, EventArgs e)
        {
            if (m_directoryTreeView.SelectedNode != null)
            {
                m_directoryTreeView.SelectedNode.Nodes.Clear();
            }
            else
            {
                m_directoryTreeView.Nodes.Clear();
            }

            FillChildNodes(m_directoryTreeView.SelectedNode);
        }

        private void selectClickedNode(object sender, TreeNodeMouseClickEventArgs e)
        {
            m_directoryTreeView.SelectedNode = e.Node;
        }

        private void deleteFolder(object sender, EventArgs e)
        {
            TreeNode deletedNodeParent = m_directoryTreeView.SelectedNode.Parent;
            m_business.DeleteFolder(m_directoryTreeView.SelectedNode.Name);

            m_directoryTreeView.SelectedNode = deletedNodeParent;
            reloadChildFolder(null, EventArgs.Empty);

            m_directoryTreeView.SelectedNode = null;
        }

        private void ExpandTreeNode(object sender, TreeViewCancelEventArgs e)
        {
            if (e.Node.Nodes[0].Text == "*")
            {
                e.Node.Nodes.Clear();
                FillChildNodes(e.Node);
            }
        }

        private void loadFolders(object sender, EventArgs e)
        {
            m_directoryTreeView.Nodes.Clear();
            DirectoryInfo[] dirs = m_business.GetChildDirectories(m_business.GetRootFolderFullPath());
            AddChildDirectories(dirs, null);
        }

        private void deselectNode(object sender, EventArgs e)
        {
            m_directoryTreeView.SelectedNode = null;
        }
    }
}
