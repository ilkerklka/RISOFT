namespace YoneticiGosterimPaneli
{
    partial class clsnblgi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(clsnblgi));
            this.lbl_ID = new System.Windows.Forms.Label();
            this.lbl_ad = new System.Windows.Forms.Label();
            this.lbl_soyad = new System.Windows.Forms.Label();
            this.lbl_cinsiyet = new System.Windows.Forms.Label();
            this.lbl_dgmtarihi = new System.Windows.Forms.Label();
            this.lbl_tcno = new System.Windows.Forms.Label();
            this.lbl_telno = new System.Windows.Forms.Label();
            this.lbl_maas = new System.Windows.Forms.Label();
            this.lbl_gorev = new System.Windows.Forms.Label();
            this.txt_ID = new System.Windows.Forms.TextBox();
            this.txt_isim = new System.Windows.Forms.TextBox();
            this.txt_soyisim = new System.Windows.Forms.TextBox();
            this.txt_tcno = new System.Windows.Forms.TextBox();
            this.txt_maas = new System.Windows.Forms.TextBox();
            this.txt_gorev = new System.Windows.Forms.TextBox();
            this.mtxt_dgmtarihi = new System.Windows.Forms.MaskedTextBox();
            this.mtxt_telno = new System.Windows.Forms.MaskedTextBox();
            this.btn_ekle = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.rdrbtn_erkek = new System.Windows.Forms.RadioButton();
            this.rdrbtn_kadn = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_guncelle = new System.Windows.Forms.Button();
            this.btn_sil = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_ID
            // 
            this.lbl_ID.AutoSize = true;
            this.lbl_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_ID.Location = new System.Drawing.Point(59, 16);
            this.lbl_ID.Name = "lbl_ID";
            this.lbl_ID.Size = new System.Drawing.Size(74, 16);
            this.lbl_ID.TabIndex = 0;
            this.lbl_ID.Text = "Çalışan ID :";
            // 
            // lbl_ad
            // 
            this.lbl_ad.AutoSize = true;
            this.lbl_ad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_ad.Location = new System.Drawing.Point(59, 51);
            this.lbl_ad.Name = "lbl_ad";
            this.lbl_ad.Size = new System.Drawing.Size(37, 16);
            this.lbl_ad.TabIndex = 0;
            this.lbl_ad.Text = "İsim :";
            // 
            // lbl_soyad
            // 
            this.lbl_soyad.AutoSize = true;
            this.lbl_soyad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_soyad.Location = new System.Drawing.Point(59, 89);
            this.lbl_soyad.Name = "lbl_soyad";
            this.lbl_soyad.Size = new System.Drawing.Size(61, 16);
            this.lbl_soyad.TabIndex = 0;
            this.lbl_soyad.Text = "Soyisim :";
            // 
            // lbl_cinsiyet
            // 
            this.lbl_cinsiyet.AutoSize = true;
            this.lbl_cinsiyet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_cinsiyet.Location = new System.Drawing.Point(410, 149);
            this.lbl_cinsiyet.Name = "lbl_cinsiyet";
            this.lbl_cinsiyet.Size = new System.Drawing.Size(60, 16);
            this.lbl_cinsiyet.TabIndex = 0;
            this.lbl_cinsiyet.Text = "Cinsiyet :";
            // 
            // lbl_dgmtarihi
            // 
            this.lbl_dgmtarihi.AutoSize = true;
            this.lbl_dgmtarihi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_dgmtarihi.Location = new System.Drawing.Point(405, 55);
            this.lbl_dgmtarihi.Name = "lbl_dgmtarihi";
            this.lbl_dgmtarihi.Size = new System.Drawing.Size(94, 16);
            this.lbl_dgmtarihi.TabIndex = 0;
            this.lbl_dgmtarihi.Text = "Doğum Tarihi :";
            this.lbl_dgmtarihi.Click += new System.EventHandler(this.lbl_dgmtarihi_Click);
            // 
            // lbl_tcno
            // 
            this.lbl_tcno.AutoSize = true;
            this.lbl_tcno.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_tcno.Location = new System.Drawing.Point(59, 124);
            this.lbl_tcno.Name = "lbl_tcno";
            this.lbl_tcno.Size = new System.Drawing.Size(92, 16);
            this.lbl_tcno.TabIndex = 0;
            this.lbl_tcno.Text = "TC Numarası :";
            // 
            // lbl_telno
            // 
            this.lbl_telno.AutoSize = true;
            this.lbl_telno.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_telno.Location = new System.Drawing.Point(405, 93);
            this.lbl_telno.Name = "lbl_telno";
            this.lbl_telno.Size = new System.Drawing.Size(120, 16);
            this.lbl_telno.TabIndex = 0;
            this.lbl_telno.Text = "Telefon Numarası :";
            // 
            // lbl_maas
            // 
            this.lbl_maas.AutoSize = true;
            this.lbl_maas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_maas.Location = new System.Drawing.Point(59, 161);
            this.lbl_maas.Name = "lbl_maas";
            this.lbl_maas.Size = new System.Drawing.Size(47, 16);
            this.lbl_maas.TabIndex = 0;
            this.lbl_maas.Text = "Maaş :";
            // 
            // lbl_gorev
            // 
            this.lbl_gorev.AutoSize = true;
            this.lbl_gorev.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_gorev.Location = new System.Drawing.Point(59, 196);
            this.lbl_gorev.Name = "lbl_gorev";
            this.lbl_gorev.Size = new System.Drawing.Size(95, 16);
            this.lbl_gorev.TabIndex = 0;
            this.lbl_gorev.Text = "Çalışma Alanı :";
            // 
            // txt_ID
            // 
            this.txt_ID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_ID.Enabled = false;
            this.txt_ID.Location = new System.Drawing.Point(170, 12);
            this.txt_ID.Name = "txt_ID";
            this.txt_ID.Size = new System.Drawing.Size(108, 20);
            this.txt_ID.TabIndex = 0;
            // 
            // txt_isim
            // 
            this.txt_isim.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_isim.Location = new System.Drawing.Point(170, 51);
            this.txt_isim.Name = "txt_isim";
            this.txt_isim.Size = new System.Drawing.Size(108, 20);
            this.txt_isim.TabIndex = 1;
            // 
            // txt_soyisim
            // 
            this.txt_soyisim.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_soyisim.Location = new System.Drawing.Point(170, 85);
            this.txt_soyisim.Name = "txt_soyisim";
            this.txt_soyisim.Size = new System.Drawing.Size(108, 20);
            this.txt_soyisim.TabIndex = 2;
            // 
            // txt_tcno
            // 
            this.txt_tcno.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_tcno.Location = new System.Drawing.Point(170, 121);
            this.txt_tcno.MaxLength = 11;
            this.txt_tcno.Name = "txt_tcno";
            this.txt_tcno.Size = new System.Drawing.Size(108, 20);
            this.txt_tcno.TabIndex = 3;
            this.txt_tcno.TextChanged += new System.EventHandler(this.txt_tcno_TextChanged);
            this.txt_tcno.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_tcno_KeyPress);
            // 
            // txt_maas
            // 
            this.txt_maas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_maas.Location = new System.Drawing.Point(170, 157);
            this.txt_maas.Name = "txt_maas";
            this.txt_maas.Size = new System.Drawing.Size(108, 20);
            this.txt_maas.TabIndex = 4;
            this.txt_maas.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_maas_KeyPress);
            // 
            // txt_gorev
            // 
            this.txt_gorev.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_gorev.Location = new System.Drawing.Point(170, 192);
            this.txt_gorev.Name = "txt_gorev";
            this.txt_gorev.Size = new System.Drawing.Size(108, 20);
            this.txt_gorev.TabIndex = 5;
            // 
            // mtxt_dgmtarihi
            // 
            this.mtxt_dgmtarihi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mtxt_dgmtarihi.Location = new System.Drawing.Point(536, 51);
            this.mtxt_dgmtarihi.Mask = "00/00/0000";
            this.mtxt_dgmtarihi.Name = "mtxt_dgmtarihi";
            this.mtxt_dgmtarihi.Size = new System.Drawing.Size(100, 20);
            this.mtxt_dgmtarihi.TabIndex = 6;
            this.mtxt_dgmtarihi.ValidatingType = typeof(System.DateTime);
            this.mtxt_dgmtarihi.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.mtxt_dgmtarihi_MaskInputRejected);
            this.mtxt_dgmtarihi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mtxt_dgmtarihi_KeyPress);
            // 
            // mtxt_telno
            // 
            this.mtxt_telno.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mtxt_telno.Location = new System.Drawing.Point(536, 89);
            this.mtxt_telno.Mask = "(999) 000-0000";
            this.mtxt_telno.Name = "mtxt_telno";
            this.mtxt_telno.Size = new System.Drawing.Size(100, 20);
            this.mtxt_telno.TabIndex = 7;
            this.mtxt_telno.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mtxt_telno_KeyPress);
            // 
            // btn_ekle
            // 
            this.btn_ekle.Location = new System.Drawing.Point(709, 48);
            this.btn_ekle.Name = "btn_ekle";
            this.btn_ekle.Size = new System.Drawing.Size(74, 33);
            this.btn_ekle.TabIndex = 11;
            this.btn_ekle.Text = "EKLE";
            this.btn_ekle.UseVisualStyleBackColor = true;
            this.btn_ekle.Click += new System.EventHandler(this.btn_ekle_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 231);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(820, 280);
            this.dataGridView1.TabIndex = 20;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEnter);
            // 
            // rdrbtn_erkek
            // 
            this.rdrbtn_erkek.AutoSize = true;
            this.rdrbtn_erkek.Location = new System.Drawing.Point(487, 137);
            this.rdrbtn_erkek.Name = "rdrbtn_erkek";
            this.rdrbtn_erkek.Size = new System.Drawing.Size(53, 17);
            this.rdrbtn_erkek.TabIndex = 9;
            this.rdrbtn_erkek.TabStop = true;
            this.rdrbtn_erkek.Text = "Erkek";
            this.rdrbtn_erkek.UseVisualStyleBackColor = true;
            // 
            // rdrbtn_kadn
            // 
            this.rdrbtn_kadn.AutoSize = true;
            this.rdrbtn_kadn.Location = new System.Drawing.Point(487, 157);
            this.rdrbtn_kadn.Name = "rdrbtn_kadn";
            this.rdrbtn_kadn.Size = new System.Drawing.Size(52, 17);
            this.rdrbtn_kadn.TabIndex = 10;
            this.rdrbtn_kadn.TabStop = true;
            this.rdrbtn_kadn.Text = "Kadın";
            this.rdrbtn_kadn.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(533, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "* (ay/gün/yıl) şeklinde yaznız";
            // 
            // btn_guncelle
            // 
            this.btn_guncelle.Location = new System.Drawing.Point(709, 93);
            this.btn_guncelle.Name = "btn_guncelle";
            this.btn_guncelle.Size = new System.Drawing.Size(74, 30);
            this.btn_guncelle.TabIndex = 22;
            this.btn_guncelle.Text = "GÜNCELLE";
            this.btn_guncelle.UseVisualStyleBackColor = true;
            this.btn_guncelle.Click += new System.EventHandler(this.btn_guncelle_Click);
            // 
            // btn_sil
            // 
            this.btn_sil.Location = new System.Drawing.Point(709, 135);
            this.btn_sil.Name = "btn_sil";
            this.btn_sil.Size = new System.Drawing.Size(74, 30);
            this.btn_sil.TabIndex = 23;
            this.btn_sil.Text = "SİL";
            this.btn_sil.UseVisualStyleBackColor = true;
            this.btn_sil.Click += new System.EventHandler(this.btn_sil_Click);
            // 
            // clsnblgi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(844, 523);
            this.Controls.Add(this.btn_sil);
            this.Controls.Add(this.btn_guncelle);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rdrbtn_kadn);
            this.Controls.Add(this.rdrbtn_erkek);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_ekle);
            this.Controls.Add(this.mtxt_telno);
            this.Controls.Add(this.mtxt_dgmtarihi);
            this.Controls.Add(this.txt_gorev);
            this.Controls.Add(this.txt_maas);
            this.Controls.Add(this.txt_tcno);
            this.Controls.Add(this.txt_soyisim);
            this.Controls.Add(this.txt_isim);
            this.Controls.Add(this.txt_ID);
            this.Controls.Add(this.lbl_gorev);
            this.Controls.Add(this.lbl_maas);
            this.Controls.Add(this.lbl_telno);
            this.Controls.Add(this.lbl_tcno);
            this.Controls.Add(this.lbl_dgmtarihi);
            this.Controls.Add(this.lbl_cinsiyet);
            this.Controls.Add(this.lbl_soyad);
            this.Controls.Add(this.lbl_ad);
            this.Controls.Add(this.lbl_ID);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "clsnblgi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RİSOFT Çalışan Bilgi Sistemi";
            this.Load += new System.EventHandler(this.clsnblgi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_ID;
        private System.Windows.Forms.Label lbl_ad;
        private System.Windows.Forms.Label lbl_soyad;
        private System.Windows.Forms.Label lbl_cinsiyet;
        private System.Windows.Forms.Label lbl_dgmtarihi;
        private System.Windows.Forms.Label lbl_tcno;
        private System.Windows.Forms.Label lbl_telno;
        private System.Windows.Forms.Label lbl_maas;
        private System.Windows.Forms.Label lbl_gorev;
        private System.Windows.Forms.TextBox txt_ID;
        private System.Windows.Forms.TextBox txt_isim;
        private System.Windows.Forms.TextBox txt_soyisim;
        private System.Windows.Forms.TextBox txt_tcno;
        private System.Windows.Forms.TextBox txt_maas;
        private System.Windows.Forms.TextBox txt_gorev;
        private System.Windows.Forms.MaskedTextBox mtxt_dgmtarihi;
        private System.Windows.Forms.MaskedTextBox mtxt_telno;
        private System.Windows.Forms.Button btn_ekle;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.RadioButton rdrbtn_erkek;
        private System.Windows.Forms.RadioButton rdrbtn_kadn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_guncelle;
        private System.Windows.Forms.Button btn_sil;
    }
}