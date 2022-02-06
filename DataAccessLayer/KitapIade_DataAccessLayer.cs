using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using DataAccessLayer;
using System.Data.OleDb;
namespace DataAccessLayer
{
    public class KitapIade_DataAccessLayer
    {
        //Kitabı alanların detaylı listesini inner join yöntemi ile 3 tablodan verilerini çekerek aldık
        public static List<OgrenciKitapBilgileri> KitapOgrenciListe(OgrenciKitapBilgileri kitap)
        {
            OleDbCommand command = new OleDbCommand("Select k.KitapId,o.OgrenciAd,o.OgrenciSoyad,k.KitapAd,kk.KitapAlinmaTarihi,kk.KitapTeslimTarihi,kk.KitapKontrol from ((Kitap k inner join KitapKayit kk on k.KitapId=kk.KitapId) inner join Ogrenci o on o.OgrenciId=kk.OgrenciId) where k.KitapId = @KitapId", Baglanti.baglanti);
            Baglanti.Baglan(command);
            command.Parameters.AddWithValue("@KitapId", kitap.KitapId);
            OleDbDataReader read = command.ExecuteReader();
            List<OgrenciKitapBilgileri> kitapOgrenci = new List<OgrenciKitapBilgileri>();

            while (read.Read()) // Verileri okuyoruz
            {
                kitapOgrenci.Add(new OgrenciKitapBilgileri
                {
                    KitapId = int.Parse(read["KitapId"].ToString()),
                    OgrenciAd = read["OgrenciAd"].ToString(),
                    OgrenciSoyad = read["OgrenciSoyad"].ToString(),
                    KitapAd = read["KitapAd"].ToString(),
                    KitapAlinmaTarihi = DateTime.Parse(read["KitapAlinmaTarihi"].ToString()),
                    KitapTeslim = read["KitapTeslimTarihi"].ToString(),
                    KitapKontrol = bool.Parse(read["KitapKontrol"].ToString())
                });
            }

            return kitapOgrenci;
        }


        //Kitap adı sorgusu ile ada ait kitapId verisi int döndürüldü
        public static int KitapId(OgrenciKitapBilgileri kitap)
        {
            OleDbCommand command = new OleDbCommand("Select KitapId from Kitap where KitapAd=@KitapAd", Baglanti.baglanti);
            Baglanti.Baglan(command);
            command.Parameters.AddWithValue("@KitapAd", kitap.KitapAd);
            OleDbDataReader read = command.ExecuteReader();

            int id = 0;
            while (read.Read()) // Verileri okuyoruz
            {

                id = int.Parse(read["KitapId"].ToString());
            }
            return id;
        }

        //Kitap alındğında veri tabanına veriler eklendi
        public static int KitapAlim(KitapIadeBilgileri kitap)
        {
            OleDbCommand command = new OleDbCommand("insert into  KitapKayit(KitapId,OgrenciId,KitapAlinmaTarihi) values(@KitapId,OgrenciId,@KitapAlinmaTarihi)", Baglanti.baglanti);
            Baglanti.Baglan(command);
            command.Parameters.AddWithValue("@KitapId", kitap.KitapId);
            command.Parameters.AddWithValue("@OgrenciId", kitap.OgrenciId);
            command.Parameters.AddWithValue("@KitapAlinmaTarihi", kitap.KitabinAlinmaTarihi);
            return command.ExecuteNonQuery();
        }

        //Ogrencinin almış olduğu kitaplar tarihsel olarak listelendi, inner join yöntemi ile veriler çekildi
        public static List<AlınanKitapBilgileri> OgrenciIdListe(AlınanKitapBilgileri kitap)
        {
            OleDbCommand command = new OleDbCommand("Select o.OgrenciId,k.KitapAd,kk.KitapAlinmaTarihi,kk.KitapTeslimTarihi,kk.KitapKontrol from ((Kitap k inner join KitapKayit kk on k.KitapId=kk.KitapId) inner join Ogrenci o on o.OgrenciId=kk.OgrenciId) where o.OgrenciId = @OgrenciId", Baglanti.baglanti);
            Baglanti.Baglan(command);
            command.Parameters.AddWithValue("@OgrenciId", kitap.OgrenciId);

            OleDbDataReader read = command.ExecuteReader();
            List<AlınanKitapBilgileri> kitapOgrenci = new List<AlınanKitapBilgileri>();
            while (read.Read()) // Verileri okuyoruz
            {
                kitapOgrenci.Add(new AlınanKitapBilgileri
                {
                    OgrenciId = int.Parse(read["OgrenciId"].ToString()),
                    KitapAd = read["KitapAd"].ToString(),
                    KitabinAlinmaTarihi = DateTime.Parse(read["KitapAlinmaTarihi"].ToString()),
                    KitapTeslimi = read["KitapTeslimTarihi"].ToString(),
                    KitapKontrol = bool.Parse(read["KitapKontrol"].ToString())
                });
            }
            return kitapOgrenci;
        }


        //Alinabilir durumdaki kitapların teslim edilme durumlarına göre listeleme işlemi gerçekleştirildi
        public static List<string> KitapAlinanListe(KitapIadeBilgileri kitap)
        {
            OleDbCommand command = new OleDbCommand("Select KitapAd from Kitap where KitapId not in(select KitapId from KitapKayit where OgrenciId=@OgrenciId and KitapKontrol=false)", Baglanti.baglanti);
            Baglanti.Baglan(command);
            command.Parameters.AddWithValue("@OgrenciId", kitap.OgrenciId);
            OleDbDataReader read = command.ExecuteReader();

            List<string> liste = new List<string>();

            while (read.Read()) // Verileri okuyoruz
            {
                liste.Add(read["KitapAd"].ToString());
            }

            return liste;
        }

        //Teslim edilmesi gereken kitaplar teslim edilmeme durumuna göre listeye aktarıldı
        public static List<string> KitapTeslimListe(KitapIadeBilgileri kitap)
        {
            OleDbCommand command = new OleDbCommand("Select KitapAd from Kitap where KitapId in(select KitapId from KitapKayit where OgrenciId=@OgrenciId and KitapKontrol=false)", Baglanti.baglanti);
            Baglanti.Baglan(command);
            command.Parameters.AddWithValue("@OgrenciId", kitap.OgrenciId);
            OleDbDataReader read = command.ExecuteReader();

            List<string> liste = new List<string>();

            while (read.Read()) // Verileri okuyoruz
            {
                liste.Add(read["KitapAd"].ToString());
            }

            return liste;
        }


        //Kitap teslim edildiğinde veriler güncellendi
        public static int KitapTeslimi(KitapIadeBilgileri kitap)
        {
            OleDbCommand command = new OleDbCommand("Update KitapKayit set KitapTeslimTarihi=@KitapTeslimTarihi,KitapKontrol=@KitapKontrol where KitapId=@KitapId  and  OgrenciId=@Ogrenci", Baglanti.baglanti);
            Baglanti.Baglan(command);
            command.Parameters.AddWithValue("@KitapTeslimTarihi", kitap.KitapTeslimi);
            command.Parameters.AddWithValue("@KitapKontrol", kitap.KitapKontrol);
            command.Parameters.AddWithValue("@KitapId", kitap.KitapId);
            command.Parameters.AddWithValue("@OgrenciId", kitap.OgrenciId);
            return command.ExecuteNonQuery();
        }

        //Veritabanından öğrenciye ait ceza bilgisi listeye aktarıldı
        public static List<string> OgrenciCeza(KitapIadeBilgileri kitap)
        {
            OleDbCommand command = new OleDbCommand("Select o.OgrenciCeza from ((Kitap k inner join KitapKayit kk on k.KitapId=kk.KitapId) inner join Ogrenci o on o.OgrenciId=kk.OgrenciId) where o.OgrenciId = @OgrenciId", Baglanti.baglanti);
            Baglanti.Baglan(command);
            command.Parameters.AddWithValue("@OgrenciId", kitap.OgrenciId);
            OleDbDataReader read = command.ExecuteReader();

            List<string> liste = new List<string>();

            while (read.Read()) // Verileri okuyoruz
            {
                kitap.OgrenciCeza = float.Parse(read["OgrenciCeza"].ToString());
            }

            return liste;
        }

        //Ceza işlemi gerçekleştirildikten sonra ogrenciye ait ceza verisinde guncelleme yapıldı
        public static int OgrenciCezaIslemi(KitapIadeBilgileri ogrenci)
        {
            OleDbCommand command = new OleDbCommand("Update Ogrenci set OgrenciCeza=@OgrenciCeza where OgrenciId=@OgrenciId", Baglanti.baglanti);
            Baglanti.Baglan(command);

            command.Parameters.AddWithValue("@OgrenciCeza", ogrenci.OgrenciCeza);
            command.Parameters.AddWithValue("@OgrenciId", ogrenci.OgrenciId);

            return command.ExecuteNonQuery();
        }

        // Alınma tarihini kitapkayıt tablosundan çekip listeye aktardık
        public static List<string> KitapTarihi(KitapIadeBilgileri kitap)
        {
            OleDbCommand command = new OleDbCommand("Select KitapAlinmaTarihi from KitapKayit where KitapId=@KitapId and OgrenciId=@OgrenciId", Baglanti.baglanti);
            Baglanti.Baglan(command);
            command.Parameters.AddWithValue("@KitapId", kitap.KitapId);
            command.Parameters.AddWithValue("@OgrenciId", kitap.OgrenciId);
            OleDbDataReader read = command.ExecuteReader();

            List<string> liste = new List<string>();

            while (read.Read()) // Verileri okuyoruz
            {
                kitap.KitabinAlinmaTarihi = DateTime.Parse(read["KitapAlinmaTarihi"].ToString());
            }

            return liste;
        }



        //Öğrenciye verilmiş kitapların sayısı int olarak döndürüldü
        public static int GrafikVerilmis(KitapIadeBilgileri kitap)
        {
            OleDbCommand command = new OleDbCommand("Select KitapAd from Kitap where KitapId in(select KitapId from KitapKayit where OgrenciId=@OgrenciId and KitapKontrol=false)", Baglanti.baglanti);
            Baglanti.Baglan(command);
            command.Parameters.AddWithValue("@OgrenciId", kitap.OgrenciId);
            OleDbDataReader read = command.ExecuteReader();
            int sayac = 0;
            while (read.Read()) // Verileri okuyoruz
            {
                sayac++;
            }

            return sayac;
        }

        //Tüm kitapların sayısı int olarak döndürüldü
         public static int GrafikHepsi()
        {
            OleDbCommand command = new OleDbCommand("Select * from Kitap", Baglanti.baglanti);
            Baglanti.Baglan(command);
            OleDbDataReader read = command.ExecuteReader();
            int sayac = 0;
            while (read.Read()) // Verileri okuyoruz
            {
                sayac++;
            }

            return sayac;
        }

        //Alınabilir kitapların sayısı int olarak döndürüldü
        public static int GrafikAlinabilir(KitapIadeBilgileri kitap)
        {
            OleDbCommand command = new OleDbCommand("Select KitapAd from Kitap where KitapId not in(select KitapId from KitapKayit where OgrenciId=@OgrenciId and KitapKontrol=false)", Baglanti.baglanti);
            Baglanti.Baglan(command);
            command.Parameters.AddWithValue("@OgrenciId", kitap.OgrenciId);
            OleDbDataReader read = command.ExecuteReader();
            int sayac = 0;
            while (read.Read()) // Verileri okuyoruz
            {
                sayac++;
            }

            return sayac;
        }
    }
}
