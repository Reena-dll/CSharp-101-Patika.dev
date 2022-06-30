using System;

namespace console_operatorler
{
    class Program
    {
        static void Main(string[] args)
        {
            // Atama ve İşlemli Atama
            Console.WriteLine("****** Atama İşlemleri *******");
            int x = 3;
            int y = 3;
            y = y + 2;

            Console.WriteLine(y);
            y += 2;
            Console.WriteLine(y);
            y /= 1;
            Console.WriteLine(y);
            x *= 2;
            Console.WriteLine(x);



            // Mantıksal Operatörler
            // ||, &&, !
            Console.WriteLine("****** Mantıksal Operatörler *******");

            bool isSuccess = true;
            bool isCompleted = false;

            if (isSuccess && isCompleted)
                Console.WriteLine("Perfect");

            if (isSuccess || isCompleted)
                Console.WriteLine("Great");

            if (isSuccess && !isCompleted)
                Console.WriteLine("Fine");


            // İlişkisel Operatorler
            // <, >, >=, <=, ==, !=
            Console.WriteLine("****** İlişkisel Operatorler *******");


            int a = 3;
            int b = 4;
            bool result = a < b;
            Console.WriteLine(result);
            result = a > b;
            Console.WriteLine(result);
            result = a >= b;
            Console.WriteLine(result);
            result = a <= b;
            Console.WriteLine(result);
            result = a == b;
            Console.WriteLine(result);
            result = a != b;
            Console.WriteLine(result);

            // Aritmatik Operatörler
            Console.WriteLine("****** Aritmatik İşlemleri *******");

            int sayi = 10;
            int sayi2 = 5;
            int sonuc = sayi/sayi2;
            Console.WriteLine(sonuc);
            sonuc = sayi*sayi2;
            Console.WriteLine(sonuc);
            sonuc = sayi+sayi2;
            Console.WriteLine(sonuc);
            sonuc = ++sayi;
            Console.WriteLine(sonuc);
            int sonuc2 = 20%3;
            Console.WriteLine(sonuc2);



            Console.Read();
        }
    }
}
