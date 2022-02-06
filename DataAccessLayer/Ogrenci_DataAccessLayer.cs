using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using System.Data.OleDb;
namespace DataAccessLayer
{
    public class Ogrenci_DataAccessLayer
    {
        //Öğrencinin tabloda kayıtlı olma durumu kontrol edildi
        public static bool ogrenciKontrol(OgrenciBilgileri ogrenci)
        {
            OleDbCommand komut = new OleDbCommand("Select * from Ogrenci where OgrenciNo=@OgrenciNo and OgrenciSifre=@OgrenciSifre", Baglanti.baglanti);
            Baglanti.Baglan(komut);
            komut.Parameters.AddWithValue("@OgrenciNo", ogrenci.OgrenciNo);
            komut.Parameters.AddWithValue("@OgrenciSifre", ogrenci.OgrenciSifre);

            OleDbDataReader okuma = komut.ExecuteReader();
            bool sonuc = false;
            int sayac = 0;

            while (okuma.Read())// Verileri okuyoruz
            {
                sayac++;
            }
            if (sayac > 0)
            {
                sonuc = true;
            }
            //Baglanti.BaglantiyiKes(komut);
            return sonuc;
        }

        // Öğrenciye ait tüm bilgilerin listelenmesi gerçekleştirildi
        public static List<OgrenciBilgileri> Listele() 
        {
            OleDbCommand komut = new OleDbCommand("Select * from Ogrenci", Baglanti.baglanti);
            Baglanti.Baglan(komut);
            OleDbDataReader read = komut.ExecuteReader();
            List<OgrenciBilgileri> ogrenci = new List<OgrenciBilgileri>();

            while (read.Read()) // Verileri okuyoruz
            {
                ogrenci.Add(new OgrenciBilgileri
                {
                    OgrenciId = int.Parse(read["OgrenciId"].ToString()),
                    OgrenciAd = read["OgrenciAd"].ToString(),
                    OgrenciSoyad = read["OgrenciSoyad"].ToString(),
                    OgrenciNo = read["OgrenciNo"].ToString(),
                    OgrenciSifre = read["OgrenciSifre"].ToString(),
                    OgrenciCinsiyet = read["OgrenciCinsiyet"].ToString(),
                    OgrenciCeza = float.Parse(read["OgrenciCeza"].ToString())
                });
            }
            
            return ogrenci;

        }
        public static int ogrenciEkle(OgrenciBilgileri ogrenci)
        {
            OleDbCommand komut = new OleDbCommand("insert into Ogrenci(OgrenciAd,OgrenciSoyad,OgrenciNo,OgrenciSifre,OgrenciCinsiyet) values(@OgrenciAd,@OgrenciSoyad,@OgrenciNo,@OgrenciSifre,@OgrenciCinsiyet)", Baglanti.baglanti);
            Baglanti.Baglan(komut);
            komut.Parameters.AddWithValue("@OgrenciAd", ogrenci.OgrenciAd);
            komut.Parameters.AddWithValue("@OgrenciSoyad", ogrenci.OgrenciSoyad);
            komut.Parameters.AddWithValue("@OgrenciNo", ogrenci.OgrenciNo);
            komut.Parameters.AddWithValue("@OgrenciSifre", ogrenci.OgrenciSifre);
            komut.Parameters.AddWithValue("@OgrenciCinsiyet", ogrenci.OgrenciCinsiyet);
            
            return komut.ExecuteNonQuery();
        }

        public static bool OgrenciNoKontrol(OgrenciBilgileri ogrenci)
        {
            //Yeni eklenecek öğrenci ile veri tabanındaki herhangi bir öğrencinin numraları çakışmaması için kontrol edildi
            OleDbCommand komut = new OleDbCommand("Select count(OgrenciNo) FROM Ogrenci Where OgrenciNo=@OgrenciNo", Baglanti.baglanti);
            Baglanti.Baglan(komut);
            komut.Parameters.AddWithValue("@OgrenciNo", ogrenci.OgrenciNo);
            int count = Convert.ToInt32(komut.ExecuteScalar());

            if (count > 0)
            {
                return false;
            }

            return true;

        }
        public static bool OgrenciSorgu(OgrenciBilgileri ogrenci)
        {
            OleDbCommand komut = new OleDbCommand("Select * from Ogrenci where OgrenciId=@OgrenciId", Baglanti.baglanti);
            Baglanti.Baglan(komut);
            komut.Parameters.AddWithValue("@OgrenciId", ogrenci.OgrenciId);

            OleDbDataReader okuma = komut.ExecuteReader();
            bool sonuc = false;
            int sayac = 0;

            while (okuma.Read()) // Verileri okuyoruz
            {
                sayac++;
            }


            if (sayac > 0)
            {
                sonuc = true;
            }

            return sonuc;
        }

        // İd ye ait öğrenci , Ogrenci tablosundan silindi
        public static int OgrenciSil(OgrenciBilgileri ogrenci)
        {
            OleDbCommand komut = new OleDbCommand("Delete from Ogrenci where OgrenciId=@OgrenciId ", Baglanti.baglanti);
            Baglanti.Baglan(komut);
            komut.Parameters.AddWithValue("@OgrenciId", ogrenci.OgrenciId);
            
            return komut.ExecuteNonQuery();
        }
        public static int OgrenciGuncelle(OgrenciBilgileri ogrenci)
        {
            OleDbCommand command = new OleDbCommand("Update Ogrenci set OgrenciAd=@OgrenciAd,OgrenciSoyad=@OgrenciSoyad,OgrenciNo=@OgrenciNo,OgrenciSifre=@OgrenciSifre,OgrenciCinsiyet=@OgrenciCinsiyet where OgrenciId=@OgrenciId", Baglanti.baglanti);
            Baglanti.Baglan(command);
            command.Parameters.AddWithValue("@OgrenciAd", ogrenci.OgrenciAd);
            command.Parameters.AddWithValue("@OgrenciSoyad", ogrenci.OgrenciSoyad);
            command.Parameters.AddWithValue("@OgrenciNo", ogrenci.OgrenciNo);
            command.Parameters.AddWithValue("@OgrenciSifre", ogrenci.OgrenciSifre);
            command.Parameters.AddWithValue("@OgrenciCinsiyet", ogrenci.OgrenciCinsiyet);
            command.Parameters.AddWithValue("@OgrenciId", ogrenci.OgrenciId);

            return command.ExecuteNonQuery();
        }


        //Ogrenci id ye ait tüm bilgiler Ogrenci tablosundan çekildi
        public static OgrenciBilgileri OgrenciIdBilgi(OgrenciBilgileri ogrenci)
        {
            OleDbCommand command = new OleDbCommand("Select * from Ogrenci where OgrenciId = @OgrenciId", Baglanti.baglanti);
            Baglanti.Baglan(command);
            command.Parameters.AddWithValue("@OgrenciId", ogrenci.OgrenciId);
            OleDbDataReader read = command.ExecuteReader();

            while (read.Read()) // Verileri okuyoruz
            {
                ogrenci.OgrenciId = int.Parse(read["OgrenciId"].ToString());
                ogrenci.OgrenciAd = read["OgrenciAd"].ToString();
                ogrenci.OgrenciSoyad = read["OgrenciSoyad"].ToString();
                ogrenci.OgrenciNo = read["OgrenciNo"].ToString();
                ogrenci.OgrenciSifre = read["OgrenciSifre"].ToString();
                ogrenci.OgrenciCinsiyet = read["OgrenciCinsiyet"].ToString();
                ogrenci.OgrenciCeza = float.Parse(read["OgrenciCeza"].ToString());
            }

            return ogrenci;
        }

        // OgrenciIdSorgu = Ogrenci no ve şifreye ait id çekildi ve int döndürüldü
        public static int OgrenciIdSorgu(OgrenciBilgileri ogr)
        {
            OleDbCommand command = new OleDbCommand("Select OgrenciId from Ogrenci where OgrenciNo=@OgrenciNo and OgrenciSifre=@OgrenciSifre", Baglanti.baglanti);
            Baglanti.Baglan(command);
            command.Parameters.AddWithValue("@OgrenciNo", ogr.OgrenciNo);
            command.Parameters.AddWithValue("@OgrenciSifre", ogr.OgrenciSifre);

            OleDbDataReader okuma = command.ExecuteReader();
            int id = 0;
            while (okuma.Read()) // Verileri okuyoruz
            {
                id = int.Parse(okuma["OgrenciId"].ToString());
            }
            return id;
        }
    }
}
