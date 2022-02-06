using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZedGraph;//ZedGraph özelliklerini kullanabilmek için kütüphanesini ekledik
using BusinessLayer;           //Referans aldığımız BL katmanını kullandık
using Entity;       // Referans aldığımız Entity katmanını kullandık    
namespace KutuphaneOtomasyonu
{
    public partial class Grafik_Form : Form
    {
        public Grafik_Form()
        {
            InitializeComponent();
        }
        private void Grafik()  // Grafik fonksiyon oluşturuldu
        {
            KitapIadeBilgileri kitapiade = new KitapIadeBilgileri();  //  KitapIadeBilgileri Entity katmanındaki Ogrenci ıd ye değer ataması yapıldı

            Ogrenci_KitapAlBırak ogr_id = new Ogrenci_KitapAlBırak();

            kitapiade.OgrenciId = int.Parse(ogr_id.lbl_Id.Text);


            GraphPane myPane = grafikKitap.GraphPane;       // GraphPane nesne oluşturuldu
            myPane.Title.Text = "Öğrenci Kitap Grafiği";   // Grafik Başlığı yazıldı
            myPane.YAxis.Title.Text = "Kitap Sayısı";     // Y ekseninin ne olduğu yazıldı
            myPane.XAxis.Title.Text = "";
            double[] y1 = { KitapIade_BusinessLayer.GrafikAlinabilir_BL(kitapiade) };  // y1 sütununa alınabilecek kitap sayısı aktarıldı
            double[] y2 = { KitapIade_BusinessLayer.GrafikVerilmis_BL(kitapiade) };   // y2 sütununa alınabilecek kitap sayısı aktarıldı
            double[] y3 = { KitapIade_BusinessLayer.GrafikHepsi_BL() };          // y3 sütununa alınabilecek kitap sayısı aktarıldı

            BarItem myBar = myPane.AddBar("Alınabilir Kitap Sayısı", null, y1, Color.Green); // y1 sütununun adı ve renk ataması yapıldı
            myBar.Bar.Fill = new Fill(Color.Green, Color.White, Color.Green);

            myBar = myPane.AddBar("İade Edilmemiş Kitap Sayısı", null, y2, Color.Red);            // y2 sütununun adı ve renk ataması yapıldı
            myBar.Bar.Fill = new Fill(Color.Red, Color.White, Color.Red);

            myBar = myPane.AddBar("Tüm Kitap Sayısı", null, y3, Color.Orange);              // y3 sütununun adı ve renk ataması yapıldı
            myBar.Bar.Fill = new Fill(Color.Orange, Color.White, Color.Orange);

            myPane.XAxis.MajorTic.IsBetweenLabels = true;
            myPane.XAxis.Type = AxisType.Text;
            myPane.Chart.Fill = new Fill(Color.White,
                  Color.FromArgb(255, 255, 166), 90F);
            myPane.Fill = new Fill(Color.FromArgb(250, 250, 255));
            grafikKitap.AxisChange();

        }

        private void pictureBox_CikisYap_Click(object sender, EventArgs e)
        {
            this.Hide();// picturebox ın üzerine tıklayınca formu kapatır

        }

        private void pictureBox_OncekiForm_Click(object sender, EventArgs e)
        {
            Ogrenci_KitapAlBırak ogrenci_KitapAlBırak = new Ogrenci_KitapAlBırak();
            this.Hide();
            ogrenci_KitapAlBırak.Show();
        }

        private void Grafik_Form_Load(object sender, EventArgs e)
        {
            Grafik();
        }
    }
}
