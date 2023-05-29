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
    public partial class finance : Form
    {
        public finance()
        {
            InitializeComponent();
        }
        //收费项目维护
        private void itemsButton_Click(object sender, EventArgs e)
        {
            Searchbutton.Visible = false;
            BillidBox.Visible = false;
            newBillbutton.Visible = false;
            remindbutton.Visible = false;
            newitembutton.Visible = true;
            financeData.DataSource = null;
            string sql = "select * from XiaoFeiXiangMu";
            financeData.DataSource=DbHelper.ExecuteQuery(sql);

        }
        //收费单维护

        private void BillsButton_Click(object sender, EventArgs e)
        {
            newitembutton.Visible = false;
            remindbutton.Visible = false;
            Searchbutton.Visible = true;
            BillidBox.Visible = true;
            newBillbutton.Visible = true;
            financeData.DataSource = null;
            string sql = "SELECT XFid,消费项目名称,收费类型,XiaoFeiZhangDan.单价 FROM XiaoFeiXiangMu,XiaoFeiZhangDan where XiaoFeiXiangMu.Xid=XiaoFeiZhangDan.Xid";
            financeData.DataSource = DbHelper.ExecuteQuery(sql);

        }

        //欠费提醒
        private void ArrearsButton_Click(object sender, EventArgs e)
        {
            newitembutton.Visible = false;
            Searchbutton.Visible = false;
            BillidBox.Visible = false;
            newBillbutton.Visible = false;
            remindbutton.Visible = true;
            financeData.DataSource = null;
            string sql = "SELECT 户主名字,项目名称,欠费金额,欠费日期,住址 from QianFeiTiXing,HuZhu,LouPanXinXi where QianFeiTiXing.Hid=HuZhu.Hid and QianFeiTiXing.LPid=LouPanXinXi.LPid and HuZhu.LPid=LouPanXinXi.LPid";
            financeData.DataSource = DbHelper.ExecuteQuery(sql);

        }
    }
}
