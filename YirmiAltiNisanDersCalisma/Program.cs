using System;
using System.Collections.Generic;

namespace YirmiAltiNisanDersCalisma
{
    class Program
    {
        static void Main(string[] args)
        { 
            Product product = new Product
            {
                Id = 1, ProductName = "Kısa Kol Tişört",
                ProductStock = 55, UnitePrice = 72.50
            };

            Product product2 = new Product
            {
                Id = 2,
                ProductName = "Uzun Kol Tişört",
                ProductStock = 13,
                UnitePrice = 122.90
            };

            Product product3 = new Product
            {
                Id = 3,
                ProductName = "Sweatshirt",
                ProductStock = 17,
                UnitePrice = 260
            };

                MyList<Product> veriler = new MyList<Product>();
                veriler.Add(product);
                veriler.Add(product2);
                veriler.Add(product3);

                foreach (var datalar in veriler.Items)
                {
                    Console.WriteLine(datalar.ProductName);
                }

            Console.ReadLine();

        }
    }
}
