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
    public partial class FasonTakip : Form
    {
        public FasonTakip()
        {
            InitializeComponent();
        }

        SqlConnection baglan = new SqlConnection(@"Data Source=LAPTOP-TLB8Q2AL;Initial Catalog=TekstilTakipOtomasyonu;Integrated Security=True");

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

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
                comboBox1.Items.Add(dr["modelNo"]);
            }
            baglan.Close();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("INSERT INTO Fason_Takibi (modelNo,adi,soyadi,calistigiFirma,isVerilenTekstil,Fiyat,İsyeri,Alani,Gorevi,resim1,resim2) VALUES " +
              "(@modelNo,@adi,@soyadi,@calistigiFirma,@isVerilenTekstil,@Fiyat,@İsyeri,@Alani,@Gorevi,@resim1,@resim2)", baglan);

            /*SqlParameter imageParameter = new SqlParameter("@resim", SqlDbType.Image);
            imageParameter.Value = DBNull.Value;
            cmd.Parameters.Add(imageParameter);*/

            cmd.Parameters.AddWithValue("@modelNo", comboBox1.Text);
            cmd.Parameters.AddWithValue("@adi", txtAdi.Text);
            cmd.Parameters.AddWithValue("@soyadi", txtSoyadi.Text);
            cmd.Parameters.AddWithValue("@calistigiFirma", txtFirma.Text);
            cmd.Parameters.AddWithValue("@isVerilenTekstil", txtTekstil.Text);
            cmd.Parameters.AddWithValue("@Fiyat", txtFiyat.Text);
            cmd.Parameters.AddWithValue("@İsyeri", txtİsyeri.Text);
            cmd.Parameters.AddWithValue("@Alani", txtAlan.Text);
            cmd.Parameters.AddWithValue("@Gorevi", txtGörev.Text);
            cmd.Parameters.AddWithValue("@resim1", label11.Text);
            cmd.Parameters.AddWithValue("@resim2", label11.Text);
          
            baglan.Open();
            cmd.ExecuteNonQuery();
            baglan.Close();
            MessageBox.Show("Veri başarıyla kaydedildi...");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            pictureBox1.ImageLocation = openFileDialog1.FileName;
            label11.Text = openFileDialog1.FileName;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            openFileDialog2.ShowDialog();
            pictureBox2.ImageLocation = openFileDialog2.FileName;
            label11.Text = openFileDialog2.FileName;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Fason_İslemleri fs = new Fason_İslemleri();
            fs.ShowDialog();
        }

        private void FasonTakip_Load(object sender, EventArgs e)
        {
            listele();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            comboBox1.Text = "";
            txtAdi.Clear();
            txtAlan.Clear();
            txtFirma.Clear();
            txtFiyat.Clear();
            txtGörev.Clear();
            txtSoyadi.Clear();
            txtTekstil.Clear();
            txtİsyeri.Clear();
            pictureBox1.Image = null;
            pictureBox2.Image = null;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Anasayfa a6 = new Anasayfa();
            this.Hide();
            a6.ShowDialog();
        }
    }
}
