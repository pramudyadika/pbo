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
   
    public partial class DataTransaksi : Form
    {
        private DataSet ds;
        private SqlDataAdapter da;

        private string text_kwitansi;
        Kelas.Koneksi konn = new Kelas.Koneksi();

        void cetak()
        {
            SqlConnection conn = konn.GetConn();
            {
                conn.Open();
                da = new SqlDataAdapter("select * from vw_cetaktransaksi where NoKwitansi = '" + text_kwitansi + "'", conn);
                ds = new DataSet();
                da.Fill(ds, "vw_cetaktransaksi");
                report_transaksi myreport = new report_transaksi();
                myreport.SetDataSource(ds);
                crystalReportViewer1.ReportSource = myreport;
                crystalReportViewer1.Refresh();
            }
        }

        public DataTransaksi(String nokwitansi)
        {
            InitializeComponent();
            text_kwitansi = nokwitansi;
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void DataTransaksi_Load(object sender, EventArgs e)
        {
            cetak();
        }
    }
}
