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
    public partial class frmSV : Form
    {
        public frmSV()
        {
            InitializeComponent();
        }

        private void trangchu_Click(object sender, EventArgs e)
        {
            frmSV f = new frmSV();
            f.Show();
            this.Close();
        }

        private void btnLSDKHP_Click(object sender, EventArgs e)
        {
            FrmLSDK f = new FrmLSDK();
            f.Show();
            this.Close();
        }

        private void btnDKHP_Click(object sender, EventArgs e)
        {
            frmSV f = new frmSV();
            f.Show();
            this.Close();
        }

        private void btnTCHP_Click(object sender, EventArgs e)
        {
            frmTCHP f = new frmTCHP();
            f.Show();
            this.Close();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Login f = new Login();
            f.ShowDialog();
        }
    }
}
