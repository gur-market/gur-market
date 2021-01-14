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

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // guvenlik_sifresi
            // 
            this.ClientSize = new System.Drawing.Size(282, 253);
            this.Name = "guvenlik_sifresi";
            this.Load += new System.EventHandler(this.guvenlik_sifresi_Load_1);
            this.ResumeLayout(false);

        }

        private void guvenlik_sifresi_Load_1(object sender, EventArgs e)
        {

        }
    }
}
