namespace Presentation.Forms
{
    partial class TypingDialog
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
            this.m_textbox = new System.Windows.Forms.RichTextBox();
            this.m_accept = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // m_textbox
            // 
            this.m_textbox.Location = new System.Drawing.Point(12, 12);
            this.m_textbox.Name = "m_textbox";
            this.m_textbox.Size = new System.Drawing.Size(451, 98);
            this.m_textbox.TabIndex = 0;
            this.m_textbox.Text = "";
            // 
            // m_accept
            // 
            this.m_accept.Location = new System.Drawing.Point(388, 116);
            this.m_accept.Name = "m_accept";
            this.m_accept.Size = new System.Drawing.Size(75, 23);
            this.m_accept.TabIndex = 1;
            this.m_accept.Text = "Accept";
            this.m_accept.UseVisualStyleBackColor = true;
            this.m_accept.Click += new System.EventHandler(this.m_accept_Click);
            // 
            // TextypingDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(475, 145);
            this.Controls.Add(this.m_accept);
            this.Controls.Add(this.m_textbox);
            this.Name = "TextypingDialog";
            this.Text = "Typing Dialog";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox m_textbox;
        private System.Windows.Forms.Button m_accept;
    }
}