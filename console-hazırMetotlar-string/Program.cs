using System;

namespace console_hazırMetotlar_string
{
    class Program
    {
        static void Main(string[] args)
        {
            string degisken = "Dersimiz CSharp, Hoşgeldiniz!";
            string degisken2 = "CSharp";
            // Length : Cümle içerisinde kaç tane harf olduğunu öğrenmek için

            Console.WriteLine(degisken.Length);

            // ToUpper, ToLower = Karakterleri ya büyütür ya da küçültür.

            Console.WriteLine(degisken.ToUpper());
            Console.WriteLine(degisken.ToLower());

            // Concat = String ifadelerde birleştirme işlemi yapar.

            Console.WriteLine(String.Concat(degisken," Merhaba"));
            
            // Compare, CompareTo = Birinci değişken ikinci değişkene eşit olursa 0 döndürür.
            // Birinci değişken ikinci değişkenden büyük olursa 1 döndürür
            // Birinci değişken ikinci değişkenden daha küçük olursa -1 döndürür.

            Console.WriteLine(degisken.CompareTo(degisken2));
            Console.WriteLine(String.Compare(degisken,degisken2,true));// Büyük küçük harf duyarsız olur true dersek, false dersek duyarlı olur.
            Console.WriteLine(String.Compare(degisken,degisken2,false));
            
            //Contains = Birinci değişkende 2. değişken var mı? İçerisinde içeriyor mu?
            // İçeriyor ise true, içermiyor ise false döndürür.

            Console.WriteLine(degisken.Contains(degisken2));
            Console.WriteLine(degisken.EndsWith("Hoşgeldiniz!")); // String değerinin sonu bu ifadeyi içeriyor mu ?
            Console.WriteLine(degisken.StartsWith("Merhaba"));

            // IndexOf = Aradığımız değerin kaçıncı indekste olduğunu verir

            Console.WriteLine(degisken.IndexOf("CS"));
            Console.WriteLine(degisken.IndexOf("Oğuzhan"));// Hiç bir değer bulamaz ise -1 döndürür.
            Console.WriteLine(degisken.LastIndexOf("i"));// karşılaştığı son i değerinin indeks numarasını getirir
            
            //Insert = İstediğimiz indeks numarasından başlayarak string değere yazı ekleriz.

            Console.WriteLine(degisken.Insert(0,"Merhaba! "));

            //PadLeft, PadRight

            Console.WriteLine(degisken + degisken2.PadLeft(30));
            Console.WriteLine(degisken + degisken2.PadLeft(30,'*'));
            Console.WriteLine(degisken.PadRight(50)+ degisken2);
            Console.WriteLine(degisken.PadRight(50,'-')+ degisken2);

            // Remove

            Console.WriteLine(degisken.Remove(10));
            Console.WriteLine(degisken.Remove(5,3));
            Console.WriteLine(degisken.Remove(0,1));

            // Replace

            Console.WriteLine(degisken.Replace("CSharp","C#"));
            Console.WriteLine(degisken.Replace(" ","*"));

            // Split = String değeri boşluklara göre parçaya böle ve diziye aktarır!

            Console.WriteLine(degisken.Split(' ')[1]);

            // Substring

            Console.WriteLine(degisken.Substring(4));
            Console.WriteLine(degisken.Substring(4,6));
          

            //
            Console.Read();


        }
    }
}
