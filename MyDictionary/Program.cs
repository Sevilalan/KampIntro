using System;
using System.Collections.Generic;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> dictionary = new Dictionary<int, string>();
            dictionary.Add(12, "Çay Bardağı");
            dictionary.Add(25, "Kahve Bardağı");
            dictionary.Add(30,"Kupa Bardağı");
            dictionary.Add(100, "2'li Kupa Bardağı");
            Console.WriteLine(dictionary.Count);
            Console.WriteLine(dictionary.Count2);
            
        }
    }
    class Dictionary<T, D>
    {
        T[] keys;
        D[] values;
        T[] tempKeys;
        D[] tempValues;
        public Dictionary()
        {
            keys = new T[0];
            values = new D[0];
        }
        public void Add(T key, D value)
        {
            tempKeys = keys;
            tempValues = values;
            keys = new T[keys.Length + 1];
            values = new D[values.Length + 1];
            for (int i = 0; i < tempKeys.Length; i++)
            {
                keys[i] = tempKeys[i];
            }
            for (int j = 0; j < tempValues.Length; j++)
            {
                values[j] = tempValues[j];
            }
            keys[keys.Length - 1] = key;
            values[values.Length - 1] = value;

        }
        public int Count
        {
            get { return keys.Length; }
           

        }
        public int Count2
        {
            
            get { return values.Length; }
        }
    }

    }

