using System;

namespace console_diziler
{
    class Program
    {
        static void Main(string[] args)
        {
            // Dizi tanımlama

            // string[] renkler = new string[5];

            // string[] hayvanlar = { "Kedi", "Köpek", "Kuş", "Maymun" };

            // int[] dizi;
            // dizi = new int[5];

            // // Dizilere değer atama ve erişim

            // renkler[0] = "Mavi";

            // dizi[3] = 10;
            // Console.WriteLine(hayvanlar[0]);
            // Console.WriteLine(dizi[3]);
            // Console.WriteLine(renkler[0]);


            // Döngülerle dizi kullanımı
            // Klavyeden girilen n tane sayının ortalamasını alan program - Kullanıcı girişli

            Console.Write("Dizi boyutunu giriniz: ");
            int diziBoyut = int.Parse(Console.ReadLine());

            int[] array = new int[diziBoyut];
            for (int i = 0; i <= diziBoyut-1; i++)
            {
                Console.Write("Lütfen Dizinin " + i + ". İndeksini Giriniz: ");
                array[i] = int.Parse(Console.ReadLine());
            }

            int ortalama =0;

            foreach (var items in array)
            {
                ortalama += items;
            }

            ortalama /= diziBoyut;
            Console.WriteLine("Dizi ortalaması: "+ortalama);


            Console.Read();
        }
    }
}
