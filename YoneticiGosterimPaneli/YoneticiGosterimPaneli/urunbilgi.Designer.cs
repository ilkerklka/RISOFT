namespace YoneticiGosterimPaneli
{
    partial class urunbilgi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(urunbilgi));
            this.lbl_ID = new System.Windows.Forms.Label();
            this.lbl_urun = new System.Windows.Forms.Label();
            this.lbl_stok = new System.Windows.Forms.Label();
            this.lbl_fiyat = new System.Windows.Forms.Label();
            this.txt_stok = new System.Windows.Forms.TextBox();
            this.txt_urunAdi = new System.Windows.Forms.TextBox();
            this.txt_urunID = new System.Windows.Forms.TextBox();
            this.txt_fiyat = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_ekle = new System.Windows.Forms.Button();
            this.btn_guncelle = new System.Windows.Forms.Button();
            this.btn_sil = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_ID
            // 
            this.lbl_ID.AutoSize = true;
            this.lbl_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_ID.Location = new System.Drawing.Point(46, 45);
            this.lbl_ID.Name = "lbl_ID";
            this.lbl_ID.Size = new System.Drawing.Size(57, 16);
            this.lbl_ID.TabIndex = 0;
            this.lbl_ID.Text = "Ürün ID :";
            // 
            // lbl_urun
            // 
            this.lbl_urun.AutoSize = true;
            this.lbl_urun.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_urun.Location = new System.Drawing.Point(46, 83);
            this.lbl_urun.Name = "lbl_urun";
            this.lbl_urun.Size = new System.Drawing.Size(64, 16);
            this.lbl_urun.TabIndex = 0;
            this.lbl_urun.Text = "Ürün Adı :";
            // 
            // lbl_stok
            // 
            this.lbl_stok.AutoSize = true;
            this.lbl_stok.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_stok.Location = new System.Drawing.Point(46, 122);
            this.lbl_stok.Name = "lbl_stok";
            this.lbl_stok.Size = new System.Drawing.Size(132, 16);
            this.lbl_stok.TabIndex = 0;
            this.lbl_stok.Text = "Stoktaki Ürün Sayısı :";
            // 
            // lbl_fiyat
            // 
            this.lbl_fiyat.AutoSize = true;
            this.lbl_fiyat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_fiyat.Location = new System.Drawing.Point(46, 161);
            this.lbl_fiyat.Name = "lbl_fiyat";
            this.lbl_fiyat.Size = new System.Drawing.Size(42, 16);
            this.lbl_fiyat.TabIndex = 0;
            this.lbl_fiyat.Text = "Fiyat :";
            // 
            // txt_stok
            // 
            this.txt_stok.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_stok.Location = new System.Drawing.Point(185, 122);
            this.txt_stok.Name = "txt_stok";
            this.txt_stok.Size = new System.Drawing.Size(130, 20);
            this.txt_stok.TabIndex = 2;
            this.txt_stok.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_stok_KeyPress);
            // 
            // txt_urunAdi
            // 
            this.txt_urunAdi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_urunAdi.Location = new System.Drawing.Point(185, 83);
            this.txt_urunAdi.Name = "txt_urunAdi";
            this.txt_urunAdi.Size = new System.Drawing.Size(130, 20);
            this.txt_urunAdi.TabIndex = 1;
            this.txt_urunAdi.TextChanged += new System.EventHandler(this.txt_urunAdi_TextChanged);
            // 
            // txt_urunID
            // 
            this.txt_urunID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_urunID.Enabled = false;
            this.txt_urunID.Location = new System.Drawing.Point(185, 41);
            this.txt_urunID.Name = "txt_urunID";
            this.txt_urunID.Size = new System.Drawing.Size(130, 20);
            this.txt_urunID.TabIndex = 0;
            // 
            // txt_fiyat
            // 
            this.txt_fiyat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_fiyat.Location = new System.Drawing.Point(185, 157);
            this.txt_fiyat.Name = "txt_fiyat";
            this.txt_fiyat.Size = new System.Drawing.Size(130, 20);
            this.txt_fiyat.TabIndex = 3;
            this.txt_fiyat.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_fiyat_KeyPress);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 210);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(751, 228);
            this.dataGridView1.TabIndex = 11;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEnter);
            // 
            // btn_ekle
            // 
            this.btn_ekle.Location = new System.Drawing.Point(587, 25);
            this.btn_ekle.Name = "btn_ekle";
            this.btn_ekle.Size = new System.Drawing.Size(80, 36);
            this.btn_ekle.TabIndex = 4;
            this.btn_ekle.Text = "EKLE";
            this.btn_ekle.UseVisualStyleBackColor = true;
            this.btn_ekle.Click += new System.EventHandler(this.btn_ekle_Click);
            // 
            // btn_guncelle
            // 
            this.btn_guncelle.Location = new System.Drawing.Point(587, 83);
            this.btn_guncelle.Name = "btn_guncelle";
            this.btn_guncelle.Size = new System.Drawing.Size(80, 36);
            this.btn_guncelle.TabIndex = 5;
            this.btn_guncelle.Text = "GÜNCELLE";
            this.btn_guncelle.UseVisualStyleBackColor = true;
            this.btn_guncelle.Click += new System.EventHandler(this.btn_guncelle_Click);
            // 
            // btn_sil
            // 
            this.btn_sil.Location = new System.Drawing.Point(587, 141);
            this.btn_sil.Name = "btn_sil";
            this.btn_sil.Size = new System.Drawing.Size(80, 36);
            this.btn_sil.TabIndex = 6;
            this.btn_sil.Text = "SİL";
            this.btn_sil.UseVisualStyleBackColor = true;
            this.btn_sil.Click += new System.EventHandler(this.btn_sil_Click);
            // 
            // urunbilgi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(775, 450);
            this.Controls.Add(this.btn_sil);
            this.Controls.Add(this.btn_guncelle);
            this.Controls.Add(this.btn_ekle);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txt_urunID);
            this.Controls.Add(this.txt_urunAdi);
            this.Controls.Add(this.txt_fiyat);
            this.Controls.Add(this.txt_stok);
            this.Controls.Add(this.lbl_fiyat);
            this.Controls.Add(this.lbl_stok);
            this.Controls.Add(this.lbl_urun);
            this.Controls.Add(this.lbl_ID);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "urunbilgi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RİSOFT Ürün Bilgi Sistemi";
            this.Load += new System.EventHandler(this.urunbilgi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_ID;
        private System.Windows.Forms.Label lbl_urun;
        private System.Windows.Forms.Label lbl_stok;
        private System.Windows.Forms.Label lbl_fiyat;
        private System.Windows.Forms.TextBox txt_stok;
        private System.Windows.Forms.TextBox txt_urunAdi;
        private System.Windows.Forms.TextBox txt_urunID;
        private System.Windows.Forms.TextBox txt_fiyat;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_ekle;
        private System.Windows.Forms.Button btn_guncelle;
        private System.Windows.Forms.Button btn_sil;
    }
}