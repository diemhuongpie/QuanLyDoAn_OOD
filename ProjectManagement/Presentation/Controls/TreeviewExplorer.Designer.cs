namespace Presentation.Controls
{
    partial class TreeviewExplorer
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.m_directoryTreeView = new System.Windows.Forms.TreeView();
            this.m_ctxmenuBackground = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.reloadToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.m_ctxmenuDirectoryTree = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.folderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.projectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reloadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.m_cbbxViewMode = new System.Windows.Forms.ComboBox();
            this.m_grpbxView = new System.Windows.Forms.GroupBox();
            this.m_isCountFolders = new System.Windows.Forms.CheckBox();
            this.newFolderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.m_ctxmenuBackground.SuspendLayout();
            this.m_ctxmenuDirectoryTree.SuspendLayout();
            this.m_grpbxView.SuspendLayout();
            this.SuspendLayout();
            // 
            // m_directoryTreeView
            // 
            this.m_directoryTreeView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.m_directoryTreeView.ContextMenuStrip = this.m_ctxmenuBackground;
            this.m_directoryTreeView.Location = new System.Drawing.Point(0, 66);
            this.m_directoryTreeView.Name = "m_directoryTreeView";
            this.m_directoryTreeView.Size = new System.Drawing.Size(201, 473);
            this.m_directoryTreeView.TabIndex = 1;
            this.m_directoryTreeView.BeforeExpand += new System.Windows.Forms.TreeViewCancelEventHandler(this.ExpandTreeNode);
            this.m_directoryTreeView.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.selectClickedNode);
            this.m_directoryTreeView.MouseClick += new System.Windows.Forms.MouseEventHandler(this.deselect);
            // 
            // m_ctxmenuBackground
            // 
            this.m_ctxmenuBackground.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reloadToolStripMenuItem1,
            this.newFolderToolStripMenuItem});
            this.m_ctxmenuBackground.Name = "m_ctxmenuBackground";
            this.m_ctxmenuBackground.Size = new System.Drawing.Size(153, 70);
            // 
            // reloadToolStripMenuItem1
            // 
            this.reloadToolStripMenuItem1.Name = "reloadToolStripMenuItem1";
            this.reloadToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.reloadToolStripMenuItem1.Text = "Reload";
            this.reloadToolStripMenuItem1.Click += new System.EventHandler(this.loadFolders);
            // 
            // m_ctxmenuDirectoryTree
            // 
            this.m_ctxmenuDirectoryTree.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.deleteToolStripMenuItem,
            this.reloadToolStripMenuItem});
            this.m_ctxmenuDirectoryTree.Name = "m_ctxmenuDirectoryTree";
            this.m_ctxmenuDirectoryTree.Size = new System.Drawing.Size(111, 70);
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.folderToolStripMenuItem,
            this.projectToolStripMenuItem});
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.newToolStripMenuItem.Text = "New";
            // 
            // folderToolStripMenuItem
            // 
            this.folderToolStripMenuItem.Name = "folderToolStripMenuItem";
            this.folderToolStripMenuItem.Size = new System.Drawing.Size(111, 22);
            this.folderToolStripMenuItem.Text = "Folder";
            // 
            // projectToolStripMenuItem
            // 
            this.projectToolStripMenuItem.Name = "projectToolStripMenuItem";
            this.projectToolStripMenuItem.Size = new System.Drawing.Size(111, 22);
            this.projectToolStripMenuItem.Text = "Project";
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteFolder);
            // 
            // reloadToolStripMenuItem
            // 
            this.reloadToolStripMenuItem.Name = "reloadToolStripMenuItem";
            this.reloadToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.reloadToolStripMenuItem.Text = "Reload";
            this.reloadToolStripMenuItem.Click += new System.EventHandler(this.reloadChildFolder);
            // 
            // m_cbbxViewMode
            // 
            this.m_cbbxViewMode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.m_cbbxViewMode.FormattingEnabled = true;
            this.m_cbbxViewMode.Items.AddRange(new object[] {
            "Directory",
            "Tag",
            "Update Time",
            "Progress",
            "Score",
            "Class"});
            this.m_cbbxViewMode.Location = new System.Drawing.Point(3, 16);
            this.m_cbbxViewMode.Name = "m_cbbxViewMode";
            this.m_cbbxViewMode.Size = new System.Drawing.Size(195, 21);
            this.m_cbbxViewMode.TabIndex = 3;
            this.m_cbbxViewMode.Text = "Directory";
            // 
            // m_grpbxView
            // 
            this.m_grpbxView.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.m_grpbxView.Controls.Add(this.m_cbbxViewMode);
            this.m_grpbxView.Dock = System.Windows.Forms.DockStyle.Top;
            this.m_grpbxView.Location = new System.Drawing.Point(0, 0);
            this.m_grpbxView.Name = "m_grpbxView";
            this.m_grpbxView.Size = new System.Drawing.Size(201, 42);
            this.m_grpbxView.TabIndex = 4;
            this.m_grpbxView.TabStop = false;
            this.m_grpbxView.Text = "View mode";
            // 
            // m_isCountFolders
            // 
            this.m_isCountFolders.AutoSize = true;
            this.m_isCountFolders.Location = new System.Drawing.Point(3, 43);
            this.m_isCountFolders.Name = "m_isCountFolders";
            this.m_isCountFolders.Size = new System.Drawing.Size(127, 17);
            this.m_isCountFolders.TabIndex = 5;
            this.m_isCountFolders.Text = "Group Inside Preview";
            this.m_isCountFolders.UseVisualStyleBackColor = true;
            this.m_isCountFolders.CheckedChanged += new System.EventHandler(this.loadFolders);
            // 
            // newFolderToolStripMenuItem
            // 
            this.newFolderToolStripMenuItem.Name = "newFolderToolStripMenuItem";
            this.newFolderToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.newFolderToolStripMenuItem.Text = "New Folder";
            // 
            // TreeviewExplorer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.m_isCountFolders);
            this.Controls.Add(this.m_grpbxView);
            this.Controls.Add(this.m_directoryTreeView);
            this.Name = "TreeviewExplorer";
            this.Size = new System.Drawing.Size(201, 539);
            this.Load += new System.EventHandler(this.loadFolders);
            this.m_ctxmenuBackground.ResumeLayout(false);
            this.m_ctxmenuDirectoryTree.ResumeLayout(false);
            this.m_grpbxView.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView m_directoryTreeView;
        private System.Windows.Forms.ContextMenuStrip m_ctxmenuDirectoryTree;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem folderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem projectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reloadToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip m_ctxmenuBackground;
        private System.Windows.Forms.ToolStripMenuItem reloadToolStripMenuItem1;
        private System.Windows.Forms.ComboBox m_cbbxViewMode;
        private System.Windows.Forms.GroupBox m_grpbxView;
        private System.Windows.Forms.CheckBox m_isCountFolders;
        private System.Windows.Forms.ToolStripMenuItem newFolderToolStripMenuItem;
    }
}
