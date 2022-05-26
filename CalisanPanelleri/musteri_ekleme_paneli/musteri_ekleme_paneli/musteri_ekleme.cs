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

namespace musteri_ekleme_paneli
{
    public partial class musteri_ekleme : Form
    {

        SqlConnection musteri;
        SqlCommand musteriCommand;
        SqlDataAdapter musteriAdapter;


        void musterigetir()
        {
            musteri = new SqlConnection("server=.;Initial Catalog=RISOFT;Integrated Security = SSPI;");
            musteri.Open();
            musteriAdapter = new SqlDataAdapter("select * from musteriler ", musteri);
            DataTable dt = new DataTable();
            musteriAdapter.Fill(dt);
            dataGridView1.DataSource = dt;
            musteri.Close();

        }

        public musteri_ekleme()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void musteri_ekleme_Load(object sender, EventArgs e)
        {
            musterigetir();
        }

        private void btn_ekle_Click(object sender, EventArgs e)
        {
            string sorgu = "insert into musteriler(musteriAdi,musteriSoyadi,cinsiyet,adres,telNo,mail)values(@musteriAdi,@musteriSoyadi,@cinsiyet,@adres,@telNo,@mail)";
            musteriCommand = new SqlCommand(sorgu,musteri);
            musteriCommand.Parameters.AddWithValue("@musteriAdi", txt_isim.Text);
            musteriCommand.Parameters.AddWithValue("@musteriSoyadi", txt_soyisim.Text);
            musteriCommand.Parameters.AddWithValue("@adres",txt_adrees.Text);
            musteriCommand.Parameters.AddWithValue("@telNo",mtxt_telno.Text);
            musteriCommand.Parameters.AddWithValue("@mail",txt_mail.Text);
            string cinsiyet = "";
            if (rdr_erkek.Checked)
            {
                cinsiyet=rdr_erkek.Text;
            }
            else
            {
                cinsiyet = radioButton2.Text;
            }
            musteriCommand.Parameters.AddWithValue("@cinsiyet",cinsiyet);
            musteri.Open();
            musteriCommand.ExecuteNonQuery();
            musteri.Close();
            musterigetir();
        }
    }
}
