using System;
using System.Collections.Generic;
using System.Text;

namespace OrnekUygulama2
{
    class BasvuruManager
    {

        public void KrediBilgilendirme(List<ICreditManager> creditManagers)
        {
            foreach (ICreditManager credits in creditManagers)
            {
                credits.Calculate();
                credits.InterestRate();
                Console.WriteLine("------------------------");
            }
        }
    }
}
