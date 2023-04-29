using System;
using System.Collections.Generic;
using System.Text;

namespace OrnekUygulama2
{
    class CardCredit:ICreditManager //Araç Kredisi
    {
        public void Calculate()
        {
            Console.WriteLine("Araç kredisi hesaplandı");
        }

        public void InterestRate()
        {
            Console.WriteLine("Araç kredisi faiz oranı 1.25");
        }
    }
}
