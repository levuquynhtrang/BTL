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
    public partial class FrmLSDK : Form
    {
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
            frmSV f = new frmSV();
            f.Show();
            this.Close();
        }

        private void btnDKHP_LSDK_Click(object sender, EventArgs e)
        {
            frmSV f = new frmSV();
            f.Show();
            this.Close();
        }

        private void btnTCHP_LSDK_Click(object sender, EventArgs e)
        {
            frmTCHP f = new frmTCHP();
            f.Show();
            this.Close();
        }
    }
}
