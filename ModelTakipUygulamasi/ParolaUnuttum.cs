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
    public partial class ParolaUnuttum : Form
    {
        public ParolaUnuttum()
        {
            InitializeComponent();
        }
        SqlConnection baglan = new SqlConnection(@"Data Source=laptop-tlb8q2al;Initial Catalog=TekstilTakip;Integrated Security=True");

        private void btnGiris_Click(object sender, EventArgs e)
        {
            SqlDataAdapter adap = new SqlDataAdapter("select count(*) from KullaniciGirisi where KullaniciAdi='" + txtKullanici.Text + "' AND GuvenlikSorusu='" + txtGuvenlikSoru.Text + "' AND parola='" + txtPassword.Text + "'", baglan);
            DataTable dtable = new DataTable();
            adap.Fill(dtable);
            if (dtable.Rows[0][0].ToString()=="1")
            {
                baglan.Open();
                SqlCommand cmd = new SqlCommand("update KullaniciGirisi set parola='"+txtPassword.Text+"'",baglan);
                cmd.ExecuteNonQuery();
                baglan.Close();

                this.Hide();
                MessageBox.Show("Şifre başarıyla değiştirildi.");
                //new PSBasarili().Show();
            }
            else
            {
                this.Hide();
                MessageBox.Show("İşlem başarısız oldu.");
            }
        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            this.Hide();
            f1.ShowDialog();
        }

        private void txtKullanici_Enter(object sender, EventArgs e)
        {
            if (txtKullanici.Text == "Kullanıcı Adı")
            {
                txtKullanici.Text = "";
                txtKullanici.ForeColor = Color.White;
            }
        }

        private void ParolaUnuttum_Load(object sender, EventArgs e)
        {

        }

        private void txtKullanici_Leave(object sender, EventArgs e)
        {
            if (txtKullanici.Text == "")
            {
                txtKullanici.Text = "Kullanıcı Adı";
                txtKullanici.ForeColor = Color.White;
            }
        }

        private void txtPassword_Enter(object sender, EventArgs e)
        {
            if(txtPassword.Text=="Yeni Parola")
            {
                txtPassword.Text = "";
                txtPassword.ForeColor = Color.White;
                txtPassword.UseSystemPasswordChar = true;
                txtPassword.Visible = true;
            }
        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            if (txtPassword.Text == "")
            {
                txtPassword.Text = "Yeni Parola";
                txtPassword.ForeColor = Color.LightGray;
                txtPassword.UseSystemPasswordChar = false;
                txtPassword.Visible = false;
            }
        }

        private void txtGuvenlikSoru_Enter(object sender, EventArgs e)
        {
            if (txtGuvenlikSoru.Text == "Guvenlik Sorusu")
            {
                txtGuvenlikSoru.Text = "";
                txtGuvenlikSoru.ForeColor = Color.White;
            }
        }

        private void txtGuvenlikSoru_Leave(object sender, EventArgs e)
        {
            if (txtGuvenlikSoru.Text == "")
            {
                txtGuvenlikSoru.Text = "Guvenlik Sorusu";
                txtGuvenlikSoru.ForeColor = Color.White;
            }
        }
    }
}
