
namespace Apl_Penjualan.GUI
{
    partial class Menu_Utama
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu_Utama));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.menu_master = new System.Windows.Forms.ToolStripMenuItem();
            this.submenu_buku = new System.Windows.Forms.ToolStripMenuItem();
            this.submenu_pelanggan = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_transaksi = new System.Windows.Forms.ToolStripMenuItem();
            this.submenu_penjualan = new System.Windows.Forms.ToolStripMenuItem();
            this.laporanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.laporanBarangToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.laporanPelangganToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_file = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.submenu_keluar = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_master,
            this.menu_transaksi,
            this.laporanToolStripMenuItem,
            this.menu_file});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(948, 33);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "MenuStrip";
            // 
            // menu_master
            // 
            this.menu_master.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.submenu_buku,
            this.submenu_pelanggan});
            this.menu_master.Name = "menu_master";
            this.menu_master.Size = new System.Drawing.Size(124, 29);
            this.menu_master.Text = "&Master Data";
            // 
            // submenu_buku
            // 
            this.submenu_buku.Name = "submenu_buku";
            this.submenu_buku.Size = new System.Drawing.Size(196, 34);
            this.submenu_buku.Text = "&Buku";
            this.submenu_buku.Click += new System.EventHandler(this.submenu_buku_Click);
            // 
            // submenu_pelanggan
            // 
            this.submenu_pelanggan.Name = "submenu_pelanggan";
            this.submenu_pelanggan.Size = new System.Drawing.Size(196, 34);
            this.submenu_pelanggan.Text = "&Pelanggan";
            this.submenu_pelanggan.Click += new System.EventHandler(this.submenu_pelanggan_Click);
            // 
            // menu_transaksi
            // 
            this.menu_transaksi.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.submenu_penjualan});
            this.menu_transaksi.Name = "menu_transaksi";
            this.menu_transaksi.Size = new System.Drawing.Size(98, 29);
            this.menu_transaksi.Text = "&Transaksi";
            // 
            // submenu_penjualan
            // 
            this.submenu_penjualan.Name = "submenu_penjualan";
            this.submenu_penjualan.Size = new System.Drawing.Size(188, 34);
            this.submenu_penjualan.Text = "&Penjualan";
            this.submenu_penjualan.Click += new System.EventHandler(this.submenu_penjualan_Click);
            // 
            // laporanToolStripMenuItem
            // 
            this.laporanToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.laporanBarangToolStripMenuItem,
            this.laporanPelangganToolStripMenuItem});
            this.laporanToolStripMenuItem.Name = "laporanToolStripMenuItem";
            this.laporanToolStripMenuItem.Size = new System.Drawing.Size(92, 29);
            this.laporanToolStripMenuItem.Text = "Laporan";
            // 
            // laporanBarangToolStripMenuItem
            // 
            this.laporanBarangToolStripMenuItem.Name = "laporanBarangToolStripMenuItem";
            this.laporanBarangToolStripMenuItem.Size = new System.Drawing.Size(265, 34);
            this.laporanBarangToolStripMenuItem.Text = "Laporan Barang";
            this.laporanBarangToolStripMenuItem.Click += new System.EventHandler(this.laporanBarangToolStripMenuItem_Click);
            // 
            // laporanPelangganToolStripMenuItem
            // 
            this.laporanPelangganToolStripMenuItem.Name = "laporanPelangganToolStripMenuItem";
            this.laporanPelangganToolStripMenuItem.Size = new System.Drawing.Size(265, 34);
            this.laporanPelangganToolStripMenuItem.Text = "Laporan Pelanggan";
            this.laporanPelangganToolStripMenuItem.Click += new System.EventHandler(this.laporanPelangganToolStripMenuItem_Click);
            // 
            // menu_file
            // 
            this.menu_file.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.submenu_keluar});
            this.menu_file.Name = "menu_file";
            this.menu_file.Size = new System.Drawing.Size(90, 29);
            this.menu_file.Text = "&Log out";
            this.menu_file.Click += new System.EventHandler(this.menu_file_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(290, 6);
            // 
            // submenu_keluar
            // 
            this.submenu_keluar.Name = "submenu_keluar";
            this.submenu_keluar.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.submenu_keluar.Size = new System.Drawing.Size(293, 34);
            this.submenu_keluar.Text = "&Keluar Aplikasi";
            // 
            // statusStrip
            // 
            this.statusStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 665);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Padding = new System.Windows.Forms.Padding(2, 0, 21, 0);
            this.statusStrip.Size = new System.Drawing.Size(948, 32);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "StatusStrip";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(295, 25);
            this.toolStripStatusLabel.Text = "Pramudya KH 20/460558/TK/51147";
            this.toolStripStatusLabel.Click += new System.EventHandler(this.toolStripStatusLabel_Click);
            // 
            // Menu_Utama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(948, 697);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Menu_Utama";
            this.Text = "BookFellas";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion


        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.ToolTip toolTip;
        public System.Windows.Forms.ToolStripMenuItem menu_file;
        public System.Windows.Forms.ToolStripMenuItem menu_master;
        public System.Windows.Forms.ToolStripMenuItem menu_transaksi;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        public System.Windows.Forms.ToolStripMenuItem submenu_keluar;
        public System.Windows.Forms.ToolStripMenuItem submenu_buku;
        public System.Windows.Forms.ToolStripMenuItem submenu_pelanggan;
        public System.Windows.Forms.ToolStripMenuItem submenu_penjualan;
        private System.Windows.Forms.ToolStripMenuItem laporanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem laporanBarangToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem laporanPelangganToolStripMenuItem;
    }
}



