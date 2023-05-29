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

        private void personnel_Load(object sender, EventArgs e)
        {
            DataTable glydt = DbHelper.ExecuteQuery("select username from GuanLiYuan where Zid=1");
            DataTable zhdt = DbHelper.ExecuteQuery("select username from GuanLiYuan where Zid=2");
            DataTable wydt = DbHelper.ExecuteQuery("select username from GuanLiYuan where Zid=3");
            TreeNode parentNode=null;
            TreeNode childNode=null;

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
            treeView1.ExpandAll();
        }
    }
}
