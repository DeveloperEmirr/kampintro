using System;
using System.Collections.Generic;
using System.Text;

namespace OrnekUygulama2
{
    class BusinessCredit : ICreditManager //esnaf kredisi

    {
        public void Calculate()
        {
            Console.WriteLine("Esnaf kredisi hesaplandı");
        }

        public void InterestRate()
        {
            Console.WriteLine("Esnaf kredisi faiz oranı 0.98");
        }
    }
}
