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
    public partial class tedarikci_borc : Form
    {
        public tedarikci_borc()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void temizle_Click(object sender, EventArgs e)
        {
            textBox4.Clear();
          
        }

        private void güncelle_Click(object sender, EventArgs e)
        {
            tedarik_sifre tedarik_sifre = new tedarik_sifre();
            tedarik_sifre.ShowDialog();
        }
    }
}
