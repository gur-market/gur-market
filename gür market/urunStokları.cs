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
    public partial class urunStokları : Form
    {
        public urunStokları()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void urunStokları_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'gurMarketDBDataSet6.Stoks' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.stoksTableAdapter.Fill(this.gurMarketDBDataSet6.Stoks);

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void arama_Click(object sender, EventArgs e)
        {
        
        }
    }
}
