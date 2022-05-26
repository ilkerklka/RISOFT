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
    public partial class RISOFT : Form
    {
        public RISOFT()
        {
            InitializeComponent();
        }

        private void btn_satis_Click(object sender, EventArgs e)
        {
            satisbilgi satisbilgi = new satisbilgi();
            satisbilgi.ShowDialog();
        }

        private void btn_urunler_Click(object sender, EventArgs e)
        {
            urunbilgi urunbilgi = new urunbilgi(); 
            urunbilgi.ShowDialog();
        }

        private void btn_calisan_Click(object sender, EventArgs e)
        {
            clsnblgi clsnblgi = new clsnblgi();
            clsnblgi.ShowDialog();
        }

        private void btn_musteri_Click(object sender, EventArgs e)
        {
            musteribilgi musteribilgi = new musteribilgi();
            musteribilgi.ShowDialog();
        }

        private void RISOFT_Load(object sender, EventArgs e)
        {

        }

        private void RISOFT_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }
    }
}
