using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ModelTakipUygulamasi
{
    public partial class utuVideo : Form
    {
        public utuVideo()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = "utupaket.MOV";
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = "utupaket.MOV";

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void yuvarlakButon1_Click(object sender, EventArgs e)
        {
            Anasayfa a2 = new Anasayfa();
            this.Hide();
            a2.ShowDialog();
        }

        private void utuVideo_Load(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
