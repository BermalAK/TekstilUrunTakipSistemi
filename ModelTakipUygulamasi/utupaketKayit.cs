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
    public partial class utupaketKayit : Form
    {
        public utupaketKayit()
        {
            InitializeComponent();
        }
        SqlConnection baglan = new SqlConnection(@"Data Source=LAPTOP-TLB8Q2AL;Initial Catalog=TekstilTakipOtomasyonu;Integrated Security=True");

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void utupaketKayit_Load(object sender, EventArgs e)
        {
            listele();
            this.Hide();
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void txtMiktar_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void panel9_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtFason_TextChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void panel10_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtOrder_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            pictureBox1.ImageLocation = openFileDialog1.FileName;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            openFileDialog2.ShowDialog();
            pictureBox2.ImageLocation = openFileDialog2.FileName;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            openFileDialog3.ShowDialog();
            pictureBox3.ImageLocation = openFileDialog3.FileName;
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("INSERT INTO Utupaket_Bilgileri (utuAdi,Adresi,telNo,Muhasebe,calisanKisi,Sorumlu,ortMaas,resim1) VALUES " +
                         "(@utuAdi,@Adresi,@telNo,@Muhasebe,@calisanKisi,@Sorumlu,@ortMaas,@resim1)", baglan);

            /*SqlParameter imageParameter = new SqlParameter("@resim", SqlDbType.Image);
            imageParameter.Value = DBNull.Value;
            cmd.Parameters.Add(imageParameter);*/

            cmd.Parameters.AddWithValue("@resim1", pictureBox1.Text);
            cmd.Parameters.AddWithValue("@utuAdi", txtAdi.Text);
            cmd.Parameters.AddWithValue("@Adresi", txtAdres.Text);
            cmd.Parameters.AddWithValue("@telNo", txtTel.Text);
            cmd.Parameters.AddWithValue("@Muhasebe", txtMuhasebe.Text);
            cmd.Parameters.AddWithValue("@calisanKisi", txtKisi.Text);
            cmd.Parameters.AddWithValue("@Sorumlu", txtSorumlu.Text);
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

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("INSERT INTO UtupaketModel_Bilgileri (resim1,resim2,modelAdi,modelNo,fasonTakip,siparisSayi,terminTarihi,numuneSorumlusu,kullanılanUtu,utuSayisi,kritikler) VALUES " +
                         "(@resim1,@resim2,@modelAdi,@modelNo,@fasonTakip,@siparisSayi,@terminTarihi,@numuneSorumlusu," +
                         "@kullanılanUtu,@utuSayisi,@kritikler)", baglan);

            /*SqlParameter imageParameter = new SqlParameter("@resim", SqlDbType.Image);
            imageParameter.Value = DBNull.Value;
            cmd.Parameters.Add(imageParameter);*/

            cmd.Parameters.AddWithValue("@resim1", pictureBox2.Text);
            cmd.Parameters.AddWithValue("@resim2", pictureBox3.Text);
            cmd.Parameters.AddWithValue("@modelAdi", txtModelAdi.Text);
            cmd.Parameters.AddWithValue("@modelNo", modelNo.Text);
            cmd.Parameters.AddWithValue("@fasonTakip", txtFason.Text);
            cmd.Parameters.AddWithValue("@siparisSayi", txtMiktar.Text);
            cmd.Parameters.AddWithValue("@terminTarihi", txtTermin.Text);
            cmd.Parameters.AddWithValue("@numuneSorumlusu", txtSorumlu.Text);
            cmd.Parameters.AddWithValue("@kullanılanUtu", textBox3.Text);
            cmd.Parameters.AddWithValue("@utuSayisi", textBox1.Text);
            cmd.Parameters.AddWithValue("@kritikler", textBox2.Text);

            baglan.Open();
            cmd.ExecuteNonQuery();
            baglan.Close();
            MessageBox.Show("Veri başarıyla kaydedildi...");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtModelAdi.Clear();
            txtFason.Clear();
            txtMiktar.Clear();
            txtTermin.Clear();
            txtSorumlu.Clear();
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Anasayfa a14 = new Anasayfa();
            this.Hide();
            a14.ShowDialog();
        }
    }
}
