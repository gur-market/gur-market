using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gür_market
{
    public partial class ana_sayfa : Form
    {
        public ana_sayfa()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            sifre_değisimi yonetici_ekleme = new sifre_değisimi();
            yonetici_ekleme.ShowDialog();
        }

        private void stok_Click(object sender, EventArgs e)
        {
            urunStokları urunStokları = new urunStokları();
            urunStokları.ShowDialog();
        }

        private void satis_Click(object sender, EventArgs e)
        {
            satis satis = new satis();
            satis.ShowDialog();
        }

        private void urunler_Click(object sender, EventArgs e)
        {
            urunAlis urunAlis = new urunAlis();
            urunAlis.ShowDialog();
        }

        private void müsteri_Click(object sender, EventArgs e)
        {
            alacak_verecek alacak_verecek = new alacak_verecek();
            alacak_verecek.ShowDialog();
        }

        private void kasa_Click(object sender, EventArgs e)
        {
            parasal_durum parasal_durum = new parasal_durum();
            parasal_durum.ShowDialog();
        }

        private void ana_sayfa_Load(object sender, EventArgs e)
        {

        }
    }
}
