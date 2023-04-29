using System;
using System.Collections.Generic;
using System.Text;

namespace OrnekUygulama2
{
    class PersonelCredit : ICreditManager //İhtiyaç Kredisi
    {
        public void Calculate()
        {
            Console.WriteLine("İhtiyaç kredisi hesaplandı");
        }

        public void InterestRate()
        {
            Console.WriteLine("İhtiyaç kredisi faiz oranı 1.65");
        }
    }
}
