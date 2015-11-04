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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChecklistView));
            this.m_checklistView = new System.Windows.Forms.TreeView();
            this.m_treeShow = new Aga.Controls.Tree.TreeColumn();
            this.m_status = new Aga.Controls.Tree.TreeColumn();
            this.m_nodeCheckBox = new Aga.Controls.Tree.NodeControls.NodeCheckBox();
            this.m_nodeName = new Aga.Controls.Tree.NodeControls.NodeTextBox();
            this.m_nodeStatus = new Aga.Controls.Tree.NodeControls.NodeTextBox();
            this.m_requestTree = new System.Windows.Forms.TreeView();
            this.m_icons = new System.Windows.Forms.ImageList(this.components);
            this.m_rightClickMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.m_newSubRequest = new System.Windows.Forms.ToolStripMenuItem();
            this.m_remove = new System.Windows.Forms.ToolStripMenuItem();
            this.m_rightClickMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // m_checklistView
            // 
            this.m_checklistView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.m_checklistView.Location = new System.Drawing.Point(0, 0);
            this.m_checklistView.Name = "m_checklistView";
            this.m_checklistView.Size = new System.Drawing.Size(366, 481);
            this.m_checklistView.TabIndex = 0;
            // 
            // m_treeShow
            // 
            this.m_treeShow.Header = "";
            this.m_treeShow.SortOrder = System.Windows.Forms.SortOrder.None;
            this.m_treeShow.TooltipText = null;
            // 
            // m_status
            // 
            this.m_status.Header = "";
            this.m_status.SortOrder = System.Windows.Forms.SortOrder.None;
            this.m_status.TooltipText = null;
            // 
            // m_nodeCheckBox
            // 
            this.m_nodeCheckBox.LeftMargin = 0;
            this.m_nodeCheckBox.ParentColumn = this.m_treeShow;
            // 
            // m_nodeName
            // 
            this.m_nodeName.IncrementalSearchEnabled = true;
            this.m_nodeName.LeftMargin = 3;
            this.m_nodeName.ParentColumn = this.m_treeShow;
            // 
            // m_nodeStatus
            // 
            this.m_nodeStatus.IncrementalSearchEnabled = true;
            this.m_nodeStatus.LeftMargin = 3;
            this.m_nodeStatus.ParentColumn = this.m_status;
            // 
            // m_requestTree
            // 
            this.m_requestTree.CheckBoxes = true;
            this.m_requestTree.Dock = System.Windows.Forms.DockStyle.Fill;
            this.m_requestTree.HideSelection = false;
            this.m_requestTree.ImageIndex = 0;
            this.m_requestTree.ImageList = this.m_icons;
            this.m_requestTree.Location = new System.Drawing.Point(0, 0);
            this.m_requestTree.Name = "m_requestTree";
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
            // m_rightClickMenu
            // 
            this.m_rightClickMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.m_rightClickMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.m_newSubRequest,
            this.m_remove});
            this.m_rightClickMenu.Name = "m_rightClickMenu";
            this.m_rightClickMenu.Size = new System.Drawing.Size(206, 70);
            // 
            // m_newSubRequest
            // 
            this.m_newSubRequest.Name = "m_newSubRequest";
            this.m_newSubRequest.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.m_newSubRequest.Size = new System.Drawing.Size(205, 22);
            this.m_newSubRequest.Text = "New sub request";
            // 
            // m_remove
            // 
            this.m_remove.Name = "m_remove";
            this.m_remove.ShortcutKeys = System.Windows.Forms.Keys.Delete;
            this.m_remove.Size = new System.Drawing.Size(205, 22);
            this.m_remove.Text = "Remove";
            this.m_remove.Click += new System.EventHandler(this.m_remove_Click);
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
        private Aga.Controls.Tree.TreeColumn m_treeShow;
        private Aga.Controls.Tree.TreeColumn m_status;
        private Aga.Controls.Tree.NodeControls.NodeCheckBox m_nodeCheckBox;
        private Aga.Controls.Tree.NodeControls.NodeTextBox m_nodeName;
        private Aga.Controls.Tree.NodeControls.NodeTextBox m_nodeStatus;
        private System.Windows.Forms.TreeView m_requestTree;
        private System.Windows.Forms.ImageList m_icons;
        private System.Windows.Forms.ContextMenuStrip m_rightClickMenu;
        private System.Windows.Forms.ToolStripMenuItem m_newSubRequest;
        private System.Windows.Forms.ToolStripMenuItem m_remove;
    }
}
