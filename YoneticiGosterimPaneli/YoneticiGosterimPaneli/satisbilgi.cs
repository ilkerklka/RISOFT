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

    public partial class satisbilgi : Form
    {
        SqlConnection baglanti;
        SqlDataAdapter veri;
        public satisbilgi()
        {
            InitializeComponent();
        }

        void bilgigetir() 
        {
            baglanti = new SqlConnection("server=.; Initial Catalog=RISOFT; Integrated Security=SSPI;");
            baglanti.Open();
            veri = new SqlDataAdapter("SELECT *FROM siparisDetay", baglanti);
            DataTable tablo = new DataTable();
            veri.Fill(tablo);
            data_satis.DataSource = tablo;
            baglanti.Close();
        }

        private void satisbilgi_Load(object sender, EventArgs e)
        {
            bilgigetir();
        }
    }
}
