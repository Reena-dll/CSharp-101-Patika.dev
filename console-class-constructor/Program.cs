using System;

namespace console_class_constructor
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("******** Çalışan 1 ********");
            Calisan calisan1 = new Calisan("Ayşe","Kara",23415634,"İnsan Kaynakları");
            calisan1.CalisanBilgileri();

            Console.WriteLine("******* Çalışan 2 ********");
            Calisan calisan2 = new Calisan();
            calisan2.Ad = "Oğuzhan";
            calisan2.Soyad = "Sadıkoğlu";
            calisan2.No = 77777777;
            calisan2.Departman = "Bilişim Teknolojileri";      
            calisan2.CalisanBilgileri();

            Console.WriteLine("****** Çalışan 3 ********");
            Calisan calisan3 = new Calisan("Barış","Akarsu");
            calisan3.CalisanBilgileri();



            Console.Read();
        }
    }

    class Calisan
    {
        public string Ad;
        public string Soyad;
        public int No;
        public string Departman;

        public Calisan(string ad, string soyad, int no, string departman)
        {
            this.Ad = ad;
            this.Soyad = soyad;
            this.No = no;
            this.Departman = departman;
        }

         public Calisan(string ad, string soyad)
        {
            this.Ad = ad;
            this.Soyad = soyad;       
        }

        public Calisan(){}




        public void CalisanBilgileri()
        {
            Console.WriteLine("Çalışan Adı: {0}", Ad);
            Console.WriteLine("Çalışan Soyadı: {0}", Soyad);
            Console.WriteLine("Çalışan No: {0}", No);
            Console.WriteLine("Çalışan Departmanı: {0}", Departman);
        }
    }
}
