using System;
using System.Collections.Generic;

namespace Intarfaces
{
    class Program
    {
        //interface new'lenemez.
        static void Main(string[] args)
        {
            IPersonManager personManager = new CustomerManager();
            IPersonManager employeeManager = new EmployeeManager();


           
            List<IPersonManager> personManagers = new List<IPersonManager>
            {
                personManager,employeeManager
            };

            ProcejtManager procejtManager = new ProcejtManager();
            procejtManager.Add(personManagers);

            Console.ReadLine();
        }
    }

    interface IPersonManager
    {
        void Add();
        void Update();

    }

    class CustomerManager : IPersonManager
    {
        public void Add()
        {
            //müşteri ekleme kodlarıu
            Console.WriteLine("Müşteri Eklendi");
        }

        public void Update()
        {
            Console.WriteLine("Müşteri Güncellendi");
        }
    }
    class EmployeeManager : IPersonManager
    {
        public void Add()
        {
            //personel ekleme kodlarıu
            Console.WriteLine("Personel Eklendi");
        }
        public void Update()
        {
            Console.WriteLine("Personel Güncellendi");
        }

    }

    class ProcejtManager
    {
        public void Add(List<IPersonManager> personManagers)
        {
            foreach (IPersonManager data in personManagers)
            {
                data.Add();
            }
        }
    }
}
