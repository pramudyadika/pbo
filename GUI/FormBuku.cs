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
    public partial class FormBuku : Form
    {
        private SqlCommand cmd;
        private DataSet ds;
        private SqlDataAdapter da;

        Kelas.Koneksi konn = new Kelas.Koneksi();

        void bersih()
        {
            textBox_kodebuku.Text = "";
            textBox_namabuku.Text = "";
            textBox_harga.Text = "0";
            textBox_stok.Text = "0";
            textBox_cari.Text = "";
        }

        void atur_tombol(Boolean status)
        {
            button_ubah.Enabled = status;
            button_hapus.Enabled = status;
        }

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
                    cmd = new SqlCommand("select * from tabel_barang where KodeBuku like '%"+textBox_cari.Text+"%' or NamaBuku like '%"+textBox_cari.Text+"%'", conn);
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
        void auto_number()
        {
            long hitung;
            string urut;
            SqlDataReader rd;
            SqlConnection conn = konn.GetConn();
            conn.Open();
            cmd = new SqlCommand("select KodeBuku from tabel_barang where KodeBuku in (select max (KodeBuku) from tabel_barang) order by KodeBuku desc", conn);
            rd = cmd.ExecuteReader();
            rd.Read();
            if (rd.HasRows)
            {
                hitung = Convert.ToInt64(rd[0].ToString().Substring(rd["KodeBuku"].ToString().Length - 3, 3)) + 1;
                string joinstr = "000" + hitung;
                urut = "N" + joinstr.Substring(joinstr.Length - 3, 3);
            }
            else
            {
                urut = "N001";
            }
            rd.Close();
            textBox_kodebuku.Enabled = false;
            textBox_kodebuku.Text = urut;
            conn.Close();

        }

        public FormBuku()
        {
            InitializeComponent();
            bersih();
            atur_tombol(false);

            refresh_barang();
            auto_number();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            cari_barang();
        }

        private void button_simpan_Click(object sender, EventArgs e)
        {
            if (textBox_kodebuku.Text.Trim() == "" || textBox_namabuku.Text.Trim() == "" || textBox_stok.Text.Trim() == "" || textBox_harga.Text.Trim() == "")
            {
                MessageBox.Show("Data Belum Lengkap ! Mohon Lengkapi data", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                SqlConnection conn = konn.GetConn();
                try
                {
                    cmd = new SqlCommand("insert into tabel_barang values ('" +textBox_kodebuku.Text+ "','" +textBox_namabuku.Text+ "','"+textBox_harga.Text+"','"+textBox_stok.Text+"')", conn);

                    conn.Open();
                    cmd.ExecuteNonQuery();


                    MessageBox.Show("Data Berhasil Disimpan!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information );

                    refresh_barang();
                    bersih();
                    atur_tombol(false);
                    auto_number();
                }
                catch (Exception x)
                {
                    MessageBox.Show(x.ToString());
                }
            }
        }

        private void dataGridView_buku_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                button_simpan.Enabled = false;
                atur_tombol(true);

                DataGridViewRow row = this.dataGridView_buku.Rows[e.RowIndex];
                textBox_kodebuku.Text = row.Cells["KodeBuku"].Value.ToString();
                textBox_namabuku.Text = row.Cells["NamaBuku"].Value.ToString();
                textBox_harga.Text = row.Cells["Harga"].Value.ToString();
                textBox_stok.Text = row.Cells["Stok"].Value.ToString();
                
            }
            catch (Exception x)
            {
                MessageBox.Show(x.ToString());
            }
        }

        private void button_ubah_Click(object sender, EventArgs e)
        {
            if (textBox_kodebuku.Text.Trim() == "" || textBox_namabuku.Text.Trim() == "" || textBox_stok.Text.Trim() == "" || textBox_harga.Text.Trim() == "")
            {
                MessageBox.Show("Data Belum Lengkap ! Mohon Lengkapi data", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                SqlConnection conn = konn.GetConn();
                try
                {
                    cmd = new SqlCommand("update tabel_barang set NamaBuku = '"+textBox_namabuku.Text+"', Harga = '"+textBox_harga.Text+"', Stok = '"+textBox_stok.Text+"' where KodeBuku = '"+textBox_kodebuku.Text+"'", conn);

                    conn.Open();
                    cmd.ExecuteNonQuery();


                    MessageBox.Show("Data Berhasil Diubah!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    refresh_barang();
                    bersih();
                    atur_tombol(false);
                    auto_number();
                    button_simpan.Enabled = true;
                }
                catch (Exception x)
                {
                    MessageBox.Show(x.ToString());
                }
            }
        }

        private void button_hapus_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Lanjutkan Menghapus Data "+textBox_namabuku.Text+ "?","Konfirmasi",MessageBoxButtons.YesNo,MessageBoxIcon.Question)== DialogResult.Yes)
            {
                SqlConnection conn = konn.GetConn();
                {
                    cmd = new SqlCommand("delete from tabel_barang where KodeBuku = '"+textBox_kodebuku.Text+"'", conn);

                    conn.Open();
                    cmd.ExecuteNonQuery();


                    MessageBox.Show("Data Berhasil Dihapus!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    refresh_barang();
                    bersih();
                    atur_tombol(false);
                    auto_number();
                    button_simpan.Enabled = true;
                }
            }
        }

        private void button_baru_Click(object sender, EventArgs e)
        {
            bersih();
            atur_tombol(false);
            button_simpan.Enabled = true;
            auto_number();
        }
    }
}
