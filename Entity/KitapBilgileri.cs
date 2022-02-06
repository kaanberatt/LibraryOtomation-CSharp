using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class KitapBilgileri
    {
        private int kitapId;
        private string kitapAd, kitapSayfa, kitapTuru, kitapYazar;

        public int KitapId 
        { 
            get{ return this.kitapId; }
            set{ this.kitapId = value;}
        }
        public string KitapAd
        {
            get { return this.kitapAd; }
            set { this.kitapAd = value; }
        }
        public string KitapSayfa
        {
            get { return this.kitapSayfa; }
            set { this.kitapSayfa = value; }
        }
        public string KitapTuru
        {
            get { return this.kitapTuru; }
            set { this.kitapTuru = value; }
        }
        public string KitapYazar
        {
            get { return this.kitapYazar; }
            set { this.kitapYazar = value; }
        }
    }
}
