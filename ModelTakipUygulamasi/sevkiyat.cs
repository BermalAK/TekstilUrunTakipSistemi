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
    public partial class sevkiyat : Form
    {
        public sevkiyat()
        {
            InitializeComponent();
        }
        SqlConnection baglan = new SqlConnection(@"Data Source=LAPTOP-TLB8Q2AL;Initial Catalog=TekstilTakipOtomasyonu;Integrated Security=True");

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
        private void sevkiyat_Load(object sender, EventArgs e)
        {
            listele();
        }

        private void btnModelEkle_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("INSERT INTO Sevkiyat (modelNo,sevkiyatUlke,adet,koliSayisi,aracPlakasi,adres,zaman,teslimKisi) VALUES " +
                        "(@modelNo,@sevkiyatUlke,@adet,@koliSayisi,@aracPlakasi,@adres,@zaman,@teslimKisi)", baglan);

            /*SqlParameter imageParameter = new SqlParameter("@resim", SqlDbType.Image);
            imageParameter.Value = DBNull.Value;
            cmd.Parameters.Add(imageParameter);*/

            cmd.Parameters.AddWithValue("@modelNo", modelNo.Text);
            cmd.Parameters.AddWithValue("@sevkiyatUlke", txtulke.Text);
            cmd.Parameters.AddWithValue("@adet", txtAdet.Text);
            cmd.Parameters.AddWithValue("@koliSayisi", txtkoliSayi.Text);
            cmd.Parameters.AddWithValue("@aracPlakasi",txtPlaka.Text);
            cmd.Parameters.AddWithValue("@adres", txtAdres.Text);
            cmd.Parameters.AddWithValue("@zaman", txtZaman.Text);
            cmd.Parameters.AddWithValue("@teslimKisi", txtKisi.Text);

            baglan.Open();
            cmd.ExecuteNonQuery();
            baglan.Close();
            MessageBox.Show("Veri başarıyla kaydedildi...");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Anasayfa aa = new Anasayfa();
            this.Hide();
            aa.ShowDialog();
        }
    }
}
