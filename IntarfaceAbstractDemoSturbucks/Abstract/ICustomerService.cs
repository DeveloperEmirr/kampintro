using IntarfaceAbstractDemoSturbucks.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace IntarfaceAbstractDemoSturbucks.Abstract
{
    public interface ICustomerService
    {

        void Save(Customer customer);
    }
}
