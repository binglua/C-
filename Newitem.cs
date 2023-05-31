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
    public partial class Newitem : Form
    {
        public Newitem()
        {
            InitializeComponent();
        }

        private void Newitem_Load(object sender, EventArgs e)
        {

        }

        private void Newbutton_Click(object sender, EventArgs e)
        {
           string Name=NameBox.Text;
           string price = priceBox.Text;
           string type=typeBox.Text;
            string sql = string.Format("insert into XiaoFeiXiangMu values('{0}',{1},'{2}')",Name,price,type);
            if (DbHelper.ExecuteNonQuery(sql)>0)
            {
                MessageBox.Show("添加成功");
                this.Close();
            } 

        }
    }
}
