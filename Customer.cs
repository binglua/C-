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
    public partial class Customer : Form
    {
        public Customer()
        {
            InitializeComponent();
        }
        //维修管理
        private void MaintenanceButton_Click(object sender, EventArgs e)
        {
            Customerdata.DataSource = null;
            string sql = "select HuZhu.户主名字,小区名称,报修设备,维修状态 from BoXiuXiangMu,HuZhu,LouPanXinXi,XiaoQuXinXi where BoXiuXiangMu.Hid=HuZhu.Hid and BoXiuXiangMu.LPid=LouPanXinXi.LPid and HuZhu.LPid=LouPanXinXi.LPid AND LouPanXinXi.XQid=XiaoQuXinXi.XQid";
            Customerdata.DataSource = DbHelper.ExecuteQuery(sql);
        }
        //投诉管理
        private void complaintsButton_Click(object sender, EventArgs e)
        {
            Customerdata.DataSource = null;
            string sql = "select HuZhu.户主名字,小区名称,投诉内容 from TouSuXinXi,HuZhu,LouPanXinXi,XiaoQuXinXi where TouSuXinXi.Hid=HuZhu.Hid and TouSuXinXi.LPid=LouPanXinXi.LPid and HuZhu.LPid=LouPanXinXi.LPid AND LouPanXinXi.XQid=XiaoQuXinXi.XQid";
            Customerdata.DataSource = DbHelper.ExecuteQuery(sql);


        }
    }
}
