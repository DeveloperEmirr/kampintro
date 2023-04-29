using System;
using System.Collections.Generic;
using System.Text;

namespace OrnekUygulama
{
    class ConstructionEngineer: IEmployeePartner, IEmployeeService // inşaat mühendisi
    {
        public void Control() //kontrol işlemi
        {
            Console.WriteLine("İnşaat mühendisi için kontrol işlemi gerçekleşti");

        }
        public void RoadToll() //yol ücreti
        {
            Console.WriteLine("İnşaat mühendisi için yol ücreti işlemi gerçekleşti");

        }
        public void MealFee()// yemek ücreti
        {
            Console.WriteLine("İnşaat mühendisi için yemek ücreti işlemi gerçekleşti");

        }
    }
}
