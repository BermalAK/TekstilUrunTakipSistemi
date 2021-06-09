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
    public partial class Numune : Form
    {
        public Numune()
        {
            InitializeComponent();
            ToolTip toolTip = new ToolTip();
            toolTip.ShowAlways = true;
            toolTip.SetToolTip(lblNumune, "Numune, yapılan işi müşteriye onaylatmak amacıyla hazırlanır. Müşterinin istediği şekilde ve sayıyla hazırlanırlar.");
            toolTip.IsBalloon = true;

            ToolTip tooltip1 = new ToolTip();
            tooltip1.ShowAlways = true;
            tooltip1.SetToolTip(lblalan, "Numune alanını seçiniz. Dikim/Ütü paket");
            tooltip1.IsBalloon = true;
        }
        SqlConnection baglan = new SqlConnection(@"Data Source=LAPTOP-TLB8Q2AL;Initial Catalog=TekstilTakipOtomasyonu;Integrated Security=True");
        SqlDataAdapter da;
        DataSet ds;
        SqlCommandBuilder cmdb;
        //SqlCommand cmd;
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
                comboModel.Items.Add(dr["modelNo"]);
            }
            baglan.Close();
        }
        public void listele2()
        {
            SqlCommand komut1 = new SqlCommand();
            komut1.CommandText = "SELECT *FROM Model_Ekle";
            komut1.Connection = baglan;
            komut1.CommandType = CommandType.Text;

            SqlDataReader drr;
            baglan.Open();
            drr = komut1.ExecuteReader();
            while (drr.Read())
            {
                comboBox1.Items.Add(drr["modelNo"]);
            }
            baglan.Close();
        }
        public void renkListele()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "select * from Model_Ekle";
            cmd.Connection = baglan;
            cmd.CommandType = CommandType.Text;

            SqlDataReader rd;
            baglan.Open();
            rd = cmd.ExecuteReader();
            while(rd.Read())
            {
                comboRenk.Items.Add(rd["modelRenk"]);
            }
            baglan.Close();
        }
        

        private void Numune_Load(object sender, EventArgs e)
        {
            listele();
            renkListele();
            listele2();
            comboAlan.Items.Add("Dikimhane");
            comboAlan.Items.Add("Ütü paket");
            comboAlan.Items.Add("Dokuma");
            comboBeden.Items.Add("XS");
            comboBeden.Items.Add("S");
            comboBeden.Items.Add("M");
            comboBeden.Items.Add("L");
            comboBeden.Items.Add("XL");


         //   listele2();
            baglan.Open();
            da = new SqlDataAdapter("Select * from Numune", baglan);
            cmdb = new SqlCommandBuilder(da);
            ds = new DataSet();
            da.Fill(ds, "Numune");
            dataGridView1.DataSource = ds.Tables[0];
            baglan.Close();

        }


        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void comboModel_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            pictureBox1.ImageLocation = openFileDialog1.FileName;
            comboModel.Text = openFileDialog1.FileName;
        }

        private void comboAlan_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    
        private void button2_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("INSERT INTO Numune (modelNo,modelResmi,numuneAlani,modelRengi,numuneBedeni,numuneSayisi,dikimNumunesi,paketNumunesi) VALUES " +
                         "(@modelNo,@modelResmi,@numuneAlani,@modelRengi,@numuneBedeni,@numuneSayisi,@dikimNumunesi,@paketNumunesi)", baglan);

            /*SqlParameter imageParameter = new SqlParameter("@resim", SqlDbType.Image);
            imageParameter.Value = DBNull.Value;
            cmd.Parameters.Add(imageParameter);*/

            cmd.Parameters.AddWithValue("@modelNo", comboModel.Text);
            cmd.Parameters.AddWithValue("@modelResmi", pictureBox1.Text);
            cmd.Parameters.AddWithValue("@numuneAlani", comboAlan.Text);
            cmd.Parameters.AddWithValue("@modelRengi", comboRenk.Text);
            cmd.Parameters.AddWithValue("@numuneBedeni", comboBeden.Text);
            cmd.Parameters.AddWithValue("@numuneSayisi", txtSayi.Text);
            cmd.Parameters.AddWithValue("@dikimNumunesi", pictureBox2.Text);
            cmd.Parameters.AddWithValue("@paketNumunesi", pictureBox2.Text);
          

            baglan.Open();
            cmd.ExecuteNonQuery();
            baglan.Close();
            MessageBox.Show("Veri başarıyla kaydedildi...");
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
        
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            
        }

        private void label6_Click(object sender, EventArgs e)
        {
            openFileDialog2.ShowDialog();
            pictureBox2.ImageLocation = openFileDialog2.FileName;
            label7.Text = openFileDialog2.FileName;
        }

        private void label5_Click(object sender, EventArgs e)
        {
            openFileDialog2.ShowDialog();
            pictureBox2.ImageLocation = openFileDialog2.FileName;
            label7.Text = openFileDialog2.FileName;
        }
        private void kayitGetir()
        {
            baglan.Open();
            string kayit = "SELECT * from Numune";
            SqlCommand komut = new SqlCommand(kayit, baglan);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            baglan.Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            kayitGetir();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            da.Update(ds, "Numune");
            MessageBox.Show("Kayıt güncellendi");
        }
       
        private void button4_Click(object sender, EventArgs e)
        {
            baglan.Open();
            SqlCommand cmd = new SqlCommand("delete  from Numune where modelNo=@modelNo", baglan);
            cmd.Parameters.AddWithValue("@modelNo", comboBox1.Text);
            cmd.ExecuteNonQuery();
            baglan.Close();
            MessageBox.Show("Kayıt silinmiştir.");
            listele();
            listele2();
            comboBox1.Text = "";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            baglan.Open();
            SqlCommand cmd = new SqlCommand("select * from Numune where modelNo like '%" + comboBox1.Text + "%'", baglan);
            SqlDataAdapter adap = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adap.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            baglan.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Anasayfa a9 = new Anasayfa();
            this.Hide();
            a9.ShowDialog();
        }
    }
}
