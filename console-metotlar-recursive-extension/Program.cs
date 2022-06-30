using System;

namespace console_metotlar_recursive_extension
{
    class Program
    {
        static void Main(string[] args)
        {
            // Rekürsif -- Öz yinelemeli
            //3^4 = 3*3*3*3
            int result = 1;
            for (int i = 1; i < 5; i++)
            {
                result *= 3;
            }
            Console.WriteLine(result.ToString());

            Islemler instance = new();

            Console.WriteLine(instance.Expo(3, 4).ToString());

            // Extension Metotlar

            string ifade = "Oğuzhan Sadıkoğlu";
            bool sonuc = ifade.checkSpaces();
            Console.WriteLine(sonuc);
            if (sonuc)
            {
                Console.WriteLine(ifade.removeWhiteSpaces());
            }

            Console.WriteLine(ifade.makeUpperCase());
            Console.WriteLine(ifade.makeLowerCase());

            int[] dizi = { 9, 3, 6, 2, 1, 5, 0 };
            dizi.sortArray();
            dizi.ekranaYazdir();
       
            int sayi = 5;
            Console.WriteLine(sayi.isEvenNumber());

            Console.WriteLine(ifade.getFirstCharacter());

            Console.Read();
        }
    }

    public class Islemler
    {

        public int Expo(int sayi, int üs)
        {
            if (üs < 2)
            {
                return sayi;
            }
            return Expo(sayi, üs - 1) * sayi;
        }

    }

    public static class Extension
    {
        public static bool checkSpaces(this string param)
        {
            return param.Contains(" ");

        }

        public static string removeWhiteSpaces(this string param)
        {
            string[] dizi = param.Split(" ");
            return string.Join("", dizi);
        }

        public static string makeUpperCase(this string param)
        {
            return param.ToUpper();
        }
        public static string makeLowerCase(this string param)
        {
            return param.ToLower();
        }

        public static int[] sortArray(this int[] param){
            Array.Sort(param);
            return param;
        }

        public static void ekranaYazdir(this int[] param){
            foreach(var item in param){
                Console.Write(item+", ");
            }
            Console.WriteLine();
        }

        public static bool isEvenNumber(this int param){
            return param%2 == 0;
        }

        public static string getFirstCharacter(this string param){
            return param.Substring(0,1);
        }

    }
}
