using System;

namespace Uygulama1
{
    class Program
    {
        static void Main(string[] args)
        {
            //clasımızı çağıralım
            SoyAgaci veriler = new SoyAgaci();
            veriler.Tc = "12456812058";
            veriler.KisiAdi = "Emircan";
            veriler.KisiSadi = "Yılmaz";
            veriler.Yas = 22;

            SoyAgaci veriler2 = new SoyAgaci();
            veriler2.Tc = "32165498778";
            veriler2.KisiAdi = "Eylül";
            veriler2.KisiSadi = "Eryılmaz";
            veriler2.Yas = 6;

            SoyAgaci veriler3 = new SoyAgaci();
            veriler3.Tc = "98745632103";
            veriler3.KisiAdi = "Elanur";
            veriler3.KisiSadi = "Öztürk";
            veriler3.Yas = 22;

            SoyAgaci[] kisiler = new SoyAgaci[]
            {
                veriler,veriler2,veriler3
            };

            Console.WriteLine("TC              Adı            Soyadı            Yaşı");
            Console.WriteLine("---------------------------------------------------------------------");
            //yazdırma işlemi yapalım
            for (int i = 0; i < kisiler.Length; i++)
            {
                Console.WriteLine(kisiler[i].Tc+ "     "+ kisiler[i].KisiAdi+ "        "+kisiler[i].KisiSadi+ "             "+kisiler[i].Yas);           
                if (i<2)
                {
                    Console.WriteLine("---------------------------------------------------------------------");
                }
            }
            Console.ReadLine();
        }
    }


    class SoyAgaci
    {
        public string Tc { get; set; }
        public string KisiAdi { get; set; }
        public string KisiSadi { get; set; }
        public int Yas { get; set; }
    }
}
