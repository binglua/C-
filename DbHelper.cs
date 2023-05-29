using System.Data.SqlClient;
using System.Data;

namespace C_小区物业管理
{
    public class DbHelper
    {
        private const string ConnectionString = "Server=localhost;Database=XiaoQu;Trusted_Connection=True;";

        // 执行查询语句
        public static DataTable ExecuteQuery(string sql)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                SqlCommand command = new SqlCommand(sql, connection);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable table = new DataTable();
                adapter.Fill(table);
                return table;
            }
        }

        // 执行非查询语句
        public static int ExecuteNonQuery(string sql)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(sql, connection);  
                return command.ExecuteNonQuery();
            }
        }

        // 执行查询语句返回单个值 
        public static object ExecuteScalar(string sql)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(sql, connection);
                return command.ExecuteScalar();
            }
        }
    }

}
