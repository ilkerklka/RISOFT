namespace YoneticiGosterimPaneli
{
    partial class sifre_ekranı
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(sifre_ekranı));
            this.lbl_kullanici = new System.Windows.Forms.Label();
            this.lbl_sifre = new System.Windows.Forms.Label();
            this.txt_kullanici = new System.Windows.Forms.TextBox();
            this.txt_sifre = new System.Windows.Forms.TextBox();
            this.chc_goster = new System.Windows.Forms.CheckBox();
            this.btn_giris = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_kullanici
            // 
            this.lbl_kullanici.AutoSize = true;
            this.lbl_kullanici.Location = new System.Drawing.Point(97, 33);
            this.lbl_kullanici.Name = "lbl_kullanici";
            this.lbl_kullanici.Size = new System.Drawing.Size(70, 13);
            this.lbl_kullanici.TabIndex = 0;
            this.lbl_kullanici.Text = "Kullanıcı Adı :";
            // 
            // lbl_sifre
            // 
            this.lbl_sifre.AutoSize = true;
            this.lbl_sifre.Location = new System.Drawing.Point(97, 104);
            this.lbl_sifre.Name = "lbl_sifre";
            this.lbl_sifre.Size = new System.Drawing.Size(34, 13);
            this.lbl_sifre.TabIndex = 0;
            this.lbl_sifre.Text = "Şifre :";
            // 
            // txt_kullanici
            // 
            this.txt_kullanici.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_kullanici.Location = new System.Drawing.Point(100, 50);
            this.txt_kullanici.Name = "txt_kullanici";
            this.txt_kullanici.Size = new System.Drawing.Size(100, 20);
            this.txt_kullanici.TabIndex = 0;
            // 
            // txt_sifre
            // 
            this.txt_sifre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_sifre.Location = new System.Drawing.Point(100, 131);
            this.txt_sifre.Name = "txt_sifre";
            this.txt_sifre.Size = new System.Drawing.Size(100, 20);
            this.txt_sifre.TabIndex = 1;
            this.txt_sifre.UseSystemPasswordChar = true;
            // 
            // chc_goster
            // 
            this.chc_goster.AutoSize = true;
            this.chc_goster.Location = new System.Drawing.Point(206, 133);
            this.chc_goster.Name = "chc_goster";
            this.chc_goster.Size = new System.Drawing.Size(15, 14);
            this.chc_goster.TabIndex = 3;
            this.chc_goster.UseVisualStyleBackColor = true;
            this.chc_goster.CheckedChanged += new System.EventHandler(this.chc_goster_CheckedChanged);
            // 
            // btn_giris
            // 
            this.btn_giris.Location = new System.Drawing.Point(100, 178);
            this.btn_giris.Name = "btn_giris";
            this.btn_giris.Size = new System.Drawing.Size(75, 23);
            this.btn_giris.TabIndex = 2;
            this.btn_giris.Text = "giriş yap";
            this.btn_giris.UseVisualStyleBackColor = true;
            this.btn_giris.Click += new System.EventHandler(this.btn_giris_Click);
            // 
            // sifre_ekranı
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(318, 217);
            this.Controls.Add(this.btn_giris);
            this.Controls.Add(this.chc_goster);
            this.Controls.Add(this.txt_sifre);
            this.Controls.Add(this.txt_kullanici);
            this.Controls.Add(this.lbl_sifre);
            this.Controls.Add(this.lbl_kullanici);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "sifre_ekranı";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " RİSOFT Yönetici Gösterim Paneli";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_kullanici;
        private System.Windows.Forms.Label lbl_sifre;
        private System.Windows.Forms.TextBox txt_kullanici;
        private System.Windows.Forms.TextBox txt_sifre;
        private System.Windows.Forms.CheckBox chc_goster;
        private System.Windows.Forms.Button btn_giris;
    }
}