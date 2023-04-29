using System;
using System.Collections.Generic;
using System.Text;

namespace OrnekUygulama2
{
    class StudentCredit : ICreditManager // öğrenci kredisi
    {
        public void Calculate()
        {
            Console.WriteLine("Öğrenci kredisi hesaplandı");
        }

        public void InterestRate()
        {
            Console.WriteLine("Öğrenci kredisi faiz oranı 0.65");
        }
    }
}
