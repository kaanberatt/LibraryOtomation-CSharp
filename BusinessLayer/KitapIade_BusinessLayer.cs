using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using DataAccessLayer;
namespace BusinessLayer
{
    public class KitapIade_BusinessLayer
    {
        // DAL katmanı kullanılarak kitap id ye ait ogrenci verileri çekildi
        public static List<OgrenciKitapBilgileri> KitapOgrenciListe_BL(OgrenciKitapBilgileri kitap)
        {
            if (kitap.KitapId != 0)
                return KitapIade_DataAccessLayer.KitapOgrenciListe(kitap);
            else
                return null;
        }

        // Kitap adı ile kitap Id bilgisi DAL katmanı kullanılarak int döndürüldü
        public static int KitapId_BL(OgrenciKitapBilgileri kitap)
        {
            if (kitap.KitapAd != "")
            {

                return KitapIade_DataAccessLayer.KitapId(kitap);
            }

            else
                return -1;
        }

        //Kitap alma işlemi DAL katmanı kullanılarak gerçekleştirildi
        public static int KitapAlim_BL(KitapIadeBilgileri kitap)
        {
            if (kitap.KitapId != 0 && kitap.OgrenciId != 0 && kitap.KitabinAlinmaTarihi != null)
            {

                return KitapIade_DataAccessLayer.KitapAlim(kitap);
            }

            else
                return -1;
        }

        // Id ile öğrencini almış olduğu kitaplar tarihsel bir şekilde  DAL katmanı kullanılarak listelendi
        public static List<AlınanKitapBilgileri> OgrenciIdListe_BL(AlınanKitapBilgileri kitap)
        {
            return KitapIade_DataAccessLayer.OgrenciIdListe(kitap);
        }

        //Ogrencinin aldiği kitaplar DAL katmanı kullanılarak listelendi
        public static List<string> KitapAlinanListe_BL(KitapIadeBilgileri kitap)
        {
            return KitapIade_DataAccessLayer.KitapAlinanListe(kitap);
        }

        //Ogrencinin teslim etmesi gereken kitaplar DAL katmanı kullanılarak listelendi
        public static List<string> KitapTeslimListe_BL(KitapIadeBilgileri kitap)
        {

            return KitapIade_DataAccessLayer.KitapTeslimListe(kitap);
        }

        // Ogrenciye ait ceza bilgisini  DAL katmanını kullanrak öğrendik
        public static List<string> OgrenciCeza_BL(KitapIadeBilgileri kitap)
        {

            return KitapIade_DataAccessLayer.OgrenciCeza(kitap);
        }

        //Öğrenciye ait güncel ceza DAL katmanı kullanılarak eklendi
        public static int OgrenciCezaIslemi_BL(KitapIadeBilgileri ogrenci)
        {
            if (ogrenci.OgrenciCeza >= 0)
            {

                return KitapIade_DataAccessLayer.OgrenciCezaIslemi(ogrenci);
            }

            else
                return -1;
        }
        //kitabın Alinma tarihini DAL katmanı kullanarak öğrendik
        public static List<string> KitapTarihi_BL(KitapIadeBilgileri kitap)
        {

            return KitapIade_DataAccessLayer.KitapTarihi(kitap);
        }

        //Kitap teslim etme işlemi DAL katmanı kullanılarak gerçekleştirildi
        public static int KitapTeslimi_BL(KitapIadeBilgileri kitap)
        {
            if (kitap.KitapId != 0)
            {

                return KitapIade_DataAccessLayer.KitapTeslimi(kitap);
            }

            else
                return -1;
        }

        // öğrenciye ait alinabilir kitaplarin sayisi DAL katmanı kullanılarak int döndürüldü
        public static int GrafikAlinabilir_BL(KitapIadeBilgileri kitap)
        {
            if (kitap.OgrenciId != 0)
            {
                return KitapIade_DataAccessLayer.GrafikAlinabilir(kitap);
            }
            return 0;
        }

        // öğrenciye ait almış olduğu kitaplarin sayisi DAL katmanı kullanılarak int döndürüldü
        public static int GrafikVerilmis_BL(KitapIadeBilgileri kitap)
        {
            if (kitap.OgrenciId != 0)
            {
                return KitapIade_DataAccessLayer.GrafikVerilmis(kitap);
            }
            return 0;
        }

        // Tüm kitapların sayisi DAL katmanı kullanılarak int döndürüldü
        public static int GrafikHepsi_BL()
        {
            return KitapIade_DataAccessLayer.GrafikHepsi();
        }
    }
}
