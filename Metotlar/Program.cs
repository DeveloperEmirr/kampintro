using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            Urun urun1 = new Urun();
            urun1.Adi = "Elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "Amasya Elması";

            Urun urun2 = new Urun();
            urun2.Adi = "Karpuz";
            urun2.Fiyati = 80;
            urun2.Aciklama = "Diyarbakır Karpuzu";

            Urun[] urunler = new Urun[]
            {
                urun1,urun2
            };// ürün1 deki ve ürün2 deki tüm verileri oraya koyduk

            foreach (Urun datalar in urunler)
            {
                Console.WriteLine(datalar.Adi+"  "+datalar.Fiyati+" TL  "+datalar.Aciklama);
            }

            Console.WriteLine("-----------------Metotlar---------------------");
            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);

            sepetManager.Ekle2("armut","yeşil armut",12);
            Console.ReadLine();
        }
    }
}

//tekrar tekrar kullanılabilir ortam sağlar metotlar. // dont repeat yourself -DRY --clean code- best practice


