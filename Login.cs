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
            txtDN.Text = "";
            txtDN.BackColor = Color.FromArgb(197, 173, 217);
        }

        private void txtDN_Leave(object sender, EventArgs e)
        {
            if (txtDN.Text == "") txtDN.Text = "Tên đăng nhập";

        }

        private void txtMK_Enter(object sender, EventArgs e)
        {
            txtMK.Text = "";
            txtMK.BackColor = Color.FromArgb(197, 173, 217);
        }

        private void txtMK_Leave(object sender, EventArgs e)
        {
            if (txtMK.Text == "") txtMK.Text = "Mật khẩu";
        }
    }
}
