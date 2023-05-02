using System;
using System.Collections.Generic;
namespace IDataBase
{
    class Program
    {
        static void Main(string[] args)
        {
            IDataBaseService sqlServer = new SqlDataServer();
            IDataBaseService mySqlServer = new MySqlDataServer();
            List<IDataBaseService> data = new List<IDataBaseService>
            {
                sqlServer, mySqlServer
            
            };

            ToInform toInform = new ToInform();
            toInform.DataServerToInform(data);

            Console.ReadLine();
        }
    }
}
