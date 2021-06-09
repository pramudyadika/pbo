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
    public partial class FormTransaksi : Form
    {

        private SqlCommand cmd;
        private DataSet ds;
        private SqlDataAdapter da;
        private SqlDataReader rd;

        Kelas.Koneksi konn = new Kelas.Koneksi();

        void bersih()
        {
            textBox_kwitansi.Text = "";
            dateTimePicker_kwitansi.Value = DateTime.Now;
            textBox_idpelanggan.Text = "";
            textBox_namapelanggan.Text = "";
            textBox_jumlah.Text = "0";
            textBox_kodebuku.Text = "";
            textBox_namabuku.Text = "";
            textBox_hargabuku.Text = "0";
            textBox_namapelanggan.Enabled = false;
            textBox_idpelanggan.Enabled = false;
            textBox_kodebuku.Enabled = false;
            textBox_namabuku.Enabled = false;
            textBox_hargabuku.Enabled = false;
            button_simpan.Enabled = false;
            button_minus.Enabled = false;
            
        }

        private void awal()
        {
            bersih();
            SqlConnection conn = konn.GetConn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("SELECT * FROM vw_penjualan order by NoKwitansi DESC", conn);
                    ds = new DataSet();
                    da = new SqlDataAdapter(cmd);
                    da.Fill(ds, "vw_penjualan");
                    dataGridView_transaksi.DataSource = ds;
                    dataGridView_transaksi.DataMember = "vw_penjualan";
                    dataGridView_transaksi.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    dataGridView_transaksi.AllowUserToAddRows = false;
                    dataGridView_transaksi.Refresh();

                }
                catch (Exception e)
                {
                    MessageBox.Show(e.ToString());
                }
                finally
                {
                    conn.Close();
                }
                groupBox_transaksi.Enabled = false;
            }
        }

        private void auto_number()
        {
            long hitung;
            string urut;
            SqlConnection conn = konn.GetConn();
            
            conn.Open();
            cmd = new SqlCommand("select NoKwitansi from tabel_penjualan where NoKwitansi in(SELECT MAX(NoKwitansi) from tabel_penjualan) order by NoKwitansi desc", conn);
            rd = cmd.ExecuteReader();
            rd.Read();

            if (rd.HasRows)
            {
                hitung = Convert.ToInt64(rd[0].ToString().Substring(rd["NoKwitansi"].ToString().Length - 12, 4)) + 1;
                string joinstr = "0000" + hitung;
                urut = "Rek-" + joinstr.Substring(joinstr.Length - 4, 4) + "/" + DateTime.Now.ToString("MM/yyyy");
            }
            else
            {
                urut = "Rek-0001/" + DateTime.Now.ToString("MM/yyyy");
            }
            rd.Close();
            textBox_kwitansi.Text = urut;
            textBox_kwitansi.Enabled = false;
            conn.Close();
        }
        private void Simpan_MasterPenjualan()
        {
            SqlConnection conn = konn.GetConn();
            {
                cmd = new SqlCommand("insert into tabel_penjualan values('" + textBox_kwitansi.Text + "','" + dateTimePicker_kwitansi.Text + "','" + textBox_idpelanggan.Text + "')", conn);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }
        private void Simpan_DetailPenjualan()
        {
            SqlConnection conn = konn.GetConn();
            {
                cmd = new SqlCommand("insert into tabel_detailpenjualan values('" + textBox_kwitansi.Text + "','" + textBox_kodebuku.Text + "','" + textBox_jumlah.Text + "')", conn);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        private void refresh_penjualan()
        {
            SqlConnection conn = konn.GetConn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("SELECT * FROM vw_detail where NoKwitansi= '" + textBox_kwitansi.Text + "'", conn);
                    ds = new DataSet();
                    da = new SqlDataAdapter(cmd);
                    da.Fill(ds, "vw_detail");
                    dataGridView_transaksi.DataSource = ds;
                    dataGridView_transaksi.DataMember = "vw_detail";
                    dataGridView_transaksi.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    dataGridView_transaksi.AllowUserToAddRows = false;
                    dataGridView_transaksi.Refresh();

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

        private void RefreshTransaksi()
        {
            refresh_penjualan();
            textBox_kodebuku.Clear();
            textBox_namabuku.Clear();
            textBox_hargabuku.Text = "0";
            textBox_jumlah.Text = "0";
            textBox_jumlah.Focus();

        }

        private void totalseluruh()
        {
            SqlConnection conn = konn.GetConn();
            {
                conn.Open();
                cmd = new SqlCommand("select sum(Harga*Jumlah) as TotalBayar from vw_detail where NoKwitansi = '" + textBox_kwitansi.Text + "'", conn);
                cmd.Connection = conn;
                int result = ((int)cmd.ExecuteScalar());
                String TotalSeluruh = result.ToString();
                label_totalseluruh.Text = result.ToString();
                conn.Close();
            }
        }
        public FormTransaksi()
        {
            InitializeComponent();
            awal();
            auto_number();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button_caripelanggan_Click(object sender, EventArgs e)
        {
            DialogPelanggan plgn = new DialogPelanggan();
            plgn.ShowDialog();
            textBox_idpelanggan.Text = plgn.ambil_id_pelanggan;
            textBox_namapelanggan.Text = plgn.ambil_nama_pelanggan;
        }

        private void button_caribuku_Click(object sender, EventArgs e)
        {
            DialogBuku brg = new DialogBuku();
            brg.ShowDialog();
            textBox_kodebuku.Text = brg.ambil_kode_buku;
            textBox_namabuku.Text = brg.ambil_nama_buku;
            textBox_hargabuku.Text = brg.ambil_harga;
        }

        private void button_baru_Click(object sender, EventArgs e)
        {
            awal();
            auto_number();
            dateTimePicker_kwitansi.Focus();
            button_caripelanggan.Enabled = true;
        }

        private void dataGridView_transaksi_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            button_plus.Enabled = false;
            button_minus.Enabled = true;
            DataGridViewRow row = this.dataGridView_transaksi.Rows[e.RowIndex];
            textBox_kodebuku.Text = row.Cells["KodeBuku"].Value.ToString();
            textBox_namabuku.Text = row.Cells["NamaBuku"].Value.ToString();
            textBox_hargabuku.Text = row.Cells["Harga"].Value.ToString();
            textBox_jumlah.Text = row.Cells["Jumlah"].Value.ToString();
        }

        private void label_totalseluruh_Click(object sender, EventArgs e)
        {

        }

        private void button_simpan_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Transaksi Selesai");

            awal();
            label_totalseluruh.Text = "0";
            button_caripelanggan.Enabled = true;
            auto_number();

            Laporan.DataTransaksi a = new Laporan.DataTransaksi(textBox_kwitansi.Text);
            a.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox_idpelanggan_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_namapelanggan_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker_kwitansi_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button_plus_Click(object sender, EventArgs e)
        {
            SqlDataReader reader = null;
            SqlConnection conn = konn.GetConn();
            {
                if (textBox_kwitansi.Text.Trim() == "" || textBox_idpelanggan.Text.Trim() == "" || textBox_kodebuku.Text.Trim() == "" || textBox_jumlah.Text.Trim() == "")
                {
                    MessageBox.Show("Mohon Lengkapi Data!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from tabel_penjualan where NoKwitansi = '" + textBox_kwitansi.Text + "'", conn);
                    cmd.ExecuteNonQuery();
                    reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        Simpan_DetailPenjualan();
                        totalseluruh();
                    }
                    else
                    {
                        Simpan_MasterPenjualan();
                        Simpan_DetailPenjualan();
                        totalseluruh();
                    }
                    button_caripelanggan.Enabled = false;
                    button_simpan.Enabled = true;
                    groupBox_transaksi.Enabled = true;
                    RefreshTransaksi();
                    
                }
            }
        }

        private void button_minus_Click(object sender, EventArgs e)
        {
            SqlConnection conn = konn.GetConn();
            {
                cmd = new SqlCommand("delete from tabel_detailpenjualan where NoKwitansi = '" + textBox_kwitansi.Text + "' AND KodeBuku = '" + textBox_kodebuku.Text + "'", conn);
                conn.Open();
                cmd.ExecuteNonQuery();
                totalseluruh();

                RefreshTransaksi();
                button_plus.Enabled = true;
                button_minus.Enabled = false;
            }
        }
    }
}

       