using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using BusinessLogic;

namespace Presentation.Forms
{
    public partial class MacroHelper : Form
    {
        private TextBox owner = null;
        public MacroHelper(ref TextBox txtBox)
        {
            InitializeComponent();

            owner = txtBox;

            Dictionary<string, string> dict = BusinessLogic.Config.GetInstance().GetMacroMap();
            for (int i = 0; i < dict.Count; i++)
            {
                string[] rowInfo = {dict.Keys.ElementAt(i), dict.Values.ElementAt(i)};
                ListViewItem item = new ListViewItem(rowInfo);
                
                m_macroList.Items.Add(item);
            }
            m_macroList.Refresh();
        }

        private void selectMacro(object sender, EventArgs e)
        {
            owner.Text += m_macroList.SelectedItems[0].Text;
            this.Hide();
        }
    }
}
