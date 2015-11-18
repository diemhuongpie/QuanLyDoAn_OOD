namespace Presentation.Controls
{
    partial class ProjectExplorer
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
            this.m_projectList = new System.Windows.Forms.TableLayoutPanel();
            this.m_spliterToolBar_ProjectList = new System.Windows.Forms.SplitContainer();
            this.m_menubar = new System.Windows.Forms.MenuStrip();
            this.m_delete = new System.Windows.Forms.ToolStripMenuItem();
            this.m_deselect = new System.Windows.Forms.ToolStripMenuItem();
            this.m_selectAll = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.m_spliterToolBar_ProjectList)).BeginInit();
            this.m_spliterToolBar_ProjectList.Panel1.SuspendLayout();
            this.m_spliterToolBar_ProjectList.Panel2.SuspendLayout();
            this.m_spliterToolBar_ProjectList.SuspendLayout();
            this.m_menubar.SuspendLayout();
            this.SuspendLayout();
            // 
            // m_projectList
            // 
            this.m_projectList.AutoScroll = true;
            this.m_projectList.AutoSize = true;
            this.m_projectList.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.m_projectList.ColumnCount = 1;
            this.m_projectList.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.m_projectList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.m_projectList.Location = new System.Drawing.Point(0, 0);
            this.m_projectList.Name = "m_projectList";
            this.m_projectList.RowCount = 1;
            this.m_projectList.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.m_projectList.Size = new System.Drawing.Size(465, 387);
            this.m_projectList.TabIndex = 5;
            // 
            // m_spliterToolBar_ProjectList
            // 
            this.m_spliterToolBar_ProjectList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.m_spliterToolBar_ProjectList.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.m_spliterToolBar_ProjectList.Location = new System.Drawing.Point(0, 0);
            this.m_spliterToolBar_ProjectList.Name = "m_spliterToolBar_ProjectList";
            this.m_spliterToolBar_ProjectList.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // m_spliterToolBar_ProjectList.Panel1
            // 
            this.m_spliterToolBar_ProjectList.Panel1.Controls.Add(this.m_menubar);
            // 
            // m_spliterToolBar_ProjectList.Panel2
            // 
            this.m_spliterToolBar_ProjectList.Panel2.Controls.Add(this.m_projectList);
            this.m_spliterToolBar_ProjectList.Size = new System.Drawing.Size(465, 413);
            this.m_spliterToolBar_ProjectList.SplitterDistance = 25;
            this.m_spliterToolBar_ProjectList.SplitterWidth = 1;
            this.m_spliterToolBar_ProjectList.TabIndex = 0;
            // 
            // m_menubar
            // 
            this.m_menubar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.m_delete,
            this.m_deselect,
            this.m_selectAll});
            this.m_menubar.Location = new System.Drawing.Point(0, 0);
            this.m_menubar.Name = "m_menubar";
            this.m_menubar.Size = new System.Drawing.Size(465, 24);
            this.m_menubar.TabIndex = 1;
            // 
            // m_delete
            // 
            this.m_delete.Name = "m_delete";
            this.m_delete.ShortcutKeys = System.Windows.Forms.Keys.Delete;
            this.m_delete.Size = new System.Drawing.Size(52, 20);
            this.m_delete.Text = "Delete";
            this.m_delete.ToolTipText = "Del";
            this.m_delete.Click += new System.EventHandler(this.deleteSelectedProjects);
            // 
            // m_deselect
            // 
            this.m_deselect.Name = "m_deselect";
            this.m_deselect.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D)));
            this.m_deselect.Size = new System.Drawing.Size(63, 20);
            this.m_deselect.Text = "Deselect";
            this.m_deselect.ToolTipText = "Ctrl + D";
            this.m_deselect.Click += new System.EventHandler(this.deselectProjects);
            // 
            // m_selectAll
            // 
            this.m_selectAll.Name = "m_selectAll";
            this.m_selectAll.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.m_selectAll.Size = new System.Drawing.Size(67, 20);
            this.m_selectAll.Text = "Select All";
            this.m_selectAll.Visible = false;
            this.m_selectAll.Click += new System.EventHandler(this.selectAllProjects);
            // 
            // ProjectExplorer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.m_spliterToolBar_ProjectList);
            this.Name = "ProjectExplorer";
            this.Size = new System.Drawing.Size(465, 413);
            this.m_spliterToolBar_ProjectList.Panel1.ResumeLayout(false);
            this.m_spliterToolBar_ProjectList.Panel1.PerformLayout();
            this.m_spliterToolBar_ProjectList.Panel2.ResumeLayout(false);
            this.m_spliterToolBar_ProjectList.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m_spliterToolBar_ProjectList)).EndInit();
            this.m_spliterToolBar_ProjectList.ResumeLayout(false);
            this.m_menubar.ResumeLayout(false);
            this.m_menubar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel m_projectList;
        private System.Windows.Forms.SplitContainer m_spliterToolBar_ProjectList;
        private System.Windows.Forms.MenuStrip m_menubar;
        private System.Windows.Forms.ToolStripMenuItem m_delete;
        private System.Windows.Forms.ToolStripMenuItem m_deselect;
        private System.Windows.Forms.ToolStripMenuItem m_selectAll;

    }
}
