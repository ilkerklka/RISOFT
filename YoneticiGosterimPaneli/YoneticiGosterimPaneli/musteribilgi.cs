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
    public partial class musteribilgi : Form
    {

        SqlConnection musteri;
        SqlDataAdapter musteridata;
        public musteribilgi()
        {
            InitializeComponent();
        }

        private void musteribilgi_Load(object sender, EventArgs e)
        {
            musteri = new SqlConnection("SERVER=.; INITIAL CATALOG=RISOFT ; Integrated Security=SSPI");
            musteri.Open();
            musteridata = new SqlDataAdapter("select * from musteriler", musteri);
            DataTable tablo = new DataTable();
            musteridata.Fill(tablo);
            dataGridView1.DataSource = tablo;
            musteri.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
