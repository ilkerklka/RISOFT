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
    public partial class clsnblgi : Form
    {
        SqlConnection clsn;
        SqlCommand clsncom;
        SqlDataAdapter clsndata;

        void calısangetir()
        {
            clsn = new SqlConnection("server =.;Initial Catalog = RISOFT;Integrated Security =SSPI;");
            clsn.Open();
            clsndata = new SqlDataAdapter("SELECT * FROM isciler",clsn);
            DataTable tablo=new DataTable();
            clsndata.Fill(tablo);
            dataGridView1.DataSource = tablo;
            clsn.Close();
        }
        public clsnblgi()
        {
            InitializeComponent();
        }

        private void mtxt_dgmtarihi_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void lbl_dgmtarihi_Click(object sender, EventArgs e)
        {

        }

        private void clsnblgi_Load(object sender, EventArgs e)
        {
            calısangetir();
        }

        
        private void btn_ekle_Click(object sender, EventArgs e)
        {
            string sorgu = "insert into isciler(isciAdi,isciSoyadi,cinsiyet,dogumTarihi,TCnumarasi,telNo,maas,gorev) values(@isciAdi,@isciSoyadi,@cinsiyet,@dogumTarihi,@TCnumarasi,@telNo,@maas,@gorev)";
            clsncom = new SqlCommand(sorgu, clsn);
            clsncom.Parameters.AddWithValue("@isciAdi", txt_isim.Text);
            clsncom.Parameters.AddWithValue("@isciSoyadi", txt_soyisim.Text);
            clsncom.Parameters.AddWithValue("@dogumTarihi",mtxt_dgmtarihi.Text);
            clsncom.Parameters.AddWithValue("@TCnumarasi",txt_tcno.Text);   
            clsncom.Parameters.AddWithValue("@telNo",mtxt_telno.Text);
            clsncom.Parameters.AddWithValue("@maas",txt_maas.Text);
            clsncom.Parameters.AddWithValue("@gorev",txt_gorev.Text);
            string cinsiyet = "";
            if (rdrbtn_erkek.Checked)
            {
                cinsiyet = rdrbtn_erkek.Text;
            }
            else
            {
                cinsiyet = rdrbtn_kadn.Text;
            }
            clsncom.Parameters.AddWithValue("@cinsiyet",cinsiyet);
            clsn.Open();
            
            clsncom.ExecuteNonQuery();
            clsn.Close();
            calısangetir();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
         
        }

        private void btn_guncelle_Click(object sender, EventArgs e)
        {
            string sorgu = "update isciler set isciAdi=@isciAdi , isciSoyadi=@isciSoyadi , cinsiyet=@cinsiyet , dogumTarihi=@dogumTarihi , TCnumarasi=@TCnumarasi , telNo=@telNo , maas=@maas , gorev=@gorev where isciID=@isciID";
            clsncom = new SqlCommand(sorgu, clsn);
            clsncom.Parameters.AddWithValue("@isciID", Convert.ToInt32(txt_ID.Text));
            clsncom.Parameters.AddWithValue("@isciAdi", txt_isim.Text);
            clsncom.Parameters.AddWithValue("@isciSoyadi", txt_soyisim.Text);
            clsncom.Parameters.AddWithValue("@dogumTarihi",mtxt_dgmtarihi.Text);
            clsncom.Parameters.AddWithValue("@TCnumarasi",txt_tcno.Text);
            clsncom.Parameters.AddWithValue("@telNo", mtxt_telno.Text);
            clsncom.Parameters.AddWithValue("@maas", txt_maas.Text);
            clsncom.Parameters.AddWithValue("@gorev",txt_gorev.Text);
            string cins = "";

            if (rdrbtn_erkek.Checked)
            {
                cins = rdrbtn_erkek.Text;
            }
            else
            {
                cins= rdrbtn_kadn.Text;
            }

            clsncom.Parameters.AddWithValue("@cinsiyet",cins);
            clsn.Open();
            clsncom.ExecuteNonQuery();
            clsn.Close();
            calısangetir();
        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            txt_ID.Text= dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txt_isim.Text= dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txt_soyisim.Text= dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txt_tcno.Text= dataGridView1.CurrentRow.Cells[5].Value.ToString();  
            txt_maas.Text= dataGridView1.CurrentRow.Cells[8].Value.ToString();
            txt_gorev.Text= dataGridView1.CurrentRow.Cells[9].Value.ToString();
            mtxt_dgmtarihi.Text= dataGridView1.CurrentRow.Cells[4].Value.ToString();
            mtxt_telno.Text= dataGridView1.CurrentRow.Cells[6].Value.ToString();
        }

        private void btn_sil_Click(object sender, EventArgs e)
        {
            DialogResult sonuc;
            sonuc = MessageBox.Show("Silmek istediğinize emin misiniz?", "RİSOFT", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (sonuc == DialogResult.Yes)
            {
                string sorgu = "delete from isciler where isciID=@isciID";
                clsncom = new SqlCommand(sorgu, clsn);
                clsncom.Parameters.AddWithValue("@isciID",Convert.ToInt32(txt_ID.Text));
                clsn.Open();
                clsncom.ExecuteNonQuery();
                clsn.Close();
                calısangetir();
                MessageBox.Show("Silme işlemi başarılı", "RİSOFT", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Silme işlemi iptal edildi", "RİSOFT", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void txt_tcno_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_tcno_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar>= 47 && (int)e.KeyChar<=58)
            {
                e.Handled = false;
            }
            else if ((int)e.KeyChar==8)
            {
                e.Handled = false;
            }
            else
            {
                MessageBox.Show("Lütfen geçerli bir değer veriniz", "RİSOFT", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Handled = true;
            }
        }

        private void txt_maas_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar>=48&&(int)e.KeyChar<=58)
            {
                e.Handled = false;
            }
            else if ((int)e.KeyChar==8)
            {
                e.Handled = false;
            }
            else
            {
                MessageBox.Show("Lütfen geçerli bir değer veriniz","RİSOFT",MessageBoxButtons.OK,MessageBoxIcon.Error);
                e.Handled= true;
            }
        }

        private void mtxt_dgmtarihi_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar>=48&&(int)e.KeyChar<=58)
            {
                e.Handled = false;
            }
            else if ((int)e.KeyChar==8)
            {
                e.Handled = false;
            }
            else
            {
                MessageBox.Show("Lütfen geçerli bir değer veriniz","RİSOFT",MessageBoxButtons.OK,MessageBoxIcon.Error);
                e.Handled=! true;
            }
        }

        private void mtxt_telno_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar>=48 && (int)e.KeyChar<=58)
            {
                e.Handled = false;
            }
            else if ((int)e.KeyChar == 8)
            {
                e.Handled = false;
            }
            else
            {
                MessageBox.Show("Lütfen geçerli bir değer veriniz","RİSOFT",MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Handled = true;
            }
        }
    }
}
