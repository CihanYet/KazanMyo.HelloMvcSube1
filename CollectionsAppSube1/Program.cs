using System;
using System.Collections;
using System.Collections.Generic;

namespace CollectionsAppSube1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int[] sayilar = new int[3];//Type Safe
            //sayilar[0] = 1;
            //sayilar[1] = 2;
            //sayilar[2] = 3;

            ////Console.WriteLine(sayilar[0] + sayilar[1]);

            //ArrayList lst = new ArrayList();
            //lst.Add(1);
            //lst.Add(2);
            //lst.Add(3);
            //lst.Add(1);
            //lst.Add(2);
            //lst.Add(2);
            //lst.Add(3);
            //lst.Add(1);
            //lst.Add(2);
            //lst.Capacity = lst.Count;
            //Console.WriteLine($"Kapasite:{lst.Capacity}\nCount:{lst.Count}");

            var lst = new List<int>();
            lst.Add(1);
            lst.Add(2);
            Console.WriteLine(lst[0]+lst[1]);
         

        }
    }

    //Generic Collections

    class Test<T> where T : class    //Generic Constraints
    {
        public void Yazdir(T veri)
        {
            Console.WriteLine(veri);
        }        
    }

    class Ogrenci
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }

    }
}

