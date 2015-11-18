namespace Presentation.Controls
{
    partial class ChecklistCompare
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.m_splitContainerLists = new System.Windows.Forms.SplitContainer();
            this.m_sourceList = new Presentation.Controls.ChecklistView();
            this.m_newList = new Presentation.Controls.ChecklistView();
            ((System.ComponentModel.ISupportInitialize)(this.m_splitContainerLists)).BeginInit();
            this.m_splitContainerLists.Panel1.SuspendLayout();
            this.m_splitContainerLists.Panel2.SuspendLayout();
            this.m_splitContainerLists.SuspendLayout();
            this.SuspendLayout();
            // 
            // m_splitContainerLists
            // 
            this.m_splitContainerLists.Dock = System.Windows.Forms.DockStyle.Fill;
            this.m_splitContainerLists.Location = new System.Drawing.Point(0, 0);
            this.m_splitContainerLists.Name = "m_splitContainerLists";
            // 
            // m_splitContainerLists.Panel1
            // 
            this.m_splitContainerLists.Panel1.Controls.Add(this.m_sourceList);
            // 
            // m_splitContainerLists.Panel2
            // 
            this.m_splitContainerLists.Panel2.Controls.Add(this.m_newList);
            this.m_splitContainerLists.Size = new System.Drawing.Size(653, 396);
            this.m_splitContainerLists.SplitterDistance = 319;
            this.m_splitContainerLists.TabIndex = 0;
            // 
            // m_sourceList
            // 
            this.m_sourceList.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.m_sourceList.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.m_sourceList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.m_sourceList.Location = new System.Drawing.Point(0, 0);
            this.m_sourceList.Name = "m_sourceList";
            this.m_sourceList.Size = new System.Drawing.Size(319, 396);
            this.m_sourceList.TabIndex = 0;
            // 
            // m_newList
            // 
            this.m_newList.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.m_newList.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.m_newList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.m_newList.Enabled = false;
            this.m_newList.Location = new System.Drawing.Point(0, 0);
            this.m_newList.Name = "m_newList";
            this.m_newList.Size = new System.Drawing.Size(330, 396);
            this.m_newList.TabIndex = 1;
            // 
            // ChecklistCompare
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(653, 396);
            this.Controls.Add(this.m_splitContainerLists);
            this.Name = "ChecklistCompare";
            this.Text = "Checklist Compare";
            this.m_splitContainerLists.Panel1.ResumeLayout(false);
            this.m_splitContainerLists.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.m_splitContainerLists)).EndInit();
            this.m_splitContainerLists.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer m_splitContainerLists;
        private Controls.ChecklistView m_sourceList;
        private Controls.ChecklistView m_newList;
    }
}