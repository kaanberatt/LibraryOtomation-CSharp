using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using DataAccessLayer;
namespace BusinessLayer
{
    public class Gorevli_BusinessLayer
    {
        public static bool gorevliKontrol_BL(GorevliBilgileri gorevli)
        {
            // gorevli tc ve gorevli sifre degeri null değilse Gorevli_DataAccessLayer katmanındaki gorevlikontrol metoduna yönlendirilir.
            if (gorevli.GorevliTc != "" && gorevli.GorevliSifre != "")
                return Gorevli_DataAccessLayer.gorevliKontrol(gorevli);
            else 
                return false; 
                
        }
    }
}
