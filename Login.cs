﻿using System;
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
            constr = "Data Source=LAPTOP-JUURU7V4\\SQLEXPRESS;Initial Catalog=DKTC;Integrated Security=True";
            conn.ConnectionString = constr;
            //conn.Open();
        }

        private void txtDN_Enter(object sender, EventArgs e)
        {
            txtDN.ForeColor = Color.FromArgb(30, 75, 114);
            if(txtDN.Text == "Tên đăng nhập")
            {
                txtDN.Text = "";
                txtDN.BackColor = Color.FromArgb(200, 218, 231);
                
            }
            else
            {
                txtDN.BackColor = Color.FromArgb(200, 218, 231);
            }
        }

        private void txtDN_Leave(object sender, EventArgs e)
        {
            if (txtDN.Text == "") { txtDN.Text = "Tên đăng nhập"; };
            txtDN.BackColor = Color.FromArgb(30, 75, 114);
            txtDN.ForeColor = Color.FromArgb(200, 218, 231);
        }

        private void txtMK_Enter(object sender, EventArgs e)
        {
            
         }

        private void txtMK_Leave(object sender, EventArgs e)
        {
            if (txtMK.Text == "") txtMK.Text = "Mật khẩu";
            if (txtMK.Text == "Mật khẩu") txtMK.PasswordChar = '\0';
            txtMK.BackColor = Color.FromArgb(30, 75, 114);
            txtMK.ForeColor = Color.FromArgb(200, 218, 231);
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
                    //this.Close();*/
                    frmSV f = new frmSV();
                    f.maSV = txtDN.Text;
                    f.Show();
                    this.Hide();
                    
                }
                else
                {
                    
                    MessageBox.Show("Đăng nhập thất bại","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Information);
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
            conn.Open();
            sql = "select * from tblQL where MaQL = '" + txtDN.Text + "' and MatKhauQL= '" + txtMK.Text + "'";
            cmd = new SqlCommand(sql, conn);
            SqlDataReader dta1 = cmd.ExecuteReader();
            if (dta1.Read() == true)
            {
                //this.Close();
                frmQL f = new frmQL();               
                f.MaQL = txtDN.Text;
                f.Show();
                this.Hide();


            }
            else
            {
                MessageBox.Show("Đăng nhập thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                conn.Close();
            }
        }

        private void txtDN_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtMK_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtMK_Click(object sender, EventArgs e)
        {
            if (txtMK.Text=="Mật khẩu")
            {
                txtMK.Text = "";
                txtMK.PasswordChar = '*';
                txtMK.BackColor = Color.FromArgb(200, 218, 231);
                txtMK.ForeColor = Color.FromArgb(30, 75, 114);
            }
            
        }

    }
}
