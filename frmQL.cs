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
    public partial class frmQL : Form
    {
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
    }
}
