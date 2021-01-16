using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            string kurs1 = "yazılım geliştirici yetiştirme kampı";
            string kurs2 = "programlamaya başlangıç için temel kurs";
            string kurs3 = "java";
            //array-dizi
            string[] kurslar = new string[] { "yazılım geliştirici yetiştirme kampı", "programlamaya başlangıç için temel kurs","java","python", "C#" };//istediğim kadar kursu burada tutabilirim.tek tek tanımlamak yerine bir listede tuttum.gerçek hayatta yine buda bir veri kaynağından gelir
            

            for (int i = 0; i < kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);  //ekranım bu şekilde dinamikleşiyor!
            }

            Console.WriteLine("for bitti!");
            foreach (string kurs in kurslar)//in kurslar(tek tek kursları dolaş) demektir. buradaki kurs her bir elemana verilen takma adıdır! foreach dizileri kolay dolaşmak için yazılır..

            {
                Console.WriteLine(kurs);
            }
            

            Console.WriteLine("sayfa sonu- footer");
        }
    }
}
