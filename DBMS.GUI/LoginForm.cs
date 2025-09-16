using DBMS.BUS;
using DBMS.DTO;
using System.Drawing.Text;

namespace DBMS.GUI
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void ExitTXT_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Username_txt.ResetText();
            Password_txt.ResetText();
            infor_txt.Visible = false;
            infor_txt.ResetText();
        }

        private void showpass_cb_CheckedChanged(object sender, EventArgs e)
        {
            if (showpass_cb.Checked)
            {
                Password_txt.PasswordChar = '\0';
            }
            else
            {
                Password_txt.PasswordChar = '*';
            }
        }

        private void Login_btn_Click(object sender, EventArgs e)
        {
            string username = Username_txt.Text.Trim();
            string password = Password_txt.Text.Trim();
            UserDTO user = UserBUS.Login(username, password);
            if (user != null)
            {
                this.Hide();
                ViewMaterials viewform = new ViewMaterials(user);
                viewform.ShowDialog();
            }
            else
            {
                infor_txt.Visible = true;
                infor_txt.Text = "Login fail !";
            }

        }
    }
}
