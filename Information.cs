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
    public partial class Information : Form
    {
        public Information()
        {
            InitializeComponent();
        }
        //窗口加载时
        private void Finance_Load(object sender, EventArgs e)
        {
         



        }
        //楼盘信息维护
        private void RealButton_Click(object sender, EventArgs e)
        {
            SQLTABLE.DataSource = null;
            string lpsql = "select 小区名称,楼栋名称,楼层名称,房间名称,户主名字\r\nfrom LouPanXinXi,LouCengXinXi,LouDongXinXi,HuZhu,XiaoQuXinXi,FangJianXinXi\r\nwhere LouPanXinXi.LDid=LouDongXinXi.LDid and LouCengXinXi.LCid=LouPanXinXi.LCid and LouPanXinXi.Hid=HuZhu.Hid and LouPanXinXi.XQid=XiaoQuXinXi.XQid and FangJianXinXi.Fid=LouPanXinXi.Fid\r\ngroup by 小区名称,楼栋名称,楼层名称,房间名称,户主名字";
            SQLTABLE.DataSource = DbHelper.ExecuteQuery(lpsql);

            
        }
        //业主信息维护
        private void OwnerButton_Click(object sender, EventArgs e)
        {
            SQLTABLE.DataSource = null;
            string hzsql = "select 户主名字,电话,住址 from HuZhu";
            SQLTABLE.DataSource = DbHelper.ExecuteQuery(hzsql);
        }
        //车位信息维护
        private void DrivewayButton_Click(object sender, EventArgs e)
        {
            SQLTABLE.DataSource = null;
            string cwsql = "select CheWeiXinXi.Cid 车位编号,户主名字,车位状态 from XiaoQuXinXi,HuZhu,CheWeiXinXi where XiaoQuXinXi.XQid=CheWeiXinXi.XQid and HuZhu.Hid=CheWeiXinXi.Hid and CheWeiXinXi.XQid=XiaoQuXinXi.XQid";
            SQLTABLE.DataSource = DbHelper.ExecuteQuery(cwsql);
        }

        private void testbutton_Click(object sender, EventArgs e)
        {
            SQLTABLE.DataSource = SQLTABLE.DataSource;
        }
    }
}
