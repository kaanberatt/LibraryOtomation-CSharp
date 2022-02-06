using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class AlınanKitapBilgileri
    {
        private int ogrenciId;
        private string kitapAd,kitapTeslimi;
        private DateTime kitabinAlinmaTarihi;
        private bool kitapKontrol;

        public int OgrenciId { get { return this.ogrenciId; }  set { this.ogrenciId = value; } }
        public string KitapAd { get { return this.kitapAd; }  set { this.kitapAd = value; } }
        public string KitapTeslimi { get { return this.kitapTeslimi; }  set { this.kitapTeslimi = value; } }
        public DateTime KitabinAlinmaTarihi { get { return this.kitabinAlinmaTarihi; }  set { this.kitabinAlinmaTarihi = value; } }
        public Boolean KitapKontrol { get { return this.kitapKontrol; } set { this.kitapKontrol = value; } }
    }
}
