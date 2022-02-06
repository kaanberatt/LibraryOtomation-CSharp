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
    public partial class Gorevli_KitapIslemForm : Form
    {
        public Gorevli_KitapIslemForm()
        {
            InitializeComponent();
        }

        private void pictureBox_CikisYap_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit(); // picturebox ın üzerine tıklayınca formu kapatır
        }

        private void pictureBox_OncekiForm_Click(object sender, EventArgs e)
        {
            Gorevli_SecimFormu grvli_secim = new Gorevli_SecimFormu();
            grvli_secim.Show();
            this.Hide();
        }
        private void Gorevli_KitapIslemForm_Load(object sender, EventArgs e)
        {
            dataGridView_Kitap.DataSource = Kitap_BusinessLayer.kitapListele_BL();
        }

        private void btn_Ekle_Click(object sender, EventArgs e)
        {
            if (txt_AdEkle.Text != "" && comboBox_TurEkle.Text!="" && txt_SayfaEkle.Text != "" &&   txt_YazarEkle.Text!="")
            {
                KitapBilgileri kitapBilgi = new KitapBilgileri();
                //Entity katmanında KitapBilgileri sınıfındaki değişkenlere textboxtaki veriler aktarılır.
                kitapBilgi.KitapAd = txt_AdEkle.Text;
                kitapBilgi.KitapTuru = comboBox_TurEkle.Text;
                kitapBilgi.KitapSayfa = txt_SayfaEkle.Text;
                kitapBilgi.KitapYazar = txt_YazarEkle.Text;

                Kitap_BusinessLayer.KitapEkle_BL(kitapBilgi);
                MessageBox.Show("Kitap Başarıyla Eklendi.");
                dataGridView_Kitap.DataSource = Kitap_BusinessLayer.kitapListele_BL();

            }
            else
            {
                MessageBox.Show("Lütfen Gerekli Alanları Doldurunuz !!");
            }
        }

       

        private void btn_sil_Click(object sender, EventArgs e)
        {
            if (txt_IdSil.Text != "" )
            {
                KitapBilgileri kitapBilgi = new KitapBilgileri();
                //Entity katmanında KitapBilgileri sınıfındaki değişkenlere textboxtaki veriler aktarılır.
                kitapBilgi.KitapId = int.Parse(txt_IdSil.Text);
                //Girilen id ye ait kitap kontrol edildi
                if (Kitap_BusinessLayer.KitapSorgu_BL(kitapBilgi) == true)
                {
                    Kitap_BusinessLayer.KitapSil_BL(kitapBilgi); // Business katmanındaki kitapSİL Fonksiyonuna silme işlemi için verileri gönderdik
                    MessageBox.Show("Kitap Başarıyla Silindi.");
                    dataGridView_Kitap.DataSource = Kitap_BusinessLayer.kitapListele_BL(); // Lİstenin güncel halini datagrid e yansıttık
                    txt_IdSil.Text = ""; // Silme işleminden sonra textbox ı temizledik
                }

                else
                    MessageBox.Show("Geçersiz Id !");
                

            }
            else
            {
                MessageBox.Show("Lütfen Gerekli Alanları Doldurunuz !!");
            }
        }

        private void btn_guncelle_Click(object sender, EventArgs e)
        {
            //Güncelleme işlemi için textboxların dolu olup olmadığını kontrol ettik
            if (txt_AdGuncelle.Text != "" && comboBox_TurGuncelle.Text != "" && txt_SayfaGuncelle.Text != "" && txt_YazarGuncelle.Text != "")
            {
                //Entity katmanındaki değişkenlere textboxtaki verileri aktardık
                KitapBilgileri kitapBilgi = new KitapBilgileri();
                //Entity katmanında KitapBilgileri sınıfındaki değişkenlere textboxtaki veriler aktarılır.
                kitapBilgi.KitapAd = txt_AdGuncelle.Text;
                kitapBilgi.KitapTuru = comboBox_TurGuncelle.Text;
                kitapBilgi.KitapSayfa = txt_SayfaGuncelle.Text;
                kitapBilgi.KitapYazar = txt_YazarGuncelle.Text;
                kitapBilgi.KitapId = id;
                

                // Girilen id ye ait kitap kontrol edildi
                if (Kitap_BusinessLayer.KitapSorgu_BL(kitapBilgi) == true)
                {
                    Kitap_BusinessLayer.KitapGuncelle_BL(kitapBilgi);// Business katmanındaki kitapGuncelle Fonksiyonuna guncelleme işlemi için verileri gönderdik
                    MessageBox.Show("Kitap Guncellendi");
                    dataGridView_Kitap.DataSource = Kitap_BusinessLayer.kitapListele_BL();// Lİstenin güncel halini datagrid e yansıttık
                    //Güncelleme işlemi bitince textboxları temizledik
                    textTemizle_g();
                    id = 0;
                }

                else
                    MessageBox.Show("Lütfen listeden seçiminizi yaptıktan sonra değerleri doldurunuz !");
            }

            else
            {
                MessageBox.Show("Lütfen gerekli alanları doldurunuz");
            }
        }

        int id;  //Global Id tanımlandı
        private void dataGridView_Kitap_SelectionChanged(object sender, EventArgs e)
        {
            //Tablo üzerinde tıklanan satırın verilerini guncelleme alanındaki textboxlara yazdırdık
            id = int.Parse(dataGridView_Kitap.CurrentRow.Cells[0].Value.ToString());
            txt_AdGuncelle.Text = dataGridView_Kitap.CurrentRow.Cells[1].Value.ToString();
            comboBox_TurGuncelle.Text = dataGridView_Kitap.CurrentRow.Cells[3].Value.ToString();
            txt_SayfaGuncelle.Text = dataGridView_Kitap.CurrentRow.Cells[2].Value.ToString();
            txt_YazarGuncelle.Text = dataGridView_Kitap.CurrentRow.Cells[4].Value.ToString();
        }

        private void btn_ktpbilgisi_Click(object sender, EventArgs e)
        {
            lbl_baslik.Text = "Kitap Listesi";
            lbl_not.Text = "İade bilgisini öğrenmek istediğiniz kitabın üzerine tıklayıp iade bilgisine basınız.";
            dataGridView_Kitap.DataSource = Kitap_BusinessLayer.kitapListele_BL();
        }

        private void btn_iadebilgi_Click(object sender, EventArgs e)
        {
            lbl_baslik.Text = "Kitap Iade Listesi";
            lbl_not.Text = "Not: Kitap listesine geri dönmek için kitap listesi butonuna basınız.";
            OgrenciKitapBilgileri kitap = new OgrenciKitapBilgileri();
            kitap.KitapId = id;
            dataGridView_Kitap.DataSource = KitapIade_BusinessLayer.KitapOgrenciListe_BL(kitap);
            textTemizle_g();
        }
        public void textTemizle_g()
        {// guncelle kısmındaki textboxların içerisini temizleyen fonksiyon
            txt_AdGuncelle.Text = "";
            comboBox_TurGuncelle.Text = null;
            txt_SayfaGuncelle.Text = "";
            txt_YazarGuncelle.Text = "";
        }
    }
}
