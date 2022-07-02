using System;

namespace console_class_encapsulation_property
{
    class Program
    {
        static void Main(string[] args)
        {
            Ogrenci ogrenci1 = new Ogrenci();
            ogrenci1.Isim = "Ayşe";
            ogrenci1.Soyisim = "Yılmaz";
            ogrenci1.OgrenciNo = 293;
            ogrenci1.Sinif = 3;
            ogrenci1.SinifAtlat();
            ogrenci1.OgrenciGetir();

            Ogrenci ogrenci2 = new Ogrenci("Deniz","Arda",256,1);
            ogrenci2.SinifDusur();
            ogrenci2.SinifDusur();
            ogrenci2.OgrenciGetir();

            Console.Read();

        }
    }

    class Ogrenci
    {
        private string isim;
        private string soyisim;
        private int ogrenciNo;
        private int sinif;

        public string Isim { get => isim; set => isim = value; }
        public string Soyisim { get => soyisim; set => soyisim = value; }
        public int OgrenciNo { get => ogrenciNo; set => ogrenciNo = value; }
        public int Sinif
        {
            get => sinif;
            set
            {
               if(value<1){
                Console.WriteLine("Sınıf En Az 1 Olabilir");
                sinif =1;
               }else
                 sinif= value;
            }
        }



        public Ogrenci(string ısim, string soyisim, int ogrenciNo, int sinif)
        {
            Isim = ısim;
            Soyisim = soyisim;
            OgrenciNo = ogrenciNo;
            Sinif = sinif;
        }

        public Ogrenci() { }

        public void OgrenciGetir()
        {
            Console.WriteLine("***** Öğrenci Bilgileri *****");
            Console.WriteLine("Oğrenci Adı: {0}", this.Isim);
            Console.WriteLine("Oğrenci Soyadı: {0}", this.Soyisim);
            Console.WriteLine("Oğrenci No: {0}", this.OgrenciNo);
            Console.WriteLine("Oğrenci Sınıf: {0}", this.Sinif);
        }

        public void SinifAtlat()
        {
            this.Sinif = this.Sinif + 1;
        }

        public void SinifDusur()
        {
            this.Sinif = this.Sinif - 1;
        }


    }
}
