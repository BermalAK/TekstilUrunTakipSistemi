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
    public partial class malzemeEkle : Form
    {
        public malzemeEkle()
        {
            InitializeComponent();
        }
        SqlConnection baglan = new SqlConnection(@"Data Source=LAPTOP-TLB8Q2AL;Initial Catalog=TekstilTakipOtomasyonu;Integrated Security=True");

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void malzemeEkle_Load(object sender, EventArgs e)
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
                comboBox1.Items.Add(dr["modelNo"]);
            }
            baglan.Close();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("INSERT INTO Dokuma_Malzemeleri (modelNo,ipTuru,makinaCesidi) VALUES " +
             "(@modelNo,@ipTuru,@makinaCesidi)", baglan);

            /*SqlParameter imageParameter = new SqlParameter("@resim", SqlDbType.Image);
            imageParameter.Value = DBNull.Value;
            cmd.Parameters.Add(imageParameter);*/

            cmd.Parameters.AddWithValue("@modelNo", comboBox1.Text);
            cmd.Parameters.AddWithValue("@ipTuru", comboİpTuru.Text);
            cmd.Parameters.AddWithValue("@makinaCesidi", comboMakina.Text);

            baglan.Open();
            cmd.ExecuteNonQuery();
            baglan.Close();
            MessageBox.Show("Veri başarıyla kaydedildi...");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("INSERT INTO Dikim_Malzemeleri (modelNo,yikamaTalimati,enseEtiketi,askilik,makinaCesidi1,makinaCesidi2," +
                "makinaCesidi3,makinaCesidi4" +
                ") VALUES " +
             "(@modelNo,@yikamaTalimati,@enseEtiketi,@askilik,@makinaCesidi1,@makinaCesidi2,@makinaCesidi3,@makinaCesidi4)", baglan);

            /*SqlParameter imageParameter = new SqlParameter("@resim", SqlDbType.Image);
            imageParameter.Value = DBNull.Value;
            cmd.Parameters.Add(imageParameter);*/

            cmd.Parameters.AddWithValue("@modelNo", comboBox1.Text);
            cmd.Parameters.AddWithValue("@yikamaTalimati", comboYikama.Text);
            cmd.Parameters.AddWithValue("@enseEtiketi", comboEnse.Text);
            cmd.Parameters.AddWithValue("@askilik", comboAskilik.Text);
            cmd.Parameters.AddWithValue("@makinaCesidi1", comboMakina1.Text);
            cmd.Parameters.AddWithValue("@makinaCesidi2", comboMakina2.Text);
            cmd.Parameters.AddWithValue("@makinaCesidi3", comboMakina3.Text);
            cmd.Parameters.AddWithValue("@makinaCesidi4", comboMakina4.Text);

            baglan.Open();
            cmd.ExecuteNonQuery();
            baglan.Close();
            MessageBox.Show("Veri başarıyla kaydedildi...");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("INSERT INTO Utupaket_Malzemeler (modelNo,utuCesidi,kartonEtiket,alarm,pelur,sticker," +
                "poset,koli,araKarton,kilcik,koliBandi,susKarti" +
                ") VALUES " +
             "(@modelNo,@utuCesidi,@kartonEtiket,@alarm,@pelur,@sticker,@poset,@koli,@araKarton,@kilcik,@koliBandi,@susKarti)", baglan);

            /*SqlParameter imageParameter = new SqlParameter("@resim", SqlDbType.Image);
            imageParameter.Value = DBNull.Value;
            cmd.Parameters.Add(imageParameter);*/

            cmd.Parameters.AddWithValue("@modelNo", comboBox1.Text);
            cmd.Parameters.AddWithValue("@utuCesidi", comboUtu.Text);
            cmd.Parameters.AddWithValue("@kartonEtiket", comboKarton.Text);
            cmd.Parameters.AddWithValue("@alarm", comboAlarm.Text);
            cmd.Parameters.AddWithValue("@pelur", comboPelur.Text);
            cmd.Parameters.AddWithValue("@sticker", comboSticker.Text);
            cmd.Parameters.AddWithValue("@poset", comboPoset.Text);
            cmd.Parameters.AddWithValue("@koli", comboKoli.Text);
            cmd.Parameters.AddWithValue("@araKarton", comboAra.Text);
            cmd.Parameters.AddWithValue("@kilcik", comboKılcık.Text);
            cmd.Parameters.AddWithValue("@koliBandi", comboBant.Text);
            cmd.Parameters.AddWithValue("@susKarti", comboSus.Text);

            baglan.Open();
            cmd.ExecuteNonQuery();
            baglan.Close();
            MessageBox.Show("Veri başarıyla kaydedildi...");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Anasayfa a8 = new Anasayfa();
            this.Hide();
            a8.ShowDialog();
        }
    }
}
