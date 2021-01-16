using System;

namespace KampIntro
{
    class Program
    {
        static void Main(string[] args)
        {    //type safety-tip güvenliği
            //do not repeat yourself-kendini tekrarlama!
            //değer tutucu , alias-kategorietiketi
            string kategoriEtiketi = "Kategori";
            int ogrenciSayisi = 32000;
            double faizOranı = 1.45;
            bool sistemeGirisYapmisMi = true; //gerçek hayatta burası veri kaynağından gelir!!
            double dolarDun = 7.35;
            double dolarBugun = 7.45;

            if (dolarDun>dolarBugun)
            {
                Console.WriteLine("Azalış butonu");
            }
            else if(dolarDun<dolarBugun)
            {
                Console.WriteLine("Artış butonu");
            }
            else
            {
                Console.WriteLine("değişmedi butonu");
            }

            if (sistemeGirisYapmisMi==true)
            {
                Console.WriteLine("Kullanıcı Ayarları butonu");
            }
            else
            {
                Console.WriteLine("giriş yap butonu");
            }
            Console.WriteLine(kategoriEtiketi);
        }
    }
}
