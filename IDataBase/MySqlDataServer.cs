using System;
using System.Collections.Generic;
using System.Text;

namespace IDataBase
{
    class MySqlDataServer:IDataBaseService
    {
        public void Add()
        {
            Console.WriteLine("Veriler MySql Data Server 'a Eklendi...");
        }
    }
}
