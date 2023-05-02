using System;
using System.Collections.Generic;
using System.Text;
using IntarfaceAbstractDemoSturbucks.Abstract;
using IntarfaceAbstractDemoSturbucks.Entities;

namespace IntarfaceAbstractDemoSturbucks.Concrete
{
    public class SturbucksCustomerManager : BaseCustomerManager
    {
        private IPersonCheckService _personCheckService;
        public override void Save(Customer customer)
        {
            if (_personCheckService.CheckIfRealPerson(customer)==true)
            {
                base.Save(customer);
            }
            throw new Exception("Geçerli bir kişi değil");
        }

    }
}
