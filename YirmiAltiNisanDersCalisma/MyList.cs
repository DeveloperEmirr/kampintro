using System;
using System.Collections.Generic;
using System.Text;

namespace YirmiAltiNisanDersCalisma
{
    class MyList<T> // Buraya Göndereceğimiz "T" Type Dedik>
    {
        T[] items; // verileri tutmak adına bir Type Tipinde Bir Dizi oluşturduk
        public MyList()
        {
            items = new T[0];
        }

        public void Add(T item)
        {

            T[] geciciDizi = items;
            items = new T[items.Length + 1];

            for (int i = 0; i < geciciDizi.Length; i++)
            {
                items[i] = geciciDizi[i];
            }

            items[items.Length - 1] = item;
        }

        public static implicit operator MyList<T>(List<Product> v)
        {
            throw new NotImplementedException();
        }

       public T[] Items
        {
            get { return items;}
        }
    }
}
