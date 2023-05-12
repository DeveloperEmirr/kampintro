using System;
using System.Collections.Generic;
using System.Linq;

namespace Linq
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> products = new List<Product> {
                new Product{ProductId=1,CategoryId=1,ProductName="Acer Laptop",QuantityPerUnit="32 GB Ram", UnitPrice=8000, UnitsInStock=3},
                new Product{ProductId=2,CategoryId=1,ProductName="Asus Laptop",QuantityPerUnit="16 GB Ram", UnitPrice=7500, UnitsInStock=12},
                new Product{ProductId=3,CategoryId=1,ProductName="Hp Laptop",QuantityPerUnit="8 GB Ram", UnitPrice=6870, UnitsInStock=5},
                new Product{ProductId=4,CategoryId=2,ProductName="Samsung Telefon",QuantityPerUnit="8 GB Ram", UnitPrice=8200, UnitsInStock=2},
                new Product{ProductId=5,CategoryId=2,ProductName="Apple Telefon",QuantityPerUnit="3 GB Ram", UnitPrice=17000, UnitsInStock=17},
            };

            List<Category> categories = new List<Category> {
            new Category{CategoryId=1, CategoryName="Bilgisayar"},
            new Category{CategoryId=2, CategoryName="Telefon"}
            };

            var result = from p in products
                         join c in categories
                         on p.CategoryId equals c.CategoryId
                         where p.UnitPrice>8000 
                         orderby p.ProductName descending
                         select new ProductDto {ProductId=p.ProductId, CategoryId=c.CategoryId, ProductName=p.ProductName };

            foreach (var productDto in result)
            {
                Console.WriteLine(productDto.ProductName+ "  "+productDto.CategoryId);
                
            }
            Console.Read();
        }
    }


    class ProductDto
    {
        public int ProductId { get; set; }
        public int CategoryId { get; set; }
        public string ProductName { get; set; }
    }

    class Product
    {
        public int ProductId { get; set; }
        public int CategoryId { get; set; }
        public string ProductName { get; set; }
        public string QuantityPerUnit { get; set; }
        public decimal UnitPrice { get; set; }
        public int UnitsInStock { get; set; }

    }

    class Category
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
    }
}
