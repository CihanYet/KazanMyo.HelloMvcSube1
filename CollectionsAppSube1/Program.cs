using System;
using System.Collections;
using System.Collections.Generic;

namespace CollectionsAppSube1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // int[] sayilar = new int[2];//Type Safe(Tip güvenliği sağlar)
            // sayilar[0] = 1;
            // sayilar[1] = 2;

            //// Console.WriteLine(sayilar[0] + sayilar[1]);

            // //Collections
            // ArrayList lst=new ArrayList();
            // lst.Add(1);
            // lst.Add(2);
            // lst.Add(1);
            // lst.Add(2);
            // lst.Add(1);
            // lst.Add(2);
            // lst.Add(2);
            // lst.Add(1);
            // lst.Add(2);
            // lst.Capacity = lst.Count;
            // Console.WriteLine($"Kapasite:{lst.Capacity}\nCount:{lst.Count}");

            // Console.WriteLine((int)lst[0] + (int)lst[1]);
            //Boxing: Değer tipinden->object
            //UnBoxing: Object->değer tipi

            //var lst = new List<int>();
            //lst.Add(1);
            //lst.Add(2);
            //Console.WriteLine(lst[0] + lst[1]);

            //var t = new Test<string>();
            
        }
    }

    //Generic Collections

    class Test<T> where T : class//Generic constraints
    {
        public void Yazdir(T veri)
        {
            Console.WriteLine(veri);
        }
    }
}

