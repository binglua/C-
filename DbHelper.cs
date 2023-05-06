using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Data.Sql;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace C_小区物业管理
{
    public class DbHelper
    {
        private const string ConnectionString = "Server=localhost;Database=project;Trusted_Connection=True;";

        // 执行查询语句
        public static DataTable ExecuteQuery(string sql, SqlParameter[] parameters = null)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                SqlCommand command = new SqlCommand(sql, connection);
                if (parameters != null)
                {
                    command.Parameters.AddRange(parameters);
                }
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable table = new DataTable();
                adapter.Fill(table);
                return table;
            }
        }

        // 执行非查询语句
        public static int ExecuteNonQuery(string sql, SqlParameter[] parameters = null)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                SqlCommand command = new SqlCommand(sql, connection);
                if (parameters != null)
                {
                    command.Parameters.AddRange(parameters);
                }
                connection.Open();
                return command.ExecuteNonQuery();
            }
        }

        // 执行查询语句返回单个值 
        public static object ExecuteScalar(string sql, SqlParameter[] parameters = null)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                SqlCommand command = new SqlCommand(sql, connection);
                if (parameters != null)
                {
                    command.Parameters.AddRange(parameters);
                }
                connection.Open();
                return command.ExecuteScalar();
            }
        }
    }

}
