using System;

namespace GenericsIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<string> isimler = new MyList<string>();
            isimler.Add("Emircan");
            isimler.Add("Ela");
            Console.WriteLine("dizinin uzunluğu : "+isimler.Length);

            //aşağıda dizideki elemanları ekrana yazdırma işlemi yaptık
            foreach (var isim in isimler.Items)
            {
                Console.WriteLine(isim);
            }
        }
    }
}
