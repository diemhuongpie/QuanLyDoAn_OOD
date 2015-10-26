namespace Presentation.Forms
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
            this.label2 = new System.Windows.Forms.Label();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.m_labelAInfo = new System.Windows.Forms.Label();
            this.m_txtboxAInfo = new System.Windows.Forms.TextBox();
            this.m_labelAuthorName = new System.Windows.Forms.Label();
            this.m_txtboxAuthorName = new System.Windows.Forms.TextBox();
            this.m_groupName = new System.Windows.Forms.Label();
            this.m_txtboxGroupName = new System.Windows.Forms.TextBox();
            this.m_labelProjectName = new System.Windows.Forms.Label();
            this.m_txtboxProjectName = new System.Windows.Forms.TextBox();
            this.m_splitContainerButtons = new System.Windows.Forms.SplitContainer();
            this.m_overView = new System.Windows.Forms.RichTextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.m_btnCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.m_splitContainerPreview)).BeginInit();
            this.m_splitContainerPreview.Panel1.SuspendLayout();
            this.m_splitContainerPreview.Panel2.SuspendLayout();
            this.m_splitContainerPreview.SuspendLayout();
            this.groupBox1.SuspendLayout();
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
            this.m_splitContainerPreview.Panel1.Controls.Add(this.label2);
            this.m_splitContainerPreview.Panel1.Controls.Add(this.treeView1);
            this.m_splitContainerPreview.Panel1.Controls.Add(this.richTextBox2);
            this.m_splitContainerPreview.Panel1.Controls.Add(this.label1);
            this.m_splitContainerPreview.Panel1.Controls.Add(this.groupBox1);
            this.m_splitContainerPreview.Panel1.Controls.Add(this.m_groupName);
            this.m_splitContainerPreview.Panel1.Controls.Add(this.m_txtboxGroupName);
            this.m_splitContainerPreview.Panel1.Controls.Add(this.m_labelProjectName);
            this.m_splitContainerPreview.Panel1.Controls.Add(this.m_txtboxProjectName);
            // 
            // m_splitContainerPreview.Panel2
            // 
            this.m_splitContainerPreview.Panel2.Controls.Add(this.m_splitContainerButtons);
            this.m_splitContainerPreview.Size = new System.Drawing.Size(697, 448);
            this.m_splitContainerPreview.SplitterDistance = 350;
            this.m_splitContainerPreview.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 241);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Request(es)";
            // 
            // treeView1
            // 
            this.treeView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.treeView1.Location = new System.Drawing.Point(12, 260);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(332, 176);
            this.treeView1.TabIndex = 15;
            // 
            // richTextBox2
            // 
            this.richTextBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBox2.Location = new System.Drawing.Point(96, 32);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(248, 89);
            this.richTextBox2.TabIndex = 14;
            this.richTextBox2.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Descripstion";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.m_labelAInfo);
            this.groupBox1.Controls.Add(this.m_txtboxAInfo);
            this.groupBox1.Controls.Add(this.m_labelAuthorName);
            this.groupBox1.Controls.Add(this.m_txtboxAuthorName);
            this.groupBox1.Location = new System.Drawing.Point(12, 158);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(332, 75);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Author(s)";
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(258, 45);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(74, 20);
            this.button1.TabIndex = 10;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // m_labelAInfo
            // 
            this.m_labelAInfo.AutoSize = true;
            this.m_labelAInfo.Location = new System.Drawing.Point(1, 48);
            this.m_labelAInfo.Name = "m_labelAInfo";
            this.m_labelAInfo.Size = new System.Drawing.Size(74, 13);
            this.m_labelAInfo.TabIndex = 9;
            this.m_labelAInfo.Text = "Additional Info";
            // 
            // m_txtboxAInfo
            // 
            this.m_txtboxAInfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.m_txtboxAInfo.Location = new System.Drawing.Point(85, 45);
            this.m_txtboxAInfo.MaxLength = 20;
            this.m_txtboxAInfo.Name = "m_txtboxAInfo";
            this.m_txtboxAInfo.Size = new System.Drawing.Size(167, 20);
            this.m_txtboxAInfo.TabIndex = 8;
            // 
            // m_labelAuthorName
            // 
            this.m_labelAuthorName.AutoSize = true;
            this.m_labelAuthorName.Location = new System.Drawing.Point(1, 22);
            this.m_labelAuthorName.Name = "m_labelAuthorName";
            this.m_labelAuthorName.Size = new System.Drawing.Size(76, 13);
            this.m_labelAuthorName.TabIndex = 7;
            this.m_labelAuthorName.Text = "Author\'s Name";
            // 
            // m_txtboxAuthorName
            // 
            this.m_txtboxAuthorName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.m_txtboxAuthorName.Location = new System.Drawing.Point(85, 19);
            this.m_txtboxAuthorName.Name = "m_txtboxAuthorName";
            this.m_txtboxAuthorName.Size = new System.Drawing.Size(247, 20);
            this.m_txtboxAuthorName.TabIndex = 6;
            // 
            // m_groupName
            // 
            this.m_groupName.AutoSize = true;
            this.m_groupName.Location = new System.Drawing.Point(13, 131);
            this.m_groupName.Name = "m_groupName";
            this.m_groupName.Size = new System.Drawing.Size(74, 13);
            this.m_groupName.TabIndex = 11;
            this.m_groupName.Text = "Group\'s Name";
            // 
            // m_txtboxGroupName
            // 
            this.m_txtboxGroupName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.m_txtboxGroupName.Location = new System.Drawing.Point(96, 128);
            this.m_txtboxGroupName.Name = "m_txtboxGroupName";
            this.m_txtboxGroupName.Size = new System.Drawing.Size(248, 20);
            this.m_txtboxGroupName.TabIndex = 10;
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
            // m_txtboxProjectName
            // 
            this.m_txtboxProjectName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.m_txtboxProjectName.Location = new System.Drawing.Point(96, 6);
            this.m_txtboxProjectName.Name = "m_txtboxProjectName";
            this.m_txtboxProjectName.Size = new System.Drawing.Size(248, 20);
            this.m_txtboxProjectName.TabIndex = 8;
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
            this.m_splitContainerButtons.Panel2.Controls.Add(this.button2);
            this.m_splitContainerButtons.Size = new System.Drawing.Size(343, 448);
            this.m_splitContainerButtons.SplitterDistance = 409;
            this.m_splitContainerButtons.TabIndex = 0;
            // 
            // m_overView
            // 
            this.m_overView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.m_overView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.m_overView.Location = new System.Drawing.Point(0, 0);
            this.m_overView.Name = "m_overView";
            this.m_overView.ReadOnly = true;
            this.m_overView.Size = new System.Drawing.Size(343, 409);
            this.m_overView.TabIndex = 8;
            this.m_overView.Text = "";
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Location = new System.Drawing.Point(265, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 28);
            this.button2.TabIndex = 0;
            this.button2.Text = "Create";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // m_btnCancel
            // 
            this.m_btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.m_btnCancel.Location = new System.Drawing.Point(184, 3);
            this.m_btnCancel.Name = "m_btnCancel";
            this.m_btnCancel.Size = new System.Drawing.Size(75, 28);
            this.m_btnCancel.TabIndex = 1;
            this.m_btnCancel.Text = "Cancel";
            this.m_btnCancel.UseVisualStyleBackColor = true;
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
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.m_splitContainerButtons.Panel1.ResumeLayout(false);
            this.m_splitContainerButtons.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.m_splitContainerButtons)).EndInit();
            this.m_splitContainerButtons.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer m_splitContainerPreview;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label m_labelAInfo;
        private System.Windows.Forms.TextBox m_txtboxAInfo;
        private System.Windows.Forms.Label m_labelAuthorName;
        private System.Windows.Forms.TextBox m_txtboxAuthorName;
        private System.Windows.Forms.Label m_groupName;
        private System.Windows.Forms.TextBox m_txtboxGroupName;
        private System.Windows.Forms.Label m_labelProjectName;
        private System.Windows.Forms.TextBox m_txtboxProjectName;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.SplitContainer m_splitContainerButtons;
        private System.Windows.Forms.RichTextBox m_overView;
        private System.Windows.Forms.Button m_btnCancel;
        private System.Windows.Forms.Button button2;

    }
}