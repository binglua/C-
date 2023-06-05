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
    public partial class newBill : Form
    {
        public newBill()
        {
            InitializeComponent();
        }

        private void newBill_Load(object sender, EventArgs e)
        {
            comboBox2.DataSource = DbHelper.ExecuteQuery("select * from XiaoFeiXiangMu");
            comboBox2.DisplayMember = "消费项目名称";
            comboBox2.ValueMember = "Xid";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sql = string.Format("insert into XiaoFeiZhangDan values ({0},'{1}')", comboBox2.SelectedValue,textBox2.Text);
           
        }
    }
}
