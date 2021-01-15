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
    public partial class pesinSatis : Form
    {
        GurMarContext db = new GurMarContext();
        public pesinSatis()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void temizle_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
        }

        private void satis_Click(object sender, EventArgs e)
        {

        }

        private void urun_sil_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pesinSatis_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'gurMarketDBDataSet4.PesinSatis' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.pesinSatisTableAdapter.Fill(this.gurMarketDBDataSet4.PesinSatis);
            // TODO: Bu kod satırı 'gurMarketDBDataSet.VeresiyeSatis' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.veresiyeSatisTableAdapter.Fill(this.gurMarketDBDataSet.VeresiyeSatis);

        }
        int mevcutKasa;
        private void sat_Click(object sender, EventArgs e)
        {
            PesinSatis pesin = new PesinSatis();
            Kasa borc = new Kasa();

            if (textBox1.Text != "" && textBox3.Text != "")
            {


                var brkdNo = Convert.ToInt32(textBox1.Text);
                var stok = db.Stoks.Where(t => t.BarkodNo == brkdNo).FirstOrDefault();
                if (stok == null)
                {
                    MessageBox.Show("Girdiğiniz Barkod Numarası Geçersizdir");
                }
                else
                {
                    pesin.BarkodNo = Convert.ToInt32(textBox1.Text);
                    pesin.UrunAdi = stok.UrunAdi;
                    pesin.Fiyat = stok.BirimFiyat;
                    pesin.BirimAdet = Convert.ToInt32(textBox3.Text);
                    pesin.Toplam = pesin.BirimAdet * pesin.Fiyat;

                    borc.MevcutKasaMiktari = borc.MevcutKasaMiktari + pesin.Toplam;

                    stok.BirimAdedi = stok.BirimAdedi - Convert.ToInt32(textBox3.Text);
                    db.PesinSatiss.Add(pesin);
                    db.SaveChanges();

                    
                }
            }
            else
            {
                MessageBox.Show("Boşlukları Doldurunuz !!!!");
            }
        }
    }
}
