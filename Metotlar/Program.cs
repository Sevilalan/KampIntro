using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            string urunAdi = "elme";
            double fiyati = 15;
            string aciklama = "emasya elması";

            string[] meyveler = new string[] { };

            Urun urun1 = new Urun();
            urun1.Adi = "elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "amasya elması";

            Urun urun2 = new Urun();
            urun2.Adi = "karpuz";
            urun2.Fiyati = 80;
            urun2.Aciklama = "diyarbakır karpuzu";

            Urun[] urunler = new Urun[] {urun1,urun2 };

            foreach (var urun in urunler)
            {
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine("-------------");
            }
            Console.WriteLine("--------METOTLAR-------------");
            //instance- örnek
            //encapsulation- kapsülleme
            SepetManager sepetManager = new SepetManager();//tekrar tekrar aynı şeyi kullanabilmeyi sağlar.
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);

            sepetManager.Ekle2("armut", "yeşil armut", 12);
            sepetManager.Ekle2("elma", "yeşil elma", 12);
            sepetManager.Ekle2("karpuz", "diyarbakır karpuzu", 12);




        }
    }
}

//dont repeat yourself -DRY- Clean Code - Best Practice 
