using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;

namespace DataAccessLayer
{
    class Baglanti
    {// Veritabanına bağlantı işlemleri gerçekleştirildi.

        public static OleDbConnection baglanti = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source= |DataDirectory|\\KutuphaneOtomasyonuVeriTabani.mdb");
        public static void Baglan(OleDbCommand komut)
        {
            if (komut.Connection.State != ConnectionState.Open)
            {
                komut.Connection.Open();
            }
        }

        // veritabanına bağlanmak ve bağlantıyı kesmek için bu Baglan ve BaglantiyiKes metotları oluşturuldu.
        // Bu metotlar bize veritabanı bağlantılarında kolaylık sağlayacaktır.
        public static void BaglantiyiKes(OleDbCommand komut)
        {
            if (komut.Connection.State == ConnectionState.Open)
            {
                komut.Connection.Close() ;
            }
        }

    }
}
