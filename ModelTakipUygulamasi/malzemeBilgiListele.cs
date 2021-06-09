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
    public partial class malzemeBilgiListele : Form
    {
        public malzemeBilgiListele()
        {
            InitializeComponent();
        }
        SqlConnection baglan = new SqlConnection(@"Data Source=LAPTOP-TLB8Q2AL;Initial Catalog=TekstilTakipOtomasyonu;Integrated Security=True");

        DataTable yenile()
        {
            baglan.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select * from DokumaModel_Bilgileri", baglan);
            DataTable tablo = new DataTable();
            adtr.Fill(tablo);
            baglan.Close();
            return tablo;
        }
        DataTable yenile1()
        {
            baglan.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select * from UtupaketModel_Bilgileri", baglan);
            DataTable tablo = new DataTable();
            adtr.Fill(tablo);
            baglan.Close();
            return tablo;
        }
        DataTable yenile2()
        {
            baglan.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select * from KonfeksiyonModel_Bilgileri", baglan);
            DataTable tablo = new DataTable();
            adtr.Fill(tablo);
            baglan.Close();
            return tablo;
        }
        private void malzemeBilgiListele_Load(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void radioButton2_Click(object sender, EventArgs e)
        {
            SqlDataAdapter tdGrvAdpter = new SqlDataAdapter("select * from Dikim_Malzemeleri", baglan);
            DataSet dtGrv = new DataSet();
            tdGrvAdpter.Fill(dtGrv);
            dataGridView1.DataSource = dtGrv.Tables[0];
            baglan.Close();
        }

        private void radioButton1_Click(object sender, EventArgs e)
        {
            SqlDataAdapter adap = new SqlDataAdapter("select * from Dokuma_Malzemeleri", baglan);
            DataSet dtGrv1 = new DataSet();
            adap.Fill(dtGrv1);
            dataGridView1.DataSource = dtGrv1.Tables[0];
            baglan.Close();
        }

        private void radioButton3_Click(object sender, EventArgs e)
        {
            SqlDataAdapter adap1 = new SqlDataAdapter("select * from Utupaket_Malzemeler", baglan);
            DataSet ds = new DataSet();
            adap1.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            baglan.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Anasayfa a7 = new Anasayfa();
            this.Hide();
            a7.ShowDialog();
        }
    }
}
