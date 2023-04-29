using System;
using System.Collections.Generic;
using System.Text;

namespace OrnekUygulama
{
    class EmployeeManager
    {

        public void IslemManager(List<IEmployeePartner> partner)
        {
            foreach (IEmployeePartner employeePartner in partner)
            {
                employeePartner.MealFee();
            }
        }

    }

}
