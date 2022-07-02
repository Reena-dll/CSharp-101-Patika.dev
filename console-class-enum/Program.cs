using System;

namespace console_class_enum
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Gunler.Pazar);
            Console.WriteLine((int)Gunler.Cumartesi);

            int sicaklik =32;
            if(sicaklik<= (int)HavaDurumu.Normal){
                Console.WriteLine("Dışarıya çıkmak için havanın biraz daha ısınmasını bekleyelim");
            }
            else if(sicaklik>= (int)HavaDurumu.Sicak)
                Console.WriteLine("Dışarıya çıkmak için çok sıcak bir gün");
            else if(sicaklik>= (int)HavaDurumu.Normal && sicaklik< (int)HavaDurumu.CokSicak)
                Console.WriteLine("Hadi Dışarıya Çıkalım");
            Console.Read();
        }
    }

    enum Gunler
    {
        Pazartesi = 1,
        Salı,
        Çarşamba,
        Perşembe,
        Cuma = 23,
        Cumartesi,
        Pazar
    }

    enum HavaDurumu
    {
        Soguk =5,
        Normal=20,
        Sicak = 25,
        CokSicak = 30
    }
}
