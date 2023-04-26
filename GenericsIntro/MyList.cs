using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsIntro
{
    class MyList<T> // <T> type demek
    {
        T[] items;
        public MyList() //ctor yazdık tab tab yaptık constructor metodu oluştu
        {// clası newlediğimiz anda burası çalışıyor.
            items = new T[0];
        }
        // tüm verileri burada tutmak için t tipinde oluşturduk
        public void Add(T item) // ben sana t olarak ne verirsem istediğim 
            //elemanın türü neyse onu kullan demek
        {
            T[] geciciDizi = items;//elemanlar kaybolmasın diye yedekledik
            items = new T[items.Length+1];
            //burası dizinin elemanını her ekledğinde bir arttır demek 
            // çünkü yukarıda eleman sayısı 0

            for (int i = 0; i < geciciDizi.Length; i++)
            {
                items[i] = geciciDizi[i];
            }// sendeki elelamnları bana geri ver ben geri tutuyum demek

            items[items.Length - 1] = item;
            //burda yeni gelen elemanları sona ekle demek
        }

        public int Length // arrayın uzunlugunu bize verir
        {
            get { return items.Length; }
        }

        public T[] Items // elemanları ekranda göstermek için kullanılır
        {
            get { return items; }
        }
    }
}
