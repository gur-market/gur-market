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
    public partial class satis : Form
    {
        public satis()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pesin_Click(object sender, EventArgs e)
        {
            pesinSatis pesinSatis = new pesinSatis();
            this.Hide();
            pesinSatis.ShowDialog();
        }

        private void veresiye_Click(object sender, EventArgs e)
        {
            veresiyeSatis veresiyeSatis = new veresiyeSatis();
            this.Hide();
            veresiyeSatis.ShowDialog();
        }
    }
}
