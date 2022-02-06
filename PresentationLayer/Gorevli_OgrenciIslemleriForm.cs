using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLayer;
using Entity;
namespace KutuphaneOtomasyonu
{
    public partial class Gorevli_OgrenciIslemleriForm : Form
    {
        public Gorevli_OgrenciIslemleriForm()
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

        private void Ogrenci_IslemForm_Load(object sender, EventArgs e)
        {
            Data_OgrListe.DataSource = Ogrenci_BusinessLayer.Listele(); // Form açıldığında datagrid üzerine veritabanındaki listeyi aktardık
            // Tablodaki görünümü iyileştirmek için genişliğini ayarladık ve isimlerini düzenledik.
            
            //Data_OgrListe.Columns[0].HeaderText = "Id";
            //Data_OgrListe.Columns[1].HeaderText = "Ad";
            //Data_OgrListe.Columns[2].HeaderText = "Soyad";
            //Data_OgrListe.Columns[3].HeaderText = "Öğrenci No";
            //Data_OgrListe.Columns[4].HeaderText = "Sifre";
            //Data_OgrListe.Columns[5].HeaderText = "Cinsiyet";
            //Data_OgrListe.Columns[6].HeaderText = "Ceza";

            // sütunlara index değerleri verdik
            Data_OgrListe.Columns["OgrenciId"].DisplayIndex = 0;
            Data_OgrListe.Columns["OgrenciAd"].DisplayIndex = 1;           
            Data_OgrListe.Columns["OgrenciSoyad"].DisplayIndex = 2;
            Data_OgrListe.Columns["OgrenciCinsiyet"].DisplayIndex = 5;

            
        }

        private void btn_OgrEkle_Click(object sender, EventArgs e)
        {
            //Ekleme işlemi için textboxların dolu olup olmadığını kontrol ettik
            if (txt_EkleAd.Text != "" && txt_EkleSoyad.Text != "" && txt_EkleNo.Text != "" && txt_EkleSifre.Text != "" && comboBox_EkleCins.Text != "")
            {
                //Entity katmanındaki değişkenlere textboxtaki verileri aktardık
                OgrenciBilgileri ogrenci = new OgrenciBilgileri();

                ogrenci.OgrenciAd = txt_EkleAd.Text;
                ogrenci.OgrenciSoyad = txt_EkleSoyad.Text;
                ogrenci.OgrenciNo = txt_EkleNo.Text;
                ogrenci.OgrenciSifre = txt_EkleSifre.Text;
                ogrenci.OgrenciCinsiyet = comboBox_EkleCins.Text;

                
                if (Ogrenci_BusinessLayer.OgrenciNoKontrol_BL(ogrenci) == true)  // Öğrencinin kayıtlı olma durumu kontrol edildi
                {

                    Ogrenci_BusinessLayer.ogrenciEkle_BL(ogrenci);  //business katmanındaki ogrenciEkle fonksiyonuna verileri gönderdik
                    MessageBox.Show("Eklendi");
                    Data_OgrListe.DataSource = Ogrenci_BusinessLayer.Listele(); // Ekleme işleminden sonra listenin güncel halini ekrana yansıttık

                    //Ekleme işlemi bitince textboxları temizledik
                    txt_EkleAd.Text = "";
                    txt_EkleSoyad.Text = "";
                    txt_EkleNo.Text = "";
                    txt_EkleSifre.Text = "";
                    comboBox_EkleCins.Text = null;
                }

                else
                {
                    MessageBox.Show("Girilen öğrenci numarası başka öğrenciye aittir. Lütfen girilen öğrenci numarasını değiştiriniz!");
                    txt_EkleNo.Text = "";
                }
            }

            else
            {
                MessageBox.Show("Lütfen gerekli alanları doldurunuz");
            }
        }

        private void btn_OgrSil_Click(object sender, EventArgs e)
        {
            //Id nin girilmesini kontrol ettik
            if (txt_IdSil.Text != "")
            {
                //Entity katmanındaki OgrenciId değişkenine textboxtaki veriyi aktardık
                OgrenciBilgileri ogrenci = new OgrenciBilgileri();
                ogrenci.OgrenciId = int.Parse(txt_IdSil.Text);
                

                //Girilen id ye ait ogrenci kontrol edildi
                if (Ogrenci_BusinessLayer.ogrenciSorgu_BL(ogrenci) == true)
                {
                    Ogrenci_BusinessLayer.ogrenciSil_BL(ogrenci); // Business katmanındaki ogrenciSİL Fonksiyonuna silme işlemi için verileri gönderdik
                    MessageBox.Show("Silindi");
                    Data_OgrListe.DataSource = Ogrenci_BusinessLayer.Listele();// Lİstenin Son Hali DataGrid' e aktarıldı.
                    txt_IdSil.Text = ""; // Silme işleminden sonra textbox ı temizledik
                }
                else 
                {
                    MessageBox.Show("Girdiğiniz ID Bulunamadı !!");
                }

            }
            else
                MessageBox.Show("Gerekli alanları doldurunuz !!");
        }
        //id yi genel olarak kullanacağım için global tanımladım.
        int id;
        string ilkNo;
        private void Data_OgrListe_SelectionChanged(object sender, EventArgs e)
        {
            //Tablo üzerinde tıklanan satırın verilerini guncelleme alanındaki textboxlara yazdırdık
            id = int.Parse(Data_OgrListe.CurrentRow.Cells[0].Value.ToString());
            txt_AdGuncelle.Text = Data_OgrListe.CurrentRow.Cells[4].Value.ToString();
            txt_SoyadGuncelle.Text = Data_OgrListe.CurrentRow.Cells[5].Value.ToString();
            txt_NoGuncelle.Text = Data_OgrListe.CurrentRow.Cells[1].Value.ToString();
            txt_SifreGuncelle.Text = Data_OgrListe.CurrentRow.Cells[2].Value.ToString();
            comboBox_CinsiGuncelle.Text = Data_OgrListe.CurrentRow.Cells[6].Value.ToString();
            ilkNo = txt_NoGuncelle.Text;
        }

        private void btn_OgrGuncelle_Click(object sender, EventArgs e)
        {
            //Güncelleme işlemi için textboxların dolu olup olmadığını kontrol ettik
            if (txt_AdGuncelle.Text != "" && txt_SoyadGuncelle.Text != "" && txt_NoGuncelle.Text != "" && txt_SifreGuncelle.Text != "" && comboBox_CinsiGuncelle.Text != "")
            {
                //Entity katmanındaki değişkenlere textboxtaki verileri aktardık
                OgrenciBilgileri ogrenci = new OgrenciBilgileri();

                ogrenci.OgrenciAd = txt_AdGuncelle.Text;
                ogrenci.OgrenciSoyad = txt_SoyadGuncelle.Text;
                ogrenci.OgrenciNo = txt_NoGuncelle.Text;
                ogrenci.OgrenciSifre = txt_SifreGuncelle.Text;
                ogrenci.OgrenciCinsiyet = comboBox_CinsiGuncelle.Text;
                ogrenci.OgrenciId = id;
                
                // Girilen id ye ait ogrenci kontrol edildi
                if (Ogrenci_BusinessLayer.ogrenciSorgu_BL(ogrenci) == true)
                {
                    if (Ogrenci_BusinessLayer.OgrenciNoKontrol_BL(ogrenci) == true || ilkNo == ogrenci.OgrenciNo.ToString())
                    {
                        Ogrenci_BusinessLayer.OgrenciGuncelle_BL(ogrenci);// Business katmanındaki ogrenciGuncelle Fonksiyonuna guncelleme işlemi için verileri gönderdik
                        MessageBox.Show("Guncellendi");
                        Data_OgrListe.DataSource = Ogrenci_BusinessLayer.Listele();// Lİstenin güncel halini datagridview' a yansıttık

                        //Güncelleme işlemi bitince textboxları temizledik
                        txt_AdGuncelle.Text = "";
                        txt_SoyadGuncelle.Text = "";
                        txt_NoGuncelle.Text = "";
                        txt_SifreGuncelle.Text = "";
                        comboBox_CinsiGuncelle.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("Girilen öğrenci numarası başka öğrenciye aittir. Lütfen girilen öğrenci numarasını değiştiriniz!");
                    }

                }

                else
                    MessageBox.Show("Lütfen listeden seçim yaptıktan sonra değerleri doldurunuz !");
            }

            else
            {
                MessageBox.Show("Lütfen gerekli alanları doldurunuz");
            }
        }

        private void txt_EkleNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            //textbox'a harf girisini engelleme
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txt_IdSil_KeyPress(object sender, KeyPressEventArgs e)
        {
            //textboxuna harf girisini engelleme
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox6_KeyPress(object sender, KeyPressEventArgs e)
        {
            //textboxuna harf girisini engelleme
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        
    }
}
