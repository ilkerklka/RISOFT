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

namespace YoneticiGosterimPaneli
{
    public partial class urunbilgi : Form
    {
        SqlConnection urun;
        SqlCommand uruncom;
        SqlDataAdapter urundata;
        public urunbilgi()
        {
            InitializeComponent();
        }

        void stokgetir()
        {
            urun = new SqlConnection("server =.;Initial Catalog=RISOFT; Integrated Security=SSPI;");
            urun.Open();
            urundata = new SqlDataAdapter("SELECT * from urunler" , urun);
            DataTable tablo=new DataTable();
            urundata.Fill(tablo);
            dataGridView1.DataSource = tablo;
            urun.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void urunbilgi_Load(object sender, EventArgs e)
        {
            stokgetir();
        }

        private void txt_stok_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar >= 47 && (int)e.KeyChar <= 58)
            {
                e.Handled = false;
            }
            else if ((int)e.KeyChar ==8)
            {
                e.Handled = false;
            }
            else
            {
                MessageBox.Show("Lütfen geçerli bir değer girin", "RİSOFT", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Handled =true;
            }
        }

        private void txt_fiyat_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar >= 47 && (int)e.KeyChar<=58)
            {
                e.Handled =false;
            }
            else if ((int)e.KeyChar ==8)
            {
                e.Handled=false;
            }
            else
            {
                MessageBox.Show("Lütfen geçerli bir değer giriniz", "RİSOFT", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Handled = true;
            }
                
        }

        private void txt_urunAdi_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_ekle_Click(object sender, EventArgs e)
        {
            string sorgu = "INSERT INTO urunler(urunAdi,stokAdet,fiyat) VALUES(@urunAdi,@stokAdet,@fiyat)";
            uruncom = new SqlCommand(sorgu, urun);
            uruncom.Parameters.AddWithValue("@urunAdi", txt_urunAdi.Text);
            uruncom.Parameters.AddWithValue("@stokAdet", txt_stok.Text);
            uruncom.Parameters.AddWithValue("@fiyat",txt_fiyat.Text);
            urun.Open();
            uruncom.ExecuteNonQuery();
            urun.Close();
            stokgetir();
        }

        private void btn_guncelle_Click(object sender, EventArgs e)
        {
            string sorgu = "UPTADE urunler SET urunAdi=@urunAdi , stokAdet=@stokAdet, fiyat=@fiyat WHERE urunID=@urunID";
            uruncom = new SqlCommand(sorgu, urun);
            uruncom.Parameters.AddWithValue("@urunID", Convert.ToInt32(txt_urunID.Text));
            uruncom.Parameters.AddWithValue("@urunAdi", txt_urunAdi.Text);
            uruncom.Parameters.AddWithValue("@stokAdet", txt_stok.Text);
            uruncom.Parameters.AddWithValue("@fiyat", txt_fiyat.Text);
            urun.Open();
            uruncom.ExecuteNonQuery();
            urun.Close();
            stokgetir();
        }

        private void btn_sil_Click(object sender, EventArgs e)
        {
            DialogResult sonuc;
            sonuc = MessageBox.Show("Silmek istediğinize emin misiniz ?", "RİSOFT", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (sonuc==DialogResult.Yes)
            {
                string sorgu = "DELETE FROM urunler WHERE urunID=@urunID";
                uruncom=new SqlCommand(sorgu, urun);
                uruncom.Parameters.AddWithValue("@urunID", Convert.ToInt32(txt_urunID.Text));
                urun.Open();
                uruncom.ExecuteNonQuery();
                urun.Close();
                stokgetir();
                MessageBox.Show("Kayıt silme işlemi başarılı", "RİSOFT", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Kayıt silme işlemi başarısız", "RİSOFT", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            txt_urunID.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txt_urunAdi.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txt_stok.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txt_fiyat.Text= dataGridView1.CurrentRow.Cells[3].Value.ToString();
        }
    }
}
