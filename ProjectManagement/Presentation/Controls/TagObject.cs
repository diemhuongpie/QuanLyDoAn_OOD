using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentation.Controls
{
    public partial class TagObject : UserControl
    {
        private const float POINT_TO_PIXEL = 0.75f;
        public TagObject()
        {
            InitializeComponent();
        }

        private void reSizeTagObject(object sender, EventArgs e)
        {
            int width = (int)(m_txtbxTagName.Text.Length * m_txtbxTagName.Font.SizeInPoints * POINT_TO_PIXEL);
            this.Size = new Size(width + m_btnDeleteTag.Size.Width, this.Size.Height);
        }

        public void setTagName(string name)
        {
            m_txtbxTagName.Text = name;
            reSizeTagObject(null, EventArgs.Empty);
        }

        private void m_btnDeleteTag_Click(object sender, EventArgs e)
        {
            this.Parent.Controls.Remove(this);
        }
    }
}
