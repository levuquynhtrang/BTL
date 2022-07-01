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
        SqlDataAdapter da = new SqlDataAdapter();
        SqlCommand cmd = new SqlCommand();
        DataTable dt = new DataTable();
        DataTable dt1 = new DataTable();
        string sql, constr, s;
        int i;
        
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
            //frmTCHP f = new frmTCHP();
            //f.Show();
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

        }

        private void btnQuayVe_Click(object sender, EventArgs e)
        {
            if (grdMonHoc.Visible==false)
            {
                grdLopHP.Visible = false;
                grdMonHoc.Visible = true;
                dt.Clear();
                sql = "Select MaMon, TenMon, SoTC from tblMonHoc";
                da = new SqlDataAdapter(sql, conn);
                da.Fill(dt);
                grdMonHoc.DataSource = dt;
            }
            
        }

        private void grdMonHoc_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            i = grdMonHoc.CurrentRow.Index;
            s = grdMonHoc.Rows[i].Cells["MaMon"].Value.ToString();
            sql = "select * from tblLopHP Where MaMon = '"+s+"'";
            grdMonHoc.Visible=false;
            if (grdLopHP.Visible==false) grdLopHP.Visible = true;
            dt.Clear();
            da = new SqlDataAdapter(sql, conn);
            da.Fill(dt);
            grdLopHP.DataSource = dt;
        }

        private void frmSV_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dKTCDataSet2.tblLopHP' table. You can move, or remove it, as needed.
            this.tblLopHPTableAdapter2.Fill(this.dKTCDataSet2.tblLopHP);
            // TODO: This line of code loads data into the 'dKTCDataSet2.tblMonHoc' table. You can move, or remove it, as needed.
            this.tblMonHocTableAdapter1.Fill(this.dKTCDataSet2.tblMonHoc);
            // TODO: This line of code loads data into the 'dKTCDataSet1.tblLopHP' table. You can move, or remove it, as needed.
            this.tblLopHPTableAdapter1.Fill(this.dKTCDataSet1.tblLopHP);
            // TODO: This line of code loads data into the 'dKTCDataSet.tblLopHP' table. You can move, or remove it, as needed.
            this.tblLopHPTableAdapter.Fill(this.dKTCDataSet.tblLopHP);
            // TODO: This line of code loads data into the 'dKTCDataSet.tblMonHoc' table. You can move, or remove it, as needed.
            //this.tblMonHocTableAdapter.Fill(this.dKTCDataSet.tblMonHoc);

            constr = @"Data Source=LAPTOP-F0TSIU3S;Initial Catalog=DKTC;Integrated Security=True";
            conn.ConnectionString = constr;
            sql = "Select MaMon, TenMon, SoTC from tblMonHoc";
            da = new SqlDataAdapter(sql, conn);
            da.Fill(dt);
            grdMonHoc.DataSource = dt;
            txtInfor.Text = maSV;
            

            //dt.Clear();
            sql = "select TenSV from tblSV where MaSV = '" + txtInfor.Text + "'";
            da = new SqlDataAdapter(sql, conn);
            da.Fill(dt1);
            txtHoTen.Text = dt1.Rows[0]["TenSV"].ToString();
            
        }
    }
}
