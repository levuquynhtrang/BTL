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
//using 

namespace BTL
{
    public partial class frmSV : Form
    {
        public string maSV;
        SqlConnection conn = new SqlConnection();
        SqlConnection conn2 = new SqlConnection();
        SqlDataAdapter da = new SqlDataAdapter();
        SqlCommand cmd = new SqlCommand();
        DataTable dt = new DataTable();
        DataTable dt1 = new DataTable();
        DataTable dt2 = new DataTable();
        DataTable dt3 = new DataTable();
        DataTable dt4 = new DataTable();

        string sql, constr, s;
        int i;
        string tenMH, stc, maMH, monTienQuyet;


        public frmSV()
        {
            InitializeComponent();
        }

        private void trangchu_Click(object sender, EventArgs e)
        {
            //frmSV f = new frmSV();
            //f.Show();
            //this.Close();
            txtInfor.Text = maSV;
        }

        private void btnLSDKHP_Click(object sender, EventArgs e)
        {
            FrmLSDK f = new FrmLSDK();
            f.MaSV = txtInfor.Text;
            f.Show();
            //this.Close();
            //txtInfor.Text = maSV;
        }

        private void btnDKHP_Click(object sender, EventArgs e)
        {
            //frmSV f = new frmSV();
            // f.Show();
            // this.Close();
            txtInfor.Text = maSV;
        }

        private void btnTCHP_Click(object sender, EventArgs e)
        {
           TCHP f = new TCHP();
           f.Show();
            //this.Close();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Login f = new Login();
            f.ShowDialog();
        }

        private void comNhomMon_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comNhomMon.Text == "")
            {
                sql = "Select MaMon, TenMon, SoTC from tblMonHoc";
            }
            else if (comNhomMon.Text == "Các môn đại cương")
            {
                sql = "Select MaMon, TenMon, SoTC from tblMonHoc where MaNhomMonHoc='DC'";
            }
            else if (comNhomMon.Text == "Tất cả các môn")
            {
                sql = "Select MaMon, TenMon, SoTC from tblMonHoc,tblSV  where MaNhomMonHoc='DC'and tblSV.MaNhomMonHoc=tblMonHoc.MaNhomMonHoc and tblSV.MaSV = '" + txtInfor.Text + "'";
            }
            else
            {
                sql = "Select MaMon, TenMon, SoTC from tblMonHoc,tblSV where tblSV.MaNhomMonHoc=tblMonHoc.MaNhomMonHoc and tblSV.MaSV = '"+txtInfor.Text+"'";

            }
            dt.Clear();
            da = new SqlDataAdapter(sql, conn);
            da.Fill(dt);
            grdMonHoc.DataSource = dt;
            //grdMonHoc.Visible = false;
        }

        private void txtInfor_TextChanged(object sender, EventArgs e)
        {
            //txtInfor.Text = msv + "|";
            //txtInfor.Text = maSV;
        }

        private void btnDK_Click(object sender, EventArgs e)
        {
            string maSV, maLopHP, tenMon, hk, namHoc, tietHoc, phongHoc, giangVien;
            int soTC;
            i = grdLopHP.CurrentRow.Index;
            maSV = txtInfor.Text;
            maLopHP = grdLopHP.Rows[i].Cells["MaLopHP"].Value.ToString();
            tenMon = tenMH;
            namHoc = "2021-2022";
            hk = "Học kỳ 2";
            tietHoc = grdLopHP.Rows[i].Cells["TietHoc"].Value.ToString();
            phongHoc = grdLopHP.Rows[i].Cells["PhongHoc"].Value.ToString();
            giangVien = grdLopHP.Rows[i].Cells["GiangVien"].Value.ToString();
            soTC = int.Parse(stc);

            //Xem môn học tồn tại trong LSDK chưa
            sql = "select MaMon from tblLSDK where MaSV='" + maSV + "' and MaMon = '" + maMH + "'";
            da = new SqlDataAdapter(sql, conn);
            DataTable dtLS = new DataTable();
            da.Fill(dtLS);
            //MessageBox.Show(dtLS.Rows.Count.ToString(), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //string x = dtLS.Rows[0]["MaMon"].ToString();
            if (dtLS.Rows.Count == 0)
            {
                sql = "select MaLopHP from tblLopHP where SSHienTai < SiSo and MaLopHP ='" + maLopHP + "'";
                da = new SqlDataAdapter(sql, conn);
                DataTable dtML = new DataTable();
                da.Fill(dtML);
                if (dtML.Rows.Count > 0)
                {
                    sql = "select maSV from tblLSDK where MaMon = '" + monTienQuyet + "' and  MaSV='" + maSV + "'";
                    da = new SqlDataAdapter(sql, conn);
                    DataTable dtMTQ = new DataTable();
                    da.Fill(dtMTQ);
                    //MessageBox.Show(dtMTQ.Rows.Count.ToString()+ monTienQuyet, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    if (dtMTQ.Rows.Count > 0 || monTienQuyet == "")
                    {
                        sql = "insert into tblKQDangKi values ('" + maSV + "','" + maLopHP + "',N'" + tenMon + "'," + soTC + ",N'"
                                + hk + "','" + namHoc + "','" + tietHoc + "','" + phongHoc + "',N'" + giangVien + "')";
                        cmd.Connection = conn;
                        cmd.CommandText = sql;
                        cmd.ExecuteNonQuery();

                        sql = "insert into tblLSDK values ('" + maSV + "','" + maMH + "','" + maLopHP + "',N'" + tenMon + "'," + soTC + ",N'"
                                + hk + "','" + namHoc + "','" + tietHoc + "','" + phongHoc + "',N'" + giangVien + "')";
                        cmd.Connection = conn;
                        cmd.CommandText = sql;
                        cmd.ExecuteNonQuery();
                        NapLai();
                    }
                    else
                    {
                        MessageBox.Show("Không đăng kí được vì chưa học môn " + monTienQuyet, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Lớp học đã hết slot", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            else
            {
                MessageBox.Show("Môn học " + tenMon + " đã tồn tại trong lịch sử đăng kí", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnQuayVe_Click(object sender, EventArgs e)
        {
            if (grdMonHoc.Visible == false)
            {
                grdLopHP.Visible = false;
                grdMonHoc.Visible = true;
                dt2.Clear();
                sql = "Select * from tblMonHoc";
                da = new SqlDataAdapter(sql, conn);
                da.Fill(dt2);
                grdMonHoc.DataSource = dt2;
            }

        }

        private void btnHDDK_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://drive.google.com/file/d/12JMQuaUM5f-qtzbkeuIcPQQ4qk41XCnY/view");
        }

        private void grdMonHoc_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            i = grdMonHoc.CurrentRow.Index;
            s = grdMonHoc.Rows[i].Cells["MaMon"].Value.ToString();
            tenMH = grdMonHoc.Rows[i].Cells["TenMon"].Value.ToString();
            maMH = grdMonHoc.Rows[i].Cells["MaMon"].Value.ToString();
            monTienQuyet = grdMonHoc.Rows[i].Cells["MaMonTienQuyet"].Value.ToString();
            stc = grdMonHoc.Rows[i].Cells["SoTC"].Value.ToString();
            sql = "select * from tblLopHP Where MaMon = '" + s + "'";
            grdMonHoc.Visible = false;
            if (grdLopHP.Visible == false) grdLopHP.Visible = true;
            dt.Clear();
            da = new SqlDataAdapter(sql, conn);
            da.Fill(dt);
            grdLopHP.DataSource = dt;

        }

        private void frmSV_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dKTCDataSet5.tblLopHP' table. You can move, or remove it, as needed.
            this.tblLopHPTableAdapter3.Fill(this.dKTCDataSet5.tblLopHP);
            // TODO: This line of code loads data into the 'dKTCDataSet5.tblMonHoc' table. You can move, or remove it, as needed.
            this.tblMonHocTableAdapter2.Fill(this.dKTCDataSet5.tblMonHoc);
            // TODO: This line of code loads data into the 'dKTCDataSet5.tblKQDangKi' table. You can move, or remove it, as needed.
            //this.tblKQDangKiTableAdapter.Fill(this.dKTCDataSet5.tblKQDangKi);
            // TODO: This line of code loads data into the 'dKTCDataSet2.tblLopHP' table. You can move, or remove it, as needed.
            //s.tblLopHPTableAdapter2.Fill(this.dKTCDataSet2.tblLopHP);
            // TODO: This line of code loads data into the 'dKTCDataSet2.tblMonHoc' table. You can move, or remove it, as needed.
            // this.tblMonHocTableAdapter1.Fill(this.dKTCDataSet2.tblMonHoc);
            // TODO: This line of code loads data into the 'dKTCDataSet1.tblLopHP' table. You can move, or remove it, as needed.
            // this.tblLopHPTableAdapter1.Fill(this.dKTCDataSet1.tblLopHP);
            // TODO: This line of code loads data into the 'dKTCDataSet.tblLopHP' table. You can move, or remove it, as needed.
            // this.tblLopHPTableAdapter.Fill(this.dKTCDataSet.tblLopHP);
            // TODO: This line of code loads data into the 'dKTCDataSet.tblMonHoc' table. You can move, or remove it, as needed.
            //this.tblMonHocTableAdapter.Fill(this.dKTCDataSet.tblMonHoc);

            constr = "Data Source=LVQT\\MSSQLSEVER01;Initial Catalog=DKTC;Integrated Security=True";
            conn.ConnectionString = constr;
            conn2.ConnectionString = constr;
            conn.Open();
            dt.Clear();
            sql = "Select * from tblMonHoc";
            da = new SqlDataAdapter(sql, conn);
            da.Fill(dt);
            grdMonHoc.DataSource = dt;
            txtInfor.Text = maSV;


            dt1.Clear();
            sql = "select TenSV from tblSV where MaSV = '" + txtInfor.Text + "'";
            da = new SqlDataAdapter(sql, conn);
            da.Fill(dt1);
            txtHoTen.Text = dt1.Rows[0]["TenSV"].ToString();

            dt3.Clear();
            sql = "Select * from tblKQDangKi";
            da = new SqlDataAdapter(sql, conn);
            da.Fill(dt3);
            grdKQDK.DataSource = dt3;

        }
        public void NapLai()
        {

            sql = "Select * From tblKQDangKi";
            da = new SqlDataAdapter(sql, conn);
            dt4.Clear();
            da.Fill(dt4);
            grdKQDK.DataSource = dt4;
            grdKQDK.Refresh();
        }

    }
}
