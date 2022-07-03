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
    public partial class frmRptKQDk : Form
    {
        public frmRptKQDk(rptKQDK rpt)
        {
            InitializeComponent();
            crystalReportViewer1.ReportSource = rpt;
        }

        private void frmRptKQDk_Load(object sender, EventArgs e)
        {

        }
    }
}
