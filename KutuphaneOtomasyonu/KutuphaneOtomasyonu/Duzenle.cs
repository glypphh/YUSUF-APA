using System;
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
    public partial class Duzenle : Form
    {
        AnaEkran anaEkran;

        public Duzenle(AnaEkran parametredenGelenAnaEkran)
        {
            InitializeComponent();
            anaEkran = parametredenGelenAnaEkran;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            anaEkran.kitapEkle(Degistir.Text);
            anaEkran.Show();
            this.Close();

        }

        private void Duzenle_FormClosed(object sender, FormClosedEventArgs e)
        {
            anaEkran.Show();
        }

        private void Duzenle_Load(object sender, EventArgs e)
        {
            
        }
    }
}
