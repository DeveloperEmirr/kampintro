using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    class Product //ürünle ilgili bilgileri içeriyor
    {
        //ürün id
        public int Id { get; set; }

        public int CategoryId { get; set; }

        //ürün ismi
        public string ProductName { get; set; }

        //ürün fiyatı
        public double UnitePrice { get; set; }

        //stok adeddi
        public int UnitsInStock { get; set; }

    }
}
