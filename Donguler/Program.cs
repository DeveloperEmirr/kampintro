using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
          // array - dizi kullanımı

            //dizi tanımlama
            string[] kurslar = new string[]
            { "Yazılım Geliştirici Yerleştirme Kampı",
                "Programlamaya Başlangıç İçin Temel Kurs" ,
                "Java",
                "Phtyon"
            
            };
            //foreach kurslar dizisini tek tek dolaş ve dataları "string veriler" kısmına ata
            //altta atadıktan sonra ekranda yazdırdı for döngüsünün diğer kolay kullanımı 
            foreach (string veriler in kurslar)
            {
                Console.WriteLine(veriler);
            }


            //for (int i = 0; i < kurslar.Length; i++)
            //{
            //    Console.WriteLine(kurslar[i]);
            //}
            Console.ReadLine();
        }
    }
}
