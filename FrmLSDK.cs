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
    public partial class FrmLSDK : Form
    {
        public string MaSV;
        SqlConnection conn = new SqlConnection();
        SqlDataAdapter da = new SqlDataAdapter();
        SqlCommand cmd = new SqlCommand();
        DataTable dt = new DataTable();
        DataTable dt1 = new DataTable();
        string sql, constr, s;
        int i;
        public FrmLSDK()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLogoutLSDK_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Login f = new Login();
            f.ShowDialog();
        }

        private void btnTrangChuLSDK_Click(object sender, EventArgs e)
        {
            //frmSV f = new frmSV();
            //f.Show();
            //this.Close();
        }

        private void btnDKHP_LSDK_Click(object sender, EventArgs e)
        {
            //frmSV f = new frmSV();
            //f.Show();
           // this.Close();
        }

        private void btnTCHP_LSDK_Click(object sender, EventArgs e)
        {
            TCHP f = new TCHP();
            f.Show();
            this.Close();
        }

        private void comHocKy_SelectedIndexChanged(object sender, EventArgs e)
        {
            string ky1 = "N'Học kỳ 1", ky2 = "N'Học kỳ 2", ky3 = "N'Học kỳ 3";
            dt.Clear();
            if (comHocKy.Text == "Học kỳ 1")
            {
                sql = "select MaMon, MaLopHP, TenMon, SoTC, HocKi, NamHoc, TietHoc, PhongHoc, GiangVien from tblLSDK where Hocki =" + ky1 + "' and NamHoc ='" + comNamHoc.Text + "' and MaSV='" + MaSV + "'";
            }
            else if (comHocKy.Text == "Học kỳ 2")
            {
                sql = "select MaMon, MaLopHP, TenMon, SoTC, HocKi, NamHoc, TietHoc, PhongHoc, GiangVien from tblLSDK where Hocki =" + ky2 + "' and NamHoc ='" + comNamHoc.Text + "'and MaSV='" + MaSV + "'";// owf =]]
            }
            else if (comHocKy.Text == "Học kỳ 3")
            {
                sql = "select MaMon, MaLopHP, TenMon, SoTC, HocKi, NamHoc, TietHoc, PhongHoc, GiangVien from tblLSDK where Hocki =" + ky3 + "' and NamHoc ='" + comNamHoc.Text + "'and MaSV='" + MaSV + "'";
            }
            da = new SqlDataAdapter(sql, conn);
            da.Fill(dt);
            grdLSDK.DataSource = dt;
            grdLSDK.Refresh();
        }

        private void FrmLSDK_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dKTCDataSet5.tblLSDK' table. You can move, or remove it, as needed.
            //this.tblLSDKTableAdapter.Fill(this.dKTCDataSet5.tblLSDK);
            constr = "Data Source=LAPTOP-JUURU7V4\\SQLEXPRESS;Initial Catalog=DKTC;Integrated Security=True";
            conn.ConnectionString = constr;
            sql = "select MaMon, MaLopHP, TenMon, SoTC, HocKi, NamHoc, TietHoc, PhongHoc, GiangVien from tblLSDK where MaSV='" + MaSV + "'";
            da = new SqlDataAdapter(sql, conn);
            da.Fill(dt);
            grdLSDK.DataSource = dt;

        }

        private void comNamHoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            string namnhat = "2020-2021", namhai = "2021-2022", namba = "2022-2023", nambon = "2023-2024";
            dt.Clear();
            if (comNamHoc.Text == "2020-2021")
            {
                sql = "select MaMon, MaLopHP, TenMon, SoTC, HocKi, NamHoc, TietHoc, PhongHoc, GiangVien from tblLSDK where NamHoc ='" + namnhat + "' and HocKi =N'" + comHocKy.Text + "'and MaSV='" + MaSV + "'";
            }
            else if (comNamHoc.Text == "2021-2022")
            {
                sql = "select MaMon, MaLopHP, TenMon, SoTC, HocKi, NamHoc, TietHoc, PhongHoc, GiangVien from tblLSDK where NamHoc ='" + namhai + "' and HocKi =N'" + comHocKy.Text + "'and MaSV='" + MaSV + "'";
            }
            else if (comNamHoc.Text == "2022-2023")
            {
                sql = "select MaMon, MaLopHP, TenMon, SoTC, HocKi, NamHoc, TietHoc, PhongHoc, GiangVien from tblLSDK where NamHoc ='" + namba + "' and HocKi =N'" + comHocKy.Text + "'and MaSV='" + MaSV + "'";
            }
            else if (comNamHoc.Text == "2023-2024")
            {
                sql = "select MaMon, MaLopHP, TenMon, SoTC, HocKi, NamHoc, TietHoc, PhongHoc, GiangVien from tblLSDK where NamHoc ='" + nambon + "' and HocKi =N'" + comHocKy.Text + "'and MaSV='" + MaSV + "'";
            }

            da = new SqlDataAdapter(sql, conn);
            da.Fill(dt);
            grdLSDK.DataSource = dt;
            grdLSDK.Refresh();
        }
    }
}
