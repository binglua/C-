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
    public partial class personnel : Form
    {
        public personnel()
        {
            InitializeComponent();
        }
        //加载窗口
        private void personnel_Load(object sender, EventArgs e)
        {
            string sql = "select username 用户名,company_phone 电话,company_address 住址,legal_id_card 身份证号 from GuanLiYuan";
           personneldata.DataSource= DbHelper.ExecuteQuery(sql);
            //定义三个数据源
            DataTable glydt = DbHelper.ExecuteQuery("select username from GuanLiYuan where Zid=1");
            DataTable zhdt = DbHelper.ExecuteQuery("select username from GuanLiYuan where Zid=2");
            DataTable wydt = DbHelper.ExecuteQuery("select username from GuanLiYuan where Zid=3");
            TreeNode parentNode=null;
            TreeNode childNode=null;
            //循环查找对应的职位并添加到树状图
            for (int i = 0; i < glydt.Rows.Count; i++)
            {
                parentNode = new TreeNode(glydt.Rows[i][0].ToString());
                treeView1.Nodes.Add(parentNode);

            }
            for (int i = 0; i < zhdt.Rows.Count; i++)
            {
                childNode = new TreeNode(zhdt.Rows[i][0].ToString());
                parentNode.Nodes.Add(childNode);
            }
            for (int i = 0; i < wydt.Rows.Count; i++)
            {
               TreeNode childNode1 = new TreeNode(wydt.Rows[i][0].ToString());
                childNode.Nodes.Add(childNode1);
            }
            //展开树状图
            treeView1.ExpandAll();
        }
    }
}
