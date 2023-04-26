using System;

namespace OOP1
{
    class Program
    {
        static void Main(string[] args)
        {
            //productlara verileri girdik bu 2 kısımda
            Product product = new Product();
            product.Id = 1;
            product.CategoryId = 2;
            product.ProductName = "Masa";
            product.UnitePrice = 500;
            product.UnitsInStock = 3;

            Product product2 = new Product {
                Id=2,
                CategoryId=5,
                ProductName="Kalem",
                UnitsInStock=5,
                UnitePrice=35
            };
            //PascalCase   //camleCase
            //aşağıda verileri prodcutmanagerdaki ekle metoduna gönderdik
            ProductManager productmanager = new ProductManager();
            productmanager.Add(product);
        }
    }
}
