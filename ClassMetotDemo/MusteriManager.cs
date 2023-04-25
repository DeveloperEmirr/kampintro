using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void MusteriSil(Musteri musteri)
        {
            musteri.MusteriAdi = "";
            musteri.MusteriSoyadi = "";
            musteri.MusteriTc = "";
        }

        public void MusteriEkle(Musteri musterii)
        {
            /*
             Bu kısımda müşteri bilgisi girdim elle diğer yerden ve müsteri ekleyince
            alt kısımda ekranda göster dedim.
             */
            Console.WriteLine(musterii.MusteriTc + " \t" + musterii.MusteriAdi + " \t\t" + musterii.MusteriSoyadi);
        }

        public void MusteriListele(Musteri musteri, Musteri musteri2, Musteri musteri3)
        {
            /*
             burada 3 tane müşteriyi çektim vaar olan bilerek böle çektim diğer tarafta
            MusteriListele metodunu 3 kere çağırmıyayım diye 
            ve burada her müsterilerin bilgilerini tablo şeklinde listeleme işlemini yaptırdım
             */
            Console.WriteLine("Tc\t\tAdı \t\tSoyadı");
            Console.WriteLine("---------------------------------------------------------");
            Console.WriteLine(musteri.MusteriTc+" \t"+ musteri.MusteriAdi+ " \t\t" + musteri.MusteriSoyadi);
            Console.WriteLine(musteri2.MusteriTc + " \t" + musteri2.MusteriAdi + " \t\t" + musteri2.MusteriSoyadi);
            Console.WriteLine(musteri3.MusteriTc + " \t" + musteri3.MusteriAdi + " \t\t" + musteri3.MusteriSoyadi);
        }
    }
}
