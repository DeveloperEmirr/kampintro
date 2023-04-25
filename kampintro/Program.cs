using System;

namespace kampintro
{
    class Program
    {
        static void Main(string[] args)
        {
            string kategoriEtiketi = "Kategori";
           
            int ogrenciSayisi = 320000000;  // tam sayılar gösterilir
            double faizOranı = 1.45; // ondalıklı sayılar gösterilir
            bool sistemeGirisYapmismi = true; // bool tipi varmı yokmu demek

            double dolarDun = 7.35;
            double dolarBugun = 7.45;

            if (dolarDun>dolarBugun)
            {
                Console.WriteLine("Azalış butonu");
            }
            else if (dolarDun<dolarBugun)
            {
                Console.WriteLine("Artış Butonu");
            }
            else
            {
                Console.WriteLine("Eşittir Butonu");
            }










            ////burada dedikk ki işte sisteme giriş yap false ise ekranda kategori metni gözüksün dedik
            //if (sistemeGirisYapmismi==false)
            //{
            //    Console.WriteLine(kategoriEtiketi); //metinsel değerler gösterilir

            //}
            //else
            //{
            //    Console.WriteLine("giriş yap butonu");
            //}
            Console.ReadLine();

        }
    }
}
