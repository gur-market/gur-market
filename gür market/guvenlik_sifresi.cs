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
    public partial class guvenlik_sifresi : Form
    {
        public guvenlik_sifresi()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            musteri_borc_guncelleme musteri_borc_guncelleme = new musteri_borc_guncelleme();
            this.Hide();
            musteri_borc_guncelleme.ShowDialog();
        }

        private void guvenlik_sifresi_Load(object sender, EventArgs e)
        {

        }
    }
}
