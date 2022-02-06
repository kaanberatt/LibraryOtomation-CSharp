using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using DataAccessLayer;

namespace BusinessLayer
{
    public class Kitap_BusinessLayer
    {
        //Kitap bilgilerinin olduğu liste Kitap_DataAccessLayer katmanı kullanılarak aktarıldı
        public static List<KitapBilgileri> kitapListele_BL()
        {

            return Kitap_DataAccessLayer.KitapListele();
        }
        //Kitap ekleme işlemi Kitap_DataAccessLayer katmanı kullanılarak gerçekleştirildi
        public static int KitapEkle_BL(KitapBilgileri kitapbilgi)
        {
            if (kitapbilgi.KitapAd != "" && kitapbilgi.KitapTuru != "" && kitapbilgi.KitapSayfa != "" && kitapbilgi.KitapYazar != "")
            {

                return Kitap_DataAccessLayer.KitapEkle(kitapbilgi);
            }

            else
                return -1;
        }
        //Girilen KitapId' ye ait kitap veri tabanında kayıtlı mı diye Kitap_DataAccessLayer katmanı kullanılarak kontrol edildi
        public static bool KitapSorgu_BL(KitapBilgileri kitapbilgi)
        {
            if (kitapbilgi.KitapId != 0) // Gelen verilerin boş olmadığı kontrol edildi
            {
                return Kitap_DataAccessLayer.KitapSorgu(kitapbilgi); // Veritabanından girilen değerlere ait kitap kontrol edildi
            }

            else                    //Eğer gelen veri boş ise false döndürdü
                return false;
        }

       
        public static int KitapSil_BL(KitapBilgileri kitapbilgi)
        {
            if (kitapbilgi.KitapId != 0) // gelen kitap bilgisinin id si 0 değilse Kitap_DataAccessLayer katmanına yönlendirilir.
            {
                return Kitap_DataAccessLayer.KitapSil(kitapbilgi);
            }

            else
                return -1;
        }

        // Id' ye kitap Kitap_DataAccessLayer katmanı kullanılarak güncellendi
        public static int KitapGuncelle_BL(KitapBilgileri kitapbilgi)
        {
            if (kitapbilgi.KitapId !=0 && kitapbilgi.KitapAd != "" && kitapbilgi.KitapTuru != "" && kitapbilgi.KitapSayfa != "" && kitapbilgi.KitapYazar != "")
            {

                return Kitap_DataAccessLayer.KitapGuncelle(kitapbilgi);
            }

            else
                return -1;
        }

        // DAL katmanı kullanılarak Kitap id ile kitap bilgileri çekildi
        public static KitapBilgileri kitapIdBilgi_BL(KitapBilgileri kitap)
        {
            if (kitap.KitapId != 0) // Gelen verilerin boş olmadığı kontrol edildi
            {
                return Kitap_DataAccessLayer.kitapIdBilgi(kitap); // Veritabanından girilen değerlere ait öğrenci kontrol edildi
            }

            else                    //Eğer gelen veri boş ise false döndürdü
                return null;
        }
    }
}
