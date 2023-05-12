using System;
using System.Collections.Generic;
using System.Text;

namespace MameHaci
{
    class DataManager
    {

        public void DataBilgilendirme(List<IDataBaseService> veriler)
        {
            foreach (IDataBaseService data in veriler)
            {
                data.Delete();
            }
        }
    }
}
