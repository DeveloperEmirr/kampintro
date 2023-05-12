using System;
using System.Collections.Generic;
using System.Text;

namespace MameHaci
{
    class OracleServerManager : IDataBaseService
    {
        public void Add()
        {
            Console.WriteLine("Veriler OracleServer Servera Eklendi.");
        }

        public void Delete()
        {
            Console.WriteLine("Veriler OracleServer Servera Silindi.");
        }

        public void Update()
        {
            Console.WriteLine("Veriler OracleServer Servera Güncellendi.");
        }
    }
}
