using System;
using System.Collections.Generic;
using System.Text;

namespace MameHaci
{
    class MSqlServerManager : IDataBaseService
    {
        public void Add()
        {
            Console.WriteLine("Veriler MS Sql Servera Eklendi.");
        }

        public void Delete()
        {
            Console.WriteLine("Veriler MS Sql Servera Silindi.");
        }

        public void Update()
        {
            Console.WriteLine("Veriler MS Sql Servera Güncellendi.");
        }
    }
}
