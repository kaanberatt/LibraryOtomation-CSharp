using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entity;
using BusinessLayer;
namespace KutuphaneOtomasyonu
{
    public partial class Ogrenci_GirisForm : Form
    {
        public Ogrenci_GirisForm()
        {
            InitializeComponent();
        }

        private void pictureBox_CikisYap_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit(); // picturebox ın üzerine tıklayınca formu kapatır
        }

        private void pictureBox_OncekiForm_Click(object sender, EventArgs e)
        {
            AnaMenu acilis = new AnaMenu(); // AcilisForm sınıfından yeni nesne ürettik
            acilis.Show(); // AcilisForm formunu göster
            this.Hide(); // aktif formunu gizle
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.CheckState == CheckState.Checked) // CheckBox seçili ise parolayı goster text e gizle yaz
            {
                textBox_OgrnSifre.UseSystemPasswordChar = false;  // Parolayı göster 
                checkBox1.Text = "Gizle";                 // CheckBox textini gizle olarak değiştir
            }
            else if (checkBox1.CheckState == CheckState.Unchecked) // ChecBox seçili değil ise parolayı gizle ve text e göster yaz
            {
                textBox_OgrnSifre.UseSystemPasswordChar = true;  // Parolayı gizle
                checkBox1.Text = "Göster";                 // CheckBox textini goster olarak değiştir
            }
        }

        private void textBox_OgrnTc_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btn_OgrnGirisYap_Click(object sender, EventArgs e)
        {
             if (textBox_OgrnNo.Text != "" && textBox_OgrnSifre.Text != "")
            {
                // Öğrenci Tc ve şifresinin kontrolü yapılacak

                /* Değerleri Kontrol etmek için OgrenciBilgileri sınıfından yeni bir nesne 
                 yarattık ve kontrol için textboxdaki değerleri Entity katmanındaki değişkenlere atadık.
                */
                OgrenciBilgileri ogrenci = new OgrenciBilgileri();
                ogrenci.OgrenciNo = textBox_OgrnNo.Text; 
                ogrenci.OgrenciSifre = textBox_OgrnSifre.Text;

                if (Ogrenci_BusinessLayer.ogrenciKontrol_BL(ogrenci)==true) 
                {   // Veritabanındaki Ogrenci tablosunda 
                    // Değerlerin doğru olması halinde Ogrenci_KitapAlBırak formuna geçiş yapılır
                    Ogrenci_KitapAlBırak ogr_kitapAlBirak = new Ogrenci_KitapAlBırak();
                    ogr_kitapAlBirak.lbl_Id.Text = Ogrenci_BusinessLayer.OgrenciIdSorgu_BL(ogrenci).ToString();
                    ogr_kitapAlBirak.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Hatalı Giriş Yaptınız Lütfen Tekrar Deneyiniz");
                }
            }
            else
            {
                MessageBox.Show("Lütfen Tüm Alanları Eksiksiz Doldurunuz...");
            }
        }

        private void Ogrenci_GirisForm_Load(object sender, EventArgs e)
        {
            textBox_OgrnNo.Text = "5454";
            textBox_OgrnSifre.Text = "5453";
            this.AcceptButton = btn_OgrnGirisYap; // enter'a basıldığında btn_OgrnGirisYap butonuna basılmış olacak
        }

        private void textBox_OgrnTc_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Ogrenci Numarası textbox'ına harf girisini engelledik
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                errorProvider1.SetError(textBox_OgrnNo, "Öğrenci numarası harflerden oluşamaz");
            }
            else
            {
                errorProvider1.Clear();
            }
        }
    }
}
