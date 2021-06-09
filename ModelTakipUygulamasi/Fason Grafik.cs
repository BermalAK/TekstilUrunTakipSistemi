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
    public partial class Fason_Grafik : Form
    {
        public Fason_Grafik()
        {
            InitializeComponent();
        }
        SqlConnection baglan = new SqlConnection(@"Data Source=LAPTOP-TLB8Q2AL;Initial Catalog=TekstilTakipOtomasyonu;Integrated Security=True");

        private void Fason_Grafik_Load(object sender, EventArgs e)
        {
            baglan.Open();
            SqlCommand cmd = new SqlCommand("Select modelNo,Fiyat From Fason_Takibi", baglan);
            SqlDataReader oku = cmd.ExecuteReader();
            while(oku.Read())
            {
                chart1.Series["Fason_İslemleri"].Points.AddXY(oku[0].ToString(), oku[1]);
            }
            baglan.Close();
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Anasayfa a4 = new Anasayfa();
            this.Hide();
            a4.ShowDialog();
        }
    }
}
