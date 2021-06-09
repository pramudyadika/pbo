using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Apl_Penjualan.GUI
{
    public partial class Menu_Utama : Form
    {

        FormBuku brg;
        FormPelanggan plgn;
        FormTransaksi trx;

        void brg_FormClosed(Object sender, FormClosedEventArgs e)
        {
            brg = null;
        }

        void plgn_FormClosed(Object sender, FormClosedEventArgs e)
        {
            plgn = null;
        }

        void trx_FormClosed(Object sender, FormClosedEventArgs e)
        {
            trx = null;

        }

        public Menu_Utama()
        {
            InitializeComponent();
        }

        private void submenu_buku_Click(object sender, EventArgs e)
        {
            if (brg == null)
            {
                brg = new FormBuku();
                brg.MdiParent = this;
                brg.FormClosed += new FormClosedEventHandler(brg_FormClosed);
                brg.Show();
            }
            else
            {
                brg.Activate();
            }
        }

        private void submenu_pelanggan_Click(object sender, EventArgs e)
        {
            if (plgn == null)
            {
                plgn = new FormPelanggan();
                plgn.MdiParent = this;
                plgn.FormClosed += new FormClosedEventHandler(brg_FormClosed);
                plgn.Show();
            }
            else
            {
                plgn.Activate();
            }
        }

        private void submenu_penjualan_Click(object sender, EventArgs e)
        {
            if (trx == null)
            {
                trx = new FormTransaksi();
                trx.MdiParent = this;
                trx.FormClosed += new FormClosedEventHandler(brg_FormClosed);
                trx.Show();
            }
            else
            {
                trx.Activate();
            }
        }

        private void laporanBarangToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Laporan.DataBarang a = new Laporan.DataBarang();
            a.Show();
        }

        private void laporanPelangganToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Laporan.DataPelanggan a = new Laporan.DataPelanggan();
            a.Show();
        }

        private void tentangToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void menu_file_Click(object sender, EventArgs e)
        {

        }

        private void toolStripStatusLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
