using System;

namespace console_donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ekrandan girilen sayıya kadar olan tek sayıları ekrana yazdır.

            Console.Write("Lütfen Bir Sayı Giriniz: ");
            int sayi = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i <= sayi; i++)
            {
                if (i % 2 == 1)
                    Console.WriteLine(i);
            }

            // 1 ile 1000 arasında ki sayıları toplayıp ekrana yazdıralım

            int tekToplam = 0;
            int ciftToplam = 0;

            for (int i = 0; i <= 1000; i++)
            {
                if (i % 2 == 0)
                    tekToplam += i;

                if (i % 2 == 1)
                    ciftToplam += i;

            }
            Console.WriteLine("Tek Toplam : " + tekToplam);
            Console.WriteLine("Çift Toplam : " + ciftToplam);


            // Break, continue

            for (int i = 1; i < 10; i++)
            {
                if (i == 4)
                    break;
                
                Console.WriteLine(i);
            }

             for (int i = 1; i < 10; i++)
            {
                if (i == 4)
                    continue;
                
                Console.WriteLine(i);
            }

            Console.Read();
        }
    }
}
