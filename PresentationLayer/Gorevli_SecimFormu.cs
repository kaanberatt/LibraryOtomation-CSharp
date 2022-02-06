using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KutuphaneOtomasyonu
{
    public partial class Gorevli_SecimFormu : Form
    {
        public Gorevli_SecimFormu()
        {
            InitializeComponent();
        }

        private void pictureBox_CikisYap_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit(); // picturebox ın üzerine tıklayınca formu kapatır
        }

        private void pictureBox_OncekiForm_Click(object sender, EventArgs e)
        {
            Gorevli_GirisForm gorevliGiris = new Gorevli_GirisForm();
            this.Hide();
            gorevliGiris.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Gorevli_OgrenciIslemleriForm ogr_islemleri = new Gorevli_OgrenciIslemleriForm();
            ogr_islemleri.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Gorevli_KitapIslemForm kitap_islemleri = new Gorevli_KitapIslemForm();
            kitap_islemleri.Show();
            this.Hide();
        }
    }
}
