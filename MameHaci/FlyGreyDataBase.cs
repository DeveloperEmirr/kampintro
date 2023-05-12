using System;
using System.Collections.Generic;
using System.Text;

namespace MameHaci
{
    class FlyGreyDataBase : IDataBaseService
    {
        public void Add()
        {
            Console.WriteLine("FlyGreyDataBase 'e eklendi");
        }

        public void Delete()
        {
            Console.WriteLine("FlyGreyDataBase silindi");
        }

        public void Update()
        {
            Console.WriteLine("FlyGreyDataBase güncellendi");
        }
    }
}
