namespace Presentation.Forms
{
    partial class NewChecklist
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
            this.m_spliter = new System.Windows.Forms.SplitContainer();
            this.m_checkList = new Presentation.Controls.ChecklistView();
            this.m_grpboxExportDirectory = new System.Windows.Forms.GroupBox();
            this.m_btnSearchExportDirectory = new System.Windows.Forms.Button();
            this.m_txtboxExportLink = new System.Windows.Forms.TextBox();
            this.m_grpboxFileName = new System.Windows.Forms.GroupBox();
            this.m_txtboxFileName = new System.Windows.Forms.TextBox();
            this.m_btnCreate = new System.Windows.Forms.Button();
            this.m_btnCancel = new System.Windows.Forms.Button();
            this.m_btnMacro = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.m_spliter)).BeginInit();
            this.m_spliter.Panel1.SuspendLayout();
            this.m_spliter.Panel2.SuspendLayout();
            this.m_spliter.SuspendLayout();
            this.m_grpboxExportDirectory.SuspendLayout();
            this.m_grpboxFileName.SuspendLayout();
            this.SuspendLayout();
            // 
            // m_spliter
            // 
            this.m_spliter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.m_spliter.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.m_spliter.IsSplitterFixed = true;
            this.m_spliter.Location = new System.Drawing.Point(0, 0);
            this.m_spliter.Name = "m_spliter";
            this.m_spliter.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // m_spliter.Panel1
            // 
            this.m_spliter.Panel1.Controls.Add(this.m_checkList);
            // 
            // m_spliter.Panel2
            // 
            this.m_spliter.Panel2.Controls.Add(this.m_grpboxExportDirectory);
            this.m_spliter.Panel2.Controls.Add(this.m_grpboxFileName);
            this.m_spliter.Panel2.Controls.Add(this.m_btnCreate);
            this.m_spliter.Panel2.Controls.Add(this.m_btnCancel);
            this.m_spliter.Size = new System.Drawing.Size(469, 477);
            this.m_spliter.SplitterDistance = 372;
            this.m_spliter.TabIndex = 0;
            // 
            // m_checkList
            // 
            this.m_checkList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.m_checkList.Location = new System.Drawing.Point(0, 0);
            this.m_checkList.Name = "m_checkList";
            this.m_checkList.Size = new System.Drawing.Size(469, 372);
            this.m_checkList.TabIndex = 0;
            // 
            // m_grpboxExportDirectory
            // 
            this.m_grpboxExportDirectory.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.m_grpboxExportDirectory.Controls.Add(this.m_btnSearchExportDirectory);
            this.m_grpboxExportDirectory.Controls.Add(this.m_txtboxExportLink);
            this.m_grpboxExportDirectory.Location = new System.Drawing.Point(2, 4);
            this.m_grpboxExportDirectory.Name = "m_grpboxExportDirectory";
            this.m_grpboxExportDirectory.Size = new System.Drawing.Size(457, 48);
            this.m_grpboxExportDirectory.TabIndex = 2;
            this.m_grpboxExportDirectory.TabStop = false;
            this.m_grpboxExportDirectory.Text = "Export directory";
            // 
            // m_btnSearchExportDirectory
            // 
            this.m_btnSearchExportDirectory.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.m_btnSearchExportDirectory.Location = new System.Drawing.Point(407, 18);
            this.m_btnSearchExportDirectory.Name = "m_btnSearchExportDirectory";
            this.m_btnSearchExportDirectory.Size = new System.Drawing.Size(43, 24);
            this.m_btnSearchExportDirectory.TabIndex = 1;
            this.m_btnSearchExportDirectory.Text = "...";
            this.m_btnSearchExportDirectory.UseVisualStyleBackColor = true;
            this.m_btnSearchExportDirectory.Click += new System.EventHandler(this.m_btnSearchExportDirectory_Click);
            // 
            // m_txtboxExportLink
            // 
            this.m_txtboxExportLink.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.m_txtboxExportLink.Location = new System.Drawing.Point(7, 20);
            this.m_txtboxExportLink.Name = "m_txtboxExportLink";
            this.m_txtboxExportLink.Size = new System.Drawing.Size(394, 20);
            this.m_txtboxExportLink.TabIndex = 0;
            // 
            // m_grpboxFileName
            // 
            this.m_grpboxFileName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.m_grpboxFileName.Controls.Add(this.m_btnMacro);
            this.m_grpboxFileName.Controls.Add(this.m_txtboxFileName);
            this.m_grpboxFileName.Location = new System.Drawing.Point(2, 50);
            this.m_grpboxFileName.Name = "m_grpboxFileName";
            this.m_grpboxFileName.Size = new System.Drawing.Size(297, 48);
            this.m_grpboxFileName.TabIndex = 3;
            this.m_grpboxFileName.TabStop = false;
            this.m_grpboxFileName.Text = "File name (without ext)";
            // 
            // m_txtboxFileName
            // 
            this.m_txtboxFileName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.m_txtboxFileName.Location = new System.Drawing.Point(7, 20);
            this.m_txtboxFileName.Name = "m_txtboxFileName";
            this.m_txtboxFileName.Size = new System.Drawing.Size(196, 20);
            this.m_txtboxFileName.TabIndex = 0;
            // 
            // m_btnCreate
            // 
            this.m_btnCreate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.m_btnCreate.Location = new System.Drawing.Point(305, 68);
            this.m_btnCreate.Name = "m_btnCreate";
            this.m_btnCreate.Size = new System.Drawing.Size(76, 23);
            this.m_btnCreate.TabIndex = 0;
            this.m_btnCreate.Text = "Create";
            this.m_btnCreate.UseVisualStyleBackColor = true;
            this.m_btnCreate.Click += new System.EventHandler(this.m_btnCreate_Click);
            // 
            // m_btnCancel
            // 
            this.m_btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.m_btnCancel.Location = new System.Drawing.Point(387, 69);
            this.m_btnCancel.Name = "m_btnCancel";
            this.m_btnCancel.Size = new System.Drawing.Size(66, 22);
            this.m_btnCancel.TabIndex = 1;
            this.m_btnCancel.Text = "Cancel";
            this.m_btnCancel.UseVisualStyleBackColor = true;
            this.m_btnCancel.Click += new System.EventHandler(this.m_btnCancel_Click);
            // 
            // m_btnMacro
            // 
            this.m_btnMacro.Location = new System.Drawing.Point(209, 18);
            this.m_btnMacro.Name = "m_btnMacro";
            this.m_btnMacro.Size = new System.Drawing.Size(82, 23);
            this.m_btnMacro.TabIndex = 1;
            this.m_btnMacro.Text = "Macro";
            this.m_btnMacro.UseVisualStyleBackColor = true;
            // 
            // NewChecklist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 477);
            this.Controls.Add(this.m_spliter);
            this.Name = "NewChecklist";
            this.Text = "New Checklist";
            this.m_spliter.Panel1.ResumeLayout(false);
            this.m_spliter.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.m_spliter)).EndInit();
            this.m_spliter.ResumeLayout(false);
            this.m_grpboxExportDirectory.ResumeLayout(false);
            this.m_grpboxExportDirectory.PerformLayout();
            this.m_grpboxFileName.ResumeLayout(false);
            this.m_grpboxFileName.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer m_spliter;
        private System.Windows.Forms.Button m_btnCancel;
        private System.Windows.Forms.Button m_btnCreate;
        private System.Windows.Forms.GroupBox m_grpboxExportDirectory;
        private System.Windows.Forms.Button m_btnSearchExportDirectory;
        private System.Windows.Forms.TextBox m_txtboxExportLink;
        private Controls.ChecklistView m_checkList;
        private System.Windows.Forms.GroupBox m_grpboxFileName;
        private System.Windows.Forms.TextBox m_txtboxFileName;
        private System.Windows.Forms.Button m_btnMacro;
    }
}