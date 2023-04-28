using System;

namespace ReferenceTpes
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person();
            Person person2 = new Person();
            person2.FirstName = "Elanur";
            person1.FirstName = "Emir";
            person2 = person1;

            Console.WriteLine(person2.FirstName);
            Customer customer = new Customer();
            customer.FirstName = "Eylül";

            person2 = customer;

            PersonManager personManager = new PersonManager();
            personManager.Add(person2);
            
            Console.Read();
        }
    }

    class Person
    {

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }

    class Customer:Person
    {
        public string CrediCardNumber { get; set; }
    }

    class Employee
    {
        public string OneNumber { get; set; }
    }

    class PersonManager:Person
    {
        public void Add(Person person)
        {
            Console.WriteLine(person.FirstName);
        }
    }
}
