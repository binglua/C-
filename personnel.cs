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
            string sql = "select Gid 编号, username 用户名,company_phone 电话,company_address 住址,legal_id_card 身份证号 from GuanLiYuan";
           personneldata.DataSource= DbHelper.ExecuteQuery(sql);
            DataGridViewLinkColumn up = new DataGridViewLinkColumn();
            up.HeaderText = "修改";
            up.Name = "修改";
            up.Text = "修改";
            up.ToolTipText = "修改";
            up.UseColumnTextForLinkValue = true;
            personneldata.Columns.Add(up);
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

        private void Savebutton_Click(object sender, EventArgs e)
        {

        }

        private void personneldata_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == personneldata.Columns["修改"].Index)
            {
                string sql = string.Format("update GuanLiYuan set username='{0}',company_phone='{1}',company_address='{2}',legal_id_card='{3}' where Gid={4}", personneldata.CurrentRow.Cells["用户名"].Value, personneldata.CurrentRow.Cells["电话"].Value, personneldata.CurrentRow.Cells["住址"].Value, personneldata.CurrentRow.Cells["身份证号"].Value, personneldata.CurrentRow.Cells["编号"].Value);
                

                if (DbHelper.ExecuteNonQuery(sql) > 0)
                {
                    MessageBox.Show("修改成功");
                }
            }
        
    }
    }
}
