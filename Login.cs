using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTL
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            
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
            /*if (txtMK.Text == "Mật khẩu")
            {

                txtMK.Text = "";
                txtMK.BackColor = Color.FromArgb(197, 173, 217);
                txtMK.PasswordChar = '*';
                // txtMK.PasswordChar = '\0';
            }
            else { 
                txtMK.Text = "";
                txtMK.PasswordChar = '*';
                txtMK.BackColor = Color.FromArgb(197, 173, 217);
            }*/
                //picHide.BackColor= Color.FromArgb(197, 173, 217);
          }

        private void txtMK_Leave(object sender, EventArgs e)
        {
            if (txtMK.Text == "") txtMK.Text = "Mật khẩu";
            if (txtMK.Text == "Mật khẩu") txtMK.PasswordChar = '\0';
            txtMK.BackColor = Color.FromArgb(68, 43, 99);
           
        }

        private void btnSV_Click(object sender, EventArgs e)
        {
            frmSV f = new frmSV();
            f.Show();
            this.Visible = false;
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
