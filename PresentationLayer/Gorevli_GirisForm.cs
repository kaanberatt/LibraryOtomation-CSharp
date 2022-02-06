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
    public partial class Gorevli_GirisForm : Form
    {
        public Gorevli_GirisForm()
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

        private void checkBox_Sifre_Gstr_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_Sifre_Gstr.CheckState == CheckState.Checked) // CheckBox seçili ise parolayı goster text e gizle yaz
            {
                textBox_GrvlSifre.UseSystemPasswordChar = false;  // Parolayı göster 
                checkBox_Sifre_Gstr.Text = "Gizle";                 // CheckBox textini gizle olarak değiştir
            }
            else if (checkBox_Sifre_Gstr.CheckState == CheckState.Unchecked) // ChecBox seçili değil ise parolayı gizle ve text e göster yaz
            {
                textBox_GrvlSifre.UseSystemPasswordChar = true;  // Parolayı gizle
                checkBox_Sifre_Gstr.Text = "Göster";                 // CheckBox textini goster olarak değiştir
            }
        }

        private void btn_grvlgiris_Click(object sender, EventArgs e)
        {
            if (textBox_GrvlTc.Text !="" && textBox_GrvlSifre.Text !="")
            {
                // Görevli Tc ve şifresinin kontrolü yapılacak
                GorevliBilgileri grvli_bilgi = new GorevliBilgileri();
                grvli_bilgi.GorevliTc = textBox_GrvlTc.Text;
                grvli_bilgi.GorevliSifre = textBox_GrvlSifre.Text;


                if (Gorevli_BusinessLayer.gorevliKontrol_BL(grvli_bilgi)==true)
                {
                    Gorevli_SecimFormu grvli_secim = new Gorevli_SecimFormu();
                    grvli_secim.Show();
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

        private void textBox_GrvlTc_TextChanged(object sender, EventArgs e)
        {
            if (textBox_GrvlTc.Text.Length != 11) 
            {
                errorProvider1.SetError(textBox_GrvlTc, "T.C Kimlik numarası 11 karakterli olmalıdır");
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void Gorevli_GirisForm_Load(object sender, EventArgs e)
        {
            this.AcceptButton = btn_grvlgiris; // enter'a basıldığında btn_grvlgiris butonuna basılmış olacak
            textBox_GrvlTc.MaxLength = 11;
            textBox_GrvlSifre.Text = "admin";
            textBox_GrvlTc.Text = "34508021496";
        }

        private void textBox_GrvlTc_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Görevli T.C'si textbox'ına harf girisini engelledik
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                errorProvider1.SetError(textBox_GrvlTc, "T.C numarası harflerden oluşamaz");
            }
            else
            {
                errorProvider1.Clear();
            }
        }
    }
}
