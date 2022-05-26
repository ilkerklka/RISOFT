namespace YoneticiGosterimPaneli
{
    partial class RISOFT
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RISOFT));
            this.btn_satis = new System.Windows.Forms.Button();
            this.btn_urunler = new System.Windows.Forms.Button();
            this.btn_calisan = new System.Windows.Forms.Button();
            this.btn_musteri = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_satis
            // 
            this.btn_satis.AutoEllipsis = true;
            this.btn_satis.Location = new System.Drawing.Point(58, 121);
            this.btn_satis.Name = "btn_satis";
            this.btn_satis.Size = new System.Drawing.Size(79, 42);
            this.btn_satis.TabIndex = 0;
            this.btn_satis.Text = "Satış Bilgileri";
            this.btn_satis.UseVisualStyleBackColor = true;
            this.btn_satis.Click += new System.EventHandler(this.btn_satis_Click);
            // 
            // btn_urunler
            // 
            this.btn_urunler.Location = new System.Drawing.Point(178, 121);
            this.btn_urunler.Name = "btn_urunler";
            this.btn_urunler.Size = new System.Drawing.Size(76, 42);
            this.btn_urunler.TabIndex = 1;
            this.btn_urunler.Text = "Ürün Bilgileri";
            this.btn_urunler.UseVisualStyleBackColor = true;
            this.btn_urunler.Click += new System.EventHandler(this.btn_urunler_Click);
            // 
            // btn_calisan
            // 
            this.btn_calisan.Location = new System.Drawing.Point(297, 121);
            this.btn_calisan.Name = "btn_calisan";
            this.btn_calisan.Size = new System.Drawing.Size(76, 42);
            this.btn_calisan.TabIndex = 2;
            this.btn_calisan.Text = "Çalışan Bilgileri";
            this.btn_calisan.UseVisualStyleBackColor = true;
            this.btn_calisan.Click += new System.EventHandler(this.btn_calisan_Click);
            // 
            // btn_musteri
            // 
            this.btn_musteri.Location = new System.Drawing.Point(424, 121);
            this.btn_musteri.Name = "btn_musteri";
            this.btn_musteri.Size = new System.Drawing.Size(76, 42);
            this.btn_musteri.TabIndex = 3;
            this.btn_musteri.Text = "Müşteri Bilgileri";
            this.btn_musteri.UseVisualStyleBackColor = true;
            this.btn_musteri.Click += new System.EventHandler(this.btn_musteri_Click);
            // 
            // RISOFT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(560, 287);
            this.Controls.Add(this.btn_musteri);
            this.Controls.Add(this.btn_calisan);
            this.Controls.Add(this.btn_urunler);
            this.Controls.Add(this.btn_satis);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "RISOFT";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RİSOFT Yönetici Kontrol Paneli";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.RISOFT_FormClosed);
            this.Load += new System.EventHandler(this.RISOFT_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_satis;
        private System.Windows.Forms.Button btn_urunler;
        private System.Windows.Forms.Button btn_calisan;
        private System.Windows.Forms.Button btn_musteri;
    }
}

