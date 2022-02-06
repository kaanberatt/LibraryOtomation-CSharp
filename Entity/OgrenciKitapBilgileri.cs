using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class OgrenciKitapBilgileri
    {
        private int kitapId;
        private string ogrenciAd, ogrenciSoyad, kitapAd, kitapTeslim;
        private DateTime kitapAlinmaTarihi;
        private bool kitapKontrol;

        public int KitapId { get => kitapId; set => kitapId = value; }
        public string OgrenciAd { get => ogrenciAd; set => ogrenciAd = value; }
        public string OgrenciSoyad { get => ogrenciSoyad; set => ogrenciSoyad = value; }
        public string KitapAd { get => kitapAd; set => kitapAd = value; }
        public string KitapTeslim { get => kitapTeslim; set => kitapTeslim = value; }
        public DateTime KitapAlinmaTarihi { get => kitapAlinmaTarihi; set => kitapAlinmaTarihi = value; }
        public bool KitapKontrol { get => kitapKontrol; set => kitapKontrol = value; }
    }
}
