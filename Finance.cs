﻿using System;
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
            idlabel.Visible = false;
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
            idlabel.Visible = true;
            financeData.DataSource = null;
            string sql = "SELECT XFid,消费项目名称,收费类型,XiaoFeiZhangDan.单价 FROM XiaoFeiXiangMu,XiaoFeiZhangDan where XiaoFeiXiangMu.Xid=XiaoFeiZhangDan.Xid";
            financeData.DataSource = DbHelper.ExecuteQuery(sql);

        }

        //欠费提醒
        private void ArrearsButton_Click(object sender, EventArgs e)
        {
            idlabel.Visible = false;
            newitembutton.Visible = false;
            Searchbutton.Visible = false;
            BillidBox.Visible = false;
            newBillbutton.Visible = false;
            remindbutton.Visible = true;
            financeData.DataSource = null;
            string sql = "SELECT 户主名字,项目名称,欠费金额,欠费日期,住址 from QianFeiTiXing,HuZhu,LouPanXinXi where QianFeiTiXing.Hid=HuZhu.Hid and QianFeiTiXing.LPid=LouPanXinXi.LPid and HuZhu.LPid=LouPanXinXi.LPid";
            financeData.DataSource = DbHelper.ExecuteQuery(sql);

        }
        //查询序号
        private void Searchbutton_Click(object sender, EventArgs e)
        {
            string sql = string.Format("select XFid,消费项目名称,收费类型,XiaoFeiZhangDan.单价 from XiaoFeiXiangMu,XiaoFeiZhangDan where XiaoFeiXiangMu.Xid=XiaoFeiZhangDan.Xid and XFid={0}", BillidBox.Text);
            financeData.DataSource= DbHelper.ExecuteQuery(sql);
        }
        //新建收费项
        private void newitembutton_Click(object sender, EventArgs e)
        {
            Newitem newitem = new Newitem();
            newitem.Show();
        }
        //新建收费单
        private void newBillbutton_Click(object sender, EventArgs e)
        {

        }
        //欠费提醒
        private void remindbutton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("已发送到欠费的邮箱");
        }

        private void finance_Load(object sender, EventArgs e)
        {

        }
    }
}
