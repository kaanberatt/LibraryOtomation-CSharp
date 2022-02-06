using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class OgrenciBilgileri
    {
        private int ogrenciId;
        private float ogrenciCeza;
        private string ogrenciAd, ogrenciSoyad, ogrenciCinsiyet, ogrenciNo, ogrenciSifre;
                
        public int OgrenciId
        {
            get { return this.ogrenciId; }
            set { this.ogrenciId = value; }
        }
        public string OgrenciNo
        {
            get { return this.ogrenciNo; }
            set { this.ogrenciNo = value; }
        }
        public string OgrenciSifre
        {
            get { return this.ogrenciSifre; }
            set { this.ogrenciSifre = value; }
        }
        public float OgrenciCeza
        {
            get { return this.ogrenciCeza; }
            set { this.ogrenciCeza = value; }
        }
        public string OgrenciAd
        {
            get { return this.ogrenciAd; }
            set { this.ogrenciAd = value; }
        }
        public string OgrenciSoyad
        {
            get { return this.ogrenciSoyad; }
            set { this.ogrenciSoyad = value; }
        }
        public string OgrenciCinsiyet
        {
            get { return this.ogrenciCinsiyet; }
            set { this.ogrenciCinsiyet = value; }
        }


    }
}
