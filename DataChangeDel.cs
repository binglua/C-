using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C_小区物业管理
{
    internal class DataChangeDel
    {
        public static void Change(string sql)
        { 

            if (MessageBox.Show("是否修改", "修改框", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                if (DbHelper.ExecuteNonQuery(sql) == 1)
                {
                    MessageBox.Show("修改成功");
                }

            }

        }
        public static void Delete(string TableName,string Columnid,string Value)
        {
            if (MessageBox.Show("是否删除", "删除框", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                string sql = string.Format("delete from {0} where {1} = {2}",TableName,Columnid,Value);
                if (DbHelper.ExecuteNonQuery(sql) == 1)
                {
                    MessageBox.Show("删除成功");
                }

            }
        }
    }
}
