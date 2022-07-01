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
    public partial class frmQL : Form
    {
        SqlConnection conn = new SqlConnection();
        SqlDataAdapter da = new SqlDataAdapter();
        SqlCommand cmd = new SqlCommand();
        DataTable dt = new DataTable();
        DataTable dt1 = new DataTable();
        string sql, constr, s;
        int i;

        public frmQL()
        {
            InitializeComponent();
        }

        private void txtNhap_QL_Click(object sender, EventArgs e)
        {
            if (txtNhap_QL.Text == "Nhập từ khóa") txtNhap_QL.Text = "";
        }

        private void txtNhap_QL_Leave(object sender, EventArgs e)
        {
            if (txtNhap_QL.Text == "") txtNhap_QL.Text = "Nhập từ khóa";
        }

        private void btnLogoutQL_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Login f = new Login();
            f.ShowDialog();
        }

        private void btnTk_Click(object sender, EventArgs e)
        {
            dt.Clear();
            if (comTCHP.Text == "")
            {
                sql = "Select MaLopHP,MaMon,TenLopHP,Siso,GiangVien,PhongHoc,TietHoc from tblLopHP";
            }
            else if (comTCHP.Text == "Tên HP")
            {
                sql = "Select MaLopHP,MaMon,TenLopHP,Siso,GiangVien,PhongHoc,TietHoc from tblLopHP Where TenLopHP= '" + txtNhap_QL.Text + "'";
            }
            else if (comTCHP.Text == "Mã HP")
            {
                sql = "Select MaLopHP,MaMon,TenLopHP,Siso,GiangVien,PhongHoc,TietHoc from tblLopHP Where MaLopHP= '" + txtNhap_QL.Text + "'";
            }
            else if (comTCHP.Text == "Tên Giảng Viên")
            {
                sql = "Select MaLopHP,MaMon,TenLopHP,Siso,GiangVien,PhongHoc,TietHoc from tblLopHP Where GiangVien= '" + txtNhap_QL.Text + "'";
            }
            da = new SqlDataAdapter(sql, conn);
            da.Fill(dt);
            grdQL.DataSource = dt;
            grdQL.Refresh();
        }

        private void btnThemmoi_Click(object sender, EventArgs e)
        {
            frmAdd f = new frmAdd(this);
            f.Show();
        }

        private void btnThemmoi_Click_1(object sender, EventArgs e)
        {
            frmAdd f = new frmAdd(this);
            f.Show();
        }

        private void frmQL_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dKTCDataSet1.tblLopHP' table. You can move, or remove it, as needed.
            //this.tblLopHPTableAdapter.Fill(this.dKTCDataSet1.tblLopHP);
            constr = "Data Source=LVQT\\MSSQLSEVER01;Initial Catalog=DKTC;Integrated Security=True";
            conn.ConnectionString = constr;
            sql = "Select MaLopHP,MaMon,TenLopHP,Siso,GiangVien,PhongHoc,TietHoc from tblLopHP";
            da = new SqlDataAdapter(sql, conn);
            da.Fill(dt);
            grdQL.DataSource = dt;

        }

        private void comTCHP_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }
    }
}
