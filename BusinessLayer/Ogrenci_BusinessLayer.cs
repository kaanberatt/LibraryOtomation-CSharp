using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using DataAccessLayer;

namespace BusinessLayer
{
    public class Ogrenci_BusinessLayer
    {
        public static bool ogrenciKontrol_BL(OgrenciBilgileri ogrenci)
        {
            if (ogrenci.OgrenciNo != "" && ogrenci.OgrenciSifre != "") // Gelen verilerin boş olmadığı kontrol edildi
                return Ogrenci_DataAccessLayer.ogrenciKontrol(ogrenci); // Veritabanından girilen değerlere ait öğrenci kontrol edildi

            else //Eğer gelen veri boş ise false döndürdü
                return true;
        }

        public static List<OgrenciBilgileri> Listele()
        {
            return Ogrenci_DataAccessLayer.Listele();
        }

        //Girilen öğrenci bilgileri DataAccess katmanı kullanılarak veritabanına eklendi
        public static int ogrenciEkle_BL(OgrenciBilgileri ogrenci)
        {
            if (ogrenci.OgrenciAd != "" && ogrenci.OgrenciSoyad != "" && ogrenci.OgrenciNo != "" && ogrenci.OgrenciSifre != "" && ogrenci.OgrenciCinsiyet != "")
            {

                return Ogrenci_DataAccessLayer.ogrenciEkle(ogrenci);
            }

            else
                return -1;
        }
        public static bool OgrenciNoKontrol_BL(OgrenciBilgileri ogrenci)
        {
            if (ogrenci.OgrenciNo != "") // Gelen verilerin boş olmadığı kontrol edildi
            {
                return Ogrenci_DataAccessLayer.OgrenciNoKontrol(ogrenci); // Veritabanından girilen değerlere ait öğrenci kontrol edildi
            }

            else                    //Eğer gelen veri boş ise false döndürdü
                return false;
        }
        
        public static bool ogrenciSorgu_BL(OgrenciBilgileri ogrenci)
        {
            if (ogrenci.OgrenciId !=0)
            {
                return Ogrenci_DataAccessLayer.OgrenciSorgu(ogrenci);
            }
            else
                return false;
        }
        
        public static int ogrenciSil_BL(OgrenciBilgileri ogrenci)
        {
            if (ogrenci.OgrenciId != 0)
            {
                return Ogrenci_DataAccessLayer.OgrenciSil(ogrenci);
            }
            else
                return -1;
        }
        public static int OgrenciGuncelle_BL(OgrenciBilgileri ogrenci)
        {
            if (ogrenci.OgrenciId!=0)
            {
                return Ogrenci_DataAccessLayer.OgrenciGuncelle(ogrenci);
            }
            else
                return -1;
        }
        public static OgrenciBilgileri OgrenciIdBilgi_BL(OgrenciBilgileri ogrenci)
        {
            if (ogrenci.OgrenciId != 0) // Gelen verilerin boş olmadığı kontrol edildi
            {
                return Ogrenci_DataAccessLayer.OgrenciIdBilgi(ogrenci); // Veritabanından girilen değerlere ait öğrenci kontrol edildi
            }

            else                    //Eğer gelen veri boş ise NULL döndürdü
                return null;
        }


        public static int OgrenciIdSorgu_BL(OgrenciBilgileri ogrenci)
        {
            if (ogrenci.OgrenciNo != "" && ogrenci.OgrenciSifre != "") // Gelen verilerin boş olmadığı kontrol edildi
            {
                return Ogrenci_DataAccessLayer.OgrenciIdSorgu(ogrenci); // Veritabanından girilen değerlere ait öğrenci kontrol edildi
            }

            else                    //Eğer gelen veri boş ise false döndürdü
                return -1;
        }
    }
}
