using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using System.Data.OleDb;
using System.Data;
namespace DataAccessLayer
{
    public class Gorevli_DataAccessLayer
    {
        // gorevli kontrol = Veritabanında görevli var mı diye kontrol eder.
        public static bool gorevliKontrol(GorevliBilgileri gorevli) 
        {

            OleDbCommand command = new OleDbCommand("Select * from Gorevli where GorevliTc=@gorevTc and GorevliSifre=@gorevSifre", Baglanti.baglanti);
            Baglanti.Baglan(command); // yazılan sql sorguları baglanti sınıfındaki baglan metoduna parametre olarak gönderildi.
            command.Parameters.AddWithValue("@gorevTc", gorevli.GorevliTc);
            command.Parameters.AddWithValue("@gorevSifre", gorevli.GorevliSifre);

            OleDbDataReader okuma = command.ExecuteReader(); 
            bool sonuc = false;
            int sayac = 0;

            while (okuma.Read())
            { 
                sayac++;
            }
            if (sayac > 0)
            {
                sonuc = true;
            }
            return sonuc;
        } 
    }
}
