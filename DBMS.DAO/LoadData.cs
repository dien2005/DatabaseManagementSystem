using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBMS.DAO
{
    public class LoadData
    {
        private static string sql_conection = "Data Source=DUONGHAO-LOQ;Initial Catalog=QL_CoSoVatChat_ThuVien;Integrated Security=True;Trust Server Certificate=True";
        public static DataTable ExecuteQuery(string sql_query, object[] parameters = null)
        {
            DataTable data = new DataTable();
            using (SqlConnection conn = new SqlConnection(sql_conection))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql_query, conn);
                if (parameters != null)
                {
                    for (int i = 0; i < parameters.Length; i++)
                    {
                        cmd.Parameters.AddWithValue($"@param{i}", parameters[i]);
                    }
                }
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(data);
                conn.Close();
            }
            return data;
        }
    }
}
