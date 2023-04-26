using System;
using System.Collections.Generic;

namespace Koleksiyonlar
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] isimler = new string[]
            //{"engin","murat","kerm","halil" };
            //Console.WriteLine(isimler[0]);

            //list kullanımı aşağıda 2 şekilde kullanımını gösterdik
            // bir string listesi oluşturduk
            //List<string> isimler2 = new List<string>();
            //isimler2.Add("Emircan");

            List<string> isimler2 = new List<string> {"emircan","Ela" };
            Console.WriteLine(isimler2[0]);
            Console.WriteLine(isimler2[1]);
            isimler2.Add("Eylül");
            Console.WriteLine(isimler2[2]);
            Console.WriteLine(isimler2[0]);
           
            Console.ReadLine();

        }
    }
}
