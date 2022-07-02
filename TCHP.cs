using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTL
{
    public partial class TCHP : Form
    {
        SqlConnection conn = new SqlConnection();
        SqlDataAdapter da = new SqlDataAdapter();
        SqlCommand cmd = new SqlCommand();
        DataTable dt = new DataTable();
        DataTable dt1 = new DataTable();
        string sql, constr, s;
        int i;
        public TCHP()
        {
            InitializeComponent();
        }

        private void btnTrangChuTCHP_Click(object sender, EventArgs e)
        {
            frmSV f = new frmSV();
            f.Show();
            this.Close();
        }

        private void btnLogoutTCHP_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Login f = new Login();
            f.ShowDialog();
        }

        private void btnDKHP_TCHP_Click(object sender, EventArgs e)
        {
            frmSV f = new frmSV();
            f.Show();
            this.Close();
        }

        private void btnLSDKHP_TCHP_Click(object sender, EventArgs e)
        {
            FrmLSDK f = new FrmLSDK();
            f.Show();
            this.Close();
        }

        private void txtNhap_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNhap_Click(object sender, EventArgs e)
        {
            if (txtNhap.Text == "Nhập từ khóa") { txtNhap.Text = ""; }
        }

        private void txtNhap_Leave(object sender, EventArgs e)
        {
            if (txtNhap.Text == "") { txtNhap.Text = "Nhập từ khóa"; }
        }
       /* private void btnTk_Click(object sender, EventArgs e)
        {
            dt.Clear();
            if (comTCHP.Text == "")
            {
                sql = "Select MaLopHP,MaMon,TenLopHP,Siso,GiangVien,PhongHoc,TietHoc,SSHienTai from tblLopHP";
            }
            else if (comTCHP.Text == "Tên HP")
            {
                sql = "Select MaLopHP,MaMon,TenLopHP,Siso,GiangVien,PhongHoc,TietHoc,SSHienTai from tblLopHP Where TenLopHP= N'" + txtNhap.Text + "'";
            }
            else if (comTCHP.Text == "Mã HP")
            {
                sql = "Select MaLopHP,MaMon,TenLopHP,Siso,GiangVien,PhongHoc,TietHoc,SSHienTai from tblLopHP Where MaLopHP= '" + txtNhap.Text + "'";
            }
            else if (comTCHP.Text == "Mã môn")
            {
                sql = "Select MaLopHP,MaMon,TenLopHP,Siso,GiangVien,PhongHoc,TietHoc.SSHienTai from tblLopHP Where GiangVien= N'" + txtNhap.Text + "'";
            }
          
            da = new SqlDataAdapter(sql, conn);
            da.Fill(dt);
            grdTCHP.DataSource = dt;
            grdTCHP.Refresh();
        }*/

        private void btnTk_Click_1(object sender, EventArgs e)
        {
            dt.Clear();
            if (comTCHP.Text == "")
            {
                sql = "Select MaLopHP,MaMon,TenLopHP,Siso,GiangVien,PhongHoc,TietHoc,SSHienTai from tblLopHP";
            }
            else if (comTCHP.Text == "Tên HP")
            {
                sql = "Select MaLopHP,MaMon,TenLopHP,Siso,GiangVien,PhongHoc,TietHoc,SSHienTai from tblLopHP Where TenLopHP= N'" + txtNhap.Text + "'";
            }
            else if (comTCHP.Text == "Mã HP")
            {
                sql = "Select MaLopHP,MaMon,TenLopHP,Siso,GiangVien,PhongHoc,TietHoc,SSHienTai from tblLopHP Where MaLopHP= '" + txtNhap.Text + "'";
            }
            else if (comTCHP.Text == "Mã môn")
            {
                sql = "Select MaLopHP,MaMon,TenLopHP,Siso,GiangVien,PhongHoc,TietHoc.SSHienTai from tblLopHP Where GiangVien= N'" + txtNhap.Text + "'";
            }

            da = new SqlDataAdapter(sql, conn);
            da.Fill(dt);
            grdTCHP.DataSource = dt;
            grdTCHP.Refresh();
        }

        private void TCHP_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dKTCDataSet5.tblLopHP' table. You can move, or remove it, as needed.
            // this.tblLopHPTableAdapter.Fill(this.dKTCDataSet5.tblLopHP);
            constr = "Data Source=LVQT\\MSSQLSEVER01;Initial Catalog=DKTC;Integrated Security=True";
            conn.ConnectionString = constr;
            sql = "Select MaLopHP,MaMon,TenLopHP,Siso,GiangVien,PhongHoc,TietHoc,SSHienTai from tblLopHP";
            da = new SqlDataAdapter(sql, conn);
            da.Fill(dt);
            grdTCHP.DataSource = dt;
        }

        private void btnHDDK_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://drive.google.com/file/d/12JMQuaUM5f-qtzbkeuIcPQQ4qk41XCnY/view");
        }
    }
}
