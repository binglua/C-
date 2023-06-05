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

        public void itemload()
        {
            financeData.AutoGenerateColumns = false;
            idlabel.Visible = false;
            Searchbutton.Visible = false;
            BillidBox.Visible = false;
            newBillbutton.Visible = false;
            remindbutton.Visible = false;
            newitembutton.Visible = true;
            financeData.DataSource = null;
            financeData.Columns["姓名"].Visible = false;
            financeData.Columns["欠费金额"].Visible = false;
            financeData.Columns["欠费日期"].Visible = false;
            financeData.Columns["住址"].Visible = false;
            string sql = "select * from XiaoFeiXiangMu";
            financeData.DataSource = DbHelper.ExecuteQuery(sql);
            financeData.Columns["修改"].Visible = true;
            financeData.Columns["修改"].ToolTipText = "项目修改";
            financeData.Columns["删除"].Visible = true;
            financeData.Columns["删除"].ToolTipText = "项目删除";
            financeData.Columns["xid"].Visible = true;
            financeData.Columns["xid"].DataPropertyName = "Xid";
            financeData.Columns["xname"].DataPropertyName = "消费项目名称";
            financeData.Columns["dj"].DataPropertyName = "单价";
            financeData.Columns["dj"].Visible = true;
            financeData.Columns["lx"].DataPropertyName = "收费类型";
            financeData.Columns["lx"].Visible = true;
        }
        //收费项目维护
        private void itemsButton_Click(object sender, EventArgs e)
        {

            itemload();
            if (financeData.Columns["xid"] == null)
            {
                DataGridViewTextBoxColumn column = new DataGridViewTextBoxColumn();
                column.HeaderText = "编号";
                column.Name = "xid";
                financeData.Columns.Add(column);
            }
           
        }

        public void Billload()
        {
            newitembutton.Visible = false;
            remindbutton.Visible = false;
            Searchbutton.Visible = true;
            BillidBox.Visible = true;
            newBillbutton.Visible = true;
            idlabel.Visible = true;
            financeData.Columns["姓名"].Visible = false;
            financeData.Columns["欠费金额"].Visible = false;
            financeData.Columns["欠费日期"].Visible = false;
            financeData.Columns["住址"].Visible = false;
            financeData.Columns["修改"].Visible = false;
            financeData.Columns["删除"].Visible = true;
            financeData.Columns["删除"].ToolTipText = "账单删除";
            financeData.Columns["xid"].Visible = true;
            financeData.Columns["xid"].DataPropertyName = "XFid";
            financeData.DataSource = null;

            string sql = "SELECT XFid,消费项目名称,收费类型,XiaoFeiZhangDan.单价 FROM XiaoFeiXiangMu,XiaoFeiZhangDan where XiaoFeiXiangMu.Xid=XiaoFeiZhangDan.Xid";
            financeData.DataSource = DbHelper.ExecuteQuery(sql);
        }





        //收费单维护
        private void BillsButton_Click(object sender, EventArgs e)
        {
         Billload();
            if (financeData.Columns["xid"]==null)
            {
                DataGridViewTextBoxColumn column = new DataGridViewTextBoxColumn();
                column.HeaderText = "编号";
                column.Name = "xid";
                financeData.Columns.Add(column);
            }
           

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
            financeData.Columns["xid"].Visible = false;
            financeData.Columns["修改"].Visible = false;
            financeData.Columns["xname"].DataPropertyName = "项目名称";
            financeData.Columns["dj"].Visible = false;
            financeData.Columns["lx"].Visible = false;
            financeData.Columns["姓名"].Visible = true;
            financeData.Columns["欠费金额"].Visible = true;
            financeData.Columns["欠费日期"].Visible = true;
            financeData.Columns["住址"].Visible = true;
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
            newBill nb = new newBill();
            nb.Show();
        }
        //欠费提醒
        private void remindbutton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("已发送到欠费的邮箱");
        }

        private void finance_Load(object sender, EventArgs e)
        {
            itemload();
        }

        private void financeData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //消费项目里面的修改按钮
            if (e.ColumnIndex == financeData.Columns["修改"].Index)
            {
                    string sql = string.Format("update XiaoFeiXiangMu set 消费项目名称='{0}',单价={1},收费类型='{2}'where Xid={3}", financeData.CurrentRow.Cells["xname"].Value, financeData.CurrentRow.Cells["dj"].Value, financeData.CurrentRow.Cells["lx"].Value.ToString(), financeData.CurrentRow.Cells["xid"].Value);
                    DataChangeDel.Change(sql);

            }
            if (e.ColumnIndex == financeData.Columns["删除"].Index)
            {
                string Name = "";
                string ID = "";
                if (financeData.Columns["删除"].ToolTipText == "项目删除")
                {

                    ID = "Xid";
                    Name = "XiaoFeiXiangMu";

                }
                else if (financeData.Columns["删除"].ToolTipText == "账单删除")
                {

                    ID = "XFid";
                    Name = "XiaoFeiZhangDan";

                }
                DataChangeDel.Delete(Name,ID, financeData.CurrentRow.Cells["xid"].Value.ToString());

            }

        }
    }
}
