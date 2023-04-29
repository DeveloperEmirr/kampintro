using System;
using System.Collections.Generic;

namespace OrnekUygulama2
{
    class Program
    {
        static void Main(string[] args)
        {
            ICreditManager personelCredit = new PersonelCredit();
            ICreditManager carCredit = new CardCredit();
            ICreditManager houseCredit = new HouseCredit();
            ICreditManager maritalCredit = new MaritalCredit();
            ICreditManager businessCredit = new BusinessCredit();
            ICreditManager studentCredit = new StudentCredit();

            List<ICreditManager> Credits = new List<ICreditManager>()
            {
                personelCredit,carCredit,houseCredit
            };

            BasvuruManager basvuruManager = new BasvuruManager();
            basvuruManager.KrediBilgilendirme(Credits);

            Console.ReadLine();
                
        }
    }
}
