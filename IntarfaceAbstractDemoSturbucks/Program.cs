using System;
using IntarfaceAbstractDemoSturbucks.Abstract;
using IntarfaceAbstractDemoSturbucks.Entities;
using IntarfaceAbstractDemoSturbucks.Concrete;
namespace IntarfaceAbstractDemoSturbucks
{
    class Program
    {
        static void Main(string[] args)
        {
            BaseCustomerManager baseCustomerManager = new NeroCustomerManager();
            baseCustomerManager.Save(new Customer
            { FirstName="Emircan",
                LastName="Yılmaz",
                NationalityId="12345678988",
                DateOfBirth=new DateTime(2001,11,11)
            });
            
        }
    }

}
