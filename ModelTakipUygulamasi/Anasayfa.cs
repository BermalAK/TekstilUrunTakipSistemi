using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;
using System.Data.SqlClient;

namespace ModelTakipUygulamasi
{
    public partial class Anasayfa : Form
    {
        public Anasayfa()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=laptop-tlb8q2al;Initial Catalog=TekstilTakip;Integrated Security=True");
        

        private void btnGiris_Click(object sender, EventArgs e)
        {
            
        }

        private void Anasayfa_Load(object sender, EventArgs e)
        {
          /*  Anasayfa aa = new Anasayfa();
            this.Hide();
            aa.ShowDialog();*/
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnKucult_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void modelEkle_Click(object sender, EventArgs e)
        {
            modelEkle modelEkle = new modelEkle();
            this.Hide();
            modelEkle.ShowDialog();
        }

        private void ithalatİhracatYönetimi_Click(object sender, EventArgs e)
        {
            DikimBilgileri dikim = new DikimBilgileri();
            this.Hide();
            dikim.ShowDialog();
        }

        private void muhasebeYönetimi_Click(object sender, EventArgs e)
        {
            utupaketBilgileri utupak = new utupaketBilgileri();
            this.Hide();
            utupak.ShowDialog();
        }

        private void FasonYönetimi_Click(object sender, EventArgs e)
        {
            FasonTakip fs = new FasonTakip();
            this.Hide();
            fs.ShowDialog();
        }

        private void numuneTakibi_Click(object sender, EventArgs e)
        {
            Numune num = new Numune();
            this.Hide();
            num.ShowDialog();
        }

        private void musteriİliskileriYönetimi_Click(object sender, EventArgs e)
        {
            utupaketKayit utu1 = new utupaketKayit();
            this.Hide();
            utu1.ShowDialog();
        }

        private void malzemeİhtiyacListesi_Click(object sender, EventArgs e)
        {
            malzemeEkle malzeme = new malzemeEkle();
            this.Hide();
            malzeme.ShowDialog();
        }

        private void stokYönetimi_Click(object sender, EventArgs e)
        {
            StokTakip st = new StokTakip();
            this.Hide();
            st.ShowDialog();
        }

        private void sevkiyatPlanlama_Click(object sender, EventArgs e)
        {
            DikimBilgileri dikim1 = new DikimBilgileri();
            this.Hide();
            dikim1.ShowDialog();
        }

        private void tedarikciPortalı_Click(object sender, EventArgs e)
        {
            utupaketKayit utukayit = new utupaketKayit();
            this.Hide();
            utukayit.ShowDialog();
        }

        private void urunTakibi_Click(object sender, EventArgs e)
        {
            dikimVideo dikimV = new dikimVideo();
            this.Hide();
            dikimV.ShowDialog();
        }

        private void kaliteKontrol_Click(object sender, EventArgs e)
        {
            utuVideo utuV = new utuVideo();
            this.Hide();
            utuV.ShowDialog();
        }

        private void yuvarlakButon3_Click(object sender, EventArgs e)
        {
            ParolaUnuttum pr = new ParolaUnuttum();
            this.Hide();
            pr.ShowDialog();
        }

        private void yuvarlakButon4_Click(object sender, EventArgs e)
        {
            FasonTakip fs = new FasonTakip();
            this.Hide();
            fs.ShowDialog();
        }

        private void yuvarlakButon1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
