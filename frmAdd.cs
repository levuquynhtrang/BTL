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
    public partial class frmAdd : Form
    {
        SqlConnection conn = new SqlConnection();
        SqlDataAdapter da = new SqlDataAdapter();
        SqlCommand cmd = new SqlCommand();
        DataTable dt = new DataTable();
        DataTable dt1 = new DataTable();
        string sql, constr, s;
        public string INDEX;
        int SiSo, SSHT;
        frmQL QuanLy;

        private void frmAdd_Load(object sender, EventArgs e)
        {
            constr = "Data Source=LVQT\\MSSQLSEVER01;Initial Catalog=DKTC;Integrated Security=True";
            conn.ConnectionString = constr;
            conn.Open();
            sql = "Select * From tblLopHP";
            da = new SqlDataAdapter(sql, conn);
            da.Fill(dt);
            QuanLy.grdQL.DataSource = dt;
            //NapCT();
        }

        private void txtSiSo_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnFix_Click(object sender, EventArgs e)
        {
            string tMaHP, tMaMon, tLopHP, TSiSo, tGiangVien, tPhongHoc, tTietHoc, tSSHT;
            //int i = Convert.ToInt16(grdData.CurrentRow.Index.ToString());
            INDEX = QuanLy.txtIndex.Text;

            int i = int.Parse(INDEX);
            {
                tMaHP = txtMaHP.Text;
                tMaMon = txtMaMon.Text;
                tLopHP = txtLopHP.Text;
                TSiSo = txtSiSo.Text;
                tGiangVien = txtGiangVien.Text;
                tPhongHoc = txtPhongHoc.Text;
                tTietHoc = txtTietHoc.Text;
                tSSHT = txtSSHT.Text;
                int SSHT;
                SSHT = Convert.ToInt32(tSSHT);
                int SiSo;
                SiSo = Convert.ToInt32(TSiSo);
                if (tMaHP == QuanLy.grdQL.Rows[i].Cells[0].Value.ToString().Trim() && tMaMon==QuanLy.grdQL.Rows[i].Cells[1].Value.ToString().Trim())
                {
                    sql = "Update tblLopHP set TenLopHP=N'" + tLopHP + "', SiSo=" +SiSo + ", GiangVien = N'" + 
                        tGiangVien + "', PhongHoc= N'" + tPhongHoc + "', TietHoc= N'" + tTietHoc + "', SSHienTai="+ 
                        SSHT +"Where MaLopHP='"+tMaHP+"' and MaMon='"+tMaMon+"'";
                } else
                {
                    MessageBox.Show("Không thể sửa dữ liệu Mã lớp học phần và Mã môn!");
                   /* frmAdd f = new frmAdd();
                    f.Close();*/
                }
                cmd.Connection = conn;
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();
                NapLai();
            }
        }
        public frmAdd()
        {
           
            InitializeComponent();
        }
        public frmAdd(frmQL ql)
        {
            this.QuanLy = ql;
            InitializeComponent();
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
            QuanLy.grdQL.DataSource = dt;
            QuanLy.grdQL.Refresh();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {

           // cmd.ExecuteNonQuery();
            //QuanLy.grdQL.Refresh();
            string tMaHP, tMaMon, tLopHP,TSiSo, tGiangVien, tPhongHoc, tTietHoc, tSSHT;
            //int i = Convert.ToInt16(QuanLy.grdQL.CurrentRow.Index.ToString());
            txtMaHP.Focus();
            tMaHP = txtMaHP.Text;
            tMaMon = txtMaMon.Text;
            tLopHP = txtLopHP.Text;
            TSiSo = txtSiSo.Text;
            tGiangVien = txtGiangVien.Text;
            tPhongHoc = txtPhongHoc.Text;
            tTietHoc = txtTietHoc.Text;
            tSSHT = txtSSHT.Text;
            int SSHT;
            SSHT = Convert.ToInt32(tSSHT);
            int SiSo;
            SiSo= Convert.ToInt32(TSiSo);

            sql = "Insert into tblLopHP(MaLopHP,MaMon,TenLopHP,SiSo,GiangVien,PhongHoc,TietHoc,SSHienTai)" +
                " Values ('" + tMaHP + "','" + tMaMon + "',N'" + tLopHP + "',"+
                  SiSo + ", '" + tGiangVien + "',N'" + tPhongHoc + "',N'" + tTietHoc + "'," + SSHT +" )";
            cmd.Connection = conn;
            cmd.CommandText = sql;
            cmd.ExecuteNonQuery();
            NapLai();
            txtMaHP.Text = "";
            txtMaMon.Text = "";
            txtLopHP.Text = "";
            txtSiSo.Text = "";
            txtGiangVien.Text = "";
            txtPhongHoc.Text = "";
            txtTietHoc.Text = "";
            txtSSHT.Text = "";
        }
    }
}
