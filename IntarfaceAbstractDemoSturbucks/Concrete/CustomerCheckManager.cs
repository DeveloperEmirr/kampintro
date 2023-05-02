using IntarfaceAbstractDemoSturbucks.Abstract;
using IntarfaceAbstractDemoSturbucks.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace IntarfaceAbstractDemoSturbucks.Concrete
{
    public class CustomerCheckManager : IPersonCheckService
    {
        public bool CheckIfRealPerson(Customer customer)
        {
            return true;

        }
    }
}
