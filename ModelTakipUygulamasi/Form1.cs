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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection baglan = new SqlConnection(@"Data Source=laptop-tlb8q2al;Initial Catalog=TekstilTakip;Integrated Security=True");
        SqlCommand cmd;
        SqlDataReader read;

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void ProgramAdi_Click(object sender, EventArgs e)
        {

        }

        private void ProgramAdi_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnKucult_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtKullanici_Enter(object sender, EventArgs e)
        {
            if (txtKullanici.Text == "Kullanıcı Adı")
            {
                txtKullanici.Text = "";
                txtKullanici.ForeColor = Color.White;

            }
        }

        private void pctKontrol_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void txtPassword_Enter(object sender, EventArgs e)
        {
            if (txtPassword.Text == "Parola")
            {
                txtPassword.Text = "";
                txtPassword.ForeColor = Color.White;
                txtPassword.UseSystemPasswordChar = true;
            }
        }

        private void txtKullanici_MouseLeave(object sender, EventArgs e)
        {
            if (txtKullanici.Text == "")
            {
                txtKullanici.Text = "Kullanıcı Adı";
                txtKullanici.ForeColor = Color.White;
              //  txtKullanici.ForeColor = Color.Red;

            }
        }

        private void txtPassword_MouseLeave(object sender, EventArgs e)
        {
            if (txtPassword.Text == "")
            {
                txtPassword.Text = "Parola";
               // txtPassword.ForeColor = Color.Red;// deneme amaçlı denendi.

                txtPassword.ForeColor = Color.LightGray;
                txtPassword.UseSystemPasswordChar = false;
            }
        }

        private void lblParola_Click(object sender, EventArgs e)
        {
            ParolaUnuttum prl = new ParolaUnuttum();
            prl.ShowDialog();
        }
        private void btnGiris_Click(object sender, EventArgs e)
        {
            hatırlama();
            string user = txtKullanici.Text;
            string pass = txtPassword.Text;
            //con = new SqlConnection("server=DESKTOP-JU1LJ2M\\SQLEXPRESS; Initial Catalog=dbLogin;Integrated Security=SSPI");
            cmd = new SqlCommand();
            baglan.Open();
            cmd.Connection = baglan;
            cmd.CommandText = "SELECT * FROM KullaniciGirisi where KullaniciAdi='" + txtKullanici.Text + "' AND parola='" + txtPassword.Text + "'";
            read = cmd.ExecuteReader();
            if (read.Read())
            {
                //MessageBox.Show("Giris başarılı.");
                Anasayfa ans = new Anasayfa();
                ans.ShowDialog();
            }
            else
            {
                MessageBox.Show("Kullanıcı adını ve şifrenizi kontrol ediniz.");
                txtPassword.Clear();
                txtKullanici.Clear();
            }
            baglan.Close();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            txtKullanici.Text = Properties.Settings.Default["kuladi"].ToString();
            txtPassword.Text = Properties.Settings.Default["sifre"].ToString();
        }
        public void hatırlama()
        {
            if (BeniHatirla.Checked)
            {
                Properties.Settings.Default["kuladi"] = txtKullanici.Text;
                Properties.Settings.Default["sifre"] = txtPassword.Text;
            }
            else
            {
                Properties.Settings.Default["kuladi"] = "";
                Properties.Settings.Default["sifre"] = "";
            }
            Properties.Settings.Default.Save();

        }

        private void txtKullanici_TextChanged(object sender, EventArgs e)
        {

        }

        private void pctKontrol_Click(object sender, EventArgs e)
        {

        }

        /*private void btnGiris_Click(object sender, EventArgs e)
        {
            hatırlama();
            string user = txtKullanici.Text;
            string pass = txtPassword.Text;
            //con = new SqlConnection("server=DESKTOP-JU1LJ2M\\SQLEXPRESS; Initial Catalog=dbLogin;Integrated Security=SSPI");
            cmd = new SqlCommand();
            baglan.Open();
            cmd.Connection = baglan;
            cmd.CommandText = "SELECT * FROM KullaniciGirisi where KullaniciAdi='" + txtKullanici.Text + "' AND parola='" + txtPassword.Text + "'";
            read = cmd.ExecuteReader();
            if (read.Read())
            {
                //MessageBox.Show("Giris başarılı.");
                Anasayfa ans = new Anasayfa();
                ans.ShowDialog();
            }
            else
            {
                MessageBox.Show("Kullanıcı adını ve şifrenizi kontrol ediniz.");
                txtPassword.Clear();
                txtKullanici.Clear();
            }
            baglan.Close();
        }*/
    }
}
