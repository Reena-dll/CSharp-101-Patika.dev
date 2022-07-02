using System;

namespace console_class_field_erisimBelirleyici
{
    class Program
    {
        static void Main(string[] args)
        {
            // class SSinifAdi{
            //     {Erişim Belirleyici} {Veri Tipi} ÖzellikAdi;
            //     {Erişim Belirleyici} {GenericUriParser Dönüş Tipi} MetotAdi {(Parametre Listesi)}
            //     {
            //         // Metot Komutları
            //     }
            // }

            // Erişim Belirliyiciler
            // * Public = Programın her noktasından erişilebilir
            // * Private = Sadece tanımlandığı sınıf içerisinden erişilebilir.
            // * Internal = Sadece kendi bulunduğu proje içerisinde erişebilen, değişkenlere ve metotlara denir
            // * Protected = Sadece tanımlandığı sınıfta veya o sınıftan kalıtım miras alan diğer sınıflarda kullanılabilir

            Calisan calisan1 = new Calisan();
            calisan1.Ad = "Ayşe";
            calisan1.Soyad = "Kara";
            calisan1.No = 23415634;
            calisan1.Departman = "İnsan Kaynakları";

            calisan1.CalisanBilgileri();
            Console.WriteLine();

            Calisan calisan2 = new Calisan();
            calisan2.Ad = "Oğuzhan";
            calisan2.Soyad = "Sadıkoğlu";
            calisan2.No = 77777777;
            calisan2.Departman = "Bilişim Teknolojileri";

            calisan2.CalisanBilgileri();

            Console.Read();

        }
    }

    class Calisan
    {
        public string Ad;
        public string Soyad;
        public int No;
        public string Departman;

        public void CalisanBilgileri()
        {
            Console.WriteLine("Çalışan Adı: {0}", Ad);
            Console.WriteLine("Çalışan Soyadı: {0}", Soyad);
            Console.WriteLine("Çalışan No: {0}", No);
            Console.WriteLine("Çalışan Departmanı: {0}", Departman);
        }
    }
}
