﻿using System;
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
    public partial class giris_sayfasi : Form
    {
        public giris_sayfasi()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void giris_sayfasi_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            txtparola.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.CheckState == CheckState.Checked)
            {
                txtparola.UseSystemPasswordChar = true;
            }
            else if (checkBox1.CheckState == CheckState.Unchecked)
            {
                txtparola.UseSystemPasswordChar = false;
            }
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            ana_sayfa ana_sayfa = new ana_sayfa();
            this.Hide();
            ana_sayfa.Show();
        }

        private void txtparola_TextChanged(object sender, EventArgs e)
        {

        }

        private void sifremi_unuttum_Click(object sender, EventArgs e)
        {
           sifre_değisimi sifre_değisimi = new sifre_değisimi();
            this.Hide();
            sifre_değisimi.ShowDialog();
        }
    }
}
