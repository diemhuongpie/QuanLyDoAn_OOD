namespace Presentation.Controls
{
    partial class TagObject
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
            this.m_btnDeleteTag = new System.Windows.Forms.Button();
            this.m_txtbxTagName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // m_btnDeleteTag
            // 
            this.m_btnDeleteTag.Dock = System.Windows.Forms.DockStyle.Right;
            this.m_btnDeleteTag.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.m_btnDeleteTag.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_btnDeleteTag.Location = new System.Drawing.Point(57, 0);
            this.m_btnDeleteTag.Margin = new System.Windows.Forms.Padding(0);
            this.m_btnDeleteTag.Name = "m_btnDeleteTag";
            this.m_btnDeleteTag.Size = new System.Drawing.Size(26, 20);
            this.m_btnDeleteTag.TabIndex = 0;
            this.m_btnDeleteTag.Text = "x";
            this.m_btnDeleteTag.UseVisualStyleBackColor = true;
            this.m_btnDeleteTag.Click += new System.EventHandler(this.m_btnDeleteTag_Click);
            // 
            // m_txtbxTagName
            // 
            this.m_txtbxTagName.AutoSize = true;
            this.m_txtbxTagName.Dock = System.Windows.Forms.DockStyle.Left;
            this.m_txtbxTagName.Location = new System.Drawing.Point(0, 0);
            this.m_txtbxTagName.Name = "m_txtbxTagName";
            this.m_txtbxTagName.Size = new System.Drawing.Size(57, 13);
            this.m_txtbxTagName.TabIndex = 1;
            this.m_txtbxTagName.Text = "Tag Name";
            this.m_txtbxTagName.TextChanged += new System.EventHandler(this.reSizeTagObject);
            // 
            // TagObject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.m_txtbxTagName);
            this.Controls.Add(this.m_btnDeleteTag);
            this.Name = "TagObject";
            this.Size = new System.Drawing.Size(83, 20);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button m_btnDeleteTag;
        private System.Windows.Forms.Label m_txtbxTagName;
    }
}
