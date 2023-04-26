using System;
using System.Collections.Generic;
using System.Text;

namespace YirmiAltiNisanDersCalisma
{
    class ProductManager
    {
        Program program = new Program();
        
        public void Add(Product product)
        {
            Console.WriteLine("Ürün Adı :"+product.ProductName+"\n" +
                "Ürün Fiyatı :"+product.UnitePrice+ "\nÜrün Stok Durumu :"+product.ProductStock);
        }
    }
}
