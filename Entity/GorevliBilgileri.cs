using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class GorevliBilgileri
    {
        private int gorevliId;
        private string gorevliAd, gorevliSoyad, gorevliTc, gorevliSifre;

        public int GorevliId
        {
            get { return this.gorevliId; }
            set { this.gorevliId = value; }
        }
       
        public string GorevliSifre
        {
            get { return this.gorevliSifre; }
            set { this.gorevliSifre = value; }
        }
       
        public string GorevliAd
        {
            get { return this.gorevliAd; }
            set { this.gorevliAd = value; }
        }
        public string GorevliSoyad
        {
            get { return this.gorevliSoyad; }
            set { this.gorevliSoyad = value; }
        }
        public string GorevliTc
        {
            get { return this.gorevliTc; }
            set { this.gorevliTc = value; }
        }
    }
}
