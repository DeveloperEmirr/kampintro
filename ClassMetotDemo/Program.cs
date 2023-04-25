using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteribilgi = new Musteri();
            musteribilgi.MusteriAdi = "Emir";
            musteribilgi.MusteriSoyadi = "Yılmaz";
            musteribilgi.MusteriTc = "12345678998";

            Musteri musteribilgi2 = new Musteri();
            musteribilgi2.MusteriAdi = "Ahmet";
            musteribilgi2.MusteriSoyadi = "Öz";
            musteribilgi2.MusteriTc = "9874563212";

            Musteri musteribilgi3 = new Musteri();
            musteribilgi3.MusteriAdi = "Efe";
            musteribilgi3.MusteriSoyadi = "Sönmez";
            musteribilgi3.MusteriTc = "36985214789";

            Musteri musteribilgi4 = new Musteri();
            musteribilgi4.MusteriAdi = "Ayşe";
            musteribilgi4.MusteriSoyadi = "Gül";
            musteribilgi4.MusteriTc = "741582369878";

            MusteriManager manager = new MusteriManager();
            manager.MusteriSil(musteribilgi);
            manager.MusteriListele(musteribilgi, musteribilgi2, musteribilgi3);
            manager.MusteriEkle(musteribilgi4);
          
            Console.ReadLine();
        }
    }
}
