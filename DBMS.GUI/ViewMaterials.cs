using DBMS.BUS;
using DBMS.DTO;
using MaterialSkin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBMS.GUI
{
    public partial class ViewMaterials : Form
    {
        private UserDTO currentUser;
        public ViewMaterials(UserDTO user)
        {
            InitializeComponent();
            currentUser = user;
        }

        private void exitcontroll_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void search_btn_Click(object sender, EventArgs e)
        {
            search_txt.Text = "";
        }

        private void Profile_Load(object sender, EventArgs e)
        {
            List<MaterialDTO> materials = MaterialBUS.GetAllMaterials();
            material_dgv.DataSource = materials;
            
        }
    }
}
