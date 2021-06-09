using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using CrystalDecisions.CrystalReports.Engine;

namespace Apl_Penjualan.Laporan
{

    public partial class DataBarang : Form
    {
        private DataSet ds;
        private SqlDataAdapter da;

        Kelas.Koneksi konn = new Kelas.Koneksi();

        void cetak()
        {
            SqlConnection conn = konn.GetConn();
            {
                conn.Open();
                da = new SqlDataAdapter("select * from tabel_barang order by KodeBuku asc", conn);
                ds = new DataSet();
                da.Fill(ds, "tabel_barang");
                report_barang myreport = new report_barang();
                myreport.SetDataSource(ds);
                crystalReportViewer1.ReportSource = myreport;
                crystalReportViewer1.Refresh();
            }
        }

        public DataBarang()
        {
            InitializeComponent();
            cetak();
        }
    }
}
