namespace musteri_ekleme_paneli
{
    partial class musteri_ekleme
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(musteri_ekleme));
            this.lbl_ID = new System.Windows.Forms.Label();
            this.txt_ID = new System.Windows.Forms.TextBox();
            this.lbl_ad = new System.Windows.Forms.Label();
            this.lbl_soyad = new System.Windows.Forms.Label();
            this.lbl_cinsiyet = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_telno = new System.Windows.Forms.Label();
            this.lbl_mail = new System.Windows.Forms.Label();
            this.txt_isim = new System.Windows.Forms.TextBox();
            this.txt_adrees = new System.Windows.Forms.TextBox();
            this.txt_soyisim = new System.Windows.Forms.TextBox();
            this.rdr_erkek = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.mtxt_telno = new System.Windows.Forms.MaskedTextBox();
            this.txt_mail = new System.Windows.Forms.TextBox();
            this.btn_ekle = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_ID
            // 
            this.lbl_ID.AutoSize = true;
            this.lbl_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbl_ID.Location = new System.Drawing.Point(27, 33);
            this.lbl_ID.Name = "lbl_ID";
            this.lbl_ID.Size = new System.Drawing.Size(84, 17);
            this.lbl_ID.TabIndex = 0;
            this.lbl_ID.Text = "Müsteri No :";
            this.lbl_ID.Click += new System.EventHandler(this.label1_Click);
            // 
            // txt_ID
            // 
            this.txt_ID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_ID.Enabled = false;
            this.txt_ID.Location = new System.Drawing.Point(118, 33);
            this.txt_ID.Name = "txt_ID";
            this.txt_ID.Size = new System.Drawing.Size(100, 20);
            this.txt_ID.TabIndex = 0;
            // 
            // lbl_ad
            // 
            this.lbl_ad.AutoSize = true;
            this.lbl_ad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbl_ad.Location = new System.Drawing.Point(27, 65);
            this.lbl_ad.Name = "lbl_ad";
            this.lbl_ad.Size = new System.Drawing.Size(40, 17);
            this.lbl_ad.TabIndex = 2;
            this.lbl_ad.Text = "İsim :";
            // 
            // lbl_soyad
            // 
            this.lbl_soyad.AutoSize = true;
            this.lbl_soyad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbl_soyad.Location = new System.Drawing.Point(27, 99);
            this.lbl_soyad.Name = "lbl_soyad";
            this.lbl_soyad.Size = new System.Drawing.Size(64, 17);
            this.lbl_soyad.TabIndex = 2;
            this.lbl_soyad.Text = "Soyisim :";
            // 
            // lbl_cinsiyet
            // 
            this.lbl_cinsiyet.AutoSize = true;
            this.lbl_cinsiyet.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbl_cinsiyet.Location = new System.Drawing.Point(26, 144);
            this.lbl_cinsiyet.Name = "lbl_cinsiyet";
            this.lbl_cinsiyet.Size = new System.Drawing.Size(65, 17);
            this.lbl_cinsiyet.TabIndex = 2;
            this.lbl_cinsiyet.Text = "Cinsiyet :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.Location = new System.Drawing.Point(403, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 17);
            this.label4.TabIndex = 2;
            this.label4.Text = "Adres :";
            // 
            // lbl_telno
            // 
            this.lbl_telno.AutoSize = true;
            this.lbl_telno.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbl_telno.Location = new System.Drawing.Point(403, 33);
            this.lbl_telno.Name = "lbl_telno";
            this.lbl_telno.Size = new System.Drawing.Size(128, 17);
            this.lbl_telno.TabIndex = 2;
            this.lbl_telno.Text = "Telefon Numarası :";
            // 
            // lbl_mail
            // 
            this.lbl_mail.AutoSize = true;
            this.lbl_mail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbl_mail.Location = new System.Drawing.Point(403, 81);
            this.lbl_mail.Name = "lbl_mail";
            this.lbl_mail.Size = new System.Drawing.Size(85, 17);
            this.lbl_mail.TabIndex = 2;
            this.lbl_mail.Text = "Mail Adresi :";
            // 
            // txt_isim
            // 
            this.txt_isim.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_isim.Location = new System.Drawing.Point(118, 65);
            this.txt_isim.Name = "txt_isim";
            this.txt_isim.Size = new System.Drawing.Size(100, 20);
            this.txt_isim.TabIndex = 1;
            // 
            // txt_adrees
            // 
            this.txt_adrees.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_adrees.Location = new System.Drawing.Point(462, 131);
            this.txt_adrees.MaxLength = 255;
            this.txt_adrees.Multiline = true;
            this.txt_adrees.Name = "txt_adrees";
            this.txt_adrees.Size = new System.Drawing.Size(265, 126);
            this.txt_adrees.TabIndex = 7;
            // 
            // txt_soyisim
            // 
            this.txt_soyisim.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_soyisim.Location = new System.Drawing.Point(118, 96);
            this.txt_soyisim.Name = "txt_soyisim";
            this.txt_soyisim.Size = new System.Drawing.Size(100, 20);
            this.txt_soyisim.TabIndex = 2;
            // 
            // rdr_erkek
            // 
            this.rdr_erkek.AutoSize = true;
            this.rdr_erkek.Location = new System.Drawing.Point(118, 134);
            this.rdr_erkek.Name = "rdr_erkek";
            this.rdr_erkek.Size = new System.Drawing.Size(53, 17);
            this.rdr_erkek.TabIndex = 3;
            this.rdr_erkek.TabStop = true;
            this.rdr_erkek.Text = "Erkek";
            this.rdr_erkek.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(118, 157);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(52, 17);
            this.radioButton2.TabIndex = 4;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Kadın";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(462, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "* maximum 255 karakte girebilirsiniz";
            // 
            // mtxt_telno
            // 
            this.mtxt_telno.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mtxt_telno.Location = new System.Drawing.Point(538, 33);
            this.mtxt_telno.Mask = "(999) 000-0000";
            this.mtxt_telno.Name = "mtxt_telno";
            this.mtxt_telno.Size = new System.Drawing.Size(100, 20);
            this.mtxt_telno.TabIndex = 5;
            // 
            // txt_mail
            // 
            this.txt_mail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_mail.Location = new System.Drawing.Point(538, 81);
            this.txt_mail.Name = "txt_mail";
            this.txt_mail.Size = new System.Drawing.Size(100, 20);
            this.txt_mail.TabIndex = 6;
            // 
            // btn_ekle
            // 
            this.btn_ekle.Location = new System.Drawing.Point(30, 201);
            this.btn_ekle.Name = "btn_ekle";
            this.btn_ekle.Size = new System.Drawing.Size(81, 29);
            this.btn_ekle.TabIndex = 8;
            this.btn_ekle.Text = "KAYDET";
            this.btn_ekle.UseVisualStyleBackColor = true;
            this.btn_ekle.Click += new System.EventHandler(this.btn_ekle_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 263);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(795, 275);
            this.dataGridView1.TabIndex = 9;
            // 
            // musteri_ekleme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(819, 550);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_ekle);
            this.Controls.Add(this.txt_mail);
            this.Controls.Add(this.mtxt_telno);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.rdr_erkek);
            this.Controls.Add(this.txt_adrees);
            this.Controls.Add(this.txt_soyisim);
            this.Controls.Add(this.txt_isim);
            this.Controls.Add(this.lbl_mail);
            this.Controls.Add(this.lbl_telno);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbl_cinsiyet);
            this.Controls.Add(this.lbl_soyad);
            this.Controls.Add(this.lbl_ad);
            this.Controls.Add(this.txt_ID);
            this.Controls.Add(this.lbl_ID);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "musteri_ekleme";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RİSOFT Müşteri Ekleme Paneli";
            this.Load += new System.EventHandler(this.musteri_ekleme_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_ID;
        private System.Windows.Forms.TextBox txt_ID;
        private System.Windows.Forms.Label lbl_ad;
        private System.Windows.Forms.Label lbl_soyad;
        private System.Windows.Forms.Label lbl_cinsiyet;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbl_telno;
        private System.Windows.Forms.Label lbl_mail;
        private System.Windows.Forms.TextBox txt_isim;
        private System.Windows.Forms.TextBox txt_adrees;
        private System.Windows.Forms.TextBox txt_soyisim;
        private System.Windows.Forms.RadioButton rdr_erkek;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox mtxt_telno;
        private System.Windows.Forms.TextBox txt_mail;
        private System.Windows.Forms.Button btn_ekle;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

