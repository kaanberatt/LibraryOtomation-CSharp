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
    public partial class AnaMenu : Form
    {
        public AnaMenu()
        {
            InitializeComponent();
        }

        private void pictureBox_Gorevligir_Click(object sender, EventArgs e)
        {
            Gorevli_GirisForm grvl_giris = new Gorevli_GirisForm(); // GorevliGirisForm sınıfından yeni nesne ürettik
            this.Hide(); // AcilisForm'u gizle
            grvl_giris.Show(); // GorevliGirisForm formunu göster
        }

        private void pictureBox_CikisYap_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit(); // picturebox ın üzerine tıklayınca formu kapatır.
        }

        private void pictureBox_OgrenciGir_Click(object sender, EventArgs e)
        {
            Ogrenci_GirisForm ogr_giris = new Ogrenci_GirisForm(); // OgrenciGirisForm sınıfından yeni nesne ürettik
            ogr_giris.Show(); // OgrenciGiris formunu göster
            this.Hide(); // açılış formunu gizle
        }

        private void AnaMenu_Load(object sender, EventArgs e)
        {

        }
    }
}
