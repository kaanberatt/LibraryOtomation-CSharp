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
    public partial class Ogrenci_KitapAlBırak : Form
    {
        public Ogrenci_KitapAlBırak()
        {
            InitializeComponent();
        }

        private void pictureBox_OncekiForm_Click(object sender, EventArgs e)
        {
            Ogrenci_GirisForm ogrnc_giris = new Ogrenci_GirisForm();
            this.Hide();
            ogrnc_giris.Show();
        }

        private void pictureBox_CikisYap_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit(); // picturebox ın üzerine tıklayınca formu kapatır.
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Ogrenci_KitapArama kitapArama = new Ogrenci_KitapArama();
            kitapArama.Show();
            
        }
        private void pictureBox_Grafik_Click(object sender, EventArgs e)
        {
            Grafik_Form grafik = new Grafik_Form();
            
            grafik.Show();
        }
        public void OgrenciBilgileriGetir()  //Ogrencinin bilgilerinin tutulduğu fonksiyon
        {
            OgrenciBilgileri ogrenci = new OgrenciBilgileri();// OgrenciBilgilerinden nesne oluşturuldu
           
            ogrenci.OgrenciId = int.Parse(lbl_Id.Text);//Id bilgisi ogrenciId ' ye aktarıldı

            //Ogrenci bilgileri labellara aktarıldı
            ogrenci = Ogrenci_BusinessLayer.OgrenciIdBilgi_BL(ogrenci);
            lbl_Baslik.Text = "Hoşgeldin  " + ogrenci.OgrenciAd + ogrenci.OgrenciSoyad;
 
            lbl_ad.Text = ogrenci.OgrenciAd;
            lbl_soyad.Text = ogrenci.OgrenciSoyad;
            lbl_ogrNo.Text = ogrenci.OgrenciNo;
            lbl_Sifre.Text = ogrenci.OgrenciSifre;
            lbl_Cinsiyet.Text = ogrenci.OgrenciCinsiyet;
            lbl_Ceza.Text = (ogrenci.OgrenciCeza + " TL").ToString();
        }
        public void listeRenklendirme() //Tabloda teslim sürelerinin gecikme veya teslim edilme durumlarına göre renklendirme yapıldı
        {
            for (int i = 0; i < dataGridView_KitapListe.Rows.Count; i++) // Tablo satırı kadar döndürüldü
            {
                DataGridViewCellStyle renk = new DataGridViewCellStyle(); //Nesne oluşturuldu

                if (Convert.ToBoolean(dataGridView_KitapListe.Rows[i].Cells[4].Value) == true) // testlim edilme durumu kontrol edildi
                {
                    //Satır renklendirildi
                    renk.BackColor = Color.Green;
                    renk.ForeColor = Color.White;
                }

                else
                {
                    //Teslim edilmeyen kitapların teslim tarihine ne kadar kaldığı öğrenildi
                    TimeSpan sonuc = DateTime.Now - Convert.ToDateTime(dataGridView_KitapListe.Rows[i].Cells[3].Value);

                    // 15 gün ve üzeri ise satır kırmızı renk yapıldı
                    if (sonuc.TotalDays > 15)
                    {
                        renk.BackColor = Color.Red;
                    }

                    // teslim süresine 2 gün kalmış ise satır sarı yapıldı
                    if (sonuc.TotalDays >= 13 && sonuc.TotalDays <= 15)
                    {
                        renk.BackColor = Color.Yellow;
                    }
                }
                dataGridView_KitapListe.Rows[i].DefaultCellStyle = renk; // Satırlara renklendirme işlemi gerçekleştirildi

            }
        }
        private void Ogrenci_KitapAlBırak_Load(object sender, EventArgs e)
        {
            OgrenciBilgileriGetir(); // Ogrenci bilgilerinin tutulduğu fonksiyon çağrıldı

            AlınanKitapBilgileri alınanKitap = new AlınanKitapBilgileri();
            alınanKitap.OgrenciId = int.Parse(lbl_Id.Text); // AlınanKitapBilgilerinden yeni nesne oluşturuldu ve OgrenciId
                                                            // atama yapıldı 

            dataGridView_KitapListe.DataSource = KitapIade_BusinessLayer.OgrenciIdListe_BL(alınanKitap);
            // Form açıldığında datagrid üzerine veritabanındaki listeyi aktardık

            // Bir sütunu gizledik ve diğer sütunların başlıklarını düzenledik
            dataGridView_KitapListe.Columns[0].Visible = false;
            dataGridView_KitapListe.Columns[1].HeaderText = "Kitap Adı";
            dataGridView_KitapListe.Columns[2].HeaderText = "Teslim Tarihi";
            dataGridView_KitapListe.Columns[3].HeaderText = "Alınma Tarihi";
            dataGridView_KitapListe.Columns[4].HeaderText = "Teslim Edilmiş mi ?";

            KitapIadeBilgileri iade = new KitapIadeBilgileri();  // nesne oluşturuldu

            iade.OgrenciId = int.Parse(lbl_Id.Text);// id ataması yapıldı

            comboBox_Alinan.DataSource = KitapIade_BusinessLayer.KitapAlinanListe_BL(iade); //Combobox'a alinabilicek kitaplar aktarıldı.
            comboBox_Teslim.DataSource = KitapIade_BusinessLayer.KitapTeslimListe_BL(iade); // Combobox'a teslim edilecek kitaplar aktarıldı.
            listeRenklendirme();  // Tablodaki satırları renklendirme fonksiyounu çağrıldı
        }

        


        private void btn_kitapAl_Click(object sender, EventArgs e)
        {

            if (comboBox_Alinan.Text != "") //Text in doluluğu kontrol edildi
            {

                TimeSpan gecenSure = DateTime.Now - dateTimePicker_Alim.Value.Date; //zaman farkı alındı
                if (gecenSure.TotalDays >= 0)  // Şuanki günden ileri olup olmadığı kontrol edildi
                {

                    OgrenciKitapBilgileri kitapbilgi = new OgrenciKitapBilgileri();//nesne oluşturuldu
                    kitapbilgi.KitapAd = comboBox_Alinan.Text;//Kitap adı aktarıldı

                    KitapIadeBilgileri kitapiade = new KitapIadeBilgileri(); // nesne oluşturuldu

                    kitapiade.KitapId = KitapIade_BusinessLayer.KitapId_BL(kitapbilgi); // kitap id aktarıldı
                    kitapiade.OgrenciId = int.Parse(lbl_Id.Text);  // ogrenci id aktarıldı
                    kitapiade.KitabinAlinmaTarihi = dateTimePicker_Alim.Value.Date; // alinma tarihi aktarıldı


                    KitapIade_BusinessLayer.KitapAlim_BL(kitapiade); // Veri tabanından alma işlemi gerçekleştirildi


                    //Güncel liste oluştruuldu
                    AlınanKitapBilgileri alinanKitap = new AlınanKitapBilgileri();
                    alinanKitap.OgrenciId = int.Parse(lbl_Id.Text);

                    dataGridView_KitapListe.DataSource = KitapIade_BusinessLayer.OgrenciIdListe_BL(alinanKitap);
                    listeRenklendirme();

                    //güncel kitaplar oluşturuldu
                    KitapIadeBilgileri iade = new KitapIadeBilgileri();

                    iade.OgrenciId = int.Parse(lbl_Id.Text);

                    comboBox_Alinan.DataSource = KitapIade_BusinessLayer.KitapAlinanListe_BL(iade);
                    comboBox_Teslim.DataSource = KitapIade_BusinessLayer.KitapTeslimListe_BL(iade);

                    MessageBox.Show("Kitap alındı.");

                }
                else
                {
                    MessageBox.Show("Alım tarihi bugünden ileri bir tarih olamaz !");
                }
            }

            else
            {
                MessageBox.Show("Alınabilir kitap mevcut değil.");
            }
        }

        private void txtOdeme_KeyPress(object sender, KeyPressEventArgs e)
        {
            //textboxuna harf girisini engelleme
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnOdeme_Click(object sender, EventArgs e)
        {
            if (txtOdeme.Text != "")  // text doluluğu kontrol edildi
            {
                KitapIadeBilgileri ogrenci = new KitapIadeBilgileri();  // nesne oluşturuldu

                ogrenci.OgrenciId = int.Parse(lbl_Id.Text); //id ataması yapıldı

                KitapIade_BusinessLayer.OgrenciCeza_BL(ogrenci); // Ceza bilgisi çekildi
                if (ogrenci.OgrenciCeza != 0)  // ceza durumu 0 değil ise...
                {
                    float ceza = ogrenci.OgrenciCeza - float.Parse(txtOdeme.Text); //ceza farkı atandı
                    if (ceza >= 0)  // cezanın eksi olmaması kontrol edildi
                    {
                        ogrenci.OgrenciCeza = ceza; // Ogrenci cezasına aktarıldı
                        KitapIade_BusinessLayer.OgrenciCezaIslemi_BL(ogrenci); //veri tabanı ile işlem gerçekleşti
                        OgrenciBilgileriGetir(); //Güncel liste çağrıldı
                        MessageBox.Show(txtOdeme.Text + " Tl ödendi.");
                        txtOdeme.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("Ödenecek tutar cezadan büyük olamaz!");
                    }
                }

                else
                {
                    MessageBox.Show("Borcunuz Bulunmamaktadır.");
                    txtOdeme.Text = "";
                }
            }
        }

        private void btn_teslim_Click(object sender, EventArgs e)
        {


            if (comboBox_Teslim.Text != "")  // text doluluğu kontrol edildi
            {

                OgrenciKitapBilgileri kitapOgr = new OgrenciKitapBilgileri(); // nesne oluşturuldu

                kitapOgr.KitapAd = comboBox_Teslim.Text;//kitap adı aktarıldı
                KitapIadeBilgileri kitap = new KitapIadeBilgileri();// nesne oluşturuldu ve bilgiler aktarıldı

                kitap.KitapId = KitapIade_BusinessLayer.KitapId_BL(kitapOgr);
                kitap.OgrenciId = int.Parse(lbl_Id.Text);
                kitap.KitapTeslimi = dateTimePicker_Teslim.Value.Date;
                kitap.KitapKontrol = true;

                KitapIade_BusinessLayer.KitapTarihi_BL(kitap); //alinma tarihi çekildi
                TimeSpan sonuc = kitap.KitapTeslimi - kitap.KitabinAlinmaTarihi; // zaman farkı alındı
                if (sonuc.TotalDays >= 0) //zaman farkını eksi olamaması kontrol edildi
                {
                    KitapIade_BusinessLayer.KitapTeslimi_BL(kitap); //teslim işlemi gerçekleştirildi

                    //Güncel liste
                    AlınanKitapBilgileri alinanKitap = new AlınanKitapBilgileri();
                    alinanKitap.OgrenciId = int.Parse(lbl_Id.Text);

                    dataGridView_KitapListe.DataSource = KitapIade_BusinessLayer.OgrenciIdListe_BL(alinanKitap);
                    listeRenklendirme();  // tablo satırları renklendirildi

                    //Güncel  Kitap
                    KitapIadeBilgileri iade = new KitapIadeBilgileri();

                    iade.OgrenciId = int.Parse(lbl_Id.Text);

                    comboBox_Alinan.DataSource = KitapIade_BusinessLayer.KitapAlinanListe_BL(iade);
                    comboBox_Teslim.Text = "";
                    comboBox_Teslim.DataSource = KitapIade_BusinessLayer.KitapTeslimListe_BL(iade);

                    if (sonuc.TotalDays > 15)  // teslim süresi 15 günü geçmiş ise ceza işlemi uygulandı
                    {
                        float ceza = float.Parse(sonuc.TotalDays.ToString()) - 15;  //15 gün teslim süresini aşanlara hergün için 1 tl kesildi   
                        KitapIade_BusinessLayer.OgrenciCeza_BL(iade); //Ceza bilgisi çekildi
                        iade.OgrenciCeza += ceza; //üzerine ekleme yapıldı
                        KitapIade_BusinessLayer.OgrenciCezaIslemi_BL(iade); // Veri tabanında ceza işlemi gerçekleşti
                        OgrenciBilgileriGetir(); // Güncel liste 
                        if (ceza > 0)
                        {
                            MessageBox.Show("Cezanız " + iade.OgrenciCeza + " TL dir. Lüfen ödemeyi unutmayınız");
                        }
                    }
                    MessageBox.Show("Teslim edildi");

                }

                else
                {

                    MessageBox.Show("Teslim tarihi alım tarihinden önce olamaz!");
                }


            }
            else
            {
                MessageBox.Show("Teslim edilecek kitabın yok !");
            }

        }

       
    }
}
