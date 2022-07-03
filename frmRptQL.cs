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
    public partial class frmRptQL : Form
    {
        public frmRptQL(rptQL rpt)
        {
            InitializeComponent();
            crystalReportViewer2.ReportSource = rpt;
        }

        private void frmRptQL_Load(object sender, EventArgs e)
        {

        }
    }
}
