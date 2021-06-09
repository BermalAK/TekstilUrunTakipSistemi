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
    public partial class KonfeksiyonBilgileri : Form
    {
        public KonfeksiyonBilgileri()
        {
            InitializeComponent();
        }
        SqlConnection baglan = new SqlConnection(@"Data Source=laptop-tlb8q2al;Initial Catalog=TekstilTakip;Integrated Security=True");

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel15_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnModelEkle_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            pctModel.ImageLocation = openFileDialog1.FileName;
            label12.Text = openFileDialog1.FileName;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog2.ShowDialog();
            pctOlcu.ImageLocation = openFileDialog2.FileName;
            label18.Text = openFileDialog2.FileName;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            openFileDialog3.ShowDialog();
            pctBir.ImageLocation = openFileDialog3.FileName;
            label19.Text = openFileDialog3.FileName;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            openFileDialog4.ShowDialog();
            pctiki.ImageLocation = openFileDialog4.FileName;
            label20.Text = openFileDialog4.FileName;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("INSERT INTO Konfeksiyon_Bilgileri(musteriAdi,orderNo,fasonTakipcisi,siparisAdeti,konfeksiyonAdi," +
                "konfeksiyonAdresi,terminTarihi,askilikAdeti," +
                "pulAdeti,yikamaAdeti,enseAdeti,numuneSorumlusu,nakisTipi,iplikCinsi,baskiTipi,calisanKisiSayisi,calisanSorumlusu,sAdeti," +
                "mAdeti,lAdeti,xlAdeti,kritikler,resim1,resim2,resim3,resim4) VALUES " +
              "(@musteriAdi,@orderNo,@fasonTakipcisi,@siparisAdeti,@konfeksiyonAdi,@konfeksiyonAdresi,@terminTarihi,@askilikAdeti,@pulAdeti," +
              "@yikamaAdeti,@enseAdeti,@numuneSorumlusu,@nakisTipi,@iplikCinsi,@baskiTipi,@calisanKisiSayisi,@calisanSorumlusu,@sAdeti,@mAdeti," +
              "@lAdeti,@xlAdeti,@kritikler,@resim1,@resim2,@resim3,@resim4)", baglan);

            /*SqlParameter imageParameter = new SqlParameter("@resim", SqlDbType.Image);
            imageParameter.Value = DBNull.Value;
            cmd.Parameters.Add(imageParameter);*/

            cmd.Parameters.AddWithValue("@musteriAdi", txtMusteriAdi.Text);
            cmd.Parameters.AddWithValue("@orderNo", txtorderNo.Text);
            cmd.Parameters.AddWithValue("@fasonTakipcisi", txtfasonTakipcisi.Text);
            cmd.Parameters.AddWithValue("@siparisAdeti", txtsiparisAdeti.Text);
            cmd.Parameters.AddWithValue("@konfeksiyonAdi", txtKonfeksiyonAdi.Text);
            cmd.Parameters.AddWithValue("@konfeksiyonAdresi", txtKonfeksiyonAdresi.Text);
            cmd.Parameters.AddWithValue("@terminTarihi", txtTerminTarihi.Text);
            cmd.Parameters.AddWithValue("@askilikAdeti", askilikAdeti.Text);
            cmd.Parameters.AddWithValue("@pulAdeti", pulAdeti.Text);
            cmd.Parameters.AddWithValue("@yikamaAdeti", yikamaAdeti.Text);
            cmd.Parameters.AddWithValue("@enseAdeti", enseAdeti.Text);
            cmd.Parameters.AddWithValue("@numuneSorumlusu", txtnumuneSorumlusu.Text);
            cmd.Parameters.AddWithValue("@nakisTipi", txtnakisTipi.Text);
            cmd.Parameters.AddWithValue("@iplikCinsi", txtiplikCinsi.Text);
            cmd.Parameters.AddWithValue("@baskiTipi", txtbaskiTipi.Text);
            cmd.Parameters.AddWithValue("@calisanKisiSayisi", txtcalisanKisi.Text);
            cmd.Parameters.AddWithValue("@calisanSorumlusu", txtcalisanSorumlusu.Text);
            cmd.Parameters.AddWithValue("@sAdeti", txtsAdeti.Text);
            cmd.Parameters.AddWithValue("@mAdeti", txtmAdeti.Text);
            cmd.Parameters.AddWithValue("@lAdeti", txtlAdeti.Text);
            cmd.Parameters.AddWithValue("@xlAdeti", txtxlAdeti.Text);
            cmd.Parameters.AddWithValue("@kritikler", txtKritikler.Text);
            cmd.Parameters.AddWithValue("@resim1", label12.Text);
            cmd.Parameters.AddWithValue("@resim2", label18.Text);
            cmd.Parameters.AddWithValue("@resim3", label19.Text);
            cmd.Parameters.AddWithValue("@resim4", label20.Text);

            baglan.Open();
            cmd.ExecuteNonQuery();
            baglan.Close();
            MessageBox.Show("Veri başarıyla kaydedildi...");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtMusteriAdi.Clear();
            txtorderNo.Clear();
            txtfasonTakipcisi.Clear();
            txtsiparisAdeti.Clear();
            txtKonfeksiyonAdi.Clear();
            txtKonfeksiyonAdresi.Clear();
            txtTerminTarihi.Clear();
            askilikAdeti.Clear();
            pulAdeti.Clear();
            yikamaAdeti.Clear();
            enseAdeti.Clear();
            txtnumuneSorumlusu.Clear();
            txtnakisTipi.Clear();
            txtiplikCinsi.Clear();
            txtbaskiTipi.Clear();
            txtcalisanKisi.Clear();
            txtsAdeti.Clear();
            txtmAdeti.Clear();
            txtlAdeti.Clear();
            txtxlAdeti.Clear();
            txtKritikler.Clear();
            pctModel.Image = null;
            pctOlcu.Image = null;
            pctiki.Image = null;
            pctBir.Image = null;
        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void KonfeksiyonBilgileri_Load(object sender, EventArgs e)
        {

        }
    }
}
