using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C_小区物业管理
{
    public partial class SetUI : Form
    {
        public SetUI()
        {
            InitializeComponent();
        }

        private void LOGOButton_Click(object sender, EventArgs e)
        {
            UIsplit.Panel2Collapsed = true;
            UIButton.Checked = false;
            
        }

        private void UIButton_Click(object sender, EventArgs e)
        {
            UIsplit.Panel1Collapsed = true;
            LOGOButton.Checked = false;
        }

        private void SetUI_Load(object sender, EventArgs e)
        {

            UIsplit.Panel2Collapsed=true;
            LOGOButton.Checked = true;
        }
    }
}
