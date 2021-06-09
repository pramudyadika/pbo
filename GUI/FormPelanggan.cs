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
    public partial class FormPelanggan : Form
    {
        private SqlCommand cmd;
        private DataSet ds;
        private SqlDataAdapter da;

        Kelas.Koneksi konn = new Kelas.Koneksi();

        void bersih()
        {
            textBox_idpelanggan.Text = "";
            textBox_namapelanggan.Text = "";
            textBox_alamat.Text = "";
            textBox_nohp.Text = "";
            textBox_namapelanggan.Focus();
        }

        void atur_tombol(Boolean status)
        {
            button_ubah.Enabled = status;
            button_hapus.Enabled = status;
        }

        void refresh_pelanggan()
        {
            SqlConnection conn = konn.GetConn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from tabel_pelanggan", conn);
                    ds = new DataSet();
                    da = new SqlDataAdapter(cmd);
                    da.Fill(ds, "tabel_pelanggan");
                    dataGridView_pelanggan.DataSource = ds;
                    dataGridView_pelanggan.DataMember = "tabel_pelanggan";
                    dataGridView_pelanggan.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    dataGridView_pelanggan.AllowUserToAddRows = false;
                    dataGridView_pelanggan.Refresh();
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

        void cari_pelanggan()
        {
            SqlConnection conn = konn.GetConn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from tabel_pelanggan where IdPelanggan like '%" + textBox_cari.Text + "%' or NamaPelanggan like '%" + textBox_cari.Text + "%'", conn);
                    ds = new DataSet();
                    da = new SqlDataAdapter(cmd);
                    da.Fill(ds, "tabel_pelanggan");
                    dataGridView_pelanggan.DataSource = ds;
                    dataGridView_pelanggan.DataMember = "tabel_pelanggan";
                    dataGridView_pelanggan.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    dataGridView_pelanggan.AllowUserToAddRows = false;
                    dataGridView_pelanggan.Refresh();
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
            cmd = new SqlCommand("select IdPelanggan from tabel_pelanggan where IdPelanggan in(select max (IdPelanggan) from tabel_pelanggan) order by IdPelanggan desc", conn);
            rd = cmd.ExecuteReader();
            rd.Read();
            if (rd.HasRows)
            {
                hitung = Convert.ToInt64(rd[0].ToString().Substring(rd["IdPelanggan"].ToString().Length - 3, 3)) + 1;
                string joinstr = "000" + hitung;
                urut = "C" + joinstr.Substring(joinstr.Length - 3, 3);
            }
            else
            {
                urut = "C001";
            }
            rd.Close();
            textBox_idpelanggan.Enabled = false;
            textBox_idpelanggan.Text = urut;
            conn.Close();
        }

        public FormPelanggan()
        {
            InitializeComponent();
            bersih();
            atur_tombol(false);
            refresh_pelanggan();
            auto_number();
        }

        private void textBox_cari_TextChanged(object sender, EventArgs e)
        {
            cari_pelanggan();
        }

        private void button_simpan_Click(object sender, EventArgs e)
        {
            if (textBox_idpelanggan.Text.Trim() == "" || textBox_namapelanggan.Text.Trim() == "" || textBox_alamat.Text.Trim() == "" || textBox_nohp.Text.Trim() == "")
            {
                MessageBox.Show("Data Belum Lengkap ! Mohon Lengkapi data", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                SqlConnection conn = konn.GetConn();
                try
                {
                    cmd = new SqlCommand("insert into tabel_pelanggan values ('" + textBox_idpelanggan.Text + "','" + textBox_namapelanggan.Text + "','" + textBox_alamat.Text + "','" + textBox_nohp.Text + "')", conn);

                    conn.Open();
                    cmd.ExecuteNonQuery();


                    MessageBox.Show("Data Berhasil Disimpan!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    refresh_pelanggan();
                    bersih();
                    auto_number();
                    atur_tombol(false);
                }
                catch (Exception x)
                {
                    MessageBox.Show(x.ToString());
                }
            }
        }

        private void dataGridView_pelanggan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                button_simpan.Enabled = false;
                atur_tombol(true);

                DataGridViewRow row = this.dataGridView_pelanggan.Rows[e.RowIndex];
                textBox_idpelanggan.Text = row.Cells["IdPelanggan"].Value.ToString();
                textBox_namapelanggan.Text = row.Cells["NamaPelanggan"].Value.ToString();
                textBox_alamat.Text = row.Cells["Alamat"].Value.ToString();
                textBox_nohp.Text = row.Cells["NoHp"].Value.ToString();

            }
            catch (Exception x)
            {
                MessageBox.Show(x.ToString());
            }
        }

        private void button_ubah_Click(object sender, EventArgs e)
        {
            if (textBox_idpelanggan.Text.Trim() == "" || textBox_namapelanggan.Text.Trim() == "" || textBox_alamat.Text.Trim() == "" || textBox_nohp.Text.Trim() == "")
            {
                MessageBox.Show("Data Belum Lengkap ! Mohon Lengkapi data", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                SqlConnection conn = konn.GetConn();
                try
                {
                    cmd = new SqlCommand("update tabel_pelanggan set NamaPelanggan = '" + textBox_namapelanggan.Text + "', Alamat = '" + textBox_alamat.Text + "', NoHp = '" + textBox_nohp.Text + "' where IdPelanggan = '" + textBox_idpelanggan.Text + "'", conn);

                    conn.Open();
                    cmd.ExecuteNonQuery();


                    MessageBox.Show("Data Berhasil Diubah!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    refresh_pelanggan();
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
            if (MessageBox.Show("Lanjutkan Menghapus Data " + textBox_namapelanggan.Text + "?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                SqlConnection conn = konn.GetConn();
                {
                    cmd = new SqlCommand("delete from tabel_pelanggan where IdPelanggan = '" + textBox_idpelanggan.Text + "'", conn);

                    conn.Open();
                    cmd.ExecuteNonQuery();


                    MessageBox.Show("Data Berhasil Dihapus!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    refresh_pelanggan();
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
        }

        private void textBox_namapelanggan_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
