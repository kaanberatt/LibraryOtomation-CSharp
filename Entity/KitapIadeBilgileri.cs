using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class KitapIadeBilgileri
    {
        private int  ogrenciId, kitapId;
        private DateTime kitapAlmaTarihi, kitapTeslimTarihi;
        private bool kitapKontrol;
        private float ogrenciCeza;

        public int OgrenciId { get { return this.ogrenciId; } set { this.ogrenciId = value; } }
        public int KitapId { get { return this.kitapId; } set { this.kitapId = value; } }
        public DateTime KitapTeslimi { get { return this.kitapAlmaTarihi; } set { this.kitapAlmaTarihi = value; } }
        public DateTime KitabinAlinmaTarihi { get { return this.kitapTeslimTarihi; } set { this.kitapTeslimTarihi = value; } }
        public bool KitapKontrol { get { return this.kitapKontrol; } set { this.kitapKontrol = value; } }
        public float OgrenciCeza { get { return this.ogrenciCeza; } set { this.ogrenciCeza = value; } }
    }
}
