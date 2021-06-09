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
    public partial class dikimVideo : Form
    {
        public dikimVideo()
        {
            InitializeComponent();
        }

        private void dikimVideo_Load(object sender, EventArgs e)
        {

        }

        private void yuvarlakButon1_Click(object sender, EventArgs e)
        {
            Anasayfa anasayfa = new Anasayfa();
            this.Hide();
            anasayfa.ShowDialog();
        }
    }
}
