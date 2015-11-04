namespace Presentation.Controls
{
    partial class NewProject
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
            this.m_splitContainerPreview = new System.Windows.Forms.SplitContainer();
            this.m_txtboxProjectName = new System.Windows.Forms.TextBox();
            this.m_lblDescription = new System.Windows.Forms.Label();
            this.m_rtxtboxProjectDescription = new System.Windows.Forms.RichTextBox();
            this.m_grpboxAuthor = new System.Windows.Forms.GroupBox();
            this.m_authorList = new System.Windows.Forms.DataGridView();
            this.m_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.m_additionalInfo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.m_btnAddAuthor = new System.Windows.Forms.Button();
            this.m_labelAInfo = new System.Windows.Forms.Label();
            this.m_groupName = new System.Windows.Forms.Label();
            this.m_txtboxAInfo = new System.Windows.Forms.TextBox();
            this.m_txtboxGroupName = new System.Windows.Forms.TextBox();
            this.m_labelAuthorName = new System.Windows.Forms.Label();
            this.m_txtboxAuthorName = new System.Windows.Forms.TextBox();
            this.m_labelProjectName = new System.Windows.Forms.Label();
            this.m_splitContainerButtons = new System.Windows.Forms.SplitContainer();
            this.m_overView = new System.Windows.Forms.RichTextBox();
            this.m_btnCancel = new System.Windows.Forms.Button();
            this.m_btnCreate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.m_splitContainerPreview)).BeginInit();
            this.m_splitContainerPreview.Panel1.SuspendLayout();
            this.m_splitContainerPreview.Panel2.SuspendLayout();
            this.m_splitContainerPreview.SuspendLayout();
            this.m_grpboxAuthor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m_authorList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_splitContainerButtons)).BeginInit();
            this.m_splitContainerButtons.Panel1.SuspendLayout();
            this.m_splitContainerButtons.Panel2.SuspendLayout();
            this.m_splitContainerButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // m_splitContainerPreview
            // 
            this.m_splitContainerPreview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.m_splitContainerPreview.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.m_splitContainerPreview.Location = new System.Drawing.Point(0, 0);
            this.m_splitContainerPreview.Name = "m_splitContainerPreview";
            // 
            // m_splitContainerPreview.Panel1
            // 
            this.m_splitContainerPreview.Panel1.Controls.Add(this.m_txtboxProjectName);
            this.m_splitContainerPreview.Panel1.Controls.Add(this.m_lblDescription);
            this.m_splitContainerPreview.Panel1.Controls.Add(this.m_rtxtboxProjectDescription);
            this.m_splitContainerPreview.Panel1.Controls.Add(this.m_grpboxAuthor);
            this.m_splitContainerPreview.Panel1.Controls.Add(this.m_labelProjectName);
            // 
            // m_splitContainerPreview.Panel2
            // 
            this.m_splitContainerPreview.Panel2.Controls.Add(this.m_splitContainerButtons);
            this.m_splitContainerPreview.Size = new System.Drawing.Size(697, 448);
            this.m_splitContainerPreview.SplitterDistance = 351;
            this.m_splitContainerPreview.TabIndex = 7;
            // 
            // m_txtboxProjectName
            // 
            this.m_txtboxProjectName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.m_txtboxProjectName.Location = new System.Drawing.Point(96, 6);
            this.m_txtboxProjectName.Name = "m_txtboxProjectName";
            this.m_txtboxProjectName.Size = new System.Drawing.Size(249, 20);
            this.m_txtboxProjectName.TabIndex = 1;
            // 
            // m_lblDescription
            // 
            this.m_lblDescription.AutoSize = true;
            this.m_lblDescription.Location = new System.Drawing.Point(13, 36);
            this.m_lblDescription.Name = "m_lblDescription";
            this.m_lblDescription.Size = new System.Drawing.Size(65, 13);
            this.m_lblDescription.TabIndex = 13;
            this.m_lblDescription.Text = "Descripstion";
            // 
            // m_rtxtboxProjectDescription
            // 
            this.m_rtxtboxProjectDescription.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.m_rtxtboxProjectDescription.Location = new System.Drawing.Point(96, 32);
            this.m_rtxtboxProjectDescription.Name = "m_rtxtboxProjectDescription";
            this.m_rtxtboxProjectDescription.Size = new System.Drawing.Size(249, 89);
            this.m_rtxtboxProjectDescription.TabIndex = 2;
            this.m_rtxtboxProjectDescription.Text = "";
            // 
            // m_grpboxAuthor
            // 
            this.m_grpboxAuthor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.m_grpboxAuthor.Controls.Add(this.m_groupName);
            this.m_grpboxAuthor.Controls.Add(this.m_txtboxGroupName);
            this.m_grpboxAuthor.Controls.Add(this.m_labelAuthorName);
            this.m_grpboxAuthor.Controls.Add(this.m_txtboxAuthorName);
            this.m_grpboxAuthor.Controls.Add(this.m_labelAInfo);
            this.m_grpboxAuthor.Controls.Add(this.m_txtboxAInfo);
            this.m_grpboxAuthor.Controls.Add(this.m_btnAddAuthor);
            this.m_grpboxAuthor.Controls.Add(this.m_authorList);
            this.m_grpboxAuthor.Location = new System.Drawing.Point(12, 127);
            this.m_grpboxAuthor.Name = "m_grpboxAuthor";
            this.m_grpboxAuthor.Size = new System.Drawing.Size(333, 321);
            this.m_grpboxAuthor.TabIndex = 12;
            this.m_grpboxAuthor.TabStop = false;
            this.m_grpboxAuthor.Text = "Author(s)";
            // 
            // m_authorList
            // 
            this.m_authorList.AllowUserToAddRows = false;
            this.m_authorList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.m_authorList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.m_authorList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.m_name,
            this.m_additionalInfo});
            this.m_authorList.Location = new System.Drawing.Point(4, 97);
            this.m_authorList.Name = "m_authorList";
            this.m_authorList.Size = new System.Drawing.Size(329, 218);
            this.m_authorList.TabIndex = 7;
            // 
            // m_name
            // 
            this.m_name.HeaderText = "Full Name";
            this.m_name.Name = "m_name";
            this.m_name.Width = 185;
            // 
            // m_additionalInfo
            // 
            this.m_additionalInfo.HeaderText = "Additional Info";
            this.m_additionalInfo.Name = "m_additionalInfo";
            // 
            // m_btnAddAuthor
            // 
            this.m_btnAddAuthor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.m_btnAddAuthor.Location = new System.Drawing.Point(252, 70);
            this.m_btnAddAuthor.Name = "m_btnAddAuthor";
            this.m_btnAddAuthor.Size = new System.Drawing.Size(74, 20);
            this.m_btnAddAuthor.TabIndex = 6;
            this.m_btnAddAuthor.Text = "Add";
            this.m_btnAddAuthor.UseVisualStyleBackColor = true;
            this.m_btnAddAuthor.Click += new System.EventHandler(this.addAuthor);
            // 
            // m_labelAInfo
            // 
            this.m_labelAInfo.AutoSize = true;
            this.m_labelAInfo.Location = new System.Drawing.Point(2, 74);
            this.m_labelAInfo.Name = "m_labelAInfo";
            this.m_labelAInfo.Size = new System.Drawing.Size(74, 13);
            this.m_labelAInfo.TabIndex = 9;
            this.m_labelAInfo.Text = "Additional Info";
            // 
            // m_groupName
            // 
            this.m_groupName.AutoSize = true;
            this.m_groupName.Location = new System.Drawing.Point(2, 22);
            this.m_groupName.Name = "m_groupName";
            this.m_groupName.Size = new System.Drawing.Size(74, 13);
            this.m_groupName.TabIndex = 11;
            this.m_groupName.Text = "Group\'s Name";
            // 
            // m_txtboxAInfo
            // 
            this.m_txtboxAInfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.m_txtboxAInfo.Location = new System.Drawing.Point(78, 71);
            this.m_txtboxAInfo.MaxLength = 20;
            this.m_txtboxAInfo.Name = "m_txtboxAInfo";
            this.m_txtboxAInfo.Size = new System.Drawing.Size(168, 20);
            this.m_txtboxAInfo.TabIndex = 5;
            // 
            // m_txtboxGroupName
            // 
            this.m_txtboxGroupName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.m_txtboxGroupName.Location = new System.Drawing.Point(78, 19);
            this.m_txtboxGroupName.Name = "m_txtboxGroupName";
            this.m_txtboxGroupName.Size = new System.Drawing.Size(249, 20);
            this.m_txtboxGroupName.TabIndex = 3;
            // 
            // m_labelAuthorName
            // 
            this.m_labelAuthorName.AutoSize = true;
            this.m_labelAuthorName.Location = new System.Drawing.Point(0, 48);
            this.m_labelAuthorName.Name = "m_labelAuthorName";
            this.m_labelAuthorName.Size = new System.Drawing.Size(76, 13);
            this.m_labelAuthorName.TabIndex = 7;
            this.m_labelAuthorName.Text = "Author\'s Name";
            // 
            // m_txtboxAuthorName
            // 
            this.m_txtboxAuthorName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.m_txtboxAuthorName.Location = new System.Drawing.Point(78, 45);
            this.m_txtboxAuthorName.Name = "m_txtboxAuthorName";
            this.m_txtboxAuthorName.Size = new System.Drawing.Size(249, 20);
            this.m_txtboxAuthorName.TabIndex = 4;
            // 
            // m_labelProjectName
            // 
            this.m_labelProjectName.AutoSize = true;
            this.m_labelProjectName.Location = new System.Drawing.Point(13, 9);
            this.m_labelProjectName.Name = "m_labelProjectName";
            this.m_labelProjectName.Size = new System.Drawing.Size(78, 13);
            this.m_labelProjectName.TabIndex = 9;
            this.m_labelProjectName.Text = "Project\'s Name";
            // 
            // m_splitContainerButtons
            // 
            this.m_splitContainerButtons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.m_splitContainerButtons.Location = new System.Drawing.Point(0, 0);
            this.m_splitContainerButtons.Name = "m_splitContainerButtons";
            this.m_splitContainerButtons.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // m_splitContainerButtons.Panel1
            // 
            this.m_splitContainerButtons.Panel1.Controls.Add(this.m_overView);
            // 
            // m_splitContainerButtons.Panel2
            // 
            this.m_splitContainerButtons.Panel2.Controls.Add(this.m_btnCancel);
            this.m_splitContainerButtons.Panel2.Controls.Add(this.m_btnCreate);
            this.m_splitContainerButtons.Size = new System.Drawing.Size(342, 448);
            this.m_splitContainerButtons.SplitterDistance = 409;
            this.m_splitContainerButtons.TabIndex = 0;
            // 
            // m_overView
            // 
            this.m_overView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.m_overView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.m_overView.Enabled = false;
            this.m_overView.Location = new System.Drawing.Point(0, 0);
            this.m_overView.Name = "m_overView";
            this.m_overView.ReadOnly = true;
            this.m_overView.Size = new System.Drawing.Size(342, 409);
            this.m_overView.TabIndex = 8;
            this.m_overView.Text = "";
            // 
            // m_btnCancel
            // 
            this.m_btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.m_btnCancel.Location = new System.Drawing.Point(188, 3);
            this.m_btnCancel.Name = "m_btnCancel";
            this.m_btnCancel.Size = new System.Drawing.Size(75, 28);
            this.m_btnCancel.TabIndex = 9;
            this.m_btnCancel.Text = "Cancel";
            this.m_btnCancel.UseVisualStyleBackColor = true;
            this.m_btnCancel.Click += new System.EventHandler(this.m_btnCancel_Click);
            // 
            // m_btnCreate
            // 
            this.m_btnCreate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.m_btnCreate.Location = new System.Drawing.Point(264, 3);
            this.m_btnCreate.Name = "m_btnCreate";
            this.m_btnCreate.Size = new System.Drawing.Size(75, 28);
            this.m_btnCreate.TabIndex = 8;
            this.m_btnCreate.Text = "Create";
            this.m_btnCreate.UseVisualStyleBackColor = true;
            this.m_btnCreate.Click += new System.EventHandler(this.m_btnCreate_Click);
            // 
            // NewProject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(697, 448);
            this.Controls.Add(this.m_splitContainerPreview);
            this.Name = "NewProject";
            this.Text = "New Project";
            this.m_splitContainerPreview.Panel1.ResumeLayout(false);
            this.m_splitContainerPreview.Panel1.PerformLayout();
            this.m_splitContainerPreview.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.m_splitContainerPreview)).EndInit();
            this.m_splitContainerPreview.ResumeLayout(false);
            this.m_grpboxAuthor.ResumeLayout(false);
            this.m_grpboxAuthor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m_authorList)).EndInit();
            this.m_splitContainerButtons.Panel1.ResumeLayout(false);
            this.m_splitContainerButtons.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.m_splitContainerButtons)).EndInit();
            this.m_splitContainerButtons.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer m_splitContainerPreview;
        private System.Windows.Forms.GroupBox m_grpboxAuthor;
        private System.Windows.Forms.Label m_groupName;
        private System.Windows.Forms.TextBox m_txtboxGroupName;
        private System.Windows.Forms.Label m_labelProjectName;
        private System.Windows.Forms.TextBox m_txtboxProjectName;
        private System.Windows.Forms.RichTextBox m_rtxtboxProjectDescription;
        private System.Windows.Forms.Label m_lblDescription;
        private System.Windows.Forms.SplitContainer m_splitContainerButtons;
        private System.Windows.Forms.RichTextBox m_overView;
        private System.Windows.Forms.Button m_btnCancel;
        private System.Windows.Forms.Button m_btnCreate;
        private System.Windows.Forms.DataGridView m_authorList;
        private System.Windows.Forms.DataGridViewTextBoxColumn m_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn m_additionalInfo;
        private System.Windows.Forms.Button m_btnAddAuthor;
        private System.Windows.Forms.Label m_labelAInfo;
        private System.Windows.Forms.TextBox m_txtboxAInfo;
        private System.Windows.Forms.Label m_labelAuthorName;
        private System.Windows.Forms.TextBox m_txtboxAuthorName;

    }
}