namespace Presentation.Forms
{
    partial class Setting
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
            this.m_radioDefaulDir = new System.Windows.Forms.RadioButton();
            this.m_radioCustomDir = new System.Windows.Forms.RadioButton();
            this.m_txtboxCustomDirPath = new System.Windows.Forms.TextBox();
            this.m_groupStorageDir = new System.Windows.Forms.GroupBox();
            this.m_btnDirSearch = new System.Windows.Forms.Button();
            this.m_btnAccept = new System.Windows.Forms.Button();
            this.m_btnCancel = new System.Windows.Forms.Button();
            this.m_groupStorageDir.SuspendLayout();
            this.SuspendLayout();
            // 
            // m_radioDefaulDir
            // 
            this.m_radioDefaulDir.AutoSize = true;
            this.m_radioDefaulDir.Location = new System.Drawing.Point(6, 19);
            this.m_radioDefaulDir.Name = "m_radioDefaulDir";
            this.m_radioDefaulDir.Size = new System.Drawing.Size(122, 17);
            this.m_radioDefaulDir.TabIndex = 0;
            this.m_radioDefaulDir.TabStop = true;
            this.m_radioDefaulDir.Text = "Use default directory";
            this.m_radioDefaulDir.UseVisualStyleBackColor = true;
            this.m_radioDefaulDir.CheckedChanged += new System.EventHandler(this.changeMode);
            // 
            // m_radioCustomDir
            // 
            this.m_radioCustomDir.AutoSize = true;
            this.m_radioCustomDir.Location = new System.Drawing.Point(6, 42);
            this.m_radioCustomDir.Name = "m_radioCustomDir";
            this.m_radioCustomDir.Size = new System.Drawing.Size(124, 17);
            this.m_radioCustomDir.TabIndex = 1;
            this.m_radioCustomDir.TabStop = true;
            this.m_radioCustomDir.Text = "Use custom directory";
            this.m_radioCustomDir.UseVisualStyleBackColor = true;
            this.m_radioCustomDir.CheckedChanged += new System.EventHandler(this.changeMode);
            // 
            // m_txtboxCustomDirPath
            // 
            this.m_txtboxCustomDirPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.m_txtboxCustomDirPath.Location = new System.Drawing.Point(6, 75);
            this.m_txtboxCustomDirPath.Name = "m_txtboxCustomDirPath";
            this.m_txtboxCustomDirPath.Size = new System.Drawing.Size(362, 20);
            this.m_txtboxCustomDirPath.TabIndex = 2;
            // 
            // m_groupStorageDir
            // 
            this.m_groupStorageDir.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.m_groupStorageDir.Controls.Add(this.m_btnDirSearch);
            this.m_groupStorageDir.Controls.Add(this.m_radioDefaulDir);
            this.m_groupStorageDir.Controls.Add(this.m_radioCustomDir);
            this.m_groupStorageDir.Controls.Add(this.m_txtboxCustomDirPath);
            this.m_groupStorageDir.Location = new System.Drawing.Point(12, 12);
            this.m_groupStorageDir.Name = "m_groupStorageDir";
            this.m_groupStorageDir.Size = new System.Drawing.Size(417, 107);
            this.m_groupStorageDir.TabIndex = 3;
            this.m_groupStorageDir.TabStop = false;
            this.m_groupStorageDir.Text = "Project storage directory";
            // 
            // m_btnDirSearch
            // 
            this.m_btnDirSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.m_btnDirSearch.Location = new System.Drawing.Point(374, 75);
            this.m_btnDirSearch.Name = "m_btnDirSearch";
            this.m_btnDirSearch.Size = new System.Drawing.Size(37, 21);
            this.m_btnDirSearch.TabIndex = 6;
            this.m_btnDirSearch.Text = "...";
            this.m_btnDirSearch.UseVisualStyleBackColor = true;
            // 
            // m_btnAccept
            // 
            this.m_btnAccept.Location = new System.Drawing.Point(273, 125);
            this.m_btnAccept.Name = "m_btnAccept";
            this.m_btnAccept.Size = new System.Drawing.Size(75, 23);
            this.m_btnAccept.TabIndex = 4;
            this.m_btnAccept.Text = "Accept";
            this.m_btnAccept.UseVisualStyleBackColor = true;
            this.m_btnAccept.Click += new System.EventHandler(this.m_btnAccept_Click);
            // 
            // m_btnCancel
            // 
            this.m_btnCancel.Location = new System.Drawing.Point(354, 125);
            this.m_btnCancel.Name = "m_btnCancel";
            this.m_btnCancel.Size = new System.Drawing.Size(75, 23);
            this.m_btnCancel.TabIndex = 5;
            this.m_btnCancel.Text = "Cancel";
            this.m_btnCancel.UseVisualStyleBackColor = true;
            this.m_btnCancel.Click += new System.EventHandler(this.m_btnCancel_Click);
            // 
            // Setting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 158);
            this.Controls.Add(this.m_groupStorageDir);
            this.Controls.Add(this.m_btnCancel);
            this.Controls.Add(this.m_btnAccept);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Setting";
            this.Text = "Setting";
            this.Shown += new System.EventHandler(this.Setting_Shown);
            this.m_groupStorageDir.ResumeLayout(false);
            this.m_groupStorageDir.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RadioButton m_radioDefaulDir;
        private System.Windows.Forms.RadioButton m_radioCustomDir;
        private System.Windows.Forms.TextBox m_txtboxCustomDirPath;
        private System.Windows.Forms.GroupBox m_groupStorageDir;
        private System.Windows.Forms.Button m_btnAccept;
        private System.Windows.Forms.Button m_btnCancel;
        private System.Windows.Forms.Button m_btnDirSearch;
    }
}