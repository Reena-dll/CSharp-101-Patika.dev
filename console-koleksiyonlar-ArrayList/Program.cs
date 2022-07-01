using System;
using System.Collections;
using System.Collections.Generic;

namespace console_koleksiyonlar_ArrayList
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList list = new ArrayList();

            // list.Add("Ayşe");
            // list.Add(2);
            // list.Add(true);
            // list.Add('A');

            // İçerisinde ki verilere erişim
            //Console.WriteLine(list[1]);
            // foreach(var item in list)
            //     Console.WriteLine(item);

            // AddRange
            Console.WriteLine("****** Add Range ******");
           // string[] renkler = {"Kırmızı", "Sarı", "Yeşil"};
            List<int> sayilar = new List<int>(){1,8,3,7,9,92,5};
           // list.AddRange(renkler);
            list.AddRange(sayilar);

            foreach(var item in list)
                Console.WriteLine(item);
            
            // Sort

            Console.WriteLine("***** Sort *****");
            list.Sort();
            
            foreach(var item in list)
                Console.WriteLine(item);


            // Binary Search
            Console.WriteLine("****** Binary Search ******");
            Console.WriteLine(list.BinarySearch(9));

            // Reverse
            Console.WriteLine("***** Reverse ******");
            list.Reverse();
            foreach(var item in list)
                Console.WriteLine(item);

            // Clear
                        Console.WriteLine("***** Clear ******");

            list.Clear();
            foreach(var item in list)
                Console.WriteLine(item);

            Console.Read();
        }
    }
}
