using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTL
{
    public partial class frmThongTinLopHoc : Form
    {
        SqlConnection conn = new SqlConnection();
        SqlDataAdapter da = new SqlDataAdapter();
        SqlCommand cmd = new SqlCommand();
        DataTable dt = new DataTable();
        DataTable dt1 = new DataTable();
        string sql, constr, s;
        //public string ;
        //int SiSo, SSHT;
        frmQL QL;
        public frmThongTinLopHoc(frmQL ql)
        {
            this.QL = ql;
            InitializeComponent();
        }

        private void frmThongTinLopHoc_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dKTCDataSet5.tblSV' table. You can move, or remove it, as needed.
            //this.tblSVTableAdapter.Fill(this.dKTCDataSet5.tblSV);
            // TODO: This line of code loads data into the 'dKTCDataSet5.tblLSDK' table. You can move, or remove it, as needed.
            //this.tblLSDKTableAdapter.Fill(this.dKTCDataSet5.tblLSDK);
            constr = "Data Source=LVQT\\MSSQLSEVER01;Initial Catalog=DKTC;Integrated Security=True";
            //constr = "Data Source=LVQT\\MSSQLSEVER01;Initial Catalog=DKTC;Integrated Security=True";
            conn.ConnectionString = constr;
            sql = "Select * from tblSV";
            da = new SqlDataAdapter(sql, conn);
            da.Fill(dt);
            grdDSSV.DataSource = dt;
        }

   
    }
}
