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
    public partial class frmAdd : Form
    {
        frmQL QuanLy;
        public frmAdd(frmQL ql)
        {
            this.QuanLy = ql;
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            
            txtMaHP.Text = "";
            txtMaMon.Text = "";
            txtLopHP.Text = "";
            txtSiSo.Text = "";
            txtGiangVien.Text = "";
            txtPhongHoc.Text = "";
            txtTietHoc.Text = "";

        }
    }
}
