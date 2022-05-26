using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YoneticiGosterimPaneli
{
    public partial class sifre_ekranı : Form
    {
        public sifre_ekranı()
        {
            InitializeComponent();
        }

        private void chc_goster_CheckedChanged(object sender, EventArgs e)
        {
            
            if (chc_goster.Checked)
            {
                txt_sifre.UseSystemPasswordChar = false;
            }
            else
            {
                txt_sifre.UseSystemPasswordChar= true;
            }
        }

        private void btn_giris_Click(object sender, EventArgs e)
        {
            
            if (txt_kullanici.Text == "admin" && txt_sifre.Text == "1592648" )
            {
                MessageBox.Show("Kullanıcı adı ve şifre doğru", "RİSOFT", MessageBoxButtons.OK, MessageBoxIcon.Information);
                RISOFT RISOFT= new RISOFT();
                RISOFT.ShowDialog();

            }
            else
            {
                MessageBox.Show("Şifre veya Kullanıcı adı hatalı !!!", "RİSOFT", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
