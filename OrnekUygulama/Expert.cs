using System;
using System.Collections.Generic;
using System.Text;

namespace OrnekUygulama
{
    class Expert: IEmployeePartner, IEmployeeService, IEmployeeFacility //usta
    {
        public void Control() //kontrol işlemi
        {
            Console.WriteLine("Usta için kontrol işlemi gerçekleşti");
        }
        public void RoadToll() //yol ücreti
        {
            Console.WriteLine("Usta için yol ücreti işlemi gerçekleşti");

        }
        public void MealFee()// yemek ücreti
        {
            Console.WriteLine("Usta için yemek ücreti işlemi gerçekleşti");

        }
        public void Command() // komut verme işlemi

        {
            Console.WriteLine("Usta için komut verme işlemi gerçekleşti");

        }
    }
}
