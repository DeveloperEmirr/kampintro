using System;
using System.Collections.Generic;
using System.Text;

namespace OrnekUygulama2
{
    class MaritalCredit: ICreditManager //evlilik kredisi
    {
        public void Calculate()
        {
            Console.WriteLine("Evlilik kredisi hesaplandı");
        }

        public void InterestRate()
        {
            Console.WriteLine("Evlilik kredisi faiz oranı 1.26");
        }
    }
}
