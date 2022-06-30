using System;

namespace console_metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            // erisim_belirteci geri_donustipi metot_adi(parametreListesi/arguman)
            //{
            //// komutlar;
            //}

            int a = 2;
            int b = 3;

            Console.WriteLine(a + b);

            int result = Topla(a, b);
            Console.WriteLine(result);

            Metotlar ornek = new Metotlar();
            ornek.EkranaYazdır(result.ToString());

            int result2 = ornek.ArttırVeTopla(ref a,ref b);
            ornek.EkranaYazdır(result2.ToString());
            ornek.EkranaYazdır((a+b).ToString());

            Console.Read();
        }

        static int Topla(int deger1, int deger2)
        {
            return (deger1 + deger2);
        }


    }

    class Metotlar
    {
        public void EkranaYazdır(string veri)
        {
            Console.WriteLine(veri);
        }

        public int ArttırVeTopla(ref int deger1,ref int deger2)
        {
            deger1 += 1;
            deger2 += 1;
            return deger1 + deger2;
        }
    }
}
