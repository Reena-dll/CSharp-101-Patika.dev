using System;

namespace console_tryCath
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Bir sayı giriniz: ");
                int sayi = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Girmiş olduğunuz sayı: " + sayi);

            }

            catch (Exception ex)
            {
                Console.WriteLine("Hatayı Ekrana Yazdırdım." + ex.Message.ToString());
            }
            finally
            {
                Console.WriteLine("İşlem tamamlandı.");
            }

            try
            {
                //int a = int.Parse(null);
                // int a = int.Parse("test");
                int a = int.Parse("-200000000000");

                
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine("Boş Değer Girdiniz");
                Console.WriteLine(ex);
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Format Uygun Değil");
                Console.WriteLine(ex);
            }
            catch (OverflowException ex)
            {
                Console.WriteLine("Çok küçük ya da çok büyük bir değer girdiniz.");
                Console.WriteLine(ex);
            }

            finally
            {
                Console.WriteLine("İşlem başarıyla tamamlandı.");
            }

            Console.Read();
        }
    }
}
