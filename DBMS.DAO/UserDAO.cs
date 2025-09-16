using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using Microsoft.Identity.Client;
using DBMS.DTO;
using DBMS.DAO;
namespace DBMS.DAO
{
    public class UserDAO
    {
        public static UserDTO Login(string username, string pass_word)
        {
            string query = "SELECT * FROM dbo.fn_selectUser(@param0, @param1)";
            DataTable dt = new DataTable();
            dt = LoadData.ExecuteQuery(query, new object[] { username, pass_word });
            if (dt.Rows.Count > 0)
            {
                return new UserDTO
                {
                    Username = dt.Rows[0]["username"].ToString(),
                    Password = dt.Rows[0]["pass_word"].ToString()
                };
            }
            return null;
        }
    }
}
