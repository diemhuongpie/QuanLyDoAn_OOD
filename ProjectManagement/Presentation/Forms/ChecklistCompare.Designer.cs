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
            this.m_sourceList = new Presentation.Controls.ChecklistView();
            this.m_newList = new Presentation.Controls.ChecklistView();
            this.m_checklistLayout = new System.Windows.Forms.TableLayoutPanel();
            this.m_checklistLayout.SuspendLayout();
            this.SuspendLayout();
            // 
            // m_sourceList
            // 
            this.m_sourceList.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.m_sourceList.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.m_sourceList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.m_sourceList.Location = new System.Drawing.Point(3, 3);
            this.m_sourceList.Name = "m_sourceList";
            this.m_sourceList.Size = new System.Drawing.Size(320, 390);
            this.m_sourceList.TabIndex = 0;
            // 
            // m_newList
            // 
            this.m_newList.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.m_newList.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.m_newList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.m_newList.Location = new System.Drawing.Point(329, 3);
            this.m_newList.Name = "m_newList";
            this.m_newList.Size = new System.Drawing.Size(321, 390);
            this.m_newList.TabIndex = 1;
            // 
            // m_checklistLayout
            // 
            this.m_checklistLayout.ColumnCount = 2;
            this.m_checklistLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.m_checklistLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.m_checklistLayout.Controls.Add(this.m_newList, 0, 0);
            this.m_checklistLayout.Controls.Add(this.m_sourceList, 0, 0);
            this.m_checklistLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.m_checklistLayout.Location = new System.Drawing.Point(0, 0);
            this.m_checklistLayout.Name = "m_checklistLayout";
            this.m_checklistLayout.RowCount = 1;
            this.m_checklistLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.m_checklistLayout.Size = new System.Drawing.Size(653, 396);
            this.m_checklistLayout.TabIndex = 1;
            // 
            // ChecklistCompare
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(653, 396);
            this.Controls.Add(this.m_checklistLayout);
            this.Name = "ChecklistCompare";
            this.Text = "Checklist Compare";
            this.m_checklistLayout.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Controls.ChecklistView m_sourceList;
        private Controls.ChecklistView m_newList;
        private System.Windows.Forms.TableLayoutPanel m_checklistLayout;
    }
}