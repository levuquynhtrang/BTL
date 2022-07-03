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
        DataTable dtBC = new DataTable();
        string sql, constr;
        frmAdd ADD;
        frmThongTinLopHoc TTLH;
        int index;
        public string MaQL;
        public frmQL(frmAdd add)
        {
            this.ADD = add;
            InitializeComponent();
        }
        public frmQL(frmThongTinLopHoc ttlp)
        {
            this.TTLH = ttlp;
            InitializeComponent();
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            string maLopHP;
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa bản ghi hiện thời?", "Xác nhận yêu cầu", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                int i = Convert.ToInt16(grdQL.CurrentRow.Index.ToString());
                maLopHP = grdQL.Rows[i].Cells[0].Value.ToString();
                //MessageBox.Show(maLopHP);
                sql = "Delete from tblLopHP where MaLopHP ='" + maLopHP + "'";
                //cmd = new SqlCommand(sql,conn);
                //cmd.CommandText = sql;
                //cmd.ExecuteNonQuery();
                clsMain.DoSQL(sql);
                dt.Clear();
                sql = "Select * From tblLopHP";
                da = new SqlDataAdapter(sql, conn);
                da.Fill(dt);
                grdQL.DataSource = dt;
            }
        }

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
                sql = "Select MaLopHP,MaMon,TenLopHP,Siso,GiangVien,PhongHoc,TietHoc,SSHienTai from tblLopHP";
            }
            else if (comTCHP.Text == "Tên HP")
            {
                sql = "Select MaLopHP,MaMon,TenLopHP,Siso,GiangVien,PhongHoc,TietHoc,SSHienTai from tblLopHP Where TenLopHP= '" + txtNhap_QL.Text + "'";
            }
            else if (comTCHP.Text == "Mã HP")
            {
                sql = "Select MaLopHP,MaMon,TenLopHP,Siso,GiangVien,PhongHoc,TietHoc,SSHienTai from tblLopHP Where MaLopHP= '" + txtNhap_QL.Text + "'";
            }
            else if (comTCHP.Text == "Tên Giảng Viên")
            {
                sql = "Select MaLopHP,MaMon,TenLopHP,Siso,GiangVien,PhongHoc,TietHoc.SSHienTai from tblLopHP Where GiangVien= '" + txtNhap_QL.Text + "'";
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

        private void frmQL_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dKTCDataSet4.tblLopHP' table. You can move, or remove it, as needed.
           // this.tblLopHPTableAdapter2.Fill(this.dKTCDataSet4.tblLopHP);
            // TODO: This line of code loads data into the 'dKTCDataSet5.tblLopHP' table. You can move, or remove it, as needed.
            //this.tblLopHPTableAdapter1.Fill(this.dKTCDataSet5.tblLopHP);
            // TODO: This line of code loads data into the 'dKTCDataSet1.tblLopHP' table. You can move, or remove it, as needed.
            //this.tblLopHPTableAdapter.Fill(this.dKTCDataSet1.tblLopHP);
            constr = "Data Source=LAPTOP-JUURU7V4\\SQLEXPRESS;Initial Catalog=DKTC;Integrated Security=True";
            conn.ConnectionString = constr;
            sql = "Select MaLopHP,MaMon,TenLopHP,Siso,GiangVien,PhongHoc,TietHoc,SSHienTai from tblLopHP";
            da = new SqlDataAdapter(sql, conn);
            da.Fill(dt);
            grdQL.DataSource = dt;
            //conn.Open();
            txtInfo.Text = MaQL;
            sql = "select TenQL from tblQL where MaQL = '" + txtInfo.Text + "'";
            da = new SqlDataAdapter(sql, conn);
            da.Fill(dt1);
            txtHoTen.Text = dt1.Rows[0]["TenQL"].ToString();
        }

        private void btnFix_Click(object sender, EventArgs e)
        {
            
            index = Convert.ToInt16(grdQL.CurrentRow.Index.ToString());
            frmAdd f = new frmAdd(this);
            f.Show();
            //MessageBox.Show(i.ToString());
            f.txtMaHP.Text= grdQL.Rows[index].Cells[0].Value.ToString();
            f.txtMaHP.Text = f.txtMaHP.Text.Trim();
            f.txtMaMon.Text = grdQL.Rows[index].Cells[1].Value.ToString();
            f.txtMaMon.Text = f.txtMaMon.Text.Trim();
            f.txtLopHP.Text = grdQL.Rows[index].Cells[2].Value.ToString();
            f.txtSiSo.Text = grdQL.Rows[index].Cells[3].Value.ToString();
            f.txtGiangVien.Text = grdQL.Rows[index].Cells[4].Value.ToString();
            f.txtPhongHoc.Text = grdQL.Rows[index].Cells[5].Value.ToString();
            f.txtTietHoc.Text = grdQL.Rows[index].Cells[6].Value.ToString();
            f.txtSSHT.Text = grdQL.Rows[index].Cells[7].Value.ToString();
            //MessageBox.Show(f.txtMaMon.Text) ;
            //f.txtMaHP.Focus();
            txtIndex.Text=index.ToString();
        }

        private void grdQL_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            index = Convert.ToInt16(grdQL.CurrentRow.Index.ToString());
            frmThongTinLopHoc f = new frmThongTinLopHoc(this);
            f.Show();
            f.txtMaLHP.Text = grdQL.Rows[index].Cells[0].Value.ToString();
            //f.txtMaLHP.Text = f.txtMaLHP.Text.Trim();
            f.txtMaMon.Text = grdQL.Rows[index].Cells[1].Value.ToString();
            //f.txtMaMon.Text = f.txtMaMon.Text.Trim();
            f.txtTenHP.Text = grdQL.Rows[index].Cells[2].Value.ToString();
            f.txtSiSo.Text = grdQL.Rows[index].Cells[7].Value.ToString()+"/"+ grdQL.Rows[index].Cells[3].Value.ToString();
            f.txtGiangVien.Text = grdQL.Rows[index].Cells[4].Value.ToString();
            f.txtPhongHoc.Text = grdQL.Rows[index].Cells[5].Value.ToString();
            f.txtTietHoc.Text = grdQL.Rows[index].Cells[6].Value.ToString();
            //txtIndex.Text = index.ToString();
            sql="Select tblSV.MaSV, tblSV.TenSV, tblSV.MaNhomMonHoc from tblSV, tblLSDK where tblSV.MaSV=tblLSDK.MaSV and tblLSDK.MaLopHP='" + f.txtMaLHP.Text +"'";
            dt1.Clear();
            da = new SqlDataAdapter(sql, conn);
            da.Fill(dt1);
            f.grdDSSV.DataSource = dt1;
            //ShowDialog();
           // NapLai();
            
        }
        public void NapLai()
        {

            //constr = "Data Source=(local);Initial Catalog=BanHang;Integrated Security=True";
            //conn.ConnectionString = constr;
            //conn.Open();
            sql = "Select * From tblLopHP";
            da = new SqlDataAdapter(sql, conn);
            dt.Clear();
            da.Fill(dt);
            grdQL.DataSource = dt;
            
            grdQL.Refresh();
        }

        private void btnThemmoi_Click_1(object sender, EventArgs e)
        {
            frmAdd f = new frmAdd(this);
            f.Show();
        }

        private void btnXuatThongTin_Click(object sender, EventArgs e)
        {
            sql = "select MaLopHP, TenLopHP, SiSo, GiangVien, PhongHoc, TietHoc, SSHienTai from tblLopHP";
            da = new SqlDataAdapter(sql, conn);
            dtBC.Clear();
            da.Fill(dtBC);
            rptQL bc = new rptQL();
            bc.SetDataSource(dtBC);
            frmRptQL f = new frmRptQL(bc);
            f.Show();
        }

        private void txtInfo_TextChanged(object sender, EventArgs e)
        {
            /*Login f = new Login();
            f.txtDN.Text = txtInfo.Text;*/
        }

        private void txtHoTen_TextChanged(object sender, EventArgs e)
        {

        }

        private void comTCHP_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }
    }
}
