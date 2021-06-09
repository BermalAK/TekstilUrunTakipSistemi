using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ModelTakipUygulamasi
{
    public partial class modelEkle : Form
    {
        public modelEkle()
        {
            InitializeComponent();
        }
        SqlConnection baglan = new SqlConnection(@"Data Source=LAPTOP-TLB8Q2AL;Initial Catalog=TekstilTakipOtomasyonu;Integrated Security=True");
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pnlPassword_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtModel_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnKonfek_Click(object sender, EventArgs e)
        {
           // KonfeksiyonBilgileri konf = new KonfeksiyonBilgileri();
            //konf.ShowDialog();
        }

        private void btnModelEkle_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("INSERT INTO Model_Ekle (modelNo,musteriNo,orderNo,onayMusteri,modelTasarimKisi,modelRenk,konfeksiyonAdi,utupaketAdi,dokumaAdi," +
                "modelYikamaCesidi,siparisAdeti,sevkiyatUlke,resim1,resim2) VALUES " +
              "(@modelNo,@musteriNo,@orderNo,@onayMusteri,@modelTasarimKisi,@modelRenk,@konfeksiyonAdi,@utupaketAdi,@dokumaAdi,@modelYikamaCesidi," +
              "@siparisAdeti,@sevkiyatUlke,@resim1,@resim2)", baglan);

            /*SqlParameter imageParameter = new SqlParameter("@resim", SqlDbType.Image);
            imageParameter.Value = DBNull.Value;
            cmd.Parameters.Add(imageParameter);*/

            cmd.Parameters.AddWithValue("@modelNo", txtModelNo.Text);
            cmd.Parameters.AddWithValue("@musteriNo", txtmusteriNo.Text);
            cmd.Parameters.AddWithValue("@orderNo", txtorderNo.Text);
            cmd.Parameters.AddWithValue("@onayMusteri", txtOnay.Text);
            cmd.Parameters.AddWithValue("@modelTasarimKisi", txtTasarim.Text);
            cmd.Parameters.AddWithValue("@modelRenk", txtRenk.Text);
            cmd.Parameters.AddWithValue("@konfeksiyonAdi", txtKonfeksiyon.Text);
            cmd.Parameters.AddWithValue("@utupaketAdi", txtUtuPaket.Text);
            cmd.Parameters.AddWithValue("@dokumaAdi",txtDokuma.Text);
            cmd.Parameters.AddWithValue("@modelYikamaCesidi", txtYıkama.Text);
            cmd.Parameters.AddWithValue("@siparisAdeti", txtSiparis.Text);
            cmd.Parameters.AddWithValue("@sevkiyatUlke", txtSevkiyat.Text);
            cmd.Parameters.AddWithValue("@resim1", label6.Text);
            cmd.Parameters.AddWithValue("@resim2", label13.Text);

            baglan.Open();
            cmd.ExecuteNonQuery();
            baglan.Close();
            MessageBox.Show("Veri başarıyla kaydedildi...");
        }

        private void button1_Click(object sender, EventArgs e)
        {
          /*  openFileDialog1.ShowDialog();
            pictureBox1.ImageLocation = openFileDialog1.FileName;
            label6.Text = openFileDialog1.FileName;*/
        }

        private void button2_Click(object sender, EventArgs e)
        {
          /*  openFileDialog2.ShowDialog();
            pictureBox2.ImageLocation = openFileDialog2.FileName;
            label13.Text = openFileDialog2.FileName;*/
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = null;
            pictureBox2.Image = null;
            txtModelNo.Clear();
            txtmusteriNo.Clear();
            txtKonfeksiyon.Clear();
            txtOnay.Clear();
            txtorderNo.Clear();
            txtDokuma.Clear();
            txtRenk.Clear();
            txtSevkiyat.Clear();
            txtSiparis.Clear();
            txtTasarim.Clear();
            txtUtuPaket.Clear();
            txtYıkama.Clear();

        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            Anasayfa anasayfa = new Anasayfa();
            this.Hide();
            anasayfa.ShowDialog();
        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void label1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

            openFileDialog1.ShowDialog();
            pictureBox1.ImageLocation = openFileDialog1.FileName;
            label6.Text = openFileDialog1.FileName;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            openFileDialog2.ShowDialog();
            pictureBox2.ImageLocation = openFileDialog2.FileName;
            label13.Text = openFileDialog2.FileName;
        }
    }
}
