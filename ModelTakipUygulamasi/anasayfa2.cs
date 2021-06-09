using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ModelTakipUygulamasi
{
    public partial class anasayfa2 : Form
    {
        public anasayfa2()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            modelEkle model = new modelEkle();
            model.ShowDialog();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            ormeDokuma dokuma = new ormeDokuma();
            dokuma.ShowDialog();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            DikimBilgileri dk = new DikimBilgileri();
            dk.ShowDialog();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            utupaketKayit utukayit = new utupaketKayit();
            utukayit.ShowDialog();
        }

        private void label15_Click(object sender, EventArgs e)
        {
            utupaketBilgileri utuBilgi = new utupaketBilgileri();
            utuBilgi.ShowDialog();
        }

        private void label17_Click(object sender, EventArgs e)
        {
            malzemeEkle malzeme1 = new malzemeEkle();
            malzeme1.ShowDialog();
        }

        private void label13_Click(object sender, EventArgs e)
        {
            Numuneİslemleri num = new Numuneİslemleri();
            num.ShowDialog();
        }

        private void label11_Click(object sender, EventArgs e)
        {
            FasonTakip fs = new FasonTakip();
            fs.ShowDialog();
        }

        private void label9_Click(object sender, EventArgs e)
        {
            StokTakip st = new StokTakip();
            st.ShowDialog();
        }
    }
}
