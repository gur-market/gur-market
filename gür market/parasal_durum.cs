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
    public partial class parasal_durum : Form
    {
        public parasal_durum()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void parasal_durum_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'gurMarketDBDataSet3.Kasas' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.kasasTableAdapter.Fill(this.gurMarketDBDataSet3.Kasas);

        }
    }
}
