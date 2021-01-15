using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using gür_market.sınıflar;
using gür_market.Context;

namespace gür_market
{
    public partial class urunAlis : Form
    {

        GurMarContext db = new GurMarContext();
        public urunAlis()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void temizle_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
        }

        private void güncelle_Click(object sender, EventArgs e)
        {

        }

        

        private void ekleme_Click(object sender, EventArgs e)
        {
            

            if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "" && textBox5.Text != "" && textBox6.Text != "")
            {
                UrunAl urun = new UrunAl();
                Stok stok = new Stok();
                Kasa borc = new Kasa();

                var irsaliye = Convert.ToInt32(textBox3.Text);
                var urunler = db.Stoks.Where(t => t.BarkodNo == irsaliye).FirstOrDefault();
                if (urunler == null)
                {

                    stok.BarkodNo = Convert.ToInt32(textBox3.Text);
                    stok.UrunAdi = textBox4.Text;
                    stok.BirimAdedi = Convert.ToInt32(textBox5.Text);
                    stok.BirimFiyat = Convert.ToInt32(textBox6.Text) * 12/10;

                    db.Stoks.Add(stok);
                    db.SaveChanges();

                }
                else
                {
                    urunler.BirimAdedi = urunler.BirimAdedi + Convert.ToInt32(textBox5.Text);
                    db.SaveChanges();
                }

                urun.IrsaliyeNo = Convert.ToInt32(textBox1.Text);
                urun.TedarikciAdi = textBox2.Text;
                urun.BarkodNo = Convert.ToInt32(textBox3.Text);
                urun.UrunAdi = textBox4.Text;
                urun.BirimAdedi = Convert.ToInt32(textBox5.Text);
                urun.BirimFiyat = Convert.ToInt32(textBox6.Text);

                int potansiyel_zarar = urun.BirimFiyat * urun.BirimAdedi;
                borc.ToplamBorc = borc.ToplamBorc + potansiyel_zarar;

                db.UrunAls.Add(urun);
                db.SaveChanges();


            }
            else
            {
                MessageBox.Show("Boşlukları Doldurunuz !!!!");
            }
            
        }
        private void urunAlis_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'gurMarketDBDataSet2.UrunAls' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.urunAlsTableAdapter.Fill(this.gurMarketDBDataSet2.UrunAls);

        }
    }
}

