using System;
using System.Collections.Generic;
using System.Text;

namespace OrnekUygulama2
{
    class HouseCredit : ICreditManager //konut kredisi
    {
        public void Calculate()
        {
            Console.WriteLine("Konut kredisi hesaplandı");
        }

        public void InterestRate()
        {
            Console.WriteLine("Konut kredisi faiz oranı 1.05");
        }
    }
}
