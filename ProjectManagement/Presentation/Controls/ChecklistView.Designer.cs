namespace Presentation.Controls
{
    partial class ChecklistView
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Requests");
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChecklistView));
            this.m_rightClickMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.m_newSubRequest = new System.Windows.Forms.ToolStripMenuItem();
            this.m_remove = new System.Windows.Forms.ToolStripMenuItem();
            this.m_checklistView = new System.Windows.Forms.TreeView();
            this.m_requestTree = new System.Windows.Forms.TreeView();
            this.m_icons = new System.Windows.Forms.ImageList(this.components);
            this.renameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.m_rightClickMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // m_rightClickMenu
            // 
            this.m_rightClickMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.m_rightClickMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.m_newSubRequest,
            this.m_remove,
            this.renameToolStripMenuItem});
            this.m_rightClickMenu.Name = "m_rightClickMenu";
            this.m_rightClickMenu.Size = new System.Drawing.Size(206, 70);
            // 
            // m_newSubRequest
            // 
            this.m_newSubRequest.Name = "m_newSubRequest";
            this.m_newSubRequest.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.m_newSubRequest.Size = new System.Drawing.Size(205, 22);
            this.m_newSubRequest.Text = "New sub request";
            this.m_newSubRequest.Click += new System.EventHandler(this.m_newSubRequest_Click);
            // 
            // m_remove
            // 
            this.m_remove.Name = "m_remove";
            this.m_remove.ShortcutKeys = System.Windows.Forms.Keys.Delete;
            this.m_remove.Size = new System.Drawing.Size(205, 22);
            this.m_remove.Text = "Remove";
            this.m_remove.Click += new System.EventHandler(this.m_remove_Click);
            // 
            // m_checklistView
            // 
            this.m_checklistView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.m_checklistView.Location = new System.Drawing.Point(0, 0);
            this.m_checklistView.Name = "m_checklistView";
            this.m_checklistView.Size = new System.Drawing.Size(366, 481);
            this.m_checklistView.TabIndex = 0;
            // 
            // m_requestTree
            // 
            this.m_requestTree.CheckBoxes = true;
            this.m_requestTree.Dock = System.Windows.Forms.DockStyle.Fill;
            this.m_requestTree.FullRowSelect = true;
            this.m_requestTree.HideSelection = false;
            this.m_requestTree.ImageIndex = 0;
            this.m_requestTree.ImageList = this.m_icons;
            this.m_requestTree.LabelEdit = true;
            this.m_requestTree.LineColor = System.Drawing.Color.DarkOrange;
            this.m_requestTree.Location = new System.Drawing.Point(0, 0);
            this.m_requestTree.Name = "m_requestTree";
            treeNode1.ContextMenuStrip = this.m_rightClickMenu;
            treeNode1.Name = "m_root";
            treeNode1.Text = "Requests";
            this.m_requestTree.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode1});
            this.m_requestTree.SelectedImageIndex = 0;
            this.m_requestTree.Size = new System.Drawing.Size(366, 481);
            this.m_requestTree.TabIndex = 1;
            // 
            // m_icons
            // 
            this.m_icons.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("m_icons.ImageStream")));
            this.m_icons.TransparentColor = System.Drawing.Color.Transparent;
            this.m_icons.Images.SetKeyName(0, "Empty_Icon.png");
            this.m_icons.Images.SetKeyName(1, "Add.ico");
            this.m_icons.Images.SetKeyName(2, "Remove.ico");
            this.m_icons.Images.SetKeyName(3, "Yes.ico");
            this.m_icons.Images.SetKeyName(4, "Red mark.ico");
            // 
            // renameToolStripMenuItem
            // 
            this.renameToolStripMenuItem.Name = "renameToolStripMenuItem";
            this.renameToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F2;
            this.renameToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.renameToolStripMenuItem.Text = "Rename";
            this.renameToolStripMenuItem.Click += new System.EventHandler(this.renameToolStripMenuItem_Click);
            // 
            // ChecklistView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.m_requestTree);
            this.Controls.Add(this.m_checklistView);
            this.Name = "ChecklistView";
            this.Size = new System.Drawing.Size(366, 481);
            this.m_rightClickMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView m_checklistView;
        private System.Windows.Forms.TreeNode m_root;
        private System.Windows.Forms.TreeView m_requestTree;
        private System.Windows.Forms.ImageList m_icons;
        private System.Windows.Forms.ContextMenuStrip m_rightClickMenu;
        private System.Windows.Forms.ToolStripMenuItem m_newSubRequest;
        private System.Windows.Forms.ToolStripMenuItem m_remove;
        private System.Windows.Forms.ToolStripMenuItem renameToolStripMenuItem;
    }
}
