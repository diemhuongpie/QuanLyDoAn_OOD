﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentation.Controls
{
    public partial class ChecklistCompare : Form
    {
        public ChecklistCompare()
        {
            InitializeComponent();
            m_sourceList.deactivate();
            m_newList.deactivate();
        }
    }
}
