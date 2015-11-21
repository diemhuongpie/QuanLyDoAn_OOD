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
            this.m_icons = new System.Windows.Forms.ImageList(this.components);
            this.m_menuBar = new System.Windows.Forms.MenuStrip();
            this.newSubRequestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.renameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deselect = new System.Windows.Forms.ToolStripMenuItem();
            this.m_menuBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // m_requestTree
            // 
            this.m_requestTree.CheckBoxes = true;
            this.m_requestTree.Dock = System.Windows.Forms.DockStyle.Fill;
            this.m_requestTree.ImageIndex = 0;
            this.m_requestTree.ImageList = this.m_icons;
            this.m_requestTree.LabelEdit = true;
            this.m_requestTree.Location = new System.Drawing.Point(0, 24);
            this.m_requestTree.Name = "m_requestTree";
            this.m_requestTree.SelectedImageIndex = 0;
            this.m_requestTree.Size = new System.Drawing.Size(481, 457);
            this.m_requestTree.TabIndex = 0;
            this.m_requestTree.Click += new System.EventHandler(this.deselecting);
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
            // m_menuBar
            // 
            this.m_menuBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newSubRequestToolStripMenuItem,
            this.deleteToolStripMenuItem,
            this.renameToolStripMenuItem,
            this.deselect});
            this.m_menuBar.Location = new System.Drawing.Point(0, 0);
            this.m_menuBar.Name = "m_menuBar";
            this.m_menuBar.Size = new System.Drawing.Size(481, 24);
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
            // ChecklistView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.m_requestTree);
            this.Controls.Add(this.m_menuBar);
            this.Name = "ChecklistView";
            this.Size = new System.Drawing.Size(481, 481);
            this.m_menuBar.ResumeLayout(false);
            this.m_menuBar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ImageList m_icons;
        private System.Windows.Forms.TreeView m_requestTree;
        private System.Windows.Forms.MenuStrip m_menuBar;
        private System.Windows.Forms.ToolStripMenuItem newSubRequestToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem renameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deselect;
    }
}
