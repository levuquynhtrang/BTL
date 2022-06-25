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
    public partial class frmTCHP : Form
    {
        public frmTCHP()
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

        private void txtNhap_Click(object sender, EventArgs e)
        {
           if (txtNhap.Text=="Nhập từ khóa") txtNhap.Text = "";
        }

        private void txtNhap_Leave(object sender, EventArgs e)
        {
            if (txtNhap.Text == "") txtNhap.Text = "Nhập từ khóa";
        }
    }
}
