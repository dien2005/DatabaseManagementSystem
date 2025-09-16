using DBMS.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBMS.BUS
{
    public class MaterialBUS
    {
       public static List<MaterialDTO> GetAllMaterials()
        {
            return DAO.MaterialDAO.GetAllMaterials();
        }
    }
}
