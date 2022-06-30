using System;

namespace console_ifElse
{
    class Program
    {
        static void Main(string[] args)
        {
            int time = DateTime.Now.Hour;

            if (time >= 6 && time < 11)
            {
                Console.WriteLine("Günaydın");
            }
            else if (time <= 18)
            {
                Console.WriteLine("İyi Günler!");
            }
            else
            {
                Console.WriteLine("İyi Geceler");
            }

            string result = time <= 18 ? "İyi Günler" : "İyi Geceler";
            Console.WriteLine(result);

            string result2 = time >= 6 && time <= 11 ? "Günaydın" : time <= 18 ? "İyi Günler" : "İyi Geceler";

            Console.WriteLine(result2);

            Console.Read();
        }
    }
}
