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
            this.m_requestTree = new System.Windows.Forms.TreeView();
            this.m_menuBar = new System.Windows.Forms.MenuStrip();
            this.newSubRequestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.renameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deselect = new System.Windows.Forms.ToolStripMenuItem();
            this.clear = new System.Windows.Forms.ToolStripMenuItem();
            this.m_priorityResource = new System.Windows.Forms.ImageList(this.components);
            this.m_requestContexMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.m_addSubRequest = new System.Windows.Forms.ToolStripMenuItem();
            this.m_removeReq = new System.Windows.Forms.ToolStripMenuItem();
            this.seperator = new System.Windows.Forms.ToolStripSeparator();
            this.m_setPriority = new System.Windows.Forms.ToolStripMenuItem();
            this.m_priorityUnset = new System.Windows.Forms.ToolStripMenuItem();
            this.m_priority1 = new System.Windows.Forms.ToolStripMenuItem();
            this.m_priority2 = new System.Windows.Forms.ToolStripMenuItem();
            this.m_priority3 = new System.Windows.Forms.ToolStripMenuItem();
            this.m_priority4 = new System.Windows.Forms.ToolStripMenuItem();
            this.m_priority5 = new System.Windows.Forms.ToolStripMenuItem();
            this.spliter = new System.Windows.Forms.SplitContainer();
            this.m_reqDecs = new System.Windows.Forms.RichTextBox();
            this.m_editDesc = new System.Windows.Forms.ToolStripMenuItem();
            this.m_menuBar.SuspendLayout();
            this.m_requestContexMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spliter)).BeginInit();
            this.spliter.Panel1.SuspendLayout();
            this.spliter.Panel2.SuspendLayout();
            this.spliter.SuspendLayout();
            this.SuspendLayout();
            // 
            // m_requestTree
            // 
            this.m_requestTree.CheckBoxes = true;
            this.m_requestTree.Dock = System.Windows.Forms.DockStyle.Fill;
            this.m_requestTree.ImageIndex = 0;
            this.m_requestTree.ImageList = this.m_priorityResource;
            this.m_requestTree.LabelEdit = true;
            this.m_requestTree.Location = new System.Drawing.Point(0, 0);
            this.m_requestTree.Name = "m_requestTree";
            this.m_requestTree.SelectedImageIndex = 0;
            this.m_requestTree.Size = new System.Drawing.Size(385, 457);
            this.m_requestTree.TabIndex = 0;
            this.m_requestTree.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.nodeClick);
            this.m_requestTree.Click += new System.EventHandler(this.deselecting);
            // 
            // m_menuBar
            // 
            this.m_menuBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newSubRequestToolStripMenuItem,
            this.deleteToolStripMenuItem,
            this.renameToolStripMenuItem,
            this.deselect,
            this.clear});
            this.m_menuBar.Location = new System.Drawing.Point(0, 0);
            this.m_menuBar.Name = "m_menuBar";
            this.m_menuBar.Size = new System.Drawing.Size(632, 24);
            this.m_menuBar.TabIndex = 1;
            // 
            // newSubRequestToolStripMenuItem
            // 
            this.newSubRequestToolStripMenuItem.Name = "newSubRequestToolStripMenuItem";
            this.newSubRequestToolStripMenuItem.ShortcutKeyDisplayString = "Ins";
            this.newSubRequestToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.Insert;
            this.newSubRequestToolStripMenuItem.Size = new System.Drawing.Size(133, 20);
            this.newSubRequestToolStripMenuItem.Text = "New sub request (Ins)";
            this.newSubRequestToolStripMenuItem.ToolTipText = "Insert";
            this.newSubRequestToolStripMenuItem.Click += new System.EventHandler(this.m_newSubRequest_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.ShortcutKeyDisplayString = "Del";
            this.deleteToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.Delete;
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(80, 20);
            this.deleteToolStripMenuItem.Text = "Delete (Del)";
            this.deleteToolStripMenuItem.ToolTipText = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.m_remove_Click);
            // 
            // renameToolStripMenuItem
            // 
            this.renameToolStripMenuItem.Name = "renameToolStripMenuItem";
            this.renameToolStripMenuItem.ShortcutKeyDisplayString = "F2";
            this.renameToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F2;
            this.renameToolStripMenuItem.Size = new System.Drawing.Size(85, 20);
            this.renameToolStripMenuItem.Text = "Rename (F2)";
            this.renameToolStripMenuItem.ToolTipText = "F2";
            this.renameToolStripMenuItem.Click += new System.EventHandler(this.renameToolStripMenuItem_Click);
            // 
            // deselect
            // 
            this.deselect.Name = "deselect";
            this.deselect.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D)));
            this.deselect.Size = new System.Drawing.Size(115, 20);
            this.deselect.Text = "Deselect (Ctrl + D)";
            this.deselect.Visible = false;
            this.deselect.Click += new System.EventHandler(this.deselecting);
            // 
            // clear
            // 
            this.clear.Name = "clear";
            this.clear.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Shift | System.Windows.Forms.Keys.Delete)));
            this.clear.Size = new System.Drawing.Size(112, 20);
            this.clear.Text = "Clear (Shift + Del)";
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // m_priorityResource
            // 
            this.m_priorityResource.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("m_priorityResource.ImageStream")));
            this.m_priorityResource.TransparentColor = System.Drawing.Color.Transparent;
            this.m_priorityResource.Images.SetKeyName(0, "Empty_Icon.png");
            this.m_priorityResource.Images.SetKeyName(1, "1.png");
            this.m_priorityResource.Images.SetKeyName(2, "2.png");
            this.m_priorityResource.Images.SetKeyName(3, "3.png");
            this.m_priorityResource.Images.SetKeyName(4, "4.png");
            this.m_priorityResource.Images.SetKeyName(5, "5.png");
            // 
            // m_requestContexMenu
            // 
            this.m_requestContexMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.m_setPriority,
            this.seperator,
            this.m_addSubRequest,
            this.m_removeReq,
            this.m_editDesc});
            this.m_requestContexMenu.Name = "m_requestContexMenu";
            this.m_requestContexMenu.Size = new System.Drawing.Size(165, 98);
            // 
            // m_addSubRequest
            // 
            this.m_addSubRequest.Name = "m_addSubRequest";
            this.m_addSubRequest.Size = new System.Drawing.Size(164, 22);
            this.m_addSubRequest.Text = "Add Sub Request";
            // 
            // m_removeReq
            // 
            this.m_removeReq.Name = "m_removeReq";
            this.m_removeReq.Size = new System.Drawing.Size(164, 22);
            this.m_removeReq.Text = "Remove";
            // 
            // seperator
            // 
            this.seperator.Name = "seperator";
            this.seperator.Size = new System.Drawing.Size(161, 6);
            // 
            // m_setPriority
            // 
            this.m_setPriority.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.m_priorityUnset,
            this.m_priority1,
            this.m_priority2,
            this.m_priority3,
            this.m_priority4,
            this.m_priority5});
            this.m_setPriority.Name = "m_setPriority";
            this.m_setPriority.Size = new System.Drawing.Size(164, 22);
            this.m_setPriority.Text = "Set Priority";
            // 
            // m_priorityUnset
            // 
            this.m_priorityUnset.Name = "m_priorityUnset";
            this.m_priorityUnset.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D6)));
            this.m_priorityUnset.Size = new System.Drawing.Size(172, 22);
            this.m_priorityUnset.Text = "Unset";
            this.m_priorityUnset.Click += new System.EventHandler(this.changePriority);
            // 
            // m_priority1
            // 
            this.m_priority1.Name = "m_priority1";
            this.m_priority1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D1)));
            this.m_priority1.Size = new System.Drawing.Size(172, 22);
            this.m_priority1.Text = "1 (Highest)";
            this.m_priority1.Click += new System.EventHandler(this.changePriority);
            // 
            // m_priority2
            // 
            this.m_priority2.Name = "m_priority2";
            this.m_priority2.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D2)));
            this.m_priority2.Size = new System.Drawing.Size(172, 22);
            this.m_priority2.Text = "2";
            this.m_priority2.Click += new System.EventHandler(this.changePriority);
            // 
            // m_priority3
            // 
            this.m_priority3.Name = "m_priority3";
            this.m_priority3.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D3)));
            this.m_priority3.Size = new System.Drawing.Size(172, 22);
            this.m_priority3.Text = "3";
            this.m_priority3.Click += new System.EventHandler(this.changePriority);
            // 
            // m_priority4
            // 
            this.m_priority4.Name = "m_priority4";
            this.m_priority4.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D4)));
            this.m_priority4.Size = new System.Drawing.Size(172, 22);
            this.m_priority4.Text = "4";
            this.m_priority4.Click += new System.EventHandler(this.changePriority);
            // 
            // m_priority5
            // 
            this.m_priority5.Name = "m_priority5";
            this.m_priority5.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D5)));
            this.m_priority5.Size = new System.Drawing.Size(172, 22);
            this.m_priority5.Text = "5 (Lowest)";
            this.m_priority5.Click += new System.EventHandler(this.changePriority);
            // 
            // spliter
            // 
            this.spliter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spliter.Location = new System.Drawing.Point(0, 24);
            this.spliter.Name = "spliter";
            // 
            // spliter.Panel1
            // 
            this.spliter.Panel1.Controls.Add(this.m_requestTree);
            // 
            // spliter.Panel2
            // 
            this.spliter.Panel2.Controls.Add(this.m_reqDecs);
            this.spliter.Size = new System.Drawing.Size(632, 457);
            this.spliter.SplitterDistance = 385;
            this.spliter.TabIndex = 3;
            // 
            // m_reqDecs
            // 
            this.m_reqDecs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.m_reqDecs.Location = new System.Drawing.Point(0, 0);
            this.m_reqDecs.Name = "m_reqDecs";
            this.m_reqDecs.Size = new System.Drawing.Size(243, 457);
            this.m_reqDecs.TabIndex = 0;
            this.m_reqDecs.Text = "";
            // 
            // m_editDesc
            // 
            this.m_editDesc.Name = "m_editDesc";
            this.m_editDesc.Size = new System.Drawing.Size(164, 22);
            this.m_editDesc.Text = "Edit Describtion";
            this.m_editDesc.Click += new System.EventHandler(this.m_editDesc_Click);
            // 
            // ChecklistView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.spliter);
            this.Controls.Add(this.m_menuBar);
            this.Name = "ChecklistView";
            this.Size = new System.Drawing.Size(632, 481);
            this.m_menuBar.ResumeLayout(false);
            this.m_menuBar.PerformLayout();
            this.m_requestContexMenu.ResumeLayout(false);
            this.spliter.Panel1.ResumeLayout(false);
            this.spliter.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.spliter)).EndInit();
            this.spliter.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView m_requestTree;
        private System.Windows.Forms.MenuStrip m_menuBar;
        private System.Windows.Forms.ToolStripMenuItem newSubRequestToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem renameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deselect;
        private System.Windows.Forms.ToolStripMenuItem clear;
        private System.Windows.Forms.ImageList m_priorityResource;
        private System.Windows.Forms.ContextMenuStrip m_requestContexMenu;
        private System.Windows.Forms.ToolStripSeparator seperator;
        private System.Windows.Forms.ToolStripMenuItem m_addSubRequest;
        private System.Windows.Forms.ToolStripMenuItem m_removeReq;
        private System.Windows.Forms.ToolStripMenuItem m_setPriority;
        private System.Windows.Forms.ToolStripMenuItem m_priorityUnset;
        private System.Windows.Forms.ToolStripMenuItem m_priority1;
        private System.Windows.Forms.ToolStripMenuItem m_priority2;
        private System.Windows.Forms.ToolStripMenuItem m_priority3;
        private System.Windows.Forms.ToolStripMenuItem m_priority4;
        private System.Windows.Forms.ToolStripMenuItem m_priority5;
        private System.Windows.Forms.SplitContainer spliter;
        private System.Windows.Forms.RichTextBox m_reqDecs;
        private System.Windows.Forms.ToolStripMenuItem m_editDesc;
    }
}
