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
using PresentationLayer;
namespace KutuphaneOtomasyonu
{
    public partial class Ogrenci_KitapArama : Form
    {
        public Ogrenci_KitapArama()
        {
            InitializeComponent();
        }

        private void pictureBox_OncekiForm_Click(object sender, EventArgs e)
        {
            Ogrenci_KitapAlBırak ogrenci_KitapAlBırak = new Ogrenci_KitapAlBırak();
            ogrenci_KitapAlBırak.Show();
            this.Hide();
        }

        private void pictureBox_CikisYap_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void Ogrenci_KitapArama_Load(object sender, EventArgs e)
        {
            
            dataGridView_KitapListesi.DataSource = Kitap_BusinessLayer.kitapListele_BL(); // Form açıldığında datagrid üzerine veritabanındaki listeyi aktardık
            //Bazı sütunların tabloda görünümünü kapattık
            dataGridView_KitapListesi.Columns[2].Visible = false;
            dataGridView_KitapListesi.Columns[3].Visible = false;
            dataGridView_KitapListesi.Columns[4].Visible = false;
        }

        private void txt_Id_KeyPress(object sender, KeyPressEventArgs e)
        {
            //textboxuna harf girisini engelleme
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void dataGridView_KitapListesi_SelectionChanged(object sender, EventArgs e)
        {
            txt_Id.Text = dataGridView_KitapListesi.CurrentRow.Cells[0].Value.ToString();

        }

        private void btn_KitapGoster_Click(object sender, EventArgs e)
        {
            if (txt_Id.Text != "")  //text doluluğu kontrol edildi
            {
                KitapBilgileri kitap = new KitapBilgileri();  //Kitap veriden nesne oluşturuldu
                kitap.KitapId = int.Parse(txt_Id.Text);  // Id aktarıldı
                

                kitap = Kitap_BusinessLayer.kitapIdBilgi_BL(kitap);  // Id bilgisi nesneye aktarıldı
                lbl_KitapAd.Text = kitap.KitapAd;
                lbl_KitapTuru.Text = kitap.KitapTuru;
                lbl_KitapSayfa.Text = kitap.KitapSayfa;
                lbl_KitapYazar.Text = kitap.KitapYazar;

                Ogrenci_KitapAlBırak ogr_id = new Ogrenci_KitapAlBırak();
                OgrenciKitapBilgileri kitapogrenci = new OgrenciKitapBilgileri();  // Kitap öğrenci veriden nesne oluşturuldu

                kitapogrenci.KitapId = int.Parse(ogr_id.lbl_Id.Text);  // Kitap ıd 'si aktarıldı
                

                if (Kitap_BusinessLayer.KitapSorgu_BL(kitap) != false)  // Kitabın mevcut olup olmadığı kontrol edildi
                {
                   
                }

                else
                    MessageBox.Show("Girilen id'ye ait kitap mevcut değil !");
            }

            else
                MessageBox.Show("Lütfen kitap id giriniz");
        }
    }
}
