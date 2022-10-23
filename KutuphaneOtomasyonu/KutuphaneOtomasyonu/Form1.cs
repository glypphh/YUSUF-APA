﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KutuphaneOtomasyonu
{
    public partial class Duzenleme : Form
    {
        AnaEkran anaEkran;
        public Duzenleme(AnaEkran parametredenGelenAnaEkran)
        {
                InitializeComponent();
                anaEkran = parametredenGelenAnaEkran;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            anaEkran.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            anaEkran.kitapEkle(textBox2.Text);
            anaEkran.Show();
            this.Close();
        }
    }
}
