using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    class ProductManager //ürünle ilgili operasyonlar içeriyor
    {

        public void Add(Product products)
        {
           
            Console.WriteLine(products.ProductName+ " Eklendi");
        }

        public void Update(Product products)
        {
            Console.WriteLine(products.ProductName + " Güncellendi");
                   
        }
    }
}
