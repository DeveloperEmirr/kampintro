using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            IKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();
            IKrediManager tasitKrediManager = new TasitKrediManager();
            IKrediManager konutKrediManager = new KonutKrediManager();

            IloggerService databaseLoggerService = new DatabaseLoggerService();
            FileLoggerService fileLoggerService = new FileLoggerService();

            BasvuruManager basvuruManager = new BasvuruManager();
            //basvuruManager.BasvuruYap(ihtiyacKrediManager, fileLoggerService);

            List<IKrediManager> krediler = new List<IKrediManager>()
            {
               ihtiyacKrediManager, tasitKrediManager
            };

            basvuruManager.KrediOnbilgilendirmesiYap(krediler);
            Console.Read();
        }
    }
}
