using System;

namespace Classintro
{
    class Program
    {
        static void Main(string[] args)
        {
            //bir class yapısını tanımladık.
            Kurs kurs1 = new Kurs();
            //aşağıdada kurslara değerler verdik
            kurs1.KursAdi = "C#";
            kurs1.Egitmen = "Engin Demiroğ";
            kurs1.IzlenmeOrani = 68;

            Kurs kurs2 = new Kurs();
            kurs2.KursAdi = "Java";
            kurs2.Egitmen = "Kerem Varış";
            kurs2.IzlenmeOrani = 64;

            Kurs kurs3 = new Kurs();
            kurs3.KursAdi = "Phyton";
            kurs3.Egitmen = "Berkay Bilgim";
            kurs3.IzlenmeOrani = 80;

            // ve burada bir dizi yapısı oluşturduk ve yukarıdaki metotları
            // dizinin içerisine attık daha sonra aşğıda foreach döngüsü yardımı ile de 
            // yazdırma işlemi gerçekleştirdik.
            Kurs[] kurslar = new Kurs[] {kurs1,kurs2,kurs3};
            foreach (Kurs data in kurslar)
            {
                Console.WriteLine(data.KursAdi + ":" +data.Egitmen);
            }

            Console.ReadLine();
        }
    }

    class Kurs
    {
        //prop yazıp 2 kere tab yaparsak alttaki yapılardan birini oluşturuyor.
        public string KursAdi { get; set; }
        public string Egitmen { get; set; }
        public int IzlenmeOrani { get; set; }
    }
}
