using IntarfaceAbstractDemoSturbucks.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace IntarfaceAbstractDemoSturbucks.Abstract
{
    public abstract class BaseCustomerManager : ICustomerService
    {
        public virtual void Save(Customer customer)
        {
            Console.WriteLine("Veri Tabanına Kaydedildi : "+customer.FirstName);
        }
    }
}
