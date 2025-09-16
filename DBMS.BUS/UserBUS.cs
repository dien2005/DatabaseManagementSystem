using DBMS.DAO;
using DBMS.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBMS.BUS
{
    public class UserBUS
    {
        public static UserDTO Login(string username , string password)
        {
            return UserDAO.Login(username, password);
        }
    }
}
