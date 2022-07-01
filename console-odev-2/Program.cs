using System;
using System.Collections;

namespace console_odev_2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
Aşağıdaki 3 soruyu ayrı ayrı console uygulamaları açarak yazınız. Koleksiyonlar-Soru-1, Koleksiyonlar-Soru-2, Koleksiyonlar-Soru-3 isimlerini kullanınız.

Soru - 1: Klavyeden girilen 20 adet pozitif sayının asal ve asal olmayan olarak 2 ayrı listeye atın. (ArrayList sınıfını kullanara yazınız.)

Negatif ve numeric olmayan girişleri engelleyin.
Her bir dizinin elemanlarını büyükten küçüğe olacak şekilde ekrana yazdırın.
Her iki dizinin eleman sayısını ve ortalamasını ekrana yazdırın.
Soru - 2: Klavyeden girilen 20 adet sayının en büyük 3 tanesi ve en küçük 3 tanesi bulan, her iki grubun kendi içerisinde ortalamalarını alan ve bu ortalamaları ve ortalama toplamlarını console'a yazdıran programı yazınız. (Array sınıfını kullanarak yazınız.)

Soru - 3: Klavyeden girilen cümle içerisindeki sesli harfleri bir dizi içerisinde saklayan ve dizinin elemanlarını sıralayan programı yazınız.
            */
            //Koleksiyon1();
            //Koleksiyon2();
            Koleksiyon3();
            Console.Read();
        }

        public static void Koleksiyon1()
        {
            Console.WriteLine("***** HoşGeldiniz *****");
            Console.WriteLine();
            Console.WriteLine("Lütfen 20 adet pozitif tam sayı giriniz");
            ArrayList arrAsal = new ArrayList();
            ArrayList arrNotAsal = new ArrayList();

            for (int i = 0; i < 20; i++)
            {
            enbas:
                int kontrol = 0;
                Console.Write(i + 1 + ". Sayıyı Giriniz: ");
                int number;
                bool result = int.TryParse(Console.ReadLine(), out number);
                if (result)
                {
                    if (number >= 1)
                    {
                        if (number == 1)
                        {
                            arrNotAsal.Add(number);
                        }
                        else
                        {

                            for (int z = 2; z < number; z++)
                            {

                                if (number % z == 0) //Kalansız bölünüyormu?
                                {
                                    kontrol++;
                                    break; //Diğer sayılara bakmaya gerek duymuyoruz.
                                }
                            }
                            if (kontrol != 0)
                            {
                                arrNotAsal.Add(number);
                            }

                            else
                            {
                                arrAsal.Add(number);
                            }

                            kontrol = 0;


                        }
                    }
                    else if (number < 1)
                    {
                        Console.WriteLine("Pozitif Tam Sayı Giriniz...");
                        goto enbas;
                    }



                }
                else
                {
                    Console.WriteLine("Yanlış Değer Girdiniz:");
                    goto enbas;
                }

            }

            arrAsal.Sort();
            arrAsal.Reverse();
            arrNotAsal.Sort();
            arrNotAsal.Reverse();

            int ortAsal = 0;
            int ortNotAsal = 0;
            foreach (var item in arrAsal)
            {
                Console.WriteLine("Asal Sayılar: " + item);
                ortAsal += Convert.ToInt32(item);
            }
            foreach (var item in arrNotAsal)
            {
                Console.WriteLine("Asal Olmayan Sayılar: " + item);
                ortNotAsal += Convert.ToInt32(item);
            }
            Console.WriteLine("Toplam Asal Sayısı: " + arrAsal.Count);
            Console.WriteLine("Toplam Asal Olmayan Sayısı: " + arrNotAsal.Count);
            Console.WriteLine("Asal Sayıların Ortalaması: " + ortAsal / arrAsal.Count);
            Console.WriteLine("Asal Olmayan Sayıların Ortalaması: " + ortNotAsal / arrNotAsal.Count);




        }

        public static void Koleksiyon2()
        {
            Console.WriteLine("***** HoşGeldiniz *****");
            Console.WriteLine();
            Console.WriteLine("Lütfen 20 adet pozitif tam sayı giriniz");
            int[] arr = new int[20];
            for (int i = 0; i < 20; i++)
            {
            enbas:

                Console.Write(i + 1 + ". Sayıyı Giriniz: ");
                int number;
                bool result = int.TryParse(Console.ReadLine(), out number);
                if (result)
                {
                    arr[i] = number;
                }
                else
                {
                    Console.WriteLine("Yanlış Değer Girdiniz:");
                    goto enbas;
                }
            }

            Array.Sort(arr);
            Console.WriteLine("En Büyük 3 Sayı: " + arr[19] + " " + arr[18] + " " + arr[17]);
            Console.WriteLine("En Küçük 3 Sayı: " + arr[0] + " " + arr[1] + " " + arr[2]);
            int enBuyukOrt = (arr[19] + arr[18] + arr[17]) / 3;
            int enKucukOrt = (arr[0] + arr[1] + arr[2]) / 3;
            Console.WriteLine("En Büyük Sayıların Ortalaması: " + enBuyukOrt);
            Console.WriteLine("En Küçük Sayıların Ortalaması: " + enKucukOrt);
            int genelOrt = (enBuyukOrt + enKucukOrt) / 2;
            Console.WriteLine("İki Ortalamanın Ortalaması: " + genelOrt);
        }

        public static void Koleksiyon3()
        {
            Console.WriteLine("***** HoşGeldiniz *****");
            Console.WriteLine();
            Console.Write("Bir Cümle Giriniz: ");
            string cumle;
            string sesli = "aeıioöuü";
            cumle = Console.ReadLine();
            int sayac = 0;
            for (int i = 0; i < cumle.Length; i++)
            {
                //karakter katarkter kontrol ediyoruz.
                if (sesli.Contains(cumle[i]))
                {
                    Console.Write(cumle[i]+", ");
                    sayac++;
                }
            }
            Console.WriteLine();
            Console.WriteLine("Yukarıdaki ifadede toplam {0} \ntane sesli harf vardır.", sayac);
            Console.ReadLine();
        }
    }
}
