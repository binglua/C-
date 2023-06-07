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
        public void AddColum(string ColumnName,string Head,string Data)
        {
            if (Customerdata.Columns[ColumnName] == null)
            {
                DataGridViewTextBoxColumn column = new DataGridViewTextBoxColumn();
                column.HeaderText = Head;
                column.Name = ColumnName;
                column.DataPropertyName = Data;
                Customerdata.Columns.Add(column);
            }
        }
        public void AddColumns()
        {
            Customerdata.AutoGenerateColumns = false;
            string sql = "select Bid, HuZhu.户主名字,小区名称,报修设备,维修状态 from BoXiuXiangMu,HuZhu,LouPanXinXi,XiaoQuXinXi where BoXiuXiangMu.Hid=HuZhu.Hid and BoXiuXiangMu.LPid=LouPanXinXi.LPid and HuZhu.LPid=LouPanXinXi.LPid AND LouPanXinXi.XQid=XiaoQuXinXi.XQid";
            DataTable dt = DbHelper.ExecuteQuery(sql);
            Customerdata.DataSource= dt;
            AddColum("编号", "编号", "Bid");
            AddColum("维修状态", "维修状态", "维修状态");
            AddColum("户主名字", "户主名字", "户主名字");
            AddColum("小区名称", "小区名称", "小区名称");
            AddColum("报修设备", "报修设备", "报修设备");
            AddColum("投诉内容", "投诉内容", "投诉内容"); 
        }
        //维修管理
        private void MaintenanceButton_Click(object sender, EventArgs e)
        {
            Customerdata.DataSource = null;
            AddColumns();
            Customerdata.Columns["修改"].Visible = true;
            Customerdata.Columns["维修状态"].Visible = true;
            Customerdata.Columns["编号"].Visible = true;
            Customerdata.Columns["投诉内容"].Visible = false;


        }
        //投诉管理
        private void complaintsButton_Click(object sender, EventArgs e)
        {
            
            Customerdata.DataSource = null;
            Customerdata.Columns["修改"].Visible = false;
            AddColumns();
            Customerdata.Columns["维修状态"].Visible = false;
            Customerdata.Columns["编号"].Visible = false;
            Customerdata.Columns["报修设备"].Visible = false;
            Customerdata.Columns["投诉内容"].Visible = true;
            string sql = "select HuZhu.户主名字,小区名称,投诉内容 from TouSuXinXi,HuZhu,LouPanXinXi,XiaoQuXinXi where TouSuXinXi.Hid=HuZhu.Hid and TouSuXinXi.LPid=LouPanXinXi.LPid and HuZhu.LPid=LouPanXinXi.LPid AND LouPanXinXi.XQid=XiaoQuXinXi.XQid";
            Customerdata.DataSource = DbHelper.ExecuteQuery(sql);


        }

        private void Customerdata_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == Customerdata.Columns["修改"].Index)
            {
                string sql = string.Format("update BoXiuXiangMu set 维修状态='{0}' where Bid={1}", Customerdata.CurrentRow.Cells["维修状态"].Value, Customerdata.CurrentRow.Cells["编号"].Value);
                DataChangeDel.Change(sql);

            }
        }
    }
}
