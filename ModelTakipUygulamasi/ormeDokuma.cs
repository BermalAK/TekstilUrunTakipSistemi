using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ModelTakipUygulamasi
{
    public partial class ormeDokuma : Form
    {
        public ormeDokuma()
        {
            InitializeComponent();
        }
        SqlConnection baglan = new SqlConnection(@"Data Source=LAPTOP-TLB8Q2AL;Initial Catalog=TekstilTakipOtomasyonu;Integrated Security=True");
        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            pictureBox1.ImageLocation = openFileDialog1.FileName;
        }

        private void btnDokumaBilgileri_Kaydet_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("INSERT INTO Dokuma_Bilgileri (dokumaAdi,Adresi,telNo,Muhasebe,calisanKisi,ortMaas,resim1) VALUES " +
                         "(@dokumaAdi,@Adresi,@telNo,@Muhasebe,@calisanKisi,@ortMaas,@resim1)", baglan);

            /*SqlParameter imageParameter = new SqlParameter("@resim", SqlDbType.Image);
            imageParameter.Value = DBNull.Value;
            cmd.Parameters.Add(imageParameter);*/

            cmd.Parameters.AddWithValue("@resim1", pictureBox1.Text);
            cmd.Parameters.AddWithValue("@dokumaAdi", txtAdi.Text);
            cmd.Parameters.AddWithValue("@Adresi", txtAdres.Text);
            cmd.Parameters.AddWithValue("@telNo", txtTel.Text);
            cmd.Parameters.AddWithValue("@Muhasebe", txtMuhasebe.Text);
            cmd.Parameters.AddWithValue("@calisanKisi", txtKisi.Text);
            cmd.Parameters.AddWithValue("@ortMaas", txtMaas.Text);


            baglan.Open();
            cmd.ExecuteNonQuery();
            baglan.Close();
            MessageBox.Show("Veri başarıyla kaydedildi...");
        }
        public void listele()
        {
            SqlCommand komut = new SqlCommand();
            komut.CommandText = "SELECT *FROM Model_Ekle";
            komut.Connection = baglan;
            komut.CommandType = CommandType.Text;

            SqlDataReader dr;
            baglan.Open();
            dr = komut.ExecuteReader();
            while (dr.Read())
            {
                modelNo.Items.Add(dr["modelNo"]);
            }
            baglan.Close();
        }
        private void btnDokumaModel_Kayit_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("INSERT INTO DokumaModel_Bilgileri (modelAdi,modelNo,fasonTakip,siparisSayi,terminTarihi," +
                "iplikCinsi,kullanılanDokumaMakinasi,makinaSayisi) VALUES " +
                         "(@modelAdi,@modelNo,@fasonTakip,@siparisSayi,@terminTarihi,@iplikCinsi," +
                         "@kullanılanDokumaMakinasi,@makinaSayisi)", baglan);

            cmd.Parameters.AddWithValue("@modelAdi", txtModelAdi.Text);
            cmd.Parameters.AddWithValue("@modelNo", modelNo.Text);
            cmd.Parameters.AddWithValue("@fasonTakip", txtFason.Text);
            cmd.Parameters.AddWithValue("@siparisSayi", txtMiktar.Text);
            cmd.Parameters.AddWithValue("@terminTarihi", txtTermin.Text);
            cmd.Parameters.AddWithValue("@iplikCinsi", textBox1.Text);
            cmd.Parameters.AddWithValue("@kullanılanDokumaMakinasi", comboBox1.Text);
            cmd.Parameters.AddWithValue("@makinaSayisi", txtSayi.Text);

            baglan.Open();
            cmd.ExecuteNonQuery();
            baglan.Close();
            MessageBox.Show("Veri başarıyla kaydedildi...");

        }

        private void ormeDokuma_Load(object sender, EventArgs e)
        {
            listele();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = null;
            txtModelAdi.Clear();
            txtFason.Clear();
            txtMiktar.Clear();
            txtTermin.Clear();
            textBox1.Clear();
            txtSayi.Clear();
         
         

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Anasayfa a11 = new Anasayfa();
            this.Hide();
            a11.ShowDialog();
        }
    }
}
