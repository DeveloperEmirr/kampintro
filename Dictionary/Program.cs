using System;
using System.Collections.Generic;

namespace Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            //Dictionary burada keyi int değeri string türünde tanımladık
            // ve aşağıda keylerine göre değer atama işlemi yaptık
            //mesela 1 keyi adanaya ait demek
            Dictionary<int, string> City = new Dictionary<int, string>
            {
                { 1, "Adana" },
                { 34, "İstanbul" },
                { 6, "Ankara" }
            };

            //burada dedikki key numarası 5 den büyük olanları ekranda göster
            //keyi büyük olanlar>5 İstanbul Ve Ankara Var bunları ekranda gösterecek
            foreach (var item in City)
            {
                if (item.Key>5)
                {
                    Console.WriteLine("Key= {0}, Value= {1}", item.Key, item.Value);
                }
            }

            Console.WriteLine("--------------------------------------- \n");

            //aşağıdaki şekildede Dictionary sınıfı oluşturabiilir ve yazdırabiliriz.
            var Cities = new Dictionary<string, string>
            {
                {"UK", "London, Manchester, Birmingham" },
                {"USA", "Chicago, New York, Washington"},
                {"India", "Mumbai, New Delhi, Pune"}
            };

            foreach (var country in Cities)
            {
                Console.WriteLine("Key :{0} ------  Value :{1}",country.Key,country.Value);
            }
            Console.ReadLine();

        }
    }

}
