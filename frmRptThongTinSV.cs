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
    public partial class frmRptThongTinSV : Form
    {
        public frmRptThongTinSV(rptThongTinSV rpt)
        {
            InitializeComponent();
            crystalReportViewerTTSV.ReportSource = rpt;
        }

        private void frmRptThongTinSV_Load(object sender, EventArgs e)
        {

        }
    }
}
