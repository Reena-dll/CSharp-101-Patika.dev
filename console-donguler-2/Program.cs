using System;

namespace console_donguler_2
{
    class Program
    {
        static void Main(string[] args)
        {
            // While

            // 1'den başlayarak consoldan girilen sayıya kadar ( sayı dahil ) ortalama hesaplayıp, consola yazdıran program.

            Console.Write("Lütfen Sayıyı Giriniz: ");
            int sayi = int.Parse(Console.ReadLine());

            int sayac = 1;
            int toplam = 0;

            while (sayac <= sayi)
            {
                toplam += sayac;
                sayac++;
            }

            int ortalama = toplam/sayi;
            Console.WriteLine("Ortalama: "+ortalama);


            // 'a' dan 'z' ye kadar tüm harfleri console'a yazdır.

            char character = 'a';
            
            while(character<'z'){
                Console.Write(character+", ");
                character++;
            }


            // FOREACH

            Console.WriteLine("***** Foreach ******");

            string[] arabalar = {"BMV", "FORD", "TOYOTA", "NISSAN"};

            foreach (var araba in arabalar)
            {
                Console.WriteLine(araba);
            }

            Console.Read();
        }
    }
}
