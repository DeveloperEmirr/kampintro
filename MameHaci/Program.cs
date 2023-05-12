using System;
using System.Collections.Generic;

namespace MameHaci
{
    class Program
    {
        static void Main(string[] args)
        {
            IDataBaseService mySqlServer = new MySqlManager();

            List<IDataBaseService> Datalar = new List<IDataBaseService>
            {
            mySqlServer,new MSqlServerManager(),new FlyGreyDataBase()
            };

            DataManager dataManager = new DataManager();
            dataManager.DataBilgilendirme(Datalar);
            Console.ReadLine();
        }
    }
}
