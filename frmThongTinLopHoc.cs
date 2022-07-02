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
    public partial class frmThongTinLopHoc : Form
    {
        public frmThongTinLopHoc()
        {
            InitializeComponent();
        }

        private void frmThongTinLopHoc_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dKTCDataSet5.tblSV' table. You can move, or remove it, as needed.
            this.tblSVTableAdapter.Fill(this.dKTCDataSet5.tblSV);
            // TODO: This line of code loads data into the 'dKTCDataSet5.tblLSDK' table. You can move, or remove it, as needed.
            this.tblLSDKTableAdapter.Fill(this.dKTCDataSet5.tblLSDK);

        }

   
    }
}
