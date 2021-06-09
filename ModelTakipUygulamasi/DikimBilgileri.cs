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
    public partial class DikimBilgileri : Form
    {
        public DikimBilgileri()
        {
            InitializeComponent();
        }
        SqlConnection baglan = new SqlConnection(@"Data Source=LAPTOP-TLB8Q2AL;Initial Catalog=TekstilTakipOtomasyonu;Integrated Security=True");

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
            openFileDialog1.ShowDialog();
            pictureBox1.ImageLocation = openFileDialog1.FileName;
           label21.Text = openFileDialog1.FileName;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            openFileDialog2.ShowDialog();
            pictureBox2.ImageLocation = openFileDialog2.FileName;
            label21.Text = openFileDialog2.FileName;

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            openFileDialog3.ShowDialog();
            pictureBox3.ImageLocation = openFileDialog3.FileName;
            label21.Text = openFileDialog3.FileName;

        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("INSERT INTO Konfeksiyon_Bilgileri (resim1,konfAdi,Adres,telNo,Muhasebe,calisanKisi,calisanSorumlu,ortMaas) VALUES " +
                         "(@resim1,@konfAdi,@Adres,@telNo,@Muhasebe,@calisanKisi,@calisanSorumlu,@ortMaas)", baglan);

            /*SqlParameter imageParameter = new SqlParameter("@resim", SqlDbType.Image);
            imageParameter.Value = DBNull.Value;
            cmd.Parameters.Add(imageParameter);*/

            cmd.Parameters.AddWithValue("@resim1", pictureBox1.Text);
            cmd.Parameters.AddWithValue("@konfAdi", txtAdi.Text);
            cmd.Parameters.AddWithValue("@Adres", txtAdres.Text);
            cmd.Parameters.AddWithValue("@telNo", txtTel.Text);
            cmd.Parameters.AddWithValue("@Muhasebe", txtMuhasebe.Text);
            cmd.Parameters.AddWithValue("@calisanKisi", txtKisi.Text);
            cmd.Parameters.AddWithValue("@calisanSorumlu", txtSorumlu.Text);
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
            SqlCommand cmd = new SqlCommand("INSERT INTO KonfeksiyonModel_Bilgileri (resim1,resim2,modelAdi,modelNo,fasonTakipcisi,siparisSayisi,terminTarihi,numuneSorumlusu," +
                "kullanılanMakina,makinaSayisi,sBeden,mBeden,lBeden,xlBeden,kritikler) VALUES " +
                         "(@resim1,@resim2,@modelAdi,@modelNo,@fasonTakipcisi,@siparisSayisi,@terminTarihi,@numuneSorumlusu," +
                         "@kullanılanMakina,@makinaSayisi,@sBeden,@mBeden,@lBeden,@xlBeden,@kritikler)", baglan);

            /*SqlParameter imageParameter = new SqlParameter("@resim", SqlDbType.Image);
            imageParameter.Value = DBNull.Value;
            cmd.Parameters.Add(imageParameter);*/

            cmd.Parameters.AddWithValue("@resim1", pictureBox2.Text);
            cmd.Parameters.AddWithValue("@resim2", pictureBox3.Text);
            cmd.Parameters.AddWithValue("@modelAdi", txtModelAdi.Text);
            cmd.Parameters.AddWithValue("@modelNo", modelNo.Text);
            cmd.Parameters.AddWithValue("@fasonTakipcisi", txtFason.Text);
            cmd.Parameters.AddWithValue("@siparisSayisi", txtMiktar.Text);
            cmd.Parameters.AddWithValue("@terminTarihi", txtTermin.Text);
            cmd.Parameters.AddWithValue("@numuneSorumlusu", txtSorumlu.Text);
            cmd.Parameters.AddWithValue("@kullanılanMakina", textBox3.Text);
            cmd.Parameters.AddWithValue("@makinaSayisi", textBox1.Text);
            cmd.Parameters.AddWithValue("@sBeden", txtsAdeti.Text);
            cmd.Parameters.AddWithValue("@mBeden", txtmAdeti.Text);
            cmd.Parameters.AddWithValue("@lBeden", txtlAdeti.Text);
            cmd.Parameters.AddWithValue("@xlBeden", txtxlAdeti.Text);
            cmd.Parameters.AddWithValue("@kritikler",textBox2.Text);

            baglan.Open();
            cmd.ExecuteNonQuery();
            baglan.Close();
            MessageBox.Show("Veri başarıyla kaydedildi...");
        }

        private void DikimBilgileri_Load(object sender, EventArgs e)
        {
            listele();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtAdi.Clear();
            pictureBox3.Image = null;
            pictureBox2.Image = null;
            txtMiktar.Clear();
            txtFason.Clear();
            txtTermin.Clear();
            txtNumune.Clear();
            textBox3.Clear();
            textBox1.Clear();
            txtsAdeti.Clear();
            txtmAdeti.Clear();
            txtlAdeti.Clear();
            txtxlAdeti.Clear();
            textBox2.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Anasayfa a3 = new Anasayfa();
            this.Hide();
            a3.ShowDialog();
        }
    }
}
