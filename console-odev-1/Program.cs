using System;

namespace console_odev_1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
ÖDEV Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin(n). Sonrasında kullanıcıdan n adet pozitif sayı girmesini isteyin. Kullanıcının girmiş olduğu sayılardan çift olanlar console'a yazdırın.

Bir konsol uygulamasında kullanıcıdan pozitif iki sayı girmesini isteyin (n, m). Sonrasında kullanıcıdan n adet pozitif sayı girmesini isteyin. Kullanıcının girmiş olduğu sayılardan m'e eşit yada tam bölünenleri console'a yazdırın.

Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin (n). Sonrasında kullanıcıdan n adet kelime girmesi isteyin. Kullanıcının girişini yaptığı kelimeleri sondan başa doğru console'a yazdırın.

Bir konsol uygulamasında kullanıcıdan bir cümle yazması isteyin. Cümledeki toplam kelime ve harf sayısını console'a yazdırın.
            */

            //ciftTekSayi();,
            //bolenSayi();
            //arrayRevurse();
            //checkSentence();
            Console.Read();


        }

        public static void ciftTekSayi()
        {
            Console.WriteLine("***** HoşGeldiniz *****");
            Console.WriteLine();
            Console.Write("Lütfen pozitif bir sayı giriniz: ");
            int number = int.Parse(Console.ReadLine());
            int[] array = new int[number];
            Console.WriteLine("Lütfen " + number + " adet sayı giriniz");

            for (int i = 0; i < number; i++)
            {
                Console.Write(i + 1 + ". Sayıyı Giriniz: ");
                array[i] = int.Parse(Console.ReadLine());
            }


            Console.WriteLine("Çift Sayılar");

            foreach (var item in array)
            {
                if (item % 2 == 0)
                    Console.Write(item + " ");
            }

            Console.WriteLine();
            Console.WriteLine("Tek Sayılar");

            foreach (var item in array)
            {
                if (item % 2 == 1)
                    Console.Write(item + " ");
            }

        }
        public static void bolenSayi()
        {
            Console.WriteLine("***** HoşGeldiniz *****");
            Console.WriteLine();
            Console.WriteLine("Lütfen pozitif iki sayı giriniz");
            Console.Write("1. Sayıyı Giriniz: ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("2. Sayıyı Giriniz: ");
            int m = int.Parse(Console.ReadLine());
            int[] array = new int[n];
            Console.WriteLine("Lütfen " + n + " adet pozitif sayı giriniz.");

            for (int i = 0; i < n; i++)
            {
                Console.Write(i + 1 + ". Sayıyı giriniz: ");
                array[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine();

            foreach (var item in array)
            {
                if (item == m)
                {
                    Console.WriteLine("M Sayısına Eşit Olan Sayı: " + item);
                }
                else if (item % m == 0)
                {
                    Console.WriteLine("M Sayısına Tam Bölünen Sayı: " + item);
                }
                else
                {
                    Console.WriteLine(item + " için herhangi bir eşleşme olmadı.");
                }
            }
        }
        public static void arrayRevurse()
        {
            Console.WriteLine("***** HoşGeldiniz *****");
            Console.WriteLine();
            Console.Write("Lütfen pozitif bir sayı giriniz: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Lütfen " + n + " adet kelime giriniz");
            string[] array = new string[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write(i + 1 + ". Kelimeyi Giriniz: ");
                array[i] = Console.ReadLine();
            }

            Array.Reverse(array);
            foreach (var item in array)
            {
                Console.Write(item + ", ");
            }

        }
        public static void checkSentence()
        
        {
            Console.WriteLine("***** HoşGeldiniz *****");
            Console.WriteLine();
            Console.Write("Lütfen Bir Cümle Yazınız: ");
            string sentence = Console.ReadLine();
            string[] array = sentence.Split(' ');
            char[] charArr = sentence.ToCharArray();  
             Console.WriteLine("Cümlenizde ki toplam kelime sayısı: "+ array.Length);
             Console.WriteLine("Cümlenizde ki toplam harf sayısı: "+ charArr.Length);

            

        }
   
        // Mission Completed
   
    }
}
