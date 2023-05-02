using System;
using System.Collections.Generic;
using System.Text;

namespace IDataBase
{
    class SqlDataServer : IDataBaseService
    {
        public void Add()
        {
            Console.WriteLine("Veriler Sql Data Server 'a Eklendi...");
        }
    }
}
