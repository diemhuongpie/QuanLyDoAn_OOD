using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentation.Controlers
{
    public partial class ProjectDisplay : UserControl
    {
        public ProjectDisplay()
        {
            InitializeComponent();
            m_splitContainerProgressBar.SplitterDistance = 5;
        }
    }
}
