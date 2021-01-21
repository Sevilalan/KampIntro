using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsIntro
{
    class MyList<T>
    {
        T[] items;
        //constructor sen mylisti newlediğin an çalışır
        public MyList() //classla aynı isim ise constructordur.
        {
            items = new T[0]; 
        }
        public void Add(T item)
        {
            T[] tempArray = items; //geçicidizinin referansını tutar.
            items = new T[items.Length+1]; //eğer yukarda referansı yani adresi tutmaz isem bu kod yüzünden adres uçar.
            for (int i = 0; i < tempArray.Length; i++)
            {
                items[i] = tempArray[i]; //tempArraya geçici olarak verdiğim elemanları geri almış oldum.
            }
            items[items.Length - 1] = item; //eklenmek istenen şuan eklendi.
        }

        public int Lenght
        {
            get { return items.Length; }
        }
       
    }
}
