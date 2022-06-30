using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace BTL
{
    public partial class Login : Form
    {
        SqlConnection conn = new SqlConnection();
        SqlDataAdapter da = new SqlDataAdapter();
        SqlCommand cmd = new SqlCommand();
        DataTable dt = new DataTable();
        string sql, constr;
        int i;
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            constr = @"Data Source=LAPTOP-F0TSIU3S;Initial Catalog=DKTC;Integrated Security=True";
            conn.ConnectionString = constr;
        }

        private void txtDN_Enter(object sender, EventArgs e)
        {
            if(txtDN.Text == "Tên đăng nhập")
            {
                txtDN.Text = "";
                txtDN.BackColor = Color.FromArgb(197, 173, 217);
            }
            else
            {
                txtDN.BackColor = Color.FromArgb(197, 173, 217);
            }
        }

        private void txtDN_Leave(object sender, EventArgs e)
        {
            if (txtDN.Text == "") { txtDN.Text = "Tên đăng nhập"; };
            txtDN.BackColor = Color.FromArgb(68, 43, 99);

        }

        private void txtMK_Enter(object sender, EventArgs e)
        {
            
         }

        private void txtMK_Leave(object sender, EventArgs e)
        {
            if (txtMK.Text == "") txtMK.Text = "Mật khẩu";
            if (txtMK.Text == "Mật khẩu") txtMK.PasswordChar = '\0';
            txtMK.BackColor = Color.FromArgb(68, 43, 99);
           
        }

        private void btnSV_Click(object sender, EventArgs e)
        {
            //try
            //{
                conn.Open();
                sql = "select * from tblSV where MaSV = '"+txtDN.Text+"' and MatKhau= '"+txtMK.Text+"'";
                cmd = new SqlCommand(sql, conn);
                SqlDataReader dta = cmd.ExecuteReader();
                if (dta.Read() == true)
                {
                //this.Close();
                frmSV f = new frmSV();
                f.Show();
                this.Hide();
                //this.Close();
                }
                else
                {
                    MessageBox.Show("Đăng nhập thất bại");
                    conn.Close();
                }
            /*}
            catch
            {
                MessageBox.Show("Lỗi kết nối");
            }*/
        }

        private void picShow_Click(object sender, EventArgs e)
        {
            txtMK.PasswordChar = '\0';
            picHide.BringToFront();
        }

        private void picHide_Click(object sender, EventArgs e)
        {
            txtMK.PasswordChar = '*';
            picShow.BringToFront();
        }

        private void btnQL_Click(object sender, EventArgs e)
        {
            frmQL f = new frmQL();
            f.Show();
            this.Visible = false;
        }

        private void txtMK_Click(object sender, EventArgs e)
        {
            if (txtMK.Text=="Mật khẩu")
            {
                txtMK.Text = "";
                txtMK.PasswordChar = '*';
                txtMK.BackColor = Color.FromArgb(197, 173, 217);
            }
            
        }

    }
}
