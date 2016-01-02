namespace Presentation.Forms
{
    partial class MacroHelper
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
            this.Macro = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Description = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            m_macroList = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // Macro
            // 
            this.Macro.Text = "Macro";
            // 
            // Description
            // 
            this.Description.Text = "Description";
            this.Description.Width = 220;
            // 
            // m_macroList
            // 
            m_macroList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            m_macroList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Macro,
            this.Description});
            m_macroList.FullRowSelect = true;
            m_macroList.GridLines = true;
            m_macroList.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            m_macroList.LabelWrap = false;
            m_macroList.Location = new System.Drawing.Point(12, 12);
            m_macroList.MultiSelect = false;
            m_macroList.Name = "m_macroList";
            m_macroList.Size = new System.Drawing.Size(289, 170);
            m_macroList.TabIndex = 0;
            m_macroList.UseCompatibleStateImageBehavior = false;
            m_macroList.View = System.Windows.Forms.View.Details;
            m_macroList.ItemActivate += new System.EventHandler(this.selectMacro);
            // 
            // MacroHelper
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(313, 194);
            this.Controls.Add(m_macroList);
            this.Name = "MacroHelper";
            this.Text = "Macro Helper";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ListView m_macroList;
        private System.Windows.Forms.ColumnHeader Macro;
        private System.Windows.Forms.ColumnHeader Description;

    }
}