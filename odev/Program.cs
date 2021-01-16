using System;

namespace odev
{
    class Program
    {
        static void Main(string[] args)
        {
            product urun1 = new product();
            urun1.urunad = "kazak";
            urun1.fiyat = 50;
            urun1.urunkod = "1220";

            product urun2 = new product();
            urun2.urunad = "pantolon";
            urun2.fiyat = 100;
            urun2.urunkod = "1225";

            product urun3 = new product();
            urun3.urunad = "mont";
            urun3.fiyat = 250;
            urun3.urunkod = "1229";

            product[] urunler = new product[] {urun1,urun2,urun3 };

            for (int i = 0; i < urunler.Length; i++)
            {
                Console.WriteLine("Ürün Adı: " + urunler[i].urunad);
                Console.WriteLine("Ürün Fiyatı: " + urunler[i].fiyat);
                Console.WriteLine("Ürün Kodu: " + urunler[i].urunkod);
                Console.WriteLine("\n");
            }

            foreach (var urun in urunler)
            {
                Console.WriteLine("Ürün Adı: " + urun.urunad);
                Console.WriteLine("Ürün Fiyatı: " + urun.fiyat);
                Console.WriteLine("Ürün Kodu: " + urun.urunkod);
                Console.WriteLine("\n");
            }

            int y = 0;
            while (y<urunler.Length)
            {
                Console.WriteLine("Ürün Adı: " + urunler[y].urunad);
                Console.WriteLine("Ürün Fiyatı: " + urunler[y].fiyat);
                Console.WriteLine("Ürün Kodu: " + urunler[y].urunkod);
                y++;
                Console.WriteLine("\n");
            }
        }
    }
    class product 
    {
        public string urunad { get; set; }
        public int fiyat { get; set; }
        public string urunkod { get; set; }
    }
}
