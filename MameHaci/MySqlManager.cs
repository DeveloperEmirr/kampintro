using System;
using System.Collections.Generic;
using System.Text;

namespace MameHaci
{
    class MySqlManager : IDataBaseService
    {
        public void Add()
        {
            Console.WriteLine("Veriler MySql Servera Eklendi.");
        }

        public void Delete()
        {
            Console.WriteLine("Veriler MySql Serverda Silindi.");
        }

        public void Update()
        {
            Console.WriteLine("Veriler MySql Serverda Güncellendi.");
        }
    }
}
