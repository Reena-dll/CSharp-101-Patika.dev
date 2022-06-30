using System;

namespace console_hazirMetotlar_DateTime_Math
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DateTime.Now); // Günün tarihini saat dakika saniye ile getirir
            Console.WriteLine(DateTime.Now.Date); // Günün tarihini getirir gg.aa.yy
            Console.WriteLine(DateTime.Now.Day); // Ayın kaçında olduğumuz
            Console.WriteLine(DateTime.Now.Month); // Ayı getirir
            Console.WriteLine(DateTime.Now.Year); // Yılı Getirir
            Console.WriteLine(DateTime.Now.Hour); // Saati Getirir
            Console.WriteLine(DateTime.Now.Minute); // Dakikayı Getirir
            Console.WriteLine(DateTime.Now.Second); // Saniyeyi Getirir 

            Console.WriteLine(DateTime.Now.DayOfWeek); // Haftanın hangi günündeyiz.
            Console.WriteLine(DateTime.Now.DayOfYear); // İçinde bulunduğum yılın kaçıncı günündeyim
            Console.WriteLine(DateTime.Now.ToLongDateString());  // Tarihi getirir
            Console.WriteLine(DateTime.Now.ToShortDateString()); // Tarihi Getirir
            Console.WriteLine(DateTime.Now.ToLongTimeString()); // Saati Getirir with second
            Console.WriteLine(DateTime.Now.ToShortTimeString()); // Saati getirir

            Console.WriteLine(DateTime.Now.AddDays(2));
            Console.WriteLine(DateTime.Now.AddHours(3));
            Console.WriteLine(DateTime.Now.AddSeconds(30));
            Console.WriteLine(DateTime.Now.AddMonths(5));
            Console.WriteLine(DateTime.Now.AddYears(10));
            Console.WriteLine(DateTime.Now.AddMilliseconds(50));

            // DateTime Format

            Console.WriteLine(DateTime.Now.ToString("dd")); //24
            Console.WriteLine(DateTime.Now.ToString("ddd")); //Sat
            Console.WriteLine(DateTime.Now.ToString("dddd")); //Saturday

            Console.WriteLine(DateTime.Now.ToString("MM")); //04
            Console.WriteLine(DateTime.Now.ToString("ddd")); //Apr
            Console.WriteLine(DateTime.Now.ToString("dddd")); //April

            Console.WriteLine(DateTime.Now.ToString("yy")); //22
            Console.WriteLine(DateTime.Now.ToString("yyy")); //2022


            // Math Kütüphanesi
            Console.WriteLine("***** Math Kütüphanesi ******");

            Console.WriteLine(Math.Abs(-24)); // Mutlak Değer :P
            Console.WriteLine(Math.Sin(10)); // Sinüs karşılığını alır
            Console.WriteLine(Math.Cos(10)); // Cos karşılığını alır
            Console.WriteLine(Math.Ceiling(22.3)); //23  Yukarı yuvarlar 
            Console.WriteLine(Math.Round(22.3)); // 22 Yuvarlama yapar en yakın sayıya
            Console.WriteLine(Math.Floor(22.7)); // Aşağı yurvarlar 22
            Console.WriteLine(Math.Max(2,6));
            Console.WriteLine(Math.Min(2,6));
            Console.WriteLine(Math.Pow(3,4)); // üs alma
            Console.WriteLine(Math.Sqrt(9)); // Karekök alır.
            Console.WriteLine(Math.Log(9)); // 9'un e tabanında ki logaritmik karşılığı
            Console.WriteLine(Math.Exp(3)); //e üzeri 3 verir.
            Console.WriteLine(Math.Log10(10)); // 10 sayısının logoritma 10 tabanında ki karşılığı
            
            
            Console.Read();
        }
    }
}
