using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentation.Forms
{
    public partial class TypingDialog : Form
    {
        public TypingDialog()
        {
            InitializeComponent();
        }

        public void SetDialogName(string newName)
        {
            Text = newName;
        }

        public string GetContent()
        {
            return m_textbox.Text;
        }

        private void m_accept_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
