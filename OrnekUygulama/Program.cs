using System;
using System.Collections.Generic;

namespace OrnekUygulama
{
    class Program
    {
        static void Main(string[] args)
        {
            ConstructionEngineer insaatMuhendis = new ConstructionEngineer();
            Expert usta = new Expert();
            EmploCalisan isci = new EmploCalisan();

            List<IEmployeePartner> ortak = new List<IEmployeePartner>()
            {
                insaatMuhendis,usta,isci
            };

            EmployeeManager employeeManager = new EmployeeManager();
            employeeManager.IslemManager(ortak);
            Console.ReadLine();
        }
    }
}
