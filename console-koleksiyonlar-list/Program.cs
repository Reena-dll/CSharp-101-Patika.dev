using System;
using System.Collections.Generic;

namespace console_koleksiyonlar_list
{
    class Program
    {
        static void Main(string[] args)
        {
            // List<T> class
            // System.Collections.Generic
            // T -> Object türündedir. Listenin içerisinde ki nesnelerin tipini belirtir.

            List<int> sayiListesi = new List<int>();

            sayiListesi.Add(23);
            sayiListesi.Add(10);
            sayiListesi.Add(4);
            sayiListesi.Add(5);
            sayiListesi.Add(92);
            sayiListesi.Add(34);

            List<string> renkListesi = new List<string>();

            renkListesi.Add("Kırmızı");
            renkListesi.Add("Mavi");
            renkListesi.Add("Turuncu");
            renkListesi.Add("Sarı");
            renkListesi.Add("Yeşil");

            // Count
            Console.WriteLine(renkListesi.Count);
            Console.WriteLine(sayiListesi.Count);

            // Foreach ve List.ForEach ile elemanlara erişim
            foreach(var item in sayiListesi)
                Console.WriteLine(item);

            foreach(var item in renkListesi)
                Console.WriteLine(item);

            sayiListesi.ForEach(sayi=> Console.WriteLine(sayi));
            renkListesi.ForEach(renk=> Console.WriteLine(renk));

            // Listeden eleman çıkarma

            sayiListesi.Remove(4); // Eleman 4'ü çıkarır
            renkListesi.Remove("Yeşil");
            sayiListesi.RemoveAt(0);
            renkListesi.RemoveAt(1);

            sayiListesi.ForEach(sayi=> Console.WriteLine(sayi));
            renkListesi.ForEach(renk=> Console.WriteLine(renk));

            // Liste içerisinde arama

            if(sayiListesi.Contains(10))
                Console.WriteLine("10 Liste içerisinde bulundu!");
            

            // Eleman ile indekse erişme

            Console.WriteLine(renkListesi.BinarySearch("Sarı"));

            // Diziyi List'e çevirme

            string[] hayvanlar = {"Kedi", "Köpek", "Kuş"};

            List<string> hayvanListesi = new List<string>(hayvanlar);

            // Listeyi nasıl temizlerim
            hayvanListesi.Clear();

            // Liste içerisinde nesne tutmak
            List<Kullanıcılar> kullaniciListesi = new List<Kullanıcılar>();
            Kullanıcılar kullanici1 = new Kullanıcılar();
            kullanici1.Isim = "Ayşe";
            kullanici1.Soyisim = "Yılmaz";
            kullanici1.Yas = 26;

            Kullanıcılar kullanici2 = new Kullanıcılar();
            kullanici2.Isim = "Özcan";
            kullanici2.Soyisim = "Çalışkan";
            kullanici2.Yas = 26;

            kullaniciListesi.Add(kullanici1);
            kullaniciListesi.Add(kullanici2);

            List<Kullanıcılar> yeniListe = new List<Kullanıcılar>();
            yeniListe.Add(new Kullanıcılar(){
                Isim = "Oğuzhan",
                Soyisim = "Sadıkoğlu",
                Yas = 22
            });

            foreach(var item in kullaniciListesi){
                Console.WriteLine("Kullanıcı Adı: "+item.Isim); 
                Console.WriteLine("Kullanıcı Soyadı: "+item.Soyisim); 
                Console.WriteLine("Kullanıcı Yaşı: "+item.Yas); 

            }

            

            Console.Read();
        }
    }

    public class Kullanıcılar{
        private string isim;
        private string soyisim;
        private int yas;

        public string Isim { get => isim; set => isim = value; }
        public string Soyisim { get => soyisim; set => soyisim = value; }
        public int Yas { get => yas; set => yas = value; }
    }
}
