using System;
using System.Collections.Generic;
using System.Text;

namespace Metotlar
{
    class SepetManager
    {
        //manager - bir operasyon tutar
        //naming convention
        //ne eklemek istiyorsak buna parametre denir.
        public void Ekle(Urun urun)// parametre aldı nerden aldı Urun sınıfından
        {
            Console.WriteLine("sepete eklendi:" + urun.Adi);

        }
        public void Ekle2(string urunAdi, string urunAciklama, double fiyat)
        {
            Console.WriteLine("tebrikler sepete eklendi " + urunAdi);
        }
    }
}
