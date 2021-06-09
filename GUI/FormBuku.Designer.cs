
namespace Apl_Penjualan.GUI
{
    partial class FormBuku
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
            this.groupBox_form = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_stok = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_harga = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_namabuku = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_kodebuku = new System.Windows.Forms.TextBox();
            this.groupBox_proses = new System.Windows.Forms.GroupBox();
            this.button_hapus = new System.Windows.Forms.Button();
            this.button_ubah = new System.Windows.Forms.Button();
            this.button_simpan = new System.Windows.Forms.Button();
            this.button_baru = new System.Windows.Forms.Button();
            this.groupBox_data = new System.Windows.Forms.GroupBox();
            this.dataGridView_buku = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_cari = new System.Windows.Forms.TextBox();
            this.groupBox_form.SuspendLayout();
            this.groupBox_proses.SuspendLayout();
            this.groupBox_data.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_buku)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox_form
            // 
            this.groupBox_form.Controls.Add(this.label4);
            this.groupBox_form.Controls.Add(this.textBox_stok);
            this.groupBox_form.Controls.Add(this.label3);
            this.groupBox_form.Controls.Add(this.textBox_harga);
            this.groupBox_form.Controls.Add(this.label2);
            this.groupBox_form.Controls.Add(this.textBox_namabuku);
            this.groupBox_form.Controls.Add(this.label1);
            this.groupBox_form.Controls.Add(this.textBox_kodebuku);
            this.groupBox_form.Location = new System.Drawing.Point(12, 12);
            this.groupBox_form.Name = "groupBox_form";
            this.groupBox_form.Size = new System.Drawing.Size(396, 348);
            this.groupBox_form.TabIndex = 0;
            this.groupBox_form.TabStop = false;
            this.groupBox_form.Text = "::Form Buku::";
            this.groupBox_form.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(15, 253);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 28);
            this.label4.TabIndex = 9;
            this.label4.Text = "Stok";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // textBox_stok
            // 
            this.textBox_stok.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_stok.Location = new System.Drawing.Point(174, 250);
            this.textBox_stok.Name = "textBox_stok";
            this.textBox_stok.Size = new System.Drawing.Size(206, 34);
            this.textBox_stok.TabIndex = 8;
            this.textBox_stok.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(15, 189);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 28);
            this.label3.TabIndex = 7;
            this.label3.Text = "Harga Buku";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // textBox_harga
            // 
            this.textBox_harga.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_harga.Location = new System.Drawing.Point(174, 186);
            this.textBox_harga.Name = "textBox_harga";
            this.textBox_harga.Size = new System.Drawing.Size(206, 34);
            this.textBox_harga.TabIndex = 6;
            this.textBox_harga.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 28);
            this.label2.TabIndex = 5;
            this.label2.Text = "Nama Buku";
            // 
            // textBox_namabuku
            // 
            this.textBox_namabuku.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_namabuku.Location = new System.Drawing.Point(174, 121);
            this.textBox_namabuku.Name = "textBox_namabuku";
            this.textBox_namabuku.Size = new System.Drawing.Size(206, 34);
            this.textBox_namabuku.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 28);
            this.label1.TabIndex = 3;
            this.label1.Text = "Kode Buku";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBox_kodebuku
            // 
            this.textBox_kodebuku.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_kodebuku.Location = new System.Drawing.Point(174, 53);
            this.textBox_kodebuku.Name = "textBox_kodebuku";
            this.textBox_kodebuku.Size = new System.Drawing.Size(206, 34);
            this.textBox_kodebuku.TabIndex = 2;
            // 
            // groupBox_proses
            // 
            this.groupBox_proses.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox_proses.Controls.Add(this.button_hapus);
            this.groupBox_proses.Controls.Add(this.button_ubah);
            this.groupBox_proses.Controls.Add(this.button_simpan);
            this.groupBox_proses.Controls.Add(this.button_baru);
            this.groupBox_proses.Location = new System.Drawing.Point(12, 366);
            this.groupBox_proses.Name = "groupBox_proses";
            this.groupBox_proses.Size = new System.Drawing.Size(396, 191);
            this.groupBox_proses.TabIndex = 1;
            this.groupBox_proses.TabStop = false;
            this.groupBox_proses.Text = "::Proses::";
            // 
            // button_hapus
            // 
            this.button_hapus.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_hapus.Image = global::Apl_Penjualan.Properties.Resources.trash__1_;
            this.button_hapus.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_hapus.Location = new System.Drawing.Point(194, 113);
            this.button_hapus.Name = "button_hapus";
            this.button_hapus.Size = new System.Drawing.Size(186, 45);
            this.button_hapus.TabIndex = 3;
            this.button_hapus.Text = "&Hapus";
            this.button_hapus.UseVisualStyleBackColor = true;
            this.button_hapus.Click += new System.EventHandler(this.button_hapus_Click);
            // 
            // button_ubah
            // 
            this.button_ubah.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_ubah.Image = global::Apl_Penjualan.Properties.Resources.edit__1_;
            this.button_ubah.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_ubah.Location = new System.Drawing.Point(20, 113);
            this.button_ubah.Name = "button_ubah";
            this.button_ubah.Size = new System.Drawing.Size(168, 45);
            this.button_ubah.TabIndex = 2;
            this.button_ubah.Text = "&Ubah";
            this.button_ubah.UseVisualStyleBackColor = true;
            this.button_ubah.Click += new System.EventHandler(this.button_ubah_Click);
            // 
            // button_simpan
            // 
            this.button_simpan.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_simpan.Image = global::Apl_Penjualan.Properties.Resources.diskette__1_;
            this.button_simpan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_simpan.Location = new System.Drawing.Point(194, 52);
            this.button_simpan.Name = "button_simpan";
            this.button_simpan.Size = new System.Drawing.Size(186, 45);
            this.button_simpan.TabIndex = 1;
            this.button_simpan.Text = "&Simpan";
            this.button_simpan.UseVisualStyleBackColor = true;
            this.button_simpan.Click += new System.EventHandler(this.button_simpan_Click);
            // 
            // button_baru
            // 
            this.button_baru.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_baru.Image = global::Apl_Penjualan.Properties.Resources.add_file__1_;
            this.button_baru.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_baru.Location = new System.Drawing.Point(20, 52);
            this.button_baru.Name = "button_baru";
            this.button_baru.Size = new System.Drawing.Size(168, 45);
            this.button_baru.TabIndex = 0;
            this.button_baru.Text = "&Baru";
            this.button_baru.UseVisualStyleBackColor = true;
            this.button_baru.Click += new System.EventHandler(this.button_baru_Click);
            // 
            // groupBox_data
            // 
            this.groupBox_data.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox_data.Controls.Add(this.dataGridView_buku);
            this.groupBox_data.Controls.Add(this.label5);
            this.groupBox_data.Controls.Add(this.textBox_cari);
            this.groupBox_data.Location = new System.Drawing.Point(427, 12);
            this.groupBox_data.Name = "groupBox_data";
            this.groupBox_data.Size = new System.Drawing.Size(473, 545);
            this.groupBox_data.TabIndex = 2;
            this.groupBox_data.TabStop = false;
            this.groupBox_data.Text = "::Data Buku::";
            this.groupBox_data.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // dataGridView_buku
            // 
            this.dataGridView_buku.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView_buku.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_buku.Location = new System.Drawing.Point(14, 121);
            this.dataGridView_buku.Name = "dataGridView_buku";
            this.dataGridView_buku.RowHeadersWidth = 62;
            this.dataGridView_buku.RowTemplate.Height = 28;
            this.dataGridView_buku.Size = new System.Drawing.Size(443, 413);
            this.dataGridView_buku.TabIndex = 6;
            this.dataGridView_buku.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_buku_CellClick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(9, 56);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(217, 28);
            this.label5.TabIndex = 5;
            this.label5.Text = "Cari Buku (Kode/Nama)";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // textBox_cari
            // 
            this.textBox_cari.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_cari.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_cari.Location = new System.Drawing.Point(251, 53);
            this.textBox_cari.Name = "textBox_cari";
            this.textBox_cari.Size = new System.Drawing.Size(206, 34);
            this.textBox_cari.TabIndex = 4;
            this.textBox_cari.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // FormBuku
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(912, 572);
            this.Controls.Add(this.groupBox_data);
            this.Controls.Add(this.groupBox_proses);
            this.Controls.Add(this.groupBox_form);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormBuku";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormBuku";
            this.groupBox_form.ResumeLayout(false);
            this.groupBox_form.PerformLayout();
            this.groupBox_proses.ResumeLayout(false);
            this.groupBox_data.ResumeLayout(false);
            this.groupBox_data.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_buku)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox_form;
        private System.Windows.Forms.GroupBox groupBox_proses;
        private System.Windows.Forms.GroupBox groupBox_data;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_harga;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_namabuku;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_kodebuku;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_stok;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_cari;
        private System.Windows.Forms.Button button_hapus;
        private System.Windows.Forms.Button button_ubah;
        private System.Windows.Forms.Button button_simpan;
        private System.Windows.Forms.Button button_baru;
        private System.Windows.Forms.DataGridView dataGridView_buku;
    }
}