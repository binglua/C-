using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
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
		//添加列的方法
		public void AddColum(string ColumnName, string Head, string Data)
		{
			if (SQLTABLE.Columns[ColumnName] == null)
			{
				DataGridViewTextBoxColumn column = new DataGridViewTextBoxColumn();
				column.HeaderText = Head;
				column.Name = ColumnName;
				column.DataPropertyName = Data;
				SQLTABLE.Columns.Add(column);
			}
		}
		//删除列的方法
		public void Remove(string ColumnName)
		{
			if (SQLTABLE.Columns[ColumnName] != null)
			{
				SQLTABLE.Columns.Remove(ColumnName);
			}
		}
		//窗口加载时
		private void Finance_Load(object sender, EventArgs e)
		{
			SQLTABLE.AutoGenerateColumns=false;


		}
		//楼盘信息维护
		private void RealButton_Click(object sender, EventArgs e)
		{
			SQLTABLE.DataSource = null;
			AddColum("小区名称", "小区名称", "小区名称");
			AddColum("楼栋名称", "楼栋名称", "楼栋名称");
			AddColum("楼层名称", "楼层名称", "楼层名称");
			AddColum("房间名称", "房间名称", "房间名称");
			Remove("电话");
			Remove("住址");
			Remove("姓名");
			Remove("车位编号");
			Remove("车位状态");
			Remove("修改");
			AddColum("姓名", "户主名字", "户主名字");
			string lpsql = "select 小区名称,楼栋名称,楼层名称,房间名称,户主名字\r\nfrom LouPanXinXi,LouCengXinXi,LouDongXinXi,HuZhu,XiaoQuXinXi,FangJianXinXi\r\nwhere LouPanXinXi.LDid=LouDongXinXi.LDid and LouCengXinXi.LCid=LouPanXinXi.LCid and LouPanXinXi.Hid=HuZhu.Hid and LouPanXinXi.XQid=XiaoQuXinXi.XQid and FangJianXinXi.Fid=LouPanXinXi.Fid\r\ngroup by 小区名称,楼栋名称,楼层名称,房间名称,户主名字";
			SQLTABLE.DataSource = DbHelper.ExecuteQuery(lpsql);

			
		}
		//业主信息维护
		private void OwnerButton_Click(object sender, EventArgs e)
		{
			Remove("小区名称");
			Remove("楼栋名称");
			Remove("楼层名称");
			Remove("房间名称");
			Remove("车位编号");
			Remove("车位状态");
			Remove("修改");
			SQLTABLE.DataSource = null;
			AddColum("姓名", "户主名字", "户主名字");
			AddColum("电话", "电话", "电话");
			AddColum("住址", "住址", "住址");
			DataGridViewLinkColumn up = new DataGridViewLinkColumn();
			up.HeaderText = "修改";
			up.Name = "修改";
			up.Text = "修改";
			up.ToolTipText = "修改";
			up.UseColumnTextForLinkValue = true;
			SQLTABLE.Columns.Add(up);
			string hzsql = "select 户主名字,电话,住址 from HuZhu";
			SQLTABLE.DataSource = DbHelper.ExecuteQuery(hzsql);
		}
		//车位信息维护
		private void DrivewayButton_Click(object sender, EventArgs e)
		{
			Remove("小区名称");
			Remove("楼栋名称");
			Remove("楼层名称");
			Remove("房间名称");
			Remove("电话");
			Remove("住址");
			Remove("姓名");
			Remove("修改");
			AddColum("车位编号", "车位编号", "车位编号");
			AddColum("姓名", "户主名字", "户主名字");
			AddColum("车位状态", "车位状态", "车位状态");
			DataGridViewLinkColumn up = new DataGridViewLinkColumn();
			up.HeaderText = "修改状态";
			up.Name = "修改";
			up.Text = "修改";
			up.ToolTipText = "修改状态";
			up.UseColumnTextForLinkValue = true;
			SQLTABLE.Columns.Add(up);
			SQLTABLE.DataSource = null;
			string cwsql = "select CheWeiXinXi.Cid 车位编号,户主名字,车位状态 from XiaoQuXinXi,HuZhu,CheWeiXinXi where XiaoQuXinXi.XQid=CheWeiXinXi.XQid and HuZhu.Hid=CheWeiXinXi.Hid and CheWeiXinXi.XQid=XiaoQuXinXi.XQid";
			SQLTABLE.DataSource = DbHelper.ExecuteQuery(cwsql);
		}

		private void SQLTABLE_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.ColumnIndex == SQLTABLE.Columns["修改"].Index)
			{
				string sql = "";
				if (SQLTABLE.Columns["修改"].ToolTipText=="修改状态")
				{
					sql = string.Format("update CheWeiXinXi set 车位状态='{0}' where Cid={1}", SQLTABLE.CurrentRow.Cells["车位状态"].Value, SQLTABLE.CurrentRow.Cells["车位编号"].Value);
				}
				else if (SQLTABLE.Columns["修改"].ToolTipText == "修改")
				{
					sql = string.Format("update HuZhu set 电话='{0}' where 户主名字='{1}'", SQLTABLE.CurrentRow.Cells["电话"].Value, SQLTABLE.CurrentRow.Cells["姓名"].Value);
				}
				if (DbHelper.ExecuteNonQuery(sql)>0)
				{
					MessageBox.Show("修改成功");
				} 
			}
		}
	}
}
