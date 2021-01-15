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
    public partial class veresiyeSatis : Form
    {
        GurMarContext db = new GurMarContext();
        public veresiyeSatis()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void temizle_Click(object sender, EventArgs e)
        {
            musteriTC.Clear();
            musteriName.Clear();
            musteriPhoneNumber.Clear();
            
            barkodNo.Clear();
            productname.Clear();
            unit.Clear();
            price.Clear();
            totalPrice.Clear();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void satis_Click(object sender, EventArgs e)
        {

            if (musteriTC.Text != "" && musteriPhoneNumber.Text != "" && tarih.Value.ToString() != "" && musteriName.Text != "" && barkodNo.Text != "" && productname.Text != "" && unit.Text != ""&& price.Text != "" && totalPrice.Text != "")
            {
                Musteri musteri = new Musteri();
                Kasa borc = new Kasa();
                //Stok stok = new Stok();


                var tc = musteriTC.Text;
                var control = db.Musteris.Where(s => s.MusteriTc == tc).FirstOrDefault();
                if (control == null)
                {
                    musteri.MusteriTc = musteriTC.Text;
                    musteri.MusteriAdSoyad = musteriName.Text;
                    musteri.MusteriTel = Convert.ToInt32(musteriPhoneNumber.Text);
                    musteri.TarihSaat = tarih.Value.ToString();
                    musteri.BorcMiktari = ((Convert.ToInt32(unit.Text)) * (Convert.ToInt32(price.Text))); 

                    db.Musteris.Add(musteri);
                   
                    db.SaveChanges();
                }
                else
                {
                    control.BorcMiktari=control.BorcMiktari+ ((Convert.ToInt32(unit.Text)) * (Convert.ToInt32(price.Text)));
                    db.SaveChanges();
                }

            

                VeresiyeSatis veresiye = new VeresiyeSatis();
                veresiye.MusteriAdSoyad = musteriName.Text;
                veresiye.MusteriTel = Convert.ToInt32(musteriPhoneNumber.Text);
                veresiye.TarihSaat = tarih.Value.ToString();
                veresiye.Toplam = (Convert.ToInt32(unit.Text)) * (Convert.ToInt32(price.Text));
                veresiye.BarkodNo = Convert.ToInt32(barkodNo.Text);
                veresiye.BirimAdet = Convert.ToInt32(unit.Text);
                veresiye.Fiyat = Convert.ToInt32(price.Text);
                veresiye.UrunAdi = productname.Text;

                int potansiyel_veresiye_kar = veresiye.Toplam;
                borc.ToplamAlacakMiktari = borc.ToplamAlacakMiktari + veresiye.Toplam;

                /* veresiye.Toplam = (Convert.ToInt32(unit.Text)) * (Convert.ToInt32(price.Text));
                veresiye.BarkodNo = Convert.ToInt32(barkodNo.Text);
                veresiye.Fiyat = Convert.ToInt32(price.Text);
                veresiye.UrunAdi = productname.Text;


                stok.BirimAdedi = stok.BirimAdedi - Convert.ToInt32(unit.Text); */



                db.VeresiyeSatiss.Add(veresiye);
                db.SaveChanges();
                
            }
            else
            {
                MessageBox.Show("Boşlukları Doldurunuz !!!!");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void güncelle_Click(object sender, EventArgs e)
        {
            veresiyeSatis veresiyeSatis = new veresiyeSatis();
            this.Hide();
            veresiyeSatis.ShowDialog();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void veresiyeSatis_Load(object sender, EventArgs e)
        {   
            // TODO: Bu kod satırı 'gurMarketDBDataSet.VeresiyeSatis' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.veresiyeSatisTableAdapter.Fill(this.gurMarketDBDataSet.VeresiyeSatis);
           
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
