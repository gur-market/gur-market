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
    public partial class musteri_borc_guncelleme : Form
    {
        GurMarContext db = new GurMarContext();
        public musteri_borc_guncelleme()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void temizle_Click(object sender, EventArgs e)
        {
            textBox5.Clear();
        }

        private void güncelle_Click(object sender, EventArgs e)
        {

          //  if ()
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void musteri_borc_guncelleme_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'gurMarketDBDataSet1.Musteris' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.musterisTableAdapter.Fill(this.gurMarketDBDataSet1.Musteris);

        }
    }
}

