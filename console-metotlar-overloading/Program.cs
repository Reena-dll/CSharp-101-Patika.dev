using System;

namespace console_metotlar_overloading
{
    class Program
    {
        static void Main(string[] args)
        {
            // out parametreler

            string sayi = "9999";

            bool sonuc = int.TryParse(sayi, out int outSayi);
            if (sonuc)
            {
                Console.WriteLine("Başarılı");
                Console.WriteLine(outSayi);
            }
            else
            {
                Console.WriteLine("Başarısız");
            }

            Metotlar instance = new Metotlar();
            instance.Topla(2,3,out int toplamSonuc);
            Console.WriteLine(toplamSonuc);


            // Metot Aşırı Yükleme - Overloading

            int ifade = 999;
            instance.EkranaYazdir(ifade);
            instance.EkranaYazdir("Selam");
            instance.EkranaYazdir("Oğuzhan"+" Sadıkoğlu");

            // Metot imzası
            // MetotAdı + parametre sayisi + parametre

            Console.Read();
        }
    }

    class Metotlar
    {
        public void Topla(int a, int b, out int toplam)
        {
            toplam = a+b;
        }

        public void EkranaYazdir(string veri){
            Console.WriteLine(veri);
        }
        public void EkranaYazdir(int veri){
            Console.WriteLine(veri);
        }

        public void EkranaYazdir(string veri1, string veri2){
            Console.WriteLine(veri1+veri2);
        }
    }
}
