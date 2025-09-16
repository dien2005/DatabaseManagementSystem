using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DBMS.DTO;
namespace DBMS.DAO
{
    public class MaterialDAO
    {
        public static List<MaterialDTO> GetAllMaterials()
        {
            string query = "SELECT * FROM VATTU"; 
            DataTable dt = LoadData.ExecuteQuery(query);
            List<MaterialDTO> materials = new List<MaterialDTO>();
            foreach (DataRow row in dt.Rows)
            {
                materials.Add(new MaterialDTO
                {
                    maVT = row["MaVT"].ToString(),
                    tenVT = row["TenVT"].ToString(),
                    donVi = row["DonVi"].ToString(),
                    soLuong = Convert.ToInt32(row["SoLuong"]),
                    moTa = row["MoTa"].ToString()
                });
            }
            Console.WriteLine(materials.Count);
            return materials;
        }
    }
}
