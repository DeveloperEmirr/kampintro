using System;
using System.Collections.Generic;
using System.Text;

namespace IDataBase
{
    class ToInform
    {

        public void DataServerToInform(List<IDataBaseService> dataBaseServices)
        {
            foreach (IDataBaseService data in dataBaseServices)
            {
                data.Add();
            }
        }
    }
}
