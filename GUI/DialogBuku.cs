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

namespace Apl_Penjualan.GUI
{
    public partial class DialogBuku : Form
    {
        private SqlCommand cmd;
        private DataSet ds;
        private SqlDataAdapter da;

        public string kodebuku, namabuku, harga = "";

        Kelas.Koneksi konn = new Kelas.Koneksi();

        void refresh_barang()
        {
            SqlConnection conn = konn.GetConn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from tabel_barang", conn);
                    ds = new DataSet();
                    da = new SqlDataAdapter(cmd);
                    da.Fill(ds, "tabel_barang");
                    dataGridView_buku.DataSource = ds;
                    dataGridView_buku.DataMember = "tabel_barang";
                    dataGridView_buku.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    dataGridView_buku.AllowUserToAddRows = false;
                    dataGridView_buku.Refresh();
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.ToString());
                }
                finally
                {
                    conn.Close();
                }
            }
        }



        void cari_barang()
        {
            SqlConnection conn = konn.GetConn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from tabel_barang where KodeBuku like '%" + textBox_cari.Text + "%' or NamaBuku like '%" + textBox_cari.Text + "%'", conn);
                    ds = new DataSet();
                    da = new SqlDataAdapter(cmd);
                    da.Fill(ds, "tabel_barang");
                    dataGridView_buku.DataSource = ds;
                    dataGridView_buku.DataMember = "tabel_barang";
                    dataGridView_buku.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    dataGridView_buku.AllowUserToAddRows = false;
                    dataGridView_buku.Refresh();
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.ToString());
                }
                finally
                {
                    conn.Close();
                }
            }
        }

        public DialogBuku()
        {
            InitializeComponent();
            refresh_barang();
        }

        private void dataGridView_buku_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            cari_barang();
        }

        private void dataGridView_buku_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                DataGridViewRow row = this.dataGridView_buku.Rows[e.RowIndex];
                kodebuku = row.Cells["KodeBuku"].Value.ToString();
                namabuku = row.Cells["NamaBuku"].Value.ToString();
                harga = row.Cells["Harga"].Value.ToString();
                this.Close();

            }
            catch (Exception x)
            {
                MessageBox.Show(x.ToString());
            }
        }

        private void DialogBuku_Load(object sender, EventArgs e)
        {

        }

        private void textBox_cari_TextChanged(object sender, EventArgs e)
        {
            cari_barang();
        }

        public String ambil_kode_buku
        {
            get
            {
                return kodebuku;
            }
        }

        public String ambil_nama_buku
        {
            get
            {
                return namabuku;
            }
        }
        public String ambil_harga
        {
            get
            {
                return harga;
            }
        }
    }
}
