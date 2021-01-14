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
    public partial class alacak_verecek : Form
    {
        public alacak_verecek()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void veresiye_Click(object sender, EventArgs e)
        {
            musteri_borc musteri_borc = new musteri_borc();
            this.Hide();
            musteri_borc.ShowDialog();
        }

        private void pesin_Click(object sender, EventArgs e)
        {
            tedarikci_borc tedarikci_borc = new tedarikci_borc();
            this.Hide();
            tedarikci_borc.ShowDialog();
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // alacak_verecek
            // 
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Name = "alacak_verecek";
            this.Load += new System.EventHandler(this.alacak_verecek_Load);
            this.ResumeLayout(false);

        }

        private void alacak_verecek_Load(object sender, EventArgs e)
        {

        }
    }
}
