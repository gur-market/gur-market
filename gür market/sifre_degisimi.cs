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
    public partial class sifre_degisimi : Form
    {
        public sifre_degisimi()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void yonetici_ekleme_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void pesin_Click(object sender, EventArgs e)
        {
            giris_sayfasi giris_sayfasi = new giris_sayfasi();
            this.Hide();
            giris_sayfasi.ShowDialog();
        }
    }
}
